using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C2 RID: 14530
public class __RewardBlueprintFunctionLibrary_InheritProxy : RewardBlueprintFunctionLibrary
{
	// Token: 0x0601EAC8 RID: 125640 RVA: 0x00896F6C File Offset: 0x0089516C
	[NullableContext(1)]
	public __RewardBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAC9 RID: 125641 RVA: 0x00896F9F File Offset: 0x0089519F
	protected __RewardBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
