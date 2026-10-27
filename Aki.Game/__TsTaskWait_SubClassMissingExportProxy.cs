using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036DD RID: 14045
public class __TsTaskWait_SubClassMissingExportProxy : __TsTaskWait_InheritProxy
{
	// Token: 0x0601E3E5 RID: 123877 RVA: 0x00886040 File Offset: 0x00884240
	[NullableContext(1)]
	protected __TsTaskWait_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3E6 RID: 123878 RVA: 0x00886073 File Offset: 0x00884273
	protected __TsTaskWait_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
