using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F4B RID: 12107
public class __TsGameBudgetFunctionLibrary_InheritProxy : TsGameBudgetFunctionLibrary
{
	// Token: 0x0601CB0B RID: 117515 RVA: 0x008C13E4 File Offset: 0x008BF5E4
	[NullableContext(1)]
	public __TsGameBudgetFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CB0C RID: 117516 RVA: 0x008C1417 File Offset: 0x008BF617
	protected __TsGameBudgetFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
