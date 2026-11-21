using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001AC2 RID: 6850
public class PhotographValueWithoutTitleSetup : PhotographSetupBase
{
	// Token: 0x06010F72 RID: 69490 RVA: 0x004F98E0 File Offset: 0x004F7AE0
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

	// Token: 0x06010F73 RID: 69491 RVA: 0x004F99A4 File Offset: 0x004F7BA4
	protected override void OnStart()
	{
		base.GetSlider(0).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		EventSystem.Instance.Add(EEventName.OnResetPhotographCamera, new Action(this.OnResetPhotographCamera));
	}

	// Token: 0x06010F74 RID: 69492 RVA: 0x004F99FB File Offset: 0x004F7BFB
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(0).OnValueChangeCb.Unbind();
		this.LevelSequencePlayer = null;
		EventSystem.Instance.Remove(EEventName.OnResetPhotographCamera, new Action(this.OnResetPhotographCamera));
	}

	// Token: 0x06010F75 RID: 69493 RVA: 0x004F9A34 File Offset: 0x004F7C34
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x06010F76 RID: 69494 RVA: 0x004F9A64 File Offset: 0x004F7C64
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

	// Token: 0x06010F77 RID: 69495 RVA: 0x004F9B10 File Offset: 0x004F7D10
	private void SetNumText(float value)
	{
		base.GetText(2).SetText(MathUtils.Instance.GetFloatPointFloorString((double)value, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit, true);
	}

	// Token: 0x06010F78 RID: 69496 RVA: 0x004F9B64 File Offset: 0x004F7D64
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

	// Token: 0x06010F79 RID: 69497 RVA: 0x004F9C7C File Offset: 0x004F7E7C
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

	// Token: 0x06010F7A RID: 69498 RVA: 0x004F9CFC File Offset: 0x004F7EFC
	private void OnResetPhotographCamera()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x04009583 RID: 38275
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007D79 RID: 32121
	private enum EChildType
	{
		// Token: 0x040289F7 RID: 166391
		ValueSlider,
		// Token: 0x040289F8 RID: 166392
		SpriteHandle,
		// Token: 0x040289F9 RID: 166393
		TextNum,
		// Token: 0x040289FA RID: 166394
		ItemRedDot,
		// Token: 0x040289FB RID: 166395
		BtnReset
	}
}
