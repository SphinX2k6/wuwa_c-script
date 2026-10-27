using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003998 RID: 14744
public class __EffectModelLight_InheritProxy : EffectModelLight
{
	// Token: 0x0601EE15 RID: 126485 RVA: 0x008A01D8 File Offset: 0x0089E3D8
	[NullableContext(1)]
	public __EffectModelLight_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE16 RID: 126486 RVA: 0x008A020B File Offset: 0x0089E40B
	protected __EffectModelLight_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
