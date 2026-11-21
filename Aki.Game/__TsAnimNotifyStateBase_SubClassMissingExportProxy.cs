using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C74 RID: 11380
public class __TsAnimNotifyStateBase_SubClassMissingExportProxy : __TsAnimNotifyStateBase_InheritProxy
{
	// Token: 0x0601C19D RID: 115101 RVA: 0x008AEE60 File Offset: 0x008AD060
	[NullableContext(1)]
	protected __TsAnimNotifyStateBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C19E RID: 115102 RVA: 0x008AEE93 File Offset: 0x008AD093
	protected __TsAnimNotifyStateBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
