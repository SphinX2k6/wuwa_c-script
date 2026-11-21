using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Summon;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020025B2 RID: 9650
[NullableContext(1)]
[Nullable(0)]
public class CharacterFollowComponent : EntityComponent
{
	// Token: 0x17002566 RID: 9574
	// (get) Token: 0x06017EF4 RID: 98036 RVA: 0x00723D7D File Offset: 0x00721F7D
	public List<int> AttributeSharerIds
	{
		get
		{
			return this.AttributeSharerIdsInternal;
		}
	}

	// Token: 0x06017EF5 RID: 98037 RVA: 0x00723D88 File Offset: 0x00721F88
	protected override bool OnStart()
	{
		this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.SkillComp = base.Entity.GetComponent<BaseSkillComponent>();
		return true;
	}

	// Token: 0x06017EF6 RID: 98038 RVA: 0x00723DDA File Offset: 0x00721FDA
	protected override void OnActivate()
	{
		this.InitFollowData();
	}

	// Token: 0x06017EF7 RID: 98039 RVA: 0x00723DE2 File Offset: 0x00721FE2
	protected override bool OnEnd()
	{
		this.RemoveFromAttributeHolder();
		return true;
	}

	// Token: 0x06017EF8 RID: 98040 RVA: 0x00723DEC File Offset: 0x00721FEC
	private void SetAttributeHolderId(int id)
	{
		this.AttributeHolderId = id;
		if (this.AttributeHolderId != 0)
		{
			Entity entity = EntitySystem.Instance.Get(this.AttributeHolderId);
			RoleGrowComponent roleGrowComponent = (entity != null) ? entity.GetComponent<RoleGrowComponent>() : null;
			if (roleGrowComponent != null)
			{
				CharacterSkillComponent component = base.Entity.GetComponent<CharacterSkillComponent>();
				if (component == null)
				{
					return;
				}
				component.ResetRoleGrowComponent(roleGrowComponent);
			}
		}
	}

	// Token: 0x06017EF9 RID: 98041 RVA: 0x00723E40 File Offset: 0x00722040
	[NullableContext(2)]
	public AActor GetRoleActor()
	{
		Entity entity = EntitySystem.Instance.Get(this.AttributeHolderId);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		return entity.GetComponent<BaseActorComponent>().Owner;
	}

	// Token: 0x06017EFA RID: 98042 RVA: 0x00723E7C File Offset: 0x0072207C
	public TArray<AActor> GetAttributeSharerActors()
	{
		List<int> attributeSharerIdsInternal = this.AttributeSharerIdsInternal;
		TArray<AActor> tarray = new TArray<AActor>();
		foreach (int id in attributeSharerIdsInternal)
		{
			Entity entity = EntitySystem.Instance.Get(id);
			if (entity != null && entity.Valid)
			{
				AActor owner = entity.GetComponent<BaseActorComponent>().Owner;
				if (owner != null)
				{
					tarray.Add(owner);
				}
			}
		}
		return tarray;
	}

	// Token: 0x06017EFB RID: 98043 RVA: 0x00723F08 File Offset: 0x00722108
	public TArray<AActor> GetFollowActor()
	{
		return this.GetAttributeSharerActors();
	}

	// Token: 0x06017EFC RID: 98044 RVA: 0x00723F10 File Offset: 0x00722110
	public void SetAttributeSharerId(int id)
	{
		if (this.AttributeSharerIdsInternal.IndexOf(id) == -1)
		{
			this.AttributeSharerIdsInternal.Add(id);
		}
	}

	// Token: 0x06017EFD RID: 98045 RVA: 0x00723F2D File Offset: 0x0072212D
	public void SetFollowId(int id)
	{
		this.SetAttributeSharerId(id);
	}

	// Token: 0x06017EFE RID: 98046 RVA: 0x00723F38 File Offset: 0x00722138
	public void RemoveFromAttributeHolder()
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.CreatureDataComponent.GetSummonerId());
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterFollowComponent component = entity.Entity.GetComponent<CharacterFollowComponent>();
		if (component == null)
		{
			return;
		}
		component.DeleteAttributeSharerId(base.Entity.Id);
	}

	// Token: 0x06017EFF RID: 98047 RVA: 0x00723F90 File Offset: 0x00722190
	[NullableContext(2)]
	public unsafe Entity GetAttributeHolder()
	{
		if (this.AttributeHolderId != 0)
		{
			Entity entity = EntitySystem.Instance.Get(this.AttributeHolderId);
			if (entity != null && entity.Valid)
			{
				return entity;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "FollowComp role is inValid";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.AttributeHolderId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "SelfId";
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			ptr = new ValueTuple<string, object>(item, (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return null;
	}

	// Token: 0x06017F00 RID: 98048 RVA: 0x00724047 File Offset: 0x00722247
	[NullableContext(2)]
	public Entity GetAttributeHolderExceptVisionSummon()
	{
		if (this.IsVisionSummon)
		{
			return null;
		}
		return this.GetAttributeHolder();
	}

	// Token: 0x06017F01 RID: 98049 RVA: 0x00724059 File Offset: 0x00722259
	public void Reset(int entityId = 0)
	{
		this.DeleteAttributeSharerId(entityId);
		this.AttributeHolderId = 0;
	}

	// Token: 0x06017F02 RID: 98050 RVA: 0x0072406C File Offset: 0x0072226C
	public double GetToRoleDistance()
	{
		if (this.AttributeHolderId == 0)
		{
			return -1.0;
		}
		Entity entity = EntitySystem.Instance.Get(this.AttributeHolderId);
		if (entity == null || base.Entity == null)
		{
			return -1.0;
		}
		if (base.Entity.GetComponent<BaseActorComponent>() != null && entity.GetComponent<BaseActorComponent>() != null)
		{
			FVectorDouble actorLocation = base.Entity.GetComponent<BaseActorComponent>().ActorLocation;
			FVectorDouble actorLocation2 = entity.GetComponent<BaseActorComponent>().ActorLocation;
			return FVectorDouble.Dist(actorLocation, actorLocation2);
		}
		return -1.0;
	}

	// Token: 0x06017F03 RID: 98051 RVA: 0x007240F8 File Offset: 0x007222F8
	private void InitFollowData()
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.CreatureDataComponent.GetSummonerId());
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (this.CreatureDataComponent.SummonType == ESummonType.ConcomitantVision)
		{
			VisionComponent visionComponent = this.CreatureDataComponent.GetVisionComponent();
			if (visionComponent != null)
			{
				SVisionData visionData = PhantomUtil.GetVisionData(visionComponent.VisionId);
				if (visionData != null)
				{
					this.IsVisionSummon = (visionData.类型 == EVisionType.召唤);
				}
			}
			this.SetRelationship(entity);
		}
		else if (this.CreatureDataComponent.SummonType == ESummonType.ConcomitantCustom && this.CreatureDataComponent.SummonCfgId != 0)
		{
			SummonCfg? config = ConfigSummonCfgById.GetConfig(this.CreatureDataComponent.SummonCfgId, true);
			if (config != null && config.GetValueOrDefault().ShareDamage)
			{
				this.SetRelationship(entity);
			}
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.怪物类型.召唤物"]));
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			ESummonType? esummonType = (creatureDataComponent != null) ? new ESummonType?(creatureDataComponent.SummonType) : null;
			if (esummonType != null)
			{
				switch (esummonType.GetValueOrDefault())
				{
				case ESummonType.ConcomitantVision:
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.怪物类型.召唤物.幻象"]));
					return;
				case ESummonType.ConcomitantCustom:
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.怪物类型.召唤物.角色召唤物"]));
					return;
				case ESummonType.ConcomitantPhantomRole:
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.怪物类型.召唤物.操控幻象"]));
					return;
				}
			}
			component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.怪物类型.召唤物.默认"]));
		}
	}

	// Token: 0x06017F04 RID: 98052 RVA: 0x007242B8 File Offset: 0x007224B8
	private void DeleteAttributeSharerId(int entityId)
	{
		if (entityId != 0)
		{
			int num = this.AttributeSharerIdsInternal.IndexOf(entityId);
			if (num != -1)
			{
				this.AttributeSharerIdsInternal.RemoveAt(num);
				return;
			}
		}
		else
		{
			this.AttributeSharerIdsInternal = new List<int>();
		}
	}

	// Token: 0x06017F05 RID: 98053 RVA: 0x007242F1 File Offset: 0x007224F1
	private void DeleteFollowId(int entityId)
	{
		this.DeleteAttributeSharerId(entityId);
	}

	// Token: 0x06017F06 RID: 98054 RVA: 0x007242FA File Offset: 0x007224FA
	public void SetRelationship(EntityHandle summoner)
	{
		this.SetAttributeHolderId(summoner.Id);
		summoner.Entity.GetComponent<CharacterFollowComponent>().SetAttributeSharerId(base.Entity.Id);
		EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnCharacterSetMaster, summoner.Id);
	}

	// Token: 0x06017F07 RID: 98055 RVA: 0x0072433C File Offset: 0x0072253C
	public void ListenConcomitantInherit(IConcomitantInheritContext context)
	{
		this.CurrentConcomitantInherit = context;
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharBeforeInterrupt));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnCharBeforeInterruptWithTarget));
	}

	// Token: 0x06017F08 RID: 98056 RVA: 0x00724390 File Offset: 0x00722590
	public void RemoveListenConcomitantInherit()
	{
		this.CurrentConcomitantInherit = null;
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharBeforeInterrupt));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnCharBeforeInterruptWithTarget));
	}

	// Token: 0x06017F09 RID: 98057 RVA: 0x007243E4 File Offset: 0x007225E4
	private void OnCharBeforeInterrupt(int entityId, int interruptedSkillId)
	{
		this.CheckStartConcomitantInherit(interruptedSkillId, null);
	}

	// Token: 0x06017F0A RID: 98058 RVA: 0x00724401 File Offset: 0x00722601
	private void OnCharBeforeInterruptWithTarget(int newSkillId, int interruptedSkillId)
	{
		this.CheckStartConcomitantInherit(interruptedSkillId, new int?(newSkillId));
	}

	// Token: 0x06017F0B RID: 98059 RVA: 0x00724410 File Offset: 0x00722610
	private void CheckStartConcomitantInherit(int interruptedSkillId, int? newSkillId = null)
	{
		if (this.CurrentConcomitantInherit == null)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsAutonomousProxy)
		{
			return;
		}
		Entity entity = base.Entity;
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		if (baseSkillComponent == null)
		{
			return;
		}
		global::Skill currentSkill = baseSkillComponent.CurrentSkill;
		if (currentSkill == null || currentSkill.SkillId != interruptedSkillId)
		{
			return;
		}
		EEndSkillReason reason = baseSkillComponent.GetSkill(interruptedSkillId).EndSkillInfo.Reason;
		if (reason != EEndSkillReason.BeginOtherSkill)
		{
			if (reason != EEndSkillReason.BeHit)
			{
				if (!this.CurrentConcomitantInherit.OtherInterrupt)
				{
					return;
				}
			}
			else if (!this.CurrentConcomitantInherit.HitInterrupt)
			{
				return;
			}
		}
		else
		{
			if (newSkillId == null)
			{
				return;
			}
			if (!this.CurrentConcomitantInherit.SkillInterrupt)
			{
				return;
			}
			if (this.CurrentConcomitantInherit.NewSkillIds.Count > 0 && !this.CurrentConcomitantInherit.NewSkillIds.Contains((long)newSkillId.Value))
			{
				return;
			}
		}
		this.CurrentConcomitantInherit.SkillId = new int?(interruptedSkillId);
		this.StartConcomitantInherit(this.CurrentConcomitantInherit);
	}

	// Token: 0x06017F0C RID: 98060 RVA: 0x0072450C File Offset: 0x0072270C
	public void StartConcomitantInherit(IConcomitantInheritContext context)
	{
		float currentMontagePosition = this.AnimComp.MontageGetPosition();
		BaseSkillComponent skillComp = this.SkillComp;
		int num = (skillComp != null) ? skillComp.GetPlayingMontageIndex(context.SkillId.Value) : -1;
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, base.Entity, "[伴生物继承本体技能表现]开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		EntityHandle summonEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantCustom, context.SummonIndex);
		EntityHandle summonEntity2 = summonEntity;
		if (summonEntity2 == null || !summonEntity2.Valid)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = base.Entity;
			string message = "[伴生物继承本体技能表现]伴生物不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SummonIndex", context.SummonIndex);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CreatureController.Instance.SetEntityEnable(summonEntity.Entity, true, "ConcomitantInherit", true);
		CharacterActorComponent component = summonEntity.Entity.GetComponent<CharacterActorComponent>();
		if (component != null)
		{
			component.SetActorLocationAndRotation(this.ActorComp.ActorLocation, this.ActorComp.ActorRotation, "ConcomitantInherit", false, null);
		}
		if (context.StartCue > 0L)
		{
			BaseGameplayCueComponent component2 = summonEntity.Entity.GetComponent<BaseGameplayCueComponent>();
			if (component2 != null)
			{
				component2.AddCue(context.StartCue, new GameplayCueParam?(new GameplayCueParam
				{
					Instant = true,
					Sync = new bool?(true)
				}));
			}
		}
		if (context.BuffId > 0L)
		{
			CharacterBuffComponent component3 = summonEntity.Entity.GetComponent<CharacterBuffComponent>();
			if (component3 != null)
			{
				component3.AddBuff(context.BuffId, new AddBuffParam
				{
					InstigatorId = this.CreatureDataComponent.GetCreatureDataId(),
					PreMessageId = context.PreMessage,
					Reason = "伴生物继承本体技能表现添加"
				});
			}
		}
		BaseSkillComponent component4 = summonEntity.Entity.GetComponent<BaseSkillComponent>();
		this.ConcomitantInheritMap[context.SummonIndex] = context;
		if (component4 == null)
		{
			return;
		}
		int value = context.SkillId.Value;
		SkillParam skillParam = new SkillParam();
		skillParam.MontageIndex = ((num > -1) ? new int?(num) : null);
		BaseSkillComponent skillComp2 = this.SkillComp;
		Entity target;
		if (skillComp2 == null)
		{
			target = null;
		}
		else
		{
			EntityHandle skillTarget = skillComp2.SkillTarget;
			target = ((skillTarget != null) ? skillTarget.Entity : null);
		}
		skillParam.Target = target;
		skillParam.Reason = "ConcomitantInherit";
		TTimerAction <>9__1;
		Action<UAnimMontage, bool> <>9__2;
		component4.BeginSkillAsync(value, skillParam).ContinueWith(delegate(bool result)
		{
			if (result)
			{
				CharacterAnimationComponent component5 = summonEntity.Entity.GetComponent<CharacterAnimationComponent>();
				if (component5 != null)
				{
					UAnimInstance mainAnimInstance = component5.MainAnimInstance;
					if (mainAnimInstance != null)
					{
						mainAnimInstance.ForceSetCurrentMontageBlendTime(0f, null);
					}
				}
				if (component5 != null)
				{
					component5.MontageSetPosition(currentMontagePosition);
				}
				EConcomitantDurationType concomitantDurationType = context.ConcomitantDurationType;
				if (concomitantDurationType != EConcomitantDurationType.蒙太奇结束消失)
				{
					if (concomitantDurationType == EConcomitantDurationType.固定时间)
					{
						IConcomitantInheritContext context2 = context;
						TimerSystemInstance instance2 = TimerSystem.Instance;
						TTimerAction action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate(float _)
							{
								this.EndConcomitantInherit(context.SummonIndex);
							});
						}
						context2.TimerHandle = instance2.Delay(action, context.Duration, null, null, true, 1f);
						return;
					}
				}
				else
				{
					IConcomitantInheritContext context3 = context;
					UAnimMontage currentMontage;
					if (component5 == null)
					{
						currentMontage = null;
					}
					else
					{
						UAnimInstance mainAnimInstance2 = component5.MainAnimInstance;
						currentMontage = ((mainAnimInstance2 != null) ? mainAnimInstance2.GetCurrentActiveMontage() : null);
					}
					context3.CurrentMontage = currentMontage;
					IConcomitantInheritContext context4 = context;
					Action<UAnimMontage, bool> onMontageEnded;
					if ((onMontageEnded = <>9__2) == null)
					{
						onMontageEnded = (<>9__2 = delegate(UAnimMontage montage, bool bInterrupted)
						{
							if (montage != context.CurrentMontage)
							{
								return;
							}
							this.EndConcomitantInherit(context.SummonIndex);
						});
					}
					context4.OnMontageEnded = onMontageEnded;
					context.SummonAnimComp = component5;
					if (component5 != null)
					{
						UAnimInstance mainAnimInstance3 = component5.MainAnimInstance;
						if (mainAnimInstance3 == null)
						{
							return;
						}
						mainAnimInstance3.OnMontageEnded.Add(context.OnMontageEnded);
					}
				}
			}
		});
	}

	// Token: 0x06017F0D RID: 98061 RVA: 0x007247B8 File Offset: 0x007229B8
	public void EndConcomitantInherit(int summonIndex)
	{
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, base.Entity, "[伴生物继承本体技能表现]结束", default(ReadOnlySpan<ValueTuple<string, object>>));
		IConcomitantInheritContext concomitantInheritContext;
		if (!this.ConcomitantInheritMap.TryGetValue(summonIndex, out concomitantInheritContext))
		{
			return;
		}
		this.ConcomitantInheritMap.Remove(summonIndex);
		TimerHandle timerHandle = concomitantInheritContext.TimerHandle;
		if (timerHandle != null)
		{
			timerHandle.Remove();
		}
		if (concomitantInheritContext.OnMontageEnded != null && concomitantInheritContext.SummonAnimComp != null)
		{
			UAnimInstance mainAnimInstance = concomitantInheritContext.SummonAnimComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(concomitantInheritContext.OnMontageEnded);
			}
			concomitantInheritContext.OnMontageEnded = null;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantCustom, summonIndex);
		if (summonedEntity == null || !summonedEntity.Valid)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = base.Entity;
			string message = "[伴生物继承本体技能表现]伴生物不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SummonIndex", summonIndex);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (concomitantInheritContext.EndCue > 0L)
		{
			BaseGameplayCueComponent component = summonedEntity.Entity.GetComponent<BaseGameplayCueComponent>();
			if (component != null)
			{
				component.AddCue(concomitantInheritContext.EndCue, new GameplayCueParam?(new GameplayCueParam
				{
					Instant = true,
					Sync = new bool?(true)
				}));
			}
		}
		if (concomitantInheritContext.BuffId > 0L)
		{
			CharacterBuffComponent component2 = summonedEntity.Entity.GetComponent<CharacterBuffComponent>();
			if (component2 != null)
			{
				component2.RemoveBuff(concomitantInheritContext.BuffId, -1, "伴生物继承本体技能表现", null, null, null);
			}
		}
		CreatureController.Instance.SetEntityEnable(summonedEntity.Entity, false, "ConcomitantInherit", true);
	}

	// Token: 0x06017F0E RID: 98062 RVA: 0x00724948 File Offset: 0x00722B48
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterFollowComponent characterFollowComponent = (CharacterFollowComponent)componentTemplate;
		if (characterFollowComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (characterFollowComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterFollowComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterFollowComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterFollowComponent.AttributeSharerIdsInternal == null)
		{
			this.AttributeSharerIdsInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeSharerIdsInternal), "AttributeSharerIdsInternal"))
		{
			return false;
		}
		this.AttributeHolderId = characterFollowComponent.AttributeHolderId;
		this.IsVisionSummon = characterFollowComponent.IsVisionSummon;
		if (characterFollowComponent.CurrentConcomitantInherit == null)
		{
			this.CurrentConcomitantInherit = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentConcomitantInherit), "CurrentConcomitantInherit"))
		{
			return false;
		}
		if (characterFollowComponent.ConcomitantInheritMap == null)
		{
			this.ConcomitantInheritMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ConcomitantInheritMap), "ConcomitantInheritMap"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002567 RID: 9575
	// (get) Token: 0x06017F0F RID: 98063 RVA: 0x00724AAD File Offset: 0x00722CAD
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002568 RID: 9576
	// (get) Token: 0x06017F10 RID: 98064 RVA: 0x00724AB0 File Offset: 0x00722CB0
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002569 RID: 9577
	// (get) Token: 0x06017F11 RID: 98065 RVA: 0x00724AB3 File Offset: 0x00722CB3
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CCC9 RID: 52425
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400CCCA RID: 52426
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CCCB RID: 52427
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400CCCC RID: 52428
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400CCCD RID: 52429
	private List<int> AttributeSharerIdsInternal = new List<int>();

	// Token: 0x0400CCCE RID: 52430
	private int AttributeHolderId;

	// Token: 0x0400CCCF RID: 52431
	private bool IsVisionSummon;

	// Token: 0x0400CCD0 RID: 52432
	[Nullable(2)]
	public IConcomitantInheritContext CurrentConcomitantInherit;

	// Token: 0x0400CCD1 RID: 52433
	public Dictionary<int, IConcomitantInheritContext> ConcomitantInheritMap = new Dictionary<int, IConcomitantInheritContext>();
}
