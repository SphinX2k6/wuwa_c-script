using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C6 RID: 14790
public class __CombatDebugBlueprintFunctionLibrary_InheritProxy : CombatDebugBlueprintFunctionLibrary
{
	// Token: 0x0601EF0B RID: 126731 RVA: 0x008A3494 File Offset: 0x008A1694
	[NullableContext(1)]
	public __CombatDebugBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF0C RID: 126732 RVA: 0x008A34C7 File Offset: 0x008A16C7
	protected __CombatDebugBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
