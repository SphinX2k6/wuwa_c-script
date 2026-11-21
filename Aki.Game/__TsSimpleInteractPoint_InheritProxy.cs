using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC5 RID: 11973
public class __TsSimpleInteractPoint_InheritProxy : TsSimpleInteractPoint
{
	// Token: 0x0601C8ED RID: 116973 RVA: 0x008BDB7C File Offset: 0x008BBD7C
	[NullableContext(1)]
	public __TsSimpleInteractPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8EE RID: 116974 RVA: 0x008BDBAF File Offset: 0x008BBDAF
	protected __TsSimpleInteractPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
