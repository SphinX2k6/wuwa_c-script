using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A8 RID: 14504
public class __TsGameSplineActor_InheritProxy : TsGameSplineActor
{
	// Token: 0x0601EA56 RID: 125526 RVA: 0x008958C8 File Offset: 0x00893AC8
	[NullableContext(1)]
	public __TsGameSplineActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA57 RID: 125527 RVA: 0x008958FB File Offset: 0x00893AFB
	protected __TsGameSplineActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
