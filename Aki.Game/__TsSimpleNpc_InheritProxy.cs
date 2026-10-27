using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393C RID: 14652
public class __TsSimpleNpc_InheritProxy : TsSimpleNpc
{
	// Token: 0x0601EC08 RID: 125960 RVA: 0x00899670 File Offset: 0x00897870
	[NullableContext(1)]
	public __TsSimpleNpc_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC09 RID: 125961 RVA: 0x008996A3 File Offset: 0x008978A3
	protected __TsSimpleNpc_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC0A RID: 125962 RVA: 0x008996AC File Offset: 0x008978AC
	protected override void __CPPCALL_EditorInit_Implementation()
	{
		base.EditorInit_Implementation();
	}

	// Token: 0x0601EC0B RID: 125963 RVA: 0x008996B4 File Offset: 0x008978B4
	protected unsafe override void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EC0C RID: 125964 RVA: 0x008996C2 File Offset: 0x008978C2
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EC0D RID: 125965 RVA: 0x008996CA File Offset: 0x008978CA
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(TsSimpleNpc.__ReceiveEndPlay_FunctionParams* __Params)
	{
		base.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601EC0E RID: 125966 RVA: 0x008996D8 File Offset: 0x008978D8
	protected override void __CPPCALL_LoadModel_Implementation()
	{
		base.LoadModel_Implementation();
	}

	// Token: 0x0601EC0F RID: 125967 RVA: 0x008996E0 File Offset: 0x008978E0
	protected unsafe override void __CPPCALL_DebugSetNpcDitherValue_Implementation(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* __Params)
	{
		base.DebugSetNpcDitherValue_Implementation(__Params->value);
	}

	// Token: 0x0601EC10 RID: 125968 RVA: 0x008996EE File Offset: 0x008978EE
	protected override void __CPPCALL_SetDefaultCollision_Implementation()
	{
		base.SetDefaultCollision_Implementation();
	}

	// Token: 0x0601EC11 RID: 125969 RVA: 0x008996F6 File Offset: 0x008978F6
	protected override void __CPPCALL_ResetMeshLocation_Implementation()
	{
		base.ResetMeshLocation_Implementation();
	}

	// Token: 0x0601EC12 RID: 125970 RVA: 0x008996FE File Offset: 0x008978FE
	protected override void __CPPCALL_FindFloor_Implementation()
	{
		base.FindFloor_Implementation();
	}

	// Token: 0x0601EC13 RID: 125971 RVA: 0x00899708 File Offset: 0x00897908
	protected unsafe override void __CPPCALL_ShowDialog_Implementation(TsSimpleNpc.__ShowDialog_FunctionParams* __Params)
	{
		string text = FString.ToString((void*)(&__Params->text));
		base.ShowDialog_Implementation(text, __Params->removeSeconds);
	}

	// Token: 0x0601EC14 RID: 125972 RVA: 0x0089972F File Offset: 0x0089792F
	protected override void __CPPCALL_HideDialog_Implementation()
	{
		base.HideDialog_Implementation();
	}

	// Token: 0x0601EC15 RID: 125973 RVA: 0x00899738 File Offset: 0x00897938
	protected unsafe override void __CPPCALL_TryPlayMontage_Implementation(TsSimpleNpc.__TryPlayMontage_FunctionParams* __Params)
	{
		string montagePath = FString.ToString((void*)(&__Params->montagePath));
		__Params->__Result = base.TryPlayMontage_Implementation(montagePath);
	}

	// Token: 0x0601EC16 RID: 125974 RVA: 0x0089975F File Offset: 0x0089795F
	protected override void __CPPCALL_StopMontage_Implementation()
	{
		base.StopMontage_Implementation();
	}
}
