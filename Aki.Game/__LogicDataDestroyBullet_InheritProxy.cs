using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F8 RID: 14584
public class __LogicDataDestroyBullet_InheritProxy : LogicDataDestroyBullet
{
	// Token: 0x0601EB68 RID: 125800 RVA: 0x00898118 File Offset: 0x00896318
	[NullableContext(1)]
	public __LogicDataDestroyBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB69 RID: 125801 RVA: 0x0089814B File Offset: 0x0089634B
	protected __LogicDataDestroyBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
