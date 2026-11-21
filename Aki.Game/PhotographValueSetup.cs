using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001AC1 RID: 6849
public class PhotographValueSetup : PhotographSetupBase
{
	// Token: 0x06010F6A RID: 69482 RVA: 0x004F9674 File Offset: 0x004F7874
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06010F6B RID: 69483 RVA: 0x004F96CE File Offset: 0x004F78CE
	protected override void OnStart()
	{
		base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010F6C RID: 69484 RVA: 0x004F96FE File Offset: 0x004F78FE
	protected override void OnBeforeDestroy()
	{
		base.GetSlider(1).OnValueChangeCb.Unbind();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06010F6D RID: 69485 RVA: 0x004F9718 File Offset: 0x004F7918
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x06010F6E RID: 69486 RVA: 0x004F9748 File Offset: 0x004F7948
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

	// Token: 0x06010F6F RID: 69487 RVA: 0x004F97D7 File Offset: 0x004F79D7
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
	}

	// Token: 0x06010F70 RID: 69488 RVA: 0x004F97E8 File Offset: 0x004F79E8
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

	// Token: 0x04009582 RID: 38274
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007D78 RID: 32120
	private enum EChildType
	{
		// Token: 0x040289F3 RID: 166387
		OptionNameText,
		// Token: 0x040289F4 RID: 166388
		ValueSlider,
		// Token: 0x040289F5 RID: 166389
		SpriteHandle
	}
}
