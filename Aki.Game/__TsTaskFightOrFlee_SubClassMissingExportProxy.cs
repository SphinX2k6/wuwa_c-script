using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BE4 RID: 11236
public class __TsTaskFightOrFlee_SubClassMissingExportProxy : __TsTaskFightOrFlee_InheritProxy
{
	// Token: 0x0601BFD0 RID: 114640 RVA: 0x008AB030 File Offset: 0x008A9230
	[NullableContext(1)]
	protected __TsTaskFightOrFlee_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFD1 RID: 114641 RVA: 0x008AB063 File Offset: 0x008A9263
	protected __TsTaskFightOrFlee_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
