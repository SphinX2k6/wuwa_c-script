using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E80 RID: 11904
public class __LogicDataRebound_SubClassMissingExportProxy : __LogicDataRebound_InheritProxy
{
	// Token: 0x0601C83E RID: 116798 RVA: 0x008BC940 File Offset: 0x008BAB40
	[NullableContext(1)]
	protected __LogicDataRebound_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C83F RID: 116799 RVA: 0x008BC973 File Offset: 0x008BAB73
	protected __LogicDataRebound_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
