using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F25 RID: 12069
public class __EffectScalabilitySetting_InheritProxy : EffectScalabilitySetting
{
	// Token: 0x0601CA66 RID: 117350 RVA: 0x008C04CC File Offset: 0x008BE6CC
	[NullableContext(1)]
	public __EffectScalabilitySetting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA67 RID: 117351 RVA: 0x008C04FF File Offset: 0x008BE6FF
	protected __EffectScalabilitySetting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
