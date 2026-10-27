using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200366D RID: 13933
public class __TsTaskExecuteEvent_SubClassMissingExportProxy : __TsTaskExecuteEvent_InheritProxy
{
	// Token: 0x0601E2B1 RID: 123569 RVA: 0x00883514 File Offset: 0x00881714
	[NullableContext(1)]
	protected __TsTaskExecuteEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2B2 RID: 123570 RVA: 0x00883547 File Offset: 0x00881747
	protected __TsTaskExecuteEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
