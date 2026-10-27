using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003921 RID: 14625
public class __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsAiBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBD2 RID: 125906 RVA: 0x0089901C File Offset: 0x0089721C
	[NullableContext(1)]
	protected __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBD3 RID: 125907 RVA: 0x0089904F File Offset: 0x0089724F
	protected __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
