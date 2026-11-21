using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026F3 RID: 9971
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Rebecca_BurstAttack : CodeSkillBase
{
	// Token: 0x06018F69 RID: 102249 RVA: 0x007985C6 File Offset: 0x007967C6
	public CodeSkill_Rebecca_BurstAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F6A RID: 102250 RVA: 0x007985E8 File Offset: 0x007967E8
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

	// Token: 0x06018F6B RID: 102251 RVA: 0x0079870C File Offset: 0x0079690C
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

	// Token: 0x06018F6C RID: 102252 RVA: 0x0079878C File Offset: 0x0079698C
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

	// Token: 0x06018F6D RID: 102253 RVA: 0x007988C0 File Offset: 0x00796AC0
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

	// Token: 0x06018F6E RID: 102254 RVA: 0x00798924 File Offset: 0x00796B24
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

	// Token: 0x06018F6F RID: 102255 RVA: 0x00798958 File Offset: 0x00796B58
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

	// Token: 0x06018F70 RID: 102256 RVA: 0x0079899A File Offset: 0x00796B9A
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

	// Token: 0x06018F71 RID: 102257 RVA: 0x007989C0 File Offset: 0x00796BC0
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

	// Token: 0x06018F72 RID: 102258 RVA: 0x00798A0C File Offset: 0x00796C0C
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

	// Token: 0x06018F73 RID: 102259 RVA: 0x00798A94 File Offset: 0x00796C94
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

	// Token: 0x06018F74 RID: 102260 RVA: 0x00798B30 File Offset: 0x00796D30
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

	// Token: 0x06018F75 RID: 102261 RVA: 0x00798BA4 File Offset: 0x00796DA4
	private void RemoveOnceGameplayEventListeners()
	{
		foreach (IGameplayEventTask gameplayEventTask in this.OnceEventTasks)
		{
			gameplayEventTask.EndTask();
		}
		this.OnceEventTasks.Clear();
	}

	// Token: 0x06018F76 RID: 102262 RVA: 0x00798C00 File Offset: 0x00796E00
	private void OnCreateBullet1Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308201003" : "1308201002");
	}

	// Token: 0x06018F77 RID: 102263 RVA: 0x00798C1C File Offset: 0x00796E1C
	private void OnCreateBullet2Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308202003" : "1308202002");
	}

	// Token: 0x06018F78 RID: 102264 RVA: 0x00798C38 File Offset: 0x00796E38
	private void OnCreateBullet3Event(int tagId, FGameplayEventData payload)
	{
		this.SpawnTargetedBullet(this.HasResonance3() ? "1308203003" : "1308203002");
	}

	// Token: 0x06018F79 RID: 102265 RVA: 0x00798C54 File Offset: 0x00796E54
	private void OnFinishEvent()
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill != null)
		{
			this.TryBeginFinishSkill(activeSkill);
		}
	}

	// Token: 0x06018F7A RID: 102266 RVA: 0x00798C74 File Offset: 0x00796E74
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

	// Token: 0x06018F7B RID: 102267 RVA: 0x00798D18 File Offset: 0x00796F18
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

	// Token: 0x06018F7C RID: 102268 RVA: 0x00798DA8 File Offset: 0x00796FA8
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

	// Token: 0x06018F7D RID: 102269 RVA: 0x00798E03 File Offset: 0x00797003
	private void EnterAiming()
	{
		CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			return;
		}
		component.EnterAimStatus(EAimViewState.Rebecca瞄准);
	}

	// Token: 0x06018F7E RID: 102270 RVA: 0x00798E1B File Offset: 0x0079701B
	private void ExitAiming()
	{
		CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			return;
		}
		component.ExitAimStatus();
	}

	// Token: 0x06018F7F RID: 102271 RVA: 0x00798E32 File Offset: 0x00797032
	private bool HasResonance3()
	{
		return this.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.共鸣链.共鸣3"]);
	}

	// Token: 0x06018F80 RID: 102272 RVA: 0x00798E49 File Offset: 0x00797049
	private bool HasTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		return component != null && component.HasTag(tagId);
	}

	// Token: 0x06018F81 RID: 102273 RVA: 0x00798E62 File Offset: 0x00797062
	private void AddTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.AddTag(new int?(tagId));
	}

	// Token: 0x06018F82 RID: 102274 RVA: 0x00798E7F File Offset: 0x0079707F
	private void RemoveTag(int tagId)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveTag(new int?(tagId));
	}

	// Token: 0x06018F83 RID: 102275 RVA: 0x00798EA0 File Offset: 0x007970A0
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

	// Token: 0x06018F84 RID: 102276 RVA: 0x00798F98 File Offset: 0x00797198
	private void RemoveBuff(long buffId, Skill skill)
	{
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveBuff(buffId, -1, "CodeSkill_Rebecca_BurstAttack.RemoveBuff", skill.CombatMessageId, null, null);
	}

	// Token: 0x06018F85 RID: 102277 RVA: 0x00798FD9 File Offset: 0x007971D9
	[NullableContext(2)]
	private void AddTimer(TimerHandle timer)
	{
		if (timer == null)
		{
			return;
		}
		this.Timers.Add(timer);
	}

	// Token: 0x06018F86 RID: 102278 RVA: 0x00798FEC File Offset: 0x007971EC
	private void ClearTimers()
	{
		foreach (TimerHandle handle in this.Timers)
		{
			TimerSystem.Instance.Remove(handle);
		}
		this.Timers.Clear();
	}

	// Token: 0x0400D956 RID: 55638
	private const int BURST_FINISH_SKILL_ID = 1308302;

	// Token: 0x0400D957 RID: 55639
	private const float DURATION = 9.5f;

	// Token: 0x0400D958 RID: 55640
	private const int INTERRUPT_PRIORITY = 9;

	// Token: 0x0400D959 RID: 55641
	private const int ENERGY_FINISH_THRESHOLD = 9000;

	// Token: 0x0400D95A RID: 55642
	private const long BUFF_STAGE_1 = 1308504001L;

	// Token: 0x0400D95B RID: 55643
	private const long BUFF_STAGE_2 = 1308504002L;

	// Token: 0x0400D95C RID: 55644
	private const long BUFF_STAGE_3 = 1308504003L;

	// Token: 0x0400D95D RID: 55645
	private const long BUFF_BURST_END = 1308301006L;

	// Token: 0x0400D95E RID: 55646
	private const string BULLET_EVENT_1_NORMAL = "1308201002";

	// Token: 0x0400D95F RID: 55647
	private const string BULLET_EVENT_1_RESONANCE_3 = "1308201003";

	// Token: 0x0400D960 RID: 55648
	private const string BULLET_EVENT_2_NORMAL = "1308202002";

	// Token: 0x0400D961 RID: 55649
	private const string BULLET_EVENT_2_RESONANCE_3 = "1308202003";

	// Token: 0x0400D962 RID: 55650
	private const string BULLET_EVENT_3_NORMAL = "1308203002";

	// Token: 0x0400D963 RID: 55651
	private const string BULLET_EVENT_3_RESONANCE_3 = "1308203003";

	// Token: 0x0400D964 RID: 55652
	private const float DELAY_STAGE_2_MS = 1000f;

	// Token: 0x0400D965 RID: 55653
	private const float DELAY_STAGE_3_MS = 1000f;

	// Token: 0x0400D966 RID: 55654
	private const float DELAY_NORMAL_FINISH_MS = 8500f;

	// Token: 0x0400D967 RID: 55655
	private const float DELAY_MOWING_FINISH_MS = 29000f;

	// Token: 0x0400D968 RID: 55656
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D969 RID: 55657
	private CodeSkill_Rebecca_BurstAttack.EBurstTickMode TickMode;

	// Token: 0x0400D96A RID: 55658
	private bool BurstFinishTriggered;

	// Token: 0x0400D96B RID: 55659
	private bool EventListenersActive;

	// Token: 0x0400D96C RID: 55660
	private readonly List<IGameplayEventTask> OnceEventTasks = new List<IGameplayEventTask>();

	// Token: 0x0400D96D RID: 55661
	[Nullable(2)]
	private ITagTask HorizontalCameraTask;

	// Token: 0x0400D96E RID: 55662
	private readonly List<TimerHandle> Timers = new List<TimerHandle>();

	// Token: 0x02008901 RID: 35073
	[NullableContext(0)]
	private enum EBurstTickMode
	{
		// Token: 0x0402BBE3 RID: 179171
		None,
		// Token: 0x0402BBE4 RID: 179172
		Normal,
		// Token: 0x0402BBE5 RID: 179173
		Mowing
	}
}
