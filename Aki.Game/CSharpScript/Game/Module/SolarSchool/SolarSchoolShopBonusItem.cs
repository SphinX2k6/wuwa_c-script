using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A07 RID: 23047
	public class SolarSchoolShopBonusItem : GridProxyAbstract<SolarSchoolShopBonusItemData>
	{
		// Token: 0x06038C01 RID: 232449 RVA: 0x00FE25D4 File Offset: 0x00FE07D4
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

		// Token: 0x06038C02 RID: 232450 RVA: 0x00FE2680 File Offset: 0x00FE0880
		public override void Refresh(SolarSchoolShopBonusItemData data, bool isSelected, int gridIndex)
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
			base.SetTextureByPath(attrConfig.Value.YellowIconSmall, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), attrConfig.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolUtils.GetAttrDeltaText(data.Attr, data.Value), true);
		}

		// Token: 0x0200B5B7 RID: 46519
		private class EComponent
		{
			// Token: 0x04038312 RID: 230162
			public const int TexIcon = 0;

			// Token: 0x04038313 RID: 230163
			public const int TxtName = 1;

			// Token: 0x04038314 RID: 230164
			public const int TxtValue = 2;

			// Token: 0x04038315 RID: 230165
			public const int SprScratch = 3;
		}
	}
}
