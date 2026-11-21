using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E50 RID: 11856
public class __TsUiSceneRoleActor_SubClassMissingExportProxy : __TsUiSceneRoleActor_InheritProxy
{
	// Token: 0x0601C7C0 RID: 116672 RVA: 0x008BBC84 File Offset: 0x008B9E84
	[NullableContext(1)]
	protected __TsUiSceneRoleActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7C1 RID: 116673 RVA: 0x008BBCB7 File Offset: 0x008B9EB7
	protected __TsUiSceneRoleActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
