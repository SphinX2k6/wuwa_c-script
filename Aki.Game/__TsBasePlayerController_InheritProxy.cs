using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003890 RID: 14480
public class __TsBasePlayerController_InheritProxy : TsBasePlayerController
{
	// Token: 0x0601E9EB RID: 125419 RVA: 0x00894500 File Offset: 0x00892700
	[NullableContext(1)]
	public __TsBasePlayerController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9EC RID: 125420 RVA: 0x00894533 File Offset: 0x00892733
	protected __TsBasePlayerController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9ED RID: 125421 RVA: 0x0089453C File Offset: 0x0089273C
	protected override void __CPPCALL_ReceiveSetupInputComponent_Implementation()
	{
		base.ReceiveSetupInputComponent_Implementation();
	}

	// Token: 0x0601E9EE RID: 125422 RVA: 0x00894544 File Offset: 0x00892744
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601E9EF RID: 125423 RVA: 0x0089454C File Offset: 0x0089274C
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601E9F0 RID: 125424 RVA: 0x00894554 File Offset: 0x00892754
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601E9F1 RID: 125425 RVA: 0x00894562 File Offset: 0x00892762
	protected override void __CPPCALL_OnReceivedPlayer_Implementation()
	{
		base.OnReceivedPlayer_Implementation();
	}

	// Token: 0x0601E9F2 RID: 125426 RVA: 0x0089456A File Offset: 0x0089276A
	protected override void __CPPCALL_InitInputHandle_Implementation()
	{
		base.InitInputHandle_Implementation();
	}

	// Token: 0x0601E9F3 RID: 125427 RVA: 0x00894572 File Offset: 0x00892772
	protected override void __CPPCALL_AddInputBinding_Implementation()
	{
		base.AddInputBinding_Implementation();
	}

	// Token: 0x0601E9F4 RID: 125428 RVA: 0x0089457A File Offset: 0x0089277A
	protected override void __CPPCALL_ClearInputBinding_Implementation()
	{
		base.ClearInputBinding_Implementation();
	}

	// Token: 0x0601E9F5 RID: 125429 RVA: 0x00894582 File Offset: 0x00892782
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
	}

	// Token: 0x0601E9F6 RID: 125430 RVA: 0x0089458A File Offset: 0x0089278A
	protected override void __CPPCALL_BindTouchHandle_Implementation()
	{
		base.BindTouchHandle_Implementation();
	}

	// Token: 0x0601E9F7 RID: 125431 RVA: 0x00894594 File Offset: 0x00892794
	protected unsafe override void __CPPCALL_OnTouchBegin_Implementation(TsBasePlayerController.__OnTouchBegin_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchBegin_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601E9F8 RID: 125432 RVA: 0x008945B8 File Offset: 0x008927B8
	protected unsafe override void __CPPCALL_OnTouchEnd_Implementation(TsBasePlayerController.__OnTouchEnd_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchEnd_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601E9F9 RID: 125433 RVA: 0x008945DC File Offset: 0x008927DC
	protected unsafe override void __CPPCALL_OnTouchMove_Implementation(TsBasePlayerController.__OnTouchMove_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchMove_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601E9FA RID: 125434 RVA: 0x00894600 File Offset: 0x00892800
	protected unsafe override void __CPPCALL_OnPressAnyKey_Implementation(TsBasePlayerController.__OnPressAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnPressAnyKey_Implementation(key);
	}

	// Token: 0x0601E9FB RID: 125435 RVA: 0x00894624 File Offset: 0x00892824
	protected unsafe override void __CPPCALL_OnReleaseAnyKey_Implementation(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnReleaseAnyKey_Implementation(key);
	}

	// Token: 0x0601E9FC RID: 125436 RVA: 0x00894648 File Offset: 0x00892848
	protected unsafe override void __CPPCALL_RemoveActionHandle_Implementation(TsBasePlayerController.__RemoveActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		base.RemoveActionHandle_Implementation(actionName);
	}

	// Token: 0x0601E9FD RID: 125437 RVA: 0x0089466C File Offset: 0x0089286C
	protected unsafe override void __CPPCALL_GetActionHandle_Implementation(TsBasePlayerController.__GetActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsActionHandle actionHandle_Implementation = base.GetActionHandle_Implementation(actionName);
		ptr = ((actionHandle_Implementation != null) ? actionHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601E9FE RID: 125438 RVA: 0x008946A4 File Offset: 0x008928A4
	protected unsafe override void __CPPCALL_RemoveAxisHandle_Implementation(TsBasePlayerController.__RemoveAxisHandle_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		base.RemoveAxisHandle_Implementation(axisName);
	}

	// Token: 0x0601E9FF RID: 125439 RVA: 0x008946C8 File Offset: 0x008928C8
	protected unsafe override void __CPPCALL_GetAxisHandle_Implementation(TsBasePlayerController.__GetAxisHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsAxisHandle axisHandle_Implementation = base.GetAxisHandle_Implementation(actionName);
		ptr = ((axisHandle_Implementation != null) ? axisHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601EA00 RID: 125440 RVA: 0x008946FE File Offset: 0x008928FE
	protected unsafe override void __CPPCALL_IsInTouch_Implementation(TsBasePlayerController.__IsInTouch_FunctionParams* __Params)
	{
		__Params->__Result = base.IsInTouch_Implementation(__Params->touchId);
	}

	// Token: 0x0601EA01 RID: 125441 RVA: 0x00894712 File Offset: 0x00892912
	protected unsafe override void __CPPCALL_SetIsPrintKeyName_Implementation(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* __Params)
	{
		base.SetIsPrintKeyName_Implementation(__Params->bPrintKeyName);
	}
}
