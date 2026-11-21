using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C48 RID: 11336
public class __TsTaskTurnToTarget_SubClassMissingExportProxy : __TsTaskTurnToTarget_InheritProxy
{
	// Token: 0x0601C0DE RID: 114910 RVA: 0x008AD4AC File Offset: 0x008AB6AC
	[NullableContext(1)]
	protected __TsTaskTurnToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0DF RID: 114911 RVA: 0x008AD4DF File Offset: 0x008AB6DF
	protected __TsTaskTurnToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
