using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Role.FemaleM.Xiakong.Abilities.GA;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x0200270B RID: 9995
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillXiaKong : SpecialSkillBase
{
	// Token: 0x060190BE RID: 102590 RVA: 0x007A0E40 File Offset: 0x0079F040
	[NullableContext(1)]
	public SpecialSkillXiaKong(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x060190BF RID: 102591 RVA: 0x007A0EA0 File Offset: 0x0079F0A0
	public override void OnStart()
	{
		this.Entity = this.SpecialSkillComponent.Entity;
		this.EntityId = this.Entity.Id;
		CreatureDataComponent component = this.Entity.GetComponent<CreatureDataComponent>();
		this.CreatureDataId = component.GetCreatureDataId();
		this.CharacterSkillComponent = this.Entity.GetComponent<CharacterSkillComponent>();
		this.CharacterTimeScaleComponent = this.Entity.GetComponent<CharacterTimeScaleComponent>();
		this.TagComponent = this.Entity.GetComponent<RoleTagComponent>();
		this.AttrComponent = this.Entity.GetComponent<BaseAttributeComponent>();
		this.BuffComponent = this.Entity.GetComponent<RoleBuffComponent>();
		this.TimeScaleCompList = new CharacterTimeScaleComponent[4];
		this.IsAutonomous = (CreatureModel.Instance.GetPlayerId() == component.GetPlayerId());
		if (this.IsAutonomous)
		{
			EventSystem.Instance.AddWithTarget<int, int, bool>(this.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			EventSystem.Instance.AddWithTarget<int, int>(this.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
			EventSystem.Instance.Add(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
			EventSystem.Instance.Add(EEventName.OnBeforeUpdateSceneTeam, new Action<EntityHandle, EntityHandle>(this.OnBeforeUpdateSceneTeam));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		this.InitSummonedEntity();
		this.InitSimulateEntity();
	}

	// Token: 0x060190C0 RID: 102592 RVA: 0x007A100C File Offset: 0x0079F20C
	private void InitSummonedEntity()
	{
		if (!this.IsAutonomous)
		{
			return;
		}
		for (int i = 1; i <= 3; i++)
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(this.Entity, ESummonType.ConcomitantCustom, i);
			if (summonedEntity == null || !summonedEntity.Valid)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = this.Entity;
				string message = "夏空Start获取幻影实体失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pos", i);
				instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SummonedEntityList.Add(null);
				this.SummonedEntityHandleIdList.Add(0);
			}
			else
			{
				this.SummonedEntityList.Add(summonedEntity);
				int item = summonedEntity.Entity.GetComponent<CharacterActorComponent>().DisableActor("夏空幻影Start");
				this.SummonedEntityHandleIdList.Add(item);
			}
		}
		this.Timer = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.CheckSummonedDistance();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x060190C1 RID: 102593 RVA: 0x007A10F4 File Offset: 0x0079F2F4
	public override void OnActivate()
	{
		if (!this.IsAutonomous)
		{
			return;
		}
		for (int i = 0; i < this.SummonedEntityList.Count; i++)
		{
			EntityHandle entityHandle = this.SummonedEntityList[i];
			if (entityHandle == null)
			{
				entityHandle = PhantomUtil.GetSummonedEntity(this.Entity, ESummonType.ConcomitantCustom, i + 1);
			}
			if (entityHandle == null || !entityHandle.Valid)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = this.Entity;
				string message = "夏空Activate获取幻影实体失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pos", i + 1);
				instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				SpecialSkillXiaKongSummoned specialSkillXiaKongSummoned = new SpecialSkillXiaKongSummoned();
				specialSkillXiaKongSummoned.Init(entityHandle);
				this.SummonedList.Add(specialSkillXiaKongSummoned);
				CreatureController.Instance.SetEntityEnable(entityHandle.Entity, true, "夏空幻影初始化", true);
				CreatureController.Instance.SetActorVisible(entityHandle.Entity, false, false, false, "夏空幻影Activate", true);
				if (this.SummonedEntityHandleIdList[i] != 0)
				{
					CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
					if (component != null)
					{
						component.EnableActor(this.SummonedEntityHandleIdList[i]);
					}
				}
			}
		}
	}

	// Token: 0x060190C2 RID: 102594 RVA: 0x007A1204 File Offset: 0x0079F404
	private void InitSimulateEntity()
	{
		if (this.IsAutonomous)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<int, int, int, float>(this.Entity, EEventName.OnSkillSimulateMontage, new Action<int, int, int, float>(this.OnSkillSimulateMontage));
		this.WaitSummonedEntityMap.Clear();
		for (int i = 0; i < 3; i++)
		{
			long num = this.Entity.GetComponent<CreatureDataComponent>().CustomServerEntityIds[i];
			EntityHandle entity = CreatureModel.Instance.GetEntity((long)((int)num));
			if (entity == null || !entity.Valid)
			{
				this.WaitSummonedEntityMap[num] = i;
				this.SummonedEntityList.Add(null);
			}
			else
			{
				this.SummonedEntityList.Add(entity);
				EventSystem.Instance.AddWithTargetUseHoldKey<int, int, int, float>(this, entity.Entity, EEventName.OnSkillSimulateMontage, new Action<int, int, int, float>(this.OnSkillSimulateMontage));
			}
		}
		if (this.WaitSummonedEntityMap.Count > 0)
		{
			EventSystem.Instance.Add<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		}
	}

	// Token: 0x060190C3 RID: 102595 RVA: 0x007A1300 File Offset: 0x0079F500
	[NullableContext(1)]
	private void OnCreateEntity(CreatureDataComponent creatureData, EntityHandle entityHandle)
	{
		long creatureDataId = creatureData.GetCreatureDataId();
		int index;
		if (!this.WaitSummonedEntityMap.TryGetValue(creatureDataId, out index))
		{
			return;
		}
		this.WaitSummonedEntityMap.Remove(creatureDataId);
		this.SummonedEntityList[index] = entityHandle;
		EventSystem.Instance.AddWithTargetUseHoldKey<int, int, int, float>(this, entityHandle.Entity, EEventName.OnSkillSimulateMontage, new Action<int, int, int, float>(this.OnSkillSimulateMontage));
		if (this.WaitSummonedEntityMap.Count <= 0)
		{
			EventSystem.Instance.Remove(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		}
	}

	// Token: 0x060190C4 RID: 102596 RVA: 0x007A138C File Offset: 0x0079F58C
	public override void OnTick(float delta)
	{
		if (this.IsUltraSkillState && this.StartFrame != Time.Instance.Frame)
		{
			this.OnUltraSkillTick(delta * this.GetTimeScale());
		}
		CharacterTimeScaleComponent characterTimeScaleComponent = this.UpdateSummonedTimeScale();
		if (characterTimeScaleComponent != this.LastTimeScaleComp)
		{
			CharacterTimeScaleComponent lastTimeScaleComp = this.LastTimeScaleComp;
			if (lastTimeScaleComp != null && lastTimeScaleComp.Valid)
			{
				this.LastTimeScaleComp.RemoveForceTimeScale("SpecialSkillXiaKong.SummonedSync", false);
			}
			this.LastTimeScaleComp = characterTimeScaleComponent;
		}
	}

	// Token: 0x060190C5 RID: 102597 RVA: 0x007A1400 File Offset: 0x0079F600
	private CharacterTimeScaleComponent UpdateSummonedTimeScale()
	{
		if (this.TimeScaleCompList == null)
		{
			return null;
		}
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(this.EntityId, "VisionId");
		if (intValueByEntity == null || intValueByEntity.Value == 0)
		{
			return null;
		}
		int value = intValueByEntity.Value;
		if (value < 0 || value >= this.TimeScaleCompList.Length)
		{
			return null;
		}
		CharacterTimeScaleComponent characterTimeScaleComponent = this.TimeScaleCompList[value];
		if (characterTimeScaleComponent == null)
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(this.Entity, ESummonType.ConcomitantCustom, value);
			if (summonedEntity == null || !summonedEntity.Valid)
			{
				return null;
			}
			WorldEntity entity = summonedEntity.Entity;
			characterTimeScaleComponent = ((entity != null) ? entity.GetComponent<CharacterTimeScaleComponent>() : null);
			if (characterTimeScaleComponent != null)
			{
				this.TimeScaleCompList[value] = characterTimeScaleComponent;
			}
		}
		if (characterTimeScaleComponent != null)
		{
			characterTimeScaleComponent.AddForceTimeScale(this.CharacterTimeScaleComponent.CurrentTimeScale, "SpecialSkillXiaKong.SummonedSync", false, ETimeScaleSourceType.InnerForceTimeScale);
			return characterTimeScaleComponent;
		}
		return null;
	}

	// Token: 0x060190C6 RID: 102598 RVA: 0x007A14C8 File Offset: 0x0079F6C8
	private void CheckSummonedDistance()
	{
		if (!this.IsAutonomous)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		global::Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		foreach (EntityHandle entityHandle in this.SummonedEntityList)
		{
			if (entityHandle != null && entityHandle.Valid)
			{
				WorldEntity entity = entityHandle.Entity;
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null && baseActorComponent.DisableActorHandle.Empty && global::Vector.DistSquared(baseActorComponent.ActorLocationProxy, vector2) > 900000000.0)
				{
					CharacterSkillComponent component = entityHandle.Entity.GetComponent<CharacterSkillComponent>();
					if (component != null)
					{
						component.StopAllSkills("幻影距离主体过远");
					}
				}
			}
		}
	}

	// Token: 0x060190C7 RID: 102599 RVA: 0x007A15AC File Offset: 0x0079F7AC
	public override void OnEnd()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
		if (this.IsAutonomous)
		{
			if (this.IsUltraSkillState)
			{
				EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiSpecialSkillEnableChanged, this.Entity.Id, 1407, false);
				this.IsUltraSkillState = false;
			}
			EventSystem.Instance.Remove(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
			EventSystem.Instance.Remove(EEventName.OnBeforeUpdateSceneTeam, new Action<EntityHandle, EntityHandle>(this.OnBeforeUpdateSceneTeam));
			EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			if (this.Entity != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, int, bool>(this.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
				EventSystem.Instance.RemoveWithTarget<int, int>(this.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
				this.Entity = null;
			}
			foreach (SpecialSkillXiaKongSummoned specialSkillXiaKongSummoned in this.SummonedList)
			{
				specialSkillXiaKongSummoned.Destroy();
			}
			this.SummonedList.Clear();
		}
		else
		{
			if (EventSystem.Instance.Has(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity)))
			{
				EventSystem.Instance.Remove(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
			}
			foreach (EntityHandle entityHandle in this.SummonedEntityList)
			{
				if (((entityHandle != null) ? entityHandle.Entity : null) != null)
				{
					EventSystem.Instance.RemoveWithTargetUseKey<int, int, int, float>(this, entityHandle.Entity, EEventName.OnSkillSimulateMontage, new Action<int, int, int, float>(this.OnSkillSimulateMontage));
				}
			}
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			if (this.Entity != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, int, int, float>(this.Entity, EEventName.OnSkillSimulateMontage, new Action<int, int, int, float>(this.OnSkillSimulateMontage));
				this.Entity = null;
			}
		}
		this.SummonedEntityList.Clear();
		this.CharacterSkillComponent = null;
		this.CharacterTimeScaleComponent = null;
		this.UltraSkill = null;
		this.TimeScaleCompList = null;
	}

	// Token: 0x060190C8 RID: 102600 RVA: 0x007A180C File Offset: 0x0079FA0C
	private void OnCharUseSkill(int entityId, int skillId, bool isAutonomousProxy)
	{
		if (skillId != 1407200)
		{
			return;
		}
		this.IsUltraSkillState = true;
		this.StartFrame = Time.Instance.Frame;
		CharacterSkillComponent characterSkillComponent = this.CharacterSkillComponent;
		this.UltraSkill = ((characterSkillComponent != null) ? characterSkillComponent.GetSkill(1407200) : null);
		if (this.BuffList.Count == 0)
		{
			CharacterSkillComponent characterSkillComponent2 = this.CharacterSkillComponent;
			TArray<long> tarray;
			if (characterSkillComponent2 == null)
			{
				tarray = null;
			}
			else
			{
				SSkillInfo skillInfo = characterSkillComponent2.GetSkillInfo(1407200);
				tarray = ((skillInfo != null) ? skillInfo.SpecialBuffInCode : null);
			}
			TArray<long> tarray2 = tarray;
			if (tarray2 != null && tarray2.Num() > 0)
			{
				for (int i = 0; i < tarray2.Num(); i++)
				{
					long num = tarray2.Get(i);
					if (num != 0L)
					{
						this.BuffList.Add(num);
					}
				}
			}
		}
		this.OnUltraSkillBegin();
	}

	// Token: 0x060190C9 RID: 102601 RVA: 0x007A18C1 File Offset: 0x0079FAC1
	private void OnSkillEnd(int entityId, int skillId)
	{
		if (skillId != 1407200)
		{
			return;
		}
		this.IsUltraSkillState = false;
		this.OnUltraSkillEnd();
	}

	// Token: 0x060190CA RID: 102602 RVA: 0x007A18DC File Offset: 0x0079FADC
	private void OnSkillSimulateMontage(int entityId, int skillId, int montageIndex, float startTimeSeconds)
	{
		foreach (EntityHandle entityHandle in this.SummonedEntityList)
		{
			if (entityHandle != null)
			{
				WorldEntity entity = entityHandle.Entity;
				int? num = (entity != null) ? new int?(entity.Id) : null;
				if (num.GetValueOrDefault() == entityId & num != null)
				{
					CreatureController.Instance.SetActorMovable(entityHandle.Entity, true, "同步幻影技能动作");
					break;
				}
			}
		}
		if (skillId != 1407004)
		{
			return;
		}
		if (startTimeSeconds < 22.333334f)
		{
			return;
		}
		float num2 = 18.333334f;
		float position = startTimeSeconds - MathF.Floor((startTimeSeconds - 4f) / num2) * num2;
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.MontageSetPosition(position);
		}
	}

	// Token: 0x060190CB RID: 102603 RVA: 0x007A19D0 File Offset: 0x0079FBD0
	[NullableContext(1)]
	private void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x060190CC RID: 102604 RVA: 0x007A19DE File Offset: 0x0079FBDE
	private void OnBeforeUpdateSceneTeam(EntityHandle newEntity, EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x060190CD RID: 102605 RVA: 0x007A19EC File Offset: 0x0079FBEC
	private void StopUltraSkillBeforeChangeRole(EntityHandle newEntity)
	{
		if (!this.IsUltraSkillState)
		{
			return;
		}
		if (((newEntity != null) ? newEntity.Entity : null) == this.Entity)
		{
			float nextEndCircleAttrValue = this.GetNextEndCircleAttrValue(0);
			if (nextEndCircleAttrValue >= 22857f && nextEndCircleAttrValue < 30000f)
			{
				this.OnResult(true, false);
			}
			Entity entity = this.Entity;
			if (entity == null)
			{
				return;
			}
			RoleTeamComponent component = entity.GetComponent<RoleTeamComponent>();
			if (component == null)
			{
				return;
			}
			component.DisableRoleWithoutEffect();
		}
	}

	// Token: 0x060190CE RID: 102606 RVA: 0x007A1A50 File Offset: 0x0079FC50
	[NullableContext(1)]
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		bool flag = newEntity.Entity == this.Entity;
		if (this.IsForeground == flag)
		{
			return;
		}
		this.IsForeground = flag;
		if (!this.IsUltraSkillState)
		{
			return;
		}
		if (this.IsForeground)
		{
			Skill ultraSkill = this.UltraSkill;
			GA_Xiakong_Burst_C ga_Xiakong_Burst_C = ((ultraSkill != null) ? ultraSkill.ActiveAbility : null) as GA_Xiakong_Burst_C;
			if (ga_Xiakong_Burst_C != null)
			{
				ga_Xiakong_Burst_C.SetIsInterrupt(true);
			}
			CharacterSkillComponent characterSkillComponent = this.CharacterSkillComponent;
			if (characterSkillComponent == null)
			{
				return;
			}
			characterSkillComponent.EndSkill(1407200, "夏空大招从后台切回来");
		}
	}

	// Token: 0x060190CF RID: 102607 RVA: 0x007A1ACB File Offset: 0x0079FCCB
	private float GetTimeScale()
	{
		if (this.Entity == null || this.CharacterTimeScaleComponent == null)
		{
			return 1f;
		}
		return this.Entity.TimeDilation * this.CharacterTimeScaleComponent.CurrentTimeScale;
	}

	// Token: 0x060190D0 RID: 102608 RVA: 0x007A1AFC File Offset: 0x0079FCFC
	private void OnUltraSkillBegin()
	{
		this.NextGenCircleIndex = 0;
		this.NextEndCircleIndex = 0;
		this.GenBuffList.Clear();
		this.CircleSpeed = 14.285714f;
		RoleTagComponent tagComponent = this.TagComponent;
		this.IsForeground = (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]));
		this.CircleGenCountDown = 2332f * this.CircleSpeed;
		this.TotalTime = 0f;
		this.InputType = 0;
		this.IsStopGenCircle = false;
		this.InputStartCountDown = 3664f;
		this.ColorType = 1;
		RoleTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 != null)
		{
			tagComponent2.TagContainer.UpdateExactTag(ETagChannel.Common, GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"], 1);
		}
		EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiSpecialSkillEnableChanged, this.Entity.Id, 1407, true);
	}

	// Token: 0x060190D1 RID: 102609 RVA: 0x007A1BDC File Offset: 0x0079FDDC
	private void OnUltraSkillTick(float delta)
	{
		if (!this.IsStopGenCircle)
		{
			this.TotalTime += delta;
			if (this.TotalTime > 34000f)
			{
				this.IsStopGenCircle = true;
			}
		}
		if (this.InputStartCountDown > 0f)
		{
			this.InputStartCountDown -= delta;
		}
		float addValue = this.CircleSpeed * delta;
		this.AddAttrValue(EAttributeType.SpecialEnergy1, addValue);
		this.AddAttrValue(EAttributeType.SpecialEnergy2, addValue);
		this.CheckInput();
		this.ClearInputType();
		this.CheckCircleGen(delta);
	}

	// Token: 0x060190D2 RID: 102610 RVA: 0x007A1C5C File Offset: 0x0079FE5C
	private void OnUltraSkillEnd()
	{
		for (int i = this.NextEndCircleIndex; i < this.NextGenCircleIndex; i++)
		{
			long buffId = this.GenBuffList[i];
			RoleBuffComponent buffComponent = this.BuffComponent;
			if (buffComponent != null)
			{
				buffComponent.RemoveBuff(buffId, 1, "夏空大招结束清理", this.UltraSkill.CombatMessageId, null, null);
			}
		}
		this.NextEndCircleIndex = this.NextGenCircleIndex;
		RoleTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.TagContainer.UpdateExactTag(ETagChannel.Common, GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"], -1);
		}
		EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiSpecialSkillEnableChanged, this.Entity.Id, 1407, false);
	}

	// Token: 0x060190D3 RID: 102611 RVA: 0x007A1D18 File Offset: 0x0079FF18
	private void CheckInput()
	{
		if (this.NextEndCircleIndex >= this.NextGenCircleIndex)
		{
			return;
		}
		float nextEndCircleAttrValue = this.GetNextEndCircleAttrValue(0);
		if (!this.IsForeground)
		{
			if (nextEndCircleAttrValue >= 25000f)
			{
				this.OnResult(true, true);
			}
			return;
		}
		int inputType = this.GetInputType();
		if (inputType <= 0)
		{
			if (nextEndCircleAttrValue >= 30000f)
			{
				this.OnResult(false, false);
			}
			return;
		}
		if ((inputType == 1 || inputType == 2) && nextEndCircleAttrValue <= 30000f && nextEndCircleAttrValue >= 22857f)
		{
			this.ColorType = inputType;
			this.OnResult(true, false);
		}
	}

	// Token: 0x060190D4 RID: 102612 RVA: 0x007A1D98 File Offset: 0x0079FF98
	private void CheckCircleGen(float delta)
	{
		if (this.IsStopGenCircle)
		{
			return;
		}
		this.CircleGenCountDown -= delta * this.CircleSpeed;
		if (this.CircleGenCountDown > 0f)
		{
			return;
		}
		if (this.CreateNewCircle())
		{
			this.CircleGenCountDown = ((this.NextGenCircleIndex == 1) ? (1332f * this.CircleSpeed) : 23285.7f);
		}
	}

	// Token: 0x060190D5 RID: 102613 RVA: 0x007A1DFB File Offset: 0x0079FFFB
	private int GetAttrIndex(int circleIndex)
	{
		return circleIndex % 2;
	}

	// Token: 0x060190D6 RID: 102614 RVA: 0x007A1E00 File Offset: 0x007A0000
	private EAttributeType GetAttrId(int attrIndex)
	{
		return EAttributeType.SpecialEnergy1 + attrIndex * 2;
	}

	// Token: 0x060190D7 RID: 102615 RVA: 0x007A1E08 File Offset: 0x007A0008
	private long GetBuffId(int attrIndex)
	{
		List<long> buffList = this.BuffList;
		if (buffList.Count <= attrIndex || buffList[attrIndex] == 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "[SpecialSkillXiaKong]不存在对应buff";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", attrIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0L;
		}
		return buffList[attrIndex];
	}

	// Token: 0x060190D8 RID: 102616 RVA: 0x007A1E68 File Offset: 0x007A0068
	private bool CreateNewCircle()
	{
		if (this.NextGenCircleIndex - this.NextEndCircleIndex >= 2)
		{
			return false;
		}
		int attrIndex = this.GetAttrIndex(this.NextGenCircleIndex);
		EAttributeType attrId = this.GetAttrId(attrIndex);
		BaseAttributeComponent attrComponent = this.AttrComponent;
		if (attrComponent != null)
		{
			attrComponent.SetBaseValue(attrId, 0f);
		}
		long buffId = this.GetBuffId(attrIndex);
		this.GenBuffList.Add(buffId);
		long? combatMessageId = this.UltraSkill.CombatMessageId;
		RoleBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.AddBuff(buffId, new AddBuffParam
			{
				InstigatorId = this.CreatureDataId,
				Reason = "夏空大招逻辑添加",
				PreMessageId = combatMessageId
			});
		}
		this.NextGenCircleIndex++;
		return true;
	}

	// Token: 0x060190D9 RID: 102617 RVA: 0x007A1F18 File Offset: 0x007A0118
	private void DestroyNextEndCircle()
	{
		int nextEndCircleIndex = this.NextEndCircleIndex;
		int nextGenCircleIndex = this.NextGenCircleIndex;
		long buffId = this.GenBuffList[this.NextEndCircleIndex];
		RoleBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.RemoveBuff(buffId, 1, "夏空大招逻辑移除", this.UltraSkill.CombatMessageId, null, null);
		}
		this.NextEndCircleIndex++;
	}

	// Token: 0x060190DA RID: 102618 RVA: 0x007A1F88 File Offset: 0x007A0188
	public float GetNextEndCircleAttrValue(int nextIndex = 0)
	{
		int attrIndex = this.GetAttrIndex(this.NextEndCircleIndex + nextIndex);
		EAttributeType attrId = this.GetAttrId(attrIndex);
		BaseAttributeComponent attrComponent = this.AttrComponent;
		if (attrComponent == null)
		{
			return 0f;
		}
		return attrComponent.GetCurrentValue(attrId);
	}

	// Token: 0x060190DB RID: 102619 RVA: 0x007A1FC2 File Offset: 0x007A01C2
	private void OnResult(bool isSucceed, bool isAuto = false)
	{
		this.DestroyNextEndCircle();
		Skill ultraSkill = this.UltraSkill;
		GA_Xiakong_Burst_C ga_Xiakong_Burst_C = ((ultraSkill != null) ? ultraSkill.ActiveAbility : null) as GA_Xiakong_Burst_C;
		if (ga_Xiakong_Burst_C == null)
		{
			return;
		}
		ga_Xiakong_Burst_C.判定结果(isSucceed, isAuto, this.ColorType);
	}

	// Token: 0x060190DC RID: 102620 RVA: 0x007A1FF4 File Offset: 0x007A01F4
	private void AddAttrValue(EAttributeType attrId, float addValue)
	{
		if (this.AttrComponent == null)
		{
			return;
		}
		float value = this.AttrComponent.GetCurrentValue(attrId) + addValue;
		this.AttrComponent.SetBaseValue(attrId, value);
	}

	// Token: 0x060190DD RID: 102621 RVA: 0x007A2026 File Offset: 0x007A0226
	private void ClearInputType()
	{
		this.InputType = 0;
	}

	// Token: 0x060190DE RID: 102622 RVA: 0x007A202F File Offset: 0x007A022F
	private int GetInputType()
	{
		return this.InputType;
	}

	// Token: 0x060190DF RID: 102623 RVA: 0x007A2038 File Offset: 0x007A0238
	public void SetInputType(int inputType)
	{
		if (!this.IsUltraSkillState || this.InputStartCountDown > 0f)
		{
			return;
		}
		if (inputType == 4)
		{
			this.InputType = 0;
			if (this.UltraSkill != null && this.NextGenCircleIndex > 0)
			{
				GA_Xiakong_Burst_C ga_Xiakong_Burst_C = this.UltraSkill.ActiveAbility as GA_Xiakong_Burst_C;
				if (ga_Xiakong_Burst_C != null)
				{
					ga_Xiakong_Burst_C.SetIsInterrupt(true);
				}
				CharacterSkillComponent characterSkillComponent = this.CharacterSkillComponent;
				if (characterSkillComponent != null)
				{
					characterSkillComponent.EndSkill(1407200, "夏空大招主动按键结束");
				}
				CharacterSkillComponent characterSkillComponent2 = this.CharacterSkillComponent;
				if (characterSkillComponent2 == null)
				{
					return;
				}
				characterSkillComponent2.BeginSkill(1407201, new SkillParam
				{
					Reason = "夏空主动结束大招触发"
				});
			}
			return;
		}
		this.InputType = inputType;
	}

	// Token: 0x060190E0 RID: 102624 RVA: 0x007A20DC File Offset: 0x007A02DC
	public float GetMinAttrValue()
	{
		return 22857f;
	}

	// Token: 0x060190E1 RID: 102625 RVA: 0x007A20E3 File Offset: 0x007A02E3
	public int GetNextGenCircleIndex()
	{
		return this.NextGenCircleIndex;
	}

	// Token: 0x060190E2 RID: 102626 RVA: 0x007A20EB File Offset: 0x007A02EB
	public int GetNextEndCircleIndex()
	{
		return this.NextEndCircleIndex;
	}

	// Token: 0x060190E3 RID: 102627 RVA: 0x007A20F3 File Offset: 0x007A02F3
	public bool GetIsUltraSkillState()
	{
		return this.IsUltraSkillState;
	}

	// Token: 0x0400DA87 RID: 55943
	private const float CHECK_DISTANCE_INTERVAL = 1000f;

	// Token: 0x0400DA88 RID: 55944
	private const float MAX_DISTANCE_SQUARED = 900000000f;

	// Token: 0x0400DA89 RID: 55945
	private const int ULTRA_SKILL_ID = 1407200;

	// Token: 0x0400DA8A RID: 55946
	private const int ULTRA_SECOND_SKILL_ID = 1407201;

	// Token: 0x0400DA8B RID: 55947
	private const int LOOP_SKILL_ID = 1407004;

	// Token: 0x0400DA8C RID: 55948
	private const float LOOP_START_TIME = 4f;

	// Token: 0x0400DA8D RID: 55949
	private const float LOOP_END_TIME = 22.333334f;

	// Token: 0x0400DA8E RID: 55950
	private const int CIRCLE_NUM = 2;

	// Token: 0x0400DA8F RID: 55951
	private const float MAX_ATRR_VALUE = 30000f;

	// Token: 0x0400DA90 RID: 55952
	private const float SUCC_MAX_ATTR_VALUE = 30000f;

	// Token: 0x0400DA91 RID: 55953
	private const float SUCC_MIN_ATTR_VALUE = 22857f;

	// Token: 0x0400DA92 RID: 55954
	private const float SUCC_BACKSTAGE_ATRR_VALUE = 25000f;

	// Token: 0x0400DA93 RID: 55955
	private const float CIRCLE_SPEED_INIT = 14.285714f;

	// Token: 0x0400DA94 RID: 55956
	private const float FRIST_CIRCLE_TIME = 2332f;

	// Token: 0x0400DA95 RID: 55957
	private const float SECOND_CIRCLE_TIME = 1332f;

	// Token: 0x0400DA96 RID: 55958
	private const float CIRCLE_INTERVAL = 23285.7f;

	// Token: 0x0400DA97 RID: 55959
	private const float ULTRA_SKILL_TOTAL_TIME = 34000f;

	// Token: 0x0400DA98 RID: 55960
	private const float INPUT_START_TIME = 3664f;

	// Token: 0x0400DA99 RID: 55961
	[Nullable(1)]
	private const string FORCE_TIME_SCALE_LOCK_KEY = "SpecialSkillXiaKong.SummonedSync";

	// Token: 0x0400DA9A RID: 55962
	private Entity Entity;

	// Token: 0x0400DA9B RID: 55963
	private int EntityId;

	// Token: 0x0400DA9C RID: 55964
	private long CreatureDataId;

	// Token: 0x0400DA9D RID: 55965
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400DA9E RID: 55966
	private CharacterTimeScaleComponent CharacterTimeScaleComponent;

	// Token: 0x0400DA9F RID: 55967
	private RoleTagComponent TagComponent;

	// Token: 0x0400DAA0 RID: 55968
	private BaseAttributeComponent AttrComponent;

	// Token: 0x0400DAA1 RID: 55969
	private RoleBuffComponent BuffComponent;

	// Token: 0x0400DAA2 RID: 55970
	private Skill UltraSkill;

	// Token: 0x0400DAA3 RID: 55971
	private bool IsUltraSkillState;

	// Token: 0x0400DAA4 RID: 55972
	private int StartFrame;

	// Token: 0x0400DAA5 RID: 55973
	private CharacterTimeScaleComponent LastTimeScaleComp;

	// Token: 0x0400DAA6 RID: 55974
	private CharacterTimeScaleComponent[] TimeScaleCompList;

	// Token: 0x0400DAA7 RID: 55975
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityHandle> SummonedEntityList = new List<EntityHandle>();

	// Token: 0x0400DAA8 RID: 55976
	[Nullable(1)]
	private readonly List<int> SummonedEntityHandleIdList = new List<int>();

	// Token: 0x0400DAA9 RID: 55977
	[Nullable(1)]
	private readonly List<SpecialSkillXiaKongSummoned> SummonedList = new List<SpecialSkillXiaKongSummoned>();

	// Token: 0x0400DAAA RID: 55978
	private TimerHandle Timer;

	// Token: 0x0400DAAB RID: 55979
	private bool IsAutonomous;

	// Token: 0x0400DAAC RID: 55980
	[Nullable(1)]
	private readonly List<long> BuffList = new List<long>();

	// Token: 0x0400DAAD RID: 55981
	private int NextGenCircleIndex;

	// Token: 0x0400DAAE RID: 55982
	private int NextEndCircleIndex;

	// Token: 0x0400DAAF RID: 55983
	[Nullable(1)]
	private readonly List<long> GenBuffList = new List<long>();

	// Token: 0x0400DAB0 RID: 55984
	private float CircleSpeed;

	// Token: 0x0400DAB1 RID: 55985
	private bool IsForeground;

	// Token: 0x0400DAB2 RID: 55986
	private float CircleGenCountDown;

	// Token: 0x0400DAB3 RID: 55987
	private float TotalTime;

	// Token: 0x0400DAB4 RID: 55988
	private int InputType;

	// Token: 0x0400DAB5 RID: 55989
	private bool IsStopGenCircle;

	// Token: 0x0400DAB6 RID: 55990
	private float InputStartCountDown;

	// Token: 0x0400DAB7 RID: 55991
	private int ColorType = 1;

	// Token: 0x0400DAB8 RID: 55992
	[Nullable(1)]
	private readonly Dictionary<long, int> WaitSummonedEntityMap = new Dictionary<long, int>();
}
