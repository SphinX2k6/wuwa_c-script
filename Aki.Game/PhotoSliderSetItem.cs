using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02002575 RID: 9589
public class PhotoSliderSetItem : PhotographSetupBase
{
	// Token: 0x060135DD RID: 79325 RVA: 0x004D1A94 File Offset: 0x004CFC94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnResetClick))
		};
	}

	// Token: 0x060135DE RID: 79326 RVA: 0x004D1B6C File Offset: 0x004CFD6C
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Combine(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x060135DF RID: 79327 RVA: 0x004D1BBC File Offset: 0x004CFDBC
	private void OnPhotographOptionChanged(EPhotoSetupValueType valueType, float value)
	{
		if (!this.IsInCurrentMode)
		{
			return;
		}
		if (valueType != this.SetupValueType)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x060135E0 RID: 79328 RVA: 0x004D1BD8 File Offset: 0x004CFDD8
	public override void Refresh()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), this.SetupConfig.Value.Name, Array.Empty<object>());
		UUISliderComponent slider = base.GetSlider(1);
		float[] array = this.SetupConfig.Value.ValueRange();
		slider.SetMinValue(array[0], false, false);
		slider.SetMaxValue(array[1], false, false);
		float num = PhotographModel.Instance.GetPhotographOption(this.SetupValueType) ?? array[2];
		this.SetNumText(num);
		if (this.SetupConfig.Value.IsReverseSet)
		{
			num = MathUtils.Instance.RangeClamp(num, array[0], array[1], array[1], array[0]);
		}
		slider.SetValue(num, false);
	}

	// Token: 0x060135E1 RID: 79329 RVA: 0x004D1CB0 File Offset: 0x004CFEB0
	private void SetNumText(float value)
	{
		base.GetText(0).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x060135E2 RID: 79330 RVA: 0x004D1D01 File Offset: 0x004CFF01
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(1).OnValueChangeCb.Unbind();
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Remove(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x060135E3 RID: 79331 RVA: 0x004D1D3C File Offset: 0x004CFF3C
	private unsafe void OnValueChanged(float value)
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		float num = value;
		if (this.SetupConfig.Value.IsReverseSet)
		{
			Span<float> valueRangeBytes = this.SetupConfig.Value.GetValueRangeBytes();
			num = MathUtils.Instance.RangeClamp(value, *valueRangeBytes[0], *valueRangeBytes[1], *valueRangeBytes[1], *valueRangeBytes[0]);
		}
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, MathUtils.Instance.GetFloatPointFloor(num, this.SetupConfig.Value.Digits), false, false);
		this.SetNumText(num);
	}

	// Token: 0x060135E4 RID: 79332 RVA: 0x004D1DF8 File Offset: 0x004CFFF8
	private void OnResetClick()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		float[] array = this.SetupConfig.Value.ValueRange();
		float num = array[2];
		float inValue = num;
		if (this.SetupConfig.Value.IsReverseSet)
		{
			inValue = MathUtils.Instance.RangeClamp(num, array[0], array[1], array[1], array[0]);
		}
		base.GetSlider(1).SetValue(inValue, true);
	}

	// Token: 0x060135E5 RID: 79333 RVA: 0x004D1E68 File Offset: 0x004D0068
	public override void SetSubItem(bool bSubItem)
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bSubItem);
	}

	// Token: 0x060135E6 RID: 79334 RVA: 0x004D1E7D File Offset: 0x004D007D
	public override void SetLock(bool bLock)
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(bLock);
		}
		if (!bLock)
		{
			this.Refresh();
		}
	}

	// Token: 0x02008B67 RID: 35687
	private enum EComponents
	{
		// Token: 0x0402D43A RID: 185402
		TextValue,
		// Token: 0x0402D43B RID: 185403
		SliderInfoHor,
		// Token: 0x0402D43C RID: 185404
		SpriteHandle,
		// Token: 0x0402D43D RID: 185405
		SpriteNormalBg,
		// Token: 0x0402D43E RID: 185406
		SpriteTempBg,
		// Token: 0x0402D43F RID: 185407
		ItemFillArea,
		// Token: 0x0402D440 RID: 185408
		ToggleRoot,
		// Token: 0x0402D441 RID: 185409
		TextSettingTitle,
		// Token: 0x0402D442 RID: 185410
		BtnReset,
		// Token: 0x0402D443 RID: 185411
		ItemLock,
		// Token: 0x0402D444 RID: 185412
		ItemUnlock,
		// Token: 0x0402D445 RID: 185413
		ItemSubIconBg
	}
}
