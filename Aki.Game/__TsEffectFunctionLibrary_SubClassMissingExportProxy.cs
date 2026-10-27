using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200389D RID: 14493
public class __TsEffectFunctionLibrary_SubClassMissingExportProxy : __TsEffectFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA3D RID: 125501 RVA: 0x00895558 File Offset: 0x00893758
	[NullableContext(1)]
	protected __TsEffectFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA3E RID: 125502 RVA: 0x0089558B File Offset: 0x0089378B
	protected __TsEffectFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
