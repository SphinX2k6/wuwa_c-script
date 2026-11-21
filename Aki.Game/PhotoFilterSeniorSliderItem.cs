using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A54 RID: 6740
public class PhotoFilterSeniorSliderItem : GridProxyAbstract<FilterSeniorSetting>
{
	// Token: 0x06010A31 RID: 68145 RVA: 0x004DE31C File Offset: 0x004DC51C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnResetClick))
		};
	}

	// Token: 0x06010A32 RID: 68146 RVA: 0x004DE3F1 File Offset: 0x004DC5F1
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
	}

	// Token: 0x06010A33 RID: 68147 RVA: 0x004DE410 File Offset: 0x004DC610
	public override void Refresh(FilterSeniorSetting data, bool isSelected, int gridIndex)
	{
		this.FilterSeniorSetting = data;
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetUIActive(data.IsNeedSpecialBg);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(!data.IsNeedSpecialBg);
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(!data.IsNeedSpecialBg);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.Name, Array.Empty<object>());
		this.RefreshValue();
	}

	// Token: 0x06010A34 RID: 68148 RVA: 0x004DE498 File Offset: 0x004DC698
	[NullableContext(1)]
	public override object GetKey(FilterSeniorSetting data, int displayIndex)
	{
		return data.ParamIndex;
	}

	// Token: 0x06010A35 RID: 68149 RVA: 0x004DE4A8 File Offset: 0x004DC6A8
	private void RefreshValue()
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		float[] array;
		if (MenuModel.Instance.FilterSettingValuesCache.TryGetValue(filterSettingIdCache, out array))
		{
			double value = Math.Round((double)(array[this.FilterSeniorSetting.ParamIndex] * (float)this.FilterSeniorSetting.Ratio));
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value);
			defaultInterpolatedStringHandler.AppendFormatted(this.FilterSeniorSetting.Unit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			double num = MathUtils.Instance.RangeClamp(value, (double)this.FilterSeniorSetting.RangeMin, (double)this.FilterSeniorSetting.RangeMax, 0.0, 1.0);
			UUISliderComponent slider = base.GetSlider(1);
			if (slider != null)
			{
				slider.SetValue((float)num, false);
			}
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "全局滤镜高级参数未找到默认值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", this.FilterSeniorSetting.ParamIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.RefreshResetBtn();
	}

	// Token: 0x06010A36 RID: 68150 RVA: 0x004DE5BD File Offset: 0x004DC7BD
	private void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterParamChanged((EFilterSettingValueIndex)this.FilterSeniorSetting.ParamIndex));
	}

	// Token: 0x06010A37 RID: 68151 RVA: 0x004DE5E8 File Offset: 0x004DC7E8
	private void OnSliderValueChanged(float value)
	{
		FilterSettingViewModel parentViewModel = this.ParentViewModel;
		if (parentViewModel != null && parentViewModel.IsPropertyDirty(512))
		{
			return;
		}
		float num = MathUtils.Instance.RangeClamp(value, 0f, 1f, this.FilterSeniorSetting.RangeMin, this.FilterSeniorSetting.RangeMax);
		float arg = num / (float)this.FilterSeniorSetting.Ratio;
		FilterSettingViewModel parentViewModel2 = this.ParentViewModel;
		if (parentViewModel2 != null)
		{
			Action<EFilterSettingValueIndex, float> onSeniorSliderChanged = parentViewModel2.OnSeniorSliderChanged;
			if (onSeniorSliderChanged != null)
			{
				onSeniorSliderChanged((EFilterSettingValueIndex)this.FilterSeniorSetting.ParamIndex, arg);
			}
		}
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Round((double)num));
		defaultInterpolatedStringHandler.AppendFormatted(this.FilterSeniorSetting.Unit);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		this.RefreshResetBtn();
		Action onParamValueChanged = this.OnParamValueChanged;
		if (onParamValueChanged == null)
		{
			return;
		}
		onParamValueChanged();
	}

	// Token: 0x06010A38 RID: 68152 RVA: 0x004DE6C5 File Offset: 0x004DC8C5
	private void OnResetClick()
	{
		FilterSettingViewModel parentViewModel = this.ParentViewModel;
		if (parentViewModel != null)
		{
			Action<EFilterSettingValueIndex> onResetSingleParamClick = parentViewModel.OnResetSingleParamClick;
			if (onResetSingleParamClick != null)
			{
				onResetSingleParamClick((EFilterSettingValueIndex)this.FilterSeniorSetting.ParamIndex);
			}
		}
		this.RefreshValue();
		Action onParamValueChanged = this.OnParamValueChanged;
		if (onParamValueChanged == null)
		{
			return;
		}
		onParamValueChanged();
	}

	// Token: 0x04009319 RID: 37657
	[Nullable(2)]
	public FilterSettingViewModel ParentViewModel;

	// Token: 0x0400931A RID: 37658
	[Nullable(2)]
	public Action OnParamValueChanged;

	// Token: 0x0400931B RID: 37659
	private FilterSeniorSetting FilterSeniorSetting;

	// Token: 0x02007CD2 RID: 31954
	private enum EComponents
	{
		// Token: 0x040286B3 RID: 165555
		TextValue,
		// Token: 0x040286B4 RID: 165556
		Slider,
		// Token: 0x040286B5 RID: 165557
		SpriteHandle,
		// Token: 0x040286B6 RID: 165558
		SpriteNormalBg,
		// Token: 0x040286B7 RID: 165559
		SpriteTempBg,
		// Token: 0x040286B8 RID: 165560
		ItemFillArea,
		// Token: 0x040286B9 RID: 165561
		ToggleRoot,
		// Token: 0x040286BA RID: 165562
		TextName,
		// Token: 0x040286BB RID: 165563
		BtnReset,
		// Token: 0x040286BC RID: 165564
		ItemLock
	}
}
