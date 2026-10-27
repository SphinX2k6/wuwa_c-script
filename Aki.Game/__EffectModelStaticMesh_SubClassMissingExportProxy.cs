using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A7 RID: 14759
public class __EffectModelStaticMesh_SubClassMissingExportProxy : __EffectModelStaticMesh_InheritProxy
{
	// Token: 0x0601EE33 RID: 126515 RVA: 0x008A055C File Offset: 0x0089E75C
	[NullableContext(1)]
	protected __EffectModelStaticMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE34 RID: 126516 RVA: 0x008A058F File Offset: 0x0089E78F
	protected __EffectModelStaticMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
