using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B5 RID: 14517
public class __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy : __AiWeaponBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA8C RID: 125580 RVA: 0x00896404 File Offset: 0x00894604
	[NullableContext(1)]
	protected __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA8D RID: 125581 RVA: 0x00896437 File Offset: 0x00894637
	protected __AiWeaponBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
