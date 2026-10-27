using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C6 RID: 14534
public class __TsSceneUiTag_InheritProxy : TsSceneUiTag
{
	// Token: 0x0601EAD6 RID: 125654 RVA: 0x008971C4 File Offset: 0x008953C4
	[NullableContext(1)]
	public __TsSceneUiTag_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAD7 RID: 125655 RVA: 0x008971F7 File Offset: 0x008953F7
	protected __TsSceneUiTag_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAD8 RID: 125656 RVA: 0x00897200 File Offset: 0x00895400
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EAD9 RID: 125657 RVA: 0x00897208 File Offset: 0x00895408
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601EADA RID: 125658 RVA: 0x00897228 File Offset: 0x00895428
	protected unsafe override void __CPPCALL_OnCanTick_Implementation(TsSceneUiTag.__OnCanTick_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCanTick_Implementation();
	}
}
