using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005900 RID: 22784
	public class SolarSchoolEventAttributeItem : UiPanelBase
	{
		// Token: 0x060382BD RID: 230077 RVA: 0x00FB38C4 File Offset: 0x00FB1AC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060382BE RID: 230078 RVA: 0x00FB3970 File Offset: 0x00FB1B70
		public void RefreshAttr(ESolarSchoolSecondAttr attrId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int attr = instance.PlayerData.GetAttr(attrId);
			SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(instance.ActivityId, (int)attrId);
			if (solarSchoolAttr == null)
			{
				return;
			}
			SolarSchoolAttr value = solarSchoolAttr.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			base.SetTextureByPath(value.YellowIconSmall, base.GetTexture(0), null, null);
			base.GetText(2).SetText(attr.ToString(), true);
			int num = SolarSchoolUtils.CalcAttrRankTier(value, attr);
			string text = (num < value.RankIconLength) ? value.RankIcon(num) : null;
			if (!string.IsNullOrEmpty(text))
			{
				base.SetTextureShowUntilLoaded(text, base.GetTexture(3), null);
				return;
			}
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0200B4BD RID: 46269
		private class EComponents
		{
			// Token: 0x04037E29 RID: 228905
			public const int TexIcon = 0;

			// Token: 0x04037E2A RID: 228906
			public const int TxtName = 1;

			// Token: 0x04037E2B RID: 228907
			public const int TxtValue = 2;

			// Token: 0x04037E2C RID: 228908
			public const int TexScore = 3;
		}
	}
}
