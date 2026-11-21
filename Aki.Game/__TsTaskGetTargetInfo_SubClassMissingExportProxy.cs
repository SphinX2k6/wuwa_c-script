using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BA0 RID: 11168
public class __TsTaskGetTargetInfo_SubClassMissingExportProxy : __TsTaskGetTargetInfo_InheritProxy
{
	// Token: 0x0601BF0D RID: 114445 RVA: 0x008A972C File Offset: 0x008A792C
	[NullableContext(1)]
	protected __TsTaskGetTargetInfo_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF0E RID: 114446 RVA: 0x008A975F File Offset: 0x008A795F
	protected __TsTaskGetTargetInfo_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
