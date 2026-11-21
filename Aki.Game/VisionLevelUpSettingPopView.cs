using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019B5 RID: 6581
public class VisionLevelUpSettingPopView : UiViewBase
{
	// Token: 0x060103AC RID: 66476 RVA: 0x004BCA65 File Offset: 0x004BAC65
	[NullableContext(1)]
	public VisionLevelUpSettingPopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060103AD RID: 66477 RVA: 0x004BCA70 File Offset: 0x004BAC70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnAllInModeToggleClick)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnStepInModeToggleClick)),
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnOnlyLevelUpMaterialToggleClick)),
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnBothLevelUpMaterialAndVisionToggleClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnCancelButtonClick)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmButtonClick)),
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnDisableIdentifyToggleClick)),
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnEnableIdentifyToggleClick))
		};
	}

	// Token: 0x060103AE RID: 66478 RVA: 0x004BCC03 File Offset: 0x004BAE03
	private void OnDisableIdentifyToggleClick(EToggleState toggleState)
	{
		this.SetIdentify(EVisionLevelUpIdentify.DisableIdentify);
	}

	// Token: 0x060103AF RID: 66479 RVA: 0x004BCC0C File Offset: 0x004BAE0C
	private void OnEnableIdentifyToggleClick(EToggleState toggleState)
	{
		this.SetIdentify(EVisionLevelUpIdentify.EnableIdentify);
	}

	// Token: 0x060103B0 RID: 66480 RVA: 0x004BCC15 File Offset: 0x004BAE15
	private void OnAllInModeToggleClick(EToggleState toggleState)
	{
		this.SetPutInMode(EVisionLevelUpMaterialPutInMode.AllIn);
	}

	// Token: 0x060103B1 RID: 66481 RVA: 0x004BCC1E File Offset: 0x004BAE1E
	private void OnStepInModeToggleClick(EToggleState toggleState)
	{
		this.SetPutInMode(EVisionLevelUpMaterialPutInMode.StepIn);
	}

	// Token: 0x060103B2 RID: 66482 RVA: 0x004BCC27 File Offset: 0x004BAE27
	private void OnOnlyLevelUpMaterialToggleClick(EToggleState toggleState)
	{
		this.SetUseType(EVisionLevelUpMaterialUseType.OnlyLevelUpMaterial);
	}

	// Token: 0x060103B3 RID: 66483 RVA: 0x004BCC30 File Offset: 0x004BAE30
	private void OnBothLevelUpMaterialAndVisionToggleClick(EToggleState toggleState)
	{
		this.SetUseType(EVisionLevelUpMaterialUseType.BothLevelUpMaterialAndVision);
	}

	// Token: 0x060103B4 RID: 66484 RVA: 0x004BCC39 File Offset: 0x004BAE39
	private void OnCancelButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060103B5 RID: 66485 RVA: 0x004BCC42 File Offset: 0x004BAE42
	private void OnConfirmButtonClick()
	{
		this.SaveSetting();
		base.CloseMe(null);
	}

	// Token: 0x060103B6 RID: 66486 RVA: 0x004BCC54 File Offset: 0x004BAE54
	protected override void OnStart()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		this.PutInMode = instance.GetVisionLevelUpMaterialPutInMode();
		this.UseType = instance.GetVisionLevelUpMaterialUseType();
		this.Identify = instance.GetVisionLevelUpIdentify();
		this.Refresh();
	}

	// Token: 0x060103B7 RID: 66487 RVA: 0x004BCC91 File Offset: 0x004BAE91
	public void Refresh()
	{
		this.RefreshPutInModeToggle();
		this.RefreshUseTypeToggle();
		this.RefreshIdentifyToggle();
	}

	// Token: 0x060103B8 RID: 66488 RVA: 0x004BCCA8 File Offset: 0x004BAEA8
	public void RefreshUseTypeToggle()
	{
		EToggleState? etoggleState = null;
		EToggleState? etoggleState2 = null;
		if (this.UseType == EVisionLevelUpMaterialUseType.OnlyLevelUpMaterial)
		{
			etoggleState = new EToggleState?(EToggleState.ETT_Checked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_UnChecked);
		}
		else
		{
			etoggleState = new EToggleState?(EToggleState.ETT_UnChecked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_Checked);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(etoggleState.Value, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetToggleState(etoggleState2.Value, false, false, false);
	}

	// Token: 0x060103B9 RID: 66489 RVA: 0x004BCD28 File Offset: 0x004BAF28
	public void RefreshPutInModeToggle()
	{
		EToggleState? etoggleState = null;
		EToggleState? etoggleState2 = null;
		if (this.PutInMode == EVisionLevelUpMaterialPutInMode.AllIn)
		{
			etoggleState = new EToggleState?(EToggleState.ETT_Checked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_UnChecked);
		}
		else
		{
			etoggleState = new EToggleState?(EToggleState.ETT_UnChecked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_Checked);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(etoggleState.Value, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetToggleState(etoggleState2.Value, false, false, false);
	}

	// Token: 0x060103BA RID: 66490 RVA: 0x004BCDA8 File Offset: 0x004BAFA8
	public void RefreshIdentifyToggle()
	{
		EToggleState? etoggleState = null;
		EToggleState? etoggleState2 = null;
		if (this.Identify == EVisionLevelUpIdentify.DisableIdentify)
		{
			etoggleState = new EToggleState?(EToggleState.ETT_Checked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_UnChecked);
		}
		else
		{
			etoggleState = new EToggleState?(EToggleState.ETT_UnChecked);
			etoggleState2 = new EToggleState?(EToggleState.ETT_Checked);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(etoggleState.Value, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(7);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetToggleState(etoggleState2.Value, false, false, false);
	}

	// Token: 0x060103BB RID: 66491 RVA: 0x004BCE28 File Offset: 0x004BB028
	protected void SetPutInMode(EVisionLevelUpMaterialPutInMode mode)
	{
		this.PutInMode = mode;
		this.RefreshPutInModeToggle();
	}

	// Token: 0x060103BC RID: 66492 RVA: 0x004BCE37 File Offset: 0x004BB037
	protected void SetUseType(EVisionLevelUpMaterialUseType useType)
	{
		this.UseType = useType;
		this.RefreshUseTypeToggle();
	}

	// Token: 0x060103BD RID: 66493 RVA: 0x004BCE46 File Offset: 0x004BB046
	protected void SetIdentify(EVisionLevelUpIdentify identify)
	{
		this.Identify = identify;
		this.RefreshIdentifyToggle();
	}

	// Token: 0x060103BE RID: 66494 RVA: 0x004BCE55 File Offset: 0x004BB055
	protected void SaveSetting()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		instance.SetVisionLevelUpMaterialPutInMode(this.PutInMode);
		instance.SetVisionLevelUpMaterialUseType(this.UseType);
		instance.SetVisionLevelUpIdentify(this.Identify);
	}

	// Token: 0x04008FEC RID: 36844
	private EVisionLevelUpMaterialPutInMode PutInMode;

	// Token: 0x04008FED RID: 36845
	private EVisionLevelUpMaterialUseType UseType;

	// Token: 0x04008FEE RID: 36846
	private EVisionLevelUpIdentify Identify;

	// Token: 0x02007BE2 RID: 31714
	private enum EComponent
	{
		// Token: 0x040281DB RID: 164315
		AllInModeToggle,
		// Token: 0x040281DC RID: 164316
		StepInModeToggle,
		// Token: 0x040281DD RID: 164317
		OnlyLevelUpMaterialToggle,
		// Token: 0x040281DE RID: 164318
		BothLevelUpMaterialAndVisionToggle,
		// Token: 0x040281DF RID: 164319
		CancelButton,
		// Token: 0x040281E0 RID: 164320
		ConfirmButton,
		// Token: 0x040281E1 RID: 164321
		DisableIdentifyToggle,
		// Token: 0x040281E2 RID: 164322
		EnableIdentifyToggle
	}
}
