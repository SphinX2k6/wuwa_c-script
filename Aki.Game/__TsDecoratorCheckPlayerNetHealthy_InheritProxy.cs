using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B8 RID: 13752
public class __TsDecoratorCheckPlayerNetHealthy_InheritProxy : TsDecoratorCheckPlayerNetHealthy
{
	// Token: 0x0601E0B8 RID: 123064 RVA: 0x0087EDB8 File Offset: 0x0087CFB8
	[NullableContext(1)]
	public __TsDecoratorCheckPlayerNetHealthy_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckPlayerNetHealthy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0B9 RID: 123065 RVA: 0x0087EDEB File Offset: 0x0087CFEB
	protected __TsDecoratorCheckPlayerNetHealthy_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E0BA RID: 123066 RVA: 0x0087EDF4 File Offset: 0x0087CFF4
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
