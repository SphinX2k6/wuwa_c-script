using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036B9 RID: 14009
public class __TsTaskSetSightToTarget_SubClassMissingExportProxy : __TsTaskSetSightToTarget_InheritProxy
{
	// Token: 0x0601E37E RID: 123774 RVA: 0x00885188 File Offset: 0x00883388
	[NullableContext(1)]
	protected __TsTaskSetSightToTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetSightToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E37F RID: 123775 RVA: 0x008851BB File Offset: 0x008833BB
	protected __TsTaskSetSightToTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
