using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003986 RID: 14726
public class __EffectClusteredStuffDefaultSettings_InheritProxy : EffectClusteredStuffDefaultSettings
{
	// Token: 0x0601EDF1 RID: 126449 RVA: 0x0089FDA0 File Offset: 0x0089DFA0
	[NullableContext(1)]
	public __EffectClusteredStuffDefaultSettings_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDF2 RID: 126450 RVA: 0x0089FDD3 File Offset: 0x0089DFD3
	protected __EffectClusteredStuffDefaultSettings_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
