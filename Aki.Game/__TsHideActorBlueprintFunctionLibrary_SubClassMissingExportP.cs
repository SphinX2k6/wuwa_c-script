using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038BD RID: 14525
public class __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsHideActorBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA9E RID: 125598 RVA: 0x0089664C File Offset: 0x0089484C
	[NullableContext(1)]
	protected __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA9F RID: 125599 RVA: 0x0089667F File Offset: 0x0089487F
	protected __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
