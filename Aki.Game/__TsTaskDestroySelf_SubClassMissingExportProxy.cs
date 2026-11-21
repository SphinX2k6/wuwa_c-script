using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BDE RID: 11230
public class __TsTaskDestroySelf_SubClassMissingExportProxy : __TsTaskDestroySelf_InheritProxy
{
	// Token: 0x0601BFC0 RID: 114624 RVA: 0x008AAE04 File Offset: 0x008A9004
	[NullableContext(1)]
	protected __TsTaskDestroySelf_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDestroySelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFC1 RID: 114625 RVA: 0x008AAE37 File Offset: 0x008A9037
	protected __TsTaskDestroySelf_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
