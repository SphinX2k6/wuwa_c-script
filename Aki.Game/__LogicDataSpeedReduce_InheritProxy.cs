using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003910 RID: 14608
public class __LogicDataSpeedReduce_InheritProxy : LogicDataSpeedReduce
{
	// Token: 0x0601EB98 RID: 125848 RVA: 0x008986B8 File Offset: 0x008968B8
	[NullableContext(1)]
	public __LogicDataSpeedReduce_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB99 RID: 125849 RVA: 0x008986EB File Offset: 0x008968EB
	protected __LogicDataSpeedReduce_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
