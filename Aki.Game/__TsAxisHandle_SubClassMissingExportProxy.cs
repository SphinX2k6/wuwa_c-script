using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E08 RID: 11784
public class __TsAxisHandle_SubClassMissingExportProxy : __TsAxisHandle_InheritProxy
{
	// Token: 0x0601C6DA RID: 116442 RVA: 0x008BA4D0 File Offset: 0x008B86D0
	[NullableContext(1)]
	protected __TsAxisHandle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6DB RID: 116443 RVA: 0x008BA503 File Offset: 0x008B8703
	protected __TsAxisHandle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
