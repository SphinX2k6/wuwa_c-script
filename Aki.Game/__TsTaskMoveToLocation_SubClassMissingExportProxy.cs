using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003691 RID: 13969
public class __TsTaskMoveToLocation_SubClassMissingExportProxy : __TsTaskMoveToLocation_InheritProxy
{
	// Token: 0x0601E314 RID: 123668 RVA: 0x00884324 File Offset: 0x00882524
	[NullableContext(1)]
	protected __TsTaskMoveToLocation_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E315 RID: 123669 RVA: 0x00884357 File Offset: 0x00882557
	protected __TsTaskMoveToLocation_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
