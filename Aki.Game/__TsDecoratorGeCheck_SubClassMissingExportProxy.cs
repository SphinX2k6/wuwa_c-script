using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B3C RID: 11068
public class __TsDecoratorGeCheck_SubClassMissingExportProxy : __TsDecoratorGeCheck_InheritProxy
{
	// Token: 0x0601BE06 RID: 114182 RVA: 0x008A7370 File Offset: 0x008A5570
	[NullableContext(1)]
	protected __TsDecoratorGeCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE07 RID: 114183 RVA: 0x008A73A3 File Offset: 0x008A55A3
	protected __TsDecoratorGeCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
