using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E4B RID: 11851
public class __TsUiAutoPlayLevelSequenceComponent_InheritProxy : TsUiAutoPlayLevelSequenceComponent
{
	// Token: 0x0601C7AF RID: 116655 RVA: 0x008BBB00 File Offset: 0x008B9D00
	[NullableContext(1)]
	public __TsUiAutoPlayLevelSequenceComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7B0 RID: 116656 RVA: 0x008BBB33 File Offset: 0x008B9D33
	protected __TsUiAutoPlayLevelSequenceComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7B1 RID: 116657 RVA: 0x008BBB3C File Offset: 0x008B9D3C
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601C7B2 RID: 116658 RVA: 0x008BBB44 File Offset: 0x008B9D44
	protected unsafe override void __CPPCALL_OnUIActiveInHierarchyBP_Implementation(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* __Params)
	{
		base.OnUIActiveInHierarchyBP_Implementation(__Params->activeOrInactive);
	}

	// Token: 0x0601C7B3 RID: 116659 RVA: 0x008BBB52 File Offset: 0x008B9D52
	protected override void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		base.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0601C7B4 RID: 116660 RVA: 0x008BBB5A File Offset: 0x008B9D5A
	protected unsafe override void __CPPCALL_UpdateBP_Implementation(ULGUIBehaviour.__UpdateBP_FunctionParams* __Params)
	{
		base.UpdateBP_Implementation(__Params->DeltaTime);
	}
}
