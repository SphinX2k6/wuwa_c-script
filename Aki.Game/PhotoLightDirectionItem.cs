using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200256D RID: 9581
public class PhotoLightDirectionItem : UiPanelBase
{
	// Token: 0x06013575 RID: 79221 RVA: 0x004D0094 File Offset: 0x004CE294
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnResetClick))
		};
	}

	// Token: 0x06013576 RID: 79222 RVA: 0x004D01AC File Offset: 0x004CE3AC
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider != null)
		{
			slider.SetMinValue(0f, false, false);
		}
		if (slider != null)
		{
			slider.SetMaxValue(359f, false, false);
		}
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
	}

	// Token: 0x06013577 RID: 79223 RVA: 0x004D0201 File Offset: 0x004CE401
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x06013578 RID: 79224 RVA: 0x004D0219 File Offset: 0x004CE419
	public void SetDirection(float direction, float resetValue)
	{
		this.ResetValue = resetValue;
		UUISliderComponent slider = base.GetSlider(1);
		if (slider != null)
		{
			slider.SetValue(direction, false);
		}
		this.SetNumText(direction);
	}

	// Token: 0x06013579 RID: 79225 RVA: 0x004D0240 File Offset: 0x004CE440
	private void SetNumText(float value)
	{
		string value2 = ConfigMultiTextLang.GetLocalTextNew("LightDirection_UnitText", null) ?? "";
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)value);
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0601357A RID: 79226 RVA: 0x004D0295 File Offset: 0x004CE495
	private void OnValueChanged(float value)
	{
		this.SetNumText(value);
		this.OnDirectionChanged(value);
	}

	// Token: 0x0601357B RID: 79227 RVA: 0x004D02AA File Offset: 0x004CE4AA
	private void OnResetClick()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(this.ResetValue, true);
	}

	// Token: 0x040091C8 RID: 37320
	private float ResetValue;

	// Token: 0x040091C9 RID: 37321
	[Nullable(1)]
	public Action<float> OnDirectionChanged = delegate(float value)
	{
	};

	// Token: 0x02008B52 RID: 35666
	private enum EComponents
	{
		// Token: 0x0402D3CC RID: 185292
		TextValue,
		// Token: 0x0402D3CD RID: 185293
		Slider,
		// Token: 0x0402D3CE RID: 185294
		SpriteHandle,
		// Token: 0x0402D3CF RID: 185295
		SpriteSldBg,
		// Token: 0x0402D3D0 RID: 185296
		SpriteSldBgTemperature,
		// Token: 0x0402D3D1 RID: 185297
		ItemFillArea,
		// Token: 0x0402D3D2 RID: 185298
		ToggleItem,
		// Token: 0x0402D3D3 RID: 185299
		TextTitle,
		// Token: 0x0402D3D4 RID: 185300
		BtnReset,
		// Token: 0x0402D3D5 RID: 185301
		ItemLock
	}
}
