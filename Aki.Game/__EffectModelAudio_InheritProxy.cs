using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F05 RID: 12037
public class __EffectModelAudio_InheritProxy : EffectModelAudio
{
	// Token: 0x0601CA26 RID: 117286 RVA: 0x008BFD4C File Offset: 0x008BDF4C
	[NullableContext(1)]
	public __EffectModelAudio_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA27 RID: 117287 RVA: 0x008BFD7F File Offset: 0x008BDF7F
	protected __EffectModelAudio_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
