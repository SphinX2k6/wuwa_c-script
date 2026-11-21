using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F09 RID: 12041
public class __EffectModelCurveTrailDecal_InheritProxy : EffectModelCurveTrailDecal
{
	// Token: 0x0601CA2E RID: 117294 RVA: 0x008BFE3C File Offset: 0x008BE03C
	[NullableContext(1)]
	public __EffectModelCurveTrailDecal_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA2F RID: 117295 RVA: 0x008BFE6F File Offset: 0x008BE06F
	protected __EffectModelCurveTrailDecal_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
