using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F6 RID: 14582
public class __LogicDataCreateBullet_InheritProxy : LogicDataCreateBullet
{
	// Token: 0x0601EB64 RID: 125796 RVA: 0x008980A0 File Offset: 0x008962A0
	[NullableContext(1)]
	public __LogicDataCreateBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB65 RID: 125797 RVA: 0x008980D3 File Offset: 0x008962D3
	protected __LogicDataCreateBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
