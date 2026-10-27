using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200565D RID: 22109
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeModel : ModelBase
	{
		// Token: 0x0603838C RID: 230284 RVA: 0x00D52CBA File Offset: 0x00D50EBA
		public void SaveLimitRefreshTime(long refreshTime)
		{
			this.LimitRefreshTime = (double)refreshTime * TimeUtil.Instance.Millisecond;
		}

		// Token: 0x0603838D RID: 230285 RVA: 0x00D52CD0 File Offset: 0x00D50ED0
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

		// Token: 0x0603838E RID: 230286 RVA: 0x00D52D14 File Offset: 0x00D50F14
		public double GetRefreshLimitTimeValue()
		{
			if (this.LimitRefreshTime <= 0.0)
			{
				return 1.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).RemainingTime;
		}

		// Token: 0x0603838F RID: 230287 RVA: 0x00D52D60 File Offset: 0x00D50F60
		protected override bool OnInit()
		{
			this.ComposeEnterFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ComposeEnterStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ComposeEnterFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ComposeEnterFlowId").Value
			};
			this.ComposeSuccessFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ComposeSuccessStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ComposeSuccessFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ComposeSuccessFlowId").Value
			};
			this.ComposeFailFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ComposeFailStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ComposeFailFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ComposeFailFlowId").Value
			};
			return true;
		}

		// Token: 0x06038390 RID: 230288 RVA: 0x00D52E4F File Offset: 0x00D5104F
		protected override bool OnClear()
		{
			this.ComposeEnterFlow = null;
			this.ComposeSuccessFlow = null;
			this.ComposeFailFlow = null;
			this.ClearComposeRoleItemDataList();
			return true;
		}

		// Token: 0x17008744 RID: 34628
		// (get) Token: 0x06038391 RID: 230289 RVA: 0x00D52E6D File Offset: 0x00D5106D
		// (set) Token: 0x06038392 RID: 230290 RVA: 0x00D52E75 File Offset: 0x00D51075
		public EComposeViewType CurrentComposeViewType
		{
			get
			{
				return this.ComposeViewType;
			}
			set
			{
				this.ComposeViewType = value;
			}
		}

		// Token: 0x17008745 RID: 34629
		// (get) Token: 0x06038393 RID: 230291 RVA: 0x00D52E7E File Offset: 0x00D5107E
		// (set) Token: 0x06038394 RID: 230292 RVA: 0x00D52E86 File Offset: 0x00D51086
		public EComposeListType CurrentComposeListType
		{
			get
			{
				return this.ComposeListType;
			}
			set
			{
				this.ComposeListType = value;
			}
		}

		// Token: 0x06038395 RID: 230293 RVA: 0x00D52E8F File Offset: 0x00D5108F
		public bool IsInPurificationList()
		{
			return ComposeDefine.IsPurificationLikeType(this.ComposeListType);
		}

		// Token: 0x06038396 RID: 230294 RVA: 0x00D52E9C File Offset: 0x00D5109C
		public void CreateComposeDataList(IList<OneSynthesisInfo> composeDataList)
		{
			this.CreateReagentProductionDataList(composeDataList);
			this.CreateStructureDataList(composeDataList);
			this.UpdatePurificationDataList(composeDataList);
			this.UpdateCollectDataList(composeDataList);
			this.CreateExchangeDataList();
		}

		// Token: 0x06038397 RID: 230295 RVA: 0x00D52EC0 File Offset: 0x00D510C0
		public void UpdateComposeDataList(IList<OneSynthesisInfo> composeDataList)
		{
			this.UpdateReagentProductionDataList(composeDataList);
			this.UpdateStructureDataList(composeDataList);
			this.UpdatePurificationDataList(composeDataList);
			this.UpdateCollectDataList(composeDataList);
		}

		// Token: 0x06038398 RID: 230296 RVA: 0x00D52EE0 File Offset: 0x00D510E0
		public void UpdateComposeByServerConfig(IList<OneSynthesisConfig> synthesisConfigs)
		{
			using (IEnumerator<OneSynthesisConfig> enumerator = synthesisConfigs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					OneSynthesisConfig synthesisCfg = enumerator.Current;
					double num = (double)MathUtils.Instance.LongToNumber(synthesisCfg.LimitBeginTime) * TimeUtil.Instance.Millisecond;
					double num2 = (double)MathUtils.Instance.LongToNumber(synthesisCfg.LimitEndTime) * TimeUtil.Instance.Millisecond;
					int num3 = this.ReagentProductionDataList.FindIndex((IReagentProductionData v) => v.ConfigId == synthesisCfg.Id);
					if (num3 != -1)
					{
						if ((num == 0.0 && num2 == 0.0) || TimeUtil.Instance.IsInTimeSpan(num, num2))
						{
							this.ReagentProductionDataList[num3].ExistStartTime = num;
							this.ReagentProductionDataList[num3].ExistEndTime = num2;
						}
						else
						{
							this.ReagentProductionDataList.RemoveAt(num3);
						}
					}
				}
			}
		}

		// Token: 0x06038399 RID: 230297 RVA: 0x00D52FF0 File Offset: 0x00D511F0
		public void HideComposeDataList(IList<int> hideIdList)
		{
			this.HideStructureDataList(hideIdList);
		}

		// Token: 0x0603839A RID: 230298 RVA: 0x00D52FFC File Offset: 0x00D511FC
		public void CreateReagentProductionDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.ReagentProductionDataList == null)
			{
				this.ReagentProductionDataList = new List<IReagentProductionData>();
			}
			this.ReagentProductionDataList.Clear();
			IEnumerable<SynthesisFormula> enumerable = ComposeConfig.Instance.GetComposeListByType(1) ?? Array.Empty<SynthesisFormula>();
			Dictionary<int, IReagentProductionData> dictionary = new Dictionary<int, IReagentProductionData>();
			foreach (SynthesisFormula synthesisFormula in enumerable)
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(synthesisFormula.ItemId);
				IReagentProductionData reagentProductionData = new IReagentProductionData
				{
					MainType = EComposeListType.ReagentProduction,
					SubType = ESubComposeDataType.Compose,
					UniqueId = 0,
					ConfigId = synthesisFormula.Id,
					ComposeCount = 0,
					IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, synthesisFormula.Id),
					LastRoleId = 0,
					Quality = config.Value.QualityId,
					EffectType = synthesisFormula.TypeId,
					ExistStartTime = 0.0,
					ExistEndTime = 0.0,
					MadeCountInLimitTime = 0,
					TotalMakeCountInLimitTime = synthesisFormula.LimitCount,
					IsUnlock = 0,
					GroupId = 0,
					IsLimitForever = synthesisFormula.PermanentLimit,
					SortId = synthesisFormula.SortId
				};
				this.ReagentProductionDataList.Add(reagentProductionData);
				dictionary[synthesisFormula.Id] = reagentProductionData;
			}
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				IReagentProductionData reagentProductionData2;
				if (ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id).Value.FormulaType == 1 && dictionary.TryGetValue(oneSynthesisInfo.Id, out reagentProductionData2))
				{
					reagentProductionData2.ConfigId = oneSynthesisInfo.Id;
					reagentProductionData2.ComposeCount = oneSynthesisInfo.Count;
					reagentProductionData2.IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, oneSynthesisInfo.Id);
					reagentProductionData2.LastRoleId = oneSynthesisInfo.LastRoleId;
					reagentProductionData2.ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
					reagentProductionData2.ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
					reagentProductionData2.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
					reagentProductionData2.TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount;
					reagentProductionData2.IsUnlock = 1;
				}
			}
		}

		// Token: 0x0603839B RID: 230299 RVA: 0x00D532B8 File Offset: 0x00D514B8
		public void UpdateReagentProductionDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.ReagentProductionDataList.Count <= 0)
			{
				return;
			}
			bool flag = false;
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				if (ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id).Value.FormulaType == 1)
				{
					bool flag2 = false;
					foreach (IReagentProductionData reagentProductionData in this.ReagentProductionDataList)
					{
						if (oneSynthesisInfo.Id == reagentProductionData.ConfigId)
						{
							bool flag3 = reagentProductionData.IsUnlock == 1;
							reagentProductionData.ComposeCount = oneSynthesisInfo.Count;
							reagentProductionData.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
							reagentProductionData.IsUnlock = 1;
							flag2 = true;
							if (!flag3)
							{
								flag = true;
								break;
							}
							break;
						}
					}
					if (!flag2)
					{
						SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id);
						ItemInfo? config = ItemConfig.Instance.GetConfig(synthesisFormulaById.Value.ItemId);
						IReagentProductionData item = new IReagentProductionData
						{
							MainType = EComposeListType.ReagentProduction,
							SubType = ESubComposeDataType.Compose,
							UniqueId = 0,
							ConfigId = oneSynthesisInfo.Id,
							ComposeCount = oneSynthesisInfo.Count,
							IsNew = true,
							LastRoleId = oneSynthesisInfo.LastRoleId,
							Quality = config.Value.QualityId,
							EffectType = synthesisFormulaById.Value.TypeId,
							ExistStartTime = (double)oneSynthesisInfo.LimitBeginTime * TimeUtil.Instance.Millisecond,
							ExistEndTime = (double)oneSynthesisInfo.LimitEndTime * TimeUtil.Instance.Millisecond,
							MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount,
							TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount,
							IsUnlock = 1,
							GroupId = 0,
							IsLimitForever = synthesisFormulaById.Value.PermanentLimit,
							SortId = synthesisFormulaById.Value.SortId
						};
						flag = true;
						NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, oneSynthesisInfo.Id);
						this.ReagentProductionDataList.Add(item);
					}
				}
			}
			if (flag)
			{
				GenericPromptController.Instance.ShowPromptByCode("FormulaLearned", Array.Empty<object>());
			}
		}

		// Token: 0x0603839C RID: 230300 RVA: 0x00D53538 File Offset: 0x00D51738
		public void UnlockReagentProductionData(int id)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(id);
			if (synthesisFormulaById.Value.FormulaType != 1)
			{
				return;
			}
			int num = 0;
			while (num < this.ReagentProductionDataList.Count && (this.ReagentProductionDataList[num].SubType != ESubComposeDataType.ComposeMenu || this.ReagentProductionDataList[num].ConfigId != synthesisFormulaById.Value.FormulaItemId))
			{
				num++;
			}
			this.ReagentProductionDataList.RemoveAt(num);
		}

		// Token: 0x0603839D RID: 230301 RVA: 0x00D535BD File Offset: 0x00D517BD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IReagentProductionData> GetReagentProductionDataList()
		{
			return this.ReagentProductionDataList;
		}

		// Token: 0x0603839E RID: 230302 RVA: 0x00D535C8 File Offset: 0x00D517C8
		[NullableContext(2)]
		public IReagentProductionData GetReagentProductionDataById(int itemId)
		{
			foreach (IReagentProductionData reagentProductionData in this.ReagentProductionDataList)
			{
				if (itemId == reagentProductionData.ConfigId)
				{
					return reagentProductionData;
				}
			}
			return null;
		}

		// Token: 0x0603839F RID: 230303 RVA: 0x00D53624 File Offset: 0x00D51824
		public int GetReagentProductionRoleId(int itemId)
		{
			IReagentProductionData reagentProductionDataById = this.GetReagentProductionDataById(itemId);
			if (reagentProductionDataById != null)
			{
				int lastRoleId = reagentProductionDataById.LastRoleId;
				if (reagentProductionDataById.LastRoleId > 0)
				{
					return reagentProductionDataById.LastRoleId;
				}
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x060383A0 RID: 230304 RVA: 0x00D53660 File Offset: 0x00D51860
		public void CreateExchangeDataList()
		{
			if (this.ExchangeDataList == null)
			{
				this.ExchangeDataList = new List<IExchangeData>();
			}
			this.ExchangeDataList.Clear();
			IEnumerable<MaterialReplace> enumerable = ComposeConfig.Instance.GetExchangeList() ?? new MaterialReplace[0];
			Dictionary<int, IExchangeData> dictionary = new Dictionary<int, IExchangeData>();
			foreach (MaterialReplace materialReplace in enumerable)
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(materialReplace.ItemId);
				IExchangeData exchangeData = new IExchangeData
				{
					MainType = EComposeListType.Exchange,
					ConfigId = materialReplace.ItemId,
					IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, materialReplace.ItemId),
					LastRoleId = 0,
					Quality = config.Value.QualityId,
					ExistStartTime = 0.0,
					ExistEndTime = 0.0,
					MadeCountInLimitTime = 0,
					TotalMakeCountInLimitTime = 0,
					IsUnlock = 1,
					ExchangeGroupId = materialReplace.GroupId,
					GroupId = materialReplace.ShowGroupId,
					IsLimitForever = false,
					SortId = materialReplace.SortId,
					ExchangeParam = materialReplace.ExchangeParam
				};
				this.FillExchangeParamInfo(exchangeData, materialReplace.ExchangeParam);
				this.ExchangeDataList.Add(exchangeData);
				dictionary[materialReplace.ItemId] = exchangeData;
			}
		}

		// Token: 0x060383A1 RID: 230305 RVA: 0x00D537E8 File Offset: 0x00D519E8
		private void FillExchangeParamInfo(IExchangeData exchangeData, int exchangeParamId)
		{
			exchangeData.ExchangeParamId = exchangeParamId;
			ExchangeParam? exchangeParamById = ComposeConfig.Instance.GetExchangeParamById(exchangeParamId);
			if (exchangeParamById == null)
			{
				return;
			}
			exchangeData.IsSingleDirection = exchangeParamById.Value.IsSingleDirection;
			IntPair? target = exchangeParamById.Value.Target;
			if (target != null)
			{
				int item = target.Value.Item1;
				exchangeData.ExchangeTarget = item;
				exchangeData.ExchangeConsume = target.Value.Item2;
			}
			ExchangeType? exchangeTypeById = ComposeConfig.Instance.GetExchangeTypeById(exchangeParamById.Value.ExchangeType);
			if (exchangeTypeById == null)
			{
				return;
			}
			exchangeData.ExchangeTypeId = exchangeTypeById.Value.Id;
			exchangeData.ExchangeTypeDesc = (exchangeTypeById.Value.Desc ?? "");
		}

		// Token: 0x060383A2 RID: 230306 RVA: 0x00D538CC File Offset: 0x00D51ACC
		[NullableContext(2)]
		public IExchangeData GetExchangeDataById(int id)
		{
			foreach (IExchangeData exchangeData in this.ExchangeDataList)
			{
				if (id == exchangeData.ConfigId)
				{
					return exchangeData;
				}
			}
			return null;
		}

		// Token: 0x060383A3 RID: 230307 RVA: 0x00D53928 File Offset: 0x00D51B28
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IExchangeData> GetExchangeDataList()
		{
			return this.ExchangeDataList;
		}

		// Token: 0x060383A4 RID: 230308 RVA: 0x00D53930 File Offset: 0x00D51B30
		public List<ISingleItemInfo> GetExchangeMaterialListByGroupIdAndQualityId(int groupId, int quality)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			List<int> list2;
			if (!this.ExchangeItemBaseMap.TryGetValue(groupId, out list2))
			{
				return list;
			}
			foreach (int configId in list2)
			{
				CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(configId, 0);
				if (commonItemData != null && commonItemData.GetQuality() == quality)
				{
					list.Add(new ISingleItemInfo
					{
						Proto_ItemId = commonItemData.GetConfigId(),
						Proto_ItemNum = commonItemData.GetCount(),
						Proto_IsUnlock = true
					});
				}
			}
			return list;
		}

		// Token: 0x060383A5 RID: 230309 RVA: 0x00D539D8 File Offset: 0x00D51BD8
		public List<ISingleItemInfo> GetExchangeMaterialListByGroupId(int groupId)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			IReadOnlyList<MaterialReplace> exchangeByGroupId = ComposeConfig.Instance.GetExchangeByGroupId(groupId);
			if (exchangeByGroupId == null)
			{
				return list;
			}
			foreach (MaterialReplace materialReplace in exchangeByGroupId)
			{
				CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(materialReplace.ItemId, 0);
				list.Add(new ISingleItemInfo
				{
					Proto_ItemId = materialReplace.ItemId,
					Proto_ItemNum = ((commonItemData != null) ? commonItemData.GetCount() : 0),
					Proto_IsUnlock = true
				});
			}
			return list;
		}

		// Token: 0x060383A6 RID: 230310 RVA: 0x00D53A78 File Offset: 0x00D51C78
		public bool CheckCanReagentProduction(int id)
		{
			EBaseItemDataCheckMask checkFlags = (EBaseItemDataCheckMask)239;
			return this.CheckBaseItemData(this.GetReagentProductionDataById(id), checkFlags);
		}

		// Token: 0x060383A7 RID: 230311 RVA: 0x00D53A9C File Offset: 0x00D51C9C
		public bool CheckCanPurification(int id)
		{
			EBaseItemDataCheckMask checkFlags = (EBaseItemDataCheckMask)239;
			return this.CheckBaseItemData(this.GetPurificationDataById(id), checkFlags);
		}

		// Token: 0x060383A8 RID: 230312 RVA: 0x00D53AC0 File Offset: 0x00D51CC0
		public bool CheckCanStructure(int id)
		{
			EBaseItemDataCheckMask checkFlags = (EBaseItemDataCheckMask)239;
			return this.CheckBaseItemData(this.GetStructureDataById(id), checkFlags);
		}

		// Token: 0x060383A9 RID: 230313 RVA: 0x00D53AE4 File Offset: 0x00D51CE4
		public bool CheckCanExchange(int id)
		{
			EBaseItemDataCheckMask checkFlags = (EBaseItemDataCheckMask)19;
			return this.CheckBaseItemData(this.GetExchangeDataById(id), checkFlags);
		}

		// Token: 0x060383AA RID: 230314 RVA: 0x00D53B04 File Offset: 0x00D51D04
		public bool CheckBaseItemData(IBaseItemData data, EBaseItemDataCheckMask checkFlags = EBaseItemDataCheckMask.All)
		{
			return true & ((checkFlags & EBaseItemDataCheckMask.Unlock) <= (EBaseItemDataCheckMask)0 || this.CheckUnlock(data)) & ((checkFlags & EBaseItemDataCheckMask.LimitCount) <= (EBaseItemDataCheckMask)0 || this.CheckLimitCount(data)) & ((checkFlags & EBaseItemDataCheckMask.CoinEnough) <= (EBaseItemDataCheckMask)0 || this.CheckCoinEnough(data.ConfigId)) & ((checkFlags & EBaseItemDataCheckMask.ComposeMaterialEnough) <= (EBaseItemDataCheckMask)0 || this.CheckComposeMaterialEnough(data.ConfigId)) & ((checkFlags & EBaseItemDataCheckMask.ExchangeMaterialEnough) <= (EBaseItemDataCheckMask)0 || this.CheckExchangeMaterialEnough(data.ConfigId));
		}

		// Token: 0x060383AB RID: 230315 RVA: 0x00D53B78 File Offset: 0x00D51D78
		public bool CheckCoinEnough(int id)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(id);
			if (synthesisFormulaById == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "合成配方不存在, 跳过CheckCoinEnough检查";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id=", id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			List<OneItemConfig> list = new List<OneItemConfig>();
			for (int i = 0; i < synthesisFormulaById.Value.ConsumeItemsLength; i++)
			{
				list.Add(synthesisFormulaById.Value.ConsumeItems(i).Value);
			}
			return InventoryModel.Instance.CheckIsCoinEnough(ComposeController.Instance.ComposeCoinId, list);
		}

		// Token: 0x060383AC RID: 230316 RVA: 0x00D53C21 File Offset: 0x00D51E21
		public bool CheckLimitCount(IBaseItemData data)
		{
			return data.TotalMakeCountInLimitTime <= 0 || data.MadeCountInLimitTime < data.TotalMakeCountInLimitTime;
		}

		// Token: 0x060383AD RID: 230317 RVA: 0x00D53C3C File Offset: 0x00D51E3C
		public bool CheckUnlock(IBaseItemData data)
		{
			return data.IsUnlock > 0;
		}

		// Token: 0x060383AE RID: 230318 RVA: 0x00D53C48 File Offset: 0x00D51E48
		public bool CheckComposeMaterialEnough(int id)
		{
			if (this.IsInPurificationList())
			{
				return this.CheckComposeMaterialEnoughPurification(id);
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(id);
			if (synthesisFormulaById == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "合成配方不存在, 跳过CheckComposeMaterialEnough检查";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id=", id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			for (int i = 0; i < synthesisFormulaById.Value.ConsumeItemsLength; i++)
			{
				OneItemConfig value = synthesisFormulaById.Value.ConsumeItems(i).Value;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(value.ItemId, 0);
				if (value.Count > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060383AF RID: 230319 RVA: 0x00D53D04 File Offset: 0x00D51F04
		public int GetExchangeCountByTargetId(int targetId)
		{
			IExchangeData exchangeDataById = this.GetExchangeDataById(targetId);
			return this.GetExchangeCountByData(exchangeDataById);
		}

		// Token: 0x060383B0 RID: 230320 RVA: 0x00D53D20 File Offset: 0x00D51F20
		[NullableContext(2)]
		public int GetExchangeCountByData(IExchangeData exchangeData)
		{
			if (exchangeData != null && exchangeData.ExchangeConsume > 0)
			{
				return exchangeData.ExchangeConsume;
			}
			return 2;
		}

		// Token: 0x060383B1 RID: 230321 RVA: 0x00D53D38 File Offset: 0x00D51F38
		public bool CheckExchangeMaterialEnough(int id)
		{
			IExchangeData exchangeDataById = this.GetExchangeDataById(id);
			if (exchangeDataById == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "置换数据不存在, 跳过CheckExchangeMaterialEnough检查";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id=", id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			foreach (ISingleItemInfo singleItemInfo in this.GetExchangeMaterialListByGroupId(exchangeDataById.ExchangeGroupId))
			{
				if (singleItemInfo.Proto_ItemId != id && this.CanUseAsExchangeMaterial(singleItemInfo.Proto_ItemId, id) && singleItemInfo.Proto_ItemNum >= this.GetExchangeCountByData(exchangeDataById))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060383B2 RID: 230322 RVA: 0x00D53DF8 File Offset: 0x00D51FF8
		public bool CanUseAsExchangeMaterial(int materialItemId, int targetItemId)
		{
			IExchangeData exchangeDataById = this.GetExchangeDataById(materialItemId);
			return exchangeDataById == null || !exchangeDataById.IsSingleDirection || exchangeDataById.ExchangeTarget == targetItemId;
		}

		// Token: 0x060383B3 RID: 230323 RVA: 0x00D53E28 File Offset: 0x00D52028
		public void CreateStructureDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.StructureDataList == null)
			{
				this.StructureDataList = new List<IStructureData>();
			}
			this.StructureDataList.Clear();
			IEnumerable<SynthesisFormula> enumerable = ComposeConfig.Instance.GetComposeListByType(2) ?? Array.Empty<SynthesisFormula>();
			Dictionary<int, IStructureData> dictionary = new Dictionary<int, IStructureData>();
			foreach (SynthesisFormula synthesisFormula in enumerable)
			{
				if (synthesisFormula.FormulaItemId > 0)
				{
					ItemInfo? config = ItemConfig.Instance.GetConfig(synthesisFormula.ItemId);
					IStructureData structureData = new IStructureData
					{
						MainType = EComposeListType.Structure,
						SubType = ESubStructureDataType.StructureMenu,
						ConfigId = synthesisFormula.Id,
						StructureCount = 0,
						IsNew = false,
						LastRoleId = 0,
						Quality = config.Value.QualityId,
						ExistStartTime = 0.0,
						ExistEndTime = 0.0,
						MadeCountInLimitTime = 0,
						TotalMakeCountInLimitTime = 0,
						IsUnlock = 0,
						GroupId = 0,
						IsLimitForever = synthesisFormula.PermanentLimit,
						SortId = synthesisFormula.SortId
					};
					dictionary[structureData.ConfigId] = structureData;
					this.StructureDataList.Add(structureData);
				}
			}
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id);
				if (synthesisFormulaById.Value.FormulaType == 2)
				{
					ItemInfo? config2 = ItemConfig.Instance.GetConfig(synthesisFormulaById.Value.ItemId);
					if (dictionary.ContainsKey(oneSynthesisInfo.Id))
					{
						IStructureData structureData2 = dictionary[oneSynthesisInfo.Id];
						structureData2.StructureCount = oneSynthesisInfo.Count;
						structureData2.IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, oneSynthesisInfo.Id);
						structureData2.LastRoleId = oneSynthesisInfo.LastRoleId;
						structureData2.ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
						structureData2.ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
						structureData2.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
						structureData2.TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount;
						structureData2.IsUnlock = 1;
					}
					else
					{
						IStructureData structureData2 = new IStructureData
						{
							MainType = EComposeListType.Structure,
							SubType = ESubStructureDataType.Structure,
							ConfigId = oneSynthesisInfo.Id,
							StructureCount = oneSynthesisInfo.Count,
							IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, oneSynthesisInfo.Id),
							LastRoleId = oneSynthesisInfo.LastRoleId,
							Quality = config2.Value.QualityId,
							ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond,
							ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond,
							MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount,
							TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount,
							IsUnlock = 1,
							GroupId = 0,
							IsLimitForever = synthesisFormulaById.Value.PermanentLimit,
							SortId = synthesisFormulaById.Value.SortId
						};
						this.StructureDataList.Add(structureData2);
					}
				}
			}
		}

		// Token: 0x060383B4 RID: 230324 RVA: 0x00D541FC File Offset: 0x00D523FC
		public void UpdateStructureDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.StructureDataList == null || this.StructureDataList.Count <= 0)
			{
				return;
			}
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id);
				if (synthesisFormulaById.Value.FormulaType == 2)
				{
					bool flag = false;
					bool flag2 = false;
					foreach (IStructureData structureData in this.StructureDataList)
					{
						if (oneSynthesisInfo.Id == structureData.ConfigId)
						{
							structureData.StructureCount = oneSynthesisInfo.Count;
							structureData.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
							flag = true;
							flag2 = (structureData.IsUnlock == 0);
							structureData.IsUnlock = 1;
							break;
						}
					}
					if (flag2 || !flag)
					{
						NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, oneSynthesisInfo.Id);
						GenericPromptController.Instance.ShowPromptByCode("FormulaLearned", Array.Empty<object>());
					}
					if (!flag)
					{
						ItemInfo? config = ItemConfig.Instance.GetConfig(synthesisFormulaById.Value.ItemId);
						IStructureData item = new IStructureData
						{
							MainType = EComposeListType.Structure,
							SubType = ESubStructureDataType.Structure,
							ConfigId = oneSynthesisInfo.Id,
							StructureCount = oneSynthesisInfo.Count,
							IsNew = true,
							LastRoleId = oneSynthesisInfo.LastRoleId,
							Quality = config.Value.QualityId,
							ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond,
							ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond,
							MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount,
							TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount,
							IsUnlock = 1,
							GroupId = 0,
							IsLimitForever = synthesisFormulaById.Value.PermanentLimit,
							SortId = synthesisFormulaById.Value.SortId
						};
						this.StructureDataList.Add(item);
					}
				}
			}
		}

		// Token: 0x060383B5 RID: 230325 RVA: 0x00D54468 File Offset: 0x00D52668
		public void UnlockStructureData(int id)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(id);
			if (synthesisFormulaById.Value.FormulaType != 2)
			{
				return;
			}
			int num = 0;
			while (num < this.StructureDataList.Count && (this.StructureDataList[num].SubType != ESubStructureDataType.StructureMenu || this.StructureDataList[num].ConfigId != synthesisFormulaById.Value.FormulaItemId))
			{
				num++;
			}
			this.StructureDataList.RemoveAt(num);
		}

		// Token: 0x060383B6 RID: 230326 RVA: 0x00D544F0 File Offset: 0x00D526F0
		public void HideStructureDataList(IList<int> idList)
		{
			foreach (int num in idList)
			{
				if (ComposeConfig.Instance.GetSynthesisFormulaById(num).Value.FormulaType == 2)
				{
					int num2 = 0;
					while (num2 < this.StructureDataList.Count && this.StructureDataList[num2].ConfigId != num)
					{
						num2++;
					}
					this.StructureDataList.RemoveAt(num2);
				}
			}
		}

		// Token: 0x060383B7 RID: 230327 RVA: 0x00D54588 File Offset: 0x00D52788
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IStructureData> GetStructureDataList()
		{
			return this.StructureDataList;
		}

		// Token: 0x060383B8 RID: 230328 RVA: 0x00D54590 File Offset: 0x00D52790
		[NullableContext(2)]
		public IStructureData GetStructureDataById(int id)
		{
			foreach (IStructureData structureData in this.StructureDataList)
			{
				if (id == structureData.ConfigId)
				{
					return structureData;
				}
			}
			return null;
		}

		// Token: 0x060383B9 RID: 230329 RVA: 0x00D545EC File Offset: 0x00D527EC
		public int GetStructureRoleId(int itemId)
		{
			IStructureData structureDataById = this.GetStructureDataById(itemId);
			if (structureDataById != null && structureDataById.LastRoleId > 0)
			{
				return structureDataById.LastRoleId;
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x060383BA RID: 230330 RVA: 0x00D5461E File Offset: 0x00D5281E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SingleItemInfo> GetCurrentComposeMaterialList()
		{
			if (this.ComposeListType == EComposeListType.Collect)
			{
				return this.CollectComposeMaterialList;
			}
			return this.PurificationComposeMaterialList;
		}

		// Token: 0x060383BB RID: 230331 RVA: 0x00D54636 File Offset: 0x00D52836
		public void SetCurrentComposeMaterialList([Nullable(new byte[]
		{
			2,
			1
		})] List<SingleItemInfo> list)
		{
			if (this.ComposeListType == EComposeListType.Collect)
			{
				this.CollectComposeMaterialList = list;
				return;
			}
			this.PurificationComposeMaterialList = list;
		}

		// Token: 0x060383BC RID: 230332 RVA: 0x00D54650 File Offset: 0x00D52850
		public void CreatePurificationDataList()
		{
			if (this.PurificationDataList == null)
			{
				this.PurificationDataList = new List<IPurificationData>();
			}
			if (this.CollectDataList == null)
			{
				this.CollectDataList = new List<ICollectData>();
			}
			foreach (SynthesisFormula synthesisFormula in ComposeConfig.Instance.GetComposeListByType(3))
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(synthesisFormula.ItemId);
				if (synthesisFormula.IsCollect)
				{
					ICollectData item = new ICollectData
					{
						MainType = EComposeListType.Collect,
						ConfigId = synthesisFormula.Id,
						IsUnlock = 0,
						IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, synthesisFormula.Id),
						Quality = config.Value.QualityId,
						LastRoleId = 0,
						ExistStartTime = 0.0,
						ExistEndTime = 0.0,
						MadeCountInLimitTime = 0,
						TotalMakeCountInLimitTime = 0,
						IsLimitForever = synthesisFormula.PermanentLimit,
						GroupId = synthesisFormula.ItemGroup,
						SortId = synthesisFormula.SortId
					};
					this.CollectDataList.Add(item);
				}
				else
				{
					IPurificationData item2 = new IPurificationData
					{
						MainType = EComposeListType.Purification,
						ConfigId = synthesisFormula.Id,
						IsUnlock = 0,
						IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, synthesisFormula.Id),
						Quality = config.Value.QualityId,
						LastRoleId = 0,
						ExistStartTime = 0.0,
						ExistEndTime = 0.0,
						MadeCountInLimitTime = 0,
						TotalMakeCountInLimitTime = 0,
						IsLimitForever = synthesisFormula.PermanentLimit,
						GroupId = synthesisFormula.ItemGroup,
						SortId = synthesisFormula.SortId
					};
					this.PurificationDataList.Add(item2);
				}
			}
		}

		// Token: 0x060383BD RID: 230333 RVA: 0x00D54864 File Offset: 0x00D52A64
		public void UpdatePurificationDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.PurificationDataList == null || this.PurificationDataList.Count <= 0)
			{
				return;
			}
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id);
				if (synthesisFormulaById.Value.FormulaType == 3 && !synthesisFormulaById.Value.IsCollect)
				{
					foreach (IPurificationData purificationData in this.PurificationDataList)
					{
						if (oneSynthesisInfo.Id == purificationData.ConfigId)
						{
							purificationData.IsUnlock = 1;
							purificationData.LastRoleId = oneSynthesisInfo.LastRoleId;
							purificationData.ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
							purificationData.ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
							purificationData.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
							purificationData.TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060383BE RID: 230334 RVA: 0x00D549E0 File Offset: 0x00D52BE0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPurificationData> GetPurificationDataList()
		{
			return this.PurificationDataList;
		}

		// Token: 0x060383BF RID: 230335 RVA: 0x00D549E8 File Offset: 0x00D52BE8
		[NullableContext(2)]
		public IPurificationData GetPurificationDataById(int id)
		{
			foreach (IPurificationData purificationData in this.PurificationDataList)
			{
				if (id == purificationData.ConfigId)
				{
					return purificationData;
				}
			}
			return null;
		}

		// Token: 0x060383C0 RID: 230336 RVA: 0x00D54A44 File Offset: 0x00D52C44
		public int GetPurificationRoleId(int itemId)
		{
			IPurificationData purificationDataById = this.GetPurificationDataById(itemId);
			if (purificationDataById != null)
			{
				int lastRoleId = purificationDataById.LastRoleId;
				if (purificationDataById.LastRoleId > 0)
				{
					return purificationDataById.LastRoleId;
				}
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x060383C1 RID: 230337 RVA: 0x00D54A7D File Offset: 0x00D52C7D
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICollectData> GetCollectDataList()
		{
			return this.CollectDataList;
		}

		// Token: 0x060383C2 RID: 230338 RVA: 0x00D54A88 File Offset: 0x00D52C88
		[NullableContext(2)]
		public ICollectData GetCollectDataById(int id)
		{
			foreach (ICollectData collectData in this.CollectDataList)
			{
				if (id == collectData.ConfigId)
				{
					return collectData;
				}
			}
			return null;
		}

		// Token: 0x060383C3 RID: 230339 RVA: 0x00D54AE4 File Offset: 0x00D52CE4
		public int GetCollectRoleId(int itemId)
		{
			ICollectData collectDataById = this.GetCollectDataById(itemId);
			if (collectDataById != null)
			{
				int lastRoleId = collectDataById.LastRoleId;
				if (collectDataById.LastRoleId > 0)
				{
					return collectDataById.LastRoleId;
				}
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x060383C4 RID: 230340 RVA: 0x00D54B20 File Offset: 0x00D52D20
		public void UpdateCollectDataList(IList<OneSynthesisInfo> composeDataList)
		{
			if (this.CollectDataList == null || this.CollectDataList.Count <= 0)
			{
				return;
			}
			foreach (OneSynthesisInfo oneSynthesisInfo in composeDataList)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(oneSynthesisInfo.Id);
				if (synthesisFormulaById.Value.FormulaType == 3 && synthesisFormulaById.Value.IsCollect)
				{
					foreach (ICollectData collectData in this.CollectDataList)
					{
						if (oneSynthesisInfo.Id == collectData.ConfigId)
						{
							collectData.IsUnlock = 1;
							collectData.LastRoleId = oneSynthesisInfo.LastRoleId;
							collectData.ExistStartTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitBeginTime) * TimeUtil.Instance.Millisecond;
							collectData.ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneSynthesisInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
							collectData.MadeCountInLimitTime = oneSynthesisInfo.LimitSynthesisCount;
							collectData.TotalMakeCountInLimitTime = oneSynthesisInfo.LimitCount;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060383C5 RID: 230341 RVA: 0x00D54C9C File Offset: 0x00D52E9C
		public bool CheckCanCollect(int id)
		{
			EBaseItemDataCheckMask checkFlags = (EBaseItemDataCheckMask)239;
			return this.CheckBaseItemData(this.GetCollectDataById(id), checkFlags);
		}

		// Token: 0x17008746 RID: 34630
		// (get) Token: 0x060383C6 RID: 230342 RVA: 0x00D54CBD File Offset: 0x00D52EBD
		// (set) Token: 0x060383C7 RID: 230343 RVA: 0x00D54CC5 File Offset: 0x00D52EC5
		public int SelectedComposeLevel
		{
			get
			{
				return this.ComposeLevel;
			}
			set
			{
				this.ComposeLevel = value;
			}
		}

		// Token: 0x060383C8 RID: 230344 RVA: 0x00D54CD0 File Offset: 0x00D52ED0
		public void CreateComposeLevelInfo(SynthesisLevelInfo composeInfo)
		{
			this.UpdateComposeInfo(composeInfo);
			this.ComposeLevelMap = new Dictionary<int, SynthesisLevel>();
			foreach (SynthesisLevel value in ComposeConfig.Instance.GetComposeLevel())
			{
				this.ComposeLevelMap[value.Id] = value;
			}
		}

		// Token: 0x060383C9 RID: 230345 RVA: 0x00D54D40 File Offset: 0x00D52F40
		public void UpdateComposeInfo(SynthesisLevelInfo composeInfo)
		{
			int addExp = 0;
			if (this.ComposeLevelInfo != null)
			{
				this.LastExp = this.ComposeLevelInfo.TotalProficiency;
				addExp = composeInfo.TotalProficiency - this.ComposeLevelInfo.TotalProficiency;
			}
			this.ComposeLevelInfo = new IComposeLevelInfoData
			{
				ComposeLevel = composeInfo.Level,
				TotalProficiency = composeInfo.TotalProficiency,
				AddExp = addExp
			};
		}

		// Token: 0x060383CA RID: 230346 RVA: 0x00D54DA5 File Offset: 0x00D52FA5
		[NullableContext(2)]
		public IComposeLevelInfoData GetComposeInfo()
		{
			return this.ComposeLevelInfo;
		}

		// Token: 0x060383CB RID: 230347 RVA: 0x00D54DAD File Offset: 0x00D52FAD
		public void CleanAddExp()
		{
			this.ComposeLevelInfo.AddExp = 0;
		}

		// Token: 0x060383CC RID: 230348 RVA: 0x00D54DBB File Offset: 0x00D52FBB
		public SynthesisLevel? GetComposeLevelByLevel(int level)
		{
			return new SynthesisLevel?(this.ComposeLevelMap[level]);
		}

		// Token: 0x060383CD RID: 230349 RVA: 0x00D54DCE File Offset: 0x00D52FCE
		public int GetComposeMaxLevel()
		{
			return this.ComposeLevelMap.Count;
		}

		// Token: 0x060383CE RID: 230350 RVA: 0x00D54DDC File Offset: 0x00D52FDC
		public int GetSumExpByLevel(int level)
		{
			int composeMaxLevel = this.GetComposeMaxLevel();
			int num = level + 1;
			if (num > composeMaxLevel)
			{
				num = composeMaxLevel;
			}
			return this.GetComposeLevelByLevel(num).Value.Completeness;
		}

		// Token: 0x060383CF RID: 230351 RVA: 0x00D54E14 File Offset: 0x00D53014
		public int GetDropIdByLevel(int level)
		{
			int composeMaxLevel = this.GetComposeMaxLevel();
			int num = level + 1;
			if (num > composeMaxLevel)
			{
				return -1;
			}
			return this.GetComposeLevelByLevel(num).Value.DropIds;
		}

		// Token: 0x060383D0 RID: 230352 RVA: 0x00D54E4C File Offset: 0x00D5304C
		public List<ISingleItemInfo> GetComposeMaterialList(int itemId)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			if (this.IsInPurificationList())
			{
				list = this.GetComposeMaterialListPurification(itemId);
				if (list.Count > 0)
				{
					return list;
				}
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(itemId);
			for (int i = 0; i < synthesisFormulaById.Value.ConsumeItemsLength; i++)
			{
				OneItemConfig value = synthesisFormulaById.Value.ConsumeItems(i).Value;
				list.Add(new ISingleItemInfo
				{
					Proto_ItemId = value.ItemId,
					Proto_ItemNum = value.Count,
					Proto_IsUnlock = true
				});
			}
			return list;
		}

		// Token: 0x060383D1 RID: 230353 RVA: 0x00D54EEC File Offset: 0x00D530EC
		public void UpdateComposeItemList(IList<SingleItemInfo> itemList)
		{
			if (this.ComposeItemList == null)
			{
				this.ComposeItemList = new List<ICommonPopItemData>();
			}
			this.ComposeItemList.Clear();
			foreach (SingleItemInfo singleItemInfo in itemList)
			{
				this.ComposeItemList.Add(new ICommonPopItemData
				{
					ItemId = singleItemInfo.ItemId,
					ItemNum = singleItemInfo.ItemNum
				});
			}
		}

		// Token: 0x060383D2 RID: 230354 RVA: 0x00D54F74 File Offset: 0x00D53174
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetComposeItemList()
		{
			return this.ComposeItemList;
		}

		// Token: 0x060383D3 RID: 230355 RVA: 0x00D54F7C File Offset: 0x00D5317C
		public string GetComposeText(int itemId)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(itemId);
			return ComposeConfig.Instance.GetLocalText(synthesisFormulaById.Value.Name);
		}

		// Token: 0x060383D4 RID: 230356 RVA: 0x00D54FB0 File Offset: 0x00D531B0
		public int GetComposeId(int itemId)
		{
			return ComposeConfig.Instance.GetSynthesisFormulaById(itemId).Value.ItemId;
		}

		// Token: 0x17008747 RID: 34631
		// (get) Token: 0x060383D5 RID: 230357 RVA: 0x00D54FD8 File Offset: 0x00D531D8
		// (set) Token: 0x060383D6 RID: 230358 RVA: 0x00D54FE0 File Offset: 0x00D531E0
		public int CurrentComposeRoleId
		{
			get
			{
				return this.ComposeRoleId;
			}
			set
			{
				this.ComposeRoleId = value;
			}
		}

		// Token: 0x060383D7 RID: 230359 RVA: 0x00D54FEC File Offset: 0x00D531EC
		public void UpdateHelpRoleItemDataList()
		{
			if (this.ComposeRoleItemDataList == null)
			{
				this.ComposeRoleItemDataList = new List<ICommonRoleItemData>();
			}
			this.ComposeRoleItemDataList.Clear();
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				this.ComposeRoleItemDataList.Add(new ICommonRoleItemData
				{
					RoleId = roleInstance.GetRoleId(),
					RoleName = roleInstance.GetRoleRealName(),
					RoleIcon = roleInstance.GetRoleConfig().RoleHeadIcon,
					IsBuff = false,
					ItemId = 0
				});
			}
		}

		// Token: 0x060383D8 RID: 230360 RVA: 0x00D5507E File Offset: 0x00D5327E
		public void ClearComposeRoleItemDataList()
		{
			this.ComposeRoleItemDataList = null;
		}

		// Token: 0x060383D9 RID: 230361 RVA: 0x00D55088 File Offset: 0x00D53288
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			if (this.ComposeRoleItemDataList == null)
			{
				this.UpdateHelpRoleItemDataList();
			}
			foreach (ICommonRoleItemData commonRoleItemData in this.ComposeRoleItemDataList)
			{
				commonRoleItemData.ItemId = itemId;
				commonRoleItemData.IsBuff = ComposeController.Instance.CheckIsBuff(commonRoleItemData.RoleId, itemId);
			}
			this.ComposeRoleItemDataList.Sort(new Comparison<ICommonRoleItemData>(this.SortHelpRoleItemDataList));
			return this.ComposeRoleItemDataList;
		}

		// Token: 0x060383DA RID: 230362 RVA: 0x00D55120 File Offset: 0x00D53320
		private int SortHelpRoleItemDataList(ICommonRoleItemData dataA, ICommonRoleItemData dataB)
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

		// Token: 0x060383DB RID: 230363 RVA: 0x00D5514C File Offset: 0x00D5334C
		public List<IBaseItemData> GetSameGroupItem(IBaseItemData data)
		{
			List<IBaseItemData> list = new List<IBaseItemData>();
			int groupId = data.GroupId;
			EComposeListType mainType = data.MainType;
			if (mainType == EComposeListType.Purification)
			{
				using (List<IPurificationData>.Enumerator enumerator = this.PurificationDataList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IPurificationData purificationData = enumerator.Current;
						if (purificationData.GroupId == groupId)
						{
							list.Add(purificationData);
						}
					}
					goto IL_EB;
				}
			}
			if (mainType == EComposeListType.Collect)
			{
				using (List<ICollectData>.Enumerator enumerator2 = this.CollectDataList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						ICollectData collectData = enumerator2.Current;
						if (collectData.GroupId == groupId)
						{
							list.Add(collectData);
						}
					}
					goto IL_EB;
				}
			}
			if (mainType == EComposeListType.Exchange)
			{
				foreach (IExchangeData exchangeData in this.ExchangeDataList)
				{
					if (exchangeData.GroupId == groupId)
					{
						list.Add(exchangeData);
					}
				}
			}
			IL_EB:
			return (from a in list
			orderby a.Quality
			select a).ToList<IBaseItemData>();
		}

		// Token: 0x060383DC RID: 230364 RVA: 0x00D55298 File Offset: 0x00D53498
		public unsafe List<IComposeItemData> CalculateNeedComposeMaterialList(int configId, int count)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(configId);
			if (synthesisFormulaById == null)
			{
				return new List<IComposeItemData>();
			}
			List<IComposeItemData> list = ComposePopupModel.Instance.CalcMaterialListPurification(synthesisFormulaById.Value.ItemId, count, false, null);
			if (list == null || list.Count <= 0)
			{
				OneItemConfig value = synthesisFormulaById.Value.ConsumeItems(0).Value;
				int num = 1;
				List<IComposeItemData> list2 = new List<IComposeItemData>(num);
				CollectionsMarshal.SetCount<IComposeItemData>(list2, num);
				Span<IComposeItemData> span = CollectionsMarshal.AsSpan<IComposeItemData>(list2);
				int index = 0;
				*span[index] = new IComposeItemData
				{
					ItemId = value.ItemId,
					RequiredNum = value.Count
				};
				return list2;
			}
			return list;
		}

		// Token: 0x060383DD RID: 230365 RVA: 0x00D5534C File Offset: 0x00D5354C
		[NullableContext(2)]
		public int GetMaxCreateCountPurification(int configId, IBaseItemData itemData = null)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(configId);
			if (synthesisFormulaById == null)
			{
				return 0;
			}
			int maxCreateCountPurification = ComposePopupModel.Instance.GetMaxCreateCountPurification(synthesisFormulaById.Value.ItemId, false, null);
			if (itemData == null)
			{
				return maxCreateCountPurification;
			}
			if (itemData.TotalMakeCountInLimitTime <= 0)
			{
				return maxCreateCountPurification;
			}
			int val = itemData.TotalMakeCountInLimitTime - itemData.MadeCountInLimitTime;
			return Math.Min(maxCreateCountPurification, val);
		}

		// Token: 0x060383DE RID: 230366 RVA: 0x00D553B4 File Offset: 0x00D535B4
		private List<ISingleItemInfo> GetComposeMaterialListPurification(int formulaId)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(formulaId);
			if (synthesisFormulaById == null)
			{
				return new List<ISingleItemInfo>();
			}
			return (from material in ComposePopupModel.Instance.GetComposeMaterialListPurification(synthesisFormulaById.Value.ItemId) ?? new List<IComposeItemData>()
			select new ISingleItemInfo
			{
				Proto_ItemId = material.ItemId,
				Proto_ItemNum = material.RequiredNum,
				Proto_IsUnlock = true
			}).ToList<ISingleItemInfo>();
		}

		// Token: 0x060383DF RID: 230367 RVA: 0x00D55428 File Offset: 0x00D53628
		private bool CheckComposeMaterialEnoughPurification(int id)
		{
			if (ComposeConfig.Instance.GetSynthesisFormulaById(id) == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "合成配方不存在, 跳过CheckComposeMaterialEnough检查";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id=", id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			return this.GetMaxCreateCountPurification(id, null) > 0;
		}

		// Token: 0x17008748 RID: 34632
		// (get) Token: 0x060383E0 RID: 230368 RVA: 0x00D55486 File Offset: 0x00D53686
		public static ComposeModel Instance
		{
			get
			{
				return ComposeModel._Instance;
			}
		}

		// Token: 0x060383E1 RID: 230369 RVA: 0x00D5548D File Offset: 0x00D5368D
		public static ComposeModel GetOrCreateInstance()
		{
			if (ComposeModel._Instance == null)
			{
				ComposeModel.CreateInstance();
			}
			return ComposeModel._Instance;
		}

		// Token: 0x060383E2 RID: 230370 RVA: 0x00D554A1 File Offset: 0x00D536A1
		public static bool CreateInstance()
		{
			if (ComposeModel._Instance != null)
			{
				return true;
			}
			ComposeModel._Instance = new ComposeModel();
			return true;
		}

		// Token: 0x060383E3 RID: 230371 RVA: 0x00D554B7 File Offset: 0x00D536B7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060383E4 RID: 230372 RVA: 0x00D554B9 File Offset: 0x00D536B9
		public static void ResetStaticDefaultValue()
		{
			ComposeModel._Instance = null;
		}

		// Token: 0x060383E5 RID: 230373 RVA: 0x00D554C1 File Offset: 0x00D536C1
		static ComposeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeModel.CreateStaticDefaultValue), new Action(ComposeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D91F RID: 121119
		public Dictionary<int, List<int>> ExchangeItemBaseMap = new Dictionary<int, List<int>>();

		// Token: 0x0401D920 RID: 121120
		private double LimitRefreshTime = -1.0;

		// Token: 0x0401D921 RID: 121121
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x0401D922 RID: 121122
		public int CurrentExchangeConsume;

		// Token: 0x0401D923 RID: 121123
		private EComposeViewType ComposeViewType;

		// Token: 0x0401D924 RID: 121124
		public int LastExp;

		// Token: 0x0401D925 RID: 121125
		[Nullable(2)]
		public PlayFlow ComposeEnterFlow;

		// Token: 0x0401D926 RID: 121126
		[Nullable(2)]
		public PlayFlow ComposeSuccessFlow;

		// Token: 0x0401D927 RID: 121127
		[Nullable(2)]
		public PlayFlow ComposeFailFlow;

		// Token: 0x0401D928 RID: 121128
		private EComposeListType ComposeListType = EComposeListType.Purification;

		// Token: 0x0401D929 RID: 121129
		private List<IReagentProductionData> ReagentProductionDataList = new List<IReagentProductionData>();

		// Token: 0x0401D92A RID: 121130
		private List<IExchangeData> ExchangeDataList = new List<IExchangeData>();

		// Token: 0x0401D92B RID: 121131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IStructureData> StructureDataList;

		// Token: 0x0401D92C RID: 121132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPurificationData> PurificationDataList;

		// Token: 0x0401D92D RID: 121133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SingleItemInfo> PurificationComposeMaterialList;

		// Token: 0x0401D92E RID: 121134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICollectData> CollectDataList;

		// Token: 0x0401D92F RID: 121135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SingleItemInfo> CollectComposeMaterialList;

		// Token: 0x0401D930 RID: 121136
		private int ComposeLevel;

		// Token: 0x0401D931 RID: 121137
		[Nullable(2)]
		private Dictionary<int, SynthesisLevel> ComposeLevelMap;

		// Token: 0x0401D932 RID: 121138
		[Nullable(2)]
		private IComposeLevelInfoData ComposeLevelInfo;

		// Token: 0x0401D933 RID: 121139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonPopItemData> ComposeItemList;

		// Token: 0x0401D934 RID: 121140
		private int ComposeRoleId;

		// Token: 0x0401D935 RID: 121141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> ComposeRoleItemDataList;

		// Token: 0x0401D936 RID: 121142
		[Nullable(2)]
		public ISelectedData ComposeSelectItem;

		// Token: 0x0401D937 RID: 121143
		public EUiViewName? ComposeSkipSourceView;

		// Token: 0x0401D938 RID: 121144
		[Nullable(2)]
		private static ComposeModel _Instance;
	}
}
