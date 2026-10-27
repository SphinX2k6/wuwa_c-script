using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003928 RID: 14632
public class __TsGameplayBlueprintFunctionLibrary_InheritProxy : TsGameplayBlueprintFunctionLibrary
{
	// Token: 0x0601EBE0 RID: 125920 RVA: 0x008991C0 File Offset: 0x008973C0
	[NullableContext(1)]
	public __TsGameplayBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBE1 RID: 125921 RVA: 0x008991F3 File Offset: 0x008973F3
	protected __TsGameplayBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
