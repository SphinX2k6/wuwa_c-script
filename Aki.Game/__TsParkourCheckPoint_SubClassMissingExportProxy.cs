using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2A RID: 11818
public class __TsParkourCheckPoint_SubClassMissingExportProxy : __TsParkourCheckPoint_InheritProxy
{
	// Token: 0x0601C74D RID: 116557 RVA: 0x008BB120 File Offset: 0x008B9320
	[NullableContext(1)]
	protected __TsParkourCheckPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C74E RID: 116558 RVA: 0x008BB153 File Offset: 0x008B9353
	protected __TsParkourCheckPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
