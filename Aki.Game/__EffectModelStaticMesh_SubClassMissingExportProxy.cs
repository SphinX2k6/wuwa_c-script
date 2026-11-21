using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F22 RID: 12066
public class __EffectModelStaticMesh_SubClassMissingExportProxy : __EffectModelStaticMesh_InheritProxy
{
	// Token: 0x0601CA60 RID: 117344 RVA: 0x008C0418 File Offset: 0x008BE618
	[NullableContext(1)]
	protected __EffectModelStaticMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA61 RID: 117345 RVA: 0x008C044B File Offset: 0x008BE64B
	protected __EffectModelStaticMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
