using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F20 RID: 12064
public class __EffectModelSkeletalMesh_SubClassMissingExportProxy : __EffectModelSkeletalMesh_InheritProxy
{
	// Token: 0x0601CA5C RID: 117340 RVA: 0x008C03A0 File Offset: 0x008BE5A0
	[NullableContext(1)]
	protected __EffectModelSkeletalMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA5D RID: 117341 RVA: 0x008C03D3 File Offset: 0x008BE5D3
	protected __EffectModelSkeletalMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
