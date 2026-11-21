using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x0200443A RID: 17466
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BasicGraphicSettingSliderItem : GridProxyAbstract<BasicGraphicSettingSliderData>
	{
		// Token: 0x0602C126 RID: 180518 RVA: 0x00C5FB34 File Offset: 0x00C5DD34
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

		// Token: 0x0602C127 RID: 180519 RVA: 0x00C5FBBC File Offset: 0x00C5DDBC
		protected override void OnStart()
		{
			this.LongPressAdd = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(1)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnAdd));
			this.LongPressReduce = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(0)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnReduce));
			this.LongPressAdd.ShouldPlayLongPressSound = true;
			this.LongPressReduce.ShouldPlayLongPressSound = true;
			this.Slider = base.GetSlider(2);
			this.Slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChange));
		}

		// Token: 0x0602C128 RID: 180520 RVA: 0x00C5FC66 File Offset: 0x00C5DE66
		protected override void OnBeforeDestroy()
		{
			this.LongPressAdd.ShouldPlayLongPressSound = false;
			this.LongPressReduce.ShouldPlayLongPressSound = false;
			this.LongPressAdd.Clear();
			this.LongPressReduce.Clear();
			this.LongPressAdd = null;
			this.LongPressReduce = null;
		}

		// Token: 0x0602C129 RID: 180521 RVA: 0x00C5FCA4 File Offset: 0x00C5DEA4
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

		// Token: 0x0602C12A RID: 180522 RVA: 0x00C5FD2C File Offset: 0x00C5DF2C
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

		// Token: 0x0602C12B RID: 180523 RVA: 0x00C5FD84 File Offset: 0x00C5DF84
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

		// Token: 0x0602C12C RID: 180524 RVA: 0x00C5FDDC File Offset: 0x00C5DFDC
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

		// Token: 0x04017BDB RID: 97243
		private BasicGraphicSettingSliderData Data;

		// Token: 0x04017BDC RID: 97244
		private LongPressButtonItem LongPressAdd;

		// Token: 0x04017BDD RID: 97245
		private LongPressButtonItem LongPressReduce;

		// Token: 0x04017BDE RID: 97246
		private UUISliderComponent Slider;
	}
}
