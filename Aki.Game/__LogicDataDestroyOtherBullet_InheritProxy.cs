using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FA RID: 14586
public class __LogicDataDestroyOtherBullet_InheritProxy : LogicDataDestroyOtherBullet
{
	// Token: 0x0601EB6C RID: 125804 RVA: 0x00898190 File Offset: 0x00896390
	[NullableContext(1)]
	public __LogicDataDestroyOtherBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB6D RID: 125805 RVA: 0x008981C3 File Offset: 0x008963C3
	protected __LogicDataDestroyOtherBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
