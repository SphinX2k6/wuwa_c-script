using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A6 RID: 14758
public class __EffectModelStaticMesh_InheritProxy : EffectModelStaticMesh
{
	// Token: 0x0601EE31 RID: 126513 RVA: 0x008A0520 File Offset: 0x0089E720
	[NullableContext(1)]
	public __EffectModelStaticMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE32 RID: 126514 RVA: 0x008A0553 File Offset: 0x0089E753
	protected __EffectModelStaticMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
