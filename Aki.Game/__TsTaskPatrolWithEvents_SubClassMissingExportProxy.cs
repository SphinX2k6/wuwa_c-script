using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B94 RID: 11156
public class __TsTaskPatrolWithEvents_SubClassMissingExportProxy : __TsTaskPatrolWithEvents_InheritProxy
{
	// Token: 0x0601BEEC RID: 114412 RVA: 0x008A92A0 File Offset: 0x008A74A0
	[NullableContext(1)]
	protected __TsTaskPatrolWithEvents_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BEED RID: 114413 RVA: 0x008A92D3 File Offset: 0x008A74D3
	protected __TsTaskPatrolWithEvents_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
