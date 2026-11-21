using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F45 RID: 12101
public class __SwitcherLibrary_InheritProxy : SwitcherLibrary
{
	// Token: 0x0601CAF5 RID: 117493 RVA: 0x008C115C File Offset: 0x008BF35C
	[NullableContext(1)]
	public __SwitcherLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAF6 RID: 117494 RVA: 0x008C118F File Offset: 0x008BF38F
	protected __SwitcherLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
