using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035EE RID: 13806
public class __TsServiceSimpleSense_InheritProxy : TsServiceSimpleSense
{
	// Token: 0x0601E140 RID: 123200 RVA: 0x0088000C File Offset: 0x0087E20C
	[NullableContext(1)]
	public __TsServiceSimpleSense_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E141 RID: 123201 RVA: 0x0088003F File Offset: 0x0087E23F
	protected __TsServiceSimpleSense_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E142 RID: 123202 RVA: 0x00880048 File Offset: 0x0087E248
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
