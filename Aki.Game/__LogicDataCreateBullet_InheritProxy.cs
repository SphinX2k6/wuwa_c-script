using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6F RID: 11887
public class __LogicDataCreateBullet_InheritProxy : LogicDataCreateBullet
{
	// Token: 0x0601C81C RID: 116764 RVA: 0x008BC544 File Offset: 0x008BA744
	[NullableContext(1)]
	public __LogicDataCreateBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C81D RID: 116765 RVA: 0x008BC577 File Offset: 0x008BA777
	protected __LogicDataCreateBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
