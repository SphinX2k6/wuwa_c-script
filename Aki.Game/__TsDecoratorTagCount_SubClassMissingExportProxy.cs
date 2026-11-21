using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B58 RID: 11096
public class __TsDecoratorTagCount_SubClassMissingExportProxy : __TsDecoratorTagCount_InheritProxy
{
	// Token: 0x0601BE4C RID: 114252 RVA: 0x008A7CD8 File Offset: 0x008A5ED8
	[NullableContext(1)]
	protected __TsDecoratorTagCount_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE4D RID: 114253 RVA: 0x008A7D0B File Offset: 0x008A5F0B
	protected __TsDecoratorTagCount_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
