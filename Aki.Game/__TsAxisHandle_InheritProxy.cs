using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E07 RID: 11783
public class __TsAxisHandle_InheritProxy : TsAxisHandle
{
	// Token: 0x0601C6D7 RID: 116439 RVA: 0x008BA484 File Offset: 0x008B8684
	[NullableContext(1)]
	public __TsAxisHandle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6D8 RID: 116440 RVA: 0x008BA4B7 File Offset: 0x008B86B7
	protected __TsAxisHandle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C6D9 RID: 116441 RVA: 0x008BA4C0 File Offset: 0x008B86C0
	protected unsafe override void __CPPCALL_OnInputAxis_Implementation(TsAxisHandle.__OnInputAxis_FunctionParams* __Params)
	{
		base.OnInputAxis_Implementation(__Params->value);
	}
}
