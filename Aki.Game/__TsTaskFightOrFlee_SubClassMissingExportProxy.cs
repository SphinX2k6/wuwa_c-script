using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200366F RID: 13935
public class __TsTaskFightOrFlee_SubClassMissingExportProxy : __TsTaskFightOrFlee_InheritProxy
{
	// Token: 0x0601E2B6 RID: 123574 RVA: 0x008835BC File Offset: 0x008817BC
	[NullableContext(1)]
	protected __TsTaskFightOrFlee_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2B7 RID: 123575 RVA: 0x008835EF File Offset: 0x008817EF
	protected __TsTaskFightOrFlee_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
