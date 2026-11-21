using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AEB RID: 10987
public class __TsDecoratorCheckNpcMovingToVehicle_InheritProxy : TsDecoratorCheckNpcMovingToVehicle
{
	// Token: 0x0601BD39 RID: 113977 RVA: 0x008A57B4 File Offset: 0x008A39B4
	[NullableContext(1)]
	public __TsDecoratorCheckNpcMovingToVehicle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcMovingToVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD3A RID: 113978 RVA: 0x008A57E7 File Offset: 0x008A39E7
	protected __TsDecoratorCheckNpcMovingToVehicle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD3B RID: 113979 RVA: 0x008A57F0 File Offset: 0x008A39F0
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
