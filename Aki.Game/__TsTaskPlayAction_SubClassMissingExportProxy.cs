using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C0E RID: 11278
public class __TsTaskPlayAction_SubClassMissingExportProxy : __TsTaskPlayAction_InheritProxy
{
	// Token: 0x0601C044 RID: 114756 RVA: 0x008AC038 File Offset: 0x008AA238
	[NullableContext(1)]
	protected __TsTaskPlayAction_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C045 RID: 114757 RVA: 0x008AC06B File Offset: 0x008AA26B
	protected __TsTaskPlayAction_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
