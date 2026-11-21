using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003733 RID: 14131
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapMarkProgressItem : GridProxyAbstract<IMapMarkProgressItemData>
	{
		// Token: 0x06024C28 RID: 150568 RVA: 0x00A627D0 File Offset: 0x00A609D0
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

		// Token: 0x06024C29 RID: 150569 RVA: 0x00A6285C File Offset: 0x00A60A5C
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

		// Token: 0x06024C2A RID: 150570 RVA: 0x00A62908 File Offset: 0x00A60B08
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

		// Token: 0x04014665 RID: 83557
		[Nullable(2)]
		private IMapMarkProgressItemData DataParam;

		// Token: 0x02009484 RID: 38020
		public static class EChildType
		{
			// Token: 0x0402E6BD RID: 190141
			public const int TextName = 0;

			// Token: 0x0402E6BE RID: 190142
			public const int TextSettingNum = 1;

			// Token: 0x0402E6BF RID: 190143
			public const int Slider = 2;
		}
	}
}
