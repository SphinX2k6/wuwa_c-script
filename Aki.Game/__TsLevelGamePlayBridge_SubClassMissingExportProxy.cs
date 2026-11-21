using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2C RID: 11820
public class __TsLevelGamePlayBridge_SubClassMissingExportProxy : __TsLevelGamePlayBridge_InheritProxy
{
	// Token: 0x0601C755 RID: 116565 RVA: 0x008BB1E8 File Offset: 0x008B93E8
	[NullableContext(1)]
	protected __TsLevelGamePlayBridge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C756 RID: 116566 RVA: 0x008BB21B File Offset: 0x008B941B
	protected __TsLevelGamePlayBridge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
