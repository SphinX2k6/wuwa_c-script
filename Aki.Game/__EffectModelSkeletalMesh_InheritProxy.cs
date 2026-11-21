using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1F RID: 12063
public class __EffectModelSkeletalMesh_InheritProxy : EffectModelSkeletalMesh
{
	// Token: 0x0601CA5A RID: 117338 RVA: 0x008C0364 File Offset: 0x008BE564
	[NullableContext(1)]
	public __EffectModelSkeletalMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA5B RID: 117339 RVA: 0x008C0397 File Offset: 0x008BE597
	protected __EffectModelSkeletalMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
