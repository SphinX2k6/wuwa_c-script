using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003920 RID: 14624
public class __TsAiBlueprintFunctionLibrary_InheritProxy : TsAiBlueprintFunctionLibrary
{
	// Token: 0x0601EBD0 RID: 125904 RVA: 0x00898FE0 File Offset: 0x008971E0
	[NullableContext(1)]
	public __TsAiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBD1 RID: 125905 RVA: 0x00899013 File Offset: 0x00897213
	protected __TsAiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
