using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EF4 RID: 12020
public class __CharRenderingComponent_SubClassMissingExportProxy : __CharRenderingComponent_InheritProxy
{
	// Token: 0x0601C9EF RID: 117231 RVA: 0x008BF634 File Offset: 0x008BD834
	[NullableContext(1)]
	protected __CharRenderingComponent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C9F0 RID: 117232 RVA: 0x008BF667 File Offset: 0x008BD867
	protected __CharRenderingComponent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
