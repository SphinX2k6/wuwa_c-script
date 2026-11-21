using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200231D RID: 8989
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class BulletController : ControllerBase
{
	// Token: 0x0601625A RID: 90714 RVA: 0x0066F890 File Offset: 0x0066DA90
	protected override bool OnInit()
	{
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

	// Token: 0x0601625B RID: 90715 RVA: 0x0066F8FC File Offset: 0x0066DAFC
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

	// Token: 0x0601625C RID: 90716 RVA: 0x0066F984 File Offset: 0x0066DB84
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

	// Token: 0x0601625D RID: 90717 RVA: 0x0066FA18 File Offset: 0x0066DC18
	protected override bool OnClear()
	{
		this.ActionRunner.Clear();
		this.OnRemoveEvents();
		BulletPool.Clear();
		this.SystemList.Clear();
		return true;
	}

	// Token: 0x0601625E RID: 90718 RVA: 0x0066FA3C File Offset: 0x0066DC3C
	protected override bool OnLeaveLevel()
	{
		BulletConfig.Instance.ClearBulletDataCache();
		BulletConfig.Instance.ClearPreload();
		return true;
	}

	// Token: 0x0601625F RID: 90719 RVA: 0x0066FA53 File Offset: 0x0066DC53
	public BulletActionCenter GetActionCenter()
	{
		return this.ActionRunner.GetActionCenter();
	}

	// Token: 0x06016260 RID: 90720 RVA: 0x0066FA60 File Offset: 0x0066DC60
	public BulletActionRunner GetActionRunner()
	{
		return this.ActionRunner;
	}

	// Token: 0x06016261 RID: 90721 RVA: 0x0066FA68 File Offset: 0x0066DC68
	private void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add(EEventName.SetNiagaraQuality, new Action(this.OnSetNiagaraQuality));
	}

	// Token: 0x06016262 RID: 90722 RVA: 0x0066FAC8 File Offset: 0x0066DCC8
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Remove(EEventName.SetNiagaraQuality, new Action(this.OnSetNiagaraQuality));
	}

	// Token: 0x06016263 RID: 90723 RVA: 0x0066FB28 File Offset: 0x0066DD28
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

	// Token: 0x06016264 RID: 90724 RVA: 0x0066FC28 File Offset: 0x0066DE28
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		BulletConfig.Instance.RemoveCacheBulletDataByEntityId(handle.Id);
	}

	// Token: 0x06016265 RID: 90725 RVA: 0x0066FC3C File Offset: 0x0066DE3C
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

	// Token: 0x06016266 RID: 90726 RVA: 0x0066FCA4 File Offset: 0x0066DEA4
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

	// Token: 0x06016267 RID: 90727 RVA: 0x0066FCC9 File Offset: 0x0066DEC9
	[NullableContext(2)]
	public bool HasAuthority(TsBaseCharacter owner)
	{
		return owner != null && owner.IsAutonomousProxy();
	}

	// Token: 0x06016268 RID: 90728 RVA: 0x0066FCD6 File Offset: 0x0066DED6
	private void CreateBulletStatStart(string bulletRowName)
	{
	}

	// Token: 0x06016269 RID: 90729 RVA: 0x0066FCD8 File Offset: 0x0066DED8
	private void CreateBulletStatSop(string bulletRowName)
	{
	}

	// Token: 0x0601626A RID: 90730 RVA: 0x0066FCDA File Offset: 0x0066DEDA
	[return: Nullable(2)]
	public BulletEntity CreateBulletCustomTarget([Nullable(2)] Entity owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams = null, long? contextId = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		return this.CreateBulletCustomTargetInternal(owner, bulletRowName, initialTransform, bulletCreateParams, contextId, createSource);
	}

	// Token: 0x0601626B RID: 90731 RVA: 0x0066FCEC File Offset: 0x0066DEEC
	[return: Nullable(2)]
	public BulletEntity CreateBulletCustomTarget([Nullable(2)] TsBaseCharacter owner, string bulletRowName, FTransformDouble? initialTransform, BulletController.BulletCreateParams bulletCreateParams = null, long? contextId = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		Entity owner2 = (owner != null) ? owner.GetEntityNoBlueprint() : null;
		return this.CreateBulletCustomTargetInternal(owner2, bulletRowName, initialTransform, bulletCreateParams, contextId, createSource);
	}

	// Token: 0x0601626C RID: 90732 RVA: 0x0066FD18 File Offset: 0x0066DF18
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

	// Token: 0x0601626D RID: 90733 RVA: 0x0066FF74 File Offset: 0x0066E174
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

	// Token: 0x0601626E RID: 90734 RVA: 0x00670024 File Offset: 0x0066E224
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

	// Token: 0x0601626F RID: 90735 RVA: 0x006700BC File Offset: 0x0066E2BC
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

	// Token: 0x06016270 RID: 90736 RVA: 0x00670168 File Offset: 0x0066E368
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

	// Token: 0x06016271 RID: 90737 RVA: 0x00670314 File Offset: 0x0066E514
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

	// Token: 0x06016272 RID: 90738 RVA: 0x00670354 File Offset: 0x0066E554
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

	// Token: 0x06016273 RID: 90739 RVA: 0x00670398 File Offset: 0x0066E598
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

	// Token: 0x06016274 RID: 90740 RVA: 0x00670478 File Offset: 0x0066E678
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

	// Token: 0x06016275 RID: 90741 RVA: 0x00670538 File Offset: 0x0066E738
	public void DestroyBullet(int id, bool summonChild, EBulletDestroyReason destroyReason = EBulletDestroyReason.Normal, bool destroyEffectImmediately = false)
	{
		BulletModel.Instance.DestroyBullet(id, summonChild, destroyReason, destroyEffectImmediately);
	}

	// Token: 0x06016276 RID: 90742 RVA: 0x00670549 File Offset: 0x0066E749
	public void DestroyAllBullet(bool summonChild = false)
	{
		BulletModel.Instance.DestroyAllBullet(summonChild);
	}

	// Token: 0x06016277 RID: 90743 RVA: 0x00670558 File Offset: 0x0066E758
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

	// Token: 0x06016278 RID: 90744 RVA: 0x00670614 File Offset: 0x0066E814
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

	// Token: 0x06016279 RID: 90745 RVA: 0x00670714 File Offset: 0x0066E914
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

	// Token: 0x0601627A RID: 90746 RVA: 0x0067080C File Offset: 0x0066EA0C
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

	// Token: 0x0601627B RID: 90747 RVA: 0x00670880 File Offset: 0x0066EA80
	public void AddSimpleAction(BulletInfo bulletInfo, EBulletAction bulletActionType)
	{
		BulletActionInfoBase actionInfo = this.GetActionCenter().CreateBulletActionInfo(bulletActionType);
		this.ActionRunner.AddAction(bulletInfo, actionInfo);
	}

	// Token: 0x0601627C RID: 90748 RVA: 0x006708A8 File Offset: 0x0066EAA8
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

	// Token: 0x0601627D RID: 90749 RVA: 0x0067092C File Offset: 0x0066EB2C
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

	// Token: 0x0601627E RID: 90750 RVA: 0x00670CB9 File Offset: 0x0066EEB9
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.DestroyBulletNotify, true, false)]
	public static void DestroyBulletNotify(Entity entity, [Nullable(1)] DestroyBulletNotify data, CombatCommon combatCommon = null)
	{
		bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
		BulletModel.Instance.DestroyBulletRemote(data.Handle, data.IsCreateSubBullet);
	}

	// Token: 0x0601627F RID: 90751 RVA: 0x00670CDC File Offset: 0x0066EEDC
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

	// Token: 0x06016280 RID: 90752 RVA: 0x00670D6C File Offset: 0x0066EF6C
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

	// Token: 0x06016281 RID: 90753 RVA: 0x00670E04 File Offset: 0x0066F004
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

	// Token: 0x06016282 RID: 90754 RVA: 0x00670F5C File Offset: 0x0066F15C
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

	// Token: 0x06016283 RID: 90755 RVA: 0x00670F8C File Offset: 0x0066F18C
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

	// Token: 0x06016284 RID: 90756 RVA: 0x00670FBC File Offset: 0x0066F1BC
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

	// Token: 0x06016285 RID: 90757 RVA: 0x00670FEC File Offset: 0x0066F1EC
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

	// Token: 0x06016286 RID: 90758 RVA: 0x0067101C File Offset: 0x0066F21C
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

	// Token: 0x06016287 RID: 90759 RVA: 0x00671049 File Offset: 0x0066F249
	[NullableContext(2)]
	public EntityHandle GetSceneBulletOwner()
	{
		return CreatureModel.Instance.GetEntity(BulletModel.Instance.SceneBulletOwnerId);
	}

	// Token: 0x06016288 RID: 90760 RVA: 0x00671060 File Offset: 0x0066F260
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

	// Token: 0x06016289 RID: 90761 RVA: 0x0067109C File Offset: 0x0066F29C
	public void SetBulletLiveRatio(int id, float ratio)
	{
		BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(id);
		BulletInfo bulletInfo = (bulletEntityById != null) ? bulletEntityById.GetBulletInfo() : null;
		if (bulletInfo != null)
		{
			bulletInfo.LiveTimeRatio = ratio;
		}
	}

	// Token: 0x0601628A RID: 90762 RVA: 0x006710CB File Offset: 0x0066F2CB
	public int SpawnPattern(Entity ownerEntity, UKuroBulletPatternDataAsset patternData, FWorldEntityBulletParam extraParam)
	{
		return BulletModel.Instance.SpawnPattern(ownerEntity, patternData, extraParam);
	}

	// Token: 0x0601628B RID: 90763 RVA: 0x006710DA File Offset: 0x0066F2DA
	public void DestroyPatternById(int patternId)
	{
		BulletModel.Instance.DestroyPatternById(patternId);
	}

	// Token: 0x0601628C RID: 90764 RVA: 0x006710E7 File Offset: 0x0066F2E7
	public void ProcessKuroBulletOperationList()
	{
		BulletModel.Instance.ProcessKuroBulletOperationList();
	}

	// Token: 0x0601628D RID: 90765 RVA: 0x006710F3 File Offset: 0x0066F2F3
	public void ProcessKuroBulletOperation(FBulletHitWorldEntityOperation operation)
	{
		BulletModel.Instance.ProcessKuroBulletOperation(operation);
	}

	// Token: 0x17002215 RID: 8725
	// (get) Token: 0x0601628E RID: 90766 RVA: 0x00671100 File Offset: 0x0066F300
	public static BulletController Instance
	{
		get
		{
			return BulletController._Instance;
		}
	}

	// Token: 0x0601628F RID: 90767 RVA: 0x00671107 File Offset: 0x0066F307
	public static BulletController GetOrCreateInstance()
	{
		if (BulletController._Instance == null)
		{
			BulletController.CreateInstance();
		}
		return BulletController._Instance;
	}

	// Token: 0x06016290 RID: 90768 RVA: 0x0067111B File Offset: 0x0066F31B
	public static bool CreateInstance()
	{
		if (BulletController._Instance != null)
		{
			return true;
		}
		BulletController._Instance = new BulletController();
		return true;
	}

	// Token: 0x06016291 RID: 90769 RVA: 0x00671131 File Offset: 0x0066F331
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016292 RID: 90770 RVA: 0x00671133 File Offset: 0x0066F333
	public static void ResetStaticDefaultValue()
	{
		BulletController._Instance = null;
	}

	// Token: 0x06016293 RID: 90771 RVA: 0x0067113B File Offset: 0x0066F33B
	static BulletController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletController.CreateStaticDefaultValue), new Action(BulletController.ResetStaticDefaultValue));
	}

	// Token: 0x0400BAAC RID: 47788
	private readonly List<BulletSystemBase> SystemList = new List<BulletSystemBase>();

	// Token: 0x0400BAAD RID: 47789
	[Nullable(2)]
	private BulletActionRunner ActionRunner;

	// Token: 0x0400BAAE RID: 47790
	private readonly Dictionary<string, Stat> BulletCreateStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400BAAF RID: 47791
	private readonly Dictionary<string, Stat> BulletDestroyStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400BAB0 RID: 47792
	private readonly Dictionary<string, Stat> BulletMoveTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400BAB1 RID: 47793
	private readonly Dictionary<string, Stat> BulletCollisionTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400BAB2 RID: 47794
	private readonly Dictionary<string, Stat> BulletCollisionAfterTickStatMap = new Dictionary<string, Stat>();

	// Token: 0x0400BAB3 RID: 47795
	private readonly Stat BulletConfigGetData = Stat.Create("BulletConfigGetData", "", "");

	// Token: 0x0400BAB4 RID: 47796
	private readonly global::Transform TempTransform = global::Transform.Create();

	// Token: 0x0400BAB5 RID: 47797
	private readonly global::Rotator TempRotator = global::Rotator.Create();

	// Token: 0x0400BAB6 RID: 47798
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400BAB7 RID: 47799
	[Nullable(2)]
	private static BulletController _Instance;

	// Token: 0x02008561 RID: 34145
	[NullableContext(2)]
	[Nullable(0)]
	public class BulletCreateParams
	{
		// Token: 0x0402AF82 RID: 176002
		public int SkillId;

		// Token: 0x0402AF83 RID: 176003
		public long? SkillContextId;

		// Token: 0x0402AF84 RID: 176004
		public global::EBulletSyncType SyncType;

		// Token: 0x0402AF85 RID: 176005
		public int? ParentVictimId = new int?(0);

		// Token: 0x0402AF86 RID: 176006
		public int? ParentTargetId = new int?(0);

		// Token: 0x0402AF87 RID: 176007
		public int ParentId;

		// Token: 0x0402AF88 RID: 176008
		public global::Vector Size;

		// Token: 0x0402AF89 RID: 176009
		public FVectorDouble? InitTargetLocation;

		// Token: 0x0402AF8A RID: 176010
		public Aki.Protocol.EBulletCreateSource Source;

		// Token: 0x0402AF8B RID: 176011
		public FVector? LocationOffset;

		// Token: 0x0402AF8C RID: 176012
		public FRotator? BeginRotatorOffset;

		// Token: 0x0402AF8D RID: 176013
		public bool CreateOnAuthority = true;

		// Token: 0x0402AF8E RID: 176014
		public ISkillBattleContext BattleContext;

		// Token: 0x0402AF8F RID: 176015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> ParentIds;

		// Token: 0x0402AF90 RID: 176016
		public BulletDataMain BulletData;

		// Token: 0x0402AF91 RID: 176017
		public int? TargetId;

		// Token: 0x0402AF92 RID: 176018
		public int? BaseTransformId;

		// Token: 0x0402AF93 RID: 176019
		public int? BaseVelocityId;

		// Token: 0x0402AF94 RID: 176020
		public IVector RandomPosOffset;

		// Token: 0x0402AF95 RID: 176021
		public IVector RandomInitSpeedOffset;
	}
}
