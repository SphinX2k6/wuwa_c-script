using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A9 RID: 13993
public class __TsTaskRandomInt_SubClassMissingExportProxy : __TsTaskRandomInt_InheritProxy
{
	// Token: 0x0601E355 RID: 123733 RVA: 0x00884C0C File Offset: 0x00882E0C
	[NullableContext(1)]
	protected __TsTaskRandomInt_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E356 RID: 123734 RVA: 0x00884C3F File Offset: 0x00882E3F
	protected __TsTaskRandomInt_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
