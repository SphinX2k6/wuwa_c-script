using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02003198 RID: 12696
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillMorphBase : SpecialSkillBase, IStaticVariableResetter
{
	// Token: 0x0601B55C RID: 111964 RVA: 0x00777089 File Offset: 0x00775289
	static SpecialSkillMorphBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialSkillMorphBase.CreateStaticDefaultValue), new Action(SpecialSkillMorphBase.ResetStaticDefaultValue));
	}

	// Token: 0x0601B55D RID: 111965 RVA: 0x007770A8 File Offset: 0x007752A8
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

	// Token: 0x0601B55E RID: 111966 RVA: 0x007770D4 File Offset: 0x007752D4
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

	// Token: 0x170025CB RID: 9675
	// (get) Token: 0x0601B55F RID: 111967
	protected abstract string MorphBuffsConfigKey { get; }

	// Token: 0x170025CC RID: 9676
	// (get) Token: 0x0601B560 RID: 111968
	protected abstract string MorphCueIdConfigKey { get; }

	// Token: 0x170025CD RID: 9677
	// (get) Token: 0x0601B561 RID: 111969
	protected abstract string ResetMorphSkillsConfigKey { get; }

	// Token: 0x170025CE RID: 9678
	// (get) Token: 0x0601B562 RID: 111970
	protected abstract string NotResetMorphSkillsConfigKey { get; }

	// Token: 0x170025CF RID: 9679
	// (get) Token: 0x0601B563 RID: 111971
	protected abstract string ChangeRoleResetMorphTagsConfigKey { get; }

	// Token: 0x0601B564 RID: 111972
	protected abstract string GetSubMeshConfigKey(EMorphType morphType);

	// Token: 0x170025D0 RID: 9680
	// (get) Token: 0x0601B565 RID: 111973 RVA: 0x00777100 File Offset: 0x00775300
	protected virtual string LogPrefix
	{
		get
		{
			return base.GetType().Name;
		}
	}

	// Token: 0x0601B566 RID: 111974 RVA: 0x0077710D File Offset: 0x0077530D
	protected SpecialSkillMorphBase(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B567 RID: 111975 RVA: 0x00777120 File Offset: 0x00775320
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

	// Token: 0x0601B568 RID: 111976 RVA: 0x007771AB File Offset: 0x007753AB
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

	// Token: 0x0601B569 RID: 111977 RVA: 0x007771E4 File Offset: 0x007753E4
	public override void OnActivate()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		EMorphType? emorphType = (morphComp != null) ? new EMorphType?(morphComp.GetMorphType()) : null;
		if (emorphType != null)
		{
			this.RefreshNoUpdateMeshes(emorphType.Value);
		}
	}

	// Token: 0x0601B56A RID: 111978 RVA: 0x00777228 File Offset: 0x00775428
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

	// Token: 0x0601B56B RID: 111979 RVA: 0x007773B4 File Offset: 0x007755B4
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

	// Token: 0x0601B56C RID: 111980 RVA: 0x007774CC File Offset: 0x007756CC
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

	// Token: 0x0601B56D RID: 111981 RVA: 0x00777600 File Offset: 0x00775800
	protected virtual void OnBeforeResetMorph()
	{
	}

	// Token: 0x0601B56E RID: 111982 RVA: 0x00777604 File Offset: 0x00775804
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

	// Token: 0x0601B56F RID: 111983 RVA: 0x00777798 File Offset: 0x00775998
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

	// Token: 0x0601B570 RID: 111984 RVA: 0x00777828 File Offset: 0x00775A28
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

	// Token: 0x0601B571 RID: 111985 RVA: 0x0077788C File Offset: 0x00775A8C
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

	// Token: 0x0601B572 RID: 111986 RVA: 0x007778CC File Offset: 0x00775ACC
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

	// Token: 0x0601B573 RID: 111987 RVA: 0x00777918 File Offset: 0x00775B18
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

	// Token: 0x0601B574 RID: 111988 RVA: 0x0077799C File Offset: 0x00775B9C
	protected void OnRoleDeadEnd()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.IsMorphing())
		{
			this.LogResetMorph(EResetMorphReason.RoleDead, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(false);
		}
	}

	// Token: 0x0601B575 RID: 111989 RVA: 0x007779D4 File Offset: 0x00775BD4
	protected void OnRoleRevive()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.IsMorphing())
		{
			this.LogResetMorph(EResetMorphReason.RoleRevive, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(false);
		}
	}

	// Token: 0x0601B576 RID: 111990 RVA: 0x00777A0C File Offset: 0x00775C0C
	protected void OnExecuteAfterSetPlotMode()
	{
		if (!this.ShouldResetMorphOnPlotMode())
		{
			return;
		}
		this.LogResetMorph(EResetMorphReason.BeforePlot, default(ReadOnlySpan<ValueTuple<string, object>>));
		this.ResetMorph(true);
	}

	// Token: 0x0601B577 RID: 111991 RVA: 0x00777A39 File Offset: 0x00775C39
	protected virtual void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		this.RefreshNoUpdateMeshes(newMorphType);
	}

	// Token: 0x0601B578 RID: 111992 RVA: 0x00777A42 File Offset: 0x00775C42
	protected void OnBeforeSkillSimulateMontage(int entityId, int skillId, int montageIndex, float startTimeSeconds)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		this.SyncRemoteSkillMontage(skillId);
	}

	// Token: 0x0601B579 RID: 111993 RVA: 0x00777A60 File Offset: 0x00775C60
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

	// Token: 0x0601B57A RID: 111994 RVA: 0x00777B0C File Offset: 0x00775D0C
	protected void OnForceResetTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.LogResetMorph(EResetMorphReason.ForceResetTag, default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResetMorph(true);
		}
	}

	// Token: 0x0601B57B RID: 111995 RVA: 0x00777B34 File Offset: 0x00775D34
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

	// Token: 0x0601B57C RID: 111996 RVA: 0x00777CDC File Offset: 0x00775EDC
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

	// Token: 0x0601B57D RID: 111997 RVA: 0x00777E58 File Offset: 0x00776058
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

	// Token: 0x0601B57E RID: 111998 RVA: 0x00777F30 File Offset: 0x00776130
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

	// Token: 0x0601B57F RID: 111999 RVA: 0x00778028 File Offset: 0x00776228
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

	// Token: 0x0601B580 RID: 112000 RVA: 0x007780B4 File Offset: 0x007762B4
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

	// Token: 0x0601B581 RID: 112001 RVA: 0x007780D0 File Offset: 0x007762D0
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

	// Token: 0x0601B582 RID: 112002 RVA: 0x0077815C File Offset: 0x0077635C
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

	// Token: 0x0601B583 RID: 112003 RVA: 0x007781BC File Offset: 0x007763BC
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

	// Token: 0x0601B584 RID: 112004 RVA: 0x0077821C File Offset: 0x0077641C
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

	// Token: 0x0400D5D7 RID: 54743
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, HashSet<long>> _morphResetConfigCache;

	// Token: 0x0400D5D8 RID: 54744
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, HashSet<long>> _morphKeepConfigCache;

	// Token: 0x0400D5D9 RID: 54745
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<int>> _changeRoleResetMorphTagsCache;

	// Token: 0x0400D5DA RID: 54746
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private static Dictionary<string, List<string>> _morphSubMeshCache;

	// Token: 0x0400D5DB RID: 54747
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<long>> _morphBuffsCache;

	// Token: 0x0400D5DC RID: 54748
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, List<long>> _morphCueIdsCache;

	// Token: 0x0400D5DD RID: 54749
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<USkeletalMeshComponent> _tempMeshes;

	// Token: 0x0400D5DE RID: 54750
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400D5DF RID: 54751
	[Nullable(2)]
	protected BaseAnimationComponent AnimComp;

	// Token: 0x0400D5E0 RID: 54752
	[Nullable(2)]
	protected CharacterMorphComponent MorphComp;

	// Token: 0x0400D5E1 RID: 54753
	[Nullable(2)]
	protected BaseSkillComponent SkillComp;

	// Token: 0x0400D5E2 RID: 54754
	[Nullable(2)]
	protected CharacterMontageComponent MontageComp;

	// Token: 0x0400D5E3 RID: 54755
	[Nullable(2)]
	protected BaseBuffComponent BuffComp;

	// Token: 0x0400D5E4 RID: 54756
	[Nullable(2)]
	protected BaseGameplayCueComponent CueComp;

	// Token: 0x0400D5E5 RID: 54757
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400D5E6 RID: 54758
	[Nullable(2)]
	protected RoleQteComponent RoleQteComp;

	// Token: 0x0400D5E7 RID: 54759
	[Nullable(2)]
	protected ITagTask GlideStateListener;

	// Token: 0x0400D5E8 RID: 54760
	[Nullable(2)]
	protected ITagTask ForceResetTagListener;

	// Token: 0x0400D5E9 RID: 54761
	protected readonly bool IsEnableOptimize = true;
}
