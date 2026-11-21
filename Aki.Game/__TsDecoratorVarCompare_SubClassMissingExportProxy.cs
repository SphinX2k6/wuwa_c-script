using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B06 RID: 11014
public class __TsDecoratorVarCompare_SubClassMissingExportProxy : __TsDecoratorVarCompare_InheritProxy
{
	// Token: 0x0601BD7D RID: 114045 RVA: 0x008A60E0 File Offset: 0x008A42E0
	[NullableContext(1)]
	protected __TsDecoratorVarCompare_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorVarCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD7E RID: 114046 RVA: 0x008A6113 File Offset: 0x008A4313
	protected __TsDecoratorVarCompare_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
