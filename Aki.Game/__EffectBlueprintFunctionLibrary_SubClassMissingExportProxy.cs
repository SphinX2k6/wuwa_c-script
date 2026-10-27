using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B1 RID: 14769
public class __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy : __EffectBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EE47 RID: 126535 RVA: 0x008A07B4 File Offset: 0x0089E9B4
	[NullableContext(1)]
	protected __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE48 RID: 126536 RVA: 0x008A07E7 File Offset: 0x0089E9E7
	protected __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
