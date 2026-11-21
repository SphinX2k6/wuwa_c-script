using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C30 RID: 11312
public class __TsTaskSetTag_SubClassMissingExportProxy : __TsTaskSetTag_InheritProxy
{
	// Token: 0x0601C09C RID: 114844 RVA: 0x008ACC0C File Offset: 0x008AAE0C
	[NullableContext(1)]
	protected __TsTaskSetTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C09D RID: 114845 RVA: 0x008ACC3F File Offset: 0x008AAE3F
	protected __TsTaskSetTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
