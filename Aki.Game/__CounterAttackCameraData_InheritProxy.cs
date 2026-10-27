using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003896 RID: 14486
public class __CounterAttackCameraData_InheritProxy : CounterAttackCameraData
{
	// Token: 0x0601EA28 RID: 125480 RVA: 0x00895210 File Offset: 0x00893410
	[NullableContext(1)]
	public __CounterAttackCameraData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA29 RID: 125481 RVA: 0x00895243 File Offset: 0x00893443
	protected __CounterAttackCameraData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
