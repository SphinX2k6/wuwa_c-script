using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B7 RID: 14519
public class __UiBlueprintFunctionLibrary_SubClassMissingExportProxy : __UiBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA90 RID: 125584 RVA: 0x0089647C File Offset: 0x0089467C
	[NullableContext(1)]
	protected __UiBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA91 RID: 125585 RVA: 0x008964AF File Offset: 0x008946AF
	protected __UiBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
