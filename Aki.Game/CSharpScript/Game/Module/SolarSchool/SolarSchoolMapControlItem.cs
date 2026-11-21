using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E0 RID: 23008
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolMapControlItem : UiPanelBase
	{
		// Token: 0x06038AAF RID: 232111 RVA: 0x00FDC414 File Offset: 0x00FDA614
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038AB0 RID: 232112 RVA: 0x00FDC4A0 File Offset: 0x00FDA6A0
		protected override void OnStart()
		{
			this.LongPressAdd = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(0)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnPressAdd))
			{
				ShouldPlayLongPressSound = true
			};
			this.LongPressReduce = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(1)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnPressReduce))
			{
				ShouldPlayLongPressSound = true
			};
			UUISliderComponent slider = base.GetSlider(2);
			if (slider != null)
			{
				this.MinValue = slider.GetMinValue();
				this.MaxValue = slider.GetMaxValue();
				slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
				this.OnSliderValueChanged(slider.GetValue());
			}
		}

		// Token: 0x06038AB1 RID: 232113 RVA: 0x00FDC560 File Offset: 0x00FDA760
		protected override void OnBeforeDestroy()
		{
			UUISliderComponent slider = base.GetSlider(2);
			if (slider != null)
			{
				slider.OnValueChangeCb.Unbind();
			}
			LongPressButtonItem longPressAdd = this.LongPressAdd;
			if (longPressAdd != null)
			{
				longPressAdd.Clear();
			}
			this.LongPressAdd = null;
			LongPressButtonItem longPressReduce = this.LongPressReduce;
			if (longPressReduce != null)
			{
				longPressReduce.Clear();
			}
			this.LongPressReduce = null;
			this.ScaleChangedCallback = null;
		}

		// Token: 0x06038AB2 RID: 232114 RVA: 0x00FDC5BB File Offset: 0x00FDA7BB
		public void SetOnScaleChanged(Action<float> callback)
		{
			this.ScaleChangedCallback = callback;
		}

		// Token: 0x06038AB3 RID: 232115 RVA: 0x00FDC5C4 File Offset: 0x00FDA7C4
		public float GetValue()
		{
			UUISliderComponent slider = base.GetSlider(2);
			if (slider == null)
			{
				return 1f;
			}
			return slider.GetValue();
		}

		// Token: 0x06038AB4 RID: 232116 RVA: 0x00FDC5DC File Offset: 0x00FDA7DC
		public void SetValue(float value)
		{
			UUISliderComponent slider = base.GetSlider(2);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(MathUtils.Instance.Clamp(value, this.MinValue, this.MaxValue), true);
		}

		// Token: 0x06038AB5 RID: 232117 RVA: 0x00FDC608 File Offset: 0x00FDA808
		private void OnSliderValueChanged(float value)
		{
			LongPressButtonItem longPressAdd = this.LongPressAdd;
			if (longPressAdd != null)
			{
				longPressAdd.SetInteractive(value < this.MaxValue);
			}
			LongPressButtonItem longPressReduce = this.LongPressReduce;
			if (longPressReduce != null)
			{
				longPressReduce.SetInteractive(value > this.MinValue);
			}
			Action<float> scaleChangedCallback = this.ScaleChangedCallback;
			if (scaleChangedCallback == null)
			{
				return;
			}
			scaleChangedCallback(value);
		}

		// Token: 0x06038AB6 RID: 232118 RVA: 0x00FDC65A File Offset: 0x00FDA85A
		private void OnPressAdd(bool _)
		{
			this.SetValue(this.GetValue() + 0.1f);
		}

		// Token: 0x06038AB7 RID: 232119 RVA: 0x00FDC66E File Offset: 0x00FDA86E
		private void OnPressReduce(bool _)
		{
			this.SetValue(this.GetValue() - 0.1f);
		}

		// Token: 0x0401DD7F RID: 122239
		public const float ScaleStep = 0.1f;

		// Token: 0x0401DD80 RID: 122240
		private LongPressButtonItem LongPressAdd;

		// Token: 0x0401DD81 RID: 122241
		private LongPressButtonItem LongPressReduce;

		// Token: 0x0401DD82 RID: 122242
		private Action<float> ScaleChangedCallback;

		// Token: 0x0401DD83 RID: 122243
		private float MinValue = 1f;

		// Token: 0x0401DD84 RID: 122244
		private float MaxValue = 1f;

		// Token: 0x0200B58D RID: 46477
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038237 RID: 229943
			public const int BtnAdd = 0;

			// Token: 0x04038238 RID: 229944
			public const int BtnReduce = 1;

			// Token: 0x04038239 RID: 229945
			public const int VerticalSlider = 2;
		}
	}
}
