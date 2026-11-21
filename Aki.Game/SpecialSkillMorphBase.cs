using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02002706 RID: 9990
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillMorphBase : SpecialSkillBase, IStaticVariableResetter
{
	// Token: 0x0601907C RID: 102524 RVA: 0x0079F315 File Offset: 0x0079D515
	static SpecialSkillMorphBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialSkillMorphBase.CreateStaticDefaultValue), new Action(SpecialSkillMorphBase.ResetStaticDefaultValue));
	}

	// Token: 0x0601907D RID: 102525 RVA: 0x0079F334 File Offset: 0x0079D534
	public static void CreateStaticDefaultValue()
	{
		SpecialSkillMorphBase._morphResetConfigCache = null;
		SpecialSkillMorphBase._morphKeepConfigCache = null;
		SpecialSkillMorphBase._changeRoleResetMorphTagsCache = null;
		SpecialSkillMorphBase._morphSubMeshCache = null;
		SpecialSkillMorphBase._morphBuffsCache = null;
		SpecialSkillMorphBase._morphCueIdsCache = null;
		SpecialSkillMorphBase._tempMeshes = null;
	}

	// Token: 0x0601907E RID: 102526 RVA: 0x0079F360 File Offset: 0x0079D560
	public static void ResetStaticDefaultValue()
	{
		SpecialSkillMorphBase._morphResetConfigCache = null;
		SpecialSkillMorphBase._morphKeepConfigCache = null;
		SpecialSkillMorphBase._changeRoleResetMorphTagsCache = null;
		SpecialSkillMorphBase._morphSubMeshCache = null;
		SpecialSkillMorphBase._morphBuffsCache = null;
		SpecialSkillMorphBase._morphCueIdsCache = null;
		SpecialSkillMorphBase._tempMeshes = null;
	}

	// Token: 0x170027BC RID: 10172
	// (get) Token: 0x0601907F RID: 102527
	protected abstract string MorphBuffsConfigKey { get; }

	// Token: 0x170027BD RID: 10173
	// (get) Token: 0x06019080 RID: 102528
	protected abstract string MorphCueIdConfigKey { get; }

	// Token: 0x170027BE RID: 10174
	// (get) Token: 0x06019081 RID: 102529
	protected abstract string ResetMorphSkillsConfigKey { get; }

	// Token: 0x170027BF RID: 10175
	// (get) Token: 0x06019082 RID: 102530
	protected abstract string NotResetMorphSkillsConfigKey { get; }

	// Token: 0x170027C0 RID: 10176
	// (get) Token: 0x06019083 RID: 102531
	protected abstract string ChangeRoleResetMorphTagsConfigKey { get; }

	// Token: 0x06019084 RID: 102532
	protected abstract string GetSubMeshConfigKey(EMorphType morphType);

	// Token: 0x170027C1 RID: 10177
	// (get) Token: 0x06019085 RID: 102533 RVA: 0x0079F38C File Offset: 0x0079D58C
	protected virtual string LogPrefix
	{
		get
		{
			return base.GetType().Name;
		}
	}

	// Token: 0x06019086 RID: 102534 RVA: 0x0079F399 File Offset: 0x0079D599
	protected SpecialSkillMorphBase(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019087 RID: 102535 RVA: 0x0079F3AC File Offset: 0x0079D5AC
	public override void OnStart()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.AnimComp = entity.GetComponent<BaseAnimationComponent>();
		this.MorphComp = entity.GetComponent<CharacterMorphComponent>();
		this.SkillComp = entity.GetComponent<BaseSkillComponent>();
		this.MontageComp = entity.GetComponent<CharacterMontageComponent>();
		this.BuffComp = entity.GetComponent<BaseBuffComponent>();
		this.CueComp = entity.GetComponent<BaseGameplayCueComponent>();
		this.TagComp = entity.GetComponent<BaseTagComponent>();
		this.RoleQteComp = entity.GetComponent<RoleQteComponent>();
		this.RegisterMorphEvents();
	}

	// Token: 0x06019088 RID: 102536 RVA: 0x0079F437 File Offset: 0x0079D637
	public override void OnEnd()
	{
		this.UnregisterMorphEvents();
		ITagTask glideStateListener = this.GlideStateListener;
		if (glideStateListener != null)
		{
			glideStateListener.EndTask();
		}
		this.GlideStateListener = null;
		ITagTask forceResetTagListener = this.ForceResetTagListener;
		if (forceResetTagListener != null)
		{
			forceResetTagListener.EndTask();
		}
		this.ForceResetTagListener = null;
	}

	// Token: 0x06019089 RID: 102537 RVA: 0x0079F470 File Offset: 0x0079D670
	public override void OnActivate()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		EMorphType? emorphType = (morphComp != null) ? new EMorphType?(morphComp.GetMorphType()) : null;
		if (emorphType != null)
		{
			this.RefreshNoUpdateMeshes(emorphType.Value);
		}
	}

	// Token: 0x0601908A RID: 102538 RVA: 0x0079F4B4 File Offset: 0x0079D6B4
	protected void RegisterMorphEvents()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
		EventSystem.Instance.Add(EEventName.OnExecuteAfterSetPlotMode, new Action(this.OnExecuteAfterSetPlotMode));
		EventSystem.Instance.AddWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
		EventSystem.Instance.AddWithTarget<ECharacterActionType>(entity, EEventName.OnBeforeCharActionWithTarget, new Action<ECharacterActionType>(this.OnBeforeCharAction));
		EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnCharOnUnifiedMoveStateChanged));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnRoleDeadEnd, new Action(this.OnRoleDeadEnd));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnRevive, new Action(this.OnRoleRevive));
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		EventSystem.Instance.AddWithTarget<int, int, int, float>(entity, EEventName.OnBeforeSkillSimulateMontage, new Action<int, int, int, float>(this.OnBeforeSkillSimulateMontage));
		SpecialSkillMorphBase specialSkillMorphBase = this;
		BaseTagComponent tagComp = this.TagComp;
		specialSkillMorphBase.GlideStateListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑翔"]), new BaseTagComponent.TTagSwitchedCallback(this.OnGlideStateChanged), null) : null);
		BaseTagComponent tagComp2 = this.TagComp;
		this.ForceResetTagListener = ((tagComp2 != null) ? tagComp2.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.角色形态.强制还原形态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForceResetTagChanged), null) : null);
	}

	// Token: 0x0601908B RID: 102539 RVA: 0x0079F640 File Offset: 0x0079D840
	protected void UnregisterMorphEvents()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
		EventSystem.Instance.Remove(EEventName.OnExecuteAfterSetPlotMode, new Action(this.OnExecuteAfterSetPlotMode));
		EventSystem.Instance.RemoveWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
		EventSystem.Instance.RemoveWithTarget<ECharacterActionType>(entity, EEventName.OnBeforeCharActionWithTarget, new Action<ECharacterActionType>(this.OnBeforeCharAction));
		EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnCharOnUnifiedMoveStateChanged));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnRoleDeadEnd, new Action(this.OnRoleDeadEnd));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnRevive, new Action(this.OnRoleRevive));
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		EventSystem.Instance.RemoveWithTarget<int, int, int, float>(entity, EEventName.OnBeforeSkillSimulateMontage, new Action<int, int, int, float>(this.OnBeforeSkillSimulateMontage));
	}

	// Token: 0x0601908C RID: 102540 RVA: 0x0079F758 File Offset: 0x0079D958
	protected void ResetMorph(bool needAddCue = true)
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp == null || !morphComp.IsMorphing())
		{
			return;
		}
		this.OnBeforeResetMorph();
		foreach (long buffId in SpecialSkillMorphBase.GetMorphBuffsFromConfig(this.MorphBuffsConfigKey))
		{
			BaseBuffComponent buffComp = this.BuffComp;
			if (buffComp != null && buffComp.HasBuff(buffId, false))
			{
				this.BuffComp.RemoveBuff(buffId, -1, this.LogPrefix + ".ResetMorph", null, null, null);
			}
		}
		if (needAddCue)
		{
			foreach (long num in SpecialSkillMorphBase.GetMorphCueIdsFromConfig(this.MorphCueIdConfigKey))
			{
				if (num > 0L)
				{
					BaseGameplayCueComponent cueComp = this.CueComp;
					if (cueComp != null)
					{
						cueComp.AddCue(num, new GameplayCueParam?(new GameplayCueParam
						{
							Instant = true
						}));
					}
				}
			}
		}
	}

	// Token: 0x0601908D RID: 102541 RVA: 0x0079F88C File Offset: 0x0079DA8C
	protected virtual void OnBeforeResetMorph()
	{
	}

	// Token: 0x0601908E RID: 102542 RVA: 0x0079F890 File Offset: 0x0079DA90
	protected void RefreshNoUpdateMeshes(EMorphType morphType)
	{
		if (!this.IsEnableOptimize)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
		if (tsBaseCharacter == null || this.AnimComp == null)
		{
			return;
		}
		if (SpecialSkillMorphBase._tempMeshes == null)
		{
			SpecialSkillMorphBase._tempMeshes = new HashSet<USkeletalMeshComponent>();
		}
		else
		{
			SpecialSkillMorphBase._tempMeshes.Clear();
		}
		List<string> list = new List<string>();
		CharacterMorphComponent morphComp = this.MorphComp;
		Dictionary<EMorphType, IMorphData> dictionary = (morphComp != null) ? morphComp.GetMorphDataMap() : null;
		if (dictionary != null)
		{
			foreach (EMorphType emorphType in dictionary.Keys)
			{
				if (emorphType != morphType)
				{
					foreach (string item in SpecialSkillMorphBase.GetSubMeshNamesFromConfig(this.GetSubMeshConfigKey(emorphType)))
					{
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
		}
		if (list.Count > 0)
		{
			TArray<UActorComponent> tarray = tsBaseCharacter.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			for (int i = 0; i < tarray.Num(); i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
				string text = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.GetName() : null;
				if (uskeletalMeshComponent != null && text != null && list.Contains(text))
				{
					SpecialSkillMorphBase._tempMeshes.Add(uskeletalMeshComponent);
				}
			}
		}
		this.AnimComp.SetNoUpdateMeshes(SpecialSkillMorphBase._tempMeshes);
		SpecialSkillMorphBase._tempMeshes.Clear();
	}

	// Token: 0x0601908F RID: 102543 RVA: 0x0079FA24 File Offset: 0x0079DC24
	protected void LogResetMorph(EResetMorphReason reason, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> extraPairs)
	{
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = extraPairs;
		int num = 0;
		ValueTuple<string, object>[] array = new ValueTuple<string, object>[1 + readOnlySpan.Length];
		array[num] = valueTuple;
		num++;
		readOnlySpan.CopyTo(new Span<ValueTuple<string, object>>(array).Slice(num, readOnlySpan.Length));
		num += readOnlySpan.Length;
		ReadOnlySpan<ValueTuple<string, object>> pairs = new ReadOnlySpan<ValueTuple<string, object>>(array);
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, this.SpecialSkillComponent.Entity, "还原形态", pairs);
	}

	// Token: 0x06019090 RID: 102544 RVA: 0x0079FAB4 File Offset: 0x0079DCB4
	protected void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		RoleQteComponent roleQteComp = this.RoleQteComp;
		if (roleQteComp != null && roleQteComp.IsInQte)
		{
			return;
		}
		int? num = this.ShouldResetMorphOnChangeRole(newEntity, oldEntity);
		if (num == null)
		{
			return;
		}
		EResetMorphReason reason = EResetMorphReason.ChangeRole;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", num.Value);
		this.LogResetMorph(reason, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ResetMorph(true);
	}

	// Token: 0x06019091 RID: 102545 RVA: 0x0079FB18 File Offset: 0x0079DD18
	protected void OnCharBeforeSkill(int skillId, bool isAutonomousProxy)
	{
		if (!this.ShouldResetMorphBeforeSkill(skillId))
		{
			return;
		}
		EResetMorphReason reason = EResetMorphReason.BeforeSkill;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
		this.LogResetMorph(reason, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ResetMorph(true);
	}

	// Token: 0x06019092 RID: 102546 RVA: 0x0079FB58 File Offset: 0x0079DD58
	protected void OnBeforeCharAction(ECharacterActionType actionType)
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp == null || !morphComp.IsMorphing())
		{
			return;
		}
		EResetMorphReason reason = EResetMorphReason.BeforeAction;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionType", actionType);
		this.LogResetMorph(reason, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ResetMorph(true);
	}

	// Token: 0x06019093 RID: 102547 RVA: 0x0079FBA4 File Offset: 0x0079DDA4
	protected unsafe void OnCharOnUnifiedMoveStateChanged(ECharMoveState oldMoveState, ECharMoveState newMoveState)
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp == null || !morphComp.IsMorphing())
		{
			return;
		}
		if (newMoveState == ECharMoveState.NormalSki)
		{
			EResetMorphReason reason = EResetMorphReason.MoveStateChanged;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldMoveState", oldMoveState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewMoveState", newMoveState);
			this.LogResetMorph(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ResetMorph(true);
		}
	}

	// Token: 0x06019094 RID: 102548 RVA: 0x0079FC28 File Offset: 0x0079DE28
	protected void OnRoleDeadEnd()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.IsMorphing())
		{
			this.LogResetMorph(EResetMorphReason.RoleDead, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(false);
		}
	}

	// Token: 0x06019095 RID: 102549 RVA: 0x0079FC60 File Offset: 0x0079DE60
	protected void OnRoleRevive()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.IsMorphing())
		{
			this.LogResetMorph(EResetMorphReason.RoleRevive, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(false);
		}
	}

	// Token: 0x06019096 RID: 102550 RVA: 0x0079FC98 File Offset: 0x0079DE98
	protected void OnExecuteAfterSetPlotMode()
	{
		if (!this.ShouldResetMorphOnPlotMode())
		{
			return;
		}
		this.LogResetMorph(EResetMorphReason.BeforePlot, default(ReadOnlySpan<ValueTuple<string, object>>));
		this.ResetMorph(true);
	}

	// Token: 0x06019097 RID: 102551 RVA: 0x0079FCC5 File Offset: 0x0079DEC5
	protected virtual void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		this.RefreshNoUpdateMeshes(newMorphType);
	}

	// Token: 0x06019098 RID: 102552 RVA: 0x0079FCCE File Offset: 0x0079DECE
	protected void OnBeforeSkillSimulateMontage(int entityId, int skillId, int montageIndex, float startTimeSeconds)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		this.SyncRemoteSkillMontage(skillId);
	}

	// Token: 0x06019099 RID: 102553 RVA: 0x0079FCEC File Offset: 0x0079DEEC
	protected void OnGlideStateChanged(int tagId, bool bTagExists)
	{
		if (bTagExists)
		{
			CharacterMorphComponent morphComp = this.MorphComp;
			if (morphComp != null && morphComp.IsMorphing())
			{
				int id = this.SpecialSkillComponent.Entity.Id;
				SceneTeamModel instance = SceneTeamModel.Instance;
				int? num;
				if (instance == null)
				{
					num = null;
				}
				else
				{
					EntityHandle getCurrentEntity = instance.GetCurrentEntity;
					if (getCurrentEntity == null)
					{
						num = null;
					}
					else
					{
						WorldEntity entity = getCurrentEntity.Entity;
						num = ((entity != null) ? new int?(entity.Id) : null);
					}
				}
				int? num2 = num;
				if (id == num2.GetValueOrDefault() & num2 != null)
				{
					this.LogResetMorph(EResetMorphReason.EnterGlide, default(ReadOnlySpan<ValueTuple<string, object>>));
					this.ResetMorph(true);
				}
			}
		}
	}

	// Token: 0x0601909A RID: 102554 RVA: 0x0079FD98 File Offset: 0x0079DF98
	protected void OnForceResetTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.LogResetMorph(EResetMorphReason.ForceResetTag, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(true);
		}
	}

	// Token: 0x0601909B RID: 102555 RVA: 0x0079FDC0 File Offset: 0x0079DFC0
	protected bool ShouldResetMorphBeforeSkill(int skillId)
	{
		if (this.SkillComp == null)
		{
			return false;
		}
		SSkillInfo skillInfo = this.SkillComp.GetSkillInfo(skillId);
		if (skillInfo == null)
		{
			return false;
		}
		bool flag = false;
		if (SpecialSkillMorphBase.IsSkillInConfig(skillId, this.ResetMorphSkillsConfigKey, ref SpecialSkillMorphBase._morphResetConfigCache))
		{
			flag = true;
		}
		else if (SpecialSkillMorphBase.IsSkillInConfig(skillId, this.NotResetMorphSkillsConfigKey, ref SpecialSkillMorphBase._morphKeepConfigCache))
		{
			flag = false;
		}
		else if (skillInfo.GroupId != 1)
		{
			flag = false;
		}
		else if (this.SkillComp.HasSkillGenre(skillId, ESkillGenre.探索幻象技10))
		{
			flag = true;
		}
		CharacterMorphComponent morphComp = this.MorphComp;
		bool flag2 = morphComp != null && morphComp.IsMorphing() && !flag;
		global::Skill skill = this.SkillComp.GetSkill(skillId);
		Entity entity = this.SkillComp.Entity;
		if (skill != null && skillInfo.MontagePaths.Num() > 0)
		{
			TArray<string> montagePaths = skillInfo.MontagePaths;
			for (int i = 0; i < montagePaths.Num(); i++)
			{
				string name = montagePaths.Get(i);
				UAnimMontage montageByIndex = skill.GetMontageByIndex(i);
				UAnimMontage uanimMontage;
				if (!flag2)
				{
					CharacterMontageComponent montageComp = this.MontageComp;
					uanimMontage = ((montageComp != null) ? montageComp.GetMontageByName(name, false, false) : null);
				}
				else
				{
					CharacterMorphComponent morphComp2 = this.MorphComp;
					uanimMontage = ((morphComp2 != null) ? morphComp2.GetMontageByName(name) : null);
				}
				UAnimMontage uanimMontage2 = uanimMontage;
				if (montageByIndex != null && uanimMontage2 != null && montageByIndex != uanimMontage2)
				{
					skill.SetMontageByIndex(i, uanimMontage2);
					if (entity != null)
					{
					}
				}
				else if (montageByIndex == null && uanimMontage2 != null)
				{
					skill.SetMontageByIndex(i, uanimMontage2);
					if (entity != null)
					{
					}
				}
				else if (montageByIndex != null && uanimMontage2 == null)
				{
					if (flag2)
					{
						flag = true;
						CharacterMontageComponent montageComp2 = this.MontageComp;
						UAnimMontage uanimMontage3 = (montageComp2 != null) ? montageComp2.GetMontageByName(name, false, false) : null;
						if (uanimMontage3 != null)
						{
							skill.SetMontageByIndex(i, uanimMontage3);
						}
					}
				}
			}
		}
		return flag;
	}

	// Token: 0x0601909C RID: 102556 RVA: 0x0079FF68 File Offset: 0x0079E168
	protected int? ShouldResetMorphOnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		WorldEntity entity = newEntity.Entity;
		int? result = (entity != null) ? new int?(entity.Id) : null;
		int id = this.SpecialSkillComponent.Entity.Id;
		if (!(result.GetValueOrDefault() == id & result != null))
		{
			result = null;
			return result;
		}
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp == null || !morphComp.IsMorphing())
		{
			result = null;
			return result;
		}
		ECharPositionState? echarPositionState;
		if (oldEntity == null)
		{
			echarPositionState = null;
		}
		else
		{
			WorldEntity entity2 = oldEntity.Entity;
			if (entity2 == null)
			{
				echarPositionState = null;
			}
			else
			{
				CharacterUnifiedStateComponent component = entity2.GetComponent<CharacterUnifiedStateComponent>();
				echarPositionState = ((component != null) ? new ECharPositionState?(component.PositionState) : null);
			}
		}
		ECharPositionState? echarPositionState2 = echarPositionState;
		ECharPositionState echarPositionState3 = ECharPositionState.Ground;
		if (echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null)
		{
			result = null;
			return result;
		}
		List<int> tagsFromConfig = SpecialSkillMorphBase.GetTagsFromConfig(ref SpecialSkillMorphBase._changeRoleResetMorphTagsCache, this.ChangeRoleResetMorphTagsConfigKey);
		if (tagsFromConfig.Count > 0)
		{
			BaseTagComponent baseTagComponent;
			if (oldEntity == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity3 = oldEntity.Entity;
				baseTagComponent = ((entity3 != null) ? entity3.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			foreach (int num in tagsFromConfig)
			{
				if (baseTagComponent2 != null && baseTagComponent2.HasTag(num))
				{
					return new int?(num);
				}
			}
		}
		return null;
	}

	// Token: 0x0601909D RID: 102557 RVA: 0x007A00E4 File Offset: 0x0079E2E4
	protected bool ShouldResetMorphOnPlotMode()
	{
		PlotModel instance = PlotModel.Instance;
		PlotConfig plotConfig = (instance != null) ? instance.PlotConfig : null;
		if (plotConfig == null)
		{
			return false;
		}
		EPlotLevel? plotLevel = plotConfig.PlotLevel;
		bool shouldSwitchMainRole = plotConfig.ShouldSwitchMainRole;
		if (plotLevel != EPlotLevel.LevelC || shouldSwitchMainRole)
		{
			return false;
		}
		SceneTeamModel instance2 = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance2 != null) ? instance2.GetCurrentEntity : null;
		int? num;
		if (entityHandle == null)
		{
			num = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			num = ((entity != null) ? new int?(entity.Id) : null);
		}
		int? num2 = num;
		int id = this.SpecialSkillComponent.Entity.Id;
		if (!(num2.GetValueOrDefault() == id & num2 != null))
		{
			return false;
		}
		CharacterMorphComponent morphComp = this.MorphComp;
		return morphComp != null && morphComp.IsMorphing();
	}

	// Token: 0x0601909E RID: 102558 RVA: 0x007A01BC File Offset: 0x0079E3BC
	protected void SyncRemoteSkillMontage(int skillId)
	{
		BaseSkillComponent skillComp = this.SkillComp;
		global::Skill skill = (skillComp != null) ? skillComp.GetSkill(skillId) : null;
		SSkillInfo sskillInfo = (skill != null) ? skill.SkillInfo : null;
		if (skill == null || sskillInfo == null)
		{
			return;
		}
		CharacterMorphComponent morphComp = this.MorphComp;
		bool flag = morphComp != null && morphComp.IsMorphing();
		if (sskillInfo.MontagePaths.Num() > 0)
		{
			TArray<string> montagePaths = sskillInfo.MontagePaths;
			for (int i = 0; i < montagePaths.Num(); i++)
			{
				string name = montagePaths.Get(i);
				UAnimMontage montageByIndex = skill.GetMontageByIndex(i);
				UAnimMontage uanimMontage;
				if (!flag)
				{
					CharacterMontageComponent montageComp = this.MontageComp;
					uanimMontage = ((montageComp != null) ? montageComp.GetMontageByName(name, false, false) : null);
				}
				else
				{
					CharacterMorphComponent morphComp2 = this.MorphComp;
					uanimMontage = ((morphComp2 != null) ? morphComp2.GetMontageByName(name) : null);
				}
				UAnimMontage uanimMontage2 = uanimMontage;
				if ((montageByIndex != null && uanimMontage2 != null && montageByIndex != uanimMontage2) || (montageByIndex == null && uanimMontage2 != null))
				{
					skill.SetMontageByIndex(i, uanimMontage2);
					BaseSkillComponent skillComp2 = this.SkillComp;
					if (skillComp2 != null)
					{
						Entity entity = skillComp2.Entity;
					}
				}
			}
		}
	}

	// Token: 0x0601909F RID: 102559 RVA: 0x007A02B4 File Offset: 0x0079E4B4
	private static HashSet<long> GetSkillsFromConfig([Nullable(new byte[]
	{
		2,
		1,
		1
	})] ref Dictionary<string, HashSet<long>> cache, [Nullable(2)] string configKey)
	{
		if (string.IsNullOrEmpty(configKey))
		{
			return new HashSet<long>();
		}
		if (cache == null)
		{
			cache = new Dictionary<string, HashSet<long>>();
		}
		HashSet<long> hashSet;
		if (!cache.TryGetValue(configKey, out hashSet))
		{
			hashSet = new HashSet<long>();
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig(configKey);
			if (intArrayConfig != null)
			{
				foreach (int num in intArrayConfig)
				{
					hashSet.Add((long)num);
				}
			}
			cache[configKey] = hashSet;
		}
		return hashSet;
	}

	// Token: 0x060190A0 RID: 102560 RVA: 0x007A0340 File Offset: 0x0079E540
	[NullableContext(2)]
	private static bool IsSkillInConfig(int skillId, string configKey, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] ref Dictionary<string, HashSet<long>> cache)
	{
		return !string.IsNullOrEmpty(configKey) && SpecialSkillMorphBase.GetSkillsFromConfig(ref cache, configKey).Contains((long)skillId);
	}

	// Token: 0x060190A1 RID: 102561 RVA: 0x007A035C File Offset: 0x0079E55C
	private static List<int> GetTagsFromConfig([Nullable(new byte[]
	{
		2,
		1,
		1
	})] ref Dictionary<string, List<int>> cache, [Nullable(2)] string configKey)
	{
		if (string.IsNullOrEmpty(configKey))
		{
			return new List<int>();
		}
		if (cache == null)
		{
			cache = new Dictionary<string, List<int>>();
		}
		List<int> list;
		if (!cache.TryGetValue(configKey, out list))
		{
			list = new List<int>();
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig(configKey);
			if (stringArrayConfig != null)
			{
				foreach (string tagName in stringArrayConfig)
				{
					list.Add(GameplayTagUtils.GetTagIdByName(tagName));
				}
			}
			cache[configKey] = list;
		}
		return list;
	}

	// Token: 0x060190A2 RID: 102562 RVA: 0x007A03E8 File Offset: 0x0079E5E8
	private static List<string> GetSubMeshNamesFromConfig([Nullable(2)] string configKey)
	{
		if (string.IsNullOrEmpty(configKey))
		{
			return new List<string>();
		}
		if (SpecialSkillMorphBase._morphSubMeshCache == null)
		{
			SpecialSkillMorphBase._morphSubMeshCache = new Dictionary<string, List<string>>();
		}
		List<string> list;
		if (!SpecialSkillMorphBase._morphSubMeshCache.TryGetValue(configKey, out list))
		{
			list = new List<string>();
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig(configKey);
			if (stringArrayConfig != null)
			{
				list.AddRange(stringArrayConfig);
			}
			SpecialSkillMorphBase._morphSubMeshCache[configKey] = list;
		}
		return list;
	}

	// Token: 0x060190A3 RID: 102563 RVA: 0x007A0448 File Offset: 0x0079E648
	private static List<long> GetMorphBuffsFromConfig([Nullable(2)] string configKey)
	{
		if (string.IsNullOrEmpty(configKey))
		{
			return new List<long>();
		}
		if (SpecialSkillMorphBase._morphBuffsCache == null)
		{
			SpecialSkillMorphBase._morphBuffsCache = new Dictionary<string, List<long>>();
		}
		List<long> list;
		if (!SpecialSkillMorphBase._morphBuffsCache.TryGetValue(configKey, out list))
		{
			list = new List<long>();
			IReadOnlyList<long> long54ArrayConfig = ConfigCommonParamById.GetLong54ArrayConfig(configKey);
			if (long54ArrayConfig != null)
			{
				list.AddRange(long54ArrayConfig);
			}
			SpecialSkillMorphBase._morphBuffsCache[configKey] = list;
		}
		return list;
	}

	// Token: 0x060190A4 RID: 102564 RVA: 0x007A04A8 File Offset: 0x0079E6A8
	private static List<long> GetMorphCueIdsFromConfig([Nullable(2)] string configKey)
	{
		if (string.IsNullOrEmpty(configKey))
		{
			return new List<long>();
		}
		if (SpecialSkillMorphBase._morphCueIdsCache == null)
		{
			SpecialSkillMorphBase._morphCueIdsCache = new Dictionary<string, List<long>>();
		}
		List<long> list;
		if (!SpecialSkillMorphBase._morphCueIdsCache.TryGetValue(configKey, out list))
		{
			list = new List<long>();
			IReadOnlyList<long> long54ArrayConfig = ConfigCommonParamById.GetLong54ArrayConfig(configKey);
			if (long54ArrayConfig != null)
			{
				list.AddRange(long54ArrayConfig);
			}
			SpecialSkillMorphBase._morphCueIdsCache[configKey] = list;
		}
		return list;
	}

	// Token: 0x0400DA5A RID: 55898
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, HashSet<long>> _morphResetConfigCache;

	// Token: 0x0400DA5B RID: 55899
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, HashSet<long>> _morphKeepConfigCache;

	// Token: 0x0400DA5C RID: 55900
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<int>> _changeRoleResetMorphTagsCache;

	// Token: 0x0400DA5D RID: 55901
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private static Dictionary<string, List<string>> _morphSubMeshCache;

	// Token: 0x0400DA5E RID: 55902
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<long>> _morphBuffsCache;

	// Token: 0x0400DA5F RID: 55903
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<long>> _morphCueIdsCache;

	// Token: 0x0400DA60 RID: 55904
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<USkeletalMeshComponent> _tempMeshes;

	// Token: 0x0400DA61 RID: 55905
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400DA62 RID: 55906
	[Nullable(2)]
	protected BaseAnimationComponent AnimComp;

	// Token: 0x0400DA63 RID: 55907
	[Nullable(2)]
	protected CharacterMorphComponent MorphComp;

	// Token: 0x0400DA64 RID: 55908
	[Nullable(2)]
	protected BaseSkillComponent SkillComp;

	// Token: 0x0400DA65 RID: 55909
	[Nullable(2)]
	protected CharacterMontageComponent MontageComp;

	// Token: 0x0400DA66 RID: 55910
	[Nullable(2)]
	protected BaseBuffComponent BuffComp;

	// Token: 0x0400DA67 RID: 55911
	[Nullable(2)]
	protected BaseGameplayCueComponent CueComp;

	// Token: 0x0400DA68 RID: 55912
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400DA69 RID: 55913
	[Nullable(2)]
	protected RoleQteComponent RoleQteComp;

	// Token: 0x0400DA6A RID: 55914
	[Nullable(2)]
	protected ITagTask GlideStateListener;

	// Token: 0x0400DA6B RID: 55915
	[Nullable(2)]
	protected ITagTask ForceResetTagListener;

	// Token: 0x0400DA6C RID: 55916
	protected readonly bool IsEnableOptimize = true;
}
