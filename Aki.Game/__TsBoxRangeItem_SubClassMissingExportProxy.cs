using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003941 RID: 14657
public class __TsBoxRangeItem_SubClassMissingExportProxy : __TsBoxRangeItem_InheritProxy
{
	// Token: 0x0601EC2F RID: 125999 RVA: 0x00899DC0 File Offset: 0x00897FC0
	[NullableContext(1)]
	protected __TsBoxRangeItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC30 RID: 126000 RVA: 0x00899DF3 File Offset: 0x00897FF3
	protected __TsBoxRangeItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
