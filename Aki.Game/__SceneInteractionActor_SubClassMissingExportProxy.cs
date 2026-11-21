using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F3C RID: 12092
public class __SceneInteractionActor_SubClassMissingExportProxy : __SceneInteractionActor_InheritProxy
{
	// Token: 0x0601CACA RID: 117450 RVA: 0x008C0DA8 File Offset: 0x008BEFA8
	[NullableContext(1)]
	protected __SceneInteractionActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CACB RID: 117451 RVA: 0x008C0DDB File Offset: 0x008BEFDB
	protected __SceneInteractionActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
