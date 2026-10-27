using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003591 RID: 13713
public class __TsDecoratorVarCompare_SubClassMissingExportProxy : __TsDecoratorVarCompare_InheritProxy
{
	// Token: 0x0601E055 RID: 122965 RVA: 0x0087E04C File Offset: 0x0087C24C
	[NullableContext(1)]
	protected __TsDecoratorVarCompare_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorVarCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E056 RID: 122966 RVA: 0x0087E07F File Offset: 0x0087C27F
	protected __TsDecoratorVarCompare_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
