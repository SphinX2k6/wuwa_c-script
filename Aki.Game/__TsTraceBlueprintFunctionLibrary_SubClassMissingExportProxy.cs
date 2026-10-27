using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003935 RID: 14645
public class __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsTraceBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBFA RID: 125946 RVA: 0x008994CC File Offset: 0x008976CC
	[NullableContext(1)]
	protected __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBFB RID: 125947 RVA: 0x008994FF File Offset: 0x008976FF
	protected __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
