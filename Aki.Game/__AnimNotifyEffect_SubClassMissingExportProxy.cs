using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397B RID: 14715
public class __AnimNotifyEffect_SubClassMissingExportProxy : __AnimNotifyEffect_InheritProxy
{
	// Token: 0x0601EDCA RID: 126410 RVA: 0x0089F85C File Offset: 0x0089DA5C
	[NullableContext(1)]
	protected __AnimNotifyEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDCB RID: 126411 RVA: 0x0089F88F File Offset: 0x0089DA8F
	protected __AnimNotifyEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
