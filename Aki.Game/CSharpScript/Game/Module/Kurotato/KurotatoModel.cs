using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005719 RID: 22297
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class KurotatoModel : ModelBase
	{
		// Token: 0x06038AB6 RID: 232118 RVA: 0x00D712A3 File Offset: 0x00D6F4A3
		protected override bool OnClear()
		{
			this.ClearInGameData();
			return true;
		}

		// Token: 0x06038AB7 RID: 232119 RVA: 0x00D712AC File Offset: 0x00D6F4AC
		public void ClearInGameData()
		{
			this.StepInternal = EKurotatoStep.None;
			this.PrevStepInternal = EKurotatoStep.None;
			this.IsStepStartInternal = false;
			this.CurLevelIdInternal = 0;
			this.CurWaveStartLevelInternal = 0;
			this.SystemPropertyValueMap.Clear();
			this.LockedPropertyValueMap.Clear();
			this.BattleMusicStartedInternal = false;
			this.BattleData.Clear();
			this.WaveDurationInternal = 0;
			this.HasEndlessModeSelectionInternal = false;
			this.UpgradeRewardData = new List<KurotatoItemRewardPbData>();
			this.UpgradeRewardIndexInternal = 0;
			this.UpgradeRewardCountInternal = 0;
			this.ChestItemIdInternal = 0;
			this.ChestSoldPriceInternal = 0;
			this.ChestRewardIndexInternal = 0;
			this.ChestRewardCount = 0;
			this.ShopData = new List<KurotatoShopProductPbData>();
			this.HoldItemData.Clear();
			this.HoldWeaponData = new List<IKurotatoWeaponData>();
			this.RefreshCostInner = 0;
			this.RoleId = 10001;
			this.NextWaveTypeInternal = KurotatoNextWaveType.Default;
			this.NextWaveNumInternal = 0;
			this.SettlementDataInternal = null;
		}

		// Token: 0x06038AB8 RID: 232120 RVA: 0x00D7138F File Offset: 0x00D6F58F
		public bool GetBattleMusicStarted()
		{
			return this.BattleMusicStartedInternal;
		}

		// Token: 0x06038AB9 RID: 232121 RVA: 0x00D71397 File Offset: 0x00D6F597
		public void SetBattleMusicStarted(bool value)
		{
			this.BattleMusicStartedInternal = value;
		}

		// Token: 0x06038ABA RID: 232122 RVA: 0x00D713A0 File Offset: 0x00D6F5A0
		public void SetStepData(KurotatoStepUpdateNotify data)
		{
			this.IsStepStartInternal = data.IsStart;
			EKurotatoStep ekurotatoStep = this.StepInternal;
			if (data.CombatStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.Combat;
			}
			if (data.ChestRewardStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.ChestReward;
			}
			if (data.ShopStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.Shop;
			}
			if (data.UpdateWavePbData != null)
			{
				ekurotatoStep = EKurotatoStep.WaveUpdate;
			}
			if (data.UpgradeRewardStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.UpgradeReward;
			}
			if (data.PrepareStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.Prepare;
			}
			if (data.EndStepPbData != null)
			{
				ekurotatoStep = EKurotatoStep.End;
			}
			if (ekurotatoStep != this.StepInternal)
			{
				this.PrevStepInternal = this.StepInternal;
				this.StepInternal = ekurotatoStep;
			}
			switch (this.StepInternal)
			{
			case EKurotatoStep.Combat:
				this.WaveDurationInternal = data.CombatStepPbData.WaveDuration;
				this.CurWaveStartLevelInternal = this.BattleData.GetRoleLevel();
				this.ClearUpgradeRewardData();
				this.ClearChestRewardData();
				this.ClearShopData();
				break;
			case EKurotatoStep.Shop:
				this.HasEndlessModeSelectionInternal = data.ShopStepPbData.HasEndLessModeSelection;
				if (data.IsStart)
				{
					this.ClearShopData();
				}
				break;
			}
			EventSystem.Instance.Emit<EKurotatoStep>(EEventName.KurotatoOnStepChanged, this.StepInternal);
		}

		// Token: 0x06038ABB RID: 232123 RVA: 0x00D714B8 File Offset: 0x00D6F6B8
		public EKurotatoStep GetStep()
		{
			return this.StepInternal;
		}

		// Token: 0x06038ABC RID: 232124 RVA: 0x00D714C0 File Offset: 0x00D6F6C0
		public EKurotatoStep GetPrevStep()
		{
			return this.PrevStepInternal;
		}

		// Token: 0x06038ABD RID: 232125 RVA: 0x00D714C8 File Offset: 0x00D6F6C8
		public bool GetIsStepStart()
		{
			return this.IsStepStartInternal;
		}

		// Token: 0x06038ABE RID: 232126 RVA: 0x00D714D0 File Offset: 0x00D6F6D0
		public void SetCurLevelId(int levelId)
		{
			this.CurLevelIdInternal = levelId;
		}

		// Token: 0x06038ABF RID: 232127 RVA: 0x00D714D9 File Offset: 0x00D6F6D9
		public int GetCurLevelId()
		{
			return this.CurLevelIdInternal;
		}

		// Token: 0x06038AC0 RID: 232128 RVA: 0x00D714E1 File Offset: 0x00D6F6E1
		public void SetCurWaveStartLevel(int level)
		{
			this.CurWaveStartLevelInternal = level;
		}

		// Token: 0x06038AC1 RID: 232129 RVA: 0x00D714EA File Offset: 0x00D6F6EA
		public int GetCurWaveStartLevel()
		{
			return this.CurWaveStartLevelInternal;
		}

		// Token: 0x06038AC2 RID: 232130 RVA: 0x00D714F2 File Offset: 0x00D6F6F2
		public bool GetIsEndlessWave()
		{
			return this.BattleData.GetBatchType() == EKurotatoBatchType.Endless;
		}

		// Token: 0x06038AC3 RID: 232131 RVA: 0x00D71502 File Offset: 0x00D6F702
		public bool GetIsSpecialWave()
		{
			return this.BattleData.GetBatchType() == EKurotatoBatchType.Special;
		}

		// Token: 0x06038AC4 RID: 232132 RVA: 0x00D71514 File Offset: 0x00D6F714
		public bool GetIsCurWaveElite()
		{
			List<KurotatoWave> list = KurotatoConfig.Instance.GetWaveByLevelId(this.CurLevelIdInternal) ?? new List<KurotatoWave>();
			int batch = this.BattleData.GetBatch();
			foreach (KurotatoWave kurotatoWave in list)
			{
				if (kurotatoWave.Wave == batch)
				{
					return kurotatoWave.IsPowerWave;
				}
			}
			return false;
		}

		// Token: 0x06038AC5 RID: 232133 RVA: 0x00D71598 File Offset: 0x00D6F798
		public bool GetIsCurWaveBoss()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			List<KurotatoWave> list = instance.GetWaveByLevelId(this.CurLevelIdInternal) ?? new List<KurotatoWave>();
			int batch = this.BattleData.GetBatch();
			foreach (KurotatoWave waveConfig in list)
			{
				if (waveConfig.Wave == batch)
				{
					return instance.WaveHasRiskType(waveConfig, EKurotatoRiskType.BOSS);
				}
			}
			return false;
		}

		// Token: 0x06038AC6 RID: 232134 RVA: 0x00D71620 File Offset: 0x00D6F820
		public void SetNextWaveType(KurotatoNextWaveType nextWaveType, int nextWaveNum)
		{
			this.NextWaveTypeInternal = nextWaveType;
			this.NextWaveNumInternal = nextWaveNum;
		}

		// Token: 0x06038AC7 RID: 232135 RVA: 0x00D71630 File Offset: 0x00D6F830
		public int GetNextWaveNum()
		{
			return this.NextWaveNumInternal;
		}

		// Token: 0x06038AC8 RID: 232136 RVA: 0x00D71638 File Offset: 0x00D6F838
		public bool GetIsNextWaveSpecial()
		{
			return this.NextWaveTypeInternal == KurotatoNextWaveType.Special;
		}

		// Token: 0x1700885A RID: 34906
		// (get) Token: 0x06038AC9 RID: 232137 RVA: 0x00D71643 File Offset: 0x00D6F843
		public int CurWaveNum
		{
			get
			{
				return this.BattleData.GetBatch();
			}
		}

		// Token: 0x06038ACA RID: 232138 RVA: 0x00D71650 File Offset: 0x00D6F850
		public int GetWaveDuration()
		{
			return this.WaveDurationInternal;
		}

		// Token: 0x06038ACB RID: 232139 RVA: 0x00D71658 File Offset: 0x00D6F858
		public bool GetHasEndlessModeSelection()
		{
			return this.HasEndlessModeSelectionInternal;
		}

		// Token: 0x06038ACC RID: 232140 RVA: 0x00D71660 File Offset: 0x00D6F860
		public int GetRefreshCost()
		{
			return this.RefreshCostInner;
		}

		// Token: 0x06038ACD RID: 232141 RVA: 0x00D71668 File Offset: 0x00D6F868
		public int GetRoleId()
		{
			return this.RoleId;
		}

		// Token: 0x06038ACE RID: 232142 RVA: 0x00D71670 File Offset: 0x00D6F870
		public List<KurotatoItemRewardPbData> GetUpgradeRewardData()
		{
			return this.UpgradeRewardData;
		}

		// Token: 0x06038ACF RID: 232143 RVA: 0x00D71678 File Offset: 0x00D6F878
		public int GetUpgradeRewardIndex()
		{
			return this.UpgradeRewardIndexInternal;
		}

		// Token: 0x06038AD0 RID: 232144 RVA: 0x00D71680 File Offset: 0x00D6F880
		public int GetUpgradeRewardCount()
		{
			return this.UpgradeRewardCountInternal;
		}

		// Token: 0x06038AD1 RID: 232145 RVA: 0x00D71688 File Offset: 0x00D6F888
		public int GetChestItemId()
		{
			return this.ChestItemIdInternal;
		}

		// Token: 0x06038AD2 RID: 232146 RVA: 0x00D71690 File Offset: 0x00D6F890
		public int GetChestSoldPrice()
		{
			return this.ChestSoldPriceInternal;
		}

		// Token: 0x06038AD3 RID: 232147 RVA: 0x00D71698 File Offset: 0x00D6F898
		public int GetChestRewardIndex()
		{
			return this.ChestRewardIndexInternal;
		}

		// Token: 0x06038AD4 RID: 232148 RVA: 0x00D716A0 File Offset: 0x00D6F8A0
		public int GetChestRewardCount()
		{
			return this.ChestRewardCount;
		}

		// Token: 0x06038AD5 RID: 232149 RVA: 0x00D716A8 File Offset: 0x00D6F8A8
		public List<KurotatoShopProductPbData> GetShopData()
		{
			return this.ShopData;
		}

		// Token: 0x06038AD6 RID: 232150 RVA: 0x00D716B0 File Offset: 0x00D6F8B0
		public bool IsRecommendWeapon(int weaponId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoCharacter? characterById = instance.GetCharacterById(this.GetRoleId());
			if (characterById == null || characterById.Value.ExcludedRecommendWeaponIdsIter().Contains(weaponId))
			{
				return false;
			}
			KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(weaponId);
			KurotatoWeaponGroup? kurotatoWeaponGroup = (weaponConfigByWeaponId != null) ? instance.GetWeaponGroupById(weaponConfigByWeaponId.Value.GroupId) : null;
			List<string> weaponTags = ((kurotatoWeaponGroup != null) ? kurotatoWeaponGroup.GetValueOrDefault().TagsIter().ToList<string>() : null) ?? new List<string>();
			return characterById.Value.RecommendedTagsIter().Any((string tag) => weaponTags.Contains(tag));
		}

		// Token: 0x06038AD7 RID: 232151 RVA: 0x00D71780 File Offset: 0x00D6F980
		public bool IsRecommendItem(int itemId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoCharacter? characterById = instance.GetCharacterById(this.GetRoleId());
			if (characterById == null || characterById.Value.ExcludedRecommendItemIdsIter().Contains(itemId))
			{
				return false;
			}
			KurotatoItem? kurotatoItem;
			List<string> itemTags = ((instance.GetItemConfigByItemId(itemId) != null) ? kurotatoItem.GetValueOrDefault().TagsIter().ToList<string>() : null) ?? new List<string>();
			return characterById.Value.RecommendedTagsIter().Any((string tag) => itemTags.Contains(tag));
		}

		// Token: 0x06038AD8 RID: 232152 RVA: 0x00D71821 File Offset: 0x00D6FA21
		public void ClearShopData()
		{
			this.ShopData = new List<KurotatoShopProductPbData>();
			this.RefreshCostInner = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnShopDataChanged);
		}

		// Token: 0x06038AD9 RID: 232153 RVA: 0x00D71845 File Offset: 0x00D6FA45
		public void ClearUpgradeRewardData()
		{
			this.UpgradeRewardData = new List<KurotatoItemRewardPbData>();
			this.UpgradeRewardIndexInternal = 0;
			this.UpgradeRewardCountInternal = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnUpgradeRewardDataChanged);
		}

		// Token: 0x06038ADA RID: 232154 RVA: 0x00D71870 File Offset: 0x00D6FA70
		public void ClearChestRewardData()
		{
			this.ChestItemIdInternal = 0;
			this.ChestSoldPriceInternal = 0;
			this.ChestRewardIndexInternal = 0;
			this.ChestRewardCount = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnChestRewardDataChanged);
		}

		// Token: 0x06038ADB RID: 232155 RVA: 0x00D718A0 File Offset: 0x00D6FAA0
		public bool CanComposeWeapon(int weaponId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(weaponId);
			if (weaponConfigByWeaponId == null)
			{
				return false;
			}
			int maxQualityByGroupId = instance.GetMaxQualityByGroupId(weaponConfigByWeaponId.Value.GroupId);
			if (weaponConfigByWeaponId.Value.Quality >= maxQualityByGroupId)
			{
				return false;
			}
			foreach (IKurotatoWeaponData kurotatoWeaponData in this.HoldWeaponData)
			{
				KurotatoWeapon? weaponConfigByWeaponId2 = instance.GetWeaponConfigByWeaponId(kurotatoWeaponData.WeaponId);
				if (weaponConfigByWeaponId2 != null && weaponConfigByWeaponId2.Value.GroupId == weaponConfigByWeaponId.Value.GroupId && weaponConfigByWeaponId2.Value.Quality == weaponConfigByWeaponId.Value.Quality)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038ADC RID: 232156 RVA: 0x00D71994 File Offset: 0x00D6FB94
		public IKurotatoComposeHighlight GetComposeHighlight()
		{
			HashSet<int> hashSet = new HashSet<int>();
			HashSet<int> hashSet2 = new HashSet<int>();
			HashSet<int> hashSet3 = new HashSet<int>();
			KurotatoComposeHighlight result = new KurotatoComposeHighlight
			{
				UpgradeSelectionIds = hashSet,
				ArrowIncIds = hashSet2,
				BagPairArrowIncIds = hashSet3
			};
			KurotatoConfig instance = KurotatoConfig.Instance;
			List<KurotatoShopProductPbData> shopData = this.GetShopData();
			bool flag = shopData.Any((KurotatoShopProductPbData item) => item.WeaponData != null && !item.IsBought && this.IsRecommendWeapon(item.WeaponData.WeaponId));
			if (!this.IsWeaponBagFull() || !flag)
			{
				return result;
			}
			Dictionary<string, KurotatoModel.ComposeBucket> dictionary = new Dictionary<string, KurotatoModel.ComposeBucket>();
			foreach (IKurotatoWeaponData kurotatoWeaponData in this.GetHoldWeaponData())
			{
				KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(kurotatoWeaponData.WeaponId);
				if (weaponConfigByWeaponId != null && weaponConfigByWeaponId.Value.Quality < instance.GetMaxQualityByGroupId(weaponConfigByWeaponId.Value.GroupId))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(weaponConfigByWeaponId.Value.GroupId);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(weaponConfigByWeaponId.Value.Quality);
					string key = defaultInterpolatedStringHandler.ToStringAndClear();
					KurotatoModel.ComposeBucket composeBucket;
					if (!dictionary.TryGetValue(key, out composeBucket))
					{
						composeBucket = new KurotatoModel.ComposeBucket
						{
							Quality = weaponConfigByWeaponId.Value.Quality
						};
						dictionary[key] = composeBucket;
					}
					composeBucket.BagIncIds.Add(kurotatoWeaponData.IncId);
				}
			}
			foreach (KurotatoShopProductPbData kurotatoShopProductPbData in shopData)
			{
				if (kurotatoShopProductPbData.WeaponData != null && !kurotatoShopProductPbData.IsBought)
				{
					int weaponId = kurotatoShopProductPbData.WeaponData.WeaponId;
					if (this.IsRecommendWeapon(weaponId))
					{
						KurotatoWeapon? weaponConfigByWeaponId2 = instance.GetWeaponConfigByWeaponId(weaponId);
						if (weaponConfigByWeaponId2 != null)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
							defaultInterpolatedStringHandler.AppendFormatted<int>(weaponConfigByWeaponId2.Value.GroupId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(weaponConfigByWeaponId2.Value.Quality);
							string key2 = defaultInterpolatedStringHandler.ToStringAndClear();
							KurotatoModel.ComposeBucket composeBucket2;
							if (dictionary.TryGetValue(key2, out composeBucket2))
							{
								composeBucket2.RecommendSelectionIds.Add(kurotatoShopProductPbData.SelectionId);
							}
						}
					}
				}
			}
			List<KurotatoModel.ComposeBucket> source = dictionary.Values.ToList<KurotatoModel.ComposeBucket>();
			List<KurotatoModel.ComposeBucket> list = (from bucket in source
			where bucket.RecommendSelectionIds.Count > 0
			orderby bucket.Quality
			select bucket).ToList<KurotatoModel.ComposeBucket>();
			List<KurotatoModel.ComposeBucket> list2 = (from bucket in source
			where bucket.RecommendSelectionIds.Count == 0 && bucket.BagIncIds.Count >= 2
			orderby bucket.Quality
			select bucket).ToList<KurotatoModel.ComposeBucket>();
			foreach (KurotatoModel.ComposeBucket composeBucket3 in list)
			{
				if (hashSet2.Count >= 2)
				{
					break;
				}
				hashSet2.Add(composeBucket3.BagIncIds[0]);
				foreach (int item2 in composeBucket3.RecommendSelectionIds)
				{
					hashSet.Add(item2);
				}
			}
			if (hashSet2.Count > 0)
			{
				return result;
			}
			foreach (KurotatoModel.ComposeBucket composeBucket4 in list2)
			{
				if (2 - hashSet2.Count >= 2)
				{
					hashSet2.Add(composeBucket4.BagIncIds[0]);
					hashSet2.Add(composeBucket4.BagIncIds[1]);
					hashSet3.Add(composeBucket4.BagIncIds[0]);
					hashSet3.Add(composeBucket4.BagIncIds[1]);
				}
			}
			return result;
		}

		// Token: 0x06038ADD RID: 232157 RVA: 0x00D71E08 File Offset: 0x00D70008
		public List<IKurotatoItemData> GetHoldItemData()
		{
			List<IKurotatoItemData> list = new List<IKurotatoItemData>();
			foreach (int num in this.HoldItemData.Keys)
			{
				int num2 = this.HoldItemData[num];
				if (num2 > 0)
				{
					list.Add(new KurotatoItemData
					{
						ItemId = num,
						Count = num2
					});
				}
			}
			return list;
		}

		// Token: 0x06038ADE RID: 232158 RVA: 0x00D71E8C File Offset: 0x00D7008C
		public int GetHoldItemCount(int itemId)
		{
			int result;
			if (!this.HoldItemData.TryGetValue(itemId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06038ADF RID: 232159 RVA: 0x00D71EAC File Offset: 0x00D700AC
		public List<IKurotatoWeaponData> GetHoldWeaponData()
		{
			return this.HoldWeaponData;
		}

		// Token: 0x06038AE0 RID: 232160 RVA: 0x00D71EB4 File Offset: 0x00D700B4
		public bool IsWeaponBagFull()
		{
			KurotatoActivityConfig? kurotatoActivityConfig;
			int num = (this.GetActivityConfig() != null) ? kurotatoActivityConfig.GetValueOrDefault().WeaponCount : this.HoldWeaponData.Count;
			return this.HoldWeaponData.Count >= num;
		}

		// Token: 0x06038AE1 RID: 232161 RVA: 0x00D71F00 File Offset: 0x00D70100
		[NullableContext(2)]
		public IKurotatoWeaponData GetWeaponDataByIncId(int incId)
		{
			foreach (IKurotatoWeaponData kurotatoWeaponData in this.HoldWeaponData)
			{
				if (kurotatoWeaponData.IncId == incId)
				{
					return kurotatoWeaponData;
				}
			}
			return null;
		}

		// Token: 0x06038AE2 RID: 232162 RVA: 0x00D71F5C File Offset: 0x00D7015C
		public int GetWeaponBuildLevelByBuildId(int weaponBuildId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			int num = 0;
			foreach (IKurotatoWeaponData kurotatoWeaponData in this.HoldWeaponData)
			{
				int groupId = instance.GetWeaponConfigByWeaponId(kurotatoWeaponData.WeaponId).Value.GroupId;
				using (IEnumerator<int> enumerator2 = instance.GetWeaponGroupById(groupId).Value.WeaponBuildIdsIter().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == weaponBuildId)
						{
							num++;
							break;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06038AE3 RID: 232163 RVA: 0x00D72028 File Offset: 0x00D70228
		public void SetRoleId(int roleId)
		{
			this.RoleId = roleId;
		}

		// Token: 0x06038AE4 RID: 232164 RVA: 0x00D72031 File Offset: 0x00D70231
		public void SetSystemPropertyValues(IDictionary<int, int> propertyValues, IDictionary<int, int> lockedPropertyValues)
		{
			this.SystemPropertyValueMap.Clear();
			this.UpdateSystemPropertyValues(propertyValues, lockedPropertyValues);
		}

		// Token: 0x06038AE5 RID: 232165 RVA: 0x00D72048 File Offset: 0x00D70248
		public void UpdateSystemPropertyValues(IDictionary<int, int> propertyValues, IDictionary<int, int> lockedPropertyValues)
		{
			foreach (KeyValuePair<int, int> keyValuePair in propertyValues)
			{
				this.SystemPropertyValueMap[keyValuePair.Key] = keyValuePair.Value;
			}
			this.LockedPropertyValueMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair2 in lockedPropertyValues)
			{
				this.LockedPropertyValueMap[keyValuePair2.Key] = keyValuePair2.Value;
			}
		}

		// Token: 0x06038AE6 RID: 232166 RVA: 0x00D720F8 File Offset: 0x00D702F8
		public int GetSystemPropertyValue(int propertyId)
		{
			int result;
			if (!this.SystemPropertyValueMap.TryGetValue(propertyId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06038AE7 RID: 232167 RVA: 0x00D72118 File Offset: 0x00D70318
		public bool IsSystemPropertyLocked(int propertyId)
		{
			return this.LockedPropertyValueMap.ContainsKey(propertyId);
		}

		// Token: 0x06038AE8 RID: 232168 RVA: 0x00D72128 File Offset: 0x00D70328
		public int GetSystemPropertyLockedValue(int propertyId)
		{
			int result;
			if (!this.LockedPropertyValueMap.TryGetValue(propertyId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06038AE9 RID: 232169 RVA: 0x00D72148 File Offset: 0x00D70348
		public int GetPropertyValue(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.GetPlayerPropertyValue(propertyId);
			}
			return this.GetSystemPropertyValue(propertyId);
		}

		// Token: 0x06038AEA RID: 232170 RVA: 0x00D7216B File Offset: 0x00D7036B
		public bool IsPropertyLocked(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.IsPlayerPropertyLocked(propertyId);
			}
			return this.IsSystemPropertyLocked(propertyId);
		}

		// Token: 0x06038AEB RID: 232171 RVA: 0x00D7218E File Offset: 0x00D7038E
		public int GetPropertyLockedValue(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.GetPlayerPropertyLockedValue(propertyId);
			}
			return this.GetSystemPropertyLockedValue(propertyId);
		}

		// Token: 0x06038AEC RID: 232172 RVA: 0x00D721B4 File Offset: 0x00D703B4
		public void SetUpgradeRewardData(KurotatoItemRewardPanelPbData rewardData)
		{
			this.UpgradeRewardData = new List<KurotatoItemRewardPbData>(rewardData.RewardItemDatas);
			this.RefreshCostInner = rewardData.RefreshCost;
			this.UpgradeRewardIndexInternal = rewardData.RewardIndex;
			this.UpgradeRewardCountInternal = rewardData.TotalRewardCount;
			EventSystem.Instance.Emit(EEventName.KurotatoOnUpgradeRewardDataChanged);
		}

		// Token: 0x06038AED RID: 232173 RVA: 0x00D72206 File Offset: 0x00D70406
		public void SetChestRewardData(int itemId, int soldPrice, int rewardIndex, int rewardCount)
		{
			this.ChestItemIdInternal = itemId;
			this.ChestSoldPriceInternal = soldPrice;
			this.ChestRewardIndexInternal = rewardIndex;
			this.ChestRewardCount = rewardCount;
			EventSystem.Instance.Emit(EEventName.KurotatoOnChestRewardDataChanged);
		}

		// Token: 0x06038AEE RID: 232174 RVA: 0x00D72235 File Offset: 0x00D70435
		public void SetShopData(KurotatoShopPanelPbData shopData)
		{
			this.ShopData = new List<KurotatoShopProductPbData>(shopData.ItemPbDatas);
			this.RefreshCostInner = shopData.RefreshCost;
			EventSystem.Instance.Emit(EEventName.KurotatoOnShopDataChanged);
		}

		// Token: 0x06038AEF RID: 232175 RVA: 0x00D72264 File Offset: 0x00D70464
		public void UpdateItem(IKurotatoItemData itemData, bool bIsAdd)
		{
			if (itemData.Count == 0)
			{
				this.HoldItemData.Remove(itemData.ItemId);
			}
			else
			{
				this.HoldItemData[itemData.ItemId] = itemData.Count;
			}
			EventSystem.Instance.Emit<int, bool>(EEventName.KurotatoOnItemUpdate, itemData.ItemId, bIsAdd);
		}

		// Token: 0x06038AF0 RID: 232176 RVA: 0x00D722BC File Offset: 0x00D704BC
		[NullableContext(2)]
		public void UpdateItemPanel(KurotatoItemPanelPbData itemPanelData)
		{
			this.HoldItemData.Clear();
			if (itemPanelData != null)
			{
				foreach (KurotatoItemPbData kurotatoItemPbData in itemPanelData.ItemPbDatas)
				{
					if (kurotatoItemPbData.Count > 0)
					{
						this.HoldItemData[kurotatoItemPbData.ItemId] = kurotatoItemPbData.Count;
					}
				}
			}
			EventSystem.Instance.Emit<int, bool>(EEventName.KurotatoOnItemUpdate, 0, true);
		}

		// Token: 0x06038AF1 RID: 232177 RVA: 0x00D72344 File Offset: 0x00D70544
		[NullableContext(2)]
		public void UpdateWeapon(KurotatoWeaponPanelPbData weaponData)
		{
			this.HoldWeaponData = new List<IKurotatoWeaponData>();
			if (weaponData != null)
			{
				foreach (KurotatoWeaponPbData kurotatoWeaponPbData in weaponData.WeaponPbDatas)
				{
					this.HoldWeaponData.Add(new KurotatoWeaponData
					{
						WeaponId = kurotatoWeaponPbData.WeaponId,
						IncId = kurotatoWeaponPbData.IncId,
						SellPrice = kurotatoWeaponPbData.SellPrice,
						PreWaveDealtDamage = kurotatoWeaponPbData.PreWaveDealtDamage
					});
				}
			}
			EventSystem.Instance.Emit(EEventName.KurotatoOnWeaponUpdate);
		}

		// Token: 0x06038AF2 RID: 232178 RVA: 0x00D723E8 File Offset: 0x00D705E8
		public void SetSettlementData(KurotatoSettlementNotify notify)
		{
			KurotatoSettlementInfo kurotatoSettlementInfo = notify.KurotatoSettlementInfo;
			List<KurotatoItemData> list = new List<KurotatoItemData>();
			if (kurotatoSettlementInfo.ItemPanelPbData != null)
			{
				foreach (KurotatoItemPbData kurotatoItemPbData in kurotatoSettlementInfo.ItemPanelPbData.ItemPbDatas)
				{
					list.Add(new KurotatoItemData
					{
						ItemId = kurotatoItemPbData.ItemId,
						Count = kurotatoItemPbData.Count
					});
				}
			}
			List<KurotatoWeaponData> list2 = new List<KurotatoWeaponData>();
			if (kurotatoSettlementInfo.WeaponPanelPbData != null)
			{
				foreach (KurotatoWeaponPbData kurotatoWeaponPbData in kurotatoSettlementInfo.WeaponPanelPbData.WeaponPbDatas)
				{
					list2.Add(new KurotatoWeaponData
					{
						WeaponId = kurotatoWeaponPbData.WeaponId,
						IncId = kurotatoWeaponPbData.IncId,
						SellPrice = kurotatoWeaponPbData.SellPrice,
						PreWaveDealtDamage = kurotatoWeaponPbData.PreWaveDealtDamage
					});
				}
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (kurotatoSettlementInfo.PropertyMap != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in kurotatoSettlementInfo.PropertyMap)
				{
					dictionary[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			this.SettlementDataInternal = new KurotatoSettlementData
			{
				IsPass = kurotatoSettlementInfo.IsPass,
				CompletionTime = (long)kurotatoSettlementInfo.CompletionTime,
				ItemPanelData = list,
				WeaponPanelData = list2,
				PassWaveCount = kurotatoSettlementInfo.PassWaveCount,
				CumulativeKills = kurotatoSettlementInfo.CumulativeKills,
				PropertyMap = dictionary,
				UnlockWeapons = new List<int>(kurotatoSettlementInfo.UnlockWeapons),
				UnlockItems = new List<int>(kurotatoSettlementInfo.UnlockItems),
				UnlockRoles = new List<int>(kurotatoSettlementInfo.UnlockRoles)
			};
		}

		// Token: 0x06038AF3 RID: 232179 RVA: 0x00D725E4 File Offset: 0x00D707E4
		[NullableContext(2)]
		public IKurotatoSettlementData GetSettlementData()
		{
			return this.SettlementDataInternal;
		}

		// Token: 0x06038AF4 RID: 232180 RVA: 0x00D725EC File Offset: 0x00D707EC
		public void ClearSettlementData()
		{
			this.SettlementDataInternal = null;
		}

		// Token: 0x06038AF5 RID: 232181 RVA: 0x00D725F5 File Offset: 0x00D707F5
		public void SetRoleSaveState(KurotatoRoleSaveState state)
		{
			this.RoleSaveStateInternal = state;
		}

		// Token: 0x06038AF6 RID: 232182 RVA: 0x00D725FE File Offset: 0x00D707FE
		public KurotatoRoleSaveState GetRoleSaveState()
		{
			return this.RoleSaveStateInternal;
		}

		// Token: 0x06038AF7 RID: 232183 RVA: 0x00D72606 File Offset: 0x00D70806
		public void SetRoleSaveIsPopView(bool isPopView)
		{
			this.RoleSaveIsPopViewInternal = isPopView;
		}

		// Token: 0x06038AF8 RID: 232184 RVA: 0x00D7260F File Offset: 0x00D7080F
		public bool GetRoleSaveIsPopView()
		{
			return this.RoleSaveIsPopViewInternal;
		}

		// Token: 0x06038AF9 RID: 232185 RVA: 0x00D72617 File Offset: 0x00D70817
		public void SetRoleSaveInstInfos(List<KurotatoInstInfo> instInfos)
		{
			this.RoleSaveInstInfosInternal = instInfos;
		}

		// Token: 0x06038AFA RID: 232186 RVA: 0x00D72620 File Offset: 0x00D70820
		public List<KurotatoInstInfo> GetRoleSaveInstInfos()
		{
			return this.RoleSaveInstInfosInternal;
		}

		// Token: 0x06038AFB RID: 232187 RVA: 0x00D72628 File Offset: 0x00D70828
		public void MarkNeedShowSaveTip()
		{
			this.NeedShowSaveTipInternal = true;
		}

		// Token: 0x06038AFC RID: 232188 RVA: 0x00D72631 File Offset: 0x00D70831
		public bool ConsumeNeedShowSaveTip()
		{
			if (!this.NeedShowSaveTipInternal)
			{
				return false;
			}
			this.NeedShowSaveTipInternal = false;
			return true;
		}

		// Token: 0x06038AFD RID: 232189 RVA: 0x00D72645 File Offset: 0x00D70845
		public void SetReChallengeCount(int maxCount, int usedCount)
		{
			this.MaxReChallengeCountInternal = maxCount;
			this.UsedReChallengeCountInternal = usedCount;
		}

		// Token: 0x06038AFE RID: 232190 RVA: 0x00D72655 File Offset: 0x00D70855
		public int GetMaxReChallengeCount()
		{
			return this.MaxReChallengeCountInternal;
		}

		// Token: 0x06038AFF RID: 232191 RVA: 0x00D7265D File Offset: 0x00D7085D
		public int GetUsedReChallengeCount()
		{
			return this.UsedReChallengeCountInternal;
		}

		// Token: 0x06038B00 RID: 232192 RVA: 0x00D72665 File Offset: 0x00D70865
		public int GetRemainReChallengeCount()
		{
			return Math.Max(0, this.MaxReChallengeCountInternal - this.UsedReChallengeCountInternal);
		}

		// Token: 0x06038B01 RID: 232193 RVA: 0x00D7267A File Offset: 0x00D7087A
		public bool IsReChallengeCountUnlimited()
		{
			return this.MaxReChallengeCountInternal == -1;
		}

		// Token: 0x06038B02 RID: 232194 RVA: 0x00D72688 File Offset: 0x00D70888
		public RoleDataBase GetRoleDataByKurotatoRoleId(int kurotatoRoleId)
		{
			int trialRole = KurotatoConfig.Instance.GetCharacterById(kurotatoRoleId).Value.TrialRole;
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			KurotatoRoleData kurotatoRoleData;
			if (instance == null)
			{
				kurotatoRoleData = null;
			}
			else
			{
				CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = instance.GetActivityData();
				kurotatoRoleData = ((activityData != null) ? activityData.GetKurotatoRoleData(kurotatoRoleId) : null);
			}
			KurotatoRoleData kurotatoRoleData2 = kurotatoRoleData;
			if (kurotatoRoleData2 == null || !kurotatoRoleData2.IsUnLock)
			{
				return RoleModel.Instance.GetRoleRobotData(trialRole);
			}
			return RoleModel.Instance.GetRoleDataByTrialRoleId(trialRole);
		}

		// Token: 0x06038B03 RID: 232195 RVA: 0x00D726F4 File Offset: 0x00D708F4
		public int GetActivityId()
		{
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = instance.GetActivityData();
				num = ((activityData != null) ? new int?(activityData.Id) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x06038B04 RID: 232196 RVA: 0x00D7273B File Offset: 0x00D7093B
		public bool IsActivityOn()
		{
			return this.GetActivityId() != 0;
		}

		// Token: 0x06038B05 RID: 232197 RVA: 0x00D72748 File Offset: 0x00D70948
		public int GetRogueCurrencyItemId()
		{
			KurotatoActivityConfig? activityConfig = this.GetActivityConfig();
			if (activityConfig == null)
			{
				return 0;
			}
			return activityConfig.GetValueOrDefault().CurrencyItemId;
		}

		// Token: 0x06038B06 RID: 232198 RVA: 0x00D72778 File Offset: 0x00D70978
		public KurotatoActivityConfig? GetActivityConfig()
		{
			if (!this.IsActivityOn())
			{
				return null;
			}
			return KurotatoConfig.Instance.GetActivityConfig(this.GetActivityId());
		}

		// Token: 0x1700885B RID: 34907
		// (get) Token: 0x06038B07 RID: 232199 RVA: 0x00D727A7 File Offset: 0x00D709A7
		public static KurotatoModel Instance
		{
			get
			{
				return KurotatoModel._Instance;
			}
		}

		// Token: 0x06038B08 RID: 232200 RVA: 0x00D727AE File Offset: 0x00D709AE
		public static KurotatoModel GetOrCreateInstance()
		{
			if (KurotatoModel._Instance == null)
			{
				KurotatoModel.CreateInstance();
			}
			return KurotatoModel._Instance;
		}

		// Token: 0x06038B09 RID: 232201 RVA: 0x00D727C2 File Offset: 0x00D709C2
		public static bool CreateInstance()
		{
			if (KurotatoModel._Instance != null)
			{
				return true;
			}
			KurotatoModel._Instance = new KurotatoModel();
			return true;
		}

		// Token: 0x06038B0A RID: 232202 RVA: 0x00D727D8 File Offset: 0x00D709D8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038B0B RID: 232203 RVA: 0x00D727DA File Offset: 0x00D709DA
		public static void ResetStaticDefaultValue()
		{
			KurotatoModel._Instance = null;
		}

		// Token: 0x06038B0C RID: 232204 RVA: 0x00D727E2 File Offset: 0x00D709E2
		static KurotatoModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoModel.CreateStaticDefaultValue), new Action(KurotatoModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DC00 RID: 121856
		private EKurotatoStep StepInternal = EKurotatoStep.None;

		// Token: 0x0401DC01 RID: 121857
		private EKurotatoStep PrevStepInternal = EKurotatoStep.None;

		// Token: 0x0401DC02 RID: 121858
		private bool IsStepStartInternal;

		// Token: 0x0401DC03 RID: 121859
		private int CurLevelIdInternal;

		// Token: 0x0401DC04 RID: 121860
		private int CurWaveStartLevelInternal;

		// Token: 0x0401DC05 RID: 121861
		public KurotatoBattleData BattleData = KurotatoBattleData.Create();

		// Token: 0x0401DC06 RID: 121862
		private int WaveDurationInternal;

		// Token: 0x0401DC07 RID: 121863
		private bool HasEndlessModeSelectionInternal;

		// Token: 0x0401DC08 RID: 121864
		private List<KurotatoItemRewardPbData> UpgradeRewardData = new List<KurotatoItemRewardPbData>();

		// Token: 0x0401DC09 RID: 121865
		private int UpgradeRewardIndexInternal;

		// Token: 0x0401DC0A RID: 121866
		private int UpgradeRewardCountInternal;

		// Token: 0x0401DC0B RID: 121867
		private int ChestItemIdInternal;

		// Token: 0x0401DC0C RID: 121868
		private int ChestSoldPriceInternal;

		// Token: 0x0401DC0D RID: 121869
		private int ChestRewardIndexInternal;

		// Token: 0x0401DC0E RID: 121870
		private int ChestRewardCount;

		// Token: 0x0401DC0F RID: 121871
		private List<KurotatoShopProductPbData> ShopData = new List<KurotatoShopProductPbData>();

		// Token: 0x0401DC10 RID: 121872
		private readonly Dictionary<int, int> HoldItemData = new Dictionary<int, int>();

		// Token: 0x0401DC11 RID: 121873
		private List<IKurotatoWeaponData> HoldWeaponData = new List<IKurotatoWeaponData>();

		// Token: 0x0401DC12 RID: 121874
		private readonly Dictionary<int, int> SystemPropertyValueMap = new Dictionary<int, int>();

		// Token: 0x0401DC13 RID: 121875
		private readonly Dictionary<int, int> LockedPropertyValueMap = new Dictionary<int, int>();

		// Token: 0x0401DC14 RID: 121876
		private int RefreshCostInner;

		// Token: 0x0401DC15 RID: 121877
		private int RoleId = 10001;

		// Token: 0x0401DC16 RID: 121878
		private KurotatoNextWaveType NextWaveTypeInternal;

		// Token: 0x0401DC17 RID: 121879
		private int NextWaveNumInternal;

		// Token: 0x0401DC18 RID: 121880
		public bool HideShopNotBuyConfirmBox;

		// Token: 0x0401DC19 RID: 121881
		public bool HideSellWeaponConfirmBox;

		// Token: 0x0401DC1A RID: 121882
		private bool BattleMusicStartedInternal;

		// Token: 0x0401DC1B RID: 121883
		[Nullable(2)]
		private IKurotatoSettlementData SettlementDataInternal;

		// Token: 0x0401DC1C RID: 121884
		private KurotatoRoleSaveState RoleSaveStateInternal;

		// Token: 0x0401DC1D RID: 121885
		private bool RoleSaveIsPopViewInternal;

		// Token: 0x0401DC1E RID: 121886
		private List<KurotatoInstInfo> RoleSaveInstInfosInternal = new List<KurotatoInstInfo>();

		// Token: 0x0401DC1F RID: 121887
		private bool NeedShowSaveTipInternal;

		// Token: 0x0401DC20 RID: 121888
		private int MaxReChallengeCountInternal;

		// Token: 0x0401DC21 RID: 121889
		private int UsedReChallengeCountInternal;

		// Token: 0x0401DC22 RID: 121890
		[Nullable(2)]
		private static KurotatoModel _Instance;

		// Token: 0x0200B8CF RID: 47311
		[Nullable(0)]
		private class ComposeBucket
		{
			// Token: 0x04037E85 RID: 228997
			public int Quality;

			// Token: 0x04037E86 RID: 228998
			public List<int> BagIncIds = new List<int>();

			// Token: 0x04037E87 RID: 228999
			public List<int> RecommendSelectionIds = new List<int>();
		}
	}
}
