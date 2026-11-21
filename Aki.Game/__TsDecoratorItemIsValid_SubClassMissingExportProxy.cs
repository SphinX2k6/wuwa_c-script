using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B48 RID: 11080
public class __TsDecoratorItemIsValid_SubClassMissingExportProxy : __TsDecoratorItemIsValid_InheritProxy
{
	// Token: 0x0601BE24 RID: 114212 RVA: 0x008A7778 File Offset: 0x008A5978
	[NullableContext(1)]
	protected __TsDecoratorItemIsValid_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorItemIsValid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE25 RID: 114213 RVA: 0x008A77AB File Offset: 0x008A59AB
	protected __TsDecoratorItemIsValid_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
