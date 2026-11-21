using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E16 RID: 11798
public class __TsEffectFunctionLibrary_SubClassMissingExportProxy : __TsEffectFunctionLibrary_InheritProxy
{
	// Token: 0x0601C718 RID: 116504 RVA: 0x008BAAD0 File Offset: 0x008B8CD0
	[NullableContext(1)]
	protected __TsEffectFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C719 RID: 116505 RVA: 0x008BAB03 File Offset: 0x008B8D03
	protected __TsEffectFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
