using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A1 RID: 13985
public class __TsTaskPlayPlot_SubClassMissingExportProxy : __TsTaskPlayPlot_InheritProxy
{
	// Token: 0x0601E340 RID: 123712 RVA: 0x00884934 File Offset: 0x00882B34
	[NullableContext(1)]
	protected __TsTaskPlayPlot_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E341 RID: 123713 RVA: 0x00884967 File Offset: 0x00882B67
	protected __TsTaskPlayPlot_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
