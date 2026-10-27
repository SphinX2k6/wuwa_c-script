using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003915 RID: 14613
public class __LogicDataSuiGuang_SubClassMissingExportProxy : __LogicDataSuiGuang_InheritProxy
{
	// Token: 0x0601EBA2 RID: 125858 RVA: 0x008987E4 File Offset: 0x008969E4
	[NullableContext(1)]
	protected __LogicDataSuiGuang_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBA3 RID: 125859 RVA: 0x00898817 File Offset: 0x00896A17
	protected __LogicDataSuiGuang_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
