using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200367D RID: 13949
public class __TsTaskFlee_SubClassMissingExportProxy : __TsTaskFlee_InheritProxy
{
	// Token: 0x0601E2DA RID: 123610 RVA: 0x00883A88 File Offset: 0x00881C88
	[NullableContext(1)]
	protected __TsTaskFlee_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2DB RID: 123611 RVA: 0x00883ABB File Offset: 0x00881CBB
	protected __TsTaskFlee_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
