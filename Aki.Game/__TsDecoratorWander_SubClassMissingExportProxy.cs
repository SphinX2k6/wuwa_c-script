using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B5C RID: 11100
public class __TsDecoratorWander_SubClassMissingExportProxy : __TsDecoratorWander_InheritProxy
{
	// Token: 0x0601BE56 RID: 114262 RVA: 0x008A7E30 File Offset: 0x008A6030
	[NullableContext(1)]
	protected __TsDecoratorWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE57 RID: 114263 RVA: 0x008A7E63 File Offset: 0x008A6063
	protected __TsDecoratorWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
