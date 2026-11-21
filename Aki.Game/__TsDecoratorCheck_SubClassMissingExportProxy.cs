using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AE4 RID: 10980
public class __TsDecoratorCheck_SubClassMissingExportProxy : __TsDecoratorCheck_InheritProxy
{
	// Token: 0x0601BD28 RID: 113960 RVA: 0x008A5574 File Offset: 0x008A3774
	[NullableContext(1)]
	protected __TsDecoratorCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD29 RID: 113961 RVA: 0x008A55A7 File Offset: 0x008A37A7
	protected __TsDecoratorCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
