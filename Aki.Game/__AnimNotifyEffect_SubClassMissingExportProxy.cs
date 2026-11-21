using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EF6 RID: 12022
public class __AnimNotifyEffect_SubClassMissingExportProxy : __AnimNotifyEffect_InheritProxy
{
	// Token: 0x0601C9F7 RID: 117239 RVA: 0x008BF718 File Offset: 0x008BD918
	[NullableContext(1)]
	protected __AnimNotifyEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C9F8 RID: 117240 RVA: 0x008BF74B File Offset: 0x008BD94B
	protected __AnimNotifyEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
