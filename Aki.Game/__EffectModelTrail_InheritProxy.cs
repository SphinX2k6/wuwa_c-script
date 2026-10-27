using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A8 RID: 14760
public class __EffectModelTrail_InheritProxy : EffectModelTrail
{
	// Token: 0x0601EE35 RID: 126517 RVA: 0x008A0598 File Offset: 0x0089E798
	[NullableContext(1)]
	public __EffectModelTrail_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE36 RID: 126518 RVA: 0x008A05CB File Offset: 0x0089E7CB
	protected __EffectModelTrail_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
