using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x020025BF RID: 9663
public class FightPhotoSliderItem : FightPhotoSetupBase
{
	// Token: 0x0601397A RID: 80250 RVA: 0x004E62D8 File Offset: 0x004E44D8
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

	// Token: 0x0601397B RID: 80251 RVA: 0x004E6397 File Offset: 0x004E4597
	protected override void OnStart()
	{
		base.GetSlider(0).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
	}

	// Token: 0x0601397C RID: 80252 RVA: 0x004E63B8 File Offset: 0x004E45B8
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

	// Token: 0x0601397D RID: 80253 RVA: 0x004E64E8 File Offset: 0x004E46E8
	private void SetNumText(float value)
	{
		base.GetText(2).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x0601397E RID: 80254 RVA: 0x004E6539 File Offset: 0x004E4739
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(0).OnValueChangeCb.Unbind();
	}

	// Token: 0x0601397F RID: 80255 RVA: 0x004E654C File Offset: 0x004E474C
	private void OnValueChanged(float value)
	{
		float num = this.SetupConfig.Value.ValueRange(0);
		float num2 = this.SetupConfig.Value.ValueRange(1);
		float num3 = this.SetupConfig.Value.IsReverseSet ? MathUtils.Instance.RangeClamp(value, num, num2, num2, num) : value;
		float floatPointFloor = MathUtils.Instance.GetFloatPointFloor(num3, this.SetupConfig.Value.Digits);
		this.SetNumText(num3);
		base.OnSetupValueChange((int)floatPointFloor);
	}

	// Token: 0x06013980 RID: 80256 RVA: 0x004E65E0 File Offset: 0x004E47E0
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

	// Token: 0x02008BD0 RID: 35792
	private enum EChildType
	{
		// Token: 0x0402D61A RID: 185882
		ValueSlider,
		// Token: 0x0402D61B RID: 185883
		SpriteHandle,
		// Token: 0x0402D61C RID: 185884
		TxtNum,
		// Token: 0x0402D61D RID: 185885
		ItemRedDot,
		// Token: 0x0402D61E RID: 185886
		BtnRefresh,
		// Token: 0x0402D61F RID: 185887
		TxtTitle
	}
}
