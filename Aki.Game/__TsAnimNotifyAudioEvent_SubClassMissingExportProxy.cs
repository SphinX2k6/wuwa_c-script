using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020037D9 RID: 14297
public class __TsAnimNotifyAudioEvent_SubClassMissingExportProxy : __TsAnimNotifyAudioEvent_InheritProxy
{
	// Token: 0x0601E7BD RID: 124861 RVA: 0x0088FCA8 File Offset: 0x0088DEA8
	[NullableContext(1)]
	protected __TsAnimNotifyAudioEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E7BE RID: 124862 RVA: 0x0088FCDB File Offset: 0x0088DEDB
	protected __TsAnimNotifyAudioEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
