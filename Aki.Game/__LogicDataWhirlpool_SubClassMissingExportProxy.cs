using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E96 RID: 11926
public class __LogicDataWhirlpool_SubClassMissingExportProxy : __LogicDataWhirlpool_InheritProxy
{
	// Token: 0x0601C86A RID: 116842 RVA: 0x008BCE68 File Offset: 0x008BB068
	[NullableContext(1)]
	protected __LogicDataWhirlpool_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C86B RID: 116843 RVA: 0x008BCE9B File Offset: 0x008BB09B
	protected __LogicDataWhirlpool_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
