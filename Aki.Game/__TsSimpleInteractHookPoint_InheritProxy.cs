using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC1 RID: 11969
public class __TsSimpleInteractHookPoint_InheritProxy : TsSimpleInteractHookPoint
{
	// Token: 0x0601C8E5 RID: 116965 RVA: 0x008BDA8C File Offset: 0x008BBC8C
	[NullableContext(1)]
	public __TsSimpleInteractHookPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8E6 RID: 116966 RVA: 0x008BDABF File Offset: 0x008BBCBF
	protected __TsSimpleInteractHookPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
