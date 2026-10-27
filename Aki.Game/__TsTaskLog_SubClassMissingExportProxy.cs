using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200360F RID: 13839
public class __TsTaskLog_SubClassMissingExportProxy : __TsTaskLog_InheritProxy
{
	// Token: 0x0601E198 RID: 123288 RVA: 0x00880BFC File Offset: 0x0087EDFC
	[NullableContext(1)]
	protected __TsTaskLog_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E199 RID: 123289 RVA: 0x00880C2F File Offset: 0x0087EE2F
	protected __TsTaskLog_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
