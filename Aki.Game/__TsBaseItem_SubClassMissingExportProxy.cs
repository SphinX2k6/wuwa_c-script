using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBA RID: 11962
public class __TsBaseItem_SubClassMissingExportProxy : __TsBaseItem_InheritProxy
{
	// Token: 0x0601C8CE RID: 116942 RVA: 0x008BD830 File Offset: 0x008BBA30
	[NullableContext(1)]
	protected __TsBaseItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8CF RID: 116943 RVA: 0x008BD863 File Offset: 0x008BBA63
	protected __TsBaseItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
