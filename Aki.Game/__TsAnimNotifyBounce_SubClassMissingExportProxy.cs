using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D5E RID: 11614
public class __TsAnimNotifyBounce_SubClassMissingExportProxy : __TsAnimNotifyBounce_InheritProxy
{
	// Token: 0x0601C4D9 RID: 115929 RVA: 0x008B6510 File Offset: 0x008B4710
	[NullableContext(1)]
	protected __TsAnimNotifyBounce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBounce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C4DA RID: 115930 RVA: 0x008B6543 File Offset: 0x008B4743
	protected __TsAnimNotifyBounce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
