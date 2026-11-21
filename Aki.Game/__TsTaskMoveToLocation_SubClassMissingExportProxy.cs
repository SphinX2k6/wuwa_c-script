using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C06 RID: 11270
public class __TsTaskMoveToLocation_SubClassMissingExportProxy : __TsTaskMoveToLocation_InheritProxy
{
	// Token: 0x0601C02D RID: 114733 RVA: 0x008ABCFC File Offset: 0x008A9EFC
	[NullableContext(1)]
	protected __TsTaskMoveToLocation_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C02E RID: 114734 RVA: 0x008ABD2F File Offset: 0x008A9F2F
	protected __TsTaskMoveToLocation_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
