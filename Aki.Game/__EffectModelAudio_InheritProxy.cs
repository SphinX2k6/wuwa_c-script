using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200398A RID: 14730
public class __EffectModelAudio_InheritProxy : EffectModelAudio
{
	// Token: 0x0601EDF9 RID: 126457 RVA: 0x0089FE90 File Offset: 0x0089E090
	[NullableContext(1)]
	public __EffectModelAudio_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDFA RID: 126458 RVA: 0x0089FEC3 File Offset: 0x0089E0C3
	protected __EffectModelAudio_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
