using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003900 RID: 14592
public class __LogicDataFreeze_InheritProxy : LogicDataFreeze
{
	// Token: 0x0601EB78 RID: 125816 RVA: 0x008982F8 File Offset: 0x008964F8
	[NullableContext(1)]
	public __LogicDataFreeze_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB79 RID: 125817 RVA: 0x0089832B File Offset: 0x0089652B
	protected __LogicDataFreeze_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
