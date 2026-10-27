using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002569 RID: 9577
public class PhotoFilterSeniorSliderItem : GridProxyAbstract<FilterSeniorSetting>
{
	// Token: 0x0601354F RID: 79183 RVA: 0x004CF6E4 File Offset: 0x004CD8E4
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

	// Token: 0x06013550 RID: 79184 RVA: 0x004CF7B9 File Offset: 0x004CD9B9
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
	}

	// Token: 0x06013551 RID: 79185 RVA: 0x004CF7D8 File Offset: 0x004CD9D8
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

	// Token: 0x06013552 RID: 79186 RVA: 0x004CF860 File Offset: 0x004CDA60
	[NullableContext(1)]
	public override object GetKey(FilterSeniorSetting data, int displayIndex)
	{
		return data.ParamIndex;
	}

	// Token: 0x06013553 RID: 79187 RVA: 0x004CF870 File Offset: 0x004CDA70
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

	// Token: 0x06013554 RID: 79188 RVA: 0x004CF985 File Offset: 0x004CDB85
	private void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterParamChanged((EFilterSettingValueIndex)this.FilterSeniorSetting.ParamIndex));
	}

	// Token: 0x06013555 RID: 79189 RVA: 0x004CF9B0 File Offset: 0x004CDBB0
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

	// Token: 0x06013556 RID: 79190 RVA: 0x004CFA8D File Offset: 0x004CDC8D
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

	// Token: 0x040091C0 RID: 37312
	[Nullable(2)]
	public FilterSettingViewModel ParentViewModel;

	// Token: 0x040091C1 RID: 37313
	[Nullable(2)]
	public Action OnParamValueChanged;

	// Token: 0x040091C2 RID: 37314
	private FilterSeniorSetting FilterSeniorSetting;

	// Token: 0x02008B4C RID: 35660
	private enum EComponents
	{
		// Token: 0x0402D3A6 RID: 185254
		TextValue,
		// Token: 0x0402D3A7 RID: 185255
		Slider,
		// Token: 0x0402D3A8 RID: 185256
		SpriteHandle,
		// Token: 0x0402D3A9 RID: 185257
		SpriteNormalBg,
		// Token: 0x0402D3AA RID: 185258
		SpriteTempBg,
		// Token: 0x0402D3AB RID: 185259
		ItemFillArea,
		// Token: 0x0402D3AC RID: 185260
		ToggleRoot,
		// Token: 0x0402D3AD RID: 185261
		TextName,
		// Token: 0x0402D3AE RID: 185262
		BtnReset,
		// Token: 0x0402D3AF RID: 185263
		ItemLock
	}
}
