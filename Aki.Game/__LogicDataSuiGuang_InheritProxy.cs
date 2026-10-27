using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003914 RID: 14612
public class __LogicDataSuiGuang_InheritProxy : LogicDataSuiGuang
{
	// Token: 0x0601EBA0 RID: 125856 RVA: 0x008987A8 File Offset: 0x008969A8
	[NullableContext(1)]
	public __LogicDataSuiGuang_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBA1 RID: 125857 RVA: 0x008987DB File Offset: 0x008969DB
	protected __LogicDataSuiGuang_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
