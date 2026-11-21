using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.Module.Manufacture.Common;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004ADD RID: 19165
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CookModel : ModelBase
	{
		// Token: 0x0602FECD RID: 196301 RVA: 0x00D60287 File Offset: 0x00D5E487
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602FECE RID: 196302 RVA: 0x00D6028A File Offset: 0x00D5E48A
		protected override bool OnClear()
		{
			this.ClearCookRoleItemDataList();
			return true;
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x0602FECF RID: 196303 RVA: 0x00D60293 File Offset: 0x00D5E493
		// (set) Token: 0x0602FED0 RID: 196304 RVA: 0x00D6029B File Offset: 0x00D5E49B
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

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x0602FED1 RID: 196305 RVA: 0x00D602A4 File Offset: 0x00D5E4A4
		// (set) Token: 0x0602FED2 RID: 196306 RVA: 0x00D602AC File Offset: 0x00D5E4AC
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

		// Token: 0x0602FED3 RID: 196307 RVA: 0x00D602B5 File Offset: 0x00D5E4B5
		public CookModel()
		{
			this.LimitRefreshTime = -1.0;
			this.LastExp = 0;
			this.CookViewType = ECookDataType.CookMain;
			this.CookListType = ECookListType.Cooking;
			this.TimeoutCookingDataMap = new Dictionary<int, ECookDataTimeState>();
		}

		// Token: 0x0602FED4 RID: 196308 RVA: 0x00D602EC File Offset: 0x00D5E4EC
		public void SaveLimitRefreshTime(long refreshTime)
		{
			this.LimitRefreshTime = (double)MathUtils.Instance.LongToNumber(refreshTime) * TimeUtil.Instance.Millisecond;
		}

		// Token: 0x0602FED5 RID: 196309 RVA: 0x00D6030B File Offset: 0x00D5E50B
		public bool CheckCanCook(int itemId)
		{
			return this.CheckLimitCount(itemId) && this.CheckCoinEnough(itemId) && this.CheckMaterialEnough(itemId);
		}

		// Token: 0x0602FED6 RID: 196310 RVA: 0x00D60328 File Offset: 0x00D5E528
		public bool CheckLimitCount(int itemId)
		{
			ICookingData cookingDataById = this.GetCookingDataById(itemId);
			return cookingDataById.LimitTotalCount <= 0 || cookingDataById.CookCount < cookingDataById.LimitTotalCount;
		}

		// Token: 0x0602FED7 RID: 196311 RVA: 0x00D60358 File Offset: 0x00D5E558
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

		// Token: 0x0602FED8 RID: 196312 RVA: 0x00D603B4 File Offset: 0x00D5E5B4
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

		// Token: 0x0602FED9 RID: 196313 RVA: 0x00D60414 File Offset: 0x00D5E614
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

		// Token: 0x0602FEDA RID: 196314 RVA: 0x00D605D0 File Offset: 0x00D5E7D0
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

		// Token: 0x0602FEDB RID: 196315 RVA: 0x00D609B4 File Offset: 0x00D5EBB4
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

		// Token: 0x0602FEDC RID: 196316 RVA: 0x00D60B58 File Offset: 0x00D5ED58
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

		// Token: 0x0602FEDD RID: 196317 RVA: 0x00D60C38 File Offset: 0x00D5EE38
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

		// Token: 0x0602FEDE RID: 196318 RVA: 0x00D60CA5 File Offset: 0x00D5EEA5
		public List<ICookingData> GetCookingDataList()
		{
			return this.CookingDataList.FindAll((ICookingData data) => !LinkedItemConfig.Instance.ShouldHide(data.ItemId, data.IsUnLock));
		}

		// Token: 0x0602FEDF RID: 196319 RVA: 0x00D60CD4 File Offset: 0x00D5EED4
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

		// Token: 0x0602FEE0 RID: 196320 RVA: 0x00D60D30 File Offset: 0x00D5EF30
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

		// Token: 0x0602FEE1 RID: 196321 RVA: 0x00D60DA0 File Offset: 0x00D5EFA0
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

		// Token: 0x0602FEE2 RID: 196322 RVA: 0x00D60EB8 File Offset: 0x00D5F0B8
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

		// Token: 0x0602FEE3 RID: 196323 RVA: 0x00D60F5C File Offset: 0x00D5F15C
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

		// Token: 0x0602FEE4 RID: 196324 RVA: 0x00D61224 File Offset: 0x00D5F424
		public List<IMachiningData> GetMachiningDataList()
		{
			return this.MachiningDataList;
		}

		// Token: 0x0602FEE5 RID: 196325 RVA: 0x00D6122C File Offset: 0x00D5F42C
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

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x0602FEE6 RID: 196326 RVA: 0x00D61288 File Offset: 0x00D5F488
		// (set) Token: 0x0602FEE7 RID: 196327 RVA: 0x00D61290 File Offset: 0x00D5F490
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

		// Token: 0x0602FEE8 RID: 196328 RVA: 0x00D6129C File Offset: 0x00D5F49C
		public void CreateCookerInfo(CookingInfo cookerInfo)
		{
			this.UpdateCookerInfo(cookerInfo);
			this.CookLevelMap = new Dictionary<int, CookLevel>();
			foreach (CookLevel value in CookConfig.Instance.GetCookLevel())
			{
				this.CookLevelMap.Add(value.Id, value);
			}
		}

		// Token: 0x0602FEE9 RID: 196329 RVA: 0x00D6130C File Offset: 0x00D5F50C
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

		// Token: 0x0602FEEA RID: 196330 RVA: 0x00D61371 File Offset: 0x00D5F571
		public ICookerInfoData GetCookerInfo()
		{
			return this.CookerInfo;
		}

		// Token: 0x0602FEEB RID: 196331 RVA: 0x00D61379 File Offset: 0x00D5F579
		public void CleanAddExp()
		{
			this.CookerInfo.AddExp = 0;
		}

		// Token: 0x0602FEEC RID: 196332 RVA: 0x00D61387 File Offset: 0x00D5F587
		public CookLevel GetCookLevelByLevel(int level)
		{
			return this.CookLevelMap[level];
		}

		// Token: 0x0602FEED RID: 196333 RVA: 0x00D61395 File Offset: 0x00D5F595
		public int GetCookerMaxLevel()
		{
			return this.CookLevelMap.Count;
		}

		// Token: 0x0602FEEE RID: 196334 RVA: 0x00D613A4 File Offset: 0x00D5F5A4
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

		// Token: 0x0602FEEF RID: 196335 RVA: 0x00D613D4 File Offset: 0x00D5F5D4
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

		// Token: 0x0602FEF0 RID: 196336 RVA: 0x00D61404 File Offset: 0x00D5F604
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

		// Token: 0x0602FEF1 RID: 196337 RVA: 0x00D614DC File Offset: 0x00D5F6DC
		public void UpdateTmpMachiningItemList(int index, ISingleItemInfo itemInfo)
		{
			this.TmpMachiningSlotItemList[index] = itemInfo;
		}

		// Token: 0x0602FEF2 RID: 196338 RVA: 0x00D614EC File Offset: 0x00D5F6EC
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

		// Token: 0x0602FEF3 RID: 196339 RVA: 0x00D61626 File Offset: 0x00D5F826
		public void ClearTmpMachiningItemList()
		{
			this.TmpMachiningSlotItemList.Clear();
			this.TmpEmptyMachiningSlotItemList.Clear();
			this.TmpEmptyMachiningSlotSelectedNumMap.Clear();
		}

		// Token: 0x0602FEF4 RID: 196340 RVA: 0x00D6164C File Offset: 0x00D5F84C
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

		// Token: 0x0602FEF5 RID: 196341 RVA: 0x00D616AC File Offset: 0x00D5F8AC
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

		// Token: 0x0602FEF6 RID: 196342 RVA: 0x00D616E4 File Offset: 0x00D5F8E4
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

		// Token: 0x0602FEF7 RID: 196343 RVA: 0x00D61780 File Offset: 0x00D5F980
		public List<ISingleItemInfo> GetTmpMachiningItemList()
		{
			return this.TmpMachiningSlotItemList;
		}

		// Token: 0x0602FEF8 RID: 196344 RVA: 0x00D61788 File Offset: 0x00D5F988
		public int GetEmptyMachiningItemListNum()
		{
			return this.TmpEmptyMachiningSlotItemList.Count;
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x0602FEF9 RID: 196345 RVA: 0x00D61795 File Offset: 0x00D5F995
		// (set) Token: 0x0602FEFA RID: 196346 RVA: 0x00D6179D File Offset: 0x00D5F99D
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

		// Token: 0x0602FEFB RID: 196347 RVA: 0x00D617A8 File Offset: 0x00D5F9A8
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

		// Token: 0x0602FEFC RID: 196348 RVA: 0x00D6183A File Offset: 0x00D5FA3A
		public void ClearCookRoleItemDataList()
		{
			this.CookRoleItemDataList = null;
		}

		// Token: 0x0602FEFD RID: 196349 RVA: 0x00D61844 File Offset: 0x00D5FA44
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

		// Token: 0x0602FEFE RID: 196350 RVA: 0x00D618DC File Offset: 0x00D5FADC
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

		// Token: 0x0602FEFF RID: 196351 RVA: 0x00D61908 File Offset: 0x00D5FB08
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

		// Token: 0x0602FF00 RID: 196352 RVA: 0x00D619FC File Offset: 0x00D5FBFC
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

		// Token: 0x0602FF01 RID: 196353 RVA: 0x00D61A94 File Offset: 0x00D5FC94
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

		// Token: 0x0602FF02 RID: 196354 RVA: 0x00D61AD8 File Offset: 0x00D5FCD8
		public double GetRefreshLimitTimeValue()
		{
			if (this.LimitRefreshTime <= 0.0)
			{
				return 1.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).RemainingTime;
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x0602FF03 RID: 196355 RVA: 0x00D61B22 File Offset: 0x00D5FD22
		// (set) Token: 0x0602FF04 RID: 196356 RVA: 0x00D61B2A File Offset: 0x00D5FD2A
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

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x0602FF05 RID: 196357 RVA: 0x00D61B33 File Offset: 0x00D5FD33
		// (set) Token: 0x0602FF06 RID: 196358 RVA: 0x00D61B3B File Offset: 0x00D5FD3B
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

		// Token: 0x0602FF07 RID: 196359 RVA: 0x00D61B44 File Offset: 0x00D5FD44
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

		// Token: 0x0602FF08 RID: 196360 RVA: 0x00D61BD0 File Offset: 0x00D5FDD0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICookPopItem> GetCookItemList()
		{
			return this.CookItemList;
		}

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x0602FF09 RID: 196361 RVA: 0x00D61BD8 File Offset: 0x00D5FDD8
		public static CookModel Instance
		{
			get
			{
				return CookModel._Instance;
			}
		}

		// Token: 0x0602FF0A RID: 196362 RVA: 0x00D61BDF File Offset: 0x00D5FDDF
		public static CookModel GetOrCreateInstance()
		{
			if (CookModel._Instance == null)
			{
				CookModel.CreateInstance();
			}
			return CookModel._Instance;
		}

		// Token: 0x0602FF0B RID: 196363 RVA: 0x00D61BF3 File Offset: 0x00D5FDF3
		public static bool CreateInstance()
		{
			if (CookModel._Instance != null)
			{
				return true;
			}
			CookModel._Instance = new CookModel();
			return true;
		}

		// Token: 0x0602FF0C RID: 196364 RVA: 0x00D61C09 File Offset: 0x00D5FE09
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FF0D RID: 196365 RVA: 0x00D61C0B File Offset: 0x00D5FE0B
		public static void ResetStaticDefaultValue()
		{
			CookModel._Instance = null;
		}

		// Token: 0x0602FF0E RID: 196366 RVA: 0x00D61C13 File Offset: 0x00D5FE13
		static CookModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookModel.CreateStaticDefaultValue), new Action(CookModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019720 RID: 104224
		private double LimitRefreshTime;

		// Token: 0x04019721 RID: 104225
		public int LastExp;

		// Token: 0x04019722 RID: 104226
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x04019723 RID: 104227
		private ECookDataType CookViewType;

		// Token: 0x04019724 RID: 104228
		private ECookListType CookListType;

		// Token: 0x04019725 RID: 104229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookingData> CookingDataList;

		// Token: 0x04019726 RID: 104230
		private readonly Dictionary<int, ECookDataTimeState> TimeoutCookingDataMap;

		// Token: 0x04019727 RID: 104231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMachiningData> MachiningDataList;

		// Token: 0x04019728 RID: 104232
		private int CookerLevel;

		// Token: 0x04019729 RID: 104233
		[Nullable(2)]
		private Dictionary<int, CookLevel> CookLevelMap;

		// Token: 0x0401972A RID: 104234
		[Nullable(2)]
		private ICookerInfoData CookerInfo;

		// Token: 0x0401972B RID: 104235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISingleItemInfo> TmpMachiningSlotItemList;

		// Token: 0x0401972C RID: 104236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISingleItemInfo> TmpEmptyMachiningSlotItemList;

		// Token: 0x0401972D RID: 104237
		[Nullable(2)]
		private Dictionary<int, int> TmpEmptyMachiningSlotSelectedNumMap;

		// Token: 0x0401972E RID: 104238
		private int? CookRoleId;

		// Token: 0x0401972F RID: 104239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookRoleItemData> CookRoleItemDataList;

		// Token: 0x04019730 RID: 104240
		private int FixId;

		// Token: 0x04019731 RID: 104241
		private long? EntityId;

		// Token: 0x04019732 RID: 104242
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookPopItem> CookItemList;

		// Token: 0x04019733 RID: 104243
		[Nullable(2)]
		private static CookModel _Instance;
	}
}
