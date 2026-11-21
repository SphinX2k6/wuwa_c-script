using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E3C RID: 11836
public class __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy : __RewardBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C788 RID: 116616 RVA: 0x008BB704 File Offset: 0x008B9904
	[NullableContext(1)]
	protected __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C789 RID: 116617 RVA: 0x008BB737 File Offset: 0x008B9937
	protected __RewardBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
