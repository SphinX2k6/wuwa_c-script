using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F3E RID: 12094
public class __SceneInteractionDebugActor_SubClassMissingExportProxy : __SceneInteractionDebugActor_InheritProxy
{
	// Token: 0x0601CADD RID: 117469 RVA: 0x008C0E98 File Offset: 0x008BF098
	[NullableContext(1)]
	protected __SceneInteractionDebugActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CADE RID: 117470 RVA: 0x008C0ECB File Offset: 0x008BF0CB
	protected __SceneInteractionDebugActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
