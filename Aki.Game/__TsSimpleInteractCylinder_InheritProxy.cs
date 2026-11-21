using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBF RID: 11967
public class __TsSimpleInteractCylinder_InheritProxy : TsSimpleInteractCylinder
{
	// Token: 0x0601C8E1 RID: 116961 RVA: 0x008BDA14 File Offset: 0x008BBC14
	[NullableContext(1)]
	public __TsSimpleInteractCylinder_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractCylinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8E2 RID: 116962 RVA: 0x008BDA47 File Offset: 0x008BBC47
	protected __TsSimpleInteractCylinder_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
