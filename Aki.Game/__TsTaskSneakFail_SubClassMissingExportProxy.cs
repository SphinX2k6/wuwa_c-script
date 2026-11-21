using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C36 RID: 11318
public class __TsTaskSneakFail_SubClassMissingExportProxy : __TsTaskSneakFail_InheritProxy
{
	// Token: 0x0601C0AC RID: 114860 RVA: 0x008ACE38 File Offset: 0x008AB038
	[NullableContext(1)]
	protected __TsTaskSneakFail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSneakFail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0AD RID: 114861 RVA: 0x008ACE6B File Offset: 0x008AB06B
	protected __TsTaskSneakFail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
