using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B1C RID: 11036
public class __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy : __TsDecoratorBlackboardStringCompare_InheritProxy
{
	// Token: 0x0601BDB4 RID: 114100 RVA: 0x008A6844 File Offset: 0x008A4A44
	[NullableContext(1)]
	protected __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardStringCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDB5 RID: 114101 RVA: 0x008A6877 File Offset: 0x008A4A77
	protected __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
