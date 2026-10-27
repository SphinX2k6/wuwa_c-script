using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F0 RID: 14576
public class __LogicDataBase_InheritProxy : LogicDataBase
{
	// Token: 0x0601EB58 RID: 125784 RVA: 0x00897F38 File Offset: 0x00896138
	[NullableContext(1)]
	public __LogicDataBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB59 RID: 125785 RVA: 0x00897F6B File Offset: 0x0089616B
	protected __LogicDataBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
