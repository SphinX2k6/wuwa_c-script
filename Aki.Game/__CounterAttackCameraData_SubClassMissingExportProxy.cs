using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E10 RID: 11792
public class __CounterAttackCameraData_SubClassMissingExportProxy : __CounterAttackCameraData_InheritProxy
{
	// Token: 0x0601C708 RID: 116488 RVA: 0x008BA924 File Offset: 0x008B8B24
	[NullableContext(1)]
	protected __CounterAttackCameraData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C709 RID: 116489 RVA: 0x008BA957 File Offset: 0x008B8B57
	protected __CounterAttackCameraData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
