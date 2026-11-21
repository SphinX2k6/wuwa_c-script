using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E37 RID: 11831
public class __TsPhotographer_InheritProxy : TsPhotographer
{
	// Token: 0x0601C76D RID: 116589 RVA: 0x008BB4E4 File Offset: 0x008B96E4
	[NullableContext(1)]
	public __TsPhotographer_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C76E RID: 116590 RVA: 0x008BB517 File Offset: 0x008B9717
	protected __TsPhotographer_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C76F RID: 116591 RVA: 0x008BB520 File Offset: 0x008B9720
	protected override void __CPPCALL_Initialize_Implementation()
	{
		base.Initialize_Implementation();
	}

	// Token: 0x0601C770 RID: 116592 RVA: 0x008BB528 File Offset: 0x008B9728
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601C771 RID: 116593 RVA: 0x008BB530 File Offset: 0x008B9730
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C772 RID: 116594 RVA: 0x008BB53E File Offset: 0x008B973E
	protected override void __CPPCALL_RefreshPlayerLocation_Implementation()
	{
		base.RefreshPlayerLocation_Implementation();
	}

	// Token: 0x0601C773 RID: 116595 RVA: 0x008BB546 File Offset: 0x008B9746
	protected unsafe override void __CPPCALL_SetPlayerSourceLocation_Implementation(TsPhotographer.__SetPlayerSourceLocation_FunctionParams* __Params)
	{
		base.SetPlayerSourceLocation_Implementation(__Params->location);
	}

	// Token: 0x0601C774 RID: 116596 RVA: 0x008BB554 File Offset: 0x008B9754
	protected unsafe override void __CPPCALL_SetCameraInitializeTransform_Implementation(TsPhotographer.__SetCameraInitializeTransform_FunctionParams* __Params)
	{
		base.SetCameraInitializeTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601C775 RID: 116597 RVA: 0x008BB562 File Offset: 0x008B9762
	protected unsafe override void __CPPCALL_GetCameraInitializeTransform_Implementation(TsPhotographer.__GetCameraInitializeTransform_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCameraInitializeTransform_Implementation();
	}

	// Token: 0x0601C776 RID: 116598 RVA: 0x008BB570 File Offset: 0x008B9770
	protected unsafe override void __CPPCALL_SetCameraInitializeFov_Implementation(TsPhotographer.__SetCameraInitializeFov_FunctionParams* __Params)
	{
		base.SetCameraInitializeFov_Implementation(__Params->fov);
	}

	// Token: 0x0601C777 RID: 116599 RVA: 0x008BB57E File Offset: 0x008B977E
	protected unsafe override void __CPPCALL_GetCameraInitializeFov_Implementation(TsPhotographer.__GetCameraInitializeFov_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCameraInitializeFov_Implementation();
	}

	// Token: 0x0601C778 RID: 116600 RVA: 0x008BB58C File Offset: 0x008B978C
	protected unsafe override void __CPPCALL_SetCameraArmTargetOffset_Implementation(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* __Params)
	{
		base.SetCameraArmTargetOffset_Implementation(__Params->cameraLocation, __Params->isInit);
	}

	// Token: 0x0601C779 RID: 116601 RVA: 0x008BB5A0 File Offset: 0x008B97A0
	protected unsafe override void __CPPCALL_MoveUp_Implementation(TsPhotographer.__MoveUp_FunctionParams* __Params)
	{
		base.MoveUp_Implementation(__Params->addValue);
	}

	// Token: 0x0601C77A RID: 116602 RVA: 0x008BB5AE File Offset: 0x008B97AE
	protected unsafe override void __CPPCALL_MoveRight_Implementation(TsPhotographer.__MoveRight_FunctionParams* __Params)
	{
		base.MoveRight_Implementation(__Params->addValue);
	}

	// Token: 0x0601C77B RID: 116603 RVA: 0x008BB5BC File Offset: 0x008B97BC
	protected unsafe override void __CPPCALL_MoveForward_Implementation(TsPhotographer.__MoveForward_FunctionParams* __Params)
	{
		base.MoveForward_Implementation(__Params->addValue);
	}

	// Token: 0x0601C77C RID: 116604 RVA: 0x008BB5CA File Offset: 0x008B97CA
	protected unsafe override void __CPPCALL_SetFov_Implementation(TsPhotographer.__SetFov_FunctionParams* __Params)
	{
		base.SetFov_Implementation(__Params->fov);
	}

	// Token: 0x0601C77D RID: 116605 RVA: 0x008BB5D8 File Offset: 0x008B97D8
	protected unsafe override void __CPPCALL_GetFov_Implementation(TsPhotographer.__GetFov_FunctionParams* __Params)
	{
		__Params->__Result = base.GetFov_Implementation();
	}

	// Token: 0x0601C77E RID: 116606 RVA: 0x008BB5E6 File Offset: 0x008B97E6
	protected override void __CPPCALL_ResetCamera_Implementation()
	{
		base.ResetCamera_Implementation();
	}

	// Token: 0x0601C77F RID: 116607 RVA: 0x008BB5F0 File Offset: 0x008B97F0
	protected unsafe override void __CPPCALL_SetCameraLUT_Implementation(TsPhotographer.__SetCameraLUT_FunctionParams* __Params)
	{
		string cameraLUT_Implementation = FString.ToString((void*)(&__Params->texturePath));
		base.SetCameraLUT_Implementation(cameraLUT_Implementation);
	}
}
