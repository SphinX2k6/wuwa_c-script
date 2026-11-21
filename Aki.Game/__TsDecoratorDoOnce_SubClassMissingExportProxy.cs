using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AFA RID: 11002
public class __TsDecoratorDoOnce_SubClassMissingExportProxy : __TsDecoratorDoOnce_InheritProxy
{
	// Token: 0x0601BD5F RID: 114015 RVA: 0x008A5CD8 File Offset: 0x008A3ED8
	[NullableContext(1)]
	protected __TsDecoratorDoOnce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDoOnce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD60 RID: 114016 RVA: 0x008A5D0B File Offset: 0x008A3F0B
	protected __TsDecoratorDoOnce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
