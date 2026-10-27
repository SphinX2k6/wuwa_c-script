using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003611 RID: 13841
public class __TsTaskMoveToTarget_SubClassMissingExportProxy : __TsTaskMoveToTarget_InheritProxy
{
	// Token: 0x0601E19E RID: 123294 RVA: 0x00880CD8 File Offset: 0x0087EED8
	[NullableContext(1)]
	protected __TsTaskMoveToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E19F RID: 123295 RVA: 0x00880D0B File Offset: 0x0087EF0B
	protected __TsTaskMoveToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
