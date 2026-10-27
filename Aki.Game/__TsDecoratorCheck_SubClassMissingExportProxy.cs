using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200356F RID: 13679
public class __TsDecoratorCheck_SubClassMissingExportProxy : __TsDecoratorCheck_InheritProxy
{
	// Token: 0x0601E000 RID: 122880 RVA: 0x0087D4E0 File Offset: 0x0087B6E0
	[NullableContext(1)]
	protected __TsDecoratorCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E001 RID: 122881 RVA: 0x0087D513 File Offset: 0x0087B713
	protected __TsDecoratorCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
