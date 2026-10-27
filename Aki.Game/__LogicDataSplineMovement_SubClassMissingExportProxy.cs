using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003913 RID: 14611
public class __LogicDataSplineMovement_SubClassMissingExportProxy : __LogicDataSplineMovement_InheritProxy
{
	// Token: 0x0601EB9E RID: 125854 RVA: 0x0089876C File Offset: 0x0089696C
	[NullableContext(1)]
	protected __LogicDataSplineMovement_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB9F RID: 125855 RVA: 0x0089879F File Offset: 0x0089699F
	protected __LogicDataSplineMovement_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
