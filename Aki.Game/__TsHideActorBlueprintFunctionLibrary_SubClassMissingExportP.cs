using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E36 RID: 11830
public class __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsHideActorBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C76B RID: 116587 RVA: 0x008BB4A8 File Offset: 0x008B96A8
	[NullableContext(1)]
	protected __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C76C RID: 116588 RVA: 0x008BB4DB File Offset: 0x008B96DB
	protected __TsHideActorBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
