using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E64 RID: 11876
public class __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy : __BulletBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C806 RID: 116742 RVA: 0x008BC2B0 File Offset: 0x008BA4B0
	[NullableContext(1)]
	protected __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C807 RID: 116743 RVA: 0x008BC2E3 File Offset: 0x008BA4E3
	protected __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
