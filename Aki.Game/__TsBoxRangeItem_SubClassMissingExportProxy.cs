using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBC RID: 11964
public class __TsBoxRangeItem_SubClassMissingExportProxy : __TsBoxRangeItem_InheritProxy
{
	// Token: 0x0601C8D5 RID: 116949 RVA: 0x008BD8E0 File Offset: 0x008BBAE0
	[NullableContext(1)]
	protected __TsBoxRangeItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8D6 RID: 116950 RVA: 0x008BD913 File Offset: 0x008BBB13
	protected __TsBoxRangeItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
