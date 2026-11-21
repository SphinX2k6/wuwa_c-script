using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DEA RID: 11754
public class __TsAnimNotifyTeleport_SubClassMissingExportProxy : __TsAnimNotifyTeleport_InheritProxy
{
	// Token: 0x0601C67B RID: 116347 RVA: 0x008B9948 File Offset: 0x008B7B48
	[NullableContext(1)]
	protected __TsAnimNotifyTeleport_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C67C RID: 116348 RVA: 0x008B997B File Offset: 0x008B7B7B
	protected __TsAnimNotifyTeleport_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
