using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2E RID: 11822
public class __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy : __AiWeaponBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C759 RID: 116569 RVA: 0x008BB260 File Offset: 0x008B9460
	[NullableContext(1)]
	protected __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C75A RID: 116570 RVA: 0x008BB293 File Offset: 0x008B9493
	protected __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
