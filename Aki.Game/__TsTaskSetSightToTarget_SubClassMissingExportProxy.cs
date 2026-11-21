using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C2E RID: 11310
public class __TsTaskSetSightToTarget_SubClassMissingExportProxy : __TsTaskSetSightToTarget_InheritProxy
{
	// Token: 0x0601C097 RID: 114839 RVA: 0x008ACB60 File Offset: 0x008AAD60
	[NullableContext(1)]
	protected __TsTaskSetSightToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetSightToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C098 RID: 114840 RVA: 0x008ACB93 File Offset: 0x008AAD93
	protected __TsTaskSetSightToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
