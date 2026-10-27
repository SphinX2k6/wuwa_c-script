using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200358F RID: 13711
public class __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy : __TsDecoratorTimeSpanCheck_InheritProxy
{
	// Token: 0x0601E050 RID: 122960 RVA: 0x0087DFA0 File Offset: 0x0087C1A0
	[NullableContext(1)]
	protected __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimeSpanCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E051 RID: 122961 RVA: 0x0087DFD3 File Offset: 0x0087C1D3
	protected __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
