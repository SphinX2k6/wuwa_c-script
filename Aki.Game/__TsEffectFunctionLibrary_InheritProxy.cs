using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200389C RID: 14492
public class __TsEffectFunctionLibrary_InheritProxy : TsEffectFunctionLibrary
{
	// Token: 0x0601EA3B RID: 125499 RVA: 0x0089551C File Offset: 0x0089371C
	[NullableContext(1)]
	public __TsEffectFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA3C RID: 125500 RVA: 0x0089554F File Offset: 0x0089374F
	protected __TsEffectFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
