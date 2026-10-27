using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FC4 RID: 28612
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleSubModel : KscSubModelBase
	{
		// Token: 0x06045906 RID: 284934 RVA: 0x0114444C File Offset: 0x0114264C
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

		// Token: 0x06045907 RID: 284935 RVA: 0x011444B4 File Offset: 0x011426B4
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

		// Token: 0x06045908 RID: 284936 RVA: 0x011445E8 File Offset: 0x011427E8
		public override string GetSkillDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().SkillDtPath : null) ?? "";
		}

		// Token: 0x06045909 RID: 284937 RVA: 0x01144620 File Offset: 0x01142820
		public override string GetEntityDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().EntityDtPath : null) ?? "";
		}

		// Token: 0x0604590A RID: 284938 RVA: 0x01144658 File Offset: 0x01142858
		public string GetBulletDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().BulletDtPath : null) ?? "";
		}

		// Token: 0x0604590B RID: 284939 RVA: 0x01144690 File Offset: 0x01142890
		public string GetWorldDaPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeWorldDaPath : null) ?? "";
		}

		// Token: 0x0604590C RID: 284940 RVA: 0x011446C8 File Offset: 0x011428C8
		public string GetWorldBoundsDaPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeWorldBoundsDaPath : null) ?? "";
		}

		// Token: 0x0604590D RID: 284941 RVA: 0x01144700 File Offset: 0x01142900
		public string GetShapeMaterialDtPath()
		{
			return ((this.WorldConfigCache != null) ? this.WorldConfigCache.GetValueOrDefault().ShapeMaterialDtPath : null) ?? "";
		}

		// Token: 0x0604590E RID: 284942 RVA: 0x01144738 File Offset: 0x01142938
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

		// Token: 0x0604590F RID: 284943 RVA: 0x01144758 File Offset: 0x01142958
		public void GetAllEntities(List<IPinballBattleCombatInfo> entities)
		{
			entities.Clear();
			foreach (IPinballBattleCombatInfo item in this.AllEntities.Values)
			{
				entities.Add(item);
			}
		}

		// Token: 0x06045910 RID: 284944 RVA: 0x011447B8 File Offset: 0x011429B8
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

		// Token: 0x06045911 RID: 284945 RVA: 0x01144800 File Offset: 0x01142A00
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

		// Token: 0x06045912 RID: 284946 RVA: 0x0114482B File Offset: 0x01142A2B
		public void SetRoleId2CreatureId(int roleId, int creatureId)
		{
			this.TeamRoleId2CreatureId[roleId] = creatureId;
		}

		// Token: 0x06045913 RID: 284947 RVA: 0x0114483C File Offset: 0x01142A3C
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

		// Token: 0x06045914 RID: 284948 RVA: 0x01144864 File Offset: 0x01142A64
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

		// Token: 0x06045915 RID: 284949 RVA: 0x011448E0 File Offset: 0x01142AE0
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

		// Token: 0x06045916 RID: 284950 RVA: 0x0114493C File Offset: 0x01142B3C
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

		// Token: 0x06045917 RID: 284951 RVA: 0x011449F0 File Offset: 0x01142BF0
		public void SetLevelScoreTargetList(List<float> levelScoreTargetList)
		{
			this.LevelScoreTargetList.Clear();
			this.LevelScoreTargetList.AddRange(levelScoreTargetList);
			this.MaxScore = this.LevelScoreTargetList[this.LevelScoreTargetList.Count - 1];
		}

		// Token: 0x06045918 RID: 284952 RVA: 0x01144A28 File Offset: 0x01142C28
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

		// Token: 0x06045919 RID: 284953 RVA: 0x01144AB9 File Offset: 0x01142CB9
		public void SetCombo(int newCombo)
		{
			if (newCombo == this.Combo)
			{
				return;
			}
			this.Combo = newCombo;
			EventSystem.Instance.Emit<int>(EEventName.OnPinballComboChanged, newCombo);
		}

		// Token: 0x0604591A RID: 284954 RVA: 0x01144AE0 File Offset: 0x01142CE0
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

		// Token: 0x0604591B RID: 284955 RVA: 0x01144B84 File Offset: 0x01142D84
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

		// Token: 0x0604591C RID: 284956 RVA: 0x01144CAC File Offset: 0x01142EAC
		public bool CheckBonusFullWin()
		{
			return this.MaxScore > 0f && this.Score >= this.MaxScore;
		}

		// Token: 0x0604591D RID: 284957 RVA: 0x01144CD0 File Offset: 0x01142ED0
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

		// Token: 0x0604591E RID: 284958 RVA: 0x01144E24 File Offset: 0x01143024
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

		// Token: 0x0604591F RID: 284959 RVA: 0x01144FA4 File Offset: 0x011431A4
		public void GetTeamAttrs(int attrId, Dictionary<EKSC_AttrType, float> outAttrs)
		{
			PinballAttr? attrConfig = PinballBattleConfig.Instance.GetAttrConfig(attrId);
			if (attrConfig != null)
			{
				this.LoadAttrFromConfig(outAttrs, attrConfig.Value, true);
			}
		}

		// Token: 0x06045920 RID: 284960 RVA: 0x01144FD8 File Offset: 0x011431D8
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

		// Token: 0x06045921 RID: 284961 RVA: 0x01145170 File Offset: 0x01143370
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

		// Token: 0x06045922 RID: 284962 RVA: 0x0114524C File Offset: 0x0114344C
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

		// Token: 0x06045923 RID: 284963 RVA: 0x01145274 File Offset: 0x01143474
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

		// Token: 0x06045924 RID: 284964 RVA: 0x011452F4 File Offset: 0x011434F4
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

		// Token: 0x06045925 RID: 284965 RVA: 0x0114546C File Offset: 0x0114366C
		public void SetLevelConfig(PinballLevelConfig? config)
		{
			int num = (config != null) ? config.Value.ScoreRatio : 0;
			this.ScoreRatio = 1f + (float)num * 0.0001f;
		}

		// Token: 0x06045926 RID: 284966 RVA: 0x011454AC File Offset: 0x011436AC
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

		// Token: 0x06045927 RID: 284967 RVA: 0x011454F9 File Offset: 0x011436F9
		public bool IsRoleLeader(int roleId)
		{
			return this.FormationData != null && this.FormationData.Count > 0 && this.FormationData[0].RoleId == roleId;
		}

		// Token: 0x06045928 RID: 284968 RVA: 0x01145528 File Offset: 0x01143728
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

		// Token: 0x06045929 RID: 284969 RVA: 0x01145598 File Offset: 0x01143798
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

		// Token: 0x040244C7 RID: 148679
		public PinballWorldConfig? WorldConfigCache;

		// Token: 0x040244C8 RID: 148680
		[Nullable(2)]
		public UDataTable BulletDataTable;

		// Token: 0x040244C9 RID: 148681
		[Nullable(2)]
		public UKSC_DA_Shape2D_World ShapeWorldDa;

		// Token: 0x040244CA RID: 148682
		[Nullable(2)]
		public UKSC_DA_Shape2D_WorldBounds ShapeWorldBoundsDa;

		// Token: 0x040244CB RID: 148683
		[Nullable(2)]
		public UDataTable ShapeMaterialDt;

		// Token: 0x040244CC RID: 148684
		public readonly PinballBattleHeadStateManager PinballBattleHeadStateManager = new PinballBattleHeadStateManager();

		// Token: 0x040244CD RID: 148685
		public Dictionary<int, PinballAttr> PinballPropertyConfigs = new Dictionary<int, PinballAttr>();

		// Token: 0x040244CE RID: 148686
		public Dictionary<int, UKSC_DA_Buff> LoadedBuffDaMap = new Dictionary<int, UKSC_DA_Buff>();

		// Token: 0x040244CF RID: 148687
		public Dictionary<int, HashSet<int>> RoleBornBuffsMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x040244D0 RID: 148688
		public Dictionary<int, Dictionary<EKSC_AttrType, float>> PinballMonsterAttrConfigs = new Dictionary<int, Dictionary<EKSC_AttrType, float>>();

		// Token: 0x040244D1 RID: 148689
		private readonly Dictionary<int, Dictionary<EKSC_AttrType, float>> RoleBaseAttrsRecord = new Dictionary<int, Dictionary<EKSC_AttrType, float>>();

		// Token: 0x040244D2 RID: 148690
		[Nullable(2)]
		private Dictionary<EKSC_AttrType, int> DefaultAttrs;

		// Token: 0x040244D3 RID: 148691
		public float ComboEfficiency;

		// Token: 0x040244D4 RID: 148692
		private readonly Dictionary<int, IPinballBattleCombatInfo> AllEntities = new Dictionary<int, IPinballBattleCombatInfo>();

		// Token: 0x040244D5 RID: 148693
		private readonly Dictionary<int, int> TeamRoleId2CreatureId = new Dictionary<int, int>();

		// Token: 0x040244D6 RID: 148694
		public int GameState;

		// Token: 0x040244D7 RID: 148695
		public int LevelId;

		// Token: 0x040244D8 RID: 148696
		public int CurWave = 1;

		// Token: 0x040244D9 RID: 148697
		public int UsedReviveTime;

		// Token: 0x040244DA RID: 148698
		public int MaxReviveTime;

		// Token: 0x040244DB RID: 148699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<PinballFormationRolePb> FormationData;

		// Token: 0x040244DC RID: 148700
		public float Score;

		// Token: 0x040244DD RID: 148701
		public int Combo;

		// Token: 0x040244DE RID: 148702
		public List<float> LevelScoreTargetList = new List<float>();

		// Token: 0x040244DF RID: 148703
		public float MaxScore;

		// Token: 0x040244E0 RID: 148704
		public int[] StarInfo = new int[3];

		// Token: 0x040244E1 RID: 148705
		public Dictionary<EKSC_AttrType, float> MonsterAttrRate = new Dictionary<EKSC_AttrType, float>();

		// Token: 0x040244E2 RID: 148706
		private float ScoreRatio = 1f;

		// Token: 0x040244E3 RID: 148707
		[Nullable(2)]
		public List<int> TeamBuffList;

		// Token: 0x040244E4 RID: 148708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<PinballFormationRolePb> PreloadFormationData;

		// Token: 0x040244E5 RID: 148709
		public Dictionary<int, PinballRoleTotalInfo> RoleTotalMap = new Dictionary<int, PinballRoleTotalInfo>();

		// Token: 0x040244E6 RID: 148710
		public int DashTimes;

		// Token: 0x040244E7 RID: 148711
		public int FullEnergyTimes;

		// Token: 0x040244E8 RID: 148712
		public int AttackTimes;

		// Token: 0x040244E9 RID: 148713
		public int BossSkillTimes;

		// Token: 0x040244EA RID: 148714
		public readonly EntitySpawnTracker FirstWaveMonsterTracker = new EntitySpawnTracker();

		// Token: 0x040244EB RID: 148715
		public readonly EntitySpawnTracker CurWaveMachineTracker = new EntitySpawnTracker();
	}
}
