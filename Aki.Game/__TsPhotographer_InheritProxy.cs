using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038BE RID: 14526
public class __TsPhotographer_InheritProxy : TsPhotographer
{
	// Token: 0x0601EAA0 RID: 125600 RVA: 0x00896688 File Offset: 0x00894888
	[NullableContext(1)]
	public __TsPhotographer_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAA1 RID: 125601 RVA: 0x008966BB File Offset: 0x008948BB
	protected __TsPhotographer_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAA2 RID: 125602 RVA: 0x008966C4 File Offset: 0x008948C4
	protected override void __CPPCALL_Initialize_Implementation()
	{
		base.Initialize_Implementation();
	}

	// Token: 0x0601EAA3 RID: 125603 RVA: 0x008966CC File Offset: 0x008948CC
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601EAA4 RID: 125604 RVA: 0x008966D4 File Offset: 0x008948D4
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EAA5 RID: 125605 RVA: 0x008966E2 File Offset: 0x008948E2
	protected override void __CPPCALL_RefreshPlayerLocation_Implementation()
	{
		base.RefreshPlayerLocation_Implementation();
	}

	// Token: 0x0601EAA6 RID: 125606 RVA: 0x008966EA File Offset: 0x008948EA
	protected unsafe override void __CPPCALL_SetPlayerSourceLocation_Implementation(TsPhotographer.__SetPlayerSourceLocation_FunctionParams* __Params)
	{
		base.SetPlayerSourceLocation_Implementation(__Params->location);
	}

	// Token: 0x0601EAA7 RID: 125607 RVA: 0x008966F8 File Offset: 0x008948F8
	protected unsafe override void __CPPCALL_SetCameraInitializeTransform_Implementation(TsPhotographer.__SetCameraInitializeTransform_FunctionParams* __Params)
	{
		base.SetCameraInitializeTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601EAA8 RID: 125608 RVA: 0x00896706 File Offset: 0x00894906
	protected unsafe override void __CPPCALL_GetCameraInitializeTransform_Implementation(TsPhotographer.__GetCameraInitializeTransform_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCameraInitializeTransform_Implementation();
	}

	// Token: 0x0601EAA9 RID: 125609 RVA: 0x00896714 File Offset: 0x00894914
	protected unsafe override void __CPPCALL_SetCameraInitializeFov_Implementation(TsPhotographer.__SetCameraInitializeFov_FunctionParams* __Params)
	{
		base.SetCameraInitializeFov_Implementation(__Params->fov);
	}

	// Token: 0x0601EAAA RID: 125610 RVA: 0x00896722 File Offset: 0x00894922
	protected unsafe override void __CPPCALL_GetCameraInitializeFov_Implementation(TsPhotographer.__GetCameraInitializeFov_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCameraInitializeFov_Implementation();
	}

	// Token: 0x0601EAAB RID: 125611 RVA: 0x00896730 File Offset: 0x00894930
	protected unsafe override void __CPPCALL_SetCameraArmTargetOffset_Implementation(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* __Params)
	{
		base.SetCameraArmTargetOffset_Implementation(__Params->cameraLocation, __Params->isInit);
	}

	// Token: 0x0601EAAC RID: 125612 RVA: 0x00896744 File Offset: 0x00894944
	protected unsafe override void __CPPCALL_MoveUp_Implementation(TsPhotographer.__MoveUp_FunctionParams* __Params)
	{
		base.MoveUp_Implementation(__Params->addValue);
	}

	// Token: 0x0601EAAD RID: 125613 RVA: 0x00896752 File Offset: 0x00894952
	protected unsafe override void __CPPCALL_MoveRight_Implementation(TsPhotographer.__MoveRight_FunctionParams* __Params)
	{
		base.MoveRight_Implementation(__Params->addValue);
	}

	// Token: 0x0601EAAE RID: 125614 RVA: 0x00896760 File Offset: 0x00894960
	protected unsafe override void __CPPCALL_MoveForward_Implementation(TsPhotographer.__MoveForward_FunctionParams* __Params)
	{
		base.MoveForward_Implementation(__Params->addValue);
	}

	// Token: 0x0601EAAF RID: 125615 RVA: 0x0089676E File Offset: 0x0089496E
	protected unsafe override void __CPPCALL_SetFov_Implementation(TsPhotographer.__SetFov_FunctionParams* __Params)
	{
		base.SetFov_Implementation(__Params->fov);
	}

	// Token: 0x0601EAB0 RID: 125616 RVA: 0x0089677C File Offset: 0x0089497C
	protected unsafe override void __CPPCALL_GetFov_Implementation(TsPhotographer.__GetFov_FunctionParams* __Params)
	{
		__Params->__Result = base.GetFov_Implementation();
	}

	// Token: 0x0601EAB1 RID: 125617 RVA: 0x0089678A File Offset: 0x0089498A
	protected override void __CPPCALL_ResetCamera_Implementation()
	{
		base.ResetCamera_Implementation();
	}

	// Token: 0x0601EAB2 RID: 125618 RVA: 0x00896794 File Offset: 0x00894994
	protected unsafe override void __CPPCALL_SetCameraLUT_Implementation(TsPhotographer.__SetCameraLUT_FunctionParams* __Params)
	{
		string cameraLUT_Implementation = FString.ToString((void*)(&__Params->texturePath));
		base.SetCameraLUT_Implementation(cameraLUT_Implementation);
	}
}
