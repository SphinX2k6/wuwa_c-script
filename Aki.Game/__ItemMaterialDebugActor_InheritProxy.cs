using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F39 RID: 12089
public class __ItemMaterialDebugActor_InheritProxy : ItemMaterialDebugActor
{
	// Token: 0x0601CA95 RID: 117397 RVA: 0x008C09F4 File Offset: 0x008BEBF4
	[NullableContext(1)]
	public __ItemMaterialDebugActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA96 RID: 117398 RVA: 0x008C0A27 File Offset: 0x008BEC27
	protected __ItemMaterialDebugActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CA97 RID: 117399 RVA: 0x008C0A30 File Offset: 0x008BEC30
	protected override void __CPPCALL_DisableAllActorData_Implementation()
	{
		base.DisableAllActorData_Implementation();
	}

	// Token: 0x0601CA98 RID: 117400 RVA: 0x008C0A38 File Offset: 0x008BEC38
	protected override void __CPPCALL_DisableActorData_Implementation()
	{
		base.DisableActorData_Implementation();
	}

	// Token: 0x0601CA99 RID: 117401 RVA: 0x008C0A40 File Offset: 0x008BEC40
	protected override void __CPPCALL_EnableActorData_Implementation()
	{
		base.EnableActorData_Implementation();
	}

	// Token: 0x0601CA9A RID: 117402 RVA: 0x008C0A48 File Offset: 0x008BEC48
	protected override void __CPPCALL_SimpleMaterialControllerDisable_Implementation()
	{
		base.SimpleMaterialControllerDisable_Implementation();
	}

	// Token: 0x0601CA9B RID: 117403 RVA: 0x008C0A50 File Offset: 0x008BEC50
	protected override void __CPPCALL_SimpleMaterialControllerUpdate_Implementation()
	{
		base.SimpleMaterialControllerUpdate_Implementation();
	}
}
