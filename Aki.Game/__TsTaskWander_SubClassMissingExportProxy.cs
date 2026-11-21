using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C54 RID: 11348
public class __TsTaskWander_SubClassMissingExportProxy : __TsTaskWander_InheritProxy
{
	// Token: 0x0601C101 RID: 114945 RVA: 0x008AD9A4 File Offset: 0x008ABBA4
	[NullableContext(1)]
	protected __TsTaskWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C102 RID: 114946 RVA: 0x008AD9D7 File Offset: 0x008ABBD7
	protected __TsTaskWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
