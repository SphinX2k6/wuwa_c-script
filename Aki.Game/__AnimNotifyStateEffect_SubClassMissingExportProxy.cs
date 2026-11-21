using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EF8 RID: 12024
public class __AnimNotifyStateEffect_SubClassMissingExportProxy : __AnimNotifyStateEffect_InheritProxy
{
	// Token: 0x0601CA01 RID: 117249 RVA: 0x008BF874 File Offset: 0x008BDA74
	[NullableContext(1)]
	protected __AnimNotifyStateEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA02 RID: 117250 RVA: 0x008BF8A7 File Offset: 0x008BDAA7
	protected __AnimNotifyStateEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
