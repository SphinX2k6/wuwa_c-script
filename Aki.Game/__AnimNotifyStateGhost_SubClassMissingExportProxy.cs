using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397F RID: 14719
public class __AnimNotifyStateGhost_SubClassMissingExportProxy : __AnimNotifyStateGhost_InheritProxy
{
	// Token: 0x0601EDDC RID: 126428 RVA: 0x0089FAC4 File Offset: 0x0089DCC4
	[NullableContext(1)]
	protected __AnimNotifyStateGhost_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDDD RID: 126429 RVA: 0x0089FAF7 File Offset: 0x0089DCF7
	protected __AnimNotifyStateGhost_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
