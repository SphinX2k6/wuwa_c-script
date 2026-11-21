using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B2A RID: 11050
public class __TsDecoratorCheckInPlot_SubClassMissingExportProxy : __TsDecoratorCheckInPlot_InheritProxy
{
	// Token: 0x0601BDD7 RID: 114135 RVA: 0x008A6CF8 File Offset: 0x008A4EF8
	[NullableContext(1)]
	protected __TsDecoratorCheckInPlot_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDD8 RID: 114136 RVA: 0x008A6D2B File Offset: 0x008A4F2B
	protected __TsDecoratorCheckInPlot_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
