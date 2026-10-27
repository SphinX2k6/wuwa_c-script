using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036D3 RID: 14035
public class __TsTaskTurnToTarget_SubClassMissingExportProxy : __TsTaskTurnToTarget_InheritProxy
{
	// Token: 0x0601E3C8 RID: 123848 RVA: 0x00885C24 File Offset: 0x00883E24
	[NullableContext(1)]
	protected __TsTaskTurnToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3C9 RID: 123849 RVA: 0x00885C57 File Offset: 0x00883E57
	protected __TsTaskTurnToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
