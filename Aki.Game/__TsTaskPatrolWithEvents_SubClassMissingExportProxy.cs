using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200361F RID: 13855
public class __TsTaskPatrolWithEvents_SubClassMissingExportProxy : __TsTaskPatrolWithEvents_InheritProxy
{
	// Token: 0x0601E1C4 RID: 123332 RVA: 0x0088120C File Offset: 0x0087F40C
	[NullableContext(1)]
	protected __TsTaskPatrolWithEvents_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1C5 RID: 123333 RVA: 0x0088123F File Offset: 0x0087F43F
	protected __TsTaskPatrolWithEvents_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
