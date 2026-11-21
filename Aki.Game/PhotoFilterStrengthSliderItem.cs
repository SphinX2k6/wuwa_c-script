using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A56 RID: 6742
public class PhotoFilterStrengthSliderItem : UiPanelBase
{
	// Token: 0x17001933 RID: 6451
	// (get) Token: 0x06010A46 RID: 68166 RVA: 0x004DE9B1 File Offset: 0x004DCBB1
	[Nullable(2)]
	private FilterSettingViewModel ParentViewModel
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as FilterSettingViewModel;
		}
	}

	// Token: 0x06010A47 RID: 68167 RVA: 0x004DE9C0 File Offset: 0x004DCBC0
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

	// Token: 0x06010A48 RID: 68168 RVA: 0x004DEA53 File Offset: 0x004DCC53
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
	}

	// Token: 0x06010A49 RID: 68169 RVA: 0x004DEA77 File Offset: 0x004DCC77
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x06010A4A RID: 68170 RVA: 0x004DEA90 File Offset: 0x004DCC90
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

	// Token: 0x06010A4B RID: 68171 RVA: 0x004DEAF9 File Offset: 0x004DCCF9
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

	// Token: 0x06010A4C RID: 68172 RVA: 0x004DEB20 File Offset: 0x004DCD20
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

	// Token: 0x06010A4D RID: 68173 RVA: 0x004DEB78 File Offset: 0x004DCD78
	private void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterParamChanged(EFilterSettingValueIndex.Intensity));
	}

	// Token: 0x02007CD5 RID: 31957
	private enum EComponents
	{
		// Token: 0x040286C9 RID: 165577
		TextValue,
		// Token: 0x040286CA RID: 165578
		Slider,
		// Token: 0x040286CB RID: 165579
		SpriteHandle,
		// Token: 0x040286CC RID: 165580
		SpriteNormalBg,
		// Token: 0x040286CD RID: 165581
		SpriteTempBg,
		// Token: 0x040286CE RID: 165582
		ItemFillArea,
		// Token: 0x040286CF RID: 165583
		ToggleRoot,
		// Token: 0x040286D0 RID: 165584
		TextName,
		// Token: 0x040286D1 RID: 165585
		BtnReset,
		// Token: 0x040286D2 RID: 165586
		ItemLock
	}
}
