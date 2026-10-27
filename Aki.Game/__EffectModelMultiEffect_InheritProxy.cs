using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AC RID: 14764
public class __EffectModelMultiEffect_InheritProxy : EffectModelMultiEffect
{
	// Token: 0x0601EE3D RID: 126525 RVA: 0x008A0688 File Offset: 0x0089E888
	[NullableContext(1)]
	public __EffectModelMultiEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE3E RID: 126526 RVA: 0x008A06BB File Offset: 0x0089E8BB
	protected __EffectModelMultiEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
