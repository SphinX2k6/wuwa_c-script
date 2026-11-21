using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005987 RID: 22919
	public class SolarSchoolBagAttrItem : GridProxyAbstract<SolarSchoolAttrDeltaItemData>
	{
		// Token: 0x06038825 RID: 231461 RVA: 0x00FCF378 File Offset: 0x00FCD578
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038826 RID: 231462 RVA: 0x00FCF424 File Offset: 0x00FCD624
		public override void Refresh(SolarSchoolAttrDeltaItemData data, bool isSelected, int gridIndex)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(instance.PlayerData.IsAttrImportant(data.Attr));
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(data.Attr);
			if (attrConfig == null)
			{
				return;
			}
			SolarSchoolAttr value = attrConfig.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			base.SetTextureByPath(value.YellowIconSmall, base.GetTexture(0), null, null);
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolUtils.GetAttrDeltaText(data.Attr, data.Delta), true);
		}

		// Token: 0x0200B529 RID: 46377
		private class EComponents
		{
			// Token: 0x04038025 RID: 229413
			public const int TexIcon = 0;

			// Token: 0x04038026 RID: 229414
			public const int TxtName = 1;

			// Token: 0x04038027 RID: 229415
			public const int TxtValue = 2;

			// Token: 0x04038028 RID: 229416
			public const int SprScratch = 3;
		}
	}
}
