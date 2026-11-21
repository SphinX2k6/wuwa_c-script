using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E09 RID: 11785
public class __TsBasePlayerController_InheritProxy : TsBasePlayerController
{
	// Token: 0x0601C6DC RID: 116444 RVA: 0x008BA50C File Offset: 0x008B870C
	[NullableContext(1)]
	public __TsBasePlayerController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6DD RID: 116445 RVA: 0x008BA53F File Offset: 0x008B873F
	protected __TsBasePlayerController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C6DE RID: 116446 RVA: 0x008BA548 File Offset: 0x008B8748
	protected override void __CPPCALL_ReceiveSetupInputComponent_Implementation()
	{
		base.ReceiveSetupInputComponent_Implementation();
	}

	// Token: 0x0601C6DF RID: 116447 RVA: 0x008BA550 File Offset: 0x008B8750
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C6E0 RID: 116448 RVA: 0x008BA558 File Offset: 0x008B8758
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601C6E1 RID: 116449 RVA: 0x008BA560 File Offset: 0x008B8760
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C6E2 RID: 116450 RVA: 0x008BA56E File Offset: 0x008B876E
	protected override void __CPPCALL_OnReceivedPlayer_Implementation()
	{
		base.OnReceivedPlayer_Implementation();
	}

	// Token: 0x0601C6E3 RID: 116451 RVA: 0x008BA576 File Offset: 0x008B8776
	protected override void __CPPCALL_InitInputHandle_Implementation()
	{
		base.InitInputHandle_Implementation();
	}

	// Token: 0x0601C6E4 RID: 116452 RVA: 0x008BA57E File Offset: 0x008B877E
	protected override void __CPPCALL_AddInputBinding_Implementation()
	{
		base.AddInputBinding_Implementation();
	}

	// Token: 0x0601C6E5 RID: 116453 RVA: 0x008BA586 File Offset: 0x008B8786
	protected override void __CPPCALL_ClearInputBinding_Implementation()
	{
		base.ClearInputBinding_Implementation();
	}

	// Token: 0x0601C6E6 RID: 116454 RVA: 0x008BA58E File Offset: 0x008B878E
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
	}

	// Token: 0x0601C6E7 RID: 116455 RVA: 0x008BA596 File Offset: 0x008B8796
	protected override void __CPPCALL_BindTouchHandle_Implementation()
	{
		base.BindTouchHandle_Implementation();
	}

	// Token: 0x0601C6E8 RID: 116456 RVA: 0x008BA5A0 File Offset: 0x008B87A0
	protected unsafe override void __CPPCALL_OnTouchBegin_Implementation(TsBasePlayerController.__OnTouchBegin_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchBegin_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601C6E9 RID: 116457 RVA: 0x008BA5C4 File Offset: 0x008B87C4
	protected unsafe override void __CPPCALL_OnTouchEnd_Implementation(TsBasePlayerController.__OnTouchEnd_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchEnd_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601C6EA RID: 116458 RVA: 0x008BA5E8 File Offset: 0x008B87E8
	protected unsafe override void __CPPCALL_OnTouchMove_Implementation(TsBasePlayerController.__OnTouchMove_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		base.OnTouchMove_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0601C6EB RID: 116459 RVA: 0x008BA60C File Offset: 0x008B880C
	protected unsafe override void __CPPCALL_OnPressAnyKey_Implementation(TsBasePlayerController.__OnPressAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnPressAnyKey_Implementation(key);
	}

	// Token: 0x0601C6EC RID: 116460 RVA: 0x008BA630 File Offset: 0x008B8830
	protected unsafe override void __CPPCALL_OnReleaseAnyKey_Implementation(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnReleaseAnyKey_Implementation(key);
	}

	// Token: 0x0601C6ED RID: 116461 RVA: 0x008BA654 File Offset: 0x008B8854
	protected unsafe override void __CPPCALL_RemoveActionHandle_Implementation(TsBasePlayerController.__RemoveActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		base.RemoveActionHandle_Implementation(actionName);
	}

	// Token: 0x0601C6EE RID: 116462 RVA: 0x008BA678 File Offset: 0x008B8878
	protected unsafe override void __CPPCALL_GetActionHandle_Implementation(TsBasePlayerController.__GetActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsActionHandle actionHandle_Implementation = base.GetActionHandle_Implementation(actionName);
		ptr = ((actionHandle_Implementation != null) ? actionHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601C6EF RID: 116463 RVA: 0x008BA6B0 File Offset: 0x008B88B0
	protected unsafe override void __CPPCALL_RemoveAxisHandle_Implementation(TsBasePlayerController.__RemoveAxisHandle_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		base.RemoveAxisHandle_Implementation(axisName);
	}

	// Token: 0x0601C6F0 RID: 116464 RVA: 0x008BA6D4 File Offset: 0x008B88D4
	protected unsafe override void __CPPCALL_GetAxisHandle_Implementation(TsBasePlayerController.__GetAxisHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsAxisHandle axisHandle_Implementation = base.GetAxisHandle_Implementation(actionName);
		ptr = ((axisHandle_Implementation != null) ? axisHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601C6F1 RID: 116465 RVA: 0x008BA70A File Offset: 0x008B890A
	protected unsafe override void __CPPCALL_IsInTouch_Implementation(TsBasePlayerController.__IsInTouch_FunctionParams* __Params)
	{
		__Params->__Result = base.IsInTouch_Implementation(__Params->touchId);
	}

	// Token: 0x0601C6F2 RID: 116466 RVA: 0x008BA71E File Offset: 0x008B891E
	protected unsafe override void __CPPCALL_SetIsPrintKeyName_Implementation(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* __Params)
	{
		base.SetIsPrintKeyName_Implementation(__Params->bPrintKeyName);
	}
}
