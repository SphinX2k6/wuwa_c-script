using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B86 RID: 11142
public class __TsTaskMoveToTarget_SubClassMissingExportProxy : __TsTaskMoveToTarget_InheritProxy
{
	// Token: 0x0601BEC6 RID: 114374 RVA: 0x008A8D6C File Offset: 0x008A6F6C
	[NullableContext(1)]
	protected __TsTaskMoveToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BEC7 RID: 114375 RVA: 0x008A8D9F File Offset: 0x008A6F9F
	protected __TsTaskMoveToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
