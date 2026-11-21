using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B98 RID: 11160
public class __TsTaskTurnToEntity_SubClassMissingExportProxy : __TsTaskTurnToEntity_InheritProxy
{
	// Token: 0x0601BEF7 RID: 114423 RVA: 0x008A9424 File Offset: 0x008A7624
	[NullableContext(1)]
	protected __TsTaskTurnToEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BEF8 RID: 114424 RVA: 0x008A9457 File Offset: 0x008A7657
	protected __TsTaskTurnToEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
