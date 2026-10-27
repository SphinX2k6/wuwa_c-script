using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035F0 RID: 13808
public class __TsTaskAnimalDestroySelf_InheritProxy : TsTaskAnimalDestroySelf
{
	// Token: 0x0601E145 RID: 123205 RVA: 0x008800B8 File Offset: 0x0087E2B8
	[NullableContext(1)]
	public __TsTaskAnimalDestroySelf_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDestroySelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E146 RID: 123206 RVA: 0x008800EB File Offset: 0x0087E2EB
	protected __TsTaskAnimalDestroySelf_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E147 RID: 123207 RVA: 0x008800F4 File Offset: 0x0087E2F4
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
