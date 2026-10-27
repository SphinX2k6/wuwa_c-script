using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200398B RID: 14731
public class __EffectModelAudio_SubClassMissingExportProxy : __EffectModelAudio_InheritProxy
{
	// Token: 0x0601EDFB RID: 126459 RVA: 0x0089FECC File Offset: 0x0089E0CC
	[NullableContext(1)]
	protected __EffectModelAudio_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDFC RID: 126460 RVA: 0x0089FEFF File Offset: 0x0089E0FF
	protected __EffectModelAudio_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
