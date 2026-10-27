using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D2 RID: 14546
public class __TsUiAutoPlayLevelSequenceComponent_InheritProxy : TsUiAutoPlayLevelSequenceComponent
{
	// Token: 0x0601EAF6 RID: 125686 RVA: 0x008975E4 File Offset: 0x008957E4
	[NullableContext(1)]
	public __TsUiAutoPlayLevelSequenceComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAF7 RID: 125687 RVA: 0x00897617 File Offset: 0x00895817
	protected __TsUiAutoPlayLevelSequenceComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAF8 RID: 125688 RVA: 0x00897620 File Offset: 0x00895820
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601EAF9 RID: 125689 RVA: 0x00897628 File Offset: 0x00895828
	protected unsafe override void __CPPCALL_OnUIActiveInHierarchyBP_Implementation(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* __Params)
	{
		base.OnUIActiveInHierarchyBP_Implementation(__Params->activeOrInactive);
	}

	// Token: 0x0601EAFA RID: 125690 RVA: 0x00897636 File Offset: 0x00895836
	protected override void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		base.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0601EAFB RID: 125691 RVA: 0x0089763E File Offset: 0x0089583E
	protected unsafe override void __CPPCALL_UpdateBP_Implementation(ULGUIBehaviour.__UpdateBP_FunctionParams* __Params)
	{
		base.UpdateBP_Implementation(__Params->DeltaTime);
	}
}
