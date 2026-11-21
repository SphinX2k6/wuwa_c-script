using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F13 RID: 12051
public class __EffectModelLight_InheritProxy : EffectModelLight
{
	// Token: 0x0601CA42 RID: 117314 RVA: 0x008C0094 File Offset: 0x008BE294
	[NullableContext(1)]
	public __EffectModelLight_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA43 RID: 117315 RVA: 0x008C00C7 File Offset: 0x008BE2C7
	protected __EffectModelLight_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
