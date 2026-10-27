using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003583 RID: 13699
public class __TsDecoratorDistanceCheck_SubClassMissingExportProxy : __TsDecoratorDistanceCheck_InheritProxy
{
	// Token: 0x0601E032 RID: 122930 RVA: 0x0087DB98 File Offset: 0x0087BD98
	[NullableContext(1)]
	protected __TsDecoratorDistanceCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E033 RID: 122931 RVA: 0x0087DBCB File Offset: 0x0087BDCB
	protected __TsDecoratorDistanceCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
