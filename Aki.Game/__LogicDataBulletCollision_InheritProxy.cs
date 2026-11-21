using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6B RID: 11883
public class __LogicDataBulletCollision_InheritProxy : LogicDataBulletCollision
{
	// Token: 0x0601C814 RID: 116756 RVA: 0x008BC454 File Offset: 0x008BA654
	[NullableContext(1)]
	public __LogicDataBulletCollision_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C815 RID: 116757 RVA: 0x008BC487 File Offset: 0x008BA687
	protected __LogicDataBulletCollision_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
