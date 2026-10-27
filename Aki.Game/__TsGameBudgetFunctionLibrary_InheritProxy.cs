using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039D0 RID: 14800
public class __TsGameBudgetFunctionLibrary_InheritProxy : TsGameBudgetFunctionLibrary
{
	// Token: 0x0601EF33 RID: 126771 RVA: 0x008A3D24 File Offset: 0x008A1F24
	[NullableContext(1)]
	public __TsGameBudgetFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF34 RID: 126772 RVA: 0x008A3D57 File Offset: 0x008A1F57
	protected __TsGameBudgetFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
