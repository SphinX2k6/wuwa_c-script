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

// Token: 0x0200305C RID: 12380
[NullableContext(1)]
[Nullable(0)]
public class CharacterFollowComponent : EntityComponent
{
	// Token: 0x17002441 RID: 9281
	// (get) Token: 0x0601A54E RID: 107854 RVA: 0x006FCE15 File Offset: 0x006FB015
	public List<int> AttributeSharerIds
	{
		get
		{
			return this.AttributeSharerIdsInternal;
		}
	}

	// Token: 0x0601A54F RID: 107855 RVA: 0x006FCE20 File Offset: 0x006FB020
	protected override bool OnStart()
	{
		this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.SkillComp = base.Entity.GetComponent<BaseSkillComponent>();
		return true;
	}

	// Token: 0x0601A550 RID: 107856 RVA: 0x006FCE72 File Offset: 0x006FB072
	protected override void OnActivate()
	{
		this.InitFollowData();
	}

	// Token: 0x0601A551 RID: 107857 RVA: 0x006FCE7A File Offset: 0x006FB07A
	protected override bool OnEnd()
	{
		this.RemoveFromAttributeHolder();
		return true;
	}

	// Token: 0x0601A552 RID: 107858 RVA: 0x006FCE84 File Offset: 0x006FB084
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

	// Token: 0x0601A553 RID: 107859 RVA: 0x006FCED8 File Offset: 0x006FB0D8
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

	// Token: 0x0601A554 RID: 107860 RVA: 0x006FCF14 File Offset: 0x006FB114
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

	// Token: 0x0601A555 RID: 107861 RVA: 0x006FCFA0 File Offset: 0x006FB1A0
	public TArray<AActor> GetFollowActor()
	{
		return this.GetAttributeSharerActors();
	}

	// Token: 0x0601A556 RID: 107862 RVA: 0x006FCFA8 File Offset: 0x006FB1A8
	public void SetAttributeSharerId(int id)
	{
		if (this.AttributeSharerIdsInternal.IndexOf(id) == -1)
		{
			this.AttributeSharerIdsInternal.Add(id);
		}
	}

	// Token: 0x0601A557 RID: 107863 RVA: 0x006FCFC5 File Offset: 0x006FB1C5
	public void SetFollowId(int id)
	{
		this.SetAttributeSharerId(id);
	}

	// Token: 0x0601A558 RID: 107864 RVA: 0x006FCFD0 File Offset: 0x006FB1D0
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

	// Token: 0x0601A559 RID: 107865 RVA: 0x006FD028 File Offset: 0x006FB228
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

	// Token: 0x0601A55A RID: 107866 RVA: 0x006FD0DF File Offset: 0x006FB2DF
	[NullableContext(2)]
	public Entity GetAttributeHolderExceptVisionSummon()
	{
		if (this.IsVisionSummon)
		{
			return null;
		}
		return this.GetAttributeHolder();
	}

	// Token: 0x0601A55B RID: 107867 RVA: 0x006FD0F1 File Offset: 0x006FB2F1
	public void Reset(int entityId = 0)
	{
		this.DeleteAttributeSharerId(entityId);
		this.AttributeHolderId = 0;
	}

	// Token: 0x0601A55C RID: 107868 RVA: 0x006FD104 File Offset: 0x006FB304
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

	// Token: 0x0601A55D RID: 107869 RVA: 0x006FD190 File Offset: 0x006FB390
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

	// Token: 0x0601A55E RID: 107870 RVA: 0x006FD350 File Offset: 0x006FB550
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

	// Token: 0x0601A55F RID: 107871 RVA: 0x006FD389 File Offset: 0x006FB589
	private void DeleteFollowId(int entityId)
	{
		this.DeleteAttributeSharerId(entityId);
	}

	// Token: 0x0601A560 RID: 107872 RVA: 0x006FD392 File Offset: 0x006FB592
	public void SetRelationship(EntityHandle summoner)
	{
		this.SetAttributeHolderId(summoner.Id);
		summoner.Entity.GetComponent<CharacterFollowComponent>().SetAttributeSharerId(base.Entity.Id);
		EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnCharacterSetMaster, summoner.Id);
	}

	// Token: 0x0601A561 RID: 107873 RVA: 0x006FD3D4 File Offset: 0x006FB5D4
	public void ListenConcomitantInherit(IConcomitantInheritContext context)
	{
		this.CurrentConcomitantInherit = context;
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharBeforeInterrupt));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnCharBeforeInterruptWithTarget));
	}

	// Token: 0x0601A562 RID: 107874 RVA: 0x006FD428 File Offset: 0x006FB628
	public void RemoveListenConcomitantInherit()
	{
		this.CurrentConcomitantInherit = null;
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharBeforeInterrupt));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnCharBeforeInterruptWithTarget));
	}

	// Token: 0x0601A563 RID: 107875 RVA: 0x006FD47C File Offset: 0x006FB67C
	private void OnCharBeforeInterrupt(int entityId, int interruptedSkillId)
	{
		this.CheckStartConcomitantInherit(interruptedSkillId, null);
	}

	// Token: 0x0601A564 RID: 107876 RVA: 0x006FD499 File Offset: 0x006FB699
	private void OnCharBeforeInterruptWithTarget(int newSkillId, int interruptedSkillId)
	{
		this.CheckStartConcomitantInherit(interruptedSkillId, new int?(newSkillId));
	}

	// Token: 0x0601A565 RID: 107877 RVA: 0x006FD4A8 File Offset: 0x006FB6A8
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

	// Token: 0x0601A566 RID: 107878 RVA: 0x006FD5A4 File Offset: 0x006FB7A4
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

	// Token: 0x0601A567 RID: 107879 RVA: 0x006FD850 File Offset: 0x006FBA50
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

	// Token: 0x0601A568 RID: 107880 RVA: 0x006FD9E0 File Offset: 0x006FBBE0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterFollowComponent characterFollowComponent = (CharacterFollowComponent)componentTemplate;
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (characterFollowComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterFollowComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterFollowComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterFollowComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeSharerIdsInternal"))
		{
			if (characterFollowComponent.AttributeSharerIdsInternal == null)
			{
				this.AttributeSharerIdsInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.AttributeSharerIdsInternal), "AttributeSharerIdsInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeHolderId"))
		{
			this.AttributeHolderId = characterFollowComponent.AttributeHolderId;
		}
		if (base.CanResetComponentProperty("IsVisionSummon"))
		{
			this.IsVisionSummon = characterFollowComponent.IsVisionSummon;
		}
		if (base.CanResetComponentProperty("CurrentConcomitantInherit"))
		{
			if (characterFollowComponent.CurrentConcomitantInherit == null)
			{
				this.CurrentConcomitantInherit = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IConcomitantInheritContext>(this.CurrentConcomitantInherit), "CurrentConcomitantInherit"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ConcomitantInheritMap"))
		{
			if (characterFollowComponent.ConcomitantInheritMap == null)
			{
				this.ConcomitantInheritMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, IConcomitantInheritContext>>(this.ConcomitantInheritMap), "ConcomitantInheritMap"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400C8EF RID: 51439
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400C8F0 RID: 51440
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400C8F1 RID: 51441
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400C8F2 RID: 51442
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400C8F3 RID: 51443
	private List<int> AttributeSharerIdsInternal = new List<int>();

	// Token: 0x0400C8F4 RID: 51444
	private int AttributeHolderId;

	// Token: 0x0400C8F5 RID: 51445
	private bool IsVisionSummon;

	// Token: 0x0400C8F6 RID: 51446
	[Nullable(2)]
	public IConcomitantInheritContext CurrentConcomitantInherit;

	// Token: 0x0400C8F7 RID: 51447
	public Dictionary<int, IConcomitantInheritContext> ConcomitantInheritMap = new Dictionary<int, IConcomitantInheritContext>();
}
