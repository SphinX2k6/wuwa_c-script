using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046F0 RID: 18160
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class KurotatoModel : ModelBase
	{
		// Token: 0x0602D9C6 RID: 186822 RVA: 0x00CBF7A7 File Offset: 0x00CBD9A7
		protected override bool OnClear()
		{
			this.ClearInGameData();
			return true;
		}

		// Token: 0x0602D9C7 RID: 186823 RVA: 0x00CBF7B0 File Offset: 0x00CBD9B0
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

		// Token: 0x0602D9C8 RID: 186824 RVA: 0x00CBF893 File Offset: 0x00CBDA93
		public bool GetBattleMusicStarted()
		{
			return this.BattleMusicStartedInternal;
		}

		// Token: 0x0602D9C9 RID: 186825 RVA: 0x00CBF89B File Offset: 0x00CBDA9B
		public void SetBattleMusicStarted(bool value)
		{
			this.BattleMusicStartedInternal = value;
		}

		// Token: 0x0602D9CA RID: 186826 RVA: 0x00CBF8A4 File Offset: 0x00CBDAA4
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

		// Token: 0x0602D9CB RID: 186827 RVA: 0x00CBF9BC File Offset: 0x00CBDBBC
		public EKurotatoStep GetStep()
		{
			return this.StepInternal;
		}

		// Token: 0x0602D9CC RID: 186828 RVA: 0x00CBF9C4 File Offset: 0x00CBDBC4
		public EKurotatoStep GetPrevStep()
		{
			return this.PrevStepInternal;
		}

		// Token: 0x0602D9CD RID: 186829 RVA: 0x00CBF9CC File Offset: 0x00CBDBCC
		public bool GetIsStepStart()
		{
			return this.IsStepStartInternal;
		}

		// Token: 0x0602D9CE RID: 186830 RVA: 0x00CBF9D4 File Offset: 0x00CBDBD4
		public void SetCurLevelId(int levelId)
		{
			this.CurLevelIdInternal = levelId;
		}

		// Token: 0x0602D9CF RID: 186831 RVA: 0x00CBF9DD File Offset: 0x00CBDBDD
		public int GetCurLevelId()
		{
			return this.CurLevelIdInternal;
		}

		// Token: 0x0602D9D0 RID: 186832 RVA: 0x00CBF9E5 File Offset: 0x00CBDBE5
		public void SetCurWaveStartLevel(int level)
		{
			this.CurWaveStartLevelInternal = level;
		}

		// Token: 0x0602D9D1 RID: 186833 RVA: 0x00CBF9EE File Offset: 0x00CBDBEE
		public int GetCurWaveStartLevel()
		{
			return this.CurWaveStartLevelInternal;
		}

		// Token: 0x0602D9D2 RID: 186834 RVA: 0x00CBF9F6 File Offset: 0x00CBDBF6
		public bool GetIsEndlessWave()
		{
			return this.BattleData.GetBatchType() == EKurotatoBatchType.Endless;
		}

		// Token: 0x0602D9D3 RID: 186835 RVA: 0x00CBFA06 File Offset: 0x00CBDC06
		public bool GetIsSpecialWave()
		{
			return this.BattleData.GetBatchType() == EKurotatoBatchType.Special;
		}

		// Token: 0x0602D9D4 RID: 186836 RVA: 0x00CBFA18 File Offset: 0x00CBDC18
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

		// Token: 0x0602D9D5 RID: 186837 RVA: 0x00CBFA9C File Offset: 0x00CBDC9C
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

		// Token: 0x0602D9D6 RID: 186838 RVA: 0x00CBFB24 File Offset: 0x00CBDD24
		public void SetNextWaveType(KurotatoNextWaveType nextWaveType, int nextWaveNum)
		{
			this.NextWaveTypeInternal = nextWaveType;
			this.NextWaveNumInternal = nextWaveNum;
		}

		// Token: 0x0602D9D7 RID: 186839 RVA: 0x00CBFB34 File Offset: 0x00CBDD34
		public int GetNextWaveNum()
		{
			return this.NextWaveNumInternal;
		}

		// Token: 0x0602D9D8 RID: 186840 RVA: 0x00CBFB3C File Offset: 0x00CBDD3C
		public bool GetIsNextWaveSpecial()
		{
			return this.NextWaveTypeInternal == KurotatoNextWaveType.Special;
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x0602D9D9 RID: 186841 RVA: 0x00CBFB47 File Offset: 0x00CBDD47
		public int CurWaveNum
		{
			get
			{
				return this.BattleData.GetBatch();
			}
		}

		// Token: 0x0602D9DA RID: 186842 RVA: 0x00CBFB54 File Offset: 0x00CBDD54
		public int GetWaveDuration()
		{
			return this.WaveDurationInternal;
		}

		// Token: 0x0602D9DB RID: 186843 RVA: 0x00CBFB5C File Offset: 0x00CBDD5C
		public bool GetHasEndlessModeSelection()
		{
			return this.HasEndlessModeSelectionInternal;
		}

		// Token: 0x0602D9DC RID: 186844 RVA: 0x00CBFB64 File Offset: 0x00CBDD64
		public int GetRefreshCost()
		{
			return this.RefreshCostInner;
		}

		// Token: 0x0602D9DD RID: 186845 RVA: 0x00CBFB6C File Offset: 0x00CBDD6C
		public int GetRoleId()
		{
			return this.RoleId;
		}

		// Token: 0x0602D9DE RID: 186846 RVA: 0x00CBFB74 File Offset: 0x00CBDD74
		public List<KurotatoItemRewardPbData> GetUpgradeRewardData()
		{
			return this.UpgradeRewardData;
		}

		// Token: 0x0602D9DF RID: 186847 RVA: 0x00CBFB7C File Offset: 0x00CBDD7C
		public int GetUpgradeRewardIndex()
		{
			return this.UpgradeRewardIndexInternal;
		}

		// Token: 0x0602D9E0 RID: 186848 RVA: 0x00CBFB84 File Offset: 0x00CBDD84
		public int GetUpgradeRewardCount()
		{
			return this.UpgradeRewardCountInternal;
		}

		// Token: 0x0602D9E1 RID: 186849 RVA: 0x00CBFB8C File Offset: 0x00CBDD8C
		public int GetChestItemId()
		{
			return this.ChestItemIdInternal;
		}

		// Token: 0x0602D9E2 RID: 186850 RVA: 0x00CBFB94 File Offset: 0x00CBDD94
		public int GetChestSoldPrice()
		{
			return this.ChestSoldPriceInternal;
		}

		// Token: 0x0602D9E3 RID: 186851 RVA: 0x00CBFB9C File Offset: 0x00CBDD9C
		public int GetChestRewardIndex()
		{
			return this.ChestRewardIndexInternal;
		}

		// Token: 0x0602D9E4 RID: 186852 RVA: 0x00CBFBA4 File Offset: 0x00CBDDA4
		public int GetChestRewardCount()
		{
			return this.ChestRewardCount;
		}

		// Token: 0x0602D9E5 RID: 186853 RVA: 0x00CBFBAC File Offset: 0x00CBDDAC
		public List<KurotatoShopProductPbData> GetShopData()
		{
			return this.ShopData;
		}

		// Token: 0x0602D9E6 RID: 186854 RVA: 0x00CBFBB4 File Offset: 0x00CBDDB4
		public bool IsRecommendWeapon(int weaponId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoCharacter? characterById = instance.GetCharacterById(this.GetRoleId());
			if (characterById == null)
			{
				return false;
			}
			using (IEnumerator<int> enumerator = characterById.Value.ExcludedRecommendWeaponIdsIter().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == weaponId)
					{
						return false;
					}
				}
			}
			KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(weaponId);
			KurotatoWeaponGroup? kurotatoWeaponGroup = (weaponConfigByWeaponId != null) ? instance.GetWeaponGroupById(weaponConfigByWeaponId.Value.GroupId) : null;
			List<string> list = (kurotatoWeaponGroup != null) ? new List<string>(kurotatoWeaponGroup.Value.TagsIter()) : new List<string>();
			foreach (string item in characterById.Value.RecommendedTagsIter())
			{
				if (list.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D9E7 RID: 186855 RVA: 0x00CBFCE8 File Offset: 0x00CBDEE8
		public bool IsRecommendItem(int itemId)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoCharacter? characterById = instance.GetCharacterById(this.GetRoleId());
			if (characterById == null)
			{
				return false;
			}
			using (IEnumerator<int> enumerator = characterById.Value.ExcludedRecommendItemIdsIter().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == itemId)
					{
						return false;
					}
				}
			}
			KurotatoItem? itemConfigByItemId = instance.GetItemConfigByItemId(itemId);
			List<string> list = (itemConfigByItemId != null) ? new List<string>(itemConfigByItemId.Value.TagsIter()) : new List<string>();
			foreach (string item in characterById.Value.RecommendedTagsIter())
			{
				if (list.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D9E8 RID: 186856 RVA: 0x00CBFDEC File Offset: 0x00CBDFEC
		public void ClearShopData()
		{
			this.ShopData = new List<KurotatoShopProductPbData>();
			this.RefreshCostInner = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnShopDataChanged);
		}

		// Token: 0x0602D9E9 RID: 186857 RVA: 0x00CBFE10 File Offset: 0x00CBE010
		public void ClearUpgradeRewardData()
		{
			this.UpgradeRewardData = new List<KurotatoItemRewardPbData>();
			this.UpgradeRewardIndexInternal = 0;
			this.UpgradeRewardCountInternal = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnUpgradeRewardDataChanged);
		}

		// Token: 0x0602D9EA RID: 186858 RVA: 0x00CBFE3B File Offset: 0x00CBE03B
		public void ClearChestRewardData()
		{
			this.ChestItemIdInternal = 0;
			this.ChestSoldPriceInternal = 0;
			this.ChestRewardIndexInternal = 0;
			this.ChestRewardCount = 0;
			EventSystem.Instance.Emit(EEventName.KurotatoOnChestRewardDataChanged);
		}

		// Token: 0x0602D9EB RID: 186859 RVA: 0x00CBFE6C File Offset: 0x00CBE06C
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

		// Token: 0x0602D9EC RID: 186860 RVA: 0x00CBFF60 File Offset: 0x00CBE160
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
			bool flag = false;
			foreach (KurotatoShopProductPbData kurotatoShopProductPbData in shopData)
			{
				if (kurotatoShopProductPbData.WeaponData != null && !kurotatoShopProductPbData.IsBought && this.IsRecommendWeapon(kurotatoShopProductPbData.WeaponData.WeaponId))
				{
					flag = true;
					break;
				}
			}
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
			foreach (KurotatoShopProductPbData kurotatoShopProductPbData2 in shopData)
			{
				if (kurotatoShopProductPbData2.WeaponData != null && !kurotatoShopProductPbData2.IsBought)
				{
					int weaponId = kurotatoShopProductPbData2.WeaponData.WeaponId;
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
								composeBucket2.RecommendSelectionIds.Add(kurotatoShopProductPbData2.SelectionId);
							}
						}
					}
				}
			}
			List<KurotatoModel.ComposeBucket> list = NoLinq.WhereSortToList<KurotatoModel.ComposeBucket>(dictionary.Values, (KurotatoModel.ComposeBucket bucket) => bucket.RecommendSelectionIds.Count > 0, (KurotatoModel.ComposeBucket left, KurotatoModel.ComposeBucket right) => left.Quality.CompareTo(right.Quality));
			List<KurotatoModel.ComposeBucket> list2 = NoLinq.WhereSortToList<KurotatoModel.ComposeBucket>(dictionary.Values, (KurotatoModel.ComposeBucket bucket) => bucket.RecommendSelectionIds.Count == 0 && bucket.BagIncIds.Count >= 2, (KurotatoModel.ComposeBucket left, KurotatoModel.ComposeBucket right) => left.Quality.CompareTo(right.Quality));
			foreach (KurotatoModel.ComposeBucket composeBucket3 in list)
			{
				if (hashSet2.Count >= 2)
				{
					break;
				}
				hashSet2.Add(composeBucket3.BagIncIds[0]);
				foreach (int item in composeBucket3.RecommendSelectionIds)
				{
					hashSet.Add(item);
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

		// Token: 0x0602D9ED RID: 186861 RVA: 0x00CC0410 File Offset: 0x00CBE610
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

		// Token: 0x0602D9EE RID: 186862 RVA: 0x00CC0494 File Offset: 0x00CBE694
		public int GetHoldItemCount(int itemId)
		{
			int result;
			if (!this.HoldItemData.TryGetValue(itemId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0602D9EF RID: 186863 RVA: 0x00CC04B4 File Offset: 0x00CBE6B4
		public List<IKurotatoWeaponData> GetHoldWeaponData()
		{
			return this.HoldWeaponData;
		}

		// Token: 0x0602D9F0 RID: 186864 RVA: 0x00CC04BC File Offset: 0x00CBE6BC
		public bool IsWeaponBagFull()
		{
			KurotatoActivityConfig? kurotatoActivityConfig;
			int num = (this.GetActivityConfig() != null) ? kurotatoActivityConfig.GetValueOrDefault().WeaponCount : this.HoldWeaponData.Count;
			return this.HoldWeaponData.Count >= num;
		}

		// Token: 0x0602D9F1 RID: 186865 RVA: 0x00CC0508 File Offset: 0x00CBE708
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

		// Token: 0x0602D9F2 RID: 186866 RVA: 0x00CC0564 File Offset: 0x00CBE764
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

		// Token: 0x0602D9F3 RID: 186867 RVA: 0x00CC0630 File Offset: 0x00CBE830
		public void SetRoleId(int roleId)
		{
			this.RoleId = roleId;
		}

		// Token: 0x0602D9F4 RID: 186868 RVA: 0x00CC0639 File Offset: 0x00CBE839
		public void SetSystemPropertyValues(IDictionary<int, int> propertyValues, IDictionary<int, int> lockedPropertyValues)
		{
			this.SystemPropertyValueMap.Clear();
			this.UpdateSystemPropertyValues(propertyValues, lockedPropertyValues);
		}

		// Token: 0x0602D9F5 RID: 186869 RVA: 0x00CC0650 File Offset: 0x00CBE850
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

		// Token: 0x0602D9F6 RID: 186870 RVA: 0x00CC0700 File Offset: 0x00CBE900
		public int GetSystemPropertyValue(int propertyId)
		{
			int result;
			if (!this.SystemPropertyValueMap.TryGetValue(propertyId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0602D9F7 RID: 186871 RVA: 0x00CC0720 File Offset: 0x00CBE920
		public bool IsSystemPropertyLocked(int propertyId)
		{
			return this.LockedPropertyValueMap.ContainsKey(propertyId);
		}

		// Token: 0x0602D9F8 RID: 186872 RVA: 0x00CC0730 File Offset: 0x00CBE930
		public int GetSystemPropertyLockedValue(int propertyId)
		{
			int result;
			if (!this.LockedPropertyValueMap.TryGetValue(propertyId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0602D9F9 RID: 186873 RVA: 0x00CC0750 File Offset: 0x00CBE950
		public int GetPropertyValue(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.GetPlayerPropertyValue(propertyId);
			}
			return this.GetSystemPropertyValue(propertyId);
		}

		// Token: 0x0602D9FA RID: 186874 RVA: 0x00CC0773 File Offset: 0x00CBE973
		public bool IsPropertyLocked(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.IsPlayerPropertyLocked(propertyId);
			}
			return this.IsSystemPropertyLocked(propertyId);
		}

		// Token: 0x0602D9FB RID: 186875 RVA: 0x00CC0796 File Offset: 0x00CBE996
		public int GetPropertyLockedValue(int propertyId)
		{
			if (!KurotatoConfig.Instance.IsServerCtrlProperty(propertyId))
			{
				return this.BattleData.GetPlayerPropertyLockedValue(propertyId);
			}
			return this.GetSystemPropertyLockedValue(propertyId);
		}

		// Token: 0x0602D9FC RID: 186876 RVA: 0x00CC07BC File Offset: 0x00CBE9BC
		public void SetUpgradeRewardData(KurotatoItemRewardPanelPbData rewardData)
		{
			this.UpgradeRewardData = new List<KurotatoItemRewardPbData>(rewardData.RewardItemDatas);
			this.RefreshCostInner = rewardData.RefreshCost;
			this.UpgradeRewardIndexInternal = rewardData.RewardIndex;
			this.UpgradeRewardCountInternal = rewardData.TotalRewardCount;
			EventSystem.Instance.Emit(EEventName.KurotatoOnUpgradeRewardDataChanged);
		}

		// Token: 0x0602D9FD RID: 186877 RVA: 0x00CC080E File Offset: 0x00CBEA0E
		public void SetChestRewardData(int itemId, int soldPrice, int rewardIndex, int rewardCount)
		{
			this.ChestItemIdInternal = itemId;
			this.ChestSoldPriceInternal = soldPrice;
			this.ChestRewardIndexInternal = rewardIndex;
			this.ChestRewardCount = rewardCount;
			EventSystem.Instance.Emit(EEventName.KurotatoOnChestRewardDataChanged);
		}

		// Token: 0x0602D9FE RID: 186878 RVA: 0x00CC083D File Offset: 0x00CBEA3D
		public void SetShopData(KurotatoShopPanelPbData shopData)
		{
			this.ShopData = new List<KurotatoShopProductPbData>(shopData.ItemPbDatas);
			this.RefreshCostInner = shopData.RefreshCost;
			EventSystem.Instance.Emit(EEventName.KurotatoOnShopDataChanged);
		}

		// Token: 0x0602D9FF RID: 186879 RVA: 0x00CC086C File Offset: 0x00CBEA6C
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

		// Token: 0x0602DA00 RID: 186880 RVA: 0x00CC08C4 File Offset: 0x00CBEAC4
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

		// Token: 0x0602DA01 RID: 186881 RVA: 0x00CC094C File Offset: 0x00CBEB4C
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

		// Token: 0x0602DA02 RID: 186882 RVA: 0x00CC09F0 File Offset: 0x00CBEBF0
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

		// Token: 0x0602DA03 RID: 186883 RVA: 0x00CC0BEC File Offset: 0x00CBEDEC
		[NullableContext(2)]
		public IKurotatoSettlementData GetSettlementData()
		{
			return this.SettlementDataInternal;
		}

		// Token: 0x0602DA04 RID: 186884 RVA: 0x00CC0BF4 File Offset: 0x00CBEDF4
		public void ClearSettlementData()
		{
			this.SettlementDataInternal = null;
		}

		// Token: 0x0602DA05 RID: 186885 RVA: 0x00CC0BFD File Offset: 0x00CBEDFD
		public void SetRoleSaveState(KurotatoRoleSaveState state)
		{
			this.RoleSaveStateInternal = state;
		}

		// Token: 0x0602DA06 RID: 186886 RVA: 0x00CC0C06 File Offset: 0x00CBEE06
		public KurotatoRoleSaveState GetRoleSaveState()
		{
			return this.RoleSaveStateInternal;
		}

		// Token: 0x0602DA07 RID: 186887 RVA: 0x00CC0C0E File Offset: 0x00CBEE0E
		public void SetRoleSaveIsPopView(bool isPopView)
		{
			this.RoleSaveIsPopViewInternal = isPopView;
		}

		// Token: 0x0602DA08 RID: 186888 RVA: 0x00CC0C17 File Offset: 0x00CBEE17
		public bool GetRoleSaveIsPopView()
		{
			return this.RoleSaveIsPopViewInternal;
		}

		// Token: 0x0602DA09 RID: 186889 RVA: 0x00CC0C1F File Offset: 0x00CBEE1F
		public void SetRoleSaveInstInfos(List<KurotatoInstInfo> instInfos)
		{
			this.RoleSaveInstInfosInternal = instInfos;
		}

		// Token: 0x0602DA0A RID: 186890 RVA: 0x00CC0C28 File Offset: 0x00CBEE28
		public List<KurotatoInstInfo> GetRoleSaveInstInfos()
		{
			return this.RoleSaveInstInfosInternal;
		}

		// Token: 0x0602DA0B RID: 186891 RVA: 0x00CC0C30 File Offset: 0x00CBEE30
		public void MarkNeedShowSaveTip()
		{
			this.NeedShowSaveTipInternal = true;
		}

		// Token: 0x0602DA0C RID: 186892 RVA: 0x00CC0C39 File Offset: 0x00CBEE39
		public bool ConsumeNeedShowSaveTip()
		{
			if (!this.NeedShowSaveTipInternal)
			{
				return false;
			}
			this.NeedShowSaveTipInternal = false;
			return true;
		}

		// Token: 0x0602DA0D RID: 186893 RVA: 0x00CC0C4D File Offset: 0x00CBEE4D
		public void SetReChallengeCount(int maxCount, int usedCount)
		{
			this.MaxReChallengeCountInternal = maxCount;
			this.UsedReChallengeCountInternal = usedCount;
		}

		// Token: 0x0602DA0E RID: 186894 RVA: 0x00CC0C5D File Offset: 0x00CBEE5D
		public int GetMaxReChallengeCount()
		{
			return this.MaxReChallengeCountInternal;
		}

		// Token: 0x0602DA0F RID: 186895 RVA: 0x00CC0C65 File Offset: 0x00CBEE65
		public int GetUsedReChallengeCount()
		{
			return this.UsedReChallengeCountInternal;
		}

		// Token: 0x0602DA10 RID: 186896 RVA: 0x00CC0C6D File Offset: 0x00CBEE6D
		public int GetRemainReChallengeCount()
		{
			return Math.Max(0, this.MaxReChallengeCountInternal - this.UsedReChallengeCountInternal);
		}

		// Token: 0x0602DA11 RID: 186897 RVA: 0x00CC0C82 File Offset: 0x00CBEE82
		public bool IsReChallengeCountUnlimited()
		{
			return this.MaxReChallengeCountInternal == -1;
		}

		// Token: 0x0602DA12 RID: 186898 RVA: 0x00CC0C90 File Offset: 0x00CBEE90
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

		// Token: 0x0602DA13 RID: 186899 RVA: 0x00CC0CFC File Offset: 0x00CBEEFC
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

		// Token: 0x0602DA14 RID: 186900 RVA: 0x00CC0D43 File Offset: 0x00CBEF43
		public bool IsActivityOn()
		{
			return this.GetActivityId() != 0;
		}

		// Token: 0x0602DA15 RID: 186901 RVA: 0x00CC0D50 File Offset: 0x00CBEF50
		public int GetRogueCurrencyItemId()
		{
			KurotatoActivityConfig? activityConfig = this.GetActivityConfig();
			if (activityConfig == null)
			{
				return 0;
			}
			return activityConfig.GetValueOrDefault().CurrencyItemId;
		}

		// Token: 0x0602DA16 RID: 186902 RVA: 0x00CC0D80 File Offset: 0x00CBEF80
		public KurotatoActivityConfig? GetActivityConfig()
		{
			if (!this.IsActivityOn())
			{
				return null;
			}
			return KurotatoConfig.Instance.GetActivityConfig(this.GetActivityId());
		}

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x0602DA17 RID: 186903 RVA: 0x00CC0DAF File Offset: 0x00CBEFAF
		public static KurotatoModel Instance
		{
			get
			{
				return KurotatoModel._Instance;
			}
		}

		// Token: 0x0602DA18 RID: 186904 RVA: 0x00CC0DB6 File Offset: 0x00CBEFB6
		public static KurotatoModel GetOrCreateInstance()
		{
			if (KurotatoModel._Instance == null)
			{
				KurotatoModel.CreateInstance();
			}
			return KurotatoModel._Instance;
		}

		// Token: 0x0602DA19 RID: 186905 RVA: 0x00CC0DCA File Offset: 0x00CBEFCA
		public static bool CreateInstance()
		{
			if (KurotatoModel._Instance != null)
			{
				return true;
			}
			KurotatoModel._Instance = new KurotatoModel();
			return true;
		}

		// Token: 0x0602DA1A RID: 186906 RVA: 0x00CC0DE0 File Offset: 0x00CBEFE0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DA1B RID: 186907 RVA: 0x00CC0DE2 File Offset: 0x00CBEFE2
		public static void ResetStaticDefaultValue()
		{
			KurotatoModel._Instance = null;
		}

		// Token: 0x0602DA1C RID: 186908 RVA: 0x00CC0DEA File Offset: 0x00CBEFEA
		static KurotatoModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoModel.CreateStaticDefaultValue), new Action(KurotatoModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018696 RID: 99990
		private EKurotatoStep StepInternal = EKurotatoStep.None;

		// Token: 0x04018697 RID: 99991
		private EKurotatoStep PrevStepInternal = EKurotatoStep.None;

		// Token: 0x04018698 RID: 99992
		private bool IsStepStartInternal;

		// Token: 0x04018699 RID: 99993
		private int CurLevelIdInternal;

		// Token: 0x0401869A RID: 99994
		private int CurWaveStartLevelInternal;

		// Token: 0x0401869B RID: 99995
		public KurotatoBattleData BattleData = KurotatoBattleData.Create();

		// Token: 0x0401869C RID: 99996
		private int WaveDurationInternal;

		// Token: 0x0401869D RID: 99997
		private bool HasEndlessModeSelectionInternal;

		// Token: 0x0401869E RID: 99998
		private List<KurotatoItemRewardPbData> UpgradeRewardData = new List<KurotatoItemRewardPbData>();

		// Token: 0x0401869F RID: 99999
		private int UpgradeRewardIndexInternal;

		// Token: 0x040186A0 RID: 100000
		private int UpgradeRewardCountInternal;

		// Token: 0x040186A1 RID: 100001
		private int ChestItemIdInternal;

		// Token: 0x040186A2 RID: 100002
		private int ChestSoldPriceInternal;

		// Token: 0x040186A3 RID: 100003
		private int ChestRewardIndexInternal;

		// Token: 0x040186A4 RID: 100004
		private int ChestRewardCount;

		// Token: 0x040186A5 RID: 100005
		private List<KurotatoShopProductPbData> ShopData = new List<KurotatoShopProductPbData>();

		// Token: 0x040186A6 RID: 100006
		private readonly Dictionary<int, int> HoldItemData = new Dictionary<int, int>();

		// Token: 0x040186A7 RID: 100007
		private List<IKurotatoWeaponData> HoldWeaponData = new List<IKurotatoWeaponData>();

		// Token: 0x040186A8 RID: 100008
		private readonly Dictionary<int, int> SystemPropertyValueMap = new Dictionary<int, int>();

		// Token: 0x040186A9 RID: 100009
		private readonly Dictionary<int, int> LockedPropertyValueMap = new Dictionary<int, int>();

		// Token: 0x040186AA RID: 100010
		private int RefreshCostInner;

		// Token: 0x040186AB RID: 100011
		private int RoleId = 10001;

		// Token: 0x040186AC RID: 100012
		private KurotatoNextWaveType NextWaveTypeInternal;

		// Token: 0x040186AD RID: 100013
		private int NextWaveNumInternal;

		// Token: 0x040186AE RID: 100014
		public bool HideShopNotBuyConfirmBox;

		// Token: 0x040186AF RID: 100015
		public bool HideSellWeaponConfirmBox;

		// Token: 0x040186B0 RID: 100016
		private bool BattleMusicStartedInternal;

		// Token: 0x040186B1 RID: 100017
		[Nullable(2)]
		private IKurotatoSettlementData SettlementDataInternal;

		// Token: 0x040186B2 RID: 100018
		private KurotatoRoleSaveState RoleSaveStateInternal;

		// Token: 0x040186B3 RID: 100019
		private bool RoleSaveIsPopViewInternal;

		// Token: 0x040186B4 RID: 100020
		private List<KurotatoInstInfo> RoleSaveInstInfosInternal = new List<KurotatoInstInfo>();

		// Token: 0x040186B5 RID: 100021
		private bool NeedShowSaveTipInternal;

		// Token: 0x040186B6 RID: 100022
		private int MaxReChallengeCountInternal;

		// Token: 0x040186B7 RID: 100023
		private int UsedReChallengeCountInternal;

		// Token: 0x040186B8 RID: 100024
		[Nullable(2)]
		private static KurotatoModel _Instance;

		// Token: 0x0200A2F5 RID: 41717
		[Nullable(0)]
		private class ComposeBucket
		{
			// Token: 0x0403289C RID: 207004
			public int Quality;

			// Token: 0x0403289D RID: 207005
			public List<int> BagIncIds = new List<int>();

			// Token: 0x0403289E RID: 207006
			public List<int> RecommendSelectionIds = new List<int>();
		}
	}
}
