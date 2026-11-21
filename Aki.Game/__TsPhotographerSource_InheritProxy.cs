using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E39 RID: 11833
public class __TsPhotographerSource_InheritProxy : TsPhotographerSource
{
	// Token: 0x0601C782 RID: 116610 RVA: 0x008BB650 File Offset: 0x008B9850
	[NullableContext(1)]
	public __TsPhotographerSource_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C783 RID: 116611 RVA: 0x008BB683 File Offset: 0x008B9883
	protected __TsPhotographerSource_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
