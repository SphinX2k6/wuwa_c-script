using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035BA RID: 13754
public class __TsDecoratorCheckSkillUsable_InheritProxy : TsDecoratorCheckSkillUsable
{
	// Token: 0x0601E0BD RID: 123069 RVA: 0x0087EE64 File Offset: 0x0087D064
	[NullableContext(1)]
	public __TsDecoratorCheckSkillUsable_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckSkillUsable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0BE RID: 123070 RVA: 0x0087EE97 File Offset: 0x0087D097
	protected __TsDecoratorCheckSkillUsable_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E0BF RID: 123071 RVA: 0x0087EEA0 File Offset: 0x0087D0A0
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
