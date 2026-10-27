using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035CB RID: 13771
public class __TsDecoratorHasWeapon_SubClassMissingExportProxy : __TsDecoratorHasWeapon_InheritProxy
{
	// Token: 0x0601E0E8 RID: 123112 RVA: 0x0087F434 File Offset: 0x0087D634
	[NullableContext(1)]
	protected __TsDecoratorHasWeapon_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorHasWeapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0E9 RID: 123113 RVA: 0x0087F467 File Offset: 0x0087D667
	protected __TsDecoratorHasWeapon_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
