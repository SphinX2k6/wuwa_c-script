using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E78 RID: 11896
public class __LogicDataForce_SubClassMissingExportProxy : __LogicDataForce_InheritProxy
{
	// Token: 0x0601C82E RID: 116782 RVA: 0x008BC760 File Offset: 0x008BA960
	[NullableContext(1)]
	protected __LogicDataForce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C82F RID: 116783 RVA: 0x008BC793 File Offset: 0x008BA993
	protected __LogicDataForce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
