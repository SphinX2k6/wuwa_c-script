using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EFE RID: 12030
public class __AnimNotifyStateTrail_SubClassMissingExportProxy : __AnimNotifyStateTrail_InheritProxy
{
	// Token: 0x0601CA17 RID: 117271 RVA: 0x008BFB74 File Offset: 0x008BDD74
	[NullableContext(1)]
	protected __AnimNotifyStateTrail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA18 RID: 117272 RVA: 0x008BFBA7 File Offset: 0x008BDDA7
	protected __AnimNotifyStateTrail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
