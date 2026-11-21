using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A58 RID: 6744
public class PhotoLightDirectionItem : UiPanelBase
{
	// Token: 0x06010A57 RID: 68183 RVA: 0x004DECCC File Offset: 0x004DCECC
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

	// Token: 0x06010A58 RID: 68184 RVA: 0x004DEDE4 File Offset: 0x004DCFE4
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

	// Token: 0x06010A59 RID: 68185 RVA: 0x004DEE39 File Offset: 0x004DD039
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Unbind();
	}

	// Token: 0x06010A5A RID: 68186 RVA: 0x004DEE51 File Offset: 0x004DD051
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

	// Token: 0x06010A5B RID: 68187 RVA: 0x004DEE78 File Offset: 0x004DD078
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

	// Token: 0x06010A5C RID: 68188 RVA: 0x004DEECD File Offset: 0x004DD0CD
	private void OnValueChanged(float value)
	{
		this.SetNumText(value);
		this.OnDirectionChanged(value);
	}

	// Token: 0x06010A5D RID: 68189 RVA: 0x004DEEE2 File Offset: 0x004DD0E2
	private void OnResetClick()
	{
		UUISliderComponent slider = base.GetSlider(1);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(this.ResetValue, true);
	}

	// Token: 0x04009321 RID: 37665
	private float ResetValue;

	// Token: 0x04009322 RID: 37666
	[Nullable(1)]
	public Action<float> OnDirectionChanged = delegate(float value)
	{
	};

	// Token: 0x02007CD8 RID: 31960
	private enum EComponents
	{
		// Token: 0x040286D9 RID: 165593
		TextValue,
		// Token: 0x040286DA RID: 165594
		Slider,
		// Token: 0x040286DB RID: 165595
		SpriteHandle,
		// Token: 0x040286DC RID: 165596
		SpriteSldBg,
		// Token: 0x040286DD RID: 165597
		SpriteSldBgTemperature,
		// Token: 0x040286DE RID: 165598
		ItemFillArea,
		// Token: 0x040286DF RID: 165599
		ToggleItem,
		// Token: 0x040286E0 RID: 165600
		TextTitle,
		// Token: 0x040286E1 RID: 165601
		BtnReset,
		// Token: 0x040286E2 RID: 165602
		ItemLock
	}
}
