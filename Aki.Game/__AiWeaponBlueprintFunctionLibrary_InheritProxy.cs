using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2D RID: 11821
public class __AiWeaponBlueprintFunctionLibrary_InheritProxy : AiWeaponBlueprintFunctionLibrary
{
	// Token: 0x0601C757 RID: 116567 RVA: 0x008BB224 File Offset: 0x008B9424
	[NullableContext(1)]
	public __AiWeaponBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C758 RID: 116568 RVA: 0x008BB257 File Offset: 0x008B9457
	protected __AiWeaponBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
