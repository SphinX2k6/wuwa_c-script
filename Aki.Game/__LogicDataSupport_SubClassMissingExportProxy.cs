using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E94 RID: 11924
public class __LogicDataSupport_SubClassMissingExportProxy : __LogicDataSupport_InheritProxy
{
	// Token: 0x0601C866 RID: 116838 RVA: 0x008BCDF0 File Offset: 0x008BAFF0
	[NullableContext(1)]
	protected __LogicDataSupport_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C867 RID: 116839 RVA: 0x008BCE23 File Offset: 0x008BB023
	protected __LogicDataSupport_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
