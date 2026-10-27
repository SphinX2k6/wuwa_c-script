using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003871 RID: 14449
public class __TsAnimNotifyTeleport_SubClassMissingExportProxy : __TsAnimNotifyTeleport_InheritProxy
{
	// Token: 0x0601E982 RID: 125314 RVA: 0x0089354C File Offset: 0x0089174C
	[NullableContext(1)]
	protected __TsAnimNotifyTeleport_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E983 RID: 125315 RVA: 0x0089357F File Offset: 0x0089177F
	protected __TsAnimNotifyTeleport_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
