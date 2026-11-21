using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A3A RID: 23098
	public class SolarSchoolSpecialBehaviorConditionItem : GridProxyAbstract<SolarSchoolAttrRequire?>
	{
		// Token: 0x06038F48 RID: 233288 RVA: 0x00FF4C4C File Offset: 0x00FF2E4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038F49 RID: 233289 RVA: 0x00FF4D7C File Offset: 0x00FF2F7C
		public override void Refresh(SolarSchoolAttrRequire? data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(data != null);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(data == null);
			}
			if (data == null)
			{
				return;
			}
			SolarSchoolAttrRequire value = data.Value;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(value.Attr);
			if (attrConfig == null)
			{
				return;
			}
			int attr = instance.PlayerData.GetAttr(value.Attr);
			bool flag = attr >= value.RequireValue;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), attrConfig.Value.Name, Array.Empty<object>());
			base.SetTextureByPath(flag ? attrConfig.Value.IconReach : attrConfig.Value.IconNotReach, base.GetTexture(1), null, null);
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew(flag ? "SolarSchool_Tepi_3" : "SolarSchool_Tepi_2", null) ?? string.Empty, attr, value.RequireValue), true);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(flag);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(!flag);
			}
			UUISprite sprite3 = base.GetSprite(0);
			if (sprite3 != null)
			{
				UUIItem uuiitem = sprite3;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(sprite3.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
		}

		// Token: 0x0200B642 RID: 46658
		private class EComponents
		{
			// Token: 0x04038614 RID: 230932
			public const int SprBg = 0;

			// Token: 0x04038615 RID: 230933
			public const int TexIcon = 1;

			// Token: 0x04038616 RID: 230934
			public const int SprAchieve = 2;

			// Token: 0x04038617 RID: 230935
			public const int SprNotAchieve = 3;

			// Token: 0x04038618 RID: 230936
			public const int TxtName = 4;

			// Token: 0x04038619 RID: 230937
			public const int TxtNum = 5;

			// Token: 0x0403861A RID: 230938
			public const int PnlContent = 6;

			// Token: 0x0403861B RID: 230939
			public const int PnlNone = 7;
		}
	}
}
