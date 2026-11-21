using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E3F RID: 11839
public class __TsSceneUiTag_InheritProxy : TsSceneUiTag
{
	// Token: 0x0601C791 RID: 116625 RVA: 0x008BB7D0 File Offset: 0x008B99D0
	[NullableContext(1)]
	public __TsSceneUiTag_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C792 RID: 116626 RVA: 0x008BB803 File Offset: 0x008B9A03
	protected __TsSceneUiTag_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C793 RID: 116627 RVA: 0x008BB80C File Offset: 0x008B9A0C
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C794 RID: 116628 RVA: 0x008BB814 File Offset: 0x008B9A14
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C795 RID: 116629 RVA: 0x008BB834 File Offset: 0x008B9A34
	protected unsafe override void __CPPCALL_OnCanTick_Implementation(TsSceneUiTag.__OnCanTick_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCanTick_Implementation();
	}
}
