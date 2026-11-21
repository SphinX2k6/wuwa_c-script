using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F27 RID: 12071
public class __EffectModelMultiEffect_InheritProxy : EffectModelMultiEffect
{
	// Token: 0x0601CA6A RID: 117354 RVA: 0x008C0544 File Offset: 0x008BE744
	[NullableContext(1)]
	public __EffectModelMultiEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA6B RID: 117355 RVA: 0x008C0577 File Offset: 0x008BE777
	protected __EffectModelMultiEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
