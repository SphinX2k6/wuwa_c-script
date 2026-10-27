using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003887 RID: 14471
public class __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy : __CameraBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601E9C1 RID: 125377 RVA: 0x00893D30 File Offset: 0x00891F30
	[NullableContext(1)]
	protected __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9C2 RID: 125378 RVA: 0x00893D63 File Offset: 0x00891F63
	protected __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
