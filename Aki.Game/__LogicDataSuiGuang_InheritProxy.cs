using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8F RID: 11919
public class __LogicDataSuiGuang_InheritProxy : LogicDataSuiGuang
{
	// Token: 0x0601C85C RID: 116828 RVA: 0x008BCCC4 File Offset: 0x008BAEC4
	[NullableContext(1)]
	public __LogicDataSuiGuang_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C85D RID: 116829 RVA: 0x008BCCF7 File Offset: 0x008BAEF7
	protected __LogicDataSuiGuang_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
