using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003922 RID: 14626
public class __TsBattleUiBlueprintFunctionLibrary_InheritProxy : TsBattleUiBlueprintFunctionLibrary
{
	// Token: 0x0601EBD4 RID: 125908 RVA: 0x00899058 File Offset: 0x00897258
	[NullableContext(1)]
	public __TsBattleUiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBD5 RID: 125909 RVA: 0x0089908B File Offset: 0x0089728B
	protected __TsBattleUiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
