using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7F RID: 11903
public class __LogicDataRebound_InheritProxy : LogicDataRebound
{
	// Token: 0x0601C83C RID: 116796 RVA: 0x008BC904 File Offset: 0x008BAB04
	[NullableContext(1)]
	public __LogicDataRebound_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C83D RID: 116797 RVA: 0x008BC937 File Offset: 0x008BAB37
	protected __LogicDataRebound_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
