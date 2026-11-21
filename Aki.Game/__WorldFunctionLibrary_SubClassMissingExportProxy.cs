using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F48 RID: 12104
public class __WorldFunctionLibrary_SubClassMissingExportProxy : __WorldFunctionLibrary_InheritProxy
{
	// Token: 0x0601CAFB RID: 117499 RVA: 0x008C1210 File Offset: 0x008BF410
	[NullableContext(1)]
	protected __WorldFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WorldFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAFC RID: 117500 RVA: 0x008C1243 File Offset: 0x008BF443
	protected __WorldFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
