using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C08 RID: 11272
public class __TsTaskPatrol_SubClassMissingExportProxy : __TsTaskPatrol_InheritProxy
{
	// Token: 0x0601C033 RID: 114739 RVA: 0x008ABDD8 File Offset: 0x008A9FD8
	[NullableContext(1)]
	protected __TsTaskPatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C034 RID: 114740 RVA: 0x008ABE0B File Offset: 0x008AA00B
	protected __TsTaskPatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
