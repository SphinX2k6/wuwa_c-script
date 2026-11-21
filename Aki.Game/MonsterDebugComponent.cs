using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200273A RID: 10042
[NullableContext(1)]
[Nullable(0)]
public class MonsterDebugComponent : EntityComponent
{
	// Token: 0x060192F3 RID: 103155 RVA: 0x007AF278 File Offset: 0x007AD478
	protected override bool OnStart()
	{
		EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.MonsterDebug, new Action<int>(this.MonsterDebug));
		EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		return true;
	}

	// Token: 0x060192F4 RID: 103156 RVA: 0x007AF2E3 File Offset: 0x007AD4E3
	protected override void OnTick(float delta)
	{
		if (this.HasBeenHit && !this.MarkedDirty)
		{
			this.TimeCount += delta;
		}
	}

	// Token: 0x060192F5 RID: 103157 RVA: 0x007AF304 File Offset: 0x007AD504
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.MonsterDebug, new Action<int>(this.MonsterDebug));
		EventSystem.Instance.RemoveWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		this.DestroyTimer();
		return true;
	}

	// Token: 0x060192F6 RID: 103158 RVA: 0x007AF378 File Offset: 0x007AD578
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

	// Token: 0x060192F7 RID: 103159 RVA: 0x007AF420 File Offset: 0x007AD620
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

	// Token: 0x060192F8 RID: 103160 RVA: 0x007AF4A6 File Offset: 0x007AD6A6
	private void OnBeDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		this.HasBeenDamaged = true;
	}

	// Token: 0x060192F9 RID: 103161 RVA: 0x007AF4AF File Offset: 0x007AD6AF
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

	// Token: 0x060192FA RID: 103162 RVA: 0x007AF4DA File Offset: 0x007AD6DA
	private void DestroyTimer()
	{
		if (TimerSystem.FlowTimeInstance.Has(this.Timer))
		{
			TimerSystem.FlowTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x060192FB RID: 103163 RVA: 0x007AF506 File Offset: 0x007AD706
	private void OnBattleStateChanged(bool inFight)
	{
		if (inFight)
		{
			this.IsInFight = true;
		}
	}

	// Token: 0x060192FC RID: 103164 RVA: 0x007AF514 File Offset: 0x007AD714
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterDebugComponent monsterDebugComponent = (MonsterDebugComponent)componentTemplate;
		this.TimeCount = monsterDebugComponent.TimeCount;
		this.HasBeenHit = monsterDebugComponent.HasBeenHit;
		this.HasBeenDamaged = monsterDebugComponent.HasBeenDamaged;
		if (monsterDebugComponent.Timer == null)
		{
			this.Timer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Timer), "Timer"))
		{
			return false;
		}
		this.MarkedDirty = monsterDebugComponent.MarkedDirty;
		this.IsInFight = monsterDebugComponent.IsInFight;
		this.IsOwnConcomitantTarget = monsterDebugComponent.IsOwnConcomitantTarget;
		return true;
	}

	// Token: 0x17002813 RID: 10259
	// (get) Token: 0x060192FD RID: 103165 RVA: 0x007AF5A7 File Offset: 0x007AD7A7
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002814 RID: 10260
	// (get) Token: 0x060192FE RID: 103166 RVA: 0x007AF5AA File Offset: 0x007AD7AA
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002815 RID: 10261
	// (get) Token: 0x060192FF RID: 103167 RVA: 0x007AF5AD File Offset: 0x007AD7AD
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DC28 RID: 56360
	private const float DELAY_TIME = 5000f;

	// Token: 0x0400DC29 RID: 56361
	private const float CHECK_TIME = 100f;

	// Token: 0x0400DC2A RID: 56362
	private float TimeCount;

	// Token: 0x0400DC2B RID: 56363
	private bool HasBeenHit;

	// Token: 0x0400DC2C RID: 56364
	private bool HasBeenDamaged;

	// Token: 0x0400DC2D RID: 56365
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x0400DC2E RID: 56366
	private bool MarkedDirty;

	// Token: 0x0400DC2F RID: 56367
	private bool IsInFight;

	// Token: 0x0400DC30 RID: 56368
	private bool? IsOwnConcomitantTarget;
}
