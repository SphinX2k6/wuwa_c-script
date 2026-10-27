using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A7 RID: 13991
public class __TsTaskRandomFloat_SubClassMissingExportProxy : __TsTaskRandomFloat_InheritProxy
{
	// Token: 0x0601E350 RID: 123728 RVA: 0x00884B64 File Offset: 0x00882D64
	[NullableContext(1)]
	protected __TsTaskRandomFloat_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E351 RID: 123729 RVA: 0x00884B97 File Offset: 0x00882D97
	protected __TsTaskRandomFloat_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
