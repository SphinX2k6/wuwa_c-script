using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003597 RID: 13719
public class __TsDecoratorActorsLocation_SubClassMissingExportProxy : __TsDecoratorActorsLocation_InheritProxy
{
	// Token: 0x0601E064 RID: 122980 RVA: 0x0087E250 File Offset: 0x0087C450
	[NullableContext(1)]
	protected __TsDecoratorActorsLocation_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorActorsLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E065 RID: 122981 RVA: 0x0087E283 File Offset: 0x0087C483
	protected __TsDecoratorActorsLocation_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
