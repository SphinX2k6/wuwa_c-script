using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036C1 RID: 14017
public class __TsTaskSneakFail_SubClassMissingExportProxy : __TsTaskSneakFail_InheritProxy
{
	// Token: 0x0601E393 RID: 123795 RVA: 0x00885460 File Offset: 0x00883660
	[NullableContext(1)]
	protected __TsTaskSneakFail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSneakFail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E394 RID: 123796 RVA: 0x00885493 File Offset: 0x00883693
	protected __TsTaskSneakFail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
