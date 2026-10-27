using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003906 RID: 14598
public class __LogicDataRebound_InheritProxy : LogicDataRebound
{
	// Token: 0x0601EB84 RID: 125828 RVA: 0x00898460 File Offset: 0x00896660
	[NullableContext(1)]
	public __LogicDataRebound_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB85 RID: 125829 RVA: 0x00898493 File Offset: 0x00896693
	protected __LogicDataRebound_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
