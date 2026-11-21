using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A4D RID: 6733
public class PhotoEnvStrengthItem : UiPanelBase
{
	// Token: 0x060109DD RID: 68061 RVA: 0x004DCC48 File Offset: 0x004DAE48
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

	// Token: 0x060109DE RID: 68062 RVA: 0x004DCD60 File Offset: 0x004DAF60
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

	// Token: 0x060109DF RID: 68063 RVA: 0x004DCDB5 File Offset: 0x004DAFB5
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x060109E0 RID: 68064 RVA: 0x004DCDCD File Offset: 0x004DAFCD
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

	// Token: 0x060109E1 RID: 68065 RVA: 0x004DCDF4 File Offset: 0x004DAFF4
	private void SetNumText(float value)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(((int)value).ToString(), true);
	}

	// Token: 0x060109E2 RID: 68066 RVA: 0x004DCE1D File Offset: 0x004DB01D
	private void OnValueChanged(float value)
	{
		this.SetNumText(value);
		this.OnStrengthChanged(value);
	}

	// Token: 0x060109E3 RID: 68067 RVA: 0x004DCE32 File Offset: 0x004DB032
	private void OnResetClick()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(this.ResetValue, true);
	}

	// Token: 0x04009305 RID: 37637
	private float ResetValue;

	// Token: 0x04009306 RID: 37638
	[Nullable(1)]
	public Action<float> OnStrengthChanged = delegate(float value)
	{
	};

	// Token: 0x02007CC3 RID: 31939
	private enum EComponents
	{
		// Token: 0x04028657 RID: 165463
		TextValue,
		// Token: 0x04028658 RID: 165464
		Slider,
		// Token: 0x04028659 RID: 165465
		SpriteHandle,
		// Token: 0x0402865A RID: 165466
		SpriteSldBg,
		// Token: 0x0402865B RID: 165467
		SpriteSldBgTemperature,
		// Token: 0x0402865C RID: 165468
		ItemFillArea,
		// Token: 0x0402865D RID: 165469
		ToggleItem,
		// Token: 0x0402865E RID: 165470
		TextTitle,
		// Token: 0x0402865F RID: 165471
		BtnReset,
		// Token: 0x04028660 RID: 165472
		ItemLock
	}
}
