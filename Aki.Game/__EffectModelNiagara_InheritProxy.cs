using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F19 RID: 12057
public class __EffectModelNiagara_InheritProxy : EffectModelNiagara
{
	// Token: 0x0601CA4E RID: 117326 RVA: 0x008C01FC File Offset: 0x008BE3FC
	[NullableContext(1)]
	public __EffectModelNiagara_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA4F RID: 117327 RVA: 0x008C022F File Offset: 0x008BE42F
	protected __EffectModelNiagara_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
