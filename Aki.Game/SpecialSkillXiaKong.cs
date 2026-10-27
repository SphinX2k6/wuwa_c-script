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

// Token: 0x0200319D RID: 12701
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillXiaKong : SpecialSkillBase
{
	// Token: 0x0601B59E RID: 112030 RVA: 0x00778BB4 File Offset: 0x00776DB4
	[NullableContext(1)]
	public SpecialSkillXiaKong(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B59F RID: 112031 RVA: 0x00778C14 File Offset: 0x00776E14
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

	// Token: 0x0601B5A0 RID: 112032 RVA: 0x00778D80 File Offset: 0x00776F80
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

	// Token: 0x0601B5A1 RID: 112033 RVA: 0x00778E68 File Offset: 0x00777068
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

	// Token: 0x0601B5A2 RID: 112034 RVA: 0x00778F78 File Offset: 0x00777178
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

	// Token: 0x0601B5A3 RID: 112035 RVA: 0x00779074 File Offset: 0x00777274
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

	// Token: 0x0601B5A4 RID: 112036 RVA: 0x00779100 File Offset: 0x00777300
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

	// Token: 0x0601B5A5 RID: 112037 RVA: 0x00779174 File Offset: 0x00777374
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

	// Token: 0x0601B5A6 RID: 112038 RVA: 0x0077923C File Offset: 0x0077743C
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

	// Token: 0x0601B5A7 RID: 112039 RVA: 0x00779320 File Offset: 0x00777520
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

	// Token: 0x0601B5A8 RID: 112040 RVA: 0x00779580 File Offset: 0x00777780
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

	// Token: 0x0601B5A9 RID: 112041 RVA: 0x00779635 File Offset: 0x00777835
	private void OnSkillEnd(int entityId, int skillId)
	{
		if (skillId != 1407200)
		{
			return;
		}
		this.IsUltraSkillState = false;
		this.OnUltraSkillEnd();
	}

	// Token: 0x0601B5AA RID: 112042 RVA: 0x00779650 File Offset: 0x00777850
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

	// Token: 0x0601B5AB RID: 112043 RVA: 0x00779744 File Offset: 0x00777944
	[NullableContext(1)]
	private void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x0601B5AC RID: 112044 RVA: 0x00779752 File Offset: 0x00777952
	private void OnBeforeUpdateSceneTeam(EntityHandle newEntity, EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x0601B5AD RID: 112045 RVA: 0x00779760 File Offset: 0x00777960
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

	// Token: 0x0601B5AE RID: 112046 RVA: 0x007797C4 File Offset: 0x007779C4
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

	// Token: 0x0601B5AF RID: 112047 RVA: 0x0077983F File Offset: 0x00777A3F
	private float GetTimeScale()
	{
		if (this.Entity == null || this.CharacterTimeScaleComponent == null)
		{
			return 1f;
		}
		return this.Entity.TimeDilation * this.CharacterTimeScaleComponent.CurrentTimeScale;
	}

	// Token: 0x0601B5B0 RID: 112048 RVA: 0x00779870 File Offset: 0x00777A70
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

	// Token: 0x0601B5B1 RID: 112049 RVA: 0x00779950 File Offset: 0x00777B50
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

	// Token: 0x0601B5B2 RID: 112050 RVA: 0x007799D0 File Offset: 0x00777BD0
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

	// Token: 0x0601B5B3 RID: 112051 RVA: 0x00779A8C File Offset: 0x00777C8C
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

	// Token: 0x0601B5B4 RID: 112052 RVA: 0x00779B0C File Offset: 0x00777D0C
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

	// Token: 0x0601B5B5 RID: 112053 RVA: 0x00779B6F File Offset: 0x00777D6F
	private int GetAttrIndex(int circleIndex)
	{
		return circleIndex % 2;
	}

	// Token: 0x0601B5B6 RID: 112054 RVA: 0x00779B74 File Offset: 0x00777D74
	private EAttributeType GetAttrId(int attrIndex)
	{
		return EAttributeType.SpecialEnergy1 + attrIndex * 2;
	}

	// Token: 0x0601B5B7 RID: 112055 RVA: 0x00779B7C File Offset: 0x00777D7C
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

	// Token: 0x0601B5B8 RID: 112056 RVA: 0x00779BDC File Offset: 0x00777DDC
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

	// Token: 0x0601B5B9 RID: 112057 RVA: 0x00779C8C File Offset: 0x00777E8C
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

	// Token: 0x0601B5BA RID: 112058 RVA: 0x00779CFC File Offset: 0x00777EFC
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

	// Token: 0x0601B5BB RID: 112059 RVA: 0x00779D36 File Offset: 0x00777F36
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

	// Token: 0x0601B5BC RID: 112060 RVA: 0x00779D68 File Offset: 0x00777F68
	private void AddAttrValue(EAttributeType attrId, float addValue)
	{
		if (this.AttrComponent == null)
		{
			return;
		}
		float value = this.AttrComponent.GetCurrentValue(attrId) + addValue;
		this.AttrComponent.SetBaseValue(attrId, value);
	}

	// Token: 0x0601B5BD RID: 112061 RVA: 0x00779D9A File Offset: 0x00777F9A
	private void ClearInputType()
	{
		this.InputType = 0;
	}

	// Token: 0x0601B5BE RID: 112062 RVA: 0x00779DA3 File Offset: 0x00777FA3
	private int GetInputType()
	{
		return this.InputType;
	}

	// Token: 0x0601B5BF RID: 112063 RVA: 0x00779DAC File Offset: 0x00777FAC
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

	// Token: 0x0601B5C0 RID: 112064 RVA: 0x00779E50 File Offset: 0x00778050
	public float GetMinAttrValue()
	{
		return 22857f;
	}

	// Token: 0x0601B5C1 RID: 112065 RVA: 0x00779E57 File Offset: 0x00778057
	public int GetNextGenCircleIndex()
	{
		return this.NextGenCircleIndex;
	}

	// Token: 0x0601B5C2 RID: 112066 RVA: 0x00779E5F File Offset: 0x0077805F
	public int GetNextEndCircleIndex()
	{
		return this.NextEndCircleIndex;
	}

	// Token: 0x0601B5C3 RID: 112067 RVA: 0x00779E67 File Offset: 0x00778067
	public bool GetIsUltraSkillState()
	{
		return this.IsUltraSkillState;
	}

	// Token: 0x0400D604 RID: 54788
	private const float CHECK_DISTANCE_INTERVAL = 1000f;

	// Token: 0x0400D605 RID: 54789
	private const float MAX_DISTANCE_SQUARED = 900000000f;

	// Token: 0x0400D606 RID: 54790
	private const int ULTRA_SKILL_ID = 1407200;

	// Token: 0x0400D607 RID: 54791
	private const int ULTRA_SECOND_SKILL_ID = 1407201;

	// Token: 0x0400D608 RID: 54792
	private const int LOOP_SKILL_ID = 1407004;

	// Token: 0x0400D609 RID: 54793
	private const float LOOP_START_TIME = 4f;

	// Token: 0x0400D60A RID: 54794
	private const float LOOP_END_TIME = 22.333334f;

	// Token: 0x0400D60B RID: 54795
	private const int CIRCLE_NUM = 2;

	// Token: 0x0400D60C RID: 54796
	private const float MAX_ATRR_VALUE = 30000f;

	// Token: 0x0400D60D RID: 54797
	private const float SUCC_MAX_ATTR_VALUE = 30000f;

	// Token: 0x0400D60E RID: 54798
	private const float SUCC_MIN_ATTR_VALUE = 22857f;

	// Token: 0x0400D60F RID: 54799
	private const float SUCC_BACKSTAGE_ATRR_VALUE = 25000f;

	// Token: 0x0400D610 RID: 54800
	private const float CIRCLE_SPEED_INIT = 14.285714f;

	// Token: 0x0400D611 RID: 54801
	private const float FRIST_CIRCLE_TIME = 2332f;

	// Token: 0x0400D612 RID: 54802
	private const float SECOND_CIRCLE_TIME = 1332f;

	// Token: 0x0400D613 RID: 54803
	private const float CIRCLE_INTERVAL = 23285.7f;

	// Token: 0x0400D614 RID: 54804
	private const float ULTRA_SKILL_TOTAL_TIME = 34000f;

	// Token: 0x0400D615 RID: 54805
	private const float INPUT_START_TIME = 3664f;

	// Token: 0x0400D616 RID: 54806
	[Nullable(1)]
	private const string FORCE_TIME_SCALE_LOCK_KEY = "SpecialSkillXiaKong.SummonedSync";

	// Token: 0x0400D617 RID: 54807
	private Entity Entity;

	// Token: 0x0400D618 RID: 54808
	private int EntityId;

	// Token: 0x0400D619 RID: 54809
	private long CreatureDataId;

	// Token: 0x0400D61A RID: 54810
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400D61B RID: 54811
	private CharacterTimeScaleComponent CharacterTimeScaleComponent;

	// Token: 0x0400D61C RID: 54812
	private RoleTagComponent TagComponent;

	// Token: 0x0400D61D RID: 54813
	private BaseAttributeComponent AttrComponent;

	// Token: 0x0400D61E RID: 54814
	private RoleBuffComponent BuffComponent;

	// Token: 0x0400D61F RID: 54815
	private Skill UltraSkill;

	// Token: 0x0400D620 RID: 54816
	private bool IsUltraSkillState;

	// Token: 0x0400D621 RID: 54817
	private int StartFrame;

	// Token: 0x0400D622 RID: 54818
	private CharacterTimeScaleComponent LastTimeScaleComp;

	// Token: 0x0400D623 RID: 54819
	private CharacterTimeScaleComponent[] TimeScaleCompList;

	// Token: 0x0400D624 RID: 54820
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityHandle> SummonedEntityList = new List<EntityHandle>();

	// Token: 0x0400D625 RID: 54821
	[Nullable(1)]
	private readonly List<int> SummonedEntityHandleIdList = new List<int>();

	// Token: 0x0400D626 RID: 54822
	[Nullable(1)]
	private readonly List<SpecialSkillXiaKongSummoned> SummonedList = new List<SpecialSkillXiaKongSummoned>();

	// Token: 0x0400D627 RID: 54823
	private TimerHandle Timer;

	// Token: 0x0400D628 RID: 54824
	private bool IsAutonomous;

	// Token: 0x0400D629 RID: 54825
	[Nullable(1)]
	private readonly List<long> BuffList = new List<long>();

	// Token: 0x0400D62A RID: 54826
	private int NextGenCircleIndex;

	// Token: 0x0400D62B RID: 54827
	private int NextEndCircleIndex;

	// Token: 0x0400D62C RID: 54828
	[Nullable(1)]
	private readonly List<long> GenBuffList = new List<long>();

	// Token: 0x0400D62D RID: 54829
	private float CircleSpeed;

	// Token: 0x0400D62E RID: 54830
	private bool IsForeground;

	// Token: 0x0400D62F RID: 54831
	private float CircleGenCountDown;

	// Token: 0x0400D630 RID: 54832
	private float TotalTime;

	// Token: 0x0400D631 RID: 54833
	private int InputType;

	// Token: 0x0400D632 RID: 54834
	private bool IsStopGenCircle;

	// Token: 0x0400D633 RID: 54835
	private float InputStartCountDown;

	// Token: 0x0400D634 RID: 54836
	private int ColorType = 1;

	// Token: 0x0400D635 RID: 54837
	[Nullable(1)]
	private readonly Dictionary<long, int> WaitSummonedEntityMap = new Dictionary<long, int>();
}
