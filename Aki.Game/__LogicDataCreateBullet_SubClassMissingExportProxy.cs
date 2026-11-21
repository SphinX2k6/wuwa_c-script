using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E70 RID: 11888
public class __LogicDataCreateBullet_SubClassMissingExportProxy : __LogicDataCreateBullet_InheritProxy
{
	// Token: 0x0601C81E RID: 116766 RVA: 0x008BC580 File Offset: 0x008BA780
	[NullableContext(1)]
	protected __LogicDataCreateBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C81F RID: 116767 RVA: 0x008BC5B3 File Offset: 0x008BA7B3
	protected __LogicDataCreateBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
