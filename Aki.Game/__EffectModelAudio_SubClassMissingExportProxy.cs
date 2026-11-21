using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F06 RID: 12038
public class __EffectModelAudio_SubClassMissingExportProxy : __EffectModelAudio_InheritProxy
{
	// Token: 0x0601CA28 RID: 117288 RVA: 0x008BFD88 File Offset: 0x008BDF88
	[NullableContext(1)]
	protected __EffectModelAudio_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA29 RID: 117289 RVA: 0x008BFDBB File Offset: 0x008BDFBB
	protected __EffectModelAudio_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
