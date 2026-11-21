using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EFA RID: 12026
public class __AnimNotifyStateGhost_SubClassMissingExportProxy : __AnimNotifyStateGhost_InheritProxy
{
	// Token: 0x0601CA09 RID: 117257 RVA: 0x008BF980 File Offset: 0x008BDB80
	[NullableContext(1)]
	protected __AnimNotifyStateGhost_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA0A RID: 117258 RVA: 0x008BF9B3 File Offset: 0x008BDBB3
	protected __AnimNotifyStateGhost_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
