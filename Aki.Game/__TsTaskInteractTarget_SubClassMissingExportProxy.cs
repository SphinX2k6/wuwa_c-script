using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003689 RID: 13961
public class __TsTaskInteractTarget_SubClassMissingExportProxy : __TsTaskInteractTarget_InheritProxy
{
	// Token: 0x0601E2FE RID: 123646 RVA: 0x00884014 File Offset: 0x00882214
	[NullableContext(1)]
	protected __TsTaskInteractTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskInteractTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2FF RID: 123647 RVA: 0x00884047 File Offset: 0x00882247
	protected __TsTaskInteractTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
