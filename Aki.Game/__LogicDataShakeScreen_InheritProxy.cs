using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E81 RID: 11905
public class __LogicDataShakeScreen_InheritProxy : LogicDataShakeScreen
{
	// Token: 0x0601C840 RID: 116800 RVA: 0x008BC97C File Offset: 0x008BAB7C
	[NullableContext(1)]
	public __LogicDataShakeScreen_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C841 RID: 116801 RVA: 0x008BC9AF File Offset: 0x008BABAF
	protected __LogicDataShakeScreen_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
