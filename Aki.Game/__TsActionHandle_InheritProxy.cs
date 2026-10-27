using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388C RID: 14476
public class __TsActionHandle_InheritProxy : TsActionHandle
{
	// Token: 0x0601E9DD RID: 125405 RVA: 0x00894220 File Offset: 0x00892420
	[NullableContext(1)]
	public __TsActionHandle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9DE RID: 125406 RVA: 0x00894253 File Offset: 0x00892453
	protected __TsActionHandle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9DF RID: 125407 RVA: 0x0089425C File Offset: 0x0089245C
	protected unsafe override void __CPPCALL_OnPressAction_Implementation(TsActionHandle.__OnPressAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnPressAction_Implementation(key);
	}

	// Token: 0x0601E9E0 RID: 125408 RVA: 0x00894280 File Offset: 0x00892480
	protected unsafe override void __CPPCALL_OnReleaseAction_Implementation(TsActionHandle.__OnReleaseAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		base.OnReleaseAction_Implementation(key);
	}
}
