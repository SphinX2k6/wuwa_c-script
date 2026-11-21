using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E35 RID: 11829
public class __TsHideActorBlueprintFunctionLibrary_InheritProxy : TsHideActorBlueprintFunctionLibrary
{
	// Token: 0x0601C769 RID: 116585 RVA: 0x008BB46C File Offset: 0x008B966C
	[NullableContext(1)]
	public __TsHideActorBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C76A RID: 116586 RVA: 0x008BB49F File Offset: 0x008B969F
	protected __TsHideActorBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
