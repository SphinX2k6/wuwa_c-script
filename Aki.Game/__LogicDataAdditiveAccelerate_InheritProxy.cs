using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038EE RID: 14574
public class __LogicDataAdditiveAccelerate_InheritProxy : LogicDataAdditiveAccelerate
{
	// Token: 0x0601EB54 RID: 125780 RVA: 0x00897EC0 File Offset: 0x008960C0
	[NullableContext(1)]
	public __LogicDataAdditiveAccelerate_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB55 RID: 125781 RVA: 0x00897EF3 File Offset: 0x008960F3
	protected __LogicDataAdditiveAccelerate_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
