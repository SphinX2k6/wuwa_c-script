using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C8 RID: 22984
	public class SolarSchoolBehaviorDonePopupItem : GridProxyAbstract<SolarSchoolBehaviorDoneAttrData>
	{
		// Token: 0x06038A60 RID: 232032 RVA: 0x00FDA138 File Offset: 0x00FD8338
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A61 RID: 232033 RVA: 0x00FDA248 File Offset: 0x00FD8448
		public override void Refresh(SolarSchoolBehaviorDoneAttrData data, bool isSelected, int gridIndex)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetUIActive(instance.PlayerData.IsAttrImportant(data.Attr));
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(data.Attr);
			if (attrConfig == null)
			{
				return;
			}
			base.SetTextureByPath(attrConfig.Value.IconSmall, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), attrConfig.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(SolarSchoolUtils.GetAttrValueText(data.Attr, data.OldValue), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(SolarSchoolUtils.GetAttrValueText(data.Attr, data.NewValue), true);
			}
			int delta = data.NewValue - data.OldValue;
			UUIText text3 = base.GetText(4);
			if (text3 != null)
			{
				text3.SetText(SolarSchoolUtils.GetAttrDeltaText(data.Attr, delta), true);
			}
			UUITexture texture = base.GetTexture(5);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(gridIndex % 2 == 0);
		}

		// Token: 0x0200B578 RID: 46456
		private class EComponents
		{
			// Token: 0x040381D7 RID: 229847
			public const int TexIcon = 0;

			// Token: 0x040381D8 RID: 229848
			public const int TxtName = 1;

			// Token: 0x040381D9 RID: 229849
			public const int TxtOldValue = 2;

			// Token: 0x040381DA RID: 229850
			public const int TxtNewValue = 3;

			// Token: 0x040381DB RID: 229851
			public const int TxtGainValue = 4;

			// Token: 0x040381DC RID: 229852
			public const int TexBg = 5;

			// Token: 0x040381DD RID: 229853
			public const int SprScratch = 6;
		}
	}
}
