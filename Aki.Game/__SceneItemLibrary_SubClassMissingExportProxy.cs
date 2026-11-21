using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC8 RID: 11976
public class __SceneItemLibrary_SubClassMissingExportProxy : __SceneItemLibrary_InheritProxy
{
	// Token: 0x0601C8F3 RID: 116979 RVA: 0x008BDC30 File Offset: 0x008BBE30
	[NullableContext(1)]
	protected __SceneItemLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8F4 RID: 116980 RVA: 0x008BDC63 File Offset: 0x008BBE63
	protected __SceneItemLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
