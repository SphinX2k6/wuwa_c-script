using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003623 RID: 13859
public class __TsTaskTurnToEntity_SubClassMissingExportProxy : __TsTaskTurnToEntity_InheritProxy
{
	// Token: 0x0601E1CF RID: 123343 RVA: 0x00881390 File Offset: 0x0087F590
	[NullableContext(1)]
	protected __TsTaskTurnToEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1D0 RID: 123344 RVA: 0x008813C3 File Offset: 0x0087F5C3
	protected __TsTaskTurnToEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
