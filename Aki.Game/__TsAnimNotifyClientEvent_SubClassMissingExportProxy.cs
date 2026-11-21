using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D80 RID: 11648
public class __TsAnimNotifyClientEvent_SubClassMissingExportProxy : __TsAnimNotifyClientEvent_InheritProxy
{
	// Token: 0x0601C53F RID: 116031 RVA: 0x008B71D0 File Offset: 0x008B53D0
	[NullableContext(1)]
	protected __TsAnimNotifyClientEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C540 RID: 116032 RVA: 0x008B7203 File Offset: 0x008B5403
	protected __TsAnimNotifyClientEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
