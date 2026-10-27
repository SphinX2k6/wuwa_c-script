using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003912 RID: 14610
public class __LogicDataSplineMovement_InheritProxy : LogicDataSplineMovement
{
	// Token: 0x0601EB9C RID: 125852 RVA: 0x00898730 File Offset: 0x00896930
	[NullableContext(1)]
	public __LogicDataSplineMovement_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB9D RID: 125853 RVA: 0x00898763 File Offset: 0x00896963
	protected __LogicDataSplineMovement_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
