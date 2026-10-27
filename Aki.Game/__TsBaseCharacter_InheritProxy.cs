using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388A RID: 14474
public class __TsBaseCharacter_InheritProxy : TsBaseCharacter
{
	// Token: 0x0601E9CA RID: 125386 RVA: 0x00893E68 File Offset: 0x00892068
	[NullableContext(1)]
	public __TsBaseCharacter_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9CB RID: 125387 RVA: 0x00893E9B File Offset: 0x0089209B
	protected __TsBaseCharacter_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9CC RID: 125388 RVA: 0x00893EA4 File Offset: 0x008920A4
	protected unsafe override void __CPPCALL_K2_OnMovementModeChanged_Implementation(ACharacter.__K2_OnMovementModeChanged_FunctionParams* __Params)
	{
		EMovementMode prevMovementMode = __Params->PrevMovementMode;
		EMovementMode newMovementMode = __Params->NewMovementMode;
		base.K2_OnMovementModeChanged_Implementation(prevMovementMode, newMovementMode, __Params->PrevCustomMode, __Params->NewCustomMode);
	}

	// Token: 0x0601E9CD RID: 125389 RVA: 0x00893EDD File Offset: 0x008920DD
	protected unsafe override void __CPPCALL_BindGameplayEnableState_Implementation(TsBaseCharacter.__BindGameplayEnableState_FunctionParams* __Params)
	{
		base.BindGameplayEnableState_Implementation(ref __Params->gameplayEnable);
	}

	// Token: 0x0601E9CE RID: 125390 RVA: 0x00893EEC File Offset: 0x008920EC
	protected unsafe override void __CPPCALL_ReceivePossessed_Implementation(APawn.__ReceivePossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->NewController);
		base.ReceivePossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E9CF RID: 125391 RVA: 0x00893F0C File Offset: 0x0089210C
	protected unsafe override void __CPPCALL_ReceiveUnpossessed_Implementation(APawn.__ReceiveUnpossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->OldController);
		base.ReceiveUnpossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E9D0 RID: 125392 RVA: 0x00893F2C File Offset: 0x0089212C
	protected unsafe override void __CPPCALL_GetEntityId_Implementation(TsBaseCharacter.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityId_Implementation();
	}

	// Token: 0x0601E9D1 RID: 125393 RVA: 0x00893F3A File Offset: 0x0089213A
	protected override void __CPPCALL_Initialize_Implementation()
	{
		base.Initialize_Implementation();
	}

	// Token: 0x0601E9D2 RID: 125394 RVA: 0x00893F44 File Offset: 0x00892144
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(TsBaseCharacter.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x0601E9D3 RID: 125395 RVA: 0x00893F65 File Offset: 0x00892165
	protected unsafe override void __CPPCALL_K2_UpdateCustomMovement_Implementation(ACharacter.__K2_UpdateCustomMovement_FunctionParams* __Params)
	{
		base.K2_UpdateCustomMovement_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0601E9D4 RID: 125396 RVA: 0x00893F73 File Offset: 0x00892173
	protected unsafe override void __CPPCALL_FightCommand_Implementation(TsBaseCharacter.__FightCommand_FunctionParams* __Params)
	{
		base.FightCommand_Implementation(__Params->isInAir);
	}

	// Token: 0x0601E9D5 RID: 125397 RVA: 0x00893F81 File Offset: 0x00892181
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}
}
