using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005457 RID: 21591
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BasicGraphicSettingSliderItem : GridProxyAbstract<BasicGraphicSettingSliderData>
	{
		// Token: 0x060371DD RID: 225757 RVA: 0x00D1071C File Offset: 0x00D0E91C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
		}

		// Token: 0x060371DE RID: 225758 RVA: 0x00D107A4 File Offset: 0x00D0E9A4
		protected override void OnStart()
		{
			this.LongPressAdd = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(1)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnAdd));
			this.LongPressReduce = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(0)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnReduce));
			this.LongPressAdd.ShouldPlayLongPressSound = true;
			this.LongPressReduce.ShouldPlayLongPressSound = true;
			this.Slider = base.GetSlider(2);
			this.Slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChange));
		}

		// Token: 0x060371DF RID: 225759 RVA: 0x00D1084E File Offset: 0x00D0EA4E
		protected override void OnBeforeDestroy()
		{
			this.LongPressAdd.ShouldPlayLongPressSound = false;
			this.LongPressReduce.ShouldPlayLongPressSound = false;
			this.LongPressAdd.Clear();
			this.LongPressReduce.Clear();
			this.LongPressAdd = null;
			this.LongPressReduce = null;
		}

		// Token: 0x060371E0 RID: 225760 RVA: 0x00D1088C File Offset: 0x00D0EA8C
		[NullableContext(1)]
		public override void Refresh(BasicGraphicSettingSliderData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), data.Title, Array.Empty<object>());
			UUISliderComponent slider = base.GetSlider(2);
			slider.SetMaxValue(data.MaxValue, true, false);
			slider.SetMinValue(data.MinValue, true, false);
			slider.SetValue(data.CurValue, true);
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(data.MenuData, data.CurValue);
			base.GetText(3).SetText(sliderDisplayValue.ToString(), true);
		}

		// Token: 0x060371E1 RID: 225761 RVA: 0x00D10914 File Offset: 0x00D0EB14
		private void OnReduce(bool _)
		{
			if (this.Data == null)
			{
				return;
			}
			float actualSliderStep = FunctionItemViewTool.GetActualSliderStep(this.Data.MenuData, 1f);
			float inValue = Math.Max(this.Data.CurValue - actualSliderStep, this.Data.MinValue);
			this.Slider.SetValue(inValue, true);
		}

		// Token: 0x060371E2 RID: 225762 RVA: 0x00D1096C File Offset: 0x00D0EB6C
		private void OnAdd(bool _)
		{
			if (this.Data == null)
			{
				return;
			}
			float actualSliderStep = FunctionItemViewTool.GetActualSliderStep(this.Data.MenuData, 1f);
			float inValue = Math.Min(this.Data.CurValue + actualSliderStep, this.Data.MaxValue);
			this.Slider.SetValue(inValue, true);
		}

		// Token: 0x060371E3 RID: 225763 RVA: 0x00D109C4 File Offset: 0x00D0EBC4
		private void OnValueChange(float value)
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OnChangeValue(value);
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(this.Data.MenuData, value);
			base.GetText(3).SetText(sliderDisplayValue.ToString(), true);
		}

		// Token: 0x0401D142 RID: 119106
		private BasicGraphicSettingSliderData Data;

		// Token: 0x0401D143 RID: 119107
		private LongPressButtonItem LongPressAdd;

		// Token: 0x0401D144 RID: 119108
		private LongPressButtonItem LongPressReduce;

		// Token: 0x0401D145 RID: 119109
		private UUISliderComponent Slider;
	}
}
