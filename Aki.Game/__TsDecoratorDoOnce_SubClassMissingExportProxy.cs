using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003585 RID: 13701
public class __TsDecoratorDoOnce_SubClassMissingExportProxy : __TsDecoratorDoOnce_InheritProxy
{
	// Token: 0x0601E037 RID: 122935 RVA: 0x0087DC44 File Offset: 0x0087BE44
	[NullableContext(1)]
	protected __TsDecoratorDoOnce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDoOnce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E038 RID: 122936 RVA: 0x0087DC77 File Offset: 0x0087BE77
	protected __TsDecoratorDoOnce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
