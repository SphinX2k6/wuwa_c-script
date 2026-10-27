using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003946 RID: 14662
public class __TsSimpleInteractHookPoint_InheritProxy : TsSimpleInteractHookPoint
{
	// Token: 0x0601EC41 RID: 126017 RVA: 0x0089A080 File Offset: 0x00898280
	[NullableContext(1)]
	public __TsSimpleInteractHookPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC42 RID: 126018 RVA: 0x0089A0B3 File Offset: 0x008982B3
	protected __TsSimpleInteractHookPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
