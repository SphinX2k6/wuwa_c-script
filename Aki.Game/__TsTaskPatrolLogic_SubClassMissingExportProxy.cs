using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003695 RID: 13973
public class __TsTaskPatrolLogic_SubClassMissingExportProxy : __TsTaskPatrolLogic_InheritProxy
{
	// Token: 0x0601E320 RID: 123680 RVA: 0x008844DC File Offset: 0x008826DC
	[NullableContext(1)]
	protected __TsTaskPatrolLogic_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolLogic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E321 RID: 123681 RVA: 0x0088450F File Offset: 0x0088270F
	protected __TsTaskPatrolLogic_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
