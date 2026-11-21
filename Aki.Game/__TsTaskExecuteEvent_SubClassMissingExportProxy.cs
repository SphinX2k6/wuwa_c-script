using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BE2 RID: 11234
public class __TsTaskExecuteEvent_SubClassMissingExportProxy : __TsTaskExecuteEvent_InheritProxy
{
	// Token: 0x0601BFCB RID: 114635 RVA: 0x008AAF88 File Offset: 0x008A9188
	[NullableContext(1)]
	protected __TsTaskExecuteEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFCC RID: 114636 RVA: 0x008AAFBB File Offset: 0x008A91BB
	protected __TsTaskExecuteEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
