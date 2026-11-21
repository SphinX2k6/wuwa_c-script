using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDC RID: 11996
public class __TsRecordEffect_SubClassMissingExportProxy : __TsRecordEffect_InheritProxy
{
	// Token: 0x0601C947 RID: 117063 RVA: 0x008BE4D0 File Offset: 0x008BC6D0
	[NullableContext(1)]
	protected __TsRecordEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C948 RID: 117064 RVA: 0x008BE503 File Offset: 0x008BC703
	protected __TsRecordEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
