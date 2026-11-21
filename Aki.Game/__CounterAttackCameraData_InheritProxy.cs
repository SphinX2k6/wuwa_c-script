using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0F RID: 11791
public class __CounterAttackCameraData_InheritProxy : CounterAttackCameraData
{
	// Token: 0x0601C706 RID: 116486 RVA: 0x008BA8E8 File Offset: 0x008B8AE8
	[NullableContext(1)]
	public __CounterAttackCameraData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C707 RID: 116487 RVA: 0x008BA91B File Offset: 0x008B8B1B
	protected __CounterAttackCameraData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
