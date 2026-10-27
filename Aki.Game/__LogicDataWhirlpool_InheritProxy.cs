using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200391A RID: 14618
public class __LogicDataWhirlpool_InheritProxy : LogicDataWhirlpool
{
	// Token: 0x0601EBAC RID: 125868 RVA: 0x00898910 File Offset: 0x00896B10
	[NullableContext(1)]
	public __LogicDataWhirlpool_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBAD RID: 125869 RVA: 0x00898943 File Offset: 0x00896B43
	protected __LogicDataWhirlpool_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
