using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BF2 RID: 11250
public class __TsTaskFlee_SubClassMissingExportProxy : __TsTaskFlee_InheritProxy
{
	// Token: 0x0601BFF4 RID: 114676 RVA: 0x008AB4FC File Offset: 0x008A96FC
	[NullableContext(1)]
	protected __TsTaskFlee_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFF5 RID: 114677 RVA: 0x008AB52F File Offset: 0x008A972F
	protected __TsTaskFlee_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
