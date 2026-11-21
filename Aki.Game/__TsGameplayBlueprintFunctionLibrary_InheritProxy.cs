using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA3 RID: 11939
public class __TsGameplayBlueprintFunctionLibrary_InheritProxy : TsGameplayBlueprintFunctionLibrary
{
	// Token: 0x0601C891 RID: 116881 RVA: 0x008BD1F4 File Offset: 0x008BB3F4
	[NullableContext(1)]
	public __TsGameplayBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C892 RID: 116882 RVA: 0x008BD227 File Offset: 0x008BB427
	protected __TsGameplayBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
