using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;

// Token: 0x02002710 RID: 10000
[NullableContext(2)]
[Nullable(0)]
public class VisionSkillComponent : CharacterSkillComponent
{
	// Token: 0x06019119 RID: 102681 RVA: 0x007A3B2C File Offset: 0x007A1D2C
	protected override bool OnStart()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.CreatureDataId = component.GetCreatureDataId();
		return base.OnStart();
	}

	// Token: 0x0601911A RID: 102682 RVA: 0x007A3B58 File Offset: 0x007A1D58
	[NullableContext(1)]
	public void InitVisionSkill(EntityHandle summonerEntity, bool isMorphVision = false, ECheckVisionType checkVisionType = ECheckVisionType.Vision)
	{
		if (this.SummonerEntity != summonerEntity)
		{
			this.TryRemoveEvents(true, true);
			this.SummonerEntity = summonerEntity;
			this.CurWorldSkillCdData = SkillCdModel.Instance.GetCurWorldSkillCdData();
			int id = base.Entity.Id;
			if (this.MultiSkillData == null)
			{
				this.MultiSkillData = this.CurWorldSkillCdData.InitMultiSkill(id);
				this.MultiSkillData.Init(this.SummonerEntity.Id, id);
				this.MultiSkillData.InitMultiSkillInfo(this.LoadedSkills);
			}
		}
		this.IsMorphVision = isMorphVision;
		this.KeepMultiSkillOnMorphEnd = false;
		this.KeepMultiSkillOnGoDown = false;
		this.EnableAttackInputAction = true;
		this.CheckVisionType = checkVisionType;
	}

	// Token: 0x0601911B RID: 102683 RVA: 0x007A3C00 File Offset: 0x007A1E00
	public unsafe override bool BeginSkill(int skillId, ISkillParam skillParam = null)
	{
		if (skillParam == null)
		{
			skillParam = new SkillParam();
		}
		if (!this.IsMorphVision)
		{
			return base.BeginSkill(skillId, skillParam);
		}
		int num = skillId;
		if (skillParam.CheckMultiSkill.GetValueOrDefault() && this.CurMultiSkillId != 0)
		{
			MultiSkillInfo multiSkillInfo = this.MultiSkillData.GetMultiSkillInfo(this.CurMultiSkillId);
			if (multiSkillInfo != null && multiSkillInfo.NextSkillId.GetValueOrDefault() != 0)
			{
				int? nextSkillId = multiSkillInfo.NextSkillId;
				int firstSkillId = multiSkillInfo.FirstSkillId;
				if (!(nextSkillId.GetValueOrDefault() == firstSkillId & nextSkillId != null))
				{
					num = multiSkillInfo.NextSkillId.Value;
				}
			}
		}
		SSkillInfo skillInfo = base.GetSkillInfo(num);
		if (skillInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "幻象缺少技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		bool flag = this.MultiSkillData.IsMultiSkill(skillInfo);
		if (flag)
		{
			this.TargetMultiSkillId = num;
		}
		if (!base.BeginSkill(num, skillParam))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
			EntityHandle summonerEntity = this.SummonerEntity;
			Entity entity = (summonerEntity != null) ? summonerEntity.Entity : null;
			string message2 = "角色开始幻象变身技能失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", (skillInfo != null) ? new FName?(skillInfo.SkillName) : null);
			instance2.Warn(flag2, entity, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		Skill skill = base.GetSkill(num);
		if (flag && this.TargetMultiSkillId == num)
		{
			this.TryAddEvents(true, true);
			if (this.MultiSkillData.StartMultiSkill(skill, false))
			{
				this.CurMultiSkillId = num;
			}
		}
		this.IsMorph = true;
		return true;
	}

	// Token: 0x0601911C RID: 102684 RVA: 0x007A3DC0 File Offset: 0x007A1FC0
	public void OnMorphEnd()
	{
		if (!this.KeepMultiSkillOnMorphEnd)
		{
			this.ClearMultiSkillState();
		}
		this.IsMorph = false;
	}

	// Token: 0x0601911D RID: 102685 RVA: 0x007A3DD7 File Offset: 0x007A1FD7
	public void ExitMultiSkillState()
	{
		this.ClearMultiSkillState();
	}

	// Token: 0x0601911E RID: 102686 RVA: 0x007A3DDF File Offset: 0x007A1FDF
	public void SetKeepMultiSkillState(bool keepOnMorphEnd, bool keepOnGoDown)
	{
		this.KeepMultiSkillOnMorphEnd = keepOnMorphEnd;
		this.KeepMultiSkillOnGoDown = keepOnGoDown;
	}

	// Token: 0x0601911F RID: 102687 RVA: 0x007A3DEF File Offset: 0x007A1FEF
	public void SetEnableAttackInputAction(bool bEnable)
	{
		this.EnableAttackInputAction = bEnable;
	}

	// Token: 0x06019120 RID: 102688 RVA: 0x007A3DF8 File Offset: 0x007A1FF8
	public bool CanSummonerStartNextMultiSkill()
	{
		if (this.CurMultiSkillId <= 0)
		{
			return false;
		}
		if (this.IsMorph)
		{
			return false;
		}
		MultiSkillInfo multiSkillInfo = this.MultiSkillData.GetMultiSkillInfo(this.CurMultiSkillId);
		if (((multiSkillInfo != null) ? multiSkillInfo.NextSkillId : null).GetValueOrDefault() == 0)
		{
			return false;
		}
		int value = multiSkillInfo.NextSkillId.Value;
		Skill skill = base.GetSkill(value);
		if (skill == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "幻象缺少技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return this.MultiSkillData.CanStartMultiSkill(skill);
	}

	// Token: 0x06019121 RID: 102689 RVA: 0x007A3EA4 File Offset: 0x007A20A4
	public bool IsInMultiSkill()
	{
		if (this.CurMultiSkillId <= 0)
		{
			return false;
		}
		MultiSkillInfo multiSkillInfo = this.MultiSkillData.GetMultiSkillInfo(this.CurMultiSkillId);
		return ((multiSkillInfo != null) ? multiSkillInfo.NextSkillId : null).GetValueOrDefault() != 0;
	}

	// Token: 0x06019122 RID: 102690 RVA: 0x007A3EF0 File Offset: 0x007A20F0
	public void OnVisionAbilityDestroy()
	{
		if (this.CurWorldSkillCdData != null)
		{
			this.CurWorldSkillCdData.RemoveMultiSkill(base.Entity.Id);
			MultiSkillData multiSkillData = this.MultiSkillData;
			if (multiSkillData != null)
			{
				multiSkillData.ClearAllSkill();
			}
		}
		if (this.SummonerEntity != null)
		{
			this.TryRemoveEvents(true, true);
			this.SummonerEntity = null;
		}
		this.CurWorldSkillCdData = null;
		this.MultiSkillData = null;
		this.CurMultiSkillId = 0;
	}

	// Token: 0x06019123 RID: 102691 RVA: 0x007A3F58 File Offset: 0x007A2158
	protected override bool OnEnd()
	{
		this.OnVisionAbilityDestroy();
		return base.OnEnd();
	}

	// Token: 0x06019124 RID: 102692 RVA: 0x007A3F66 File Offset: 0x007A2166
	private void ClearMultiSkillState()
	{
		if (this.CurMultiSkillId != 0)
		{
			this.MultiSkillData.ResetMultiSkills(this.CurMultiSkillId, true);
			this.CurMultiSkillId = 0;
		}
		this.TargetMultiSkillId = 0;
		this.TryRemoveEvents(true, false);
	}

	// Token: 0x06019125 RID: 102693 RVA: 0x007A3F98 File Offset: 0x007A2198
	private void TryAddEvents(bool bCharInputPress, bool bChangeRole)
	{
		EntityHandle summonerEntity = this.SummonerEntity;
		if (summonerEntity == null || !summonerEntity.Valid)
		{
			return;
		}
		this.EnableInput = true;
		WorldEntity entity = this.SummonerEntity.Entity;
		if (bChangeRole && !EventSystem.Instance.HasWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnSummonerDown)))
		{
			EventSystem.Instance.AddWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnSummonerDown));
		}
	}

	// Token: 0x06019126 RID: 102694 RVA: 0x007A4010 File Offset: 0x007A2210
	private void TryRemoveEvents(bool bCharInputPress, bool bChangeRole)
	{
		EntityHandle summonerEntity = this.SummonerEntity;
		if (summonerEntity == null || !summonerEntity.Valid)
		{
			return;
		}
		this.EnableInput = false;
		WorldEntity entity = this.SummonerEntity.Entity;
		if (bChangeRole && EventSystem.Instance.HasWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnSummonerDown)))
		{
			EventSystem.Instance.RemoveWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnSummonerDown));
		}
	}

	// Token: 0x06019127 RID: 102695 RVA: 0x007A4088 File Offset: 0x007A2288
	private unsafe bool OnCharInputPress(EInputAction action)
	{
		if (action != EInputAction.幻象2 && (action != EInputAction.攻击 || !this.EnableAttackInputAction))
		{
			return false;
		}
		if (!this.CheckVisionCreature())
		{
			return false;
		}
		if (this.CurMultiSkillId <= 0)
		{
			return false;
		}
		MultiSkillInfo multiSkillInfo = this.MultiSkillData.GetMultiSkillInfo(this.CurMultiSkillId);
		if (multiSkillInfo == null || multiSkillInfo.NextSkillId.GetValueOrDefault() == 0)
		{
			return false;
		}
		int value = multiSkillInfo.NextSkillId.Value;
		Skill skill = base.GetSkill(value);
		if (skill == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "幻象缺少技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!this.MultiSkillData.CanStartMultiSkill(skill))
		{
			return false;
		}
		EntityHandle summonerEntity = this.SummonerEntity;
		if (summonerEntity == null || !summonerEntity.Valid)
		{
			return false;
		}
		if (this.IsMorph)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = base.Entity;
			string message2 = "使用幻象技能（输入触发下一段）";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("skillId", multiSkillInfo.NextSkillId);
			instance2.Info(flag, entity, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.AbilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(VisionSkillComponent._useNextSkillTagId).Value, null);
			CharacterSkillComponent characterSkillComponent = summonerEntity.Entity.CheckGetComponent<CharacterSkillComponent>();
			int skillId = value;
			SkillParam skillParam = new SkillParam();
			EntityHandle skillTarget = characterSkillComponent.SkillTarget;
			skillParam.Target = ((skillTarget != null) ? skillTarget.Entity : null);
			skillParam.SocketName = characterSkillComponent.SkillTargetSocket;
			skillParam.Reason = "VisionSkill.OnCharInputPress";
			if (!base.BeginSkill(skillId, skillParam))
			{
				CombatLog instance3 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
				Entity entity2 = base.Entity;
				string message3 = "角色幻象变身中使用下一段技能失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", (skill != null) ? new int?(skill.SkillId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", (skill != null) ? skill.SkillName : null);
				instance3.Warn(flag2, entity2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			CombatLog instance4 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
			Entity entity3 = base.Entity;
			string message4 = "角色幻象变身中使用下一段技能成功";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("skillId", multiSkillInfo.NextSkillId);
			instance4.Info(flag3, entity3, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			if (this.MultiSkillData.StartMultiSkill(skill, true))
			{
				this.CurMultiSkillId = value;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019128 RID: 102696 RVA: 0x007A42CB File Offset: 0x007A24CB
	private void OnSummonerDown(double _)
	{
		if (!this.KeepMultiSkillOnGoDown)
		{
			this.ClearMultiSkillState();
		}
	}

	// Token: 0x06019129 RID: 102697 RVA: 0x007A42DB File Offset: 0x007A24DB
	public bool HandlePress(EInputAction action, float time)
	{
		return this.EnableInput && this.OnCharInputPress(action);
	}

	// Token: 0x0601912A RID: 102698 RVA: 0x007A42F0 File Offset: 0x007A24F0
	private bool CheckVisionCreature()
	{
		if (this.CheckVisionType == ECheckVisionType.Vision)
		{
			CharacterVisionComponent component = this.SummonerEntity.Entity.GetComponent<CharacterVisionComponent>();
			long creatureDataId = this.CreatureDataId;
			long? num = (component != null) ? new long?(component.GetVisionCreatureDataId()) : null;
			if (!(creatureDataId == num.GetValueOrDefault() & num != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601912B RID: 102699 RVA: 0x007A4350 File Offset: 0x007A2550
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VisionSkillComponent visionSkillComponent = (VisionSkillComponent)componentTemplate;
		this.CreatureDataId = visionSkillComponent.CreatureDataId;
		if (visionSkillComponent.CurWorldSkillCdData == null)
		{
			this.CurWorldSkillCdData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurWorldSkillCdData), "CurWorldSkillCdData"))
		{
			return false;
		}
		if (visionSkillComponent.SummonerEntity == null)
		{
			this.SummonerEntity = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SummonerEntity), "SummonerEntity"))
		{
			return false;
		}
		if (visionSkillComponent.MultiSkillData == null)
		{
			this.MultiSkillData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MultiSkillData), "MultiSkillData"))
		{
			return false;
		}
		this.CurMultiSkillId = visionSkillComponent.CurMultiSkillId;
		this.TargetMultiSkillId = visionSkillComponent.TargetMultiSkillId;
		this.IsMorphVision = visionSkillComponent.IsMorphVision;
		this.IsMorph = visionSkillComponent.IsMorph;
		this.KeepMultiSkillOnMorphEnd = visionSkillComponent.KeepMultiSkillOnMorphEnd;
		this.KeepMultiSkillOnGoDown = visionSkillComponent.KeepMultiSkillOnGoDown;
		this.EnableAttackInputAction = visionSkillComponent.EnableAttackInputAction;
		this.EnableInput = visionSkillComponent.EnableInput;
		this.CheckVisionType = visionSkillComponent.CheckVisionType;
		return true;
	}

	// Token: 0x170027C9 RID: 10185
	// (get) Token: 0x0601912C RID: 102700 RVA: 0x007A4469 File Offset: 0x007A2669
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CA RID: 10186
	// (get) Token: 0x0601912D RID: 102701 RVA: 0x007A446C File Offset: 0x007A266C
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CB RID: 10187
	// (get) Token: 0x0601912E RID: 102702 RVA: 0x007A446F File Offset: 0x007A266F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CC RID: 10188
	// (get) Token: 0x0601912F RID: 102703 RVA: 0x007A4472 File Offset: 0x007A2672
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CD RID: 10189
	// (get) Token: 0x06019130 RID: 102704 RVA: 0x007A4475 File Offset: 0x007A2675
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CE RID: 10190
	// (get) Token: 0x06019131 RID: 102705 RVA: 0x007A4478 File Offset: 0x007A2678
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027CF RID: 10191
	// (get) Token: 0x06019132 RID: 102706 RVA: 0x007A447B File Offset: 0x007A267B
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027D0 RID: 10192
	// (get) Token: 0x06019133 RID: 102707 RVA: 0x007A447E File Offset: 0x007A267E
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DAF1 RID: 56049
	[StaticVariableRuleIgnore]
	private static int _useNextSkillTagId = GameplayTagDefine.EGameplayTagId["幻象.技能.使用下一段技能"];

	// Token: 0x0400DAF2 RID: 56050
	private long CreatureDataId;

	// Token: 0x0400DAF3 RID: 56051
	private WorldSkillCdData CurWorldSkillCdData;

	// Token: 0x0400DAF4 RID: 56052
	private EntityHandle SummonerEntity;

	// Token: 0x0400DAF5 RID: 56053
	private MultiSkillData MultiSkillData;

	// Token: 0x0400DAF6 RID: 56054
	private int CurMultiSkillId;

	// Token: 0x0400DAF7 RID: 56055
	private int TargetMultiSkillId;

	// Token: 0x0400DAF8 RID: 56056
	private bool IsMorphVision;

	// Token: 0x0400DAF9 RID: 56057
	private bool IsMorph;

	// Token: 0x0400DAFA RID: 56058
	private bool KeepMultiSkillOnMorphEnd;

	// Token: 0x0400DAFB RID: 56059
	private bool KeepMultiSkillOnGoDown;

	// Token: 0x0400DAFC RID: 56060
	private bool EnableAttackInputAction = true;

	// Token: 0x0400DAFD RID: 56061
	private bool EnableInput;

	// Token: 0x0400DAFE RID: 56062
	private ECheckVisionType CheckVisionType;
}
