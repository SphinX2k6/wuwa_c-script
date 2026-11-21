using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6C RID: 11884
public class __LogicDataBulletCollision_SubClassMissingExportProxy : __LogicDataBulletCollision_InheritProxy
{
	// Token: 0x0601C816 RID: 116758 RVA: 0x008BC490 File Offset: 0x008BA690
	[NullableContext(1)]
	protected __LogicDataBulletCollision_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C817 RID: 116759 RVA: 0x008BC4C3 File Offset: 0x008BA6C3
	protected __LogicDataBulletCollision_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
