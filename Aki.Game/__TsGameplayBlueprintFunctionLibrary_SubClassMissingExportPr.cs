using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003929 RID: 14633
public class __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsGameplayBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBE2 RID: 125922 RVA: 0x008991FC File Offset: 0x008973FC
	[NullableContext(1)]
	protected __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBE3 RID: 125923 RVA: 0x0089922F File Offset: 0x0089742F
	protected __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
