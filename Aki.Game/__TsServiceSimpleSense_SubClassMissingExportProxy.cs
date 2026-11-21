using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B64 RID: 11108
public class __TsServiceSimpleSense_SubClassMissingExportProxy : __TsServiceSimpleSense_InheritProxy
{
	// Token: 0x0601BE6B RID: 114283 RVA: 0x008A8110 File Offset: 0x008A6310
	[NullableContext(1)]
	protected __TsServiceSimpleSense_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE6C RID: 114284 RVA: 0x008A8143 File Offset: 0x008A6343
	protected __TsServiceSimpleSense_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
