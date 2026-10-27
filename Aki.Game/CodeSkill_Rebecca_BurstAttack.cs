using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003186 RID: 12678
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Rebecca_BurstAttack : CodeSkillBase
{
	// Token: 0x0601B464 RID: 111716 RVA: 0x00770C62 File Offset: 0x0076EE62
	public CodeSkill_Rebecca_BurstAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B465 RID: 111717 RVA: 0x00770C84 File Offset: 0x0076EE84
	public override void OnBegin(Skill skill)
	{
		this.ActiveSkill = skill;
		this.TickMode = CodeSkill_Rebecca_BurstAttack.EBurstTickMode.None;
		this.BurstFinishTriggered = false;
		this.ClearTimers();
		CameraBlueprintFunctionLibrary.ForceStopCameraModify(false);
		this.AddTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.屏蔽modify强制生效.丽贝卡专用"]);
		this.AddTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏状态功能.隐藏战斗UI仅允许战斗输入"]);
		this.AddBuff(1308504001L, skill);
		bool flag = this.HasTag(GameplayTagDefine.EGameplayTagId["关卡.副本.电玩割草.丽贝卡大招"]);
		if (!flag)
		{
			SkillUtils.BeginAbsoluteTimeStop(base.Entity.Id, 9.5f, true, 0f);
			SkillUtils.BeginTimeStopRequest(base.Entity.Id, 9.5f, 0f);
		}
		this.EnterAiming();
		this.AddTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.专属Special动作"]);
		this.AddTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.覆盖基础层动作"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身通用融合"]);
		this.AddTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射一阶"]);
		this.RegisterBulletEventListeners();
		if (flag)
		{
			this.StartMowingFlow();
			return;
		}
		this.StartNormalFlow();
	}

	// Token: 0x0601B466 RID: 111718 RVA: 0x00770DA8 File Offset: 0x0076EFA8
	public override void OnTick(float delta, Skill skill)
	{
		if (this.TickMode == CodeSkill_Rebecca_BurstAttack.EBurstTickMode.None)
		{
			return;
		}
		this.FaceToFightCameraYaw();
		if (this.TickMode == CodeSkill_Rebecca_BurstAttack.EBurstTickMode.Mowing)
		{
			if (this.HasTag(GameplayTagDefine.EGameplayTagId["关卡.副本.电玩割草.全部击杀"]))
			{
				this.TryBeginFinishSkill(skill);
			}
			return;
		}
		BaseAttributeComponent component = base.Entity.GetComponent<BaseAttributeComponent>();
		if (((component != null) ? new float?(component.GetCurrentValue(EAttributeType.SpecialEnergy3)) : null).GetValueOrDefault() >= 9000f)
		{
			this.TryBeginFinishSkill(skill);
		}
	}

	// Token: 0x0601B467 RID: 111719 RVA: 0x00770E28 File Offset: 0x0076F028
	public override void OnEnd(Skill skill)
	{
		this.TickMode = CodeSkill_Rebecca_BurstAttack.EBurstTickMode.None;
		this.RemoveBulletEventListeners();
		this.RemoveOnceGameplayEventListeners();
		ITagTask horizontalCameraTask = this.HorizontalCameraTask;
		if (horizontalCameraTask != null)
		{
			horizontalCameraTask.EndTask();
		}
		this.HorizontalCameraTask = null;
		this.ClearTimers();
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.屏蔽modify强制生效.丽贝卡专用"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏状态功能.隐藏战斗UI仅允许战斗输入"]);
		this.RemoveBuff(1308504001L, skill);
		this.RemoveBuff(1308504002L, skill);
		this.RemoveBuff(1308504003L, skill);
		SkillUtils.EndAbsoluteTimeStop(base.Entity.Id);
		SkillUtils.EndTimeStopRequest(base.Entity.Id);
		this.ExitAiming();
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.专属Special动作"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.覆盖基础层动作"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射一阶"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射二阶"]);
		this.RemoveTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射三阶"]);
		this.AddBuff(1308301006L, skill);
		this.ActiveSkill = null;
	}

	// Token: 0x0601B468 RID: 111720 RVA: 0x00770F5C File Offset: 0x0076F15C
	private void StartNormalFlow()
	{
		this.TickMode = CodeSkill_Rebecca_BurstAttack.EBurstTickMode.Normal;
		this.RegisterOnceGameplayEvent(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.终结一击"], new Action(this.OnFinishEvent));
		this.RegisterHorizontalCameraListener();
		this.AddTimer(TimerSystem.Instance.Delay(delegate(float _)
		{
			this.RegisterStage2Event(1000f);
			this.AddTimer(TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnFinishEvent();
			}, 8500f, null, null, true, 1f));
		}, 1000f, null, null, true, 1f));
	}

	// Token: 0x0601B469 RID: 111721 RVA: 0x00770FC0 File Offset: 0x0076F1C0
	private void StartMowingFlow()
	{
		this.TickMode = CodeSkill_Rebecca_BurstAttack.EBurstTickMode.Mowing;
		this.AddTimer(TimerSystem.Instance.Delay(delegate(float _)
		{
			this.RegisterStage2Event(1000f);
			this.AddTimer(TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnFinishEvent();
			}, 29000f, null, null, true, 1f));
		}, 1000f, null, null, true, 1f));
	}

	// Token: 0x0601B46A RID: 111722 RVA: 0x00770FF4 File Offset: 0x0076F1F4
	private void RegisterStage2Event(float delayToStage3Ms)
	{
		TTimerAction <>9__1;
		this.RegisterOnceGameplayEvent(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射二阶"], delegate
		{
			Skill activeSkill = this.ActiveSkill;
			if (activeSkill == null)
			{
				return;
			}
			this.AddTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射二阶"]);
			this.RemoveTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射一阶"]);
			this.AddBuff(1308504002L, activeSkill);
			this.RemoveBuff(1308504001L, activeSkill);
			CodeSkill_Rebecca_BurstAttack <>4__this = this;
			TimerSystemInstance instance = TimerSystem.Instance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					this.RegisterStage3Event();
				});
			}
			<>4__this.AddTimer(instance.Delay(action, delayToStage3Ms, null, null, true, 1f));
		});
	}

	// Token: 0x0601B46B RID: 111723 RVA: 0x00771036 File Offset: 0x0076F236
	private void RegisterStage3Event()
	{
		this.RegisterOnceGameplayEvent(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射三阶"], delegate
		{
			Skill activeSkill = this.ActiveSkill;
			if (activeSkill == null)
			{
				return;
			}
			this.AddTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射三阶"]);
			this.RemoveTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射二阶"]);
			this.AddBuff(1308504003L, activeSkill);
			this.RemoveBuff(1308504002L, activeSkill);
		});
	}

	// Token: 0x0601B46C RID: 111724 RVA: 0x0077105C File Offset: 0x0076F25C
	private void RegisterHorizontalCameraListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.HorizontalCameraTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.镜头.横版镜头"]), delegate(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				return;
			}
			ITagTask horizontalCameraTask = this.HorizontalCameraTask;
			if (horizontalCameraTask != null)
			{
				horizontalCameraTask.EndTask();
			}
			this.HorizontalCameraTask = null;
			this.OnFinishEvent();
		}, null) : null);
	}

	// Token: 0x0601B46D RID: 111725 RVA: 0x007710A8 File Offset: 0x0076F2A8
	private void RegisterBulletEventListeners()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹1"], new TGameplayEventCallback(this.OnCreateBullet1Event));
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹2"], new TGameplayEventCallback(this.OnCreateBullet2Event));
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹3"], new TGameplayEventCallback(this.OnCreateBullet3Event));
		this.EventListenersActive = true;
	}

	// Token: 0x0601B46E RID: 111726 RVA: 0x00771130 File Offset: 0x0076F330
	private void RemoveBulletEventListeners()
	{
		if (!this.EventListenersActive)
		{
			return;
		}
		this.EventListenersActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component != null)
		{
			component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹1"], new TGameplayEventCallback(this.OnCreateBullet1Event));
		}
		if (component != null)
		{
			component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹2"], new TGameplayEventCallback(this.OnCreateBullet2Event));
		}
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.大招GA指令.创建子弹3"], new TGameplayEventCallback(this.OnCreateBullet3Event));
	}

	// Token: 0x0601B46F RID: 111727 RVA: 0x007711CC File Offset: 0x0076F3CC
	private void RegisterOnceGameplayEvent(int tagId, Action callback)
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		IGameplayEventTask task = null;
		task = ((component != null) ? component.AddGameplayEventListenerOnce(new int?(tagId), delegate(int id, FGameplayEventData payload)
		{
			if (task == null)
			{
				return;
			}
			int num = this.OnceEventTasks.IndexOf(task);
			if (num >= 0)
			{
				this.OnceEventTasks.RemoveAt(num);
			}
			callback();
		}) : null);
		if (task != null)
		{
			this.OnceEventTasks.Add(task);
		}
	}

	// Token: 0x0601B470 RID: 111728 RVA: 0x00771240 File Offset: 0x0076F440
	private void RemoveOnceGameplayEventListeners()
	{
		foreach (IGameplayEventTask gameplayEventTask in this.OnceEventTasks)
		{
			gameplayEventTask.EndTask();
		}
		this.OnceEventTasks.Clear();
	}

	// Token: 0x0601B471 RID: 111729 RVA: 0x0077129C File Offset: 0x0076F49C
	private void OnCreateBullet1Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308201003" : "1308201002");
	}

	// Token: 0x0601B472 RID: 111730 RVA: 0x007712B8 File Offset: 0x0076F4B8
	private void OnCreateBullet2Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308202003" : "1308202002");
	}

	// Token: 0x0601B473 RID: 111731 RVA: 0x007712D4 File Offset: 0x0076F4D4
	private void OnCreateBullet3Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308203003" : "1308203002");
	}

	// Token: 0x0601B474 RID: 111732 RVA: 0x007712F0 File Offset: 0x0076F4F0
	private void OnFinishEvent()
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill != null)
		{
			this.TryBeginFinishSkill(activeSkill);
		}
	}

	// Token: 0x0601B475 RID: 111733 RVA: 0x00771310 File Offset: 0x0076F510
	private void TryBeginFinishSkill(Skill skill)
	{
		if (this.BurstFinishTriggered)
		{
			return;
		}
		this.BurstFinishTriggered = true;
		base.SkillComp.SetSkillPriority(skill.SkillId, 9);
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		WorldEntity worldEntity = (skillTarget != null) ? skillTarget.Entity : null;
		AActor aactor;
		if (worldEntity == null)
		{
			aactor = null;
		}
		else
		{
			BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
			aactor = ((component != null) ? component.Owner : null);
		}
		AActor targetActor = aactor;
		if (!base.SkillComp.BeginSkill(1308302, new SkillParam
		{
			TargetActor = targetActor,
			SocketName = base.SkillComp.SkillTargetSocket,
			Reason = "CodeSkill_Rebecca_BurstAttack"
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B476 RID: 111734 RVA: 0x007713B4 File Offset: 0x0076F5B4
	private void SpawnTargetedBullet(string bulletId)
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill != null)
		{
			EntityHandle skillTarget = base.SkillComp.SkillTarget;
			if (skillTarget != null && skillTarget.Valid)
			{
				long? skillContextId = BulletUtil.GetSkillContextId(base.Entity, activeSkill.SkillId);
				BulletController.Instance.CreateBulletCustomTarget(base.Entity, bulletId, null, new BulletController.BulletCreateParams
				{
					SkillId = activeSkill.SkillId,
					SkillContextId = skillContextId,
					SyncType = EBulletSyncType.SyncCreate,
					BattleContext = activeSkill.BattleContext
				}, skillContextId, global::EBulletCreateSource.Skill);
				return;
			}
		}
	}

	// Token: 0x0601B477 RID: 111735 RVA: 0x00771444 File Offset: 0x0076F644
	private void FaceToFightCameraYaw()
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		FRotator frotator = component.ActorForwardProxy.ToUeVector(false).Rotation();
		FRotator fightCameraRotation = CameraBlueprintFunctionLibrary.GetFightCameraRotation();
		component.SetActorRotation(new FRotator(0f, fightCameraRotation.Yaw, frotator.Roll), "CodeSkill_Rebecca_BurstAttack.FaceToFightCameraYaw", false);
	}

	// Token: 0x0601B478 RID: 111736 RVA: 0x0077149F File Offset: 0x0076F69F
	private void EnterAiming()
	{
		CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			return;
		}
		component.EnterAimStatus(EAimViewState.Rebecca瞄准);
	}

	// Token: 0x0601B479 RID: 111737 RVA: 0x007714B7 File Offset: 0x0076F6B7
	private void ExitAiming()
	{
		CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			return;
		}
		component.ExitAimStatus();
	}

	// Token: 0x0601B47A RID: 111738 RVA: 0x007714CE File Offset: 0x0076F6CE
	private bool HasResonance3()
	{
		return this.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.共鸣链.共鸣3"]);
	}

	// Token: 0x0601B47B RID: 111739 RVA: 0x007714E5 File Offset: 0x0076F6E5
	private bool HasTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		return component != null && component.HasTag(tagId);
	}

	// Token: 0x0601B47C RID: 111740 RVA: 0x007714FE File Offset: 0x0076F6FE
	private void AddTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.AddTag(new int?(tagId));
	}

	// Token: 0x0601B47D RID: 111741 RVA: 0x0077151B File Offset: 0x0076F71B
	private void RemoveTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveTag(new int?(tagId));
	}

	// Token: 0x0601B47E RID: 111742 RVA: 0x0077153C File Offset: 0x0076F73C
	private void AddBuff(long buffId, Skill skill)
	{
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
		if (component != null && num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				BaseBuffComponent baseBuffComponent = component;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = num.Value;
				addBuffParam.OuterStackCount = new int?(1);
				addBuffParam.PreMessageId = skill.CombatMessageId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(skill.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("GA");
				UClass abilityClass = skill.AbilityClass;
				defaultInterpolatedStringHandler.AppendFormatted((abilityClass != null) ? abilityClass.GetName() : null);
				defaultInterpolatedStringHandler.AppendLiteral("的buff添加");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				baseBuffComponent.AddBuff(buffId, addBuffParam);
				return;
			}
		}
	}

	// Token: 0x0601B47F RID: 111743 RVA: 0x00771634 File Offset: 0x0076F834
	private void RemoveBuff(long buffId, Skill skill)
	{
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveBuff(buffId, -1, "CodeSkill_Rebecca_BurstAttack.RemoveBuff", skill.CombatMessageId, null, null);
	}

	// Token: 0x0601B480 RID: 111744 RVA: 0x00771675 File Offset: 0x0076F875
	[NullableContext(2)]
	private void AddTimer(TimerHandle timer)
	{
		if (timer == null)
		{
			return;
		}
		this.Timers.Add(timer);
	}

	// Token: 0x0601B481 RID: 111745 RVA: 0x00771688 File Offset: 0x0076F888
	private void ClearTimers()
	{
		foreach (TimerHandle handle in this.Timers)
		{
			TimerSystem.Instance.Remove(handle);
		}
		this.Timers.Clear();
	}

	// Token: 0x0400D4F3 RID: 54515
	private const int BURST_FINISH_SKILL_ID = 1308302;

	// Token: 0x0400D4F4 RID: 54516
	private const float DURATION = 9.5f;

	// Token: 0x0400D4F5 RID: 54517
	private const int INTERRUPT_PRIORITY = 9;

	// Token: 0x0400D4F6 RID: 54518
	private const int ENERGY_FINISH_THRESHOLD = 9000;

	// Token: 0x0400D4F7 RID: 54519
	private const long BUFF_STAGE_1 = 1308504001L;

	// Token: 0x0400D4F8 RID: 54520
	private const long BUFF_STAGE_2 = 1308504002L;

	// Token: 0x0400D4F9 RID: 54521
	private const long BUFF_STAGE_3 = 1308504003L;

	// Token: 0x0400D4FA RID: 54522
	private const long BUFF_BURST_END = 1308301006L;

	// Token: 0x0400D4FB RID: 54523
	private const string BULLET_EVENT_1_NORMAL = "1308201002";

	// Token: 0x0400D4FC RID: 54524
	private const string BULLET_EVENT_1_RESONANCE_3 = "1308201003";

	// Token: 0x0400D4FD RID: 54525
	private const string BULLET_EVENT_2_NORMAL = "1308202002";

	// Token: 0x0400D4FE RID: 54526
	private const string BULLET_EVENT_2_RESONANCE_3 = "1308202003";

	// Token: 0x0400D4FF RID: 54527
	private const string BULLET_EVENT_3_NORMAL = "1308203002";

	// Token: 0x0400D500 RID: 54528
	private const string BULLET_EVENT_3_RESONANCE_3 = "1308203003";

	// Token: 0x0400D501 RID: 54529
	private const float DELAY_STAGE_2_MS = 1000f;

	// Token: 0x0400D502 RID: 54530
	private const float DELAY_STAGE_3_MS = 1000f;

	// Token: 0x0400D503 RID: 54531
	private const float DELAY_NORMAL_FINISH_MS = 8500f;

	// Token: 0x0400D504 RID: 54532
	private const float DELAY_MOWING_FINISH_MS = 29000f;

	// Token: 0x0400D505 RID: 54533
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D506 RID: 54534
	private CodeSkill_Rebecca_BurstAttack.EBurstTickMode TickMode;

	// Token: 0x0400D507 RID: 54535
	private bool BurstFinishTriggered;

	// Token: 0x0400D508 RID: 54536
	private bool EventListenersActive;

	// Token: 0x0400D509 RID: 54537
	private readonly List<IGameplayEventTask> OnceEventTasks = new List<IGameplayEventTask>();

	// Token: 0x0400D50A RID: 54538
	[Nullable(2)]
	private ITagTask HorizontalCameraTask;

	// Token: 0x0400D50B RID: 54539
	private readonly List<TimerHandle> Timers = new List<TimerHandle>();

	// Token: 0x020096DB RID: 38619
	[NullableContext(0)]
	private enum EBurstTickMode
	{
		// Token: 0x0403054E RID: 197966
		None,
		// Token: 0x0403054F RID: 197967
		Normal,
		// Token: 0x04030550 RID: 197968
		Mowing
	}
}
