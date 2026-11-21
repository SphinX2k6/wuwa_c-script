using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0B RID: 11787
public class __TsCharacterController_InheritProxy : TsCharacterController
{
	// Token: 0x0601C6F5 RID: 116469 RVA: 0x008BA768 File Offset: 0x008B8968
	[NullableContext(1)]
	public __TsCharacterController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6F6 RID: 116470 RVA: 0x008BA79B File Offset: 0x008B899B
	protected __TsCharacterController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C6F7 RID: 116471 RVA: 0x008BA7A4 File Offset: 0x008B89A4
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C6F8 RID: 116472 RVA: 0x008BA7AC File Offset: 0x008B89AC
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601C6F9 RID: 116473 RVA: 0x008BA7B4 File Offset: 0x008B89B4
	protected unsafe override void __CPPCALL_ReceivePossess_Implementation(AController.__ReceivePossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->PossessedPawn);
		base.ReceivePossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C6FA RID: 116474 RVA: 0x008BA7D4 File Offset: 0x008B89D4
	protected unsafe override void __CPPCALL_ReceiveUnPossess_Implementation(AController.__ReceiveUnPossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->UnpossessedPawn);
		base.ReceiveUnPossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C6FB RID: 116475 RVA: 0x008BA7F4 File Offset: 0x008B89F4
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
	}

	// Token: 0x0601C6FC RID: 116476 RVA: 0x008BA7FC File Offset: 0x008B89FC
	protected unsafe override void __CPPCALL_ReceivePreProcessInput_Implementation(ABasePlayerController.__ReceivePreProcessInput_FunctionParams* __Params)
	{
		base.ReceivePreProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x0601C6FD RID: 116477 RVA: 0x008BA810 File Offset: 0x008B8A10
	protected unsafe override void __CPPCALL_ReceivePostProcessInput_Implementation(ABasePlayerController.__ReceivePostProcessInput_FunctionParams* __Params)
	{
		base.ReceivePostProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x0601C6FE RID: 116478 RVA: 0x008BA824 File Offset: 0x008B8A24
	protected override void __CPPCALL_OnSetUiRootActive_Implementation()
	{
		base.OnSetUiRootActive_Implementation();
	}

	// Token: 0x0601C6FF RID: 116479 RVA: 0x008BA82C File Offset: 0x008B8A2C
	protected override void __CPPCALL_OnSetUiRootDeactivate_Implementation()
	{
		base.OnSetUiRootDeactivate_Implementation();
	}
}
