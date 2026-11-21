using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E15 RID: 11797
public class __TsEffectFunctionLibrary_InheritProxy : TsEffectFunctionLibrary
{
	// Token: 0x0601C716 RID: 116502 RVA: 0x008BAA94 File Offset: 0x008B8C94
	[NullableContext(1)]
	public __TsEffectFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C717 RID: 116503 RVA: 0x008BAAC7 File Offset: 0x008B8CC7
	protected __TsEffectFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
