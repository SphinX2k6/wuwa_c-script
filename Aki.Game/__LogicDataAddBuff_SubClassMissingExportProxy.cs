using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E66 RID: 11878
public class __LogicDataAddBuff_SubClassMissingExportProxy : __LogicDataAddBuff_InheritProxy
{
	// Token: 0x0601C80A RID: 116746 RVA: 0x008BC328 File Offset: 0x008BA528
	[NullableContext(1)]
	protected __LogicDataAddBuff_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C80B RID: 116747 RVA: 0x008BC35B File Offset: 0x008BA55B
	protected __LogicDataAddBuff_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
