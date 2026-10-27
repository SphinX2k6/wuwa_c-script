using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003925 RID: 14629
public class __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsControlBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBDA RID: 125914 RVA: 0x0089910C File Offset: 0x0089730C
	[NullableContext(1)]
	protected __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBDB RID: 125915 RVA: 0x0089913F File Offset: 0x0089733F
	protected __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
