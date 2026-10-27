using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003908 RID: 14600
public class __LogicDataShakeScreen_InheritProxy : LogicDataShakeScreen
{
	// Token: 0x0601EB88 RID: 125832 RVA: 0x008984D8 File Offset: 0x008966D8
	[NullableContext(1)]
	public __LogicDataShakeScreen_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB89 RID: 125833 RVA: 0x0089850B File Offset: 0x0089670B
	protected __LogicDataShakeScreen_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
