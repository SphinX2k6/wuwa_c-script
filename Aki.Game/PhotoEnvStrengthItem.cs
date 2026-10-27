using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002562 RID: 9570
public class PhotoEnvStrengthItem : UiPanelBase
{
	// Token: 0x060134FB RID: 79099 RVA: 0x004CE010 File Offset: 0x004CC210
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

	// Token: 0x060134FC RID: 79100 RVA: 0x004CE128 File Offset: 0x004CC328
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider != null)
		{
			slider.SetMinValue(0f, false, false);
		}
		if (slider != null)
		{
			slider.SetMaxValue(100f, false, false);
		}
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
	}

	// Token: 0x060134FD RID: 79101 RVA: 0x004CE17D File Offset: 0x004CC37D
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x060134FE RID: 79102 RVA: 0x004CE195 File Offset: 0x004CC395
	public void SetStrength(float strength, float resetValue)
	{
		this.ResetValue = resetValue;
		UUISliderComponent slider = base.GetSlider(1);
		if (slider != null)
		{
			slider.SetValue(strength, false);
		}
		this.SetNumText(strength);
	}

	// Token: 0x060134FF RID: 79103 RVA: 0x004CE1BC File Offset: 0x004CC3BC
	private void SetNumText(float value)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(((int)value).ToString(), true);
	}

	// Token: 0x06013500 RID: 79104 RVA: 0x004CE1E5 File Offset: 0x004CC3E5
	private void OnValueChanged(float value)
	{
		this.SetNumText(value);
		this.OnStrengthChanged(value);
	}

	// Token: 0x06013501 RID: 79105 RVA: 0x004CE1FA File Offset: 0x004CC3FA
	private void OnResetClick()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(this.ResetValue, true);
	}

	// Token: 0x040091AC RID: 37292
	private float ResetValue;

	// Token: 0x040091AD RID: 37293
	[Nullable(1)]
	public Action<float> OnStrengthChanged = delegate(float value)
	{
	};

	// Token: 0x02008B3D RID: 35645
	private enum EComponents
	{
		// Token: 0x0402D34A RID: 185162
		TextValue,
		// Token: 0x0402D34B RID: 185163
		Slider,
		// Token: 0x0402D34C RID: 185164
		SpriteHandle,
		// Token: 0x0402D34D RID: 185165
		SpriteSldBg,
		// Token: 0x0402D34E RID: 185166
		SpriteSldBgTemperature,
		// Token: 0x0402D34F RID: 185167
		ItemFillArea,
		// Token: 0x0402D350 RID: 185168
		ToggleItem,
		// Token: 0x0402D351 RID: 185169
		TextTitle,
		// Token: 0x0402D352 RID: 185170
		BtnReset,
		// Token: 0x0402D353 RID: 185171
		ItemLock
	}
}
