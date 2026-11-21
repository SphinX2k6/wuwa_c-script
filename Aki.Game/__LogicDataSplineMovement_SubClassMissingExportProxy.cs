using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8E RID: 11918
public class __LogicDataSplineMovement_SubClassMissingExportProxy : __LogicDataSplineMovement_InheritProxy
{
	// Token: 0x0601C85A RID: 116826 RVA: 0x008BCC88 File Offset: 0x008BAE88
	[NullableContext(1)]
	protected __LogicDataSplineMovement_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C85B RID: 116827 RVA: 0x008BCCBB File Offset: 0x008BAEBB
	protected __LogicDataSplineMovement_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
