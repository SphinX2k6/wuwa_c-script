using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E74 RID: 11892
public class __LogicDataDestroyOtherBullet_SubClassMissingExportProxy : __LogicDataDestroyOtherBullet_InheritProxy
{
	// Token: 0x0601C826 RID: 116774 RVA: 0x008BC670 File Offset: 0x008BA870
	[NullableContext(1)]
	protected __LogicDataDestroyOtherBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C827 RID: 116775 RVA: 0x008BC6A3 File Offset: 0x008BA8A3
	protected __LogicDataDestroyOtherBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
