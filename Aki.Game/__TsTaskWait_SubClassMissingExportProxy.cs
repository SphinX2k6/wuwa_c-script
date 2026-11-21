using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C52 RID: 11346
public class __TsTaskWait_SubClassMissingExportProxy : __TsTaskWait_InheritProxy
{
	// Token: 0x0601C0FB RID: 114939 RVA: 0x008AD8C8 File Offset: 0x008ABAC8
	[NullableContext(1)]
	protected __TsTaskWait_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0FC RID: 114940 RVA: 0x008AD8FB File Offset: 0x008ABAFB
	protected __TsTaskWait_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
