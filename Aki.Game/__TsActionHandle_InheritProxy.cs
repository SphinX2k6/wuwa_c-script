using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E05 RID: 11781
public class __TsActionHandle_InheritProxy : TsActionHandle
{
	// Token: 0x0601C6D1 RID: 116433 RVA: 0x008BA3C4 File Offset: 0x008B85C4
	[NullableContext(1)]
	public __TsActionHandle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6D2 RID: 116434 RVA: 0x008BA3F7 File Offset: 0x008B85F7
	protected __TsActionHandle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C6D3 RID: 116435 RVA: 0x008BA400 File Offset: 0x008B8600
	protected unsafe override void __CPPCALL_OnPressAction_Implementation(TsActionHandle.__OnPressAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnPressAction_Implementation(key);
	}

	// Token: 0x0601C6D4 RID: 116436 RVA: 0x008BA424 File Offset: 0x008B8624
	protected unsafe override void __CPPCALL_OnReleaseAction_Implementation(TsActionHandle.__OnReleaseAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnReleaseAction_Implementation(key);
	}
}
