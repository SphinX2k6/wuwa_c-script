using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035EA RID: 13802
public class __TsServiceAnimalPerception_InheritProxy : TsServiceAnimalPerception
{
	// Token: 0x0601E135 RID: 123189 RVA: 0x0087FE84 File Offset: 0x0087E084
	[NullableContext(1)]
	public __TsServiceAnimalPerception_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceAnimalPerception.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E136 RID: 123190 RVA: 0x0087FEB7 File Offset: 0x0087E0B7
	protected __TsServiceAnimalPerception_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E137 RID: 123191 RVA: 0x0087FEC0 File Offset: 0x0087E0C0
	protected unsafe override void __CPPCALL_ReceiveActivationAI_Implementation(UBTService_BlueprintBase.__ReceiveActivationAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveActivationAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E138 RID: 123192 RVA: 0x0087FEF0 File Offset: 0x0087E0F0
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
