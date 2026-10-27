using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200256B RID: 9579
public class PhotoFilterStrengthSliderItem : UiPanelBase
{
	// Token: 0x170018F9 RID: 6393
	// (get) Token: 0x06013564 RID: 79204 RVA: 0x004CFD79 File Offset: 0x004CDF79
	[Nullable(2)]
	private FilterSettingViewModel ParentViewModel
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as FilterSettingViewModel;
		}
	}

	// Token: 0x06013565 RID: 79205 RVA: 0x004CFD88 File Offset: 0x004CDF88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnResetClick))
		};
	}

	// Token: 0x06013566 RID: 79206 RVA: 0x004CFE1B File Offset: 0x004CE01B
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
	}

	// Token: 0x06013567 RID: 79207 RVA: 0x004CFE3F File Offset: 0x004CE03F
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x06013568 RID: 79208 RVA: 0x004CFE58 File Offset: 0x004CE058
	private void OnSliderValueChanged(float value)
	{
		if (this.ParentViewModel != null && !this.ParentViewModel.IsPropertyDirty(2))
		{
			this.ParentViewModel.IntensityNormalized = value;
			Action onSliderChanged = this.ParentViewModel.OnSliderChanged;
			if (onSliderChanged != null)
			{
				onSliderChanged();
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(this.ParentViewModel.IntensityString, true);
			}
			this.RefreshResetBtn();
		}
	}

	// Token: 0x06013569 RID: 79209 RVA: 0x004CFEC1 File Offset: 0x004CE0C1
	private void OnResetClick()
	{
		FilterSettingViewModel parentViewModel = this.ParentViewModel;
		if (parentViewModel != null)
		{
			Action<EFilterSettingValueIndex> onResetSingleParamClick = parentViewModel.OnResetSingleParamClick;
			if (onResetSingleParamClick != null)
			{
				onResetSingleParamClick(EFilterSettingValueIndex.Intensity);
			}
		}
		this.RefreshByViewModel();
	}

	// Token: 0x0601356A RID: 79210 RVA: 0x004CFEE8 File Offset: 0x004CE0E8
	public void RefreshByViewModel()
	{
		if (this.ParentViewModel == null)
		{
			return;
		}
		UUISliderComponent slider = base.GetSlider(1);
		if (slider != null)
		{
			slider.SetValue(this.ParentViewModel.IntensityNormalized, false);
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(this.ParentViewModel.IntensityString, true);
		}
		this.RefreshResetBtn();
	}

	// Token: 0x0601356B RID: 79211 RVA: 0x004CFF40 File Offset: 0x004CE140
	private void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterParamChanged(EFilterSettingValueIndex.Intensity));
	}

	// Token: 0x02008B4F RID: 35663
	private enum EComponents
	{
		// Token: 0x0402D3BC RID: 185276
		TextValue,
		// Token: 0x0402D3BD RID: 185277
		Slider,
		// Token: 0x0402D3BE RID: 185278
		SpriteHandle,
		// Token: 0x0402D3BF RID: 185279
		SpriteNormalBg,
		// Token: 0x0402D3C0 RID: 185280
		SpriteTempBg,
		// Token: 0x0402D3C1 RID: 185281
		ItemFillArea,
		// Token: 0x0402D3C2 RID: 185282
		ToggleRoot,
		// Token: 0x0402D3C3 RID: 185283
		TextName,
		// Token: 0x0402D3C4 RID: 185284
		BtnReset,
		// Token: 0x0402D3C5 RID: 185285
		ItemLock
	}
}
