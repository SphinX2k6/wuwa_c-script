using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E90 RID: 11920
public class __LogicDataSuiGuang_SubClassMissingExportProxy : __LogicDataSuiGuang_InheritProxy
{
	// Token: 0x0601C85E RID: 116830 RVA: 0x008BCD00 File Offset: 0x008BAF00
	[NullableContext(1)]
	protected __LogicDataSuiGuang_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C85F RID: 116831 RVA: 0x008BCD33 File Offset: 0x008BAF33
	protected __LogicDataSuiGuang_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
