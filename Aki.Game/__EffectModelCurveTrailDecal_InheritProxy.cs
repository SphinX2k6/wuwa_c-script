using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200398E RID: 14734
public class __EffectModelCurveTrailDecal_InheritProxy : EffectModelCurveTrailDecal
{
	// Token: 0x0601EE01 RID: 126465 RVA: 0x0089FF80 File Offset: 0x0089E180
	[NullableContext(1)]
	public __EffectModelCurveTrailDecal_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE02 RID: 126466 RVA: 0x0089FFB3 File Offset: 0x0089E1B3
	protected __EffectModelCurveTrailDecal_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
