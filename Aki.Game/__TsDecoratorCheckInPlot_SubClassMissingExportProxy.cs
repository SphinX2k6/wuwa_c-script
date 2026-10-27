using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B5 RID: 13749
public class __TsDecoratorCheckInPlot_SubClassMissingExportProxy : __TsDecoratorCheckInPlot_InheritProxy
{
	// Token: 0x0601E0AF RID: 123055 RVA: 0x0087EC64 File Offset: 0x0087CE64
	[NullableContext(1)]
	protected __TsDecoratorCheckInPlot_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0B0 RID: 123056 RVA: 0x0087EC97 File Offset: 0x0087CE97
	protected __TsDecoratorCheckInPlot_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
