using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC3 RID: 11971
public class __TsSimpleInteractPlane_InheritProxy : TsSimpleInteractPlane
{
	// Token: 0x0601C8E9 RID: 116969 RVA: 0x008BDB04 File Offset: 0x008BBD04
	[NullableContext(1)]
	public __TsSimpleInteractPlane_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPlane.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8EA RID: 116970 RVA: 0x008BDB37 File Offset: 0x008BBD37
	protected __TsSimpleInteractPlane_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
