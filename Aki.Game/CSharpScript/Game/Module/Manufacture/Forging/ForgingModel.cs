using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Manufacture.Common;

namespace CSharpScript.Game.Module.Manufacture.Forging
{
	// Token: 0x0200461F RID: 17951
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingModel : ModelBase
	{
		// Token: 0x0602D186 RID: 184710 RVA: 0x00C9B19E File Offset: 0x00C9939E
		public void SaveLimitRefreshTime(long refreshTime)
		{
			this.LimitRefreshTime = (double)refreshTime * TimeUtil.Instance.Millisecond;
		}

		// Token: 0x0602D187 RID: 184711 RVA: 0x00C9B1B4 File Offset: 0x00C993B4
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

		// Token: 0x0602D188 RID: 184712 RVA: 0x00C9B1F8 File Offset: 0x00C993F8
		public double GetRefreshLimitTimeValue()
		{
			if (this.LimitRefreshTime <= 0.0)
			{
				return 1.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).RemainingTime;
		}

		// Token: 0x0602D189 RID: 184713 RVA: 0x00C9B244 File Offset: 0x00C99444
		protected override bool OnInit()
		{
			this.ForgingEnterFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ForgingEnterStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ForgingEnterFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ForgingEnterFlowId").Value
			};
			this.ForgingSuccessFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ForgingSuccessStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ForgingSuccessFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ForgingSuccessFlowId").Value
			};
			this.ForgingFailFlow = new PlayFlow
			{
				StateId = ConfigCommonParamById.GetIntConfig("ForgingFailStateId").Value,
				FlowListName = ConfigCommonParamById.GetStringConfig("ForgingFailFlowListName"),
				FlowId = ConfigCommonParamById.GetIntConfig("ForgingFailFlowId").Value
			};
			return true;
		}

		// Token: 0x0602D18A RID: 184714 RVA: 0x00C9B333 File Offset: 0x00C99533
		protected override bool OnClear()
		{
			this.ForgingEnterFlow = null;
			this.ForgingSuccessFlow = null;
			this.ForgingFailFlow = null;
			return true;
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x0602D18B RID: 184715 RVA: 0x00C9B34B File Offset: 0x00C9954B
		// (set) Token: 0x0602D18C RID: 184716 RVA: 0x00C9B353 File Offset: 0x00C99553
		public EForgingViewType CurrentForgingViewType
		{
			get
			{
				return this.ForgingViewType;
			}
			set
			{
				this.ForgingViewType = value;
			}
		}

		// Token: 0x0602D18D RID: 184717 RVA: 0x00C9B35C File Offset: 0x00C9955C
		public void CreateForgingDataList()
		{
			if (this.ForgingDataList == null)
			{
				this.ForgingDataList = new List<IWeaponForgingData>();
			}
			this.ForgingDataList.Clear();
			foreach (ForgeFormula forgeFormula in ForgingConfig.Instance.GetForgeList())
			{
				int id = forgeFormula.Id;
				ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
				WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
				IWeaponForgingData weaponForgingData = new IWeaponForgingData
				{
					MainType = EForgingListType.WeaponForging,
					ItemId = id,
					IsUnlock = 0,
					FormulaItemId = forgeFormulaById.Value.FormulaItemId,
					UniqueId = 0,
					IsNew = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.ForgingLevelKey, id),
					IsForging = 0,
					Quality = weaponConfigByItemId.Value.QualityId,
					LastRoleId = 0,
					WeaponType = weaponConfigByItemId.Value.WeaponType,
					ExistStartTime = 0.0,
					ExistEndTime = 0.0,
					MadeCountInLimitTime = 0,
					TotalMakeCountInLimitTime = 0,
					SortId = forgeFormulaById.Value.SortId
				};
				this.ForgingDataList.Add(weaponForgingData);
				this.ForgingDataMap[id] = weaponForgingData;
				weaponForgingData.IsForging = ((this.CheckCanForging(id) > false) ? 1 : 0);
			}
		}

		// Token: 0x0602D18E RID: 184718 RVA: 0x00C9B4FC File Offset: 0x00C996FC
		private void RemoveForgingDataByItemId(int itemId)
		{
			int index = this.ForgingDataList.FindIndex((IWeaponForgingData v) => v.ItemId == itemId);
			this.ForgingDataList.RemoveAt(index);
			this.ForgingDataMap.Remove(itemId);
		}

		// Token: 0x0602D18F RID: 184719 RVA: 0x00C9B54C File Offset: 0x00C9974C
		public bool CheckCanForging(int id)
		{
			IWeaponForgingData forgingDataById = this.GetForgingDataById(id);
			return this.CheckUnlock(forgingDataById) && this.CheckLimitCount(forgingDataById) && this.CheckCoinEnough(forgingDataById.ItemId) && this.CheckMaterialEnough(forgingDataById.ItemId);
		}

		// Token: 0x0602D190 RID: 184720 RVA: 0x00C9B590 File Offset: 0x00C99790
		public bool CheckCoinEnough(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return InventoryModel.Instance.CheckIsCoinEnough(ForgingController.Instance.ForgingCostId, forgeFormulaById.Value.ConsumeItems());
		}

		// Token: 0x0602D191 RID: 184721 RVA: 0x00C9B5CC File Offset: 0x00C997CC
		public bool CheckLimitCount(IWeaponForgingData data)
		{
			return data.TotalMakeCountInLimitTime <= 0 || data.MadeCountInLimitTime < data.TotalMakeCountInLimitTime;
		}

		// Token: 0x0602D192 RID: 184722 RVA: 0x00C9B5E7 File Offset: 0x00C997E7
		public bool CheckUnlock(IWeaponForgingData data)
		{
			return data.IsUnlock > 0;
		}

		// Token: 0x0602D193 RID: 184723 RVA: 0x00C9B5F4 File Offset: 0x00C997F4
		public bool CheckMaterialEnough(int id)
		{
			foreach (OneItemConfig oneItemConfig in ForgingConfig.Instance.GetForgeFormulaById(id).Value.ConsumeItems())
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0);
				if (oneItemConfig.Count > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602D194 RID: 184724 RVA: 0x00C9B658 File Offset: 0x00C99858
		public void UpdateForgingDataList(IList<OneForgeInfo> forgingDataList)
		{
			foreach (OneForgeInfo oneForgeInfo in forgingDataList)
			{
				int id = oneForgeInfo.Id;
				IWeaponForgingData forgingDataById = this.GetForgingDataById(id);
				if (forgingDataById != null)
				{
					forgingDataById.LastRoleId = oneForgeInfo.LastRoleId;
					forgingDataById.ExistStartTime = (double)oneForgeInfo.LimitBeginTime * TimeUtil.Instance.Millisecond;
					forgingDataById.ExistEndTime = (double)MathUtils.Instance.LongToNumber(oneForgeInfo.LimitEndTime) * TimeUtil.Instance.Millisecond;
					forgingDataById.MadeCountInLimitTime = oneForgeInfo.LimitForgeCount;
					forgingDataById.TotalMakeCountInLimitTime = oneForgeInfo.LimitCount;
					forgingDataById.IsUnlock = 1;
					forgingDataById.IsForging = ((this.CheckCanForging(id) > false) ? 1 : 0);
				}
			}
		}

		// Token: 0x0602D195 RID: 184725 RVA: 0x00C9B728 File Offset: 0x00C99928
		public void UpdateForgingByServerConfig(IList<OneForgeInfo> forgeConfigs)
		{
			foreach (OneForgeInfo oneForgeInfo in forgeConfigs)
			{
				double num = (double)oneForgeInfo.LimitBeginTime * TimeUtil.Instance.Millisecond;
				double num2 = (double)oneForgeInfo.LimitEndTime * TimeUtil.Instance.Millisecond;
				int id = oneForgeInfo.Id;
				IWeaponForgingData forgingDataById = this.GetForgingDataById(id);
				if (forgingDataById != null)
				{
					if ((num == 0.0 && num2 == 0.0) || TimeUtil.Instance.IsInTimeSpan(num, num2))
					{
						forgingDataById.ExistStartTime = num;
						forgingDataById.ExistEndTime = num2;
					}
					else
					{
						this.RemoveForgingDataByItemId(id);
					}
				}
			}
		}

		// Token: 0x0602D196 RID: 184726 RVA: 0x00C9B7E4 File Offset: 0x00C999E4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IWeaponForgingData> GetForgingDataList()
		{
			return this.ForgingDataList;
		}

		// Token: 0x0602D197 RID: 184727 RVA: 0x00C9B7EC File Offset: 0x00C999EC
		[NullableContext(2)]
		public IWeaponForgingData GetForgingDataById(int id)
		{
			IWeaponForgingData result;
			if (!this.ForgingDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602D198 RID: 184728 RVA: 0x00C9B80C File Offset: 0x00C99A0C
		public int GetForgingRoleId(int itemId)
		{
			IWeaponForgingData forgingDataById = this.GetForgingDataById(itemId);
			if (forgingDataById != null && forgingDataById.LastRoleId > 0)
			{
				return forgingDataById.LastRoleId;
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x0602D199 RID: 184729 RVA: 0x00C9B840 File Offset: 0x00C99A40
		public List<ISingleItemInfo> GetForgingMaterialList(int itemId)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			foreach (OneItemConfig oneItemConfig in ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.ConsumeItems())
			{
				list.Add(new ISingleItemInfo
				{
					Proto_ItemId = oneItemConfig.ItemId,
					Proto_ItemNum = oneItemConfig.Count,
					Proto_IsUnlock = true
				});
			}
			return list;
		}

		// Token: 0x0602D19A RID: 184730 RVA: 0x00C9B8B4 File Offset: 0x00C99AB4
		public void UpdateForgingItemList(IList<SingleItemInfo> itemList)
		{
			if (this.ForgingItemList == null)
			{
				this.ForgingItemList = new List<ICommonPopItemData>();
			}
			this.ForgingItemList.Clear();
			foreach (SingleItemInfo singleItemInfo in itemList)
			{
				this.ForgingItemList.Add(new ICommonPopItemData
				{
					ItemId = singleItemInfo.ItemId,
					ItemNum = singleItemInfo.ItemNum
				});
			}
		}

		// Token: 0x0602D19B RID: 184731 RVA: 0x00C9B93C File Offset: 0x00C99B3C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetForgingItemList()
		{
			return this.ForgingItemList;
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x0602D19C RID: 184732 RVA: 0x00C9B944 File Offset: 0x00C99B44
		// (set) Token: 0x0602D19D RID: 184733 RVA: 0x00C9B94C File Offset: 0x00C99B4C
		public int CurrentForgingRoleId
		{
			get
			{
				return this.ForgingRoleId;
			}
			set
			{
				this.ForgingRoleId = value;
			}
		}

		// Token: 0x0602D19E RID: 184734 RVA: 0x00C9B958 File Offset: 0x00C99B58
		public void UpdateHelpRoleItemDataList()
		{
			if (this.ForgingRoleItemDataList == null)
			{
				this.ForgingRoleItemDataList = new List<ICommonRoleItemData>();
			}
			this.ForgingRoleItemDataList.Clear();
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				this.ForgingRoleItemDataList.Add(new ICommonRoleItemData
				{
					RoleId = roleInstance.GetRoleId(),
					RoleName = roleInstance.GetRoleRealName(),
					RoleIcon = roleInstance.GetRoleConfig().RoleHeadIcon,
					IsBuff = false,
					ItemId = 0
				});
			}
		}

		// Token: 0x0602D19F RID: 184735 RVA: 0x00C9B9EC File Offset: 0x00C99BEC
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			if (this.ForgingRoleItemDataList == null)
			{
				this.UpdateHelpRoleItemDataList();
			}
			foreach (ICommonRoleItemData commonRoleItemData in this.ForgingRoleItemDataList)
			{
				commonRoleItemData.ItemId = itemId;
				commonRoleItemData.IsBuff = ForgingController.Instance.CheckIsBuff(commonRoleItemData.RoleId, itemId);
			}
			this.ForgingRoleItemDataList.Sort(new Comparison<ICommonRoleItemData>(this.SortHelpRoleItemDataList));
			return this.ForgingRoleItemDataList;
		}

		// Token: 0x0602D1A0 RID: 184736 RVA: 0x00C9BA84 File Offset: 0x00C99C84
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

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x0602D1A1 RID: 184737 RVA: 0x00C9BAAD File Offset: 0x00C99CAD
		public static ForgingModel Instance
		{
			get
			{
				return ForgingModel._Instance;
			}
		}

		// Token: 0x0602D1A2 RID: 184738 RVA: 0x00C9BAB4 File Offset: 0x00C99CB4
		public static ForgingModel GetOrCreateInstance()
		{
			if (ForgingModel._Instance == null)
			{
				ForgingModel.CreateInstance();
			}
			return ForgingModel._Instance;
		}

		// Token: 0x0602D1A3 RID: 184739 RVA: 0x00C9BAC8 File Offset: 0x00C99CC8
		public static bool CreateInstance()
		{
			if (ForgingModel._Instance != null)
			{
				return true;
			}
			ForgingModel._Instance = new ForgingModel();
			return true;
		}

		// Token: 0x0602D1A4 RID: 184740 RVA: 0x00C9BADE File Offset: 0x00C99CDE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D1A5 RID: 184741 RVA: 0x00C9BAE0 File Offset: 0x00C99CE0
		public static void ResetStaticDefaultValue()
		{
			ForgingModel._Instance = null;
		}

		// Token: 0x0602D1A6 RID: 184742 RVA: 0x00C9BAE8 File Offset: 0x00C99CE8
		static ForgingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingModel.CreateStaticDefaultValue), new Action(ForgingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401832D RID: 99117
		private double LimitRefreshTime = -1.0;

		// Token: 0x0401832E RID: 99118
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x0401832F RID: 99119
		private EForgingViewType ForgingViewType;

		// Token: 0x04018330 RID: 99120
		[Nullable(2)]
		public PlayFlow ForgingEnterFlow;

		// Token: 0x04018331 RID: 99121
		[Nullable(2)]
		public PlayFlow ForgingSuccessFlow;

		// Token: 0x04018332 RID: 99122
		[Nullable(2)]
		public PlayFlow ForgingFailFlow;

		// Token: 0x04018333 RID: 99123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IWeaponForgingData> ForgingDataList;

		// Token: 0x04018334 RID: 99124
		private readonly Dictionary<int, IWeaponForgingData> ForgingDataMap = new Dictionary<int, IWeaponForgingData>();

		// Token: 0x04018335 RID: 99125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonPopItemData> ForgingItemList;

		// Token: 0x04018336 RID: 99126
		private int ForgingRoleId;

		// Token: 0x04018337 RID: 99127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> ForgingRoleItemDataList;

		// Token: 0x04018338 RID: 99128
		[Nullable(2)]
		private static ForgingModel _Instance;
	}
}
