using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E47 RID: 11847
public class __TsTowerDefenseEventActor_InheritProxy : TsTowerDefenseEventActor
{
	// Token: 0x0601C7A5 RID: 116645 RVA: 0x008BB9F8 File Offset: 0x008B9BF8
	[NullableContext(1)]
	public __TsTowerDefenseEventActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7A6 RID: 116646 RVA: 0x008BBA2B File Offset: 0x008B9C2B
	protected __TsTowerDefenseEventActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7A7 RID: 116647 RVA: 0x008BBA34 File Offset: 0x008B9C34
	protected override void __CPPCALL_OnLevelShown_Implementation()
	{
		base.OnLevelShown_Implementation();
	}
}
