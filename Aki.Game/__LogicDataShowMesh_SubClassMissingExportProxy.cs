using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E86 RID: 11910
public class __LogicDataShowMesh_SubClassMissingExportProxy : __LogicDataShowMesh_InheritProxy
{
	// Token: 0x0601C84A RID: 116810 RVA: 0x008BCAA8 File Offset: 0x008BACA8
	[NullableContext(1)]
	protected __LogicDataShowMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C84B RID: 116811 RVA: 0x008BCADB File Offset: 0x008BACDB
	protected __LogicDataShowMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
