using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E52 RID: 11858
public class __TsUiHomeHelper_SubClassMissingExportProxy : __TsUiHomeHelper_InheritProxy
{
	// Token: 0x0601C7C4 RID: 116676 RVA: 0x008BBCFC File Offset: 0x008B9EFC
	[NullableContext(1)]
	protected __TsUiHomeHelper_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7C5 RID: 116677 RVA: 0x008BBD2F File Offset: 0x008B9F2F
	protected __TsUiHomeHelper_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
