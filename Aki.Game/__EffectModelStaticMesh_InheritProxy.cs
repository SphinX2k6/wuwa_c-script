using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F21 RID: 12065
public class __EffectModelStaticMesh_InheritProxy : EffectModelStaticMesh
{
	// Token: 0x0601CA5E RID: 117342 RVA: 0x008C03DC File Offset: 0x008BE5DC
	[NullableContext(1)]
	public __EffectModelStaticMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA5F RID: 117343 RVA: 0x008C040F File Offset: 0x008BE60F
	protected __EffectModelStaticMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
