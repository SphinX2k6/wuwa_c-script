using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CA RID: 14794
public class __SwitcherLibrary_InheritProxy : SwitcherLibrary
{
	// Token: 0x0601EF13 RID: 126739 RVA: 0x008A3584 File Offset: 0x008A1784
	[NullableContext(1)]
	public __SwitcherLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF14 RID: 126740 RVA: 0x008A35B7 File Offset: 0x008A17B7
	protected __SwitcherLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
