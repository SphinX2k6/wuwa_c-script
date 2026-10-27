using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CE RID: 14542
public class __TsTowerDefenseEventActor_InheritProxy : TsTowerDefenseEventActor
{
	// Token: 0x0601EAEB RID: 125675 RVA: 0x00897464 File Offset: 0x00895664
	[NullableContext(1)]
	public __TsTowerDefenseEventActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAEC RID: 125676 RVA: 0x00897497 File Offset: 0x00895697
	protected __TsTowerDefenseEventActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAED RID: 125677 RVA: 0x008974A0 File Offset: 0x008956A0
	protected override void __CPPCALL_OnLevelShown_Implementation()
	{
		base.OnLevelShown_Implementation();
	}
}
