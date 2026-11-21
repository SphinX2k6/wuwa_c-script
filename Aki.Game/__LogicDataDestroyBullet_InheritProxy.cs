using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E71 RID: 11889
public class __LogicDataDestroyBullet_InheritProxy : LogicDataDestroyBullet
{
	// Token: 0x0601C820 RID: 116768 RVA: 0x008BC5BC File Offset: 0x008BA7BC
	[NullableContext(1)]
	public __LogicDataDestroyBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C821 RID: 116769 RVA: 0x008BC5EF File Offset: 0x008BA7EF
	protected __LogicDataDestroyBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
