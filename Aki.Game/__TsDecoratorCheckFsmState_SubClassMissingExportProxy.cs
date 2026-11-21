using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B24 RID: 11044
public class __TsDecoratorCheckFsmState_SubClassMissingExportProxy : __TsDecoratorCheckFsmState_InheritProxy
{
	// Token: 0x0601BDC8 RID: 114120 RVA: 0x008A6AF4 File Offset: 0x008A4CF4
	[NullableContext(1)]
	protected __TsDecoratorCheckFsmState_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDC9 RID: 114121 RVA: 0x008A6B27 File Offset: 0x008A4D27
	protected __TsDecoratorCheckFsmState_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
