using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CD RID: 14797
public class __WorldFunctionLibrary_SubClassMissingExportProxy : __WorldFunctionLibrary_InheritProxy
{
	// Token: 0x0601EF19 RID: 126745 RVA: 0x008A3638 File Offset: 0x008A1838
	[NullableContext(1)]
	protected __WorldFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WorldFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF1A RID: 126746 RVA: 0x008A366B File Offset: 0x008A186B
	protected __WorldFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
