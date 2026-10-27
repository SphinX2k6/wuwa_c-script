using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035EF RID: 13807
public class __TsServiceSimpleSense_SubClassMissingExportProxy : __TsServiceSimpleSense_InheritProxy
{
	// Token: 0x0601E143 RID: 123203 RVA: 0x0088007C File Offset: 0x0087E27C
	[NullableContext(1)]
	protected __TsServiceSimpleSense_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E144 RID: 123204 RVA: 0x008800AF File Offset: 0x0087E2AF
	protected __TsServiceSimpleSense_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
