using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002DC3 RID: 11715
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class BulletController : ControllerBase
{
	// Token: 0x060189B2 RID: 100786 RVA: 0x00649A88 File Offset: 0x00647C88
	protected override bool OnInit()
	{
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			BulletConstant.Instance.OpenCreateLog = true;
			BulletConstant.Instance.OpenActionStat = true;
		}
		BulletActionRunner.InitStat();
		BulletSpecialActionDeclare.RegisterAll();
		if (this.ActionRunner == null)
		{
			this.ActionRunner = new BulletActionRunner();
		}
		this.ActionRunner.Init();
		BulletPool.Init();
		this.SystemList.Clear();
		this.SystemList.Add(new BulletMoveSystem());
		this.SystemList.Add(new BulletCollisionSystem());
		this.OnAddEvents();
		return true;
	}

	// Token: 0x060189B3 RID: 100787 RVA: 0x00649B18 File Offset: 0x00647D18
	protected override void OnTick(float delta)
	{
		if (this.ActionRunner == null)
		{
			return;
		}
		this.ActionRunner.Pause();
		foreach (BulletSystemBase bulletSystemBase in this.SystemList)
		{
			bulletSystemBase.OnTick(delta);
		}
		this.ActionRunner.Resume();
		this.ActionRunner.Run(delta, false);
		BulletConfig.Instance.TickPreload();
	}

	// Token: 0x060189B4 RID: 100788 RVA: 0x00649BA0 File Offset: 0x00647DA0
	protected override void OnAfterTick(float delta)
	{
		BulletModel.Instance.ProcessKuroBulletPendingOperation();
		if (this.SystemList == null || this.ActionRunner == null)
		{
			return;
		}
		this.ActionRunner.Pause();
		foreach (BulletSystemBase bulletSystemBase in this.SystemList)
		{
			bulletSystemBase.OnAfterTick(delta);
		}
		this.ActionRunner.Resume();
		this.ActionRunner.Run(delta, true);
		BulletPool.CheckAtFrameEnd();
	}

	// Token: 0x060189B5 RID: 100789 RVA: 0x00649C34 File Offset: 0x00647E34
	protected override bool OnClear()
	{
		this.ActionRunner.Clear();
		this.OnRemoveEvents();
		BulletPool.Clear();
		this.SystemList.Clear();
		return true;
	}

	// Token: 0x060189B6 RID: 100790 RVA: 0x00649C58 File Offset: 0x00647E58
	protected override bool OnLeaveLevel()
	{
		BulletConfig.Instance.ClearBulletDataCache();
		BulletConfig.Instance.ClearPreload();
		return true;
	}

	// Token: 0x060189B7 RID: 100791 RVA: 0x00649C6F File Offset: 0x00647E6F
	public BulletActionCenter GetActionCenter()
	{
		return this.ActionRunner.GetActionCenter();
	}

	// Token: 0x060189B8 RID: 100792 RVA: 0x00649C7C File Offset: 0x00647E7C
	public BulletActionRunner GetActionRunner()
	{
		return this.ActionRunner;
	}

	// Token: 0x060189B9 RID: 100793 RVA: 0x00649C84 File Offset: 0x00647E84
	private void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add(EEventName.SetNiagaraQuality, new Action(this.OnSetNiagaraQuality));
	}

	// Token: 0x060189BA RID: 100794 RVA: 0x00649CE4 File Offset: 0x00647EE4
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Remove(EEventName.SetNiagaraQuality, new Action(this.OnSetNiagaraQuality));
	}

	// Token: 0x060189BB RID: 100795 RVA: 0x00649D44 File Offset: 0x00647F44
	private void OnSkillEnd(int entityId, int skillId)
	{
		if (skillId == 0)
		{
			return;
		}
		IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(entityId);
		if (bulletSetByAttacker == null)
		{
			return;
		}
		List<BulletEntity> list = new List<BulletEntity>();
		foreach (BulletEntity bulletEntity in bulletSetByAttacker)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			if (skillId == bulletInfo.BulletInitParams.SkillId)
			{
				BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
				if (bulletDataMain.Move.IsDetachOnSkillEnd)
				{
					bulletInfo.Actor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
				if (bulletDataMain.Base.DestroyOnSkillEnd)
				{
					list.Add(bulletEntity);
				}
			}
		}
		foreach (BulletEntity bulletEntity2 in list)
		{
			bulletEntity2.GetBulletInfo().IsDestroyByCharSkillEnd = true;
			this.DestroyBullet(bulletEntity2.Id, false, EBulletDestroyReason.Normal, false);
		}
	}

	// Token: 0x060189BC RID: 100796 RVA: 0x00649E44 File Offset: 0x00648044
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		BulletConfig.Instance.RemoveCacheBulletDataByEntityId(handle.Id);
	}

	// Token: 0x060189BD RID: 100797 RVA: 0x00649E58 File Offset: 0x00648058
	private void OnSetNiagaraQuality()
	{
		foreach (BulletEntity bulletEntity in BulletModel.Instance.GetBulletEntityMap().Values)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			if (!bulletInfo.NeedDestroy)
			{
				BulletStaticFunction.UpdateEffectQualityLevel(bulletInfo);
			}
		}
	}

	// Token: 0x060189BE RID: 100798 RVA: 0x00649EC0 File Offset: 0x006480C0
	[NullableContext(2)]
	public bool HasAuthority(Entity owner)
	{
		object obj;
		if (owner == null)
		{
			obj = null;
		}
		else
		{
			BaseActorComponent component = owner.GetComponent<BaseActorComponent>();
			obj = ((component != null) ? component.Owner : null);
		}
		object obj2 = obj;
		return obj2 != null && obj2.IsAutonomousProxy();
	}

	// Token: 0x060189BF RID: 100799 RVA: 0x00649EE5 File Offset: 0x006480E5
	[NullableContext(2)]
	public bool HasAuthority(TsBaseCharacter owner)
	{
		return owner != null && owner.IsAutonomousProxy();
	}

	// Token: 0x060189C0 RID: 100800 RVA: 0x00649EF2 File Offset: 0x006480F2
	private void CreateBulletStatStart(string bulletRowName)
	{
	}

	// Token: 0x060189C1 RID: 100801 RVA: 0x00649EF4 File Offset: 0x006480F4
	private void CreateBulletStatSop(string bulletRowName)
	{
	}

	// Token: 0x060189C2 RID: 100802 RVA: 0x00649EF6 File Offset: 0x006480F6
	[return: Nullable(2)]
	public BulletEntity CreateBulletCustomTarget([Nullable(2)] Entity owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams = null, long? contextId = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		return this.CreateBulletCustomTargetInternal(owner, bulletRowName, initialTransform, bulletCreateParams, contextId, createSource);
	}

	// Token: 0x060189C3 RID: 100803 RVA: 0x00649F08 File Offset: 0x00648108
	[return: Nullable(2)]
	public BulletEntity CreateBulletCustomTarget([Nullable(2)] TsBaseCharacter owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams = null, long? contextId = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		Entity owner2 = (owner != null) ? owner.GetEntityNoBlueprint() : null;
		return this.CreateBulletCustomTargetInternal(owner2, bulletRowName, initialTransform, bulletCreateParams, contextId, createSource);
	}

	// Token: 0x060189C4 RID: 100804 RVA: 0x00649F34 File Offset: 0x00648134
	[return: Nullable(2)]
	private unsafe BulletEntity CreateBulletCustomTargetInternal([Nullable(2)] Entity owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams, long? contextId, global::EBulletCreateSource createSource)
	{
		if (bulletCreateParams == null)
		{
			bulletCreateParams = new BulletController.BulletCreateParams();
		}
		if (!GameModeModel.Instance.WorldDone)
		{
			return null;
		}
		this.CreateBulletStatStart(bulletRowName);
		if (owner == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "创建子弹时Owner为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rowName", bulletRowName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (contextId == null && !SpecialIgnoreBullet.CheckBulletInSpecialList(bulletRowName))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Bullet;
			Entity entity = null;
			string message2 = "创建子弹时contextId为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("rowName", bulletRowName);
			instance2.Error(flag, entity, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.CreateBulletStatSop(bulletRowName);
			return null;
		}
		BulletDataMain bulletData = BulletConfig.Instance.GetBulletData(owner, bulletRowName, true);
		if (bulletData == null)
		{
			this.CreateBulletStatSop(bulletRowName);
			return null;
		}
		if (createSource == global::EBulletCreateSource.Skill && bulletData.Base.DestroyOnSkillEnd)
		{
			BaseSkillComponent component = owner.GetComponent<BaseSkillComponent>();
			if (component == null || !component.Valid)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.Bullet;
				ELogAuthor author2 = ELogAuthor.HCW;
				string message3 = "勾选了技能结束是否销毁子弹, 技能组件不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bulletRowName", bulletRowName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", bulletCreateParams.SkillId);
				instance3.Error(module2, author2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CreateBulletStatSop(bulletRowName);
				return null;
			}
			Skill skill = component.GetSkill(bulletCreateParams.SkillId);
			if (skill == null || !skill.Active)
			{
				bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
				this.CreateBulletStatSop(bulletRowName);
				return null;
			}
		}
		global::EBulletSyncType ebulletSyncType = this.ModSyncType(bulletCreateParams.SyncType, bulletData);
		if (bulletCreateParams.CreateOnAuthority && ebulletSyncType == global::EBulletSyncType.SyncCreate && !this.HasAuthority(owner))
		{
			bool openCreateLog2 = BulletConstant.Instance.OpenCreateLog;
			this.CreateBulletStatSop(bulletRowName);
			return null;
		}
		int valueOrDefault = bulletCreateParams.ParentVictimId.GetValueOrDefault();
		int valueOrDefault2 = bulletCreateParams.ParentTargetId.GetValueOrDefault();
		int targetId = this.GetTargetId(owner, bulletData, bulletRowName, valueOrDefault, valueOrDefault2, bulletCreateParams.ParentId);
		int baseVelocityId = this.GetBaseVelocityId(owner, bulletData, bulletRowName, valueOrDefault, valueOrDefault2, bulletCreateParams.ParentId);
		int baseTransformId = this.GetBaseTransformId(owner, bulletData, bulletRowName, valueOrDefault, valueOrDefault2);
		bulletCreateParams.SyncType = ebulletSyncType;
		bulletCreateParams.BulletData = bulletData;
		bulletCreateParams.TargetId = new int?(targetId);
		bulletCreateParams.BaseTransformId = new int?(baseTransformId);
		bulletCreateParams.BaseVelocityId = new int?(baseVelocityId);
		BulletEntity result = this.CreateBullet(owner, bulletRowName, initialTransform, bulletCreateParams, contextId, createSource);
		this.CreateBulletStatSop(bulletRowName);
		return result;
	}

	// Token: 0x060189C5 RID: 100805 RVA: 0x0064A190 File Offset: 0x00648390
	private int GetBaseTransformId(Entity ownerEntity, BulletDataMain data, string bulletRowName, int parentVictimId, int parentTargetId)
	{
		EPositionStandard bornPositionStandard = data.Base.BornPositionStandard;
		if (EPositionStandard.技能目标位置 == bornPositionStandard)
		{
			return this.FindSkillTarget(ownerEntity, bulletRowName);
		}
		if (EPositionStandard.自定义目标 == bornPositionStandard)
		{
			return BulletModel.Instance.GetEntityIdByCustomKey(ownerEntity.Id, data.Base.BlackboardKey, bulletRowName);
		}
		if (EPositionStandard.父子弹受击者 == bornPositionStandard)
		{
			return parentVictimId;
		}
		if (EPositionStandard.父子弹目标 == bornPositionStandard)
		{
			return parentTargetId;
		}
		if (EPositionStandard.伴生物 == bornPositionStandard || EPositionStandard.伴生物位置和朝向 == bornPositionStandard)
		{
			int pos = int.Parse(data.Base.BlackboardKey);
			return this.GetCustomEntityId(ownerEntity, pos, bulletRowName);
		}
		if (EPositionStandard.攻击者锁定目标位置 == bornPositionStandard)
		{
			CharacterLockOnComponent component = ownerEntity.GetComponent<CharacterLockOnComponent>();
			EntityHandle entityHandle = (component != null) ? component.GetCurrentTarget() : null;
			if (entityHandle != null && entityHandle.Valid)
			{
				return entityHandle.Id;
			}
		}
		else if (EPositionStandard.前台角色锁定目标 == bornPositionStandard)
		{
			return this.GetCurrentRoleLockOn();
		}
		return 0;
	}

	// Token: 0x060189C6 RID: 100806 RVA: 0x0064A240 File Offset: 0x00648440
	[NullableContext(2)]
	private global::EBulletSyncType ModSyncType(global::EBulletSyncType syncType, BulletDataMain data)
	{
		if (GameModeModel.Instance.IsMulti && syncType == global::EBulletSyncType.Local)
		{
			if (data.Base.SyncType == EBulletSyncTypeTs.Remote)
			{
				return global::EBulletSyncType.SyncCreate;
			}
			EPositionStandard bornPositionStandard = data.Base.BornPositionStandard;
			if (bornPositionStandard == EPositionStandard.攻击者锁定目标位置 || bornPositionStandard == EPositionStandard.前台角色锁定目标 || bornPositionStandard == EPositionStandard.伴生物)
			{
				return global::EBulletSyncType.SyncCreate;
			}
			EInitialVelocityDirection initVelocityDirStandard = data.Move.InitVelocityDirStandard;
			if (initVelocityDirStandard == EInitialVelocityDirection.前台角色锁定目标 || initVelocityDirStandard == EInitialVelocityDirection.面向发射者锁定目标)
			{
				return global::EBulletSyncType.SyncCreate;
			}
			EBulletTarget trackTarget = data.Move.TrackTarget;
			if (trackTarget == EBulletTarget.攻击者锁定目标静态 || trackTarget == EBulletTarget.攻击者锁定目标动态)
			{
				return global::EBulletSyncType.SyncCreate;
			}
			BulletDataExecution execution = data.Execution;
			execution.InitGbGroup();
			if (execution.HasRebound)
			{
				return global::EBulletSyncType.SyncCreate;
			}
			if (execution.HasCollision)
			{
				return global::EBulletSyncType.SyncCreate;
			}
		}
		return syncType;
	}

	// Token: 0x060189C7 RID: 100807 RVA: 0x0064A2D8 File Offset: 0x006484D8
	public int CreateBulletForDebug(TsBaseCharacter owner, string bulletRowName)
	{
		Entity entityNoBlueprint = owner.GetEntityNoBlueprint();
		int entityId = (entityNoBlueprint != null) ? entityNoBlueprint.Id : 0;
		long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
		ChatRequest chatRequest = new ChatRequest();
		chatRequest.ChannelId = 0;
		ChatRequest chatRequest2 = chatRequest;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
		defaultInterpolatedStringHandler.AppendLiteral("@gmcreatebullet ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(creatureDataId);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted(bulletRowName);
		chatRequest2.Content = defaultInterpolatedStringHandler.ToStringAndClear();
		Net.Instance.Call(ERequestMessageId.ChatRequest, chatRequest, delegate(IMessage response, Net.CallbackStatus status)
		{
		}, 0);
		return 0;
	}

	// Token: 0x060189C8 RID: 100808 RVA: 0x0064A384 File Offset: 0x00648584
	private int GetTargetId(Entity owner, BulletDataMain data, string bulletRowName, int parentVictimId, int parentTargetId, int parentId)
	{
		EBulletTarget trackTarget = data.Move.TrackTarget;
		if (trackTarget == EBulletTarget.攻击者锁定目标静态 || trackTarget == EBulletTarget.攻击者锁定目标动态)
		{
			CharacterLockOnComponent component = owner.GetComponent<CharacterLockOnComponent>();
			EntityHandle entityHandle = (component != null) ? component.GetCurrentTarget() : null;
			if (entityHandle != null && entityHandle.Valid)
			{
				return entityHandle.Id;
			}
		}
		else
		{
			if (trackTarget == EBulletTarget.自定义目标)
			{
				return BulletModel.Instance.GetEntityIdByCustomKey(owner.Id, data.Move.TrackTargetBlackboardKey, bulletRowName);
			}
			if (trackTarget == EBulletTarget.父子弹受击者)
			{
				if (parentVictimId != 0)
				{
					return parentVictimId;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "父子弹受击者 VictimId为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rowName", bulletRowName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else if (trackTarget == EBulletTarget.父子弹目标)
			{
				if (parentTargetId != 0)
				{
					return parentTargetId;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Bullet;
				ELogAuthor author2 = ELogAuthor.HCW;
				string message2 = "父子弹目标为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("rowName", bulletRowName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			else if (trackTarget == EBulletTarget.父子弹位置)
			{
				if (parentId != 0)
				{
					return parentId;
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Bullet;
				ELogAuthor author3 = ELogAuthor.HCW;
				string message3 = "父子弹位置 ParentId为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("rowName", bulletRowName);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			else
			{
				if (trackTarget == EBulletTarget.子弹发射者)
				{
					return owner.Id;
				}
				if (trackTarget == EBulletTarget.技能目标 || trackTarget == EBulletTarget.技能目标前台)
				{
					return this.FindSkillTarget(owner, bulletRowName);
				}
				if (trackTarget == EBulletTarget.队伍角色)
				{
					if (!GameModeModel.Instance.IsMulti)
					{
						return Global.BaseCharacter.GetEntityIdNoBlueprint();
					}
					CreatureDataComponent component2 = owner.GetComponent<CreatureDataComponent>();
					EntityHandle entityHandle2 = SceneTeamModel.Instance.GetTeamItem((long)component2.GetPlayerId(), new GetTeamItemOptions
					{
						ParamType = ETeamParamType.PlayerId,
						IsControl = new bool?(true)
					}).EntityHandle;
					if (entityHandle2 != null && entityHandle2.Valid)
					{
						return entityHandle2.Id;
					}
				}
				else if (trackTarget == EBulletTarget.前台角色锁定目标)
				{
					return this.GetCurrentRoleLockOn();
				}
			}
		}
		return 0;
	}

	// Token: 0x060189C9 RID: 100809 RVA: 0x0064A530 File Offset: 0x00648730
	private int FindSkillTarget(Entity owner, string rowName)
	{
		BaseSkillComponent component = owner.GetComponent<BaseSkillComponent>();
		EntityHandle entityHandle = (component != null) ? component.SkillTarget : null;
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		if (entityHandle != null && entityHandle.Valid)
		{
			return entityHandle.Id;
		}
		return 0;
	}

	// Token: 0x060189CA RID: 100810 RVA: 0x0064A570 File Offset: 0x00648770
	private int GetCurrentRoleLockOn()
	{
		CharacterLockOnComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterLockOnComponent>();
		EntityHandle entityHandle = (component != null) ? component.GetCurrentTarget() : null;
		if (entityHandle != null && entityHandle.Valid)
		{
			return entityHandle.Id;
		}
		return 0;
	}

	// Token: 0x060189CB RID: 100811 RVA: 0x0064A5B4 File Offset: 0x006487B4
	private int GetBaseVelocityId(Entity owner, BulletDataMain data, string bulletRowName, int parentVictim, int parentTarget, int parentId)
	{
		EInitialVelocityDirection initVelocityDirStandard = data.Move.InitVelocityDirStandard;
		if (initVelocityDirStandard == EInitialVelocityDirection.面向发射者锁定目标)
		{
			CharacterLockOnComponent component = owner.GetComponent<CharacterLockOnComponent>();
			EntityHandle entityHandle = (component != null) ? component.GetCurrentTarget() : null;
			if (entityHandle != null && entityHandle.Valid)
			{
				return entityHandle.Id;
			}
		}
		else
		{
			if (initVelocityDirStandard == EInitialVelocityDirection.面向自定义目标)
			{
				return BulletModel.Instance.GetEntityIdByCustomKey(owner.Id, data.Move.InitVelocityDirParam, bulletRowName);
			}
			if (initVelocityDirStandard == EInitialVelocityDirection.伴生物 || initVelocityDirStandard == EInitialVelocityDirection.伴生物朝向)
			{
				int pos = int.Parse(data.Move.InitVelocityDirParam);
				return this.GetCustomEntityId(owner, pos, bulletRowName);
			}
			if (initVelocityDirStandard == EInitialVelocityDirection.前台角色锁定目标)
			{
				return this.GetCurrentRoleLockOn();
			}
			if (initVelocityDirStandard == EInitialVelocityDirection.父子弹受击者)
			{
				return parentVictim;
			}
			if (initVelocityDirStandard == EInitialVelocityDirection.父子弹目标)
			{
				return parentTarget;
			}
			if (initVelocityDirStandard == EInitialVelocityDirection.面向父子弹位置)
			{
				if (parentId != 0)
				{
					return parentId;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "面向父子弹位置 ParentId为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rowName", bulletRowName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return 0;
	}

	// Token: 0x060189CC RID: 100812 RVA: 0x0064A694 File Offset: 0x00648894
	[return: Nullable(2)]
	private BulletEntity CreateBullet(Entity owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams, long? contextId = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		bool fromRemote = bulletCreateParams.SyncType == global::EBulletSyncType.SyncFromRemote;
		BulletEntity bulletEntity = BulletModel.Instance.CreateBullet(owner, bulletRowName, initialTransform, bulletCreateParams.InitTargetLocation, bulletCreateParams.SkillId, new int?(bulletCreateParams.ParentId), fromRemote, bulletCreateParams.TargetId.GetValueOrDefault(), bulletCreateParams.BaseTransformId, bulletCreateParams.BaseVelocityId, bulletCreateParams.Size, bulletCreateParams.BulletData, bulletCreateParams.SyncType, contextId, bulletCreateParams.SkillContextId, bulletCreateParams.Source, bulletCreateParams.LocationOffset, bulletCreateParams.BeginRotatorOffset, bulletCreateParams.RandomPosOffset, bulletCreateParams.RandomInitSpeedOffset, bulletCreateParams.BattleContext, bulletCreateParams.ParentIds, createSource);
		if (bulletEntity == null || !bulletEntity.Valid)
		{
			return null;
		}
		return bulletEntity;
	}

	// Token: 0x060189CD RID: 100813 RVA: 0x0064A754 File Offset: 0x00648954
	public void DestroyBullet(int id, bool summonChild, EBulletDestroyReason destroyReason = EBulletDestroyReason.Normal, bool destroyEffectImmediately = false)
	{
		BulletModel.Instance.DestroyBullet(id, summonChild, destroyReason, destroyEffectImmediately);
	}

	// Token: 0x060189CE RID: 100814 RVA: 0x0064A765 File Offset: 0x00648965
	public void DestroyAllBullet(bool summonChild = false)
	{
		BulletModel.Instance.DestroyAllBullet(summonChild);
	}

	// Token: 0x060189CF RID: 100815 RVA: 0x0064A774 File Offset: 0x00648974
	public void DestroySpecifiedBullet(int ownerId, FName bulletName, bool summonChild = false, int includeTeammate = 0, float interval = 0f)
	{
		if (includeTeammate == 1)
		{
			bool flag = false;
			List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(true);
			using (List<EntityHandle>.Enumerator enumerator = teamEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Id == ownerId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			using (List<EntityHandle>.Enumerator enumerator = teamEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EntityHandle entityHandle = enumerator.Current;
					this.DestroyBulletByOwnerIdAndName(entityHandle.Id, bulletName, summonChild, interval);
				}
				return;
			}
		}
		this.DestroyBulletByOwnerIdAndName(ownerId, bulletName, summonChild, interval);
	}

	// Token: 0x060189D0 RID: 100816 RVA: 0x0064A830 File Offset: 0x00648A30
	public void DestroyBulletByOwnerIdAndName(int ownerId, FName bulletName, bool summonChild = false, float interval = 0f)
	{
		IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(ownerId);
		if (bulletSetByAttacker != null)
		{
			List<BulletEntity> list = new List<BulletEntity>();
			foreach (BulletEntity bulletEntity in bulletSetByAttacker)
			{
				BulletDataMain bulletDataMain = bulletEntity.GetBulletInfo().BulletDataMain;
				if (bulletDataMain != null && bulletDataMain.BulletFName == bulletName)
				{
					list.Add(bulletEntity);
				}
			}
			if (interval <= 0f)
			{
				using (List<BulletEntity>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						BulletEntity bulletEntity2 = enumerator2.Current;
						this.DestroyBullet(bulletEntity2.Id, summonChild, EBulletDestroyReason.Normal, false);
					}
					return;
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				this.DelayDestroyBullet(list[i].GetBulletInfo(), summonChild, (float)i * interval);
			}
		}
	}

	// Token: 0x060189D1 RID: 100817 RVA: 0x0064A930 File Offset: 0x00648B30
	public unsafe void DelayDestroyBullet(BulletInfo bulletInfo, bool summonChild, float delayTime)
	{
		if (delayTime <= 0f)
		{
			this.DestroyBullet(bulletInfo.BulletEntityId, summonChild, EBulletDestroyReason.Normal, false);
			return;
		}
		BulletActionInfoDelayDestroyBullet bulletActionInfoDelayDestroyBullet = this.GetActionCenter().CreateBulletActionInfo(EBulletAction.DelayDestroyBullet) as BulletActionInfoDelayDestroyBullet;
		if (bulletActionInfoDelayDestroyBullet == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "创建延迟销毁子弹Action失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletId", bulletInfo.BulletRowName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", bulletInfo.BulletEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("delayTime", delayTime);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		bulletActionInfoDelayDestroyBullet.DelayTime = delayTime * (float)TimeUtil.Instance.InverseMillisecond;
		bulletActionInfoDelayDestroyBullet.SummonChild = summonChild;
		bulletActionInfoDelayDestroyBullet.IgnoreBulletActorTimeScale = true;
		this.GetActionRunner().AddAction(bulletInfo, bulletActionInfoDelayDestroyBullet);
		bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
	}

	// Token: 0x060189D2 RID: 100818 RVA: 0x0064AA28 File Offset: 0x00648C28
	public int GetSpecifiedBulletCount(int ownerId, FName bulletName)
	{
		int num = 0;
		IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(ownerId);
		if (bulletSetByAttacker != null)
		{
			foreach (BulletEntity bulletEntity in bulletSetByAttacker)
			{
				BulletDataMain bulletDataMain = bulletEntity.GetBulletInfo().BulletDataMain;
				if (bulletDataMain != null && bulletDataMain.BulletFName == bulletName)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060189D3 RID: 100819 RVA: 0x0064AA9C File Offset: 0x00648C9C
	public void AddSimpleAction(BulletInfo bulletInfo, EBulletAction bulletActionType)
	{
		BulletActionInfoBase actionInfo = this.GetActionCenter().CreateBulletActionInfo(bulletActionType);
		this.ActionRunner.AddAction(bulletInfo, actionInfo);
	}

	// Token: 0x060189D4 RID: 100820 RVA: 0x0064AAC4 File Offset: 0x00648CC4
	public void SetTimeDilation(float timeDilation)
	{
		foreach (OrderedSet<BulletEntity> orderedSet in BulletModel.Instance.GetAttackerBulletIterator())
		{
			foreach (BulletEntity bulletEntity in orderedSet)
			{
				bulletEntity.SetTimeDilation(timeDilation);
			}
		}
	}

	// Token: 0x060189D5 RID: 100821 RVA: 0x0064AB48 File Offset: 0x00648D48
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.CreateBulletNotify, true, false)]
	public static void CreateBulletNotify(Entity owner, [Nullable(1)] CreateBulletNotify data, CombatCommon combatCommon = null)
	{
		if (!GameModeModel.Instance.WorldDone)
		{
			return;
		}
		if (owner == null)
		{
			return;
		}
		int skillId = (int)data.SkillId;
		string text = data.BulletId.ToString();
		long? num = (data != null) ? new long?(data.LocationEntityId) : null;
		bool flag = false;
		if (num != null)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(MathUtils.Instance.LongToNumber(num.Value));
			if (entity != null && entity.Valid)
			{
				if (entity.IsInit)
				{
					FTransformDouble? targetSocketTransform = SkillUtils.GetTargetSocketTransform(entity.Entity, data.HitCase, ERelativeTransformSpace.RTS_World, "子弹" + text, ESocketTransformDefault.BaseActor);
					global::Transform tempTransform = BulletController.Instance.TempTransform;
					FTransformDouble ftransformDouble = targetSocketTransform.Value;
					tempTransform.FromUeTransform(ftransformDouble);
				}
				else
				{
					CreatureDataComponent component = entity.Entity.GetComponent<CreatureDataComponent>();
					global::Transform tempTransform2 = BulletController.Instance.TempTransform;
					FTransformDouble ftransformDouble = component.D_GetTransform();
					tempTransform2.FromUeTransform(ftransformDouble);
					bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
				}
				flag = true;
			}
		}
		if (!flag)
		{
			if (((data != null) ? data.Location : null) != null || ((data != null) ? data.Rotation : null) != null)
			{
				BulletController.Instance.TempTransform.Reset();
				Aki.Protocol.Vector location = data.Location;
				Aki.Protocol.Rotator rotation = data.Rotation;
				if (rotation != null)
				{
					BulletController.Instance.TempRotator.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
					BulletController.Instance.TempRotator.Quaternion(BulletController.Instance.TempQuat);
					BulletController.Instance.TempTransform.SetRotation(BulletController.Instance.TempQuat);
				}
				if (location != null)
				{
					BulletController.Instance.TempTransform.SetLocation(location);
				}
				BulletController.Instance.TempTransform.SetScale3D(global::Vector.OneVectorProxy);
			}
			else
			{
				BaseActorComponent baseActorComponent = (owner != null) ? owner.CheckGetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null)
				{
					BulletController.Instance.TempTransform.SetLocation(baseActorComponent.ActorLocationProxy);
					BulletController.Instance.TempRotator.DeepCopy(baseActorComponent.ActorRotationProxy);
					BulletController.Instance.TempTransform.SetRotation(baseActorComponent.ActorQuatProxy);
				}
			}
		}
		int entityId = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.SpawnEntityId));
		int entityId2 = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.SpawnVelocityEntityId));
		int entityId3 = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.TargetId));
		FVectorDouble? targetLocation = null;
		if (data.TarLocation != null)
		{
			targetLocation = new FVectorDouble?(new FVectorDouble((double)data.TarLocation.X, (double)data.TarLocation.Y, (double)data.TarLocation.Z));
		}
		bool openCreateLog2 = BulletConstant.Instance.OpenCreateLog;
		BulletEntity bulletEntity = BulletController.Instance.CreateBulletRemote(owner, text, BulletController.Instance.TempTransform.ToUeTransform(), skillId, entityId, entityId2, entityId3, data.CombatCommon.MessageId, targetLocation, data.RandomInitPosOffset, data.RandomInitSpeed, data.Size);
		if (bulletEntity == null)
		{
			return;
		}
		BulletModel.Instance.RegisterBullet(data.Handle, bulletEntity.Id);
		if (bulletEntity.Data.Render.HandOverParentEffect)
		{
			int idByBulletHandle = BulletModel.Instance.GetIdByBulletHandle(data.ParentHandle);
			BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(idByBulletHandle);
			BulletInfo bulletInfo = (bulletEntityById != null) ? bulletEntityById.GetBulletInfo() : null;
			BulletInfo bulletInfo2 = bulletEntity.GetBulletInfo();
			if (bulletInfo != null && bulletInfo2 != null)
			{
				BulletStaticFunction.HandOverEffects(bulletInfo, bulletInfo2);
			}
			bool openCreateLog3 = BulletConstant.Instance.OpenCreateLog;
		}
	}

	// Token: 0x060189D6 RID: 100822 RVA: 0x0064AED5 File Offset: 0x006490D5
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.DestroyBulletNotify, true, false)]
	public static void DestroyBulletNotify(Entity entity, [Nullable(1)] DestroyBulletNotify data, CombatCommon combatCommon = null)
	{
		bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
		BulletModel.Instance.DestroyBulletRemote(data.Handle, data.IsCreateSubBullet);
	}

	// Token: 0x060189D7 RID: 100823 RVA: 0x0064AEF8 File Offset: 0x006490F8
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ModifyBulletParamsNotify, true, false)]
	public static void ModifyBulletParamsNotify(Entity owner, [Nullable(1)] ModifyBulletParamsNotify data, CombatCommon combatCommon = null)
	{
		BulletModel instance = BulletModel.Instance;
		ActiveBulletHandle handle;
		if (data == null)
		{
			handle = null;
		}
		else
		{
			ModifyBulletParams modifyBulletParams = data.ModifyBulletParams;
			handle = ((modifyBulletParams != null) ? modifyBulletParams.Handle : null);
		}
		int idByBulletHandle = instance.GetIdByBulletHandle(handle);
		BulletEntity bulletEntity = EntitySystem.Instance.Get<BulletEntity>(idByBulletHandle);
		long creatureDataId = MathUtils.Instance.LongToNumber(data.ModifyBulletParams.TargetId);
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		BulletInfo bulletInfo = (bulletEntity != null) ? bulletEntity.GetBulletInfo() : null;
		if (bulletInfo != null && entity != null && entity.Valid)
		{
			bulletInfo.SetTargetById(entity.Id);
		}
	}

	// Token: 0x060189D8 RID: 100824 RVA: 0x0064AF88 File Offset: 0x00649188
	[NullableContext(2)]
	private BulletEntity CreateBulletRemote([Nullable(1)] Entity owner, [Nullable(1)] string bulletRowName, FTransformDouble initialTransform, int skillId, int spawnEntityId, int spawnVelocityEntityId, int targetId, long contextId, FVectorDouble? targetLocation = null, IVector randomPosOffset = null, IVector randomInitSpeedOffset = null, IVector size = null)
	{
		this.CreateBulletStatStart(bulletRowName);
		BulletEntity result = this.CreateBullet(owner, bulletRowName, new FTransformDouble?(initialTransform), new BulletController.BulletCreateParams
		{
			SkillId = skillId,
			SyncType = global::EBulletSyncType.SyncFromRemote,
			BaseTransformId = new int?(spawnEntityId),
			BaseVelocityId = new int?(spawnVelocityEntityId),
			TargetId = new int?(targetId),
			InitTargetLocation = targetLocation,
			RandomPosOffset = randomPosOffset,
			RandomInitSpeedOffset = randomInitSpeedOffset,
			Size = ((size != null) ? global::Vector.Create(size) : null)
		}, new long?(contextId), global::EBulletCreateSource.Others);
		this.CreateBulletStatSop(bulletRowName);
		return result;
	}

	// Token: 0x060189D9 RID: 100825 RVA: 0x0064B020 File Offset: 0x00649220
	private unsafe int GetCustomEntityId(Entity owner, int pos, string bulletRowName)
	{
		if (float.IsNaN((float)pos))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "pos NAN！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bulletRowName", bulletRowName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		IList<long> customServerEntityIds = owner.GetComponent<CreatureDataComponent>().CustomServerEntityIds;
		if (pos > customServerEntityIds.Count || pos == 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author2 = ELogAuthor.HCW;
			string message2 = "pos不合法！";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bulletRowName", bulletRowName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pos", pos);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("serverEntityIds", customServerEntityIds);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(customServerEntityIds[pos - 1]);
		if (entity != null)
		{
			return entity.Id;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Bullet;
		ELogAuthor author3 = ELogAuthor.HCW;
		string message3 = "无法找到伴生物实体";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("bulletRowName", bulletRowName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("pos", pos);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("serverEntityIds", customServerEntityIds);
		instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		return 0;
	}

	// Token: 0x060189DA RID: 100826 RVA: 0x0064B178 File Offset: 0x00649378
	public Stat GetBulletCreateStat(string bulletRowName)
	{
		Stat stat;
		if (!this.BulletCreateStatMap.TryGetValue(bulletRowName, out stat))
		{
			stat = null;
			this.BulletCreateStatMap[bulletRowName] = stat;
		}
		return stat;
	}

	// Token: 0x060189DB RID: 100827 RVA: 0x0064B1A8 File Offset: 0x006493A8
	public Stat GetBulletDestroyStat(string bulletRowName)
	{
		Stat stat;
		if (!this.BulletDestroyStatMap.TryGetValue(bulletRowName, out stat))
		{
			stat = null;
			this.BulletDestroyStatMap[bulletRowName] = stat;
		}
		return stat;
	}

	// Token: 0x060189DC RID: 100828 RVA: 0x0064B1D8 File Offset: 0x006493D8
	public Stat GetBulletMoveTickStat(string bulletRowName)
	{
		Stat stat;
		if (!this.BulletMoveTickStatMap.TryGetValue(bulletRowName, out stat))
		{
			stat = null;
			this.BulletMoveTickStatMap[bulletRowName] = stat;
		}
		return stat;
	}

	// Token: 0x060189DD RID: 100829 RVA: 0x0064B208 File Offset: 0x00649408
	public Stat GetBulletCollisionTickStat(string bulletRowName)
	{
		Stat stat;
		if (!this.BulletCollisionTickStatMap.TryGetValue(bulletRowName, out stat))
		{
			stat = null;
			this.BulletCollisionTickStatMap[bulletRowName] = stat;
		}
		return stat;
	}

	// Token: 0x060189DE RID: 100830 RVA: 0x0064B238 File Offset: 0x00649438
	public Stat GetBulletCollisionAfterTickStat(string bulletRowName)
	{
		Stat stat;
		if (!this.BulletCollisionAfterTickStatMap.TryGetValue(bulletRowName, out stat))
		{
			stat = null;
			this.BulletCollisionAfterTickStatMap[bulletRowName] = stat;
		}
		return stat;
	}

	// Token: 0x060189DF RID: 100831 RVA: 0x0064B265 File Offset: 0x00649465
	[NullableContext(2)]
	public EntityHandle GetSceneBulletOwner()
	{
		return CreatureModel.Instance.GetEntity(BulletModel.Instance.SceneBulletOwnerId);
	}

	// Token: 0x060189E0 RID: 100832 RVA: 0x0064B27C File Offset: 0x0064947C
	public void SetBulletSpeedRatio(int id, float newSpeed)
	{
		BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(id);
		BulletInfo bulletInfo = (bulletEntityById != null) ? bulletEntityById.GetBulletInfo() : null;
		BulletMoveInfo bulletMoveInfo = (bulletInfo != null) ? bulletInfo.MoveInfo : null;
		if (bulletMoveInfo != null)
		{
			bulletMoveInfo.BulletSpeedRatio = newSpeed;
		}
	}

	// Token: 0x060189E1 RID: 100833 RVA: 0x0064B2B8 File Offset: 0x006494B8
	public void SetBulletLiveRatio(int id, float ratio)
	{
		BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(id);
		BulletInfo bulletInfo = (bulletEntityById != null) ? bulletEntityById.GetBulletInfo() : null;
		if (bulletInfo != null)
		{
			bulletInfo.LiveTimeRatio = ratio;
		}
	}

	// Token: 0x060189E2 RID: 100834 RVA: 0x0064B2E7 File Offset: 0x006494E7
	public int SpawnPattern(Entity ownerEntity, UKuroBulletPatternDataAsset patternData, FWorldEntityBulletParam extraParam)
	{
		return BulletModel.Instance.SpawnPattern(ownerEntity, patternData, extraParam);
	}

	// Token: 0x060189E3 RID: 100835 RVA: 0x0064B2F6 File Offset: 0x006494F6
	public void DestroyPatternById(int patternId)
	{
		BulletModel.Instance.DestroyPatternById(patternId);
	}

	// Token: 0x060189E4 RID: 100836 RVA: 0x0064B303 File Offset: 0x00649503
	public void ProcessKuroBulletOperationList()
	{
		BulletModel.Instance.ProcessKuroBulletOperationList();
	}

	// Token: 0x060189E5 RID: 100837 RVA: 0x0064B30F File Offset: 0x0064950F
	public void ProcessKuroBulletOperation(FBulletHitWorldEntityOperation operation)
	{
		BulletModel.Instance.ProcessKuroBulletOperation(operation);
	}

	// Token: 0x170021B9 RID: 8633
	// (get) Token: 0x060189E6 RID: 100838 RVA: 0x0064B31C File Offset: 0x0064951C
	public static BulletController Instance
	{
		get
		{
			return BulletController._Instance;
		}
	}

	// Token: 0x060189E7 RID: 100839 RVA: 0x0064B323 File Offset: 0x00649523
	public static BulletController GetOrCreateInstance()
	{
		if (BulletController._Instance == null)
		{
			BulletController.CreateInstance();
		}
		return BulletController._Instance;
	}

	// Token: 0x060189E8 RID: 100840 RVA: 0x0064B337 File Offset: 0x00649537
	public static bool CreateInstance()
	{
		if (BulletController._Instance != null)
		{
			return true;
		}
		BulletController._Instance = new BulletController();
		return true;
	}

	// Token: 0x060189E9 RID: 100841 RVA: 0x0064B34D File Offset: 0x0064954D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060189EA RID: 100842 RVA: 0x0064B34F File Offset: 0x0064954F
	public static void ResetStaticDefaultValue()
	{
		BulletController._Instance = null;
	}

	// Token: 0x060189EB RID: 100843 RVA: 0x0064B357 File Offset: 0x00649557
	static BulletController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletController.CreateStaticDefaultValue), new Action(BulletController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B731 RID: 46897
	private readonly List<BulletSystemBase> SystemList = new List<BulletSystemBase>();

	// Token: 0x0400B732 RID: 46898
	[Nullable(2)]
	private BulletActionRunner ActionRunner;

	// Token: 0x0400B733 RID: 46899
	private readonly Dictionary<string, Stat> BulletCreateStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400B734 RID: 46900
	private readonly Dictionary<string, Stat> BulletDestroyStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400B735 RID: 46901
	private readonly Dictionary<string, Stat> BulletMoveTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400B736 RID: 46902
	private readonly Dictionary<string, Stat> BulletCollisionTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400B737 RID: 46903
	private readonly Dictionary<string, Stat> BulletCollisionAfterTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400B738 RID: 46904
	private readonly Stat BulletConfigGetData = Stat.Create("BulletConfigGetData", "", "");

	// Token: 0x0400B739 RID: 46905
	private readonly global::Transform TempTransform = global::Transform.Create();

	// Token: 0x0400B73A RID: 46906
	private readonly global::Rotator TempRotator = global::Rotator.Create();

	// Token: 0x0400B73B RID: 46907
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400B73C RID: 46908
	[Nullable(2)]
	private static BulletController _Instance;

	// Token: 0x0200933A RID: 37690
	[NullableContext(2)]
	[Nullable(0)]
	public class BulletCreateParams
	{
		// Token: 0x0402F8FA RID: 194810
		public int SkillId;

		// Token: 0x0402F8FB RID: 194811
		public long? SkillContextId;

		// Token: 0x0402F8FC RID: 194812
		public global::EBulletSyncType SyncType;

		// Token: 0x0402F8FD RID: 194813
		public int? ParentVictimId = new int?(0);

		// Token: 0x0402F8FE RID: 194814
		public int? ParentTargetId = new int?(0);

		// Token: 0x0402F8FF RID: 194815
		public int ParentId;

		// Token: 0x0402F900 RID: 194816
		public global::Vector Size;

		// Token: 0x0402F901 RID: 194817
		public FVectorDouble? InitTargetLocation;

		// Token: 0x0402F902 RID: 194818
		public Aki.Protocol.EBulletCreateSource Source;

		// Token: 0x0402F903 RID: 194819
		public FVector? LocationOffset;

		// Token: 0x0402F904 RID: 194820
		public FRotator? BeginRotatorOffset;

		// Token: 0x0402F905 RID: 194821
		public bool CreateOnAuthority = true;

		// Token: 0x0402F906 RID: 194822
		public ISkillBattleContext BattleContext;

		// Token: 0x0402F907 RID: 194823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> ParentIds;

		// Token: 0x0402F908 RID: 194824
		public BulletDataMain BulletData;

		// Token: 0x0402F909 RID: 194825
		public int? TargetId;

		// Token: 0x0402F90A RID: 194826
		public int? BaseTransformId;

		// Token: 0x0402F90B RID: 194827
		public int? BaseVelocityId;

		// Token: 0x0402F90C RID: 194828
		public IVector RandomPosOffset;

		// Token: 0x0402F90D RID: 194829
		public IVector RandomInitSpeedOffset;
	}
}
