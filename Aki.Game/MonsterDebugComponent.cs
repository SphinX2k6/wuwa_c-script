using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020031CB RID: 12747
[NullableContext(1)]
[Nullable(0)]
public class MonsterDebugComponent : EntityComponent
{
	// Token: 0x0601B7B0 RID: 112560 RVA: 0x007871B8 File Offset: 0x007853B8
	protected override bool OnStart()
	{
		EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.MonsterDebug, new Action<int>(this.MonsterDebug));
		EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		return true;
	}

	// Token: 0x0601B7B1 RID: 112561 RVA: 0x00787223 File Offset: 0x00785423
	protected override void OnTick(float delta)
	{
		if (this.HasBeenHit && !this.MarkedDirty)
		{
			this.TimeCount += delta;
		}
	}

	// Token: 0x0601B7B2 RID: 112562 RVA: 0x00787244 File Offset: 0x00785444
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.MonsterDebug, new Action<int>(this.MonsterDebug));
		EventSystem.Instance.RemoveWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		this.DestroyTimer();
		return true;
	}

	// Token: 0x0601B7B3 RID: 112563 RVA: 0x007872B8 File Offset: 0x007854B8
	private void MonsterDebug(int attackerEntityId)
	{
		if (this.HasBeenHit)
		{
			return;
		}
		if (!base.Entity.Active)
		{
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		bool flag;
		if (instance == null)
		{
			flag = true;
		}
		else
		{
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			int? num;
			if (getCurrentEntity == null)
			{
				num = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				num = ((entity != null) ? new int?(entity.Id) : null);
			}
			int? num2 = num;
			flag = !(num2.GetValueOrDefault() == attackerEntityId & num2 != null);
		}
		if (flag)
		{
			return;
		}
		if (this.ShouldIgnoreOwnConcomitantDebug())
		{
			return;
		}
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			this.IsInFight = true;
		}
		this.SetTimer();
		this.HasBeenHit = true;
	}

	// Token: 0x0601B7B4 RID: 112564 RVA: 0x00787360 File Offset: 0x00785560
	private bool ShouldIgnoreOwnConcomitantDebug()
	{
		if (this.IsOwnConcomitantTarget != null)
		{
			return this.IsOwnConcomitantTarget.Value;
		}
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return false;
		}
		if (!component.IsConcomitantEntity)
		{
			this.IsOwnConcomitantTarget = new bool?(false);
			return this.IsOwnConcomitantTarget.Value;
		}
		CreatureModel instance = CreatureModel.Instance;
		if (instance == null)
		{
			return false;
		}
		this.IsOwnConcomitantTarget = new bool?(component.GetSummonerPlayerId() == instance.GetPlayerId());
		return this.IsOwnConcomitantTarget.Value;
	}

	// Token: 0x0601B7B5 RID: 112565 RVA: 0x007873E6 File Offset: 0x007855E6
	private void OnBeDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		this.HasBeenDamaged = true;
	}

	// Token: 0x0601B7B6 RID: 112566 RVA: 0x007873EF File Offset: 0x007855EF
	private unsafe void SetTimer()
	{
		this.Timer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
		{
			this.DestroyTimer();
			Entity entity = base.Entity;
			uint num = (entity != null) ? entity.GameBudgetManagedToken : 0U;
			if (this.TimeCount <= 100f)
			{
				this.MarkedDirty = true;
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity2 = base.Entity;
				string message = "怪物状态出问题了！不Tick！";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TimeCount", this.TimeCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DebugInfo", LogController.Instance.OutputDebugInfo(false));
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "location";
				Entity entity3 = base.Entity;
				object item2;
				if (entity3 == null)
				{
					item2 = null;
				}
				else
				{
					BaseActorComponent component = entity3.GetComponent<BaseActorComponent>();
					item2 = ((component != null) ? component.ActorLocationProxy : null);
				}
				ptr = new ValueTuple<string, object>(item, item2);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
				string item3 = "centerRoleLocation";
				AActor centerRole = GameBudgetInterfaceController.Instance.CenterRole;
				ptr2 = new ValueTuple<string, object>(item3, (centerRole != null) ? new FVector?(centerRole.K2_GetActorLocation()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("centerOffset", GameBudgetInterfaceController.Instance.GetCenterOffset());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("debugStr", (num != 0U) ? UKuroGameBudgetAllocatorCSharpInterface.GetGameBudgetDebugString(num) : null);
				instance.Error(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			if (!this.HasBeenDamaged)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
				Entity entity4 = base.Entity;
				string message2 = "怪物状态出问题了！没有伤害结算！";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("DebugInfo", LogController.Instance.OutputDebugInfo(false));
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item4 = "location";
				Entity entity5 = base.Entity;
				object item5;
				if (entity5 == null)
				{
					item5 = null;
				}
				else
				{
					BaseActorComponent component2 = entity5.GetComponent<BaseActorComponent>();
					item5 = ((component2 != null) ? component2.ActorLocationProxy : null);
				}
				ptr3 = new ValueTuple<string, object>(item4, item5);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
				string item6 = "centerRoleLocation";
				AActor centerRole2 = GameBudgetInterfaceController.Instance.CenterRole;
				ptr4 = new ValueTuple<string, object>(item6, (centerRole2 != null) ? new FVector?(centerRole2.K2_GetActorLocation()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("centerOffset", GameBudgetInterfaceController.Instance.GetCenterOffset());
				instance2.Error(flag2, entity4, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
			if (!this.IsInFight)
			{
				CombatLog instance3 = CombatLog.Instance;
				CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
				Entity entity6 = base.Entity;
				string message3 = "怪物状态出问题了！没有进入战斗状态！";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("TimeCount", this.TimeCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("DebugInfo", LogController.Instance.OutputDebugInfo(false));
				ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2);
				string item7 = "location";
				Entity entity7 = base.Entity;
				object item8;
				if (entity7 == null)
				{
					item8 = null;
				}
				else
				{
					BaseActorComponent component3 = entity7.GetComponent<BaseActorComponent>();
					item8 = ((component3 != null) ? component3.ActorLocationProxy : null);
				}
				ptr5 = new ValueTuple<string, object>(item7, item8);
				ref ValueTuple<string, object> ptr6 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3);
				string item9 = "centerRoleLocation";
				AActor centerRole3 = GameBudgetInterfaceController.Instance.CenterRole;
				ptr6 = new ValueTuple<string, object>(item9, (centerRole3 != null) ? new FVector?(centerRole3.K2_GetActorLocation()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("centerOffset", GameBudgetInterfaceController.Instance.GetCenterOffset());
				instance3.Error(flag3, entity6, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
			}
		}, 5000f, null, null, true, 1f);
	}

	// Token: 0x0601B7B7 RID: 112567 RVA: 0x0078741A File Offset: 0x0078561A
	private void DestroyTimer()
	{
		if (TimerSystem.FlowTimeInstance.Has(this.Timer))
		{
			TimerSystem.FlowTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0601B7B8 RID: 112568 RVA: 0x00787446 File Offset: 0x00785646
	private void OnBattleStateChanged(bool inFight)
	{
		if (inFight)
		{
			this.IsInFight = true;
		}
	}

	// Token: 0x0601B7B9 RID: 112569 RVA: 0x00787454 File Offset: 0x00785654
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterDebugComponent monsterDebugComponent = (MonsterDebugComponent)componentTemplate;
		if (base.CanResetComponentProperty("TimeCount"))
		{
			this.TimeCount = monsterDebugComponent.TimeCount;
		}
		if (base.CanResetComponentProperty("HasBeenHit"))
		{
			this.HasBeenHit = monsterDebugComponent.HasBeenHit;
		}
		if (base.CanResetComponentProperty("HasBeenDamaged"))
		{
			this.HasBeenDamaged = monsterDebugComponent.HasBeenDamaged;
		}
		if (base.CanResetComponentProperty("Timer"))
		{
			if (monsterDebugComponent.Timer == null)
			{
				this.Timer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.Timer), "Timer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MarkedDirty"))
		{
			this.MarkedDirty = monsterDebugComponent.MarkedDirty;
		}
		if (base.CanResetComponentProperty("IsInFight"))
		{
			this.IsInFight = monsterDebugComponent.IsInFight;
		}
		if (base.CanResetComponentProperty("IsOwnConcomitantTarget"))
		{
			this.IsOwnConcomitantTarget = monsterDebugComponent.IsOwnConcomitantTarget;
		}
		return true;
	}

	// Token: 0x0400D7A1 RID: 55201
	private const float DELAY_TIME = 5000f;

	// Token: 0x0400D7A2 RID: 55202
	private const float CHECK_TIME = 100f;

	// Token: 0x0400D7A3 RID: 55203
	private float TimeCount;

	// Token: 0x0400D7A4 RID: 55204
	private bool HasBeenHit;

	// Token: 0x0400D7A5 RID: 55205
	private bool HasBeenDamaged;

	// Token: 0x0400D7A6 RID: 55206
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x0400D7A7 RID: 55207
	private bool MarkedDirty;

	// Token: 0x0400D7A8 RID: 55208
	private bool IsInFight;

	// Token: 0x0400D7A9 RID: 55209
	private bool? IsOwnConcomitantTarget;
}
