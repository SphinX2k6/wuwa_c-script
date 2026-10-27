using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039BE RID: 14782
public class __ItemMaterialDebugActor_InheritProxy : ItemMaterialDebugActor
{
	// Token: 0x0601EE6E RID: 126574 RVA: 0x008A0DF0 File Offset: 0x0089EFF0
	[NullableContext(1)]
	public __ItemMaterialDebugActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE6F RID: 126575 RVA: 0x008A0E23 File Offset: 0x0089F023
	protected __ItemMaterialDebugActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE70 RID: 126576 RVA: 0x008A0E2C File Offset: 0x0089F02C
	protected override void __CPPCALL_DisableAllActorData_Implementation()
	{
		base.DisableAllActorData_Implementation();
	}

	// Token: 0x0601EE71 RID: 126577 RVA: 0x008A0E34 File Offset: 0x0089F034
	protected override void __CPPCALL_DisableActorData_Implementation()
	{
		base.DisableActorData_Implementation();
	}

	// Token: 0x0601EE72 RID: 126578 RVA: 0x008A0E3C File Offset: 0x0089F03C
	protected override void __CPPCALL_EnableActorData_Implementation()
	{
		base.EnableActorData_Implementation();
	}

	// Token: 0x0601EE73 RID: 126579 RVA: 0x008A0E44 File Offset: 0x0089F044
	protected override void __CPPCALL_SimpleMaterialControllerDisable_Implementation()
	{
		base.SimpleMaterialControllerDisable_Implementation();
	}

	// Token: 0x0601EE74 RID: 126580 RVA: 0x008A0E4C File Offset: 0x0089F04C
	protected override void __CPPCALL_SimpleMaterialControllerUpdate_Implementation()
	{
		base.SimpleMaterialControllerUpdate_Implementation();
	}
}
