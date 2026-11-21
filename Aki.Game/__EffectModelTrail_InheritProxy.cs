using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F23 RID: 12067
public class __EffectModelTrail_InheritProxy : EffectModelTrail
{
	// Token: 0x0601CA62 RID: 117346 RVA: 0x008C0454 File Offset: 0x008BE654
	[NullableContext(1)]
	public __EffectModelTrail_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA63 RID: 117347 RVA: 0x008C0487 File Offset: 0x008BE687
	protected __EffectModelTrail_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
