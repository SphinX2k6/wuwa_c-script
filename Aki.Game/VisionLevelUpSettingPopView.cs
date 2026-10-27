using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024CE RID: 9422
public class VisionLevelUpSettingPopView : UiViewBase
{
	// Token: 0x06012EED RID: 77549 RVA: 0x004AEE65 File Offset: 0x004AD065
	[NullableContext(1)]
	public VisionLevelUpSettingPopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012EEE RID: 77550 RVA: 0x004AEE70 File Offset: 0x004AD070
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

	// Token: 0x06012EEF RID: 77551 RVA: 0x004AF003 File Offset: 0x004AD203
	private void OnDisableIdentifyToggleClick(EToggleState toggleState)
	{
		this.SetIdentify(EVisionLevelUpIdentify.DisableIdentify);
	}

	// Token: 0x06012EF0 RID: 77552 RVA: 0x004AF00C File Offset: 0x004AD20C
	private void OnEnableIdentifyToggleClick(EToggleState toggleState)
	{
		this.SetIdentify(EVisionLevelUpIdentify.EnableIdentify);
	}

	// Token: 0x06012EF1 RID: 77553 RVA: 0x004AF015 File Offset: 0x004AD215
	private void OnAllInModeToggleClick(EToggleState toggleState)
	{
		this.SetPutInMode(EVisionLevelUpMaterialPutInMode.AllIn);
	}

	// Token: 0x06012EF2 RID: 77554 RVA: 0x004AF01E File Offset: 0x004AD21E
	private void OnStepInModeToggleClick(EToggleState toggleState)
	{
		this.SetPutInMode(EVisionLevelUpMaterialPutInMode.StepIn);
	}

	// Token: 0x06012EF3 RID: 77555 RVA: 0x004AF027 File Offset: 0x004AD227
	private void OnOnlyLevelUpMaterialToggleClick(EToggleState toggleState)
	{
		this.SetUseType(EVisionLevelUpMaterialUseType.OnlyLevelUpMaterial);
	}

	// Token: 0x06012EF4 RID: 77556 RVA: 0x004AF030 File Offset: 0x004AD230
	private void OnBothLevelUpMaterialAndVisionToggleClick(EToggleState toggleState)
	{
		this.SetUseType(EVisionLevelUpMaterialUseType.BothLevelUpMaterialAndVision);
	}

	// Token: 0x06012EF5 RID: 77557 RVA: 0x004AF039 File Offset: 0x004AD239
	private void OnCancelButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012EF6 RID: 77558 RVA: 0x004AF042 File Offset: 0x004AD242
	private void OnConfirmButtonClick()
	{
		this.SaveSetting();
		base.CloseMe(null);
	}

	// Token: 0x06012EF7 RID: 77559 RVA: 0x004AF054 File Offset: 0x004AD254
	protected override void OnStart()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		this.PutInMode = instance.GetVisionLevelUpMaterialPutInMode();
		this.UseType = instance.GetVisionLevelUpMaterialUseType();
		this.Identify = instance.GetVisionLevelUpIdentify();
		this.Refresh();
	}

	// Token: 0x06012EF8 RID: 77560 RVA: 0x004AF091 File Offset: 0x004AD291
	public void Refresh()
	{
		this.RefreshPutInModeToggle();
		this.RefreshUseTypeToggle();
		this.RefreshIdentifyToggle();
	}

	// Token: 0x06012EF9 RID: 77561 RVA: 0x004AF0A8 File Offset: 0x004AD2A8
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

	// Token: 0x06012EFA RID: 77562 RVA: 0x004AF128 File Offset: 0x004AD328
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

	// Token: 0x06012EFB RID: 77563 RVA: 0x004AF1A8 File Offset: 0x004AD3A8
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

	// Token: 0x06012EFC RID: 77564 RVA: 0x004AF228 File Offset: 0x004AD428
	protected void SetPutInMode(EVisionLevelUpMaterialPutInMode mode)
	{
		this.PutInMode = mode;
		this.RefreshPutInModeToggle();
	}

	// Token: 0x06012EFD RID: 77565 RVA: 0x004AF237 File Offset: 0x004AD437
	protected void SetUseType(EVisionLevelUpMaterialUseType useType)
	{
		this.UseType = useType;
		this.RefreshUseTypeToggle();
	}

	// Token: 0x06012EFE RID: 77566 RVA: 0x004AF246 File Offset: 0x004AD446
	protected void SetIdentify(EVisionLevelUpIdentify identify)
	{
		this.Identify = identify;
		this.RefreshIdentifyToggle();
	}

	// Token: 0x06012EFF RID: 77567 RVA: 0x004AF255 File Offset: 0x004AD455
	protected void SaveSetting()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		instance.SetVisionLevelUpMaterialPutInMode(this.PutInMode);
		instance.SetVisionLevelUpMaterialUseType(this.UseType);
		instance.SetVisionLevelUpIdentify(this.Identify);
	}

	// Token: 0x04008EA2 RID: 36514
	private EVisionLevelUpMaterialPutInMode PutInMode;

	// Token: 0x04008EA3 RID: 36515
	private EVisionLevelUpMaterialUseType UseType;

	// Token: 0x04008EA4 RID: 36516
	private EVisionLevelUpIdentify Identify;

	// Token: 0x02008A59 RID: 35417
	private enum EComponent
	{
		// Token: 0x0402CEBD RID: 183997
		AllInModeToggle,
		// Token: 0x0402CEBE RID: 183998
		StepInModeToggle,
		// Token: 0x0402CEBF RID: 183999
		OnlyLevelUpMaterialToggle,
		// Token: 0x0402CEC0 RID: 184000
		BothLevelUpMaterialAndVisionToggle,
		// Token: 0x0402CEC1 RID: 184001
		CancelButton,
		// Token: 0x0402CEC2 RID: 184002
		ConfirmButton,
		// Token: 0x0402CEC3 RID: 184003
		DisableIdentifyToggle,
		// Token: 0x0402CEC4 RID: 184004
		EnableIdentifyToggle
	}
}
