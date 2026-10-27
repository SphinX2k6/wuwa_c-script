using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AFC RID: 23292
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CookModel : ModelBase
	{
		// Token: 0x0603AF5B RID: 241499 RVA: 0x00E0F593 File Offset: 0x00E0D793
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603AF5C RID: 241500 RVA: 0x00E0F596 File Offset: 0x00E0D796
		protected override bool OnClear()
		{
			this.ClearCookRoleItemDataList();
			return true;
		}

		// Token: 0x17008C39 RID: 35897
		// (get) Token: 0x0603AF5D RID: 241501 RVA: 0x00E0F59F File Offset: 0x00E0D79F
		// (set) Token: 0x0603AF5E RID: 241502 RVA: 0x00E0F5A7 File Offset: 0x00E0D7A7
		public ECookDataType CurrentCookViewType
		{
			get
			{
				return this.CookViewType;
			}
			set
			{
				this.CookViewType = value;
			}
		}

		// Token: 0x17008C3A RID: 35898
		// (get) Token: 0x0603AF5F RID: 241503 RVA: 0x00E0F5B0 File Offset: 0x00E0D7B0
		// (set) Token: 0x0603AF60 RID: 241504 RVA: 0x00E0F5B8 File Offset: 0x00E0D7B8
		public ECookListType CurrentCookListType
		{
			get
			{
				return this.CookListType;
			}
			set
			{
				this.CookListType = value;
			}
		}

		// Token: 0x0603AF61 RID: 241505 RVA: 0x00E0F5C1 File Offset: 0x00E0D7C1
		public CookModel()
		{
			this.LimitRefreshTime = -1.0;
			this.LastExp = 0;
			this.CookViewType = ECookDataType.CookMain;
			this.CookListType = ECookListType.Cooking;
			this.TimeoutCookingDataMap = new Dictionary<int, ECookDataTimeState>();
		}

		// Token: 0x0603AF62 RID: 241506 RVA: 0x00E0F5F8 File Offset: 0x00E0D7F8
		public void SaveLimitRefreshTime(long refreshTime)
		{
			this.LimitRefreshTime = (double)MathUtils.Instance.LongToNumber(refreshTime) * TimeUtil.Instance.Millisecond;
		}

		// Token: 0x0603AF63 RID: 241507 RVA: 0x00E0F617 File Offset: 0x00E0D817
		public bool CheckCanCook(int itemId)
		{
			return this.CheckLimitCount(itemId) && this.CheckCoinEnough(itemId) && this.CheckMaterialEnough(itemId);
		}

		// Token: 0x0603AF64 RID: 241508 RVA: 0x00E0F634 File Offset: 0x00E0D834
		public bool CheckLimitCount(int itemId)
		{
			ICookingData cookingDataById = this.GetCookingDataById(itemId);
			return cookingDataById.LimitTotalCount <= 0 || cookingDataById.CookCount < cookingDataById.LimitTotalCount;
		}

		// Token: 0x0603AF65 RID: 241509 RVA: 0x00E0F664 File Offset: 0x00E0D864
		public bool CheckCoinEnough(int itemId)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(itemId);
			List<OneItemConfig> list = new List<OneItemConfig>();
			for (int i = 0; i < cookFormulaById.ConsumeItemsLength; i++)
			{
				list.Add(cookFormulaById.ConsumeItems(i).Value);
			}
			return InventoryModel.Instance.CheckIsCoinEnough(CookController.Instance.CookCoinId, list);
		}

		// Token: 0x0603AF66 RID: 241510 RVA: 0x00E0F6C0 File Offset: 0x00E0D8C0
		public bool CheckMaterialEnough(int itemId)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(itemId);
			for (int i = 0; i < cookFormulaById.ConsumeItemsLength; i++)
			{
				OneItemConfig value = cookFormulaById.ConsumeItems(i).Value;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(value.ItemId, 0);
				if (value.Count > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603AF67 RID: 241511 RVA: 0x00E0F720 File Offset: 0x00E0D920
		public bool CheckHasItemTimeoutStateChangedCore()
		{
			List<ICookingData> cookingDataList = this.CookingDataList;
			Dictionary<int, ECookDataTimeState> timeoutCookingDataMap = this.TimeoutCookingDataMap;
			foreach (int key in new List<int>(timeoutCookingDataMap.Keys))
			{
				timeoutCookingDataMap[key]--;
			}
			bool result = false;
			foreach (ICookingData cookingData in cookingDataList)
			{
				if (cookingData.ExistStartTime != 0.0 && cookingData.ExistEndTime != 0.0)
				{
					int itemId = cookingData.ItemId;
					ECookDataTimeState ecookDataTimeState = TimeUtil.Instance.IsInTimeSpan(cookingData.ExistStartTime, cookingData.ExistEndTime) ? ECookDataTimeState.IN : ECookDataTimeState.OUT;
					ECookDataTimeState ecookDataTimeState2;
					if (!timeoutCookingDataMap.TryGetValue(itemId, out ecookDataTimeState2) || ecookDataTimeState2 != ecookDataTimeState - 1)
					{
						result = true;
					}
					timeoutCookingDataMap[itemId] = ecookDataTimeState;
				}
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, ECookDataTimeState> keyValuePair in timeoutCookingDataMap)
			{
				if (keyValuePair.Value == ECookDataTimeState.IN2NIL || keyValuePair.Value == ECookDataTimeState.OUT2NIL)
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (int key2 in list)
			{
				timeoutCookingDataMap.Remove(key2);
			}
			return result;
		}

		// Token: 0x0603AF68 RID: 241512 RVA: 0x00E0F8DC File Offset: 0x00E0DADC
		public void CreateCookingDataList(IReadOnlyList<SingleFoodFormulaInfo> cookFoodDataList)
		{
			if (this.CookingDataList == null)
			{
				this.CookingDataList = new List<ICookingData>();
			}
			this.CookingDataList.Clear();
			IReadOnlyList<CookFormula> readOnlyList = CookConfig.Instance.GetCookFormula() ?? new List<CookFormula>();
			Dictionary<int, ICookingData> dictionary = new Dictionary<int, ICookingData>();
			if (readOnlyList != null)
			{
				foreach (CookFormula cookFormula in readOnlyList)
				{
					ItemInfo? config = ItemConfig.Instance.GetConfig(cookFormula.FoodItemId);
					CookingData cookingData = new CookingData
					{
						MainType = ECookListType.Cooking,
						SubType = ESubCookDataType.CookMenu,
						UniqueId = 0,
						ItemId = cookFormula.Id,
						CookCount = 0,
						IsNew = false,
						LastRoleId = null,
						IsCook = 0,
						Quality = config.Value.QualityId,
						EffectType = cookFormula.TypeId,
						DataId = cookFormula.FoodItemId,
						LimitTotalCount = 0,
						LimitedCount = 0,
						ExistStartTime = 0.0,
						ExistEndTime = 0.0,
						IsUnLock = false
					};
					dictionary.Add(cookingData.ItemId, cookingData);
					this.CookingDataList.Add(cookingData);
				}
			}
			if (cookFoodDataList != null)
			{
				foreach (SingleFoodFormulaInfo singleFoodFormulaInfo in cookFoodDataList)
				{
					CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(singleFoodFormulaInfo.Id);
					ItemInfo? config2 = ItemConfig.Instance.GetConfig(cookFormulaById.FoodItemId);
					ICookingData cookingData2;
					if (dictionary.ContainsKey(singleFoodFormulaInfo.Id))
					{
						cookingData2 = dictionary[singleFoodFormulaInfo.Id];
						cookingData2.CookCount = singleFoodFormulaInfo.CookCount;
						cookingData2.IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CookerLevelKey, singleFoodFormulaInfo.Id);
						cookingData2.LastRoleId = new int?(singleFoodFormulaInfo.LastRoleId);
						cookingData2.IsCook = 0;
						cookingData2.LimitTotalCount = singleFoodFormulaInfo.LimitCount;
						cookingData2.LimitedCount = singleFoodFormulaInfo.LimitCookCount;
						cookingData2.DataId = cookFormulaById.FoodItemId;
						cookingData2.ExistStartTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
						cookingData2.ExistEndTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
						cookingData2.IsUnLock = true;
					}
					else
					{
						cookingData2 = new CookingData
						{
							MainType = ECookListType.Cooking,
							SubType = ESubCookDataType.CookFood,
							UniqueId = 0,
							ItemId = singleFoodFormulaInfo.Id,
							CookCount = singleFoodFormulaInfo.CookCount,
							IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CookerLevelKey, singleFoodFormulaInfo.Id),
							LastRoleId = new int?(singleFoodFormulaInfo.LastRoleId),
							IsCook = 0,
							Quality = config2.Value.QualityId,
							EffectType = cookFormulaById.TypeId,
							DataId = cookFormulaById.FoodItemId,
							LimitTotalCount = singleFoodFormulaInfo.LimitCount,
							LimitedCount = singleFoodFormulaInfo.LimitCookCount,
							ExistStartTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond,
							ExistEndTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitEndTime) * TimeUtil.Instance.Millisecond,
							IsUnLock = true
						};
						this.CookingDataList.Add(cookingData2);
					}
					cookingData2.IsCook = ((this.CheckCanCook(singleFoodFormulaInfo.Id) > false) ? 1 : 0);
				}
			}
		}

		// Token: 0x0603AF69 RID: 241513 RVA: 0x00E0FCC0 File Offset: 0x00E0DEC0
		public void UpdateCookingDataList(IReadOnlyList<SingleFoodFormulaInfo> cookFoodDataList)
		{
			if (this.CookingDataList == null)
			{
				this.CreateCookingDataList(cookFoodDataList);
			}
			if (cookFoodDataList != null)
			{
				foreach (SingleFoodFormulaInfo singleFoodFormulaInfo in cookFoodDataList)
				{
					foreach (ICookingData cookingData in this.CookingDataList)
					{
						if (singleFoodFormulaInfo.Id == cookingData.ItemId)
						{
							cookingData.CookCount = singleFoodFormulaInfo.CookCount;
							cookingData.LimitTotalCount = singleFoodFormulaInfo.LimitCount;
							cookingData.LimitedCount = singleFoodFormulaInfo.LimitCookCount;
							if (!cookingData.IsUnLock)
							{
								CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(singleFoodFormulaInfo.Id);
								cookingData.IsNew = true;
								cookingData.IsUnLock = true;
								cookingData.DataId = cookFormulaById.FoodItemId;
								cookingData.ExistStartTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
								cookingData.ExistEndTime = (double)MathUtils.Instance.LongToNumber(singleFoodFormulaInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
								NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.CookerLevelKey, singleFoodFormulaInfo.Id);
								GenericPromptController.Instance.ShowPromptByCode("FormulaLearned", Array.Empty<object>());
							}
							cookingData.IsCook = ((this.CheckCanCook(singleFoodFormulaInfo.Id) > false) ? 1 : 0);
						}
					}
				}
			}
		}

		// Token: 0x0603AF6A RID: 241514 RVA: 0x00E0FE64 File Offset: 0x00E0E064
		public void UpdateCookingDataByServerConfig(IReadOnlyList<OneFormulaConfig> formulaConfigs)
		{
			if (formulaConfigs != null)
			{
				using (IEnumerator<OneFormulaConfig> enumerator = formulaConfigs.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						OneFormulaConfig formulaCfg = enumerator.Current;
						double existStartTime = (double)MathUtils.Instance.LongToNumber(formulaCfg.LimitBeginTime) * TimeUtil.Instance.Millisecond;
						double existEndTime = (double)MathUtils.Instance.LongToNumber(formulaCfg.LimitEndTime) * TimeUtil.Instance.Millisecond;
						int num = this.CookingDataList.FindIndex((ICookingData v) => v.ItemId == formulaCfg.Id);
						if (num != -1)
						{
							this.CookingDataList[num].ExistStartTime = existStartTime;
							this.CookingDataList[num].ExistEndTime = existEndTime;
						}
					}
				}
			}
		}

		// Token: 0x0603AF6B RID: 241515 RVA: 0x00E0FF44 File Offset: 0x00E0E144
		public void UnlockCookMenuData(int formulaId)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(formulaId);
			int num = 0;
			while (num < this.CookingDataList.Count && (this.CookingDataList[num].SubType != ESubCookDataType.CookMenu || this.CookingDataList[num].ItemId != cookFormulaById.FormulaItemId))
			{
				num++;
			}
			this.CookingDataList.RemoveAt(num);
		}

		// Token: 0x0603AF6C RID: 241516 RVA: 0x00E0FFB1 File Offset: 0x00E0E1B1
		public List<ICookingData> GetCookingDataList()
		{
			return this.CookingDataList;
		}

		// Token: 0x0603AF6D RID: 241517 RVA: 0x00E0FFBC File Offset: 0x00E0E1BC
		[NullableContext(2)]
		public ICookingData GetCookingDataById(int itemId)
		{
			foreach (ICookingData cookingData in this.CookingDataList)
			{
				if (itemId == cookingData.ItemId)
				{
					return cookingData;
				}
			}
			return null;
		}

		// Token: 0x0603AF6E RID: 241518 RVA: 0x00E10018 File Offset: 0x00E0E218
		public int GetCookRoleId(int itemId)
		{
			ICookingData cookingDataById = this.GetCookingDataById(itemId);
			if (cookingDataById != null && cookingDataById.LastRoleId != null)
			{
				int? lastRoleId = cookingDataById.LastRoleId;
				int num = 0;
				if (!(lastRoleId.GetValueOrDefault() == num & lastRoleId != null))
				{
					return cookingDataById.LastRoleId.Value;
				}
			}
			if (PlayerInfoModel.Instance.GetPlayerRoleId() != 0)
			{
				return PlayerInfoModel.Instance.GetPlayerRoleId();
			}
			return 1502;
		}

		// Token: 0x0603AF6F RID: 241519 RVA: 0x00E10088 File Offset: 0x00E0E288
		public void CreateMachiningDataList()
		{
			if (this.MachiningDataList == null)
			{
				this.MachiningDataList = new List<IMachiningData>();
			}
			foreach (CookProcessed cookProcessed in CookConfig.Instance.GetCookProcessed())
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(cookProcessed.FinalItemId);
				MachiningData item = new MachiningData
				{
					MainType = ECookListType.Machining,
					ItemId = cookProcessed.Id,
					IsUnLock = false,
					InteractiveList = new List<int>(),
					UnlockList = new List<int>(),
					IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CookerLevelKey, cookProcessed.Id),
					IsMachining = ((CookController.Instance.CheckCanProcessed(cookProcessed.Id) > false) ? 1 : 0),
					Quality = config.Value.QualityId
				};
				this.MachiningDataList.Add(item);
			}
			this.MachiningDataList.Sort(new Comparison<IMachiningData>(this.SortMachiningData));
		}

		// Token: 0x0603AF70 RID: 241520 RVA: 0x00E101A0 File Offset: 0x00E0E3A0
		private int SortMachiningData(IMachiningData aMachiningData, IMachiningData bMachiningData)
		{
			int num = (aMachiningData.IsUnLock > false) ? 1 : 0;
			int num2 = (bMachiningData.IsUnLock > false) ? 1 : 0;
			if (num == 1 && num == num2)
			{
				if (aMachiningData.IsMachining != bMachiningData.IsMachining)
				{
					return bMachiningData.IsMachining - aMachiningData.IsMachining;
				}
				if (aMachiningData.Quality == bMachiningData.Quality)
				{
					return aMachiningData.ItemId - bMachiningData.ItemId;
				}
				return aMachiningData.Quality - bMachiningData.Quality;
			}
			else
			{
				if (num != 0 || num != num2)
				{
					return num2 - num;
				}
				if (aMachiningData.Quality == bMachiningData.Quality)
				{
					return aMachiningData.ItemId - bMachiningData.ItemId;
				}
				return aMachiningData.Quality - bMachiningData.Quality;
			}
		}

		// Token: 0x0603AF71 RID: 241521 RVA: 0x00E10244 File Offset: 0x00E0E444
		public void UpdateMachiningDataList(IReadOnlyList<SingleProcessedFoodFormulaInfo> machiningDataList, bool isNew)
		{
			if (machiningDataList != null)
			{
				foreach (SingleProcessedFoodFormulaInfo singleProcessedFoodFormulaInfo in machiningDataList)
				{
					foreach (IMachiningData machiningData in this.MachiningDataList)
					{
						if (singleProcessedFoodFormulaInfo.Id == machiningData.ItemId)
						{
							List<int> list = new List<int>();
							List<int> list2 = new List<int>();
							CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(singleProcessedFoodFormulaInfo.Id);
							if (singleProcessedFoodFormulaInfo.LockState)
							{
								for (int i = 0; i < cookProcessedById.ConsumeItemsIdLength; i++)
								{
									list2.Add(cookProcessedById.ConsumeItemsId(i).Value.ItemId);
								}
								for (int j = 0; j < cookProcessedById.InterationIdLength; j++)
								{
									list.Add(cookProcessedById.InterationId(j));
								}
							}
							else
							{
								if (singleProcessedFoodFormulaInfo.Interations != null)
								{
									foreach (int item in singleProcessedFoodFormulaInfo.Interations)
									{
										list.Add(item);
									}
								}
								foreach (int num in list)
								{
									int num2 = -1;
									for (int k = 0; k < cookProcessedById.InterationIdLength; k++)
									{
										if (cookProcessedById.InterationId(k) == num)
										{
											num2 = k;
											break;
										}
									}
									if (num2 >= 0)
									{
										int itemId = cookProcessedById.ConsumeItemsId(num2).Value.ItemId;
										list2.Add(itemId);
									}
								}
							}
							machiningData.IsUnLock = (list.Count == cookProcessedById.InterationIdLength);
							machiningData.InteractiveList = list;
							machiningData.UnlockList = list2;
							machiningData.IsMachining = ((CookController.Instance.CheckCanProcessed(singleProcessedFoodFormulaInfo.Id) > false) ? 1 : 0);
							if (!isNew)
							{
								break;
							}
							machiningData.IsNew = isNew;
							NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.CookerLevelKey, singleProcessedFoodFormulaInfo.Id);
							if (singleProcessedFoodFormulaInfo.LockState)
							{
								GenericPromptController.Instance.ShowPromptByCode("FormulaLearned", Array.Empty<object>());
								break;
							}
							break;
						}
					}
				}
			}
			this.MachiningDataList.Sort(new Comparison<IMachiningData>(this.SortMachiningData));
		}

		// Token: 0x0603AF72 RID: 241522 RVA: 0x00E1050C File Offset: 0x00E0E70C
		public List<IMachiningData> GetMachiningDataList()
		{
			return this.MachiningDataList;
		}

		// Token: 0x0603AF73 RID: 241523 RVA: 0x00E10514 File Offset: 0x00E0E714
		[NullableContext(2)]
		public IMachiningData GetMachiningDataById(int id)
		{
			foreach (IMachiningData machiningData in this.MachiningDataList)
			{
				if (id == machiningData.ItemId)
				{
					return machiningData;
				}
			}
			return null;
		}

		// Token: 0x17008C3B RID: 35899
		// (get) Token: 0x0603AF74 RID: 241524 RVA: 0x00E10570 File Offset: 0x00E0E770
		// (set) Token: 0x0603AF75 RID: 241525 RVA: 0x00E10578 File Offset: 0x00E0E778
		public int SelectedCookerLevel
		{
			get
			{
				return this.CookerLevel;
			}
			set
			{
				this.CookerLevel = value;
			}
		}

		// Token: 0x0603AF76 RID: 241526 RVA: 0x00E10584 File Offset: 0x00E0E784
		public void CreateCookerInfo(CookingInfo cookerInfo)
		{
			this.UpdateCookerInfo(cookerInfo);
			this.CookLevelMap = new Dictionary<int, CookLevel>();
			foreach (CookLevel value in CookConfig.Instance.GetCookLevel())
			{
				this.CookLevelMap.Add(value.Id, value);
			}
		}

		// Token: 0x0603AF77 RID: 241527 RVA: 0x00E105F4 File Offset: 0x00E0E7F4
		public void UpdateCookerInfo(CookingInfo cookerInfo)
		{
			int addExp = 0;
			if (this.CookerInfo != null)
			{
				this.LastExp = this.CookerInfo.TotalProficiencys;
				addExp = cookerInfo.TotalProficiencys - this.CookerInfo.TotalProficiencys;
			}
			this.CookerInfo = new CookerInfoData
			{
				CookingLevel = cookerInfo.CookingLevel,
				TotalProficiencys = cookerInfo.TotalProficiencys,
				AddExp = addExp
			};
		}

		// Token: 0x0603AF78 RID: 241528 RVA: 0x00E10659 File Offset: 0x00E0E859
		public ICookerInfoData GetCookerInfo()
		{
			return this.CookerInfo;
		}

		// Token: 0x0603AF79 RID: 241529 RVA: 0x00E10661 File Offset: 0x00E0E861
		public void CleanAddExp()
		{
			this.CookerInfo.AddExp = 0;
		}

		// Token: 0x0603AF7A RID: 241530 RVA: 0x00E1066F File Offset: 0x00E0E86F
		public CookLevel GetCookLevelByLevel(int level)
		{
			return this.CookLevelMap[level];
		}

		// Token: 0x0603AF7B RID: 241531 RVA: 0x00E1067D File Offset: 0x00E0E87D
		public int GetCookerMaxLevel()
		{
			return this.CookLevelMap.Count;
		}

		// Token: 0x0603AF7C RID: 241532 RVA: 0x00E1068C File Offset: 0x00E0E88C
		public int GetSumExpByLevel(int level)
		{
			int cookerMaxLevel = this.GetCookerMaxLevel();
			int num = level + 1;
			if (num > cookerMaxLevel)
			{
				num = cookerMaxLevel;
			}
			return this.GetCookLevelByLevel(num).Completeness;
		}

		// Token: 0x0603AF7D RID: 241533 RVA: 0x00E106BC File Offset: 0x00E0E8BC
		public int GetDropIdByLevel(int level)
		{
			int cookerMaxLevel = this.GetCookerMaxLevel();
			int num = level + 1;
			if (num > cookerMaxLevel)
			{
				return -1;
			}
			return this.GetCookLevelByLevel(num).DropIds;
		}

		// Token: 0x0603AF7E RID: 241534 RVA: 0x00E106EC File Offset: 0x00E0E8EC
		public void CreateTmpMachiningItemList(List<ISingleItemInfo> itemInfoList)
		{
			if (this.TmpMachiningSlotItemList == null)
			{
				this.TmpMachiningSlotItemList = new List<ISingleItemInfo>();
			}
			this.TmpMachiningSlotItemList.Clear();
			if (this.TmpEmptyMachiningSlotItemList == null)
			{
				this.TmpEmptyMachiningSlotItemList = new List<ISingleItemInfo>();
			}
			this.TmpEmptyMachiningSlotItemList.Clear();
			if (this.TmpEmptyMachiningSlotSelectedNumMap == null)
			{
				this.TmpEmptyMachiningSlotSelectedNumMap = new Dictionary<int, int>();
			}
			this.TmpEmptyMachiningSlotSelectedNumMap.Clear();
			this.TmpMachiningSlotItemList.Clear();
			this.TmpEmptyMachiningSlotItemList.Clear();
			foreach (ISingleItemInfo singleItemInfo in itemInfoList)
			{
				this.TmpMachiningSlotItemList.Add(singleItemInfo);
				if (!singleItemInfo.Proto_IsUnlock)
				{
					this.TmpEmptyMachiningSlotItemList.Add(singleItemInfo);
				}
			}
		}

		// Token: 0x0603AF7F RID: 241535 RVA: 0x00E107C4 File Offset: 0x00E0E9C4
		public void UpdateTmpMachiningItemList(int index, ISingleItemInfo itemInfo)
		{
			this.TmpMachiningSlotItemList[index] = itemInfo;
		}

		// Token: 0x0603AF80 RID: 241536 RVA: 0x00E107D4 File Offset: 0x00E0E9D4
		public void SubOneTmpMachiningItemSelectNum(int index)
		{
			if (this.TmpMachiningSlotItemList[index] == null)
			{
				return;
			}
			ISingleItemInfo singleItemInfo = this.TmpMachiningSlotItemList[index];
			if (!this.TmpEmptyMachiningSlotSelectedNumMap.ContainsKey(singleItemInfo.Proto_ItemId))
			{
				return;
			}
			int num = this.TmpEmptyMachiningSlotSelectedNumMap[singleItemInfo.Proto_ItemId] - 1;
			this.TmpEmptyMachiningSlotSelectedNumMap[singleItemInfo.Proto_ItemId] = num;
			if (num > 0)
			{
				return;
			}
			this.TmpEmptyMachiningSlotSelectedNumMap.Remove(singleItemInfo.Proto_ItemId);
			singleItemInfo.Proto_IsUnlock = false;
			ISingleItemInfo singleItemInfo2 = new ISingleItemInfo
			{
				Proto_IsUnlock = false,
				Proto_ItemId = 0,
				Proto_ItemNum = 0
			};
			singleItemInfo2.Proto_IsUnlock = singleItemInfo.Proto_IsUnlock;
			singleItemInfo2.Proto_ItemId = singleItemInfo.Proto_ItemId;
			int i;
			for (i = this.TmpEmptyMachiningSlotItemList.IndexOf(singleItemInfo); i < this.TmpEmptyMachiningSlotItemList.Count - 1; i++)
			{
				ISingleItemInfo singleItemInfo3 = this.TmpEmptyMachiningSlotItemList[i + 1];
				ISingleItemInfo singleItemInfo4 = this.TmpEmptyMachiningSlotItemList[i];
				singleItemInfo4.Proto_IsUnlock = singleItemInfo3.Proto_IsUnlock;
				singleItemInfo4.Proto_ItemId = singleItemInfo3.Proto_ItemId;
			}
			this.TmpEmptyMachiningSlotItemList[i].Proto_IsUnlock = singleItemInfo2.Proto_IsUnlock;
			this.TmpEmptyMachiningSlotItemList[i].Proto_ItemId = singleItemInfo2.Proto_ItemId;
		}

		// Token: 0x0603AF81 RID: 241537 RVA: 0x00E1090E File Offset: 0x00E0EB0E
		public void ClearTmpMachiningItemList()
		{
			this.TmpMachiningSlotItemList.Clear();
			this.TmpEmptyMachiningSlotItemList.Clear();
			this.TmpEmptyMachiningSlotSelectedNumMap.Clear();
		}

		// Token: 0x0603AF82 RID: 241538 RVA: 0x00E10934 File Offset: 0x00E0EB34
		public void SetEmptyBySelectedItem(int index, bool isUnlock, int? selectedItemId = null, int? selectedCount = null)
		{
			ISingleItemInfo singleItemInfo = this.TmpEmptyMachiningSlotItemList[index];
			if (singleItemInfo == null)
			{
				return;
			}
			if (selectedItemId != null)
			{
				singleItemInfo.Proto_ItemId = selectedItemId.Value;
				if (selectedCount != null)
				{
					this.TmpEmptyMachiningSlotSelectedNumMap[selectedItemId.Value] = selectedCount.Value;
				}
			}
			singleItemInfo.Proto_IsUnlock = isUnlock;
		}

		// Token: 0x0603AF83 RID: 241539 RVA: 0x00E10994 File Offset: 0x00E0EB94
		[NullableContext(0)]
		public ValueTuple<bool, int> IsSelectNumFromEmpty(int itemId)
		{
			bool item = false;
			int item2 = 0;
			if (this.TmpEmptyMachiningSlotSelectedNumMap.ContainsKey(itemId))
			{
				item = true;
				item2 = this.TmpEmptyMachiningSlotSelectedNumMap[itemId];
			}
			return new ValueTuple<bool, int>(item, item2);
		}

		// Token: 0x0603AF84 RID: 241540 RVA: 0x00E109CC File Offset: 0x00E0EBCC
		public bool CheckCanProcessedNew(int itemId)
		{
			if (this.TmpEmptyMachiningSlotSelectedNumMap.Count == 0)
			{
				return CookController.Instance.CheckCanProcessed(itemId);
			}
			bool result = true;
			foreach (ISingleItemInfo singleItemInfo in this.TmpMachiningSlotItemList)
			{
				if (this.TmpEmptyMachiningSlotSelectedNumMap.ContainsKey(singleItemInfo.Proto_ItemId))
				{
					int num = this.TmpEmptyMachiningSlotSelectedNumMap[singleItemInfo.Proto_ItemId];
					if (singleItemInfo.Proto_ItemNum > num)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0603AF85 RID: 241541 RVA: 0x00E10A68 File Offset: 0x00E0EC68
		public List<ISingleItemInfo> GetTmpMachiningItemList()
		{
			return this.TmpMachiningSlotItemList;
		}

		// Token: 0x0603AF86 RID: 241542 RVA: 0x00E10A70 File Offset: 0x00E0EC70
		public int GetEmptyMachiningItemListNum()
		{
			return this.TmpEmptyMachiningSlotItemList.Count;
		}

		// Token: 0x17008C3C RID: 35900
		// (get) Token: 0x0603AF87 RID: 241543 RVA: 0x00E10A7D File Offset: 0x00E0EC7D
		// (set) Token: 0x0603AF88 RID: 241544 RVA: 0x00E10A85 File Offset: 0x00E0EC85
		public int? CurrentCookRoleId
		{
			get
			{
				return this.CookRoleId;
			}
			set
			{
				this.CookRoleId = value;
			}
		}

		// Token: 0x0603AF89 RID: 241545 RVA: 0x00E10A90 File Offset: 0x00E0EC90
		public void UpdateCookRoleItemDataList()
		{
			if (this.CookRoleItemDataList == null)
			{
				this.CookRoleItemDataList = new List<ICookRoleItemData>();
			}
			this.CookRoleItemDataList.Clear();
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				this.CookRoleItemDataList.Add(new CookRoleItemData
				{
					RoleId = roleInstance.GetRoleId(),
					RoleName = roleInstance.GetRoleRealName(),
					RoleIcon = roleInstance.GetRoleConfig().RoleHeadIcon,
					IsBuff = false,
					ItemId = 0
				});
			}
		}

		// Token: 0x0603AF8A RID: 241546 RVA: 0x00E10B22 File Offset: 0x00E0ED22
		public void ClearCookRoleItemDataList()
		{
			this.CookRoleItemDataList = null;
		}

		// Token: 0x0603AF8B RID: 241547 RVA: 0x00E10B2C File Offset: 0x00E0ED2C
		public List<ICookRoleItemData> GetCookRoleItemDataList(int itemId)
		{
			if (this.CookRoleItemDataList == null)
			{
				this.UpdateCookRoleItemDataList();
			}
			foreach (ICookRoleItemData cookRoleItemData in this.CookRoleItemDataList)
			{
				cookRoleItemData.ItemId = itemId;
				cookRoleItemData.IsBuff = CookController.Instance.CheckIsBuff(cookRoleItemData.RoleId, itemId);
			}
			this.CookRoleItemDataList.Sort(new Comparison<ICookRoleItemData>(this.SortCookRoleItemDataList));
			return this.CookRoleItemDataList;
		}

		// Token: 0x0603AF8C RID: 241548 RVA: 0x00E10BC4 File Offset: 0x00E0EDC4
		private int SortCookRoleItemDataList(ICookRoleItemData dataA, ICookRoleItemData dataB)
		{
			if (dataA.IsBuff == dataB.IsBuff)
			{
				return dataA.RoleId - dataB.RoleId;
			}
			if (dataA.IsBuff)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x0603AF8D RID: 241549 RVA: 0x00E10BF0 File Offset: 0x00E0EDF0
		public List<ISingleItemInfo> GetCookMaterialList(int itemId, ECookListType type)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			if (type == ECookListType.Cooking)
			{
				CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(itemId);
				for (int i = 0; i < cookFormulaById.ConsumeItemsLength; i++)
				{
					OneItemConfig value = cookFormulaById.ConsumeItems(i).Value;
					list.Add(new ISingleItemInfo
					{
						Proto_ItemId = value.ItemId,
						Proto_ItemNum = value.Count,
						Proto_IsUnlock = true
					});
				}
			}
			else
			{
				IMachiningData machiningDataById = this.GetMachiningDataById(itemId);
				CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(itemId);
				for (int j = 0; j < cookProcessedById.ConsumeItemsIdLength; j++)
				{
					OneItemConfig value2 = cookProcessedById.ConsumeItemsId(j).Value;
					list.Add(new ISingleItemInfo
					{
						Proto_ItemId = value2.ItemId,
						Proto_ItemNum = value2.Count,
						Proto_IsUnlock = machiningDataById.UnlockList.Contains(value2.ItemId)
					});
				}
			}
			return list;
		}

		// Token: 0x0603AF8E RID: 241550 RVA: 0x00E10CE4 File Offset: 0x00E0EEE4
		public List<ISingleItemInfo> GetMachiningMaterialStudyList(int itemId)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			IMachiningData machiningDataById = this.GetMachiningDataById(itemId);
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(itemId);
			for (int i = 0; i < cookProcessedById.ConsumeItemsIdLength; i++)
			{
				OneItemConfig value = cookProcessedById.ConsumeItemsId(i).Value;
				bool flag = machiningDataById.UnlockList.Contains(value.ItemId);
				list.Add(new ISingleItemInfo
				{
					Proto_ItemId = (flag ? value.ItemId : 0),
					Proto_ItemNum = value.Count,
					Proto_IsUnlock = flag
				});
			}
			return list;
		}

		// Token: 0x0603AF8F RID: 241551 RVA: 0x00E10D7C File Offset: 0x00E0EF7C
		[NullableContext(2)]
		public string GetRefreshLimitTime()
		{
			if (this.LimitRefreshTime == 0.0)
			{
				return null;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).CountDownText;
		}

		// Token: 0x0603AF90 RID: 241552 RVA: 0x00E10DC0 File Offset: 0x00E0EFC0
		public double GetRefreshLimitTimeValue()
		{
			if (this.LimitRefreshTime <= 0.0)
			{
				return 1.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).RemainingTime;
		}

		// Token: 0x17008C3D RID: 35901
		// (get) Token: 0x0603AF91 RID: 241553 RVA: 0x00E10E0A File Offset: 0x00E0F00A
		// (set) Token: 0x0603AF92 RID: 241554 RVA: 0x00E10E12 File Offset: 0x00E0F012
		public int CurrentFixId
		{
			get
			{
				return this.FixId;
			}
			set
			{
				this.FixId = value;
			}
		}

		// Token: 0x17008C3E RID: 35902
		// (get) Token: 0x0603AF93 RID: 241555 RVA: 0x00E10E1B File Offset: 0x00E0F01B
		// (set) Token: 0x0603AF94 RID: 241556 RVA: 0x00E10E23 File Offset: 0x00E0F023
		public long? CurrentEntityId
		{
			get
			{
				return this.EntityId;
			}
			set
			{
				this.EntityId = value;
			}
		}

		// Token: 0x0603AF95 RID: 241557 RVA: 0x00E10E2C File Offset: 0x00E0F02C
		public void UpdateCookItemList(IReadOnlyList<SingleItemInfo> itemList)
		{
			if (this.CookItemList == null)
			{
				this.CookItemList = new List<ICookPopItem>();
			}
			this.CookItemList.Clear();
			if (itemList != null)
			{
				foreach (SingleItemInfo singleItemInfo in itemList)
				{
					this.CookItemList.Add(new CookPopItem
					{
						ItemId = singleItemInfo.ItemId,
						ItemNum = singleItemInfo.ItemNum
					});
				}
			}
		}

		// Token: 0x0603AF96 RID: 241558 RVA: 0x00E10EB8 File Offset: 0x00E0F0B8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICookPopItem> GetCookItemList()
		{
			return this.CookItemList;
		}

		// Token: 0x17008C3F RID: 35903
		// (get) Token: 0x0603AF97 RID: 241559 RVA: 0x00E10EC0 File Offset: 0x00E0F0C0
		public static CookModel Instance
		{
			get
			{
				return CookModel._Instance;
			}
		}

		// Token: 0x0603AF98 RID: 241560 RVA: 0x00E10EC7 File Offset: 0x00E0F0C7
		public static CookModel GetOrCreateInstance()
		{
			if (CookModel._Instance == null)
			{
				CookModel.CreateInstance();
			}
			return CookModel._Instance;
		}

		// Token: 0x0603AF99 RID: 241561 RVA: 0x00E10EDB File Offset: 0x00E0F0DB
		public static bool CreateInstance()
		{
			if (CookModel._Instance != null)
			{
				return true;
			}
			CookModel._Instance = new CookModel();
			return true;
		}

		// Token: 0x0603AF9A RID: 241562 RVA: 0x00E10EF1 File Offset: 0x00E0F0F1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AF9B RID: 241563 RVA: 0x00E10EF3 File Offset: 0x00E0F0F3
		public static void ResetStaticDefaultValue()
		{
			CookModel._Instance = null;
		}

		// Token: 0x0603AF9C RID: 241564 RVA: 0x00E10EFB File Offset: 0x00E0F0FB
		static CookModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookModel.CreateStaticDefaultValue), new Action(CookModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC64 RID: 126052
		private double LimitRefreshTime;

		// Token: 0x0401EC65 RID: 126053
		public int LastExp;

		// Token: 0x0401EC66 RID: 126054
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x0401EC67 RID: 126055
		private ECookDataType CookViewType;

		// Token: 0x0401EC68 RID: 126056
		private ECookListType CookListType;

		// Token: 0x0401EC69 RID: 126057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookingData> CookingDataList;

		// Token: 0x0401EC6A RID: 126058
		private readonly Dictionary<int, ECookDataTimeState> TimeoutCookingDataMap;

		// Token: 0x0401EC6B RID: 126059
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMachiningData> MachiningDataList;

		// Token: 0x0401EC6C RID: 126060
		private int CookerLevel;

		// Token: 0x0401EC6D RID: 126061
		[Nullable(2)]
		private Dictionary<int, CookLevel> CookLevelMap;

		// Token: 0x0401EC6E RID: 126062
		[Nullable(2)]
		private ICookerInfoData CookerInfo;

		// Token: 0x0401EC6F RID: 126063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISingleItemInfo> TmpMachiningSlotItemList;

		// Token: 0x0401EC70 RID: 126064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISingleItemInfo> TmpEmptyMachiningSlotItemList;

		// Token: 0x0401EC71 RID: 126065
		[Nullable(2)]
		private Dictionary<int, int> TmpEmptyMachiningSlotSelectedNumMap;

		// Token: 0x0401EC72 RID: 126066
		private int? CookRoleId;

		// Token: 0x0401EC73 RID: 126067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookRoleItemData> CookRoleItemDataList;

		// Token: 0x0401EC74 RID: 126068
		private int FixId;

		// Token: 0x0401EC75 RID: 126069
		private long? EntityId;

		// Token: 0x0401EC76 RID: 126070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookPopItem> CookItemList;

		// Token: 0x0401EC77 RID: 126071
		[Nullable(2)]
		private static CookModel _Instance;
	}
}
