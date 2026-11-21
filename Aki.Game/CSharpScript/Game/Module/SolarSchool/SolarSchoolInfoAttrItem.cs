using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AF RID: 22959
	public class SolarSchoolInfoAttrItem : GridProxyAbstract<SolarSchoolInfoAttrData>
	{
		// Token: 0x060389A0 RID: 231840 RVA: 0x00FD63F0 File Offset: 0x00FD45F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389A1 RID: 231841 RVA: 0x00FD64E0 File Offset: 0x00FD46E0
		public override void Refresh(SolarSchoolInfoAttrData data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.IsAttrImportant(data.Attr));
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
			base.TrySetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			base.TrySetTextureByPath(data.RankIconPath, base.GetTexture(1), null, null);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.Value.ToString(), true);
			}
			UUISliderComponent slider = base.GetSlider(4);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(data.RankRatio, true);
		}

		// Token: 0x0200B55A RID: 46426
		private class EComponents
		{
			// Token: 0x04038127 RID: 229671
			public const int TexIcon = 0;

			// Token: 0x04038128 RID: 229672
			public const int TexScore = 1;

			// Token: 0x04038129 RID: 229673
			public const int TxtName = 2;

			// Token: 0x0403812A RID: 229674
			public const int TxtValue = 3;

			// Token: 0x0403812B RID: 229675
			public const int SldHorDefault = 4;

			// Token: 0x0403812C RID: 229676
			public const int SprScratch = 5;
		}
	}
}
