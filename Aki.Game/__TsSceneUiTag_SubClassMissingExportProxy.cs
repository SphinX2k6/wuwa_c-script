using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E40 RID: 11840
public class __TsSceneUiTag_SubClassMissingExportProxy : __TsSceneUiTag_InheritProxy
{
	// Token: 0x0601C796 RID: 116630 RVA: 0x008BB844 File Offset: 0x008B9A44
	[NullableContext(1)]
	protected __TsSceneUiTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C797 RID: 116631 RVA: 0x008BB877 File Offset: 0x008B9A77
	protected __TsSceneUiTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
