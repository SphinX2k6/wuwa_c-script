using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003892 RID: 14482
public class __TsCharacterController_InheritProxy : TsCharacterController
{
	// Token: 0x0601EA14 RID: 125460 RVA: 0x00894F40 File Offset: 0x00893140
	[NullableContext(1)]
	public __TsCharacterController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA15 RID: 125461 RVA: 0x00894F73 File Offset: 0x00893173
	protected __TsCharacterController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA16 RID: 125462 RVA: 0x00894F7C File Offset: 0x0089317C
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EA17 RID: 125463 RVA: 0x00894F84 File Offset: 0x00893184
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601EA18 RID: 125464 RVA: 0x00894F8C File Offset: 0x0089318C
	protected unsafe override void __CPPCALL_ReceivePossess_Implementation(AController.__ReceivePossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->PossessedPawn);
		base.ReceivePossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA19 RID: 125465 RVA: 0x00894FAC File Offset: 0x008931AC
	protected unsafe override void __CPPCALL_ReceiveUnPossess_Implementation(AController.__ReceiveUnPossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->UnpossessedPawn);
		base.ReceiveUnPossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA1A RID: 125466 RVA: 0x00894FCC File Offset: 0x008931CC
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
	}

	// Token: 0x0601EA1B RID: 125467 RVA: 0x00894FD4 File Offset: 0x008931D4
	protected unsafe override void __CPPCALL_ReceivePreProcessInput_Implementation(ABasePlayerController.__ReceivePreProcessInput_FunctionParams* __Params)
	{
		base.ReceivePreProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x0601EA1C RID: 125468 RVA: 0x00894FE8 File Offset: 0x008931E8
	protected unsafe override void __CPPCALL_ReceivePostProcessInput_Implementation(ABasePlayerController.__ReceivePostProcessInput_FunctionParams* __Params)
	{
		base.ReceivePostProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x0601EA1D RID: 125469 RVA: 0x00894FFC File Offset: 0x008931FC
	protected override void __CPPCALL_OnSetUiRootActive_Implementation()
	{
		base.OnSetUiRootActive_Implementation();
	}

	// Token: 0x0601EA1E RID: 125470 RVA: 0x00895004 File Offset: 0x00893204
	protected override void __CPPCALL_OnSetUiRootDeactivate_Implementation()
	{
		base.OnSetUiRootDeactivate_Implementation();
	}
}
