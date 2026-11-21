using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E72 RID: 11890
public class __LogicDataDestroyBullet_SubClassMissingExportProxy : __LogicDataDestroyBullet_InheritProxy
{
	// Token: 0x0601C822 RID: 116770 RVA: 0x008BC5F8 File Offset: 0x008BA7F8
	[NullableContext(1)]
	protected __LogicDataDestroyBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C823 RID: 116771 RVA: 0x008BC62B File Offset: 0x008BA82B
	protected __LogicDataDestroyBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
