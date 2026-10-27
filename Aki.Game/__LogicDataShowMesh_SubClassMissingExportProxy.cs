using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390D RID: 14605
public class __LogicDataShowMesh_SubClassMissingExportProxy : __LogicDataShowMesh_InheritProxy
{
	// Token: 0x0601EB92 RID: 125842 RVA: 0x00898604 File Offset: 0x00896804
	[NullableContext(1)]
	protected __LogicDataShowMesh_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB93 RID: 125843 RVA: 0x00898637 File Offset: 0x00896837
	protected __LogicDataShowMesh_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
