using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F01 RID: 12033
public class __EffectClusteredStuffDefaultSettings_InheritProxy : EffectClusteredStuffDefaultSettings
{
	// Token: 0x0601CA1E RID: 117278 RVA: 0x008BFC5C File Offset: 0x008BDE5C
	[NullableContext(1)]
	public __EffectClusteredStuffDefaultSettings_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA1F RID: 117279 RVA: 0x008BFC8F File Offset: 0x008BDE8F
	protected __EffectClusteredStuffDefaultSettings_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
