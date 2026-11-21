using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E03 RID: 11779
public class __TsBaseCharacter_InheritProxy : TsBaseCharacter
{
	// Token: 0x0601C6C3 RID: 116419 RVA: 0x008BA264 File Offset: 0x008B8464
	[NullableContext(1)]
	public __TsBaseCharacter_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6C4 RID: 116420 RVA: 0x008BA297 File Offset: 0x008B8497
	protected __TsBaseCharacter_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C6C5 RID: 116421 RVA: 0x008BA2A0 File Offset: 0x008B84A0
	protected unsafe override void __CPPCALL_K2_OnMovementModeChanged_Implementation(ACharacter.__K2_OnMovementModeChanged_FunctionParams* __Params)
	{
		EMovementMode prevMovementMode = __Params->PrevMovementMode;
		EMovementMode newMovementMode = __Params->NewMovementMode;
		base.K2_OnMovementModeChanged_Implementation(prevMovementMode, newMovementMode, __Params->PrevCustomMode, __Params->NewCustomMode);
	}

	// Token: 0x0601C6C6 RID: 116422 RVA: 0x008BA2D9 File Offset: 0x008B84D9
	protected unsafe override void __CPPCALL_BindGameplayEnableState_Implementation(TsBaseCharacter.__BindGameplayEnableState_FunctionParams* __Params)
	{
		base.BindGameplayEnableState_Implementation(ref __Params->gameplayEnable);
	}

	// Token: 0x0601C6C7 RID: 116423 RVA: 0x008BA2E8 File Offset: 0x008B84E8
	protected unsafe override void __CPPCALL_ReceivePossessed_Implementation(APawn.__ReceivePossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->NewController);
		base.ReceivePossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C6C8 RID: 116424 RVA: 0x008BA308 File Offset: 0x008B8508
	protected unsafe override void __CPPCALL_ReceiveUnpossessed_Implementation(APawn.__ReceiveUnpossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->OldController);
		base.ReceiveUnpossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C6C9 RID: 116425 RVA: 0x008BA328 File Offset: 0x008B8528
	protected unsafe override void __CPPCALL_GetEntityId_Implementation(TsBaseCharacter.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityId_Implementation();
	}

	// Token: 0x0601C6CA RID: 116426 RVA: 0x008BA336 File Offset: 0x008B8536
	protected override void __CPPCALL_Initialize_Implementation()
	{
		base.Initialize_Implementation();
	}

	// Token: 0x0601C6CB RID: 116427 RVA: 0x008BA340 File Offset: 0x008B8540
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(TsBaseCharacter.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x0601C6CC RID: 116428 RVA: 0x008BA361 File Offset: 0x008B8561
	protected unsafe override void __CPPCALL_K2_UpdateCustomMovement_Implementation(ACharacter.__K2_UpdateCustomMovement_FunctionParams* __Params)
	{
		base.K2_UpdateCustomMovement_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0601C6CD RID: 116429 RVA: 0x008BA36F File Offset: 0x008B856F
	protected unsafe override void __CPPCALL_FightCommand_Implementation(TsBaseCharacter.__FightCommand_FunctionParams* __Params)
	{
		base.FightCommand_Implementation(__Params->isInAir);
	}

	// Token: 0x0601C6CE RID: 116430 RVA: 0x008BA37D File Offset: 0x008B857D
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}
}
