using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB7 RID: 11959
public class __TsSimpleNpc_InheritProxy : TsSimpleNpc
{
	// Token: 0x0601C8B9 RID: 116921 RVA: 0x008BD6A4 File Offset: 0x008BB8A4
	[NullableContext(1)]
	public __TsSimpleNpc_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8BA RID: 116922 RVA: 0x008BD6D7 File Offset: 0x008BB8D7
	protected __TsSimpleNpc_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C8BB RID: 116923 RVA: 0x008BD6E0 File Offset: 0x008BB8E0
	protected override void __CPPCALL_EditorInit_Implementation()
	{
		base.EditorInit_Implementation();
	}

	// Token: 0x0601C8BC RID: 116924 RVA: 0x008BD6E8 File Offset: 0x008BB8E8
	protected unsafe override void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C8BD RID: 116925 RVA: 0x008BD6F6 File Offset: 0x008BB8F6
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C8BE RID: 116926 RVA: 0x008BD6FE File Offset: 0x008BB8FE
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(TsSimpleNpc.__ReceiveEndPlay_FunctionParams* __Params)
	{
		base.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601C8BF RID: 116927 RVA: 0x008BD70C File Offset: 0x008BB90C
	protected override void __CPPCALL_LoadModel_Implementation()
	{
		base.LoadModel_Implementation();
	}

	// Token: 0x0601C8C0 RID: 116928 RVA: 0x008BD714 File Offset: 0x008BB914
	protected unsafe override void __CPPCALL_DebugSetNpcDitherValue_Implementation(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* __Params)
	{
		base.DebugSetNpcDitherValue_Implementation(__Params->value);
	}

	// Token: 0x0601C8C1 RID: 116929 RVA: 0x008BD722 File Offset: 0x008BB922
	protected override void __CPPCALL_SetDefaultCollision_Implementation()
	{
		base.SetDefaultCollision_Implementation();
	}

	// Token: 0x0601C8C2 RID: 116930 RVA: 0x008BD72A File Offset: 0x008BB92A
	protected override void __CPPCALL_ResetMeshLocation_Implementation()
	{
		base.ResetMeshLocation_Implementation();
	}

	// Token: 0x0601C8C3 RID: 116931 RVA: 0x008BD732 File Offset: 0x008BB932
	protected override void __CPPCALL_FindFloor_Implementation()
	{
		base.FindFloor_Implementation();
	}

	// Token: 0x0601C8C4 RID: 116932 RVA: 0x008BD73C File Offset: 0x008BB93C
	protected unsafe override void __CPPCALL_ShowDialog_Implementation(TsSimpleNpc.__ShowDialog_FunctionParams* __Params)
	{
		string text = FString.ToString((void*)(&__Params->text));
		base.ShowDialog_Implementation(text, __Params->removeSeconds);
	}

	// Token: 0x0601C8C5 RID: 116933 RVA: 0x008BD763 File Offset: 0x008BB963
	protected override void __CPPCALL_HideDialog_Implementation()
	{
		base.HideDialog_Implementation();
	}

	// Token: 0x0601C8C6 RID: 116934 RVA: 0x008BD76C File Offset: 0x008BB96C
	protected unsafe override void __CPPCALL_TryPlayMontage_Implementation(TsSimpleNpc.__TryPlayMontage_FunctionParams* __Params)
	{
		string montagePath = FString.ToString((void*)(&__Params->montagePath));
		__Params->__Result = base.TryPlayMontage_Implementation(montagePath);
	}

	// Token: 0x0601C8C7 RID: 116935 RVA: 0x008BD793 File Offset: 0x008BB993
	protected override void __CPPCALL_StopMontage_Implementation()
	{
		base.StopMontage_Implementation();
	}
}
