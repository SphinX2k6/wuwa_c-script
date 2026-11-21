using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8D RID: 11917
public class __LogicDataSplineMovement_InheritProxy : LogicDataSplineMovement
{
	// Token: 0x0601C858 RID: 116824 RVA: 0x008BCC4C File Offset: 0x008BAE4C
	[NullableContext(1)]
	public __LogicDataSplineMovement_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C859 RID: 116825 RVA: 0x008BCC7F File Offset: 0x008BAE7F
	protected __LogicDataSplineMovement_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
