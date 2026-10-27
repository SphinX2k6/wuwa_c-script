using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C3 RID: 14531
public class __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy : __RewardBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EACA RID: 125642 RVA: 0x00896FA8 File Offset: 0x008951A8
	[NullableContext(1)]
	protected __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EACB RID: 125643 RVA: 0x00896FDB File Offset: 0x008951DB
	protected __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
