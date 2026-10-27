using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388E RID: 14478
public class __TsAxisHandle_InheritProxy : TsAxisHandle
{
	// Token: 0x0601E9E5 RID: 125413 RVA: 0x00894400 File Offset: 0x00892600
	[NullableContext(1)]
	public __TsAxisHandle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9E6 RID: 125414 RVA: 0x00894433 File Offset: 0x00892633
	protected __TsAxisHandle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9E7 RID: 125415 RVA: 0x0089443C File Offset: 0x0089263C
	protected unsafe override void __CPPCALL_OnInputAxis_Implementation(TsAxisHandle.__OnInputAxis_FunctionParams* __Params)
	{
		base.OnInputAxis_Implementation(__Params->value);
	}
}
