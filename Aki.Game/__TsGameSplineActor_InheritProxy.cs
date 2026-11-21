using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E21 RID: 11809
public class __TsGameSplineActor_InheritProxy : TsGameSplineActor
{
	// Token: 0x0601C730 RID: 116528 RVA: 0x008BADD0 File Offset: 0x008B8FD0
	[NullableContext(1)]
	public __TsGameSplineActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C731 RID: 116529 RVA: 0x008BAE03 File Offset: 0x008B9003
	protected __TsGameSplineActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
