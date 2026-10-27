using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A5 RID: 14757
public class __EffectModelSkeletalMesh_SubClassMissingExportProxy : __EffectModelSkeletalMesh_InheritProxy
{
	// Token: 0x0601EE2F RID: 126511 RVA: 0x008A04E4 File Offset: 0x0089E6E4
	[NullableContext(1)]
	protected __EffectModelSkeletalMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE30 RID: 126512 RVA: 0x008A0517 File Offset: 0x0089E717
	protected __EffectModelSkeletalMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
