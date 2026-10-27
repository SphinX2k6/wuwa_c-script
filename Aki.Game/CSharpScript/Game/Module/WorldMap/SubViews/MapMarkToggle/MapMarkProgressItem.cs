using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004802 RID: 18434
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapMarkProgressItem : GridProxyAbstract<IMapMarkProgressItemData>
	{
		// Token: 0x06030458 RID: 197720 RVA: 0x00B32868 File Offset: 0x00B30A68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030459 RID: 197721 RVA: 0x00B328F4 File Offset: 0x00B30AF4
		[NullableContext(1)]
		public override void Refresh(IMapMarkProgressItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(data.NameId);
			}
			float progress = data.Progress;
			UUISliderComponent slider = base.GetSlider(2);
			if (slider != null)
			{
				slider.SetMinValue(data.ProgressMin, false, false);
				slider.SetMaxValue(data.ProgressMax, false, false);
				slider.SetValue(progress, true);
				slider.OnValueChangeCb.Bind(new Action<float>(this.SetProgressCallback));
			}
			float num = progress / this.DataParam.ProgressMax * 100f;
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(num.ToString("F0"), true);
		}

		// Token: 0x0603045A RID: 197722 RVA: 0x00B329A0 File Offset: 0x00B30BA0
		private void SetProgressCallback(float progress)
		{
			IMapMarkProgressItemData dataParam = this.DataParam;
			if (dataParam != null)
			{
				Action<float> setProgressCallback = dataParam.SetProgressCallback;
				if (setProgressCallback != null)
				{
					setProgressCallback(progress);
				}
			}
			float num = progress / this.DataParam.ProgressMax * 100f;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString("F0"), true);
		}

		// Token: 0x04019FB1 RID: 106417
		[Nullable(2)]
		private IMapMarkProgressItemData DataParam;

		// Token: 0x0200AAD3 RID: 43731
		public static class EChildType
		{
			// Token: 0x04033F3A RID: 212794
			public const int TextName = 0;

			// Token: 0x04033F3B RID: 212795
			public const int TextSettingNum = 1;

			// Token: 0x04033F3C RID: 212796
			public const int Slider = 2;
		}
	}
}
