using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B84 RID: 11140
public class __TsTaskLog_SubClassMissingExportProxy : __TsTaskLog_InheritProxy
{
	// Token: 0x0601BEC0 RID: 114368 RVA: 0x008A8C90 File Offset: 0x008A6E90
	[NullableContext(1)]
	protected __TsTaskLog_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BEC1 RID: 114369 RVA: 0x008A8CC3 File Offset: 0x008A6EC3
	protected __TsTaskLog_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
