using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B54 RID: 11092
public class __TsDecoratorSightReachTarget_SubClassMissingExportProxy : __TsDecoratorSightReachTarget_InheritProxy
{
	// Token: 0x0601BE42 RID: 114242 RVA: 0x008A7B80 File Offset: 0x008A5D80
	[NullableContext(1)]
	protected __TsDecoratorSightReachTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSightReachTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE43 RID: 114243 RVA: 0x008A7BB3 File Offset: 0x008A5DB3
	protected __TsDecoratorSightReachTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
