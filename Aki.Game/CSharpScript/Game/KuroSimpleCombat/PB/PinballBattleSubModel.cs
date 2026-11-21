using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006145 RID: 24901
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleSubModel : KscSubModelBase
	{
		// Token: 0x0603BAB6 RID: 244406 RVA: 0x010EE224 File Offset: 0x010EC424
		protected override bool OnInit()
		{
			PinballWorldConfig? worldConfigCache = null;
			int mapId = GameModeModel.Instance.MapConfig.MapId;
			if (mapId != 0)
			{
				worldConfigCache = PinballBattleConfig.Instance.GetWorldConfigByMapId(mapId);
			}
			if (worldConfigCache == null)
			{
				worldConfigCache = PinballBattleConfig.Instance.GetWorldConfig(1);
			}
			this.WorldConfigCache = worldConfigCache;
			PinballBattleHeadStateManager pinballBattleHeadStateManager = this.PinballBattleHeadStateManager;
			if (pinballBattleHeadStateManager != null)
			{
				pinballBattleHeadStateManager.Init();
			}
			return true;
		}

		// Token: 0x0603BAB7 RID: 244407 RVA: 0x010EE28C File Offset: 0x010EC48C
		protected override bool OnClear()
		{
			this.WorldConfigCache = null;
			this.BulletDataTable = null;
			this.ShapeWorldDa = null;
			this.ShapeWorldBoundsDa = null;
			this.ShapeMaterialDt = null;
			this.DefaultAttrs = null;
			PinballBattleHeadStateManager pinballBattleHeadStateManager = this.PinballBattleHeadStateManager;
			if (pinballBattleHeadStateManager != null)
			{
				pinballBattleHeadStateManager.Clear();
			}
			this.PinballPropertyConfigs.Clear();
			this.LoadedBuffDaMap.Clear();
			this.RoleBornBuffsMap.Clear();
			this.PinballMonsterAttrConfigs.Clear();
			this.MonsterAttrRate.Clear();
			this.RoleBaseAttrsRecord.Clear();
			this.GameState = 0;
			this.LevelId = 0;
			this.CurWave = 1;
			this.UsedReviveTime = 0;
			this.MaxReviveTime = 0;
			this.FormationData = null;
			this.Score = 0f;
			this.Combo = 0;
			this.LevelScoreTargetList.Clear();
			this.MaxScore = 0f;
			this.StarInfo = new int[3];
			this.PreloadFormationData = null;
			this.RoleTotalMap.Clear();
			this.DashTimes = 0;
			this.FullEnergyTimes = 0;
			this.AttackTimes = 0;
			this.BossSkillTimes = 0;
			this.FirstWaveMonsterTracker.Reset();
			this.CurWaveMachineTracker.Reset();
			return true;
		}

		// Token: 0x0603BAB8 RID: 244408 RVA: 0x010EE3C0 File Offset: 0x010EC5C0
		public override string GetSkillDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().SkillDtPath : null) ?? "";
		}

		// Token: 0x0603BAB9 RID: 244409 RVA: 0x010EE3F8 File Offset: 0x010EC5F8
		public override string GetEntityDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().EntityDtPath : null) ?? "";
		}

		// Token: 0x0603BABA RID: 244410 RVA: 0x010EE430 File Offset: 0x010EC630
		public string GetBulletDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().BulletDtPath : null) ?? "";
		}

		// Token: 0x0603BABB RID: 244411 RVA: 0x010EE468 File Offset: 0x010EC668
		public string GetWorldDaPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeWorldDaPath : null) ?? "";
		}

		// Token: 0x0603BABC RID: 244412 RVA: 0x010EE4A0 File Offset: 0x010EC6A0
		public string GetWorldBoundsDaPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeWorldBoundsDaPath : null) ?? "";
		}

		// Token: 0x0603BABD RID: 244413 RVA: 0x010EE4D8 File Offset: 0x010EC6D8
		public string GetShapeMaterialDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeMaterialDtPath : null) ?? "";
		}

		// Token: 0x0603BABE RID: 244414 RVA: 0x010EE510 File Offset: 0x010EC710
		[NullableContext(2)]
		public IPinballBattleCombatInfo GetEntity(int uid)
		{
			IPinballBattleCombatInfo result;
			if (!this.AllEntities.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0603BABF RID: 244415 RVA: 0x010EE530 File Offset: 0x010EC730
		public void GetAllEntities(List<IPinballBattleCombatInfo> entities)
		{
			entities.Clear();
			foreach (IPinballBattleCombatInfo item in this.AllEntities.Values)
			{
				entities.Add(item);
			}
		}

		// Token: 0x0603BAC0 RID: 244416 RVA: 0x010EE590 File Offset: 0x010EC790
		[return: Nullable(2)]
		public string TryAddEntity(IPinballBattleCombatInfo entityModel)
		{
			if (entityModel == null || !entityModel.IsValid())
			{
				return "实体数据无效";
			}
			int uid = entityModel.Uid;
			if (this.AllEntities.ContainsKey(uid))
			{
				return "实体数据已存在";
			}
			this.AllEntities[uid] = entityModel;
			return null;
		}

		// Token: 0x0603BAC1 RID: 244417 RVA: 0x010EE5D8 File Offset: 0x010EC7D8
		[NullableContext(2)]
		public IPinballBattleCombatInfo RemoveEntity(int uid)
		{
			IPinballBattleCombatInfo result;
			if (this.AllEntities.TryGetValue(uid, out result))
			{
				this.AllEntities.Remove(uid);
			}
			return result;
		}

		// Token: 0x0603BAC2 RID: 244418 RVA: 0x010EE603 File Offset: 0x010EC803
		public void SetRoleId2CreatureId(int roleId, int creatureId)
		{
			this.TeamRoleId2CreatureId[roleId] = creatureId;
		}

		// Token: 0x0603BAC3 RID: 244419 RVA: 0x010EE614 File Offset: 0x010EC814
		[NullableContext(2)]
		public KscEntityHandle GetKscEntityByRoleId(int roleId)
		{
			int num;
			if (!this.TeamRoleId2CreatureId.TryGetValue(roleId, out num))
			{
				return null;
			}
			return base.GetKscEntityHandle((long)num);
		}

		// Token: 0x0603BAC4 RID: 244420 RVA: 0x010EE63C File Offset: 0x010EC83C
		public int? GetRoleIdByEntityId(int entityId)
		{
			long entityCreatureId = base.GetEntityCreatureId(entityId);
			foreach (KeyValuePair<int, int> keyValuePair in this.TeamRoleId2CreatureId)
			{
				if ((long)keyValuePair.Value == entityCreatureId)
				{
					return new int?(keyValuePair.Key);
				}
			}
			return null;
		}

		// Token: 0x0603BAC5 RID: 244421 RVA: 0x010EE6B8 File Offset: 0x010EC8B8
		public int? GetRoleSlotIndex(int roleId)
		{
			if (this.FormationData == null)
			{
				return null;
			}
			for (int i = 0; i < this.FormationData.Count; i++)
			{
				if (this.FormationData[i].RoleId == roleId)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x0603BAC6 RID: 244422 RVA: 0x010EE714 File Offset: 0x010EC914
		public void SetFormationData(List<PinballFormationRolePb> formationData)
		{
			if (this.FormationData != null)
			{
				return;
			}
			this.FormationData = formationData;
			this.RoleTotalMap.Clear();
			foreach (PinballFormationRolePb pinballFormationRolePb in this.FormationData)
			{
				this.RoleTotalMap[pinballFormationRolePb.RoleId] = new PinballRoleTotalInfo
				{
					Damage = 0f,
					SkillTimes = 0,
					DropCostHp = 0f,
					HitCostHp = 0f,
					DieTimes = 0,
					ReviveTimes = 0
				};
			}
		}

		// Token: 0x0603BAC7 RID: 244423 RVA: 0x010EE7C8 File Offset: 0x010EC9C8
		public void SetLevelScoreTargetList(IEnumerable<float> levelScoreTargetList)
		{
			this.LevelScoreTargetList.Clear();
			this.LevelScoreTargetList.AddRange(levelScoreTargetList);
			this.MaxScore = this.LevelScoreTargetList[this.LevelScoreTargetList.Count - 1];
		}

		// Token: 0x0603BAC8 RID: 244424 RVA: 0x010EE800 File Offset: 0x010ECA00
		public void SetScore(float newScore)
		{
			if (this.MaxScore > 0f && this.Score >= this.MaxScore)
			{
				return;
			}
			float num = (this.MaxScore > 0f) ? 1f : newScore;
			float num2 = (newScore < num) ? num : newScore;
			if (num2 == this.Score)
			{
				return;
			}
			if (this.MaxScore > 0f && num2 > this.MaxScore)
			{
				this.Score = this.MaxScore;
			}
			else
			{
				this.Score = num2;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPinballScoreChanged, (int)num2);
		}

		// Token: 0x0603BAC9 RID: 244425 RVA: 0x010EE891 File Offset: 0x010ECA91
		public void SetCombo(int newCombo)
		{
			if (newCombo == this.Combo)
			{
				return;
			}
			this.Combo = newCombo;
			EventSystem.Instance.Emit<int>(EEventName.OnPinballComboChanged, newCombo);
		}

		// Token: 0x0603BACA RID: 244426 RVA: 0x010EE8B8 File Offset: 0x010ECAB8
		public void UpdateDamageInfo(TMap<int, int> damageInfo)
		{
			float num = 0f;
			foreach (KeyValuePair<int, int> keyValuePair in damageInfo)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int entityId = num2;
				int num4 = num3;
				int valueOrDefault = this.GetRoleIdByEntityId(entityId).GetValueOrDefault();
				if (valueOrDefault != 0)
				{
					PinballRoleTotalInfo pinballRoleTotalInfo;
					if (this.RoleTotalMap.TryGetValue(valueOrDefault, out pinballRoleTotalInfo))
					{
						pinballRoleTotalInfo.Damage = (float)num4;
					}
					num += (float)num4;
				}
			}
			float score = num * this.ScoreRatio;
			this.SetScore(score);
		}

		// Token: 0x0603BACB RID: 244427 RVA: 0x010EE960 File Offset: 0x010ECB60
		public PinballSettlePayload GetPayloadData()
		{
			PinballSettlePayload pinballSettlePayload = PinballSettlePayload.Create();
			pinballSettlePayload.Score = (int)this.Score;
			pinballSettlePayload.DashTimes = this.DashTimes;
			pinballSettlePayload.FullEnergyTimes = this.FullEnergyTimes;
			pinballSettlePayload.AttackTimes = this.AttackTimes;
			pinballSettlePayload.BossSkillTimes = this.BossSkillTimes;
			if (this.FormationData != null)
			{
				foreach (PinballFormationRolePb pinballFormationRolePb in this.FormationData)
				{
					PinballResultRolePb pinballResultRolePb = PinballResultRolePb.Create();
					pinballResultRolePb.RoleId = pinballFormationRolePb.RoleId;
					PinballRoleTotalInfo pinballRoleTotalInfo;
					if (this.RoleTotalMap.TryGetValue(pinballFormationRolePb.RoleId, out pinballRoleTotalInfo))
					{
						pinballResultRolePb.Damage = (long)((int)pinballRoleTotalInfo.Damage);
						pinballResultRolePb.SkillTimes = pinballRoleTotalInfo.SkillTimes;
						pinballResultRolePb.DropCostHp = (long)((int)pinballRoleTotalInfo.DropCostHp);
						pinballResultRolePb.HitCostHp = (long)((int)pinballRoleTotalInfo.HitCostHp);
						pinballResultRolePb.TempDieTimes = pinballRoleTotalInfo.DieTimes;
						pinballResultRolePb.TempReviveTimes = pinballRoleTotalInfo.ReviveTimes;
					}
					pinballSettlePayload.RolePbs.Add(pinballResultRolePb);
				}
			}
			return pinballSettlePayload;
		}

		// Token: 0x0603BACC RID: 244428 RVA: 0x010EEA88 File Offset: 0x010ECC88
		public bool CheckBonusFullWin()
		{
			return this.MaxScore > 0f && this.Score >= this.MaxScore;
		}

		// Token: 0x0603BACD RID: 244429 RVA: 0x010EEAAC File Offset: 0x010ECCAC
		public void GetRoleBornAttrs(PinballFormationRolePb roleData, Dictionary<EKSC_AttrType, float> outAttrs)
		{
			PinballBattleConfig instance = PinballBattleConfig.Instance;
			if (instance.GetRoleConfig(roleData.RoleId) != null)
			{
				PinballRoleLevelConfig? roleLevelConfig = instance.GetRoleLevelConfig(roleData.LevelId);
				if (roleLevelConfig != null)
				{
					PinballAttr? attrConfig = instance.GetAttrConfig(roleLevelConfig.Value.Prop);
					if (attrConfig != null)
					{
						this.LoadAttrFromConfig(outAttrs, attrConfig.Value, false);
					}
				}
			}
			if (roleData.HasWeapon)
			{
				PinballWeaponConfig? weaponConfig = instance.GetWeaponConfig(roleData.WeaponId);
				if (weaponConfig != null)
				{
					for (int i = 0; i < weaponConfig.Value.PropListLength; i++)
					{
						int configId = weaponConfig.Value.PropList(i);
						PinballWeaponAttr? weaponAttrConfig = instance.GetWeaponAttrConfig(configId);
						if (weaponAttrConfig != null && weaponAttrConfig.Value.KscAttrType != 0)
						{
							EKSC_AttrType eksc_AttrType = (EKSC_AttrType)weaponAttrConfig.Value.KscAttrType;
							this.AddToAttrMap(outAttrs, eksc_AttrType, weaponAttrConfig.Value.ProperVal);
							if (eksc_AttrType == EKSC_AttrType.LifeMax)
							{
								this.AddToAttrMap(outAttrs, EKSC_AttrType.Life, weaponAttrConfig.Value.ProperVal);
								this.AddToAttrMap(outAttrs, EKSC_AttrType.BaseLife, weaponAttrConfig.Value.ProperVal);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603BACE RID: 244430 RVA: 0x010EEC00 File Offset: 0x010ECE00
		[return: Nullable(2)]
		public HashSet<int> GetRoleBornBuffs(PinballFormationRolePb roleData, bool isLeader)
		{
			PinballBattleConfig instance = PinballBattleConfig.Instance;
			PinballRoleConfig? roleConfig = instance.GetRoleConfig(roleData.RoleId);
			if (roleConfig == null)
			{
				return null;
			}
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i < roleConfig.Value.BornBuffLength; i++)
			{
				int num = roleConfig.Value.BornBuff(i);
				if (num != 0)
				{
					hashSet.Add(num);
				}
			}
			if (isLeader)
			{
				for (int j = 0; j < roleConfig.Value.LeaderBuffLength; j++)
				{
					int num2 = roleConfig.Value.LeaderBuff(j);
					if (num2 != 0)
					{
						hashSet.Add(num2);
					}
				}
			}
			if (roleData.HasWeapon)
			{
				PinballWeaponConfig? weaponConfig = instance.GetWeaponConfig(roleData.WeaponId);
				if (weaponConfig != null)
				{
					PinballWeaponMainEntry? weaponMainEntryConfig = instance.GetWeaponMainEntryConfig(weaponConfig.Value.MainEntry);
					if (weaponMainEntryConfig != null && weaponMainEntryConfig.Value.Buff != 0)
					{
						hashSet.Add(weaponMainEntryConfig.Value.Buff);
					}
				}
			}
			for (int k = 0; k < roleData.RandomAffixIds.Count; k++)
			{
				int configId = roleData.RandomAffixIds[k];
				PinballWeaponSubEntry? weaponSubEntryConfig = instance.GetWeaponSubEntryConfig(configId);
				if (weaponSubEntryConfig != null && weaponSubEntryConfig.Value.Buff != 0)
				{
					hashSet.Add(weaponSubEntryConfig.Value.Buff);
				}
			}
			return hashSet;
		}

		// Token: 0x0603BACF RID: 244431 RVA: 0x010EED80 File Offset: 0x010ECF80
		public void GetTeamAttrs(int attrId, Dictionary<EKSC_AttrType, float> outAttrs)
		{
			PinballAttr? attrConfig = PinballBattleConfig.Instance.GetAttrConfig(attrId);
			if (attrConfig != null)
			{
				this.LoadAttrFromConfig(outAttrs, attrConfig.Value, true);
			}
		}

		// Token: 0x0603BAD0 RID: 244432 RVA: 0x010EEDB4 File Offset: 0x010ECFB4
		public void GetCommonAttrs(Dictionary<EKSC_AttrType, float> attrMap, PinballAttr attrConfig)
		{
			attrMap[EKSC_AttrType.LifeMax] = (float)attrConfig.LifeMax;
			attrMap[EKSC_AttrType.Life] = (float)attrConfig.Life;
			attrMap[EKSC_AttrType.BaseLife] = (float)attrConfig.Life;
			attrMap[EKSC_AttrType.Atk] = (float)attrConfig.Atk;
			attrMap[EKSC_AttrType.Def] = (float)attrConfig.Def;
			attrMap[EKSC_AttrType.Crit] = (float)attrConfig.Crit;
			attrMap[EKSC_AttrType.CritDamage] = (float)attrConfig.CritDamage;
			attrMap[EKSC_AttrType.DamageChange] = (float)attrConfig.DamageChange;
			attrMap[EKSC_AttrType.DamageAmplify1] = (float)attrConfig.DamageAmplify1;
			attrMap[EKSC_AttrType.SpecialDamageChange1] = (float)attrConfig.DamageChangeAuto;
			attrMap[EKSC_AttrType.SpecialDamageChange2] = (float)attrConfig.DamageChangeStrong;
			attrMap[EKSC_AttrType.SpecialDamageChange3] = (float)attrConfig.DamageChangeSkill;
			attrMap[EKSC_AttrType.SpecialDamageChange4] = (float)attrConfig.DamageChangeSprint;
			attrMap[EKSC_AttrType.SpecialDamageChange5] = (float)attrConfig.DamageChangeSummon;
			attrMap[EKSC_AttrType.DamageReduce] = (float)attrConfig.DamageReduce;
			attrMap[EKSC_AttrType.SpecialDamageReduce1] = (float)attrConfig.DamageReduceAuto;
			attrMap[EKSC_AttrType.SpecialDamageReduce2] = (float)attrConfig.DamageReduceStrong;
			attrMap[EKSC_AttrType.SpecialDamageReduce3] = (float)attrConfig.DamageReduceSkill;
			attrMap[EKSC_AttrType.SpecialDamageReduce4] = (float)attrConfig.DamageReduceSprint;
			attrMap[EKSC_AttrType.SpecialDamageReduce5] = (float)attrConfig.DamageReduceSummon;
			attrMap[EKSC_AttrType.HealChange] = (float)attrConfig.HealEfficiency;
			attrMap[EKSC_AttrType.ShieldChange] = (float)attrConfig.ProtectEfficiency;
			attrMap[EKSC_AttrType.ShieldMax] = (float)attrConfig.ProtectMax;
		}

		// Token: 0x0603BAD1 RID: 244433 RVA: 0x010EEF4C File Offset: 0x010ED14C
		private void LoadAttrFromConfig(Dictionary<EKSC_AttrType, float> attrMap, PinballAttr attrConfig, bool isTeam = false)
		{
			this.GetCommonAttrs(attrMap, attrConfig);
			if (!isTeam)
			{
				attrMap[EKSC_AttrType.SpecialEnergy1Max] = (float)attrConfig.EnergyMax;
				attrMap[EKSC_AttrType.SpecialEnergy1] = (float)attrConfig.Energy;
				attrMap[EKSC_AttrType.SpecialEnergy1RecoverSpeed] = (float)attrConfig.EnergyRecoverSpeed;
				attrMap[EKSC_AttrType.SpecialEnergy1ChargeEfficiency] = (float)attrConfig.EnergyEfficiency;
				return;
			}
			attrMap[EKSC_AttrType.SpecialEnergy2Max] = (float)attrConfig.SprintEnergyMax;
			attrMap[EKSC_AttrType.SpecialEnergy2] = (float)attrConfig.SprintEnergy;
			attrMap[EKSC_AttrType.SpecialEnergy2RecoverSpeed] = (float)attrConfig.SprintEnergyRecoverSpeed;
			attrMap[EKSC_AttrType.SpecialEnergy2ChargeEfficiency] = (float)attrConfig.SprintEnergyEfficiency;
			attrMap[EKSC_AttrType.SpecialEnergy3Max] = (float)attrConfig.FeverEnergyMax;
			attrMap[EKSC_AttrType.SpecialEnergy3] = (float)attrConfig.FeverEnergy;
			attrMap[EKSC_AttrType.SpecialEnergy3RecoverSpeed] = (float)attrConfig.FeverEnergyRecoverSpeed;
			attrMap[EKSC_AttrType.SpecialEnergy3ChargeEfficiency] = (float)attrConfig.FeverEnergyEfficiency;
		}

		// Token: 0x0603BAD2 RID: 244434 RVA: 0x010EF028 File Offset: 0x010ED228
		private void AddToAttrMap(Dictionary<EKSC_AttrType, float> attrMap, EKSC_AttrType attrType, float value)
		{
			if (attrType == EKSC_AttrType.EAttributeType_None)
			{
				return;
			}
			float num;
			attrMap.TryGetValue(attrType, out num);
			attrMap[attrType] = num + value;
		}

		// Token: 0x0603BAD3 RID: 244435 RVA: 0x010EF050 File Offset: 0x010ED250
		public Dictionary<EKSC_AttrType, int> GetDefaultAttrs(TMap<EKSC_AttrType, int> attrs)
		{
			if (this.DefaultAttrs == null)
			{
				this.DefaultAttrs = new Dictionary<EKSC_AttrType, int>(attrs.Num());
				foreach (KeyValuePair<EKSC_AttrType, int> keyValuePair in attrs)
				{
					EKSC_AttrType eksc_AttrType;
					int num;
					keyValuePair.Deconstruct(out eksc_AttrType, out num);
					EKSC_AttrType key = eksc_AttrType;
					int value = num;
					this.DefaultAttrs[key] = value;
				}
			}
			return this.DefaultAttrs;
		}

		// Token: 0x0603BAD4 RID: 244436 RVA: 0x010EF0D4 File Offset: 0x010ED2D4
		public void InitMonsterAttrConfigs()
		{
			IReadOnlyList<PinballMonsterAttr> allMonsterAttrConfigs = PinballBattleConfig.Instance.GetAllMonsterAttrConfigs();
			if (allMonsterAttrConfigs != null)
			{
				foreach (PinballMonsterAttr pinballMonsterAttr in allMonsterAttrConfigs)
				{
					Dictionary<EKSC_AttrType, float> dictionary = new Dictionary<EKSC_AttrType, float>();
					dictionary[EKSC_AttrType.LifeMax] = (float)pinballMonsterAttr.LifeMax;
					dictionary[EKSC_AttrType.Life] = (float)pinballMonsterAttr.Life;
					dictionary[EKSC_AttrType.BaseLife] = (float)pinballMonsterAttr.Life;
					dictionary[EKSC_AttrType.Atk] = (float)pinballMonsterAttr.Atk;
					dictionary[EKSC_AttrType.Def] = (float)pinballMonsterAttr.Def;
					dictionary[EKSC_AttrType.Crit] = (float)pinballMonsterAttr.Crit;
					dictionary[EKSC_AttrType.CritDamage] = (float)pinballMonsterAttr.CritDamage;
					dictionary[EKSC_AttrType.DamageAmplify1] = (float)pinballMonsterAttr.DamageAmplify1;
					dictionary[EKSC_AttrType.DamageReduce] = (float)pinballMonsterAttr.DamageReduce;
					dictionary[EKSC_AttrType.SpecialDamageReduce1] = (float)pinballMonsterAttr.DamageReduceAuto;
					dictionary[EKSC_AttrType.SpecialDamageReduce2] = (float)pinballMonsterAttr.DamageReduceStrong;
					dictionary[EKSC_AttrType.SpecialDamageReduce3] = (float)pinballMonsterAttr.DamageReduceSkill;
					dictionary[EKSC_AttrType.SpecialDamageReduce4] = (float)pinballMonsterAttr.DamageReduceSprint;
					dictionary[EKSC_AttrType.SpecialDamageReduce5] = (float)pinballMonsterAttr.DamageReduceSummon;
					dictionary[EKSC_AttrType.ShieldMax] = (float)pinballMonsterAttr.ProtectMax;
					this.PinballMonsterAttrConfigs[pinballMonsterAttr.Id] = dictionary;
				}
			}
		}

		// Token: 0x0603BAD5 RID: 244437 RVA: 0x010EF24C File Offset: 0x010ED44C
		public void SetLevelConfig(PinballLevelConfig? config)
		{
			int num = (config != null) ? config.Value.ScoreRatio : 0;
			this.ScoreRatio = 1f + (float)num * 0.0001f;
		}

		// Token: 0x0603BAD6 RID: 244438 RVA: 0x010EF28C File Offset: 0x010ED48C
		public int GetMaxWave()
		{
			PinballConfig instance = PinballConfig.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				IReadOnlyList<PinballWaveConfig> pinballWaveConfigListByLevel = instance.GetPinballWaveConfigListByLevel(this.LevelId);
				num = ((pinballWaveConfigListByLevel != null) ? new int?(pinballWaveConfigListByLevel.Count) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0603BAD7 RID: 244439 RVA: 0x010EF2D9 File Offset: 0x010ED4D9
		public bool IsRoleLeader(int roleId)
		{
			return this.FormationData != null && this.FormationData.Count > 0 && this.FormationData[0].RoleId == roleId;
		}

		// Token: 0x0603BAD8 RID: 244440 RVA: 0x010EF308 File Offset: 0x010ED508
		public void SetRoleBaseAttrsRecord(PinballFormationRolePb roleData, Dictionary<EKSC_AttrType, float> attrs)
		{
			Dictionary<EKSC_AttrType, float> dictionary;
			if (!this.RoleBaseAttrsRecord.TryGetValue(roleData.RoleId, out dictionary))
			{
				dictionary = new Dictionary<EKSC_AttrType, float>();
				this.RoleBaseAttrsRecord[roleData.RoleId] = dictionary;
			}
			float num;
			dictionary[EKSC_AttrType.LifeMax] = (attrs.TryGetValue(EKSC_AttrType.LifeMax, out num) ? num : 0f);
			float num2;
			dictionary[EKSC_AttrType.Atk] = (attrs.TryGetValue(EKSC_AttrType.Atk, out num2) ? num2 : 0f);
		}

		// Token: 0x0603BAD9 RID: 244441 RVA: 0x010EF378 File Offset: 0x010ED578
		public float GetRoleContribution(PinballResultRolePb rolePb, float totalDamage)
		{
			PinballWorldConfig? worldConfigCache = this.WorldConfigCache;
			if (worldConfigCache == null)
			{
				return 0f;
			}
			float num = 0f;
			float num2 = 0f;
			Dictionary<EKSC_AttrType, float> dictionary;
			if (this.RoleBaseAttrsRecord.TryGetValue(rolePb.RoleId, out dictionary))
			{
				dictionary.TryGetValue(EKSC_AttrType.Atk, out num);
				dictionary.TryGetValue(EKSC_AttrType.LifeMax, out num2);
			}
			float num3 = totalDamage * (num * num2 / (float)worldConfigCache.Value.DamageResultAttrRatio);
			if (worldConfigCache.Value.DamageResultTeamRatiosLength > 1)
			{
				num3 *= (this.IsRoleLeader(rolePb.RoleId) ? worldConfigCache.Value.DamageResultTeamRatios(0) : worldConfigCache.Value.DamageResultTeamRatios(1));
			}
			if (worldConfigCache.Value.DamageResultClassRatiosLength > 2)
			{
				PinballRoleConfig? roleConfig = PinballBattleConfig.Instance.GetRoleConfig(rolePb.RoleId);
				if (roleConfig != null && roleConfig.Value.PinballClassLength > 0)
				{
					int num4 = roleConfig.Value.PinballClass(0);
					if (num4 == 1)
					{
						num3 *= worldConfigCache.Value.DamageResultClassRatios(0);
					}
					else if (num4 == 2)
					{
						num3 *= worldConfigCache.Value.DamageResultClassRatios(1);
					}
					else if (num4 == 3)
					{
						num3 *= worldConfigCache.Value.DamageResultClassRatios(2);
					}
				}
			}
			return num3 * (1f + (float)rolePb.SkillTimes * worldConfigCache.Value.DamageResultSkillRatio);
		}

		// Token: 0x0401F77C RID: 128892
		public PinballWorldConfig? WorldConfigCache;

		// Token: 0x0401F77D RID: 128893
		[Nullable(2)]
		public UDataTable BulletDataTable;

		// Token: 0x0401F77E RID: 128894
		[Nullable(2)]
		public UKSC_DA_Shape2D_World ShapeWorldDa;

		// Token: 0x0401F77F RID: 128895
		[Nullable(2)]
		public UKSC_DA_Shape2D_WorldBounds ShapeWorldBoundsDa;

		// Token: 0x0401F780 RID: 128896
		[Nullable(2)]
		public UDataTable ShapeMaterialDt;

		// Token: 0x0401F781 RID: 128897
		public readonly PinballBattleHeadStateManager PinballBattleHeadStateManager = new PinballBattleHeadStateManager();

		// Token: 0x0401F782 RID: 128898
		public Dictionary<int, PinballAttr> PinballPropertyConfigs = new Dictionary<int, PinballAttr>();

		// Token: 0x0401F783 RID: 128899
		public Dictionary<int, UKSC_DA_Buff> LoadedBuffDaMap = new Dictionary<int, UKSC_DA_Buff>();

		// Token: 0x0401F784 RID: 128900
		public Dictionary<int, HashSet<int>> RoleBornBuffsMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401F785 RID: 128901
		public Dictionary<int, Dictionary<EKSC_AttrType, float>> PinballMonsterAttrConfigs = new Dictionary<int, Dictionary<EKSC_AttrType, float>>();

		// Token: 0x0401F786 RID: 128902
		private readonly Dictionary<int, Dictionary<EKSC_AttrType, float>> RoleBaseAttrsRecord = new Dictionary<int, Dictionary<EKSC_AttrType, float>>();

		// Token: 0x0401F787 RID: 128903
		[Nullable(2)]
		private Dictionary<EKSC_AttrType, int> DefaultAttrs;

		// Token: 0x0401F788 RID: 128904
		public float ComboEfficiency;

		// Token: 0x0401F789 RID: 128905
		private readonly Dictionary<int, IPinballBattleCombatInfo> AllEntities = new Dictionary<int, IPinballBattleCombatInfo>();

		// Token: 0x0401F78A RID: 128906
		private readonly Dictionary<int, int> TeamRoleId2CreatureId = new Dictionary<int, int>();

		// Token: 0x0401F78B RID: 128907
		public int GameState;

		// Token: 0x0401F78C RID: 128908
		public int LevelId;

		// Token: 0x0401F78D RID: 128909
		public int CurWave = 1;

		// Token: 0x0401F78E RID: 128910
		public int UsedReviveTime;

		// Token: 0x0401F78F RID: 128911
		public int MaxReviveTime;

		// Token: 0x0401F790 RID: 128912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<PinballFormationRolePb> FormationData;

		// Token: 0x0401F791 RID: 128913
		public float Score;

		// Token: 0x0401F792 RID: 128914
		public int Combo;

		// Token: 0x0401F793 RID: 128915
		public List<float> LevelScoreTargetList = new List<float>();

		// Token: 0x0401F794 RID: 128916
		public float MaxScore;

		// Token: 0x0401F795 RID: 128917
		public int[] StarInfo = new int[3];

		// Token: 0x0401F796 RID: 128918
		public Dictionary<EKSC_AttrType, float> MonsterAttrRate = new Dictionary<EKSC_AttrType, float>();

		// Token: 0x0401F797 RID: 128919
		private float ScoreRatio = 1f;

		// Token: 0x0401F798 RID: 128920
		[Nullable(2)]
		public List<int> TeamBuffList;

		// Token: 0x0401F799 RID: 128921
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<PinballFormationRolePb> PreloadFormationData;

		// Token: 0x0401F79A RID: 128922
		public Dictionary<int, PinballRoleTotalInfo> RoleTotalMap = new Dictionary<int, PinballRoleTotalInfo>();

		// Token: 0x0401F79B RID: 128923
		public int DashTimes;

		// Token: 0x0401F79C RID: 128924
		public int FullEnergyTimes;

		// Token: 0x0401F79D RID: 128925
		public int AttackTimes;

		// Token: 0x0401F79E RID: 128926
		public int BossSkillTimes;

		// Token: 0x0401F79F RID: 128927
		public readonly EntitySpawnTracker FirstWaveMonsterTracker = new EntitySpawnTracker();

		// Token: 0x0401F7A0 RID: 128928
		public readonly EntitySpawnTracker CurWaveMachineTracker = new EntitySpawnTracker();
	}
}
