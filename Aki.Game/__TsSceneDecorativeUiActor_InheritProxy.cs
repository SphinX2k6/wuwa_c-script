using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C4 RID: 14532
public class __TsSceneDecorativeUiActor_InheritProxy : TsSceneDecorativeUiActor
{
	// Token: 0x0601EACC RID: 125644 RVA: 0x00896FE4 File Offset: 0x008951E4
	[NullableContext(1)]
	public __TsSceneDecorativeUiActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EACD RID: 125645 RVA: 0x00897017 File Offset: 0x00895217
	protected __TsSceneDecorativeUiActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EACE RID: 125646 RVA: 0x00897020 File Offset: 0x00895220
	protected override void __CPPCALL_Create3dUi_Implementation()
	{
		base.Create3dUi_Implementation();
	}

	// Token: 0x0601EACF RID: 125647 RVA: 0x00897028 File Offset: 0x00895228
	protected override void __CPPCALL_Destroy3dUi_Implementation()
	{
		base.Destroy3dUi_Implementation();
	}

	// Token: 0x0601EAD0 RID: 125648 RVA: 0x00897030 File Offset: 0x00895230
	protected override void __CPPCALL_DrawDistance_Implementation()
	{
		base.DrawDistance_Implementation();
	}
}
