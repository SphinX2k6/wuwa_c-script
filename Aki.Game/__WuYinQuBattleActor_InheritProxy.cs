using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003966 RID: 14694
public class __WuYinQuBattleActor_InheritProxy : WuYinQuBattleActor
{
	// Token: 0x0601ED05 RID: 126213 RVA: 0x0089C89C File Offset: 0x0089AA9C
	[NullableContext(1)]
	public __WuYinQuBattleActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED06 RID: 126214 RVA: 0x0089C8CF File Offset: 0x0089AACF
	protected __WuYinQuBattleActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED07 RID: 126215 RVA: 0x0089C8D8 File Offset: 0x0089AAD8
	protected override void __CPPCALL_手动初始化_Implementation()
	{
		base.手动初始化_Implementation();
	}

	// Token: 0x0601ED08 RID: 126216 RVA: 0x0089C8E0 File Offset: 0x0089AAE0
	protected override void __CPPCALL_显示Debug线框_Implementation()
	{
		base.显示Debug线框_Implementation();
	}

	// Token: 0x0601ED09 RID: 126217 RVA: 0x0089C8E8 File Offset: 0x0089AAE8
	protected override void __CPPCALL_切换到清空状态_Implementation()
	{
		base.切换到清空状态_Implementation();
	}

	// Token: 0x0601ED0A RID: 126218 RVA: 0x0089C8F0 File Offset: 0x0089AAF0
	protected override void __CPPCALL_切换到静止状态_Implementation()
	{
		base.切换到静止状态_Implementation();
	}

	// Token: 0x0601ED0B RID: 126219 RVA: 0x0089C8F8 File Offset: 0x0089AAF8
	protected override void __CPPCALL_切换到战斗阶段1_Implementation()
	{
		base.切换到战斗阶段1_Implementation();
	}

	// Token: 0x0601ED0C RID: 126220 RVA: 0x0089C900 File Offset: 0x0089AB00
	protected override void __CPPCALL_切换到战斗阶段2_Implementation()
	{
		base.切换到战斗阶段2_Implementation();
	}

	// Token: 0x0601ED0D RID: 126221 RVA: 0x0089C908 File Offset: 0x0089AB08
	protected override void __CPPCALL_切换到战斗阶段3_Implementation()
	{
		base.切换到战斗阶段3_Implementation();
	}

	// Token: 0x0601ED0E RID: 126222 RVA: 0x0089C910 File Offset: 0x0089AB10
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ED0F RID: 126223 RVA: 0x0089C918 File Offset: 0x0089AB18
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
