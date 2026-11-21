using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02001A60 RID: 6752
public class PhotoSliderSetItem : PhotographSetupBase
{
	// Token: 0x06010AC0 RID: 68288 RVA: 0x004E06FC File Offset: 0x004DE8FC
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

	// Token: 0x06010AC1 RID: 68289 RVA: 0x004E07D4 File Offset: 0x004DE9D4
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Combine(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x06010AC2 RID: 68290 RVA: 0x004E0824 File Offset: 0x004DEA24
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

	// Token: 0x06010AC3 RID: 68291 RVA: 0x004E0840 File Offset: 0x004DEA40
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

	// Token: 0x06010AC4 RID: 68292 RVA: 0x004E0918 File Offset: 0x004DEB18
	private void SetNumText(float value)
	{
		base.GetText(0).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x06010AC5 RID: 68293 RVA: 0x004E0969 File Offset: 0x004DEB69
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(1).OnValueChangeCb.Unbind();
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Remove(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x06010AC6 RID: 68294 RVA: 0x004E09A4 File Offset: 0x004DEBA4
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

	// Token: 0x06010AC7 RID: 68295 RVA: 0x004E0A60 File Offset: 0x004DEC60
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

	// Token: 0x06010AC8 RID: 68296 RVA: 0x004E0AD0 File Offset: 0x004DECD0
	public override void SetSubItem(bool bSubItem)
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bSubItem);
	}

	// Token: 0x06010AC9 RID: 68297 RVA: 0x004E0AE5 File Offset: 0x004DECE5
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

	// Token: 0x02007CED RID: 31981
	private enum EComponents
	{
		// Token: 0x04028747 RID: 165703
		TextValue,
		// Token: 0x04028748 RID: 165704
		SliderInfoHor,
		// Token: 0x04028749 RID: 165705
		SpriteHandle,
		// Token: 0x0402874A RID: 165706
		SpriteNormalBg,
		// Token: 0x0402874B RID: 165707
		SpriteTempBg,
		// Token: 0x0402874C RID: 165708
		ItemFillArea,
		// Token: 0x0402874D RID: 165709
		ToggleRoot,
		// Token: 0x0402874E RID: 165710
		TextSettingTitle,
		// Token: 0x0402874F RID: 165711
		BtnReset,
		// Token: 0x04028750 RID: 165712
		ItemLock,
		// Token: 0x04028751 RID: 165713
		ItemUnlock,
		// Token: 0x04028752 RID: 165714
		ItemSubIconBg
	}
}
