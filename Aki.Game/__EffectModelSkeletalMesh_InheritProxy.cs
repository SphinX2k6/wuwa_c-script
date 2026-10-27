using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A4 RID: 14756
public class __EffectModelSkeletalMesh_InheritProxy : EffectModelSkeletalMesh
{
	// Token: 0x0601EE2D RID: 126509 RVA: 0x008A04A8 File Offset: 0x0089E6A8
	[NullableContext(1)]
	public __EffectModelSkeletalMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE2E RID: 126510 RVA: 0x008A04DB File Offset: 0x0089E6DB
	protected __EffectModelSkeletalMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
