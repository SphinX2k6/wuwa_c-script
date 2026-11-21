using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D62 RID: 11618
public class __TsAnimNotifyBreakPoint_SubClassMissingExportProxy : __TsAnimNotifyBreakPoint_InheritProxy
{
	// Token: 0x0601C4E5 RID: 115941 RVA: 0x008B6690 File Offset: 0x008B4890
	[NullableContext(1)]
	protected __TsAnimNotifyBreakPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C4E6 RID: 115942 RVA: 0x008B66C3 File Offset: 0x008B48C3
	protected __TsAnimNotifyBreakPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
