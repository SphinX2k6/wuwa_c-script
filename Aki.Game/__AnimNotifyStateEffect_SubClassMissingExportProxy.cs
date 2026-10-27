using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397D RID: 14717
public class __AnimNotifyStateEffect_SubClassMissingExportProxy : __AnimNotifyStateEffect_InheritProxy
{
	// Token: 0x0601EDD4 RID: 126420 RVA: 0x0089F9B8 File Offset: 0x0089DBB8
	[NullableContext(1)]
	protected __AnimNotifyStateEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDD5 RID: 126421 RVA: 0x0089F9EB File Offset: 0x0089DBEB
	protected __AnimNotifyStateEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
