using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B40 RID: 11072
public class __TsDecoratorHasWeapon_SubClassMissingExportProxy : __TsDecoratorHasWeapon_InheritProxy
{
	// Token: 0x0601BE10 RID: 114192 RVA: 0x008A74C8 File Offset: 0x008A56C8
	[NullableContext(1)]
	protected __TsDecoratorHasWeapon_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorHasWeapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE11 RID: 114193 RVA: 0x008A74FB File Offset: 0x008A56FB
	protected __TsDecoratorHasWeapon_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
