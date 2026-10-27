using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020037E9 RID: 14313
public class __TsAnimNotifyBreakPoint_SubClassMissingExportProxy : __TsAnimNotifyBreakPoint_InheritProxy
{
	// Token: 0x0601E7EC RID: 124908 RVA: 0x00890294 File Offset: 0x0088E494
	[NullableContext(1)]
	protected __TsAnimNotifyBreakPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E7ED RID: 124909 RVA: 0x008902C7 File Offset: 0x0088E4C7
	protected __TsAnimNotifyBreakPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
