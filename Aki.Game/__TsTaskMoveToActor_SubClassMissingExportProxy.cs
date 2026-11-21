using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C04 RID: 11268
public class __TsTaskMoveToActor_SubClassMissingExportProxy : __TsTaskMoveToActor_InheritProxy
{
	// Token: 0x0601C027 RID: 114727 RVA: 0x008ABC20 File Offset: 0x008A9E20
	[NullableContext(1)]
	protected __TsTaskMoveToActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C028 RID: 114728 RVA: 0x008ABC53 File Offset: 0x008A9E53
	protected __TsTaskMoveToActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
