using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F30 RID: 12080
public class __SceneInteractionDebugTool_SubClassMissingExportProxy : __SceneInteractionDebugTool_InheritProxy
{
	// Token: 0x0601CA82 RID: 117378 RVA: 0x008C07A4 File Offset: 0x008BE9A4
	[NullableContext(1)]
	protected __SceneInteractionDebugTool_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA83 RID: 117379 RVA: 0x008C07D7 File Offset: 0x008BE9D7
	protected __SceneInteractionDebugTool_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
