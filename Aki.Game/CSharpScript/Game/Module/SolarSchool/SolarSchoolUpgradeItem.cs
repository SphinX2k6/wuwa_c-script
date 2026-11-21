using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059DE RID: 23006
	public class SolarSchoolUpgradeItem : GridProxyAbstract<SolarSchoolAttrRankUpInfo>
	{
		// Token: 0x06038AA8 RID: 232104 RVA: 0x00FDC064 File Offset: 0x00FDA264
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038AA9 RID: 232105 RVA: 0x00FDC130 File Offset: 0x00FDA330
		public override void Refresh(SolarSchoolAttrRankUpInfo data, bool isSelected, int gridIndex)
		{
			SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(data.Attr);
			if (attrConfig == null)
			{
				return;
			}
			SolarSchoolAttr value = attrConfig.Value;
			base.SetTextureByPath(value.YellowIconSmall, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.OldValue.ToString(), true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetText(data.NewValue.ToString(), true);
			}
			int num = SolarSchoolUtils.CalcAttrRankTier(value, data.NewValue);
			string text3 = (num < value.RankIconLength) ? value.RankIcon(num) : null;
			if (!string.IsNullOrEmpty(text3))
			{
				base.SetTextureShowUntilLoaded(text3, base.GetTexture(5), null);
				return;
			}
			UUITexture texture = base.GetTexture(5);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0200B58A RID: 46474
		private class EComponent
		{
			// Token: 0x04038228 RID: 229928
			public const int PnlSelf = 0;

			// Token: 0x04038229 RID: 229929
			public const int TexIcon = 1;

			// Token: 0x0403822A RID: 229930
			public const int TxtName = 2;

			// Token: 0x0403822B RID: 229931
			public const int TxtNumOld = 3;

			// Token: 0x0403822C RID: 229932
			public const int TxtNumNew = 4;

			// Token: 0x0403822D RID: 229933
			public const int TexLevel = 5;
		}
	}
}
