using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003807 RID: 14343
public class __TsAnimNotifyClientEvent_SubClassMissingExportProxy : __TsAnimNotifyClientEvent_InheritProxy
{
	// Token: 0x0601E846 RID: 124998 RVA: 0x00890DD4 File Offset: 0x0088EFD4
	[NullableContext(1)]
	protected __TsAnimNotifyClientEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E847 RID: 124999 RVA: 0x00890E07 File Offset: 0x0088F007
	protected __TsAnimNotifyClientEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
