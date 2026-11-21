using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F41 RID: 12097
public class __CombatDebugBlueprintFunctionLibrary_InheritProxy : CombatDebugBlueprintFunctionLibrary
{
	// Token: 0x0601CAED RID: 117485 RVA: 0x008C106C File Offset: 0x008BF26C
	[NullableContext(1)]
	public __CombatDebugBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAEE RID: 117486 RVA: 0x008C109F File Offset: 0x008BF29F
	protected __CombatDebugBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
