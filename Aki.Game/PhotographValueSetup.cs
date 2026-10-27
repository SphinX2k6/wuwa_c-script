using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025D6 RID: 9686
public class PhotographValueSetup : PhotographSetupBase
{
	// Token: 0x06013A8A RID: 80522 RVA: 0x004EAA74 File Offset: 0x004E8C74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013A8B RID: 80523 RVA: 0x004EAACE File Offset: 0x004E8CCE
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013A8C RID: 80524 RVA: 0x004EAAFE File Offset: 0x004E8CFE
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(1).OnValueChangeCb.Unbind();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06013A8D RID: 80525 RVA: 0x004EAB18 File Offset: 0x004E8D18
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x06013A8E RID: 80526 RVA: 0x004EAB48 File Offset: 0x004E8D48
	private void OnValueChanged(float value)
	{
		if (this.SetupConfig.Value.IsReverseSet)
		{
			float[] array = this.SetupConfig.Value.ValueRange();
			float value2 = MathUtils.Instance.RangeClamp(value, array[0], array[1], array[1], array[0]);
			PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, value2, false, true);
			return;
		}
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, value, false, true);
	}

	// Token: 0x06013A8F RID: 80527 RVA: 0x004EABD7 File Offset: 0x004E8DD7
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
	}

	// Token: 0x06013A90 RID: 80528 RVA: 0x004EABE8 File Offset: 0x004E8DE8
	public override void Refresh()
	{
		if (this.SetupConfig == null || this.SetupConfig.Value.Type == 0)
		{
			return;
		}
		string name = this.SetupConfig.Value.Name;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
		UUISliderComponent slider = base.GetSlider(1);
		float[] array = this.SetupConfig.Value.ValueRange();
		slider.SetMinValue(array[0], false, false);
		slider.SetMaxValue(array[1], false, false);
		float num = PhotographModel.Instance.GetPhotographOption(this.SetupValueType) ?? array[2];
		if (this.SetupConfig.Value.IsReverseSet)
		{
			num = MathUtils.Instance.RangeClamp(num, array[0], array[1], array[1], array[0]);
		}
		slider.SetValue(num, false);
	}

	// Token: 0x0400942C RID: 37932
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008BF0 RID: 35824
	private enum EChildType
	{
		// Token: 0x0402D6DE RID: 186078
		OptionNameText,
		// Token: 0x0402D6DF RID: 186079
		ValueSlider,
		// Token: 0x0402D6E0 RID: 186080
		SpriteHandle
	}
}
