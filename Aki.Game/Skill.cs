using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020026BB RID: 9915
[NullableContext(1)]
[Nullable(0)]
public class Skill
{
	// Token: 0x17002789 RID: 10121
	// (get) Token: 0x06018D91 RID: 101777 RVA: 0x0078B04A File Offset: 0x0078924A
	// (set) Token: 0x06018D92 RID: 101778 RVA: 0x0078B052 File Offset: 0x00789252
	public long? CombatMessageId
	{
		get
		{
			return this.CombatMessageIdInternal;
		}
		private set
		{
			this.CombatMessageIdInternal = value;
			AddBattleFlag.ApplyEffects(this.SkillComp.Entity, this);
			if (this.BattleContext != null)
			{
				this.BattleContext.VisionId = this.GetVisionId();
			}
		}
	}

	// Token: 0x1700278A RID: 10122
	// (get) Token: 0x06018D93 RID: 101779 RVA: 0x0078B085 File Offset: 0x00789285
	public int SkillId
	{
		get
		{
			return this.SkillIdInternal;
		}
	}

	// Token: 0x1700278B RID: 10123
	// (get) Token: 0x06018D94 RID: 101780 RVA: 0x0078B08D File Offset: 0x0078928D
	public bool Active
	{
		get
		{
			return this.ActiveInternal;
		}
	}

	// Token: 0x1700278C RID: 10124
	// (get) Token: 0x06018D95 RID: 101781 RVA: 0x0078B095 File Offset: 0x00789295
	public bool IsSimulated
	{
		get
		{
			return this.IsSimulatedInternal;
		}
	}

	// Token: 0x1700278D RID: 10125
	// (get) Token: 0x06018D96 RID: 101782 RVA: 0x0078B09D File Offset: 0x0078929D
	[Nullable(2)]
	public SSkillInfo SkillInfo
	{
		[NullableContext(2)]
		get
		{
			return this.SkillInfoInternal;
		}
	}

	// Token: 0x1700278E RID: 10126
	// (get) Token: 0x06018D97 RID: 101783 RVA: 0x0078B0A8 File Offset: 0x007892A8
	public string SkillName
	{
		get
		{
			SSkillInfo skillInfoInternal = this.SkillInfoInternal;
			return ((skillInfoInternal != null) ? skillInfoInternal.SkillName.ToString() : null) ?? "";
		}
	}

	// Token: 0x1700278F RID: 10127
	// (get) Token: 0x06018D98 RID: 101784 RVA: 0x0078B0DE File Offset: 0x007892DE
	public IReadOnlyList<int> SkillTagIds
	{
		get
		{
			return this.SkillTagIdsInternal;
		}
	}

	// Token: 0x17002790 RID: 10128
	// (get) Token: 0x06018D99 RID: 101785 RVA: 0x0078B0E6 File Offset: 0x007892E6
	public IReadOnlyList<ESkillGenre> SkillGenres
	{
		get
		{
			return this.SkillGenresInternal;
		}
	}

	// Token: 0x17002791 RID: 10129
	// (get) Token: 0x06018D9A RID: 101786 RVA: 0x0078B0EE File Offset: 0x007892EE
	[Nullable(2)]
	public UClass AbilityClass
	{
		[NullableContext(2)]
		get
		{
			return this.AbilityClassInternal;
		}
	}

	// Token: 0x17002792 RID: 10130
	// (get) Token: 0x06018D9B RID: 101787 RVA: 0x0078B0F6 File Offset: 0x007892F6
	// (set) Token: 0x06018D9C RID: 101788 RVA: 0x0078B0FE File Offset: 0x007892FE
	public int InterruptLevel
	{
		get
		{
			return this.InterruptLevelInternal;
		}
		set
		{
			this.InterruptLevelInternal = value;
		}
	}

	// Token: 0x06018D9D RID: 101789 RVA: 0x0078B107 File Offset: 0x00789307
	[NullableContext(2)]
	public UAnimMontage GetMontageByIndex(int index)
	{
		if (this.LoadedMontagesInternal == null)
		{
			return null;
		}
		if (index < 0 || index >= this.LoadedMontagesInternal.Length)
		{
			return null;
		}
		return this.LoadedMontagesInternal[index];
	}

	// Token: 0x06018D9E RID: 101790 RVA: 0x0078B12C File Offset: 0x0078932C
	public void SetMontageByIndex(int index, UAnimMontage montage)
	{
		if (this.LoadedMontagesInternal == null)
		{
			this.LoadedMontagesInternal = new UAnimMontage[this.SkillInfo.MontagePaths.Num()];
		}
		if (index < this.LoadedMontagesInternal.Length)
		{
			this.LoadedMontagesInternal[index] = montage;
		}
	}

	// Token: 0x06018D9F RID: 101791 RVA: 0x0078B165 File Offset: 0x00789365
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public UAnimMontage[] GetLoadedMontages()
	{
		return this.LoadedMontagesInternal;
	}

	// Token: 0x06018DA0 RID: 101792 RVA: 0x0078B170 File Offset: 0x00789370
	public int GetPlayingMontageIndex()
	{
		BaseSkillComponent skillComp = this.SkillComp;
		UAnimMontage uanimMontage;
		if (skillComp == null)
		{
			uanimMontage = null;
		}
		else
		{
			UAnimInstance mainAnimInstance = skillComp.GetMainAnimInstance();
			uanimMontage = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
		}
		UAnimMontage uanimMontage2 = uanimMontage;
		if (uanimMontage2 != null && this.LoadedMontagesInternal != null)
		{
			for (int i = 0; i < this.LoadedMontagesInternal.Length; i++)
			{
				if (this.LoadedMontagesInternal[i] == uanimMontage2)
				{
					return i;
				}
			}
		}
		return this.CurrentMontageIndex;
	}

	// Token: 0x06018DA1 RID: 101793 RVA: 0x0078B1D0 File Offset: 0x007893D0
	public void Initialize(int skillId, SSkillInfo skillInfo, BaseSkillComponent skillComponent)
	{
		this.SkillComp = skillComponent;
		this.BuffComp = skillComponent.Entity.GetComponent<CharacterBuffComponent>();
		this.TagComp = skillComponent.Entity.GetComponent<BaseTagComponent>();
		this.ActorComp = skillComponent.Entity.GetComponent<CharacterActorComponent>();
		this.MontageComp = skillComponent.Entity.GetComponent<CharacterMontageComponent>();
		this.TimeScaleComp = skillComponent.Entity.GetComponent<PawnTimeScaleComponent>();
		this.SkillIdInternal = skillId;
		this.SkillInfoInternal = skillInfo;
		this.ActiveInternal = false;
		this.EndSkillInfo = new EndSkillInfo();
		this.InterruptLevelInternal = skillInfo.InterruptLevel;
		this.VisionTagId = 0;
		UDataTable fightDataTable = skillComponent.GetFightDataTable(EFightDataTableKind.Skill, EFightDataTableSourceType.Common);
		if (fightDataTable != null)
		{
			this.IsInCommonSkillDt = (DataTableUtil.GetDataTableRow<SSkillInfo>(fightDataTable, skillId.ToString()) != null);
		}
		this.SkillGenresInternal.Clear();
		this.SkillGenresInternal.AddRange(SkillUtils.GetSkillGenres(skillInfo));
		for (int i = skillInfo.SkillTag.Num() - 1; i >= 0; i--)
		{
			int num = skillInfo.SkillTag.Get(i).TagId();
			if (GameplayTagUtils.IsChildTag(num, VisionTriggerTag.Value))
			{
				this.VisionTagId = num;
			}
			this.SkillTagIdsInternal.Add(num);
		}
		if (skillInfo.SkillMode == ESkillMode.GameplayAbility)
		{
			this.LoadAbility();
		}
		this.LoadMontage();
	}

	// Token: 0x06018DA2 RID: 101794 RVA: 0x0078B318 File Offset: 0x00789518
	public bool Clear()
	{
		if (this.Active)
		{
			this.EndSkill();
		}
		this.ClearBurstLockTimer();
		if (this.AbilityHandle != null)
		{
			this.SkillComp.Entity.GetComponent<BaseAbilityComponent>().ClearAbility(this.AbilityHandle);
			this.AbilityHandle = null;
		}
		this.SkillComp = null;
		this.BuffComp = null;
		this.TagComp = null;
		this.SkillInfoInternal = null;
		this.SkillGenresInternal.Clear();
		this.ActiveAbility = null;
		this.ActiveMontageTask = null;
		this.ActiveInternal = false;
		this.GroupSkillCdInfo = null;
		this.LoadedMontagesInternal = null;
		this.AbilityClassInternal = null;
		this.NeedPlayMontageIndex = -1;
		return true;
	}

	// Token: 0x06018DA3 RID: 101795 RVA: 0x0078B3C4 File Offset: 0x007895C4
	private unsafe void LoadAbility()
	{
		string text = this.SkillInfo.SkillGA.AssetPathName.ToString();
		if (!string.IsNullOrEmpty(text) && text != "None")
		{
			CharacterActorComponent actorComp = this.ActorComp;
			text = (((actorComp != null) ? actorComp.GetReplaceEffect(text) : null) ?? text);
			this.AbilityClassInternal = ResourceSystem.Instance.GetLoadedAsset<UBlueprintGeneratedClass>(text);
			if (this.AbilityClassInternal == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = this.SkillComp.Entity;
				string message = "加载技能GA失败，GA未加载";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("GA", this.SkillInfo.SkillGA);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("GA Path", text);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			GA_Base_C ga_Base_C = UKuroStaticLibrary.GetDefaultObject(this.AbilityClassInternal.ClassStackOnlyPtr) as GA_Base_C;
			if (this.AbilityClassInternal.IsChildOf(Ga_Passive_C.StaticClass()))
			{
				this.SkillComp.SetGaPassiveClassToSkillMap(this.AbilityClassInternal, this.SkillId);
				this.CombatMessageId = this.GetGaPassiveSkillMessage();
			}
			else if (ga_Base_C.AbilityTriggers != null && ga_Base_C.AbilityTriggers.Num() > 0)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
				Entity entity2 = this.SkillComp.Entity;
				string message2 = "被动技能未继承自Ga_Passive";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("GA", this.SkillInfo.SkillGA);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("GA Path", text);
				instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
			this.GiveAbility();
			if (ga_Base_C.StartOnGiven)
			{
				this.SkillComp.StartOnGivenList.Add(this.SkillId);
				return;
			}
		}
		else
		{
			CombatLog instance3 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
			Entity entity3 = this.SkillComp.Entity;
			string message3 = "加载技能GA失败，GA路径为空";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("GA", this.SkillInfo.SkillGA);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("GA Path", text);
			instance3.Error(flag3, entity3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
		}
	}

	// Token: 0x06018DA4 RID: 101796 RVA: 0x0078B6C8 File Offset: 0x007898C8
	private void GiveAbility()
	{
		if (this.AbilityClassInternal != null)
		{
			BaseAbilityComponent component = this.SkillComp.Entity.GetComponent<BaseAbilityComponent>();
			this.AbilityHandle = component.GetAbility(this.AbilityClassInternal.ClassStackOnlyPtr);
		}
	}

	// Token: 0x06018DA5 RID: 101797 RVA: 0x0078B708 File Offset: 0x00789908
	private unsafe void LoadMontage()
	{
		if (this.SkillInfo.Animations.Num() > 0)
		{
			this.LoadedMontagesInternal = new UAnimMontage[this.SkillInfo.Animations.Num()];
			BaseSkillComponent skillComp = this.SkillComp;
			CharacterActorComponent characterActorComponent = (skillComp != null) ? skillComp.Entity.GetComponent<CharacterActorComponent>() : null;
			for (int i = 0; i < this.SkillInfo.Animations.Num(); i++)
			{
				FSoftObjectPath montageSoftObjectPath = this.SkillInfo.Animations.Get(i);
				if (!ObjectUtils.SoftObjectPathIsValid(montageSoftObjectPath))
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
					Entity entity = this.SkillComp.Entity;
					string message = "蒙太奇软路径对象无效，请设置Animations蒙太奇软路径对象";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("索引", i);
					instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				else
				{
					int index = i;
					string text = montageSoftObjectPath.AssetPathName.ToString();
					if (characterActorComponent != null)
					{
						text = (characterActorComponent.GetReplaceMontage(text) ?? text);
					}
					UAnimMontage loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UAnimMontage>(text);
					if (loadedAsset == null || !loadedAsset.IsValid())
					{
						ResourceSystem.Instance.LoadAsync<UAnimMontage>(text, delegate([Nullable(2)] UAnimMontage montage, string _)
						{
							if (montage == null || !montage.IsValid())
							{
								CombatLog instance4 = CombatLog.Instance;
								CombatLog.EDebugModule flag5 = CombatLog.EDebugModule.Skill;
								Entity entity4 = this.SkillComp.Entity;
								string message4 = "蒙太奇加载失败，请检查Animations蒙太奇软路径对象";
								<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("索引", index);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("AssetNamePath", montageSoftObjectPath.AssetPathName);
								instance4.Warn(flag5, entity4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
								return;
							}
							if (this.LoadedMontagesInternal == null)
							{
								return;
							}
							this.LoadedMontagesInternal[index] = montage;
						}, 100, "js_undefined");
					}
					else
					{
						this.LoadedMontagesInternal[index] = loadedAsset;
					}
				}
			}
			return;
		}
		TArray<string> montagePaths = this.SkillInfo.MontagePaths;
		if (montagePaths.Num() > 0)
		{
			bool flag2 = false;
			this.LoadedMontagesInternal = new UAnimMontage[montagePaths.Num()];
			for (int j = 0; j < montagePaths.Num(); j++)
			{
				string text2 = montagePaths.Get(j);
				if (string.IsNullOrEmpty(text2))
				{
					flag2 = true;
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
					Entity entity2 = this.SkillComp.Entity;
					string message2 = "蒙太奇路径为空，请设置MontagePaths蒙太奇路径";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("索引", j);
					instance2.Error(flag3, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
				if (flag2)
				{
					return;
				}
				CharacterMontageComponent montageComp = this.MontageComp;
				UAnimMontage uanimMontage = (montageComp != null) ? montageComp.GetMontageByName(text2, true, true) : null;
				if (uanimMontage != null)
				{
					this.LoadedMontagesInternal[j] = uanimMontage;
				}
				else
				{
					CombatLog instance3 = CombatLog.Instance;
					CombatLog.EDebugModule flag4 = CombatLog.EDebugModule.Skill;
					Entity entity3 = this.SkillComp.Entity;
					string message3 = "蒙太奇未加载";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("技能Id", this.SkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("技能名", this.SkillName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("索引", j);
					instance3.Warn(flag4, entity3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				}
			}
		}
	}

	// Token: 0x06018DA6 RID: 101798 RVA: 0x0078BA7C File Offset: 0x00789C7C
	public void AttachEffect(int effect, Skill.ESkillEffectType type, FName boneName, float whenSkillEndEnableTime)
	{
		List<Skill.ISkillEffect> list;
		if (!this.EffectsAttached.TryGetValue(type, out list))
		{
			list = new List<Skill.ISkillEffect>();
			this.EffectsAttached[type] = list;
		}
		Skill.SkillEffect item = new Skill.SkillEffect
		{
			BoneName = boneName,
			EffectHandle = effect,
			WhenSkillEndEnableTime = whenSkillEndEnableTime
		};
		list.Add(item);
	}

	// Token: 0x06018DA7 RID: 101799 RVA: 0x0078BAD0 File Offset: 0x00789CD0
	private void CloseEffect(Skill.ESkillEffectType type, int handleId, float whenSkillEndEnableTime)
	{
		if (!EffectSystem.Instance.IsValid(handleId))
		{
			return;
		}
		EffectSystem.Instance.SetTimeScale(handleId, 1f, false);
		if (whenSkillEndEnableTime > 0f && EffectSystem.Instance.GetTotalPassTime(handleId) > whenSkillEndEnableTime)
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(handleId);
		EDetachmentRule edetachmentRule = EDetachmentRule.KeepWorld;
		switch (type)
		{
		case Skill.ESkillEffectType.Detach:
			if (sureEffectActor != null)
			{
				sureEffectActor.K2_DetachFromActor(edetachmentRule, edetachmentRule, edetachmentRule);
			}
			EffectUtil.ListenForeverTimeScale(handleId, this.TimeScaleComp);
			EffectSystem.Instance.StopEffectById(handleId, "[Skill.EffectsProcess] Detach", false, null);
			return;
		case Skill.ESkillEffectType.DetachEnd:
			if (sureEffectActor != null)
			{
				sureEffectActor.K2_DetachFromActor(edetachmentRule, edetachmentRule, edetachmentRule);
				EffectUtil.ListenForeverTimeScale(handleId, this.TimeScaleComp);
				EffectSystem.Instance.StopEffectById(handleId, "[Skill.EffectsProcess] DetachEnd", false, null);
				return;
			}
			break;
		case Skill.ESkillEffectType.DetachDestroy:
			if (sureEffectActor != null)
			{
				sureEffectActor.K2_DetachFromActor(edetachmentRule, edetachmentRule, edetachmentRule);
				EffectSystem.Instance.StopEffectById(handleId, "[Skill.EffectsProcess] DetachDestroy", true, null);
				return;
			}
			break;
		case Skill.ESkillEffectType.UnDetachEnd:
			EffectUtil.ListenForeverTimeScale(handleId, this.TimeScaleComp);
			EffectSystem.Instance.StopEffectById(handleId, "[Skill.EffectsProcess] UnDetachEnd", false, null);
			break;
		case Skill.ESkillEffectType.UnDetachDestroy:
			EffectSystem.Instance.StopEffectById(handleId, "[Skill.EffectsProcess] UnDetachDestroy", true, null);
			return;
		default:
			return;
		}
	}

	// Token: 0x06018DA8 RID: 101800 RVA: 0x0078BC14 File Offset: 0x00789E14
	private void ClearEffects()
	{
		if (this.EffectsAttached == null)
		{
			return;
		}
		foreach (KeyValuePair<Skill.ESkillEffectType, List<Skill.ISkillEffect>> keyValuePair in this.EffectsAttached)
		{
			List<Skill.ISkillEffect> value = keyValuePair.Value;
			for (int i = value.Count - 1; i >= 0; i--)
			{
				Skill.ISkillEffect skillEffect = value[i];
				value.RemoveAt(i);
				int effectHandle = skillEffect.EffectHandle;
				this.CloseEffect(keyValuePair.Key, effectHandle, skillEffect.WhenSkillEndEnableTime);
			}
		}
		this.EffectsAttached.Clear();
	}

	// Token: 0x06018DA9 RID: 101801 RVA: 0x0078BCC0 File Offset: 0x00789EC0
	public bool BeginSkill()
	{
		if (this.Active)
		{
			return false;
		}
		this.CurrentMontageIndex = -1;
		this.ActiveInternal = true;
		this.IsSimulatedInternal = false;
		this.CombatMessageId = new long?(CombatMessageModel.Instance.GenMessageId());
		this.MontageContextId = null;
		EndSkillInfo endSkillInfo = this.EndSkillInfo;
		if (endSkillInfo != null)
		{
			endSkillInfo.Reset();
		}
		return true;
	}

	// Token: 0x06018DAA RID: 101802 RVA: 0x0078BD20 File Offset: 0x00789F20
	public void BeginSkillBuffAndTag(int skillLevel)
	{
		this.SkillLevel = skillLevel;
		if (!this.IsSimulated)
		{
			this.StartBurstLockTimer();
		}
		if (this.BuffComp != null)
		{
			int item = this.BuffComp.AddTagWithReturnHandle(this.SkillTagIds, -1f);
			this.ActiveBuffHandles.Add(item);
		}
		if (this.TagComp != null && this.SkillInfo.GroupId == 1)
		{
			if (this.SkillInfo.IsFullBodySkill)
			{
				this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]));
			}
			else
			{
				this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.部分动作"]));
			}
		}
		if (this.BuffComp != null && !this.IsSimulated)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (this.SkillComp.IsStrengthCostEffective(this.SkillInfo.StrengthCost))
			{
				BaseBuffComponent buffComp = this.BuffComp;
				long buffId = 3015L;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = this.BuffComp.CreatureDataId;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("存在体力消耗");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam.PreMessageId = this.CombatMessageId;
				int item2 = buffComp.AddBuffLocal(buffId, addBuffParam);
				this.ActiveBuffHandles.Add(item2);
			}
			CharacterBuffComponent buffComp2 = this.BuffComp;
			EAttributeType attributeId = EAttributeType.SkillToughRatio;
			float rate = this.SkillInfo.ToughRatio - 1f;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("技能");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
			defaultInterpolatedStringHandler.AppendLiteral("技能状态韧性系数");
			int item3 = buffComp2.AddAttributeRateModifierLocal(attributeId, rate, defaultInterpolatedStringHandler.ToStringAndClear());
			this.ActiveBuffHandles.Add(item3);
			float num = this.SkillInfo.ImmuneFallDamageTime;
			bool flag = this.SkillInfo.GroupId == 1;
			if (flag)
			{
				BaseSkillComponent skillComp = this.SkillComp;
				if (((skillComp != null) ? skillComp.Entity : null) != null)
				{
					CreatureDataComponent component = this.SkillComp.Entity.GetComponent<CreatureDataComponent>();
					if (component != null && component.IsRole() && flag && !this.IsInCommonSkillDt)
					{
						num = ((num < 10f) ? 10f : num);
					}
				}
			}
			if (flag && num > 0f)
			{
				BaseBuffComponent buffComp3 = this.BuffComp;
				long buffId2 = 3098L;
				AddBuffParam addBuffParam2 = new AddBuffParam();
				addBuffParam2.InstigatorId = this.BuffComp.CreatureDataId;
				addBuffParam2.Duration = new float?(num);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("跌落伤害保护");
				addBuffParam2.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam2.PreMessageId = this.CombatMessageId;
				int item4 = buffComp3.AddBuffLocal(buffId2, addBuffParam2);
				this.ActiveBuffHandles.Add(item4);
			}
			for (int i = 0; i < this.SkillInfo.SkillBuff.Num(); i++)
			{
				BaseBuffComponent buffComp4 = this.BuffComp;
				long buffId3 = this.SkillInfo.SkillBuff.Get(i);
				AddBuffParam addBuffParam3 = new AddBuffParam();
				addBuffParam3.InstigatorId = this.BuffComp.CreatureDataId;
				addBuffParam3.Level = new int?(skillLevel);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("通过技能期间生效的GE添加");
				addBuffParam3.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam3.PreMessageId = this.CombatMessageId;
				int item5 = buffComp4.AddBuffLocal(buffId3, addBuffParam3);
				this.ActiveBuffHandles.Add(item5);
			}
			for (int j = 0; j < this.SkillInfo.SkillStartBuff.Num(); j++)
			{
				BaseBuffComponent buffComp5 = this.BuffComp;
				long buffId4 = this.SkillInfo.SkillStartBuff.Get(j);
				AddBuffParam addBuffParam4 = new AddBuffParam();
				addBuffParam4.InstigatorId = this.BuffComp.CreatureDataId;
				addBuffParam4.Level = new int?(skillLevel);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("开始时添加");
				addBuffParam4.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam4.PreMessageId = this.CombatMessageId;
				buffComp5.AddBuff(buffId4, addBuffParam4);
			}
			for (int k = 0; k < this.SkillInfo.StartRemoveBuffIds.Num(); k++)
			{
				BaseBuffComponent buffComp6 = this.BuffComp;
				long buffId5 = this.SkillInfo.StartRemoveBuffIds.Get(k);
				int stackCount = -1;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("开始时移除");
				buffComp6.RemoveBuff(buffId5, stackCount, defaultInterpolatedStringHandler.ToStringAndClear(), this.CombatMessageId, null, null);
			}
		}
	}

	// Token: 0x06018DAB RID: 101803 RVA: 0x0078C1D8 File Offset: 0x0078A3D8
	public bool EndSkill()
	{
		if (!this.Active)
		{
			return false;
		}
		this.ClearBurstLockTimer();
		this.InterruptLevel = this.SkillInfo.InterruptLevel;
		this.ActiveInternal = false;
		this.ActiveAbility = null;
		CharacterFightStateComponent fightStateComp = this.SkillComp.FightStateComp;
		if (fightStateComp != null)
		{
			fightStateComp.ExitState(this.FightStateHandle);
		}
		this.ClearMontage();
		this.ClearEffects();
		foreach (int handle in this.ActiveBuffHandles)
		{
			CharacterBuffComponent buffComp = this.BuffComp;
			if (buffComp != null)
			{
				buffComp.RemoveBuffByHandle(handle, -1, "技能结束移除", null, null, null);
			}
		}
		this.ActiveBuffHandles.Clear();
		if (this.TagComp != null && this.SkillInfo.GroupId == 1)
		{
			if (this.SkillInfo.IsFullBodySkill)
			{
				this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]));
			}
			else
			{
				this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.部分动作"]));
			}
		}
		this.SkillBehaviorAnimNotifyMessageId = null;
		if (this.BuffComp != null && !this.IsSimulated)
		{
			for (int i = 0; i < this.SkillInfo.SkillEndBuff.Num(); i++)
			{
				BaseBuffComponent buffComp2 = this.BuffComp;
				long buffId = this.SkillInfo.SkillEndBuff.Get(i);
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = this.BuffComp.CreatureDataId;
				addBuffParam.Level = new int?(this.SkillLevel);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("结束时添加");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam.PreMessageId = this.CombatMessageId;
				buffComp2.AddBuff(buffId, addBuffParam);
			}
			for (int j = 0; j < this.SkillInfo.EndRemoveBuffIds.Num(); j++)
			{
				BaseBuffComponent buffComp3 = this.BuffComp;
				long buffId2 = this.SkillInfo.EndRemoveBuffIds.Get(j);
				int stackCount = -1;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("结束时移除");
				buffComp3.RemoveBuff(buffId2, stackCount, defaultInterpolatedStringHandler.ToStringAndClear(), this.CombatMessageId, null, null);
			}
		}
		this.NeedPlayMontageIndex = -1;
		return true;
	}

	// Token: 0x06018DAC RID: 101804 RVA: 0x0078C488 File Offset: 0x0078A688
	public bool SimulatedBeginSkill(long messageId)
	{
		if (this.Active)
		{
			return false;
		}
		this.ActiveInternal = true;
		this.IsSimulatedInternal = true;
		this.CombatMessageId = new long?(messageId);
		this.NeedPlayMontageIndex = -1;
		this.BeginSkillBuffAndTag(0);
		return true;
	}

	// Token: 0x06018DAD RID: 101805 RVA: 0x0078C4C0 File Offset: 0x0078A6C0
	public void SetTimeDilation(PawnTimeScaleComponent timeScaleComp, float timeDilation)
	{
		foreach (List<Skill.ISkillEffect> list in this.EffectsAttached.Values)
		{
			if (list != null)
			{
				foreach (Skill.ISkillEffect skillEffect in list)
				{
					if (EffectSystem.Instance.IsValid(skillEffect.EffectHandle))
					{
						EffectUtil.SetEffectTimeScale(skillEffect.EffectHandle, timeScaleComp, timeDilation, ETimeScaleType.FollowEntity);
					}
				}
			}
		}
	}

	// Token: 0x06018DAE RID: 101806 RVA: 0x0078C56C File Offset: 0x0078A76C
	[NullableContext(2)]
	public unsafe bool PlayMontage(int index, float rate, [Nullable(1)] string startSection, float startTime, Action<bool> onCompleted = null, Action<bool> onBlendOut = null, long? messageId = null)
	{
		UAnimMontage montageByIndex = this.GetMontageByIndex(index);
		if (montageByIndex == null || !montageByIndex.IsValid())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = this.SkillComp.Entity;
			string message = "PlaySkillMontage 播放的蒙太奇索引不存在";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能id:", this.SkillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名:", this.SkillName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MontageIndex", index);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.CurrentMontageIndex = index;
		TArray<FCompositeSection> compositeSections = montageByIndex.CompositeSections;
		bool flag2 = false;
		for (int i = 0; i < compositeSections.Num(); i++)
		{
			if (compositeSections.Get(i).SectionName.Equals(CharacterNameDefines.Instance.LOOP_SECTION))
			{
				flag2 = true;
				break;
			}
		}
		float num = startTime;
		float sequenceLength = montageByIndex.SequenceLength;
		if (sequenceLength > 0f && num > sequenceLength && flag2)
		{
			num = 0f;
		}
		FName startingSection = FNameUtil.GetDynamicFName(startSection) ?? FNameUtil.EMPTY;
		this.ActiveMontageTask = UAsyncTaskPlayMontageAndWait.ListenForPlayMontage(this.SkillComp.GetMainAnimInstance(), montageByIndex, rate, num, startingSection);
		if (this.ActiveMontageTask.MontageLength <= 0f)
		{
			Action<bool> onCompleted2 = onCompleted;
			if (onCompleted2 != null)
			{
				onCompleted2(true);
			}
			return false;
		}
		if (onCompleted != null)
		{
			this.ActiveMontageTask.EndCallback.Add(delegate(bool isInterrupted)
			{
				onCompleted(isInterrupted);
			});
		}
		if (onBlendOut != null)
		{
			this.ActiveMontageTask.BlendOutCallback.Add(delegate(bool isInterrupted)
			{
				onBlendOut(isInterrupted);
			});
		}
		this.MontageCallback = onCompleted;
		this.MontageContextId = new long?(messageId ?? CombatMessageModel.Instance.GenMessageId());
		BaseMontageComponent montageComp = this.SkillComp.MontageComp;
		if (montageComp != null)
		{
			montageComp.PushMontageInfo(new MontageInfo
			{
				MontageNames = new List<string>(),
				SkillId = new int?(this.SkillId),
				MontageIndex = new int?(index),
				MontageTaskMessageId = this.MontageContextId
			}, montageByIndex);
		}
		return true;
	}

	// Token: 0x06018DAF RID: 101807 RVA: 0x0078C7DC File Offset: 0x0078A9DC
	private void ClearMontage()
	{
		if (this.ActiveMontageTask != null)
		{
			UAnimMontage montageToPlay = this.ActiveMontageTask.MontageToPlay;
			this.ActiveMontageTask.EndTask();
			this.ActiveMontageTask = null;
			this.SkillComp.GetMainAnimInstance().Montage_Stop(0.2f, montageToPlay);
		}
		this.MontageCallback = null;
	}

	// Token: 0x06018DB0 RID: 101808 RVA: 0x0078C82C File Offset: 0x0078AA2C
	public void RequestStopMontage(bool isInterrupted)
	{
		if (this.MontageCallback != null)
		{
			Action<bool> montageCallback = this.MontageCallback;
			this.MontageCallback = null;
			if (montageCallback == null)
			{
				return;
			}
			montageCallback(isInterrupted);
		}
	}

	// Token: 0x06018DB1 RID: 101809 RVA: 0x0078C850 File Offset: 0x0078AA50
	public void SetEffectHidden(bool hidden)
	{
		foreach (List<Skill.ISkillEffect> list in this.EffectsAttached.Values)
		{
			foreach (Skill.ISkillEffect skillEffect in list)
			{
				if (EffectSystem.Instance.IsValid(skillEffect.EffectHandle))
				{
					EffectSystem.Instance.SetEffectHidden(skillEffect.EffectHandle, hidden, "Skill", false);
				}
			}
		}
	}

	// Token: 0x06018DB2 RID: 101810 RVA: 0x0078C900 File Offset: 0x0078AB00
	private void StartBurstLockTimer()
	{
		this.ClearBurstLockTimer();
		float burstLockTime = this.SkillInfo.BurstLockTime;
		PawnTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		if (burstLockTime <= 0f || timeScaleComp == null)
		{
			return;
		}
		TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.BurstLockTimer = null;
			timeScaleComp.RemoveNormalizeTimeScaleLock("Skill.BurstLock", false);
		}, burstLockTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		if (timerHandle == null)
		{
			return;
		}
		this.BurstLockTimer = timerHandle;
		timeScaleComp.AddNormalizeTimeScaleLock("Skill.BurstLock", true);
	}

	// Token: 0x06018DB3 RID: 101811 RVA: 0x0078C991 File Offset: 0x0078AB91
	private void ClearBurstLockTimer()
	{
		if (this.BurstLockTimer != null)
		{
			TimerSystem.Instance.Remove(this.BurstLockTimer);
			this.BurstLockTimer = null;
		}
		PawnTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		if (timeScaleComp == null)
		{
			return;
		}
		timeScaleComp.RemoveNormalizeTimeScaleLock("Skill.BurstLock", false);
	}

	// Token: 0x06018DB4 RID: 101812 RVA: 0x0078C9CC File Offset: 0x0078ABCC
	private long? GetGaPassiveSkillMessage()
	{
		EntityComponentPb entityComponentPb;
		SkillComponentPb skillComponentPb = this.SkillComp.Entity.GetComponent<CreatureDataComponent>().ComponentDataMap.TryGetValue("SkillComponentPb", out entityComponentPb) ? entityComponentPb.SkillComponentPb : null;
		if (skillComponentPb != null && skillComponentPb.GaPassiveSkills != null)
		{
			foreach (GaPassiveSkill gaPassiveSkill in skillComponentPb.GaPassiveSkills)
			{
				if (this.SkillId == (int)gaPassiveSkill.SkillId)
				{
					return new long?(gaPassiveSkill.ContextId);
				}
			}
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity = this.SkillComp.Entity;
		string message = "未找到服务器对应被动ga技能的上下文，检查该技能是否有导出给服务器";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("技能Id", this.SkillId);
		instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06018DB5 RID: 101813 RVA: 0x0078CAB4 File Offset: 0x0078ACB4
	private int GetVisionId()
	{
		if (this.VisionTagId != 0)
		{
			return this.VisionTagId;
		}
		CreatureDataComponent component = this.SkillComp.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
		if (num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				CreatureDataComponent creatureDataComponent = (worldEntity != null) ? worldEntity.GetComponent<CreatureDataComponent>() : null;
				if (((creatureDataComponent != null) ? creatureDataComponent.VisionServerEntityIds : null) != null && creatureDataComponent.VisionServerEntityIds.Contains(component.GetCreatureDataId()))
				{
					int? num4;
					if (worldEntity == null)
					{
						num4 = null;
					}
					else
					{
						CharacterVisionComponent component2 = worldEntity.GetComponent<CharacterVisionComponent>();
						num4 = ((component2 != null) ? new int?(component2.GetVisionId(new int?(0))) : null);
					}
					int? num5 = num4;
					return num5.GetValueOrDefault();
				}
			}
		}
		return 0;
	}

	// Token: 0x0400D7A8 RID: 55208
	private readonly Stat StatAddSpecTag = Stat.Create("Add Spec Tag", "", "");

	// Token: 0x0400D7A9 RID: 55209
	private readonly Stat StatAddInSkillTag = Stat.Create("Add InSkill Tag", "", "");

	// Token: 0x0400D7AA RID: 55210
	private readonly Stat StatAddSpecBuff = Stat.Create("Add Spec Buff", "", "");

	// Token: 0x0400D7AB RID: 55211
	private readonly Stat StatRemoveSpecBuff = Stat.Create("Remove Spec Buff", "", "");

	// Token: 0x0400D7AC RID: 55212
	private readonly Stat StatRemoveSpecBuffTag = Stat.Create("Remove Spec Buff&Tag", "", "");

	// Token: 0x0400D7AD RID: 55213
	private readonly Stat StatRemoveInSkillTag = Stat.Create("Remove InSkill Tag", "", "");

	// Token: 0x0400D7AE RID: 55214
	private readonly Stat StatAddSpecEndBuff = Stat.Create("Add Spec EndBuff", "", "");

	// Token: 0x0400D7AF RID: 55215
	private readonly Stat StatRemoveSpecEndBuff = Stat.Create("Remove Spec EndBuff", "", "");

	// Token: 0x0400D7B0 RID: 55216
	[Nullable(2)]
	public UGameplayAbility ActiveAbility;

	// Token: 0x0400D7B1 RID: 55217
	[Nullable(2)]
	private UAsyncTaskPlayMontageAndWait ActiveMontageTask;

	// Token: 0x0400D7B2 RID: 55218
	[Nullable(2)]
	private Action<bool> MontageCallback;

	// Token: 0x0400D7B3 RID: 55219
	public long? MontageContextId;

	// Token: 0x0400D7B4 RID: 55220
	public long? PreContextId;

	// Token: 0x0400D7B5 RID: 55221
	private long? CombatMessageIdInternal;

	// Token: 0x0400D7B6 RID: 55222
	[Nullable(2)]
	public ISkillBattleContext BattleContext;

	// Token: 0x0400D7B7 RID: 55223
	public long? SkillBehaviorAnimNotifyMessageId;

	// Token: 0x0400D7B8 RID: 55224
	public int FightStateHandle;

	// Token: 0x0400D7B9 RID: 55225
	private int SkillIdInternal;

	// Token: 0x0400D7BA RID: 55226
	private bool ActiveInternal;

	// Token: 0x0400D7BB RID: 55227
	private bool IsSimulatedInternal;

	// Token: 0x0400D7BC RID: 55228
	[Nullable(2)]
	private SSkillInfo SkillInfoInternal;

	// Token: 0x0400D7BD RID: 55229
	[Nullable(2)]
	public GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x0400D7BE RID: 55230
	private readonly List<int> SkillTagIdsInternal = new List<int>();

	// Token: 0x0400D7BF RID: 55231
	private readonly List<ESkillGenre> SkillGenresInternal = new List<ESkillGenre>();

	// Token: 0x0400D7C0 RID: 55232
	private int VisionTagId;

	// Token: 0x0400D7C1 RID: 55233
	[Nullable(2)]
	private UClass AbilityClassInternal;

	// Token: 0x0400D7C2 RID: 55234
	[Nullable(2)]
	private FGameplayAbilitySpecHandle AbilityHandle;

	// Token: 0x0400D7C3 RID: 55235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UAnimMontage[] LoadedMontagesInternal;

	// Token: 0x0400D7C4 RID: 55236
	public const int MONTAGE_INVALID_INDEX = -1;

	// Token: 0x0400D7C5 RID: 55237
	public const int MONTAGE_DEFAULT_INDEX = 0;

	// Token: 0x0400D7C6 RID: 55238
	private const float SPECIAL_SKILL_MIN_IMMUNE_FALL_DAMAGE_TIME = 10f;

	// Token: 0x0400D7C7 RID: 55239
	private const float MONTAGE_BLEND_TIME = 0.2f;

	// Token: 0x0400D7C8 RID: 55240
	private const string BURST_LOCK_KEY = "Skill.BurstLock";

	// Token: 0x0400D7C9 RID: 55241
	public int CurrentMontageIndex = -1;

	// Token: 0x0400D7CA RID: 55242
	public int NeedPlayMontageIndex = -1;

	// Token: 0x0400D7CB RID: 55243
	private readonly List<int> ActiveBuffHandles = new List<int>();

	// Token: 0x0400D7CC RID: 55244
	private readonly Dictionary<Skill.ESkillEffectType, List<Skill.ISkillEffect>> EffectsAttached = new Dictionary<Skill.ESkillEffectType, List<Skill.ISkillEffect>>();

	// Token: 0x0400D7CD RID: 55245
	[Nullable(2)]
	private TimerHandle BurstLockTimer;

	// Token: 0x0400D7CE RID: 55246
	private int InterruptLevelInternal;

	// Token: 0x0400D7CF RID: 55247
	public FVectorDouble? ExtraTargetLocation;

	// Token: 0x0400D7D0 RID: 55248
	private int SkillLevel;

	// Token: 0x0400D7D1 RID: 55249
	[Nullable(2)]
	public EndSkillInfo EndSkillInfo;

	// Token: 0x0400D7D2 RID: 55250
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D7D3 RID: 55251
	[Nullable(2)]
	private CharacterBuffComponent BuffComp;

	// Token: 0x0400D7D4 RID: 55252
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D7D5 RID: 55253
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D7D6 RID: 55254
	[Nullable(2)]
	private CharacterMontageComponent MontageComp;

	// Token: 0x0400D7D7 RID: 55255
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400D7D8 RID: 55256
	private bool IsInCommonSkillDt;

	// Token: 0x020088D7 RID: 35031
	[NullableContext(0)]
	public enum ESkillEffectType
	{
		// Token: 0x0402BB73 RID: 179059
		None,
		// Token: 0x0402BB74 RID: 179060
		UnDetach,
		// Token: 0x0402BB75 RID: 179061
		Detach,
		// Token: 0x0402BB76 RID: 179062
		DetachEnd,
		// Token: 0x0402BB77 RID: 179063
		DetachDestroy,
		// Token: 0x0402BB78 RID: 179064
		UnDetachEnd,
		// Token: 0x0402BB79 RID: 179065
		UnDetachDestroy
	}

	// Token: 0x020088D8 RID: 35032
	private interface ISkillEffect
	{
		// Token: 0x170078BA RID: 30906
		// (get) Token: 0x0604281D RID: 272413
		// (set) Token: 0x0604281E RID: 272414
		int EffectHandle { get; set; }

		// Token: 0x170078BB RID: 30907
		// (get) Token: 0x0604281F RID: 272415
		// (set) Token: 0x06042820 RID: 272416
		FName BoneName { get; set; }

		// Token: 0x170078BC RID: 30908
		// (get) Token: 0x06042821 RID: 272417
		// (set) Token: 0x06042822 RID: 272418
		float WhenSkillEndEnableTime { get; set; }
	}

	// Token: 0x020088D9 RID: 35033
	[NullableContext(0)]
	private class SkillEffect : Skill.ISkillEffect
	{
		// Token: 0x170078BD RID: 30909
		// (get) Token: 0x06042823 RID: 272419 RVA: 0x013C3027 File Offset: 0x013C1227
		// (set) Token: 0x06042824 RID: 272420 RVA: 0x013C302F File Offset: 0x013C122F
		public int EffectHandle { get; set; }

		// Token: 0x170078BE RID: 30910
		// (get) Token: 0x06042825 RID: 272421 RVA: 0x013C3038 File Offset: 0x013C1238
		// (set) Token: 0x06042826 RID: 272422 RVA: 0x013C3040 File Offset: 0x013C1240
		public FName BoneName { get; set; }

		// Token: 0x170078BF RID: 30911
		// (get) Token: 0x06042827 RID: 272423 RVA: 0x013C3049 File Offset: 0x013C1249
		// (set) Token: 0x06042828 RID: 272424 RVA: 0x013C3051 File Offset: 0x013C1251
		public float WhenSkillEndEnableTime { get; set; }
	}
}
