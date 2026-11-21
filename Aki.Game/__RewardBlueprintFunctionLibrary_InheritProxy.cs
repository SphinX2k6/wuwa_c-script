using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E3B RID: 11835
public class __RewardBlueprintFunctionLibrary_InheritProxy : RewardBlueprintFunctionLibrary
{
	// Token: 0x0601C786 RID: 116614 RVA: 0x008BB6C8 File Offset: 0x008B98C8
	[NullableContext(1)]
	public __RewardBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C787 RID: 116615 RVA: 0x008BB6FB File Offset: 0x008B98FB
	protected __RewardBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
