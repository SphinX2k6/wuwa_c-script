using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394A RID: 14666
public class __TsSimpleInteractPoint_InheritProxy : TsSimpleInteractPoint
{
	// Token: 0x0601EC49 RID: 126025 RVA: 0x0089A170 File Offset: 0x00898370
	[NullableContext(1)]
	public __TsSimpleInteractPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC4A RID: 126026 RVA: 0x0089A1A3 File Offset: 0x008983A3
	protected __TsSimpleInteractPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
