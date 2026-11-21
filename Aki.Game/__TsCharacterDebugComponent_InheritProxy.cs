using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E97 RID: 11927
public class __TsCharacterDebugComponent_InheritProxy : TsCharacterDebugComponent
{
	// Token: 0x0601C86C RID: 116844 RVA: 0x008BCEA4 File Offset: 0x008BB0A4
	[NullableContext(1)]
	public __TsCharacterDebugComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C86D RID: 116845 RVA: 0x008BCED7 File Offset: 0x008BB0D7
	protected __TsCharacterDebugComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C86E RID: 116846 RVA: 0x008BCEE0 File Offset: 0x008BB0E0
	protected unsafe override void __CPPCALL_SetMovementDebug_Implementation(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* __Params)
	{
		base.SetMovementDebug_Implementation(__Params->newDebug);
	}

	// Token: 0x0601C86F RID: 116847 RVA: 0x008BCEEE File Offset: 0x008BB0EE
	protected override void __CPPCALL_ChangeEnterClimbTrace_Implementation()
	{
		base.ChangeEnterClimbTrace_Implementation();
	}

	// Token: 0x0601C870 RID: 116848 RVA: 0x008BCEF6 File Offset: 0x008BB0F6
	protected override void __CPPCALL_ChangeVaultClimbTrace_Implementation()
	{
		base.ChangeVaultClimbTrace_Implementation();
	}

	// Token: 0x0601C871 RID: 116849 RVA: 0x008BCEFE File Offset: 0x008BB0FE
	protected override void __CPPCALL_ChangeUpArriveClimbTrace_Implementation()
	{
		base.ChangeUpArriveClimbTrace_Implementation();
	}

	// Token: 0x0601C872 RID: 116850 RVA: 0x008BCF06 File Offset: 0x008BB106
	protected override void __CPPCALL_ChangeClimbingTrace_Implementation()
	{
		base.ChangeClimbingTrace_Implementation();
	}

	// Token: 0x0601C873 RID: 116851 RVA: 0x008BCF0E File Offset: 0x008BB10E
	protected override void __CPPCALL_ChangeNoTop_Implementation()
	{
		base.ChangeNoTop_Implementation();
	}

	// Token: 0x0601C874 RID: 116852 RVA: 0x008BCF16 File Offset: 0x008BB116
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C875 RID: 116853 RVA: 0x008BCF1E File Offset: 0x008BB11E
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C876 RID: 116854 RVA: 0x008BCF2C File Offset: 0x008BB12C
	protected unsafe override void __CPPCALL_ActivateDebugSpeed_Implementation(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* __Params)
	{
		base.ActivateDebugSpeed_Implementation(__Params->activate);
	}

	// Token: 0x0601C877 RID: 116855 RVA: 0x008BCF3A File Offset: 0x008BB13A
	protected override void __CPPCALL_DebugDrawActivateArea_Implementation()
	{
		base.DebugDrawActivateArea_Implementation();
	}

	// Token: 0x0601C878 RID: 116856 RVA: 0x008BCF42 File Offset: 0x008BB142
	protected unsafe override void __CPPCALL_SetDebugRiseEnable_Implementation(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* __Params)
	{
		base.SetDebugRiseEnable_Implementation(__Params->enable);
	}

	// Token: 0x0601C879 RID: 116857 RVA: 0x008BCF50 File Offset: 0x008BB150
	protected override void __CPPCALL_DrawDebugPatrolPoints_Implementation()
	{
		base.DrawDebugPatrolPoints_Implementation();
	}

	// Token: 0x0601C87A RID: 116858 RVA: 0x008BCF58 File Offset: 0x008BB158
	protected override void __CPPCALL_DrawErrorNavigationPaths_Implementation()
	{
		base.DrawErrorNavigationPaths_Implementation();
	}
}
