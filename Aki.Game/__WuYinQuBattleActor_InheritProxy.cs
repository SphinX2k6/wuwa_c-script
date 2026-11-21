using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EE1 RID: 12001
public class __WuYinQuBattleActor_InheritProxy : WuYinQuBattleActor
{
	// Token: 0x0601C972 RID: 117106 RVA: 0x008BE7E4 File Offset: 0x008BC9E4
	[NullableContext(1)]
	public __WuYinQuBattleActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C973 RID: 117107 RVA: 0x008BE817 File Offset: 0x008BCA17
	protected __WuYinQuBattleActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C974 RID: 117108 RVA: 0x008BE820 File Offset: 0x008BCA20
	protected override void __CPPCALL_手动初始化_Implementation()
	{
		base.手动初始化_Implementation();
	}

	// Token: 0x0601C975 RID: 117109 RVA: 0x008BE828 File Offset: 0x008BCA28
	protected override void __CPPCALL_显示Debug线框_Implementation()
	{
		base.显示Debug线框_Implementation();
	}

	// Token: 0x0601C976 RID: 117110 RVA: 0x008BE830 File Offset: 0x008BCA30
	protected override void __CPPCALL_切换到清空状态_Implementation()
	{
		base.切换到清空状态_Implementation();
	}

	// Token: 0x0601C977 RID: 117111 RVA: 0x008BE838 File Offset: 0x008BCA38
	protected override void __CPPCALL_切换到静止状态_Implementation()
	{
		base.切换到静止状态_Implementation();
	}

	// Token: 0x0601C978 RID: 117112 RVA: 0x008BE840 File Offset: 0x008BCA40
	protected override void __CPPCALL_切换到战斗阶段1_Implementation()
	{
		base.切换到战斗阶段1_Implementation();
	}

	// Token: 0x0601C979 RID: 117113 RVA: 0x008BE848 File Offset: 0x008BCA48
	protected override void __CPPCALL_切换到战斗阶段2_Implementation()
	{
		base.切换到战斗阶段2_Implementation();
	}

	// Token: 0x0601C97A RID: 117114 RVA: 0x008BE850 File Offset: 0x008BCA50
	protected override void __CPPCALL_切换到战斗阶段3_Implementation()
	{
		base.切换到战斗阶段3_Implementation();
	}

	// Token: 0x0601C97B RID: 117115 RVA: 0x008BE858 File Offset: 0x008BCA58
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C97C RID: 117116 RVA: 0x008BE860 File Offset: 0x008BCA60
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
