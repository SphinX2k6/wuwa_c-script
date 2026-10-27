using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020025D7 RID: 9687
public class PhotographValueWithoutTitleSetup : PhotographSetupBase
{
	// Token: 0x06013A92 RID: 80530 RVA: 0x004EACE0 File Offset: 0x004E8EE0
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickReset));
		this.BtnBindInfo = list;
	}

	// Token: 0x06013A93 RID: 80531 RVA: 0x004EADA4 File Offset: 0x004E8FA4
	protected override void OnStart()
	{
		base.GetSlider(0).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		EventSystem.Instance.Add(EEventName.OnResetPhotographCamera, new Action(this.OnResetPhotographCamera));
	}

	// Token: 0x06013A94 RID: 80532 RVA: 0x004EADFB File Offset: 0x004E8FFB
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(0).OnValueChangeCb.Unbind();
		this.LevelSequencePlayer = null;
		EventSystem.Instance.Remove(EEventName.OnResetPhotographCamera, new Action(this.OnResetPhotographCamera));
	}

	// Token: 0x06013A95 RID: 80533 RVA: 0x004EAE34 File Offset: 0x004E9034
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x06013A96 RID: 80534 RVA: 0x004EAE64 File Offset: 0x004E9064
	private unsafe void OnValueChanged(float value)
	{
		float num = value;
		if (this.SetupConfig.Value.IsReverseSet)
		{
			Span<float> valueRangeBytes = this.SetupConfig.Value.GetValueRangeBytes();
			num = MathUtils.Instance.RangeClamp(value, *valueRangeBytes[0], *valueRangeBytes[1], *valueRangeBytes[1], *valueRangeBytes[0]);
		}
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, MathUtils.Instance.GetFloatPointFloor(num, this.SetupConfig.Value.Digits), false, true);
		this.SetNumText(num);
	}

	// Token: 0x06013A97 RID: 80535 RVA: 0x004EAF10 File Offset: 0x004E9110
	private void SetNumText(float value)
	{
		base.GetText(2).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x06013A98 RID: 80536 RVA: 0x004EAF64 File Offset: 0x004E9164
	public unsafe override void Refresh()
	{
		if (this.SetupConfig == null || this.SetupConfig.Value.Type != 3)
		{
			return;
		}
		UUISliderComponent slider = base.GetSlider(0);
		Span<float> valueRangeBytes = this.SetupConfig.Value.GetValueRangeBytes();
		slider.SetMinValue(*valueRangeBytes[0], false, false);
		slider.SetMaxValue(*valueRangeBytes[1], false, false);
		float? photographOption = PhotographModel.Instance.GetPhotographOption(this.SetupValueType);
		if (this.SetupConfig.Value.IsReverseSet)
		{
			photographOption = new float?(MathUtils.Instance.RangeClamp(photographOption ?? (*valueRangeBytes[2]), *valueRangeBytes[0], *valueRangeBytes[1], *valueRangeBytes[1], *valueRangeBytes[0]));
		}
		float num = photographOption ?? (*valueRangeBytes[2]);
		slider.SetValue(num, false);
		this.SetNumText(num);
	}

	// Token: 0x06013A99 RID: 80537 RVA: 0x004EB07C File Offset: 0x004E927C
	private unsafe void OnClickReset()
	{
		Span<float> valueRangeBytes = this.SetupConfig.Value.GetValueRangeBytes();
		float num = *valueRangeBytes[2];
		float inValue = num;
		if (this.SetupConfig.Value.IsReverseSet)
		{
			inValue = MathUtils.Instance.RangeClamp(num, *valueRangeBytes[0], *valueRangeBytes[1], *valueRangeBytes[1], *valueRangeBytes[0]);
		}
		base.GetSlider(0).SetValue(inValue, true);
	}

	// Token: 0x06013A9A RID: 80538 RVA: 0x004EB0FC File Offset: 0x004E92FC
	private void OnResetPhotographCamera()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x0400942D RID: 37933
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008BF1 RID: 35825
	private enum EChildType
	{
		// Token: 0x0402D6E2 RID: 186082
		ValueSlider,
		// Token: 0x0402D6E3 RID: 186083
		SpriteHandle,
		// Token: 0x0402D6E4 RID: 186084
		TextNum,
		// Token: 0x0402D6E5 RID: 186085
		ItemRedDot,
		// Token: 0x0402D6E6 RID: 186086
		BtnReset
	}
}
