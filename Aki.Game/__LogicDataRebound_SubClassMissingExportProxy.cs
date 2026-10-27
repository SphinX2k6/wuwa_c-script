using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003907 RID: 14599
public class __LogicDataRebound_SubClassMissingExportProxy : __LogicDataRebound_InheritProxy
{
	// Token: 0x0601EB86 RID: 125830 RVA: 0x0089849C File Offset: 0x0089669C
	[NullableContext(1)]
	protected __LogicDataRebound_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB87 RID: 125831 RVA: 0x008984CF File Offset: 0x008966CF
	protected __LogicDataRebound_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
