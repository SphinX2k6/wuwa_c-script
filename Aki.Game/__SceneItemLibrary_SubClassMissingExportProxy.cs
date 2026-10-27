using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394D RID: 14669
public class __SceneItemLibrary_SubClassMissingExportProxy : __SceneItemLibrary_InheritProxy
{
	// Token: 0x0601EC4F RID: 126031 RVA: 0x0089A224 File Offset: 0x00898424
	[NullableContext(1)]
	protected __SceneItemLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC50 RID: 126032 RVA: 0x0089A257 File Offset: 0x00898457
	protected __SceneItemLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
