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

// Token: 0x0200314E RID: 12622
[NullableContext(1)]
[Nullable(0)]
public class Skill
{
	// Token: 0x17002598 RID: 9624
	// (get) Token: 0x0601B28C RID: 111244 RVA: 0x00763689 File Offset: 0x00761889
	// (set) Token: 0x0601B28D RID: 111245 RVA: 0x00763691 File Offset: 0x00761891
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

	// Token: 0x17002599 RID: 9625
	// (get) Token: 0x0601B28E RID: 111246 RVA: 0x007636C4 File Offset: 0x007618C4
	public int SkillId
	{
		get
		{
			return this.SkillIdInternal;
		}
	}

	// Token: 0x1700259A RID: 9626
	// (get) Token: 0x0601B28F RID: 111247 RVA: 0x007636CC File Offset: 0x007618CC
	public bool Active
	{
		get
		{
			return this.ActiveInternal;
		}
	}

	// Token: 0x1700259B RID: 9627
	// (get) Token: 0x0601B290 RID: 111248 RVA: 0x007636D4 File Offset: 0x007618D4
	public bool IsSimulated
	{
		get
		{
			return this.IsSimulatedInternal;
		}
	}

	// Token: 0x1700259C RID: 9628
	// (get) Token: 0x0601B291 RID: 111249 RVA: 0x007636DC File Offset: 0x007618DC
	[Nullable(2)]
	public SSkillInfo SkillInfo
	{
		[NullableContext(2)]
		get
		{
			return this.SkillInfoInternal;
		}
	}

	// Token: 0x1700259D RID: 9629
	// (get) Token: 0x0601B292 RID: 111250 RVA: 0x007636E4 File Offset: 0x007618E4
	public string SkillName
	{
		get
		{
			SSkillInfo skillInfoInternal = this.SkillInfoInternal;
			return ((skillInfoInternal != null) ? skillInfoInternal.SkillName.ToString() : null) ?? "";
		}
	}

	// Token: 0x1700259E RID: 9630
	// (get) Token: 0x0601B293 RID: 111251 RVA: 0x0076371A File Offset: 0x0076191A
	public IReadOnlyList<int> SkillTagIds
	{
		get
		{
			return this.SkillTagIdsInternal;
		}
	}

	// Token: 0x1700259F RID: 9631
	// (get) Token: 0x0601B294 RID: 111252 RVA: 0x00763722 File Offset: 0x00761922
	public IReadOnlyList<ESkillGenre> SkillGenres
	{
		get
		{
			return this.SkillGenresInternal;
		}
	}

	// Token: 0x170025A0 RID: 9632
	// (get) Token: 0x0601B295 RID: 111253 RVA: 0x0076372A File Offset: 0x0076192A
	[Nullable(2)]
	public UClass AbilityClass
	{
		[NullableContext(2)]
		get
		{
			return this.AbilityClassInternal;
		}
	}

	// Token: 0x170025A1 RID: 9633
	// (get) Token: 0x0601B296 RID: 111254 RVA: 0x00763732 File Offset: 0x00761932
	// (set) Token: 0x0601B297 RID: 111255 RVA: 0x0076373A File Offset: 0x0076193A
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

	// Token: 0x0601B298 RID: 111256 RVA: 0x00763743 File Offset: 0x00761943
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

	// Token: 0x0601B299 RID: 111257 RVA: 0x00763768 File Offset: 0x00761968
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

	// Token: 0x0601B29A RID: 111258 RVA: 0x007637A1 File Offset: 0x007619A1
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public UAnimMontage[] GetLoadedMontages()
	{
		return this.LoadedMontagesInternal;
	}

	// Token: 0x0601B29B RID: 111259 RVA: 0x007637AC File Offset: 0x007619AC
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

	// Token: 0x0601B29C RID: 111260 RVA: 0x0076380C File Offset: 0x00761A0C
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

	// Token: 0x0601B29D RID: 111261 RVA: 0x00763954 File Offset: 0x00761B54
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

	// Token: 0x0601B29E RID: 111262 RVA: 0x00763A00 File Offset: 0x00761C00
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

	// Token: 0x0601B29F RID: 111263 RVA: 0x00763D04 File Offset: 0x00761F04
	private void GiveAbility()
	{
		if (this.AbilityClassInternal != null)
		{
			BaseAbilityComponent component = this.SkillComp.Entity.GetComponent<BaseAbilityComponent>();
			this.AbilityHandle = component.GetAbility(this.AbilityClassInternal.ClassStackOnlyPtr);
		}
	}

	// Token: 0x0601B2A0 RID: 111264 RVA: 0x00763D44 File Offset: 0x00761F44
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

	// Token: 0x0601B2A1 RID: 111265 RVA: 0x007640B8 File Offset: 0x007622B8
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

	// Token: 0x0601B2A2 RID: 111266 RVA: 0x0076410C File Offset: 0x0076230C
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

	// Token: 0x0601B2A3 RID: 111267 RVA: 0x00764250 File Offset: 0x00762450
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

	// Token: 0x0601B2A4 RID: 111268 RVA: 0x007642FC File Offset: 0x007624FC
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

	// Token: 0x0601B2A5 RID: 111269 RVA: 0x0076435C File Offset: 0x0076255C
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

	// Token: 0x0601B2A6 RID: 111270 RVA: 0x00764814 File Offset: 0x00762A14
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

	// Token: 0x0601B2A7 RID: 111271 RVA: 0x00764AC4 File Offset: 0x00762CC4
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

	// Token: 0x0601B2A8 RID: 111272 RVA: 0x00764AFC File Offset: 0x00762CFC
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

	// Token: 0x0601B2A9 RID: 111273 RVA: 0x00764BA8 File Offset: 0x00762DA8
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

	// Token: 0x0601B2AA RID: 111274 RVA: 0x00764E18 File Offset: 0x00763018
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

	// Token: 0x0601B2AB RID: 111275 RVA: 0x00764E68 File Offset: 0x00763068
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

	// Token: 0x0601B2AC RID: 111276 RVA: 0x00764E8C File Offset: 0x0076308C
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

	// Token: 0x0601B2AD RID: 111277 RVA: 0x00764F3C File Offset: 0x0076313C
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

	// Token: 0x0601B2AE RID: 111278 RVA: 0x00764FCD File Offset: 0x007631CD
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

	// Token: 0x0601B2AF RID: 111279 RVA: 0x00765008 File Offset: 0x00763208
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

	// Token: 0x0601B2B0 RID: 111280 RVA: 0x007650F0 File Offset: 0x007632F0
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

	// Token: 0x0400D345 RID: 54085
	private readonly Stat StatAddSpecTag = Stat.Create("Add Spec Tag", "", "");

	// Token: 0x0400D346 RID: 54086
	private readonly Stat StatAddInSkillTag = Stat.Create("Add InSkill Tag", "", "");

	// Token: 0x0400D347 RID: 54087
	private readonly Stat StatAddSpecBuff = Stat.Create("Add Spec Buff", "", "");

	// Token: 0x0400D348 RID: 54088
	private readonly Stat StatRemoveSpecBuff = Stat.Create("Remove Spec Buff", "", "");

	// Token: 0x0400D349 RID: 54089
	private readonly Stat StatRemoveSpecBuffTag = Stat.Create("Remove Spec Buff&Tag", "", "");

	// Token: 0x0400D34A RID: 54090
	private readonly Stat StatRemoveInSkillTag = Stat.Create("Remove InSkill Tag", "", "");

	// Token: 0x0400D34B RID: 54091
	private readonly Stat StatAddSpecEndBuff = Stat.Create("Add Spec EndBuff", "", "");

	// Token: 0x0400D34C RID: 54092
	private readonly Stat StatRemoveSpecEndBuff = Stat.Create("Remove Spec EndBuff", "", "");

	// Token: 0x0400D34D RID: 54093
	[Nullable(2)]
	public UGameplayAbility ActiveAbility;

	// Token: 0x0400D34E RID: 54094
	[Nullable(2)]
	private UAsyncTaskPlayMontageAndWait ActiveMontageTask;

	// Token: 0x0400D34F RID: 54095
	[Nullable(2)]
	private Action<bool> MontageCallback;

	// Token: 0x0400D350 RID: 54096
	public long? MontageContextId;

	// Token: 0x0400D351 RID: 54097
	public long? PreContextId;

	// Token: 0x0400D352 RID: 54098
	private long? CombatMessageIdInternal;

	// Token: 0x0400D353 RID: 54099
	[Nullable(2)]
	public ISkillBattleContext BattleContext;

	// Token: 0x0400D354 RID: 54100
	public long? SkillBehaviorAnimNotifyMessageId;

	// Token: 0x0400D355 RID: 54101
	public int FightStateHandle;

	// Token: 0x0400D356 RID: 54102
	private int SkillIdInternal;

	// Token: 0x0400D357 RID: 54103
	private bool ActiveInternal;

	// Token: 0x0400D358 RID: 54104
	private bool IsSimulatedInternal;

	// Token: 0x0400D359 RID: 54105
	[Nullable(2)]
	private SSkillInfo SkillInfoInternal;

	// Token: 0x0400D35A RID: 54106
	[Nullable(2)]
	public GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x0400D35B RID: 54107
	private readonly List<int> SkillTagIdsInternal = new List<int>();

	// Token: 0x0400D35C RID: 54108
	private readonly List<ESkillGenre> SkillGenresInternal = new List<ESkillGenre>();

	// Token: 0x0400D35D RID: 54109
	private int VisionTagId;

	// Token: 0x0400D35E RID: 54110
	[Nullable(2)]
	private UClass AbilityClassInternal;

	// Token: 0x0400D35F RID: 54111
	[Nullable(2)]
	private FGameplayAbilitySpecHandle AbilityHandle;

	// Token: 0x0400D360 RID: 54112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UAnimMontage[] LoadedMontagesInternal;

	// Token: 0x0400D361 RID: 54113
	public const int MONTAGE_INVALID_INDEX = -1;

	// Token: 0x0400D362 RID: 54114
	public const int MONTAGE_DEFAULT_INDEX = 0;

	// Token: 0x0400D363 RID: 54115
	private const float SPECIAL_SKILL_MIN_IMMUNE_FALL_DAMAGE_TIME = 10f;

	// Token: 0x0400D364 RID: 54116
	private const float MONTAGE_BLEND_TIME = 0.2f;

	// Token: 0x0400D365 RID: 54117
	private const string BURST_LOCK_KEY = "Skill.BurstLock";

	// Token: 0x0400D366 RID: 54118
	public int CurrentMontageIndex = -1;

	// Token: 0x0400D367 RID: 54119
	public int NeedPlayMontageIndex = -1;

	// Token: 0x0400D368 RID: 54120
	private readonly List<int> ActiveBuffHandles = new List<int>();

	// Token: 0x0400D369 RID: 54121
	private readonly Dictionary<Skill.ESkillEffectType, List<Skill.ISkillEffect>> EffectsAttached = new Dictionary<Skill.ESkillEffectType, List<Skill.ISkillEffect>>();

	// Token: 0x0400D36A RID: 54122
	[Nullable(2)]
	private TimerHandle BurstLockTimer;

	// Token: 0x0400D36B RID: 54123
	private int InterruptLevelInternal;

	// Token: 0x0400D36C RID: 54124
	public FVectorDouble? ExtraTargetLocation;

	// Token: 0x0400D36D RID: 54125
	private int SkillLevel;

	// Token: 0x0400D36E RID: 54126
	[Nullable(2)]
	public EndSkillInfo EndSkillInfo;

	// Token: 0x0400D36F RID: 54127
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D370 RID: 54128
	[Nullable(2)]
	private CharacterBuffComponent BuffComp;

	// Token: 0x0400D371 RID: 54129
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D372 RID: 54130
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D373 RID: 54131
	[Nullable(2)]
	private CharacterMontageComponent MontageComp;

	// Token: 0x0400D374 RID: 54132
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400D375 RID: 54133
	private bool IsInCommonSkillDt;

	// Token: 0x020096B1 RID: 38577
	[NullableContext(0)]
	public enum ESkillEffectType
	{
		// Token: 0x040304DE RID: 197854
		None,
		// Token: 0x040304DF RID: 197855
		UnDetach,
		// Token: 0x040304E0 RID: 197856
		Detach,
		// Token: 0x040304E1 RID: 197857
		DetachEnd,
		// Token: 0x040304E2 RID: 197858
		DetachDestroy,
		// Token: 0x040304E3 RID: 197859
		UnDetachEnd,
		// Token: 0x040304E4 RID: 197860
		UnDetachDestroy
	}

	// Token: 0x020096B2 RID: 38578
	private interface ISkillEffect
	{
		// Token: 0x1700A12B RID: 41259
		// (get) Token: 0x0604C38F RID: 312207
		// (set) Token: 0x0604C390 RID: 312208
		int EffectHandle { get; set; }

		// Token: 0x1700A12C RID: 41260
		// (get) Token: 0x0604C391 RID: 312209
		// (set) Token: 0x0604C392 RID: 312210
		FName BoneName { get; set; }

		// Token: 0x1700A12D RID: 41261
		// (get) Token: 0x0604C393 RID: 312211
		// (set) Token: 0x0604C394 RID: 312212
		float WhenSkillEndEnableTime { get; set; }
	}

	// Token: 0x020096B3 RID: 38579
	[NullableContext(0)]
	private class SkillEffect : Skill.ISkillEffect
	{
		// Token: 0x1700A12E RID: 41262
		// (get) Token: 0x0604C395 RID: 312213 RVA: 0x014183EF File Offset: 0x014165EF
		// (set) Token: 0x0604C396 RID: 312214 RVA: 0x014183F7 File Offset: 0x014165F7
		public int EffectHandle { get; set; }

		// Token: 0x1700A12F RID: 41263
		// (get) Token: 0x0604C397 RID: 312215 RVA: 0x01418400 File Offset: 0x01416600
		// (set) Token: 0x0604C398 RID: 312216 RVA: 0x01418408 File Offset: 0x01416608
		public FName BoneName { get; set; }

		// Token: 0x1700A130 RID: 41264
		// (get) Token: 0x0604C399 RID: 312217 RVA: 0x01418411 File Offset: 0x01416611
		// (set) Token: 0x0604C39A RID: 312218 RVA: 0x01418419 File Offset: 0x01416619
		public float WhenSkillEndEnableTime { get; set; }
	}
}
