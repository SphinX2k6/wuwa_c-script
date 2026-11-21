using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E73 RID: 11891
public class __LogicDataDestroyOtherBullet_InheritProxy : LogicDataDestroyOtherBullet
{
	// Token: 0x0601C824 RID: 116772 RVA: 0x008BC634 File Offset: 0x008BA834
	[NullableContext(1)]
	public __LogicDataDestroyOtherBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C825 RID: 116773 RVA: 0x008BC667 File Offset: 0x008BA867
	protected __LogicDataDestroyOtherBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
