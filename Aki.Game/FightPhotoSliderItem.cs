using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02001AAA RID: 6826
public class FightPhotoSliderItem : FightPhotoSetupBase
{
	// Token: 0x06010E5A RID: 69210 RVA: 0x004F4ED8 File Offset: 0x004F30D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRefresh))
		};
	}

	// Token: 0x06010E5B RID: 69211 RVA: 0x004F4F97 File Offset: 0x004F3197
	protected override void OnStart()
	{
		base.GetSlider(0).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
	}

	// Token: 0x06010E5C RID: 69212 RVA: 0x004F4FB8 File Offset: 0x004F31B8
	public override void Refresh()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.SetupConfig.Value.Name, Array.Empty<object>());
		float num = this.SetupConfig.Value.ValueRange(0);
		float num2 = this.SetupConfig.Value.ValueRange(1);
		float num3 = this.SetupConfig.Value.ValueRange(2);
		UUISliderComponent slider = base.GetSlider(0);
		slider.SetMinValue(num, false, false);
		slider.SetMaxValue(num2, false, false);
		int? fightPhotoSetupOption = FightPhotoModel.Instance.GetFightPhotoSetupOption((EFightPhotoSetupOptionType)this.SetupConfig.Value.Id);
		float num4 = (fightPhotoSetupOption != null) ? ((float)fightPhotoSetupOption.GetValueOrDefault()) : num3;
		float inValue = this.SetupConfig.Value.IsReverseSet ? MathUtils.Instance.RangeClamp(num4, num, num2, num2, num) : num4;
		slider.SetValue(inValue, false);
		base.GetText(2).SetUIActive(this.SetupConfig.Value.IsShowText);
		this.SetNumText(num4);
	}

	// Token: 0x06010E5D RID: 69213 RVA: 0x004F50E8 File Offset: 0x004F32E8
	private void SetNumText(float value)
	{
		base.GetText(2).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x06010E5E RID: 69214 RVA: 0x004F5139 File Offset: 0x004F3339
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(0).OnValueChangeCb.Unbind();
	}

	// Token: 0x06010E5F RID: 69215 RVA: 0x004F514C File Offset: 0x004F334C
	private void OnValueChanged(float value)
	{
		float num = this.SetupConfig.Value.ValueRange(0);
		float num2 = this.SetupConfig.Value.ValueRange(1);
		float num3 = this.SetupConfig.Value.IsReverseSet ? MathUtils.Instance.RangeClamp(value, num, num2, num2, num) : value;
		float floatPointFloor = MathUtils.Instance.GetFloatPointFloor(num3, this.SetupConfig.Value.Digits);
		this.SetNumText(num3);
		base.OnSetupValueChange((int)floatPointFloor);
	}

	// Token: 0x06010E60 RID: 69216 RVA: 0x004F51E0 File Offset: 0x004F33E0
	private void OnClickRefresh()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		float num = this.SetupConfig.Value.ValueRange(0);
		float num2 = this.SetupConfig.Value.ValueRange(1);
		float num3 = this.SetupConfig.Value.ValueRange(2);
		float inValue = this.SetupConfig.Value.IsReverseSet ? MathUtils.Instance.RangeClamp(num3, num, num2, num2, num) : num3;
		base.GetSlider(0).SetValue(inValue, true);
	}

	// Token: 0x02007D58 RID: 32088
	private enum EChildType
	{
		// Token: 0x0402892F RID: 166191
		ValueSlider,
		// Token: 0x04028930 RID: 166192
		SpriteHandle,
		// Token: 0x04028931 RID: 166193
		TxtNum,
		// Token: 0x04028932 RID: 166194
		ItemRedDot,
		// Token: 0x04028933 RID: 166195
		BtnRefresh,
		// Token: 0x04028934 RID: 166196
		TxtTitle
	}
}
