using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036C3 RID: 14019
public class __TsTaskSneakStart_SubClassMissingExportProxy : __TsTaskSneakStart_InheritProxy
{
	// Token: 0x0601E398 RID: 123800 RVA: 0x00885508 File Offset: 0x00883708
	[NullableContext(1)]
	protected __TsTaskSneakStart_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSneakStart.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E399 RID: 123801 RVA: 0x0088553B File Offset: 0x0088373B
	protected __TsTaskSneakStart_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
