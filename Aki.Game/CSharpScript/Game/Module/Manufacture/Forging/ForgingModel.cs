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
	// Token: 0x02005649 RID: 22089
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingModel : ModelBase
	{
		// Token: 0x06038288 RID: 230024 RVA: 0x00D4D44E File Offset: 0x00D4B64E
		public void SaveLimitRefreshTime(long refreshTime)
		{
			this.LimitRefreshTime = (double)refreshTime * TimeUtil.Instance.Millisecond;
		}

		// Token: 0x06038289 RID: 230025 RVA: 0x00D4D464 File Offset: 0x00D4B664
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

		// Token: 0x0603828A RID: 230026 RVA: 0x00D4D4A8 File Offset: 0x00D4B6A8
		public double GetRefreshLimitTimeValue()
		{
			if (this.LimitRefreshTime <= 0.0)
			{
				return 1.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetRemainTimeDataFormat(this.LimitRefreshTime - serverTime).RemainingTime;
		}

		// Token: 0x0603828B RID: 230027 RVA: 0x00D4D4F4 File Offset: 0x00D4B6F4
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

		// Token: 0x0603828C RID: 230028 RVA: 0x00D4D5E3 File Offset: 0x00D4B7E3
		protected override bool OnClear()
		{
			this.ForgingEnterFlow = null;
			this.ForgingSuccessFlow = null;
			this.ForgingFailFlow = null;
			return true;
		}

		// Token: 0x1700873C RID: 34620
		// (get) Token: 0x0603828D RID: 230029 RVA: 0x00D4D5FB File Offset: 0x00D4B7FB
		// (set) Token: 0x0603828E RID: 230030 RVA: 0x00D4D603 File Offset: 0x00D4B803
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

		// Token: 0x0603828F RID: 230031 RVA: 0x00D4D60C File Offset: 0x00D4B80C
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

		// Token: 0x06038290 RID: 230032 RVA: 0x00D4D7AC File Offset: 0x00D4B9AC
		private void RemoveForgingDataByItemId(int itemId)
		{
			int index = this.ForgingDataList.FindIndex((IWeaponForgingData v) => v.ItemId == itemId);
			this.ForgingDataList.RemoveAt(index);
			this.ForgingDataMap.Remove(itemId);
		}

		// Token: 0x06038291 RID: 230033 RVA: 0x00D4D7FC File Offset: 0x00D4B9FC
		public bool CheckCanForging(int id)
		{
			IWeaponForgingData forgingDataById = this.GetForgingDataById(id);
			return this.CheckUnlock(forgingDataById) && this.CheckLimitCount(forgingDataById) && this.CheckCoinEnough(forgingDataById.ItemId) && this.CheckMaterialEnough(forgingDataById.ItemId);
		}

		// Token: 0x06038292 RID: 230034 RVA: 0x00D4D840 File Offset: 0x00D4BA40
		public bool CheckCoinEnough(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return InventoryModel.Instance.CheckIsCoinEnough(ForgingController.Instance.ForgingCostId, forgeFormulaById.Value.ConsumeItems());
		}

		// Token: 0x06038293 RID: 230035 RVA: 0x00D4D87C File Offset: 0x00D4BA7C
		public bool CheckLimitCount(IWeaponForgingData data)
		{
			return data.TotalMakeCountInLimitTime <= 0 || data.MadeCountInLimitTime < data.TotalMakeCountInLimitTime;
		}

		// Token: 0x06038294 RID: 230036 RVA: 0x00D4D897 File Offset: 0x00D4BA97
		public bool CheckUnlock(IWeaponForgingData data)
		{
			return data.IsUnlock > 0;
		}

		// Token: 0x06038295 RID: 230037 RVA: 0x00D4D8A4 File Offset: 0x00D4BAA4
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

		// Token: 0x06038296 RID: 230038 RVA: 0x00D4D908 File Offset: 0x00D4BB08
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

		// Token: 0x06038297 RID: 230039 RVA: 0x00D4D9D8 File Offset: 0x00D4BBD8
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

		// Token: 0x06038298 RID: 230040 RVA: 0x00D4DA94 File Offset: 0x00D4BC94
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IWeaponForgingData> GetForgingDataList()
		{
			return this.ForgingDataList;
		}

		// Token: 0x06038299 RID: 230041 RVA: 0x00D4DA9C File Offset: 0x00D4BC9C
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

		// Token: 0x0603829A RID: 230042 RVA: 0x00D4DABC File Offset: 0x00D4BCBC
		public int GetForgingRoleId(int itemId)
		{
			IWeaponForgingData forgingDataById = this.GetForgingDataById(itemId);
			if (forgingDataById != null && forgingDataById.LastRoleId > 0)
			{
				return forgingDataById.LastRoleId;
			}
			return PlayerInfoModel.Instance.GetPlayerRoleId();
		}

		// Token: 0x0603829B RID: 230043 RVA: 0x00D4DAF0 File Offset: 0x00D4BCF0
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

		// Token: 0x0603829C RID: 230044 RVA: 0x00D4DB64 File Offset: 0x00D4BD64
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

		// Token: 0x0603829D RID: 230045 RVA: 0x00D4DBEC File Offset: 0x00D4BDEC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetForgingItemList()
		{
			return this.ForgingItemList;
		}

		// Token: 0x1700873D RID: 34621
		// (get) Token: 0x0603829E RID: 230046 RVA: 0x00D4DBF4 File Offset: 0x00D4BDF4
		// (set) Token: 0x0603829F RID: 230047 RVA: 0x00D4DBFC File Offset: 0x00D4BDFC
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

		// Token: 0x060382A0 RID: 230048 RVA: 0x00D4DC08 File Offset: 0x00D4BE08
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

		// Token: 0x060382A1 RID: 230049 RVA: 0x00D4DC9C File Offset: 0x00D4BE9C
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

		// Token: 0x060382A2 RID: 230050 RVA: 0x00D4DD34 File Offset: 0x00D4BF34
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

		// Token: 0x1700873E RID: 34622
		// (get) Token: 0x060382A3 RID: 230051 RVA: 0x00D4DD5D File Offset: 0x00D4BF5D
		public static ForgingModel Instance
		{
			get
			{
				return ForgingModel._Instance;
			}
		}

		// Token: 0x060382A4 RID: 230052 RVA: 0x00D4DD64 File Offset: 0x00D4BF64
		public static ForgingModel GetOrCreateInstance()
		{
			if (ForgingModel._Instance == null)
			{
				ForgingModel.CreateInstance();
			}
			return ForgingModel._Instance;
		}

		// Token: 0x060382A5 RID: 230053 RVA: 0x00D4DD78 File Offset: 0x00D4BF78
		public static bool CreateInstance()
		{
			if (ForgingModel._Instance != null)
			{
				return true;
			}
			ForgingModel._Instance = new ForgingModel();
			return true;
		}

		// Token: 0x060382A6 RID: 230054 RVA: 0x00D4DD8E File Offset: 0x00D4BF8E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060382A7 RID: 230055 RVA: 0x00D4DD90 File Offset: 0x00D4BF90
		public static void ResetStaticDefaultValue()
		{
			ForgingModel._Instance = null;
		}

		// Token: 0x060382A8 RID: 230056 RVA: 0x00D4DD98 File Offset: 0x00D4BF98
		static ForgingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingModel.CreateStaticDefaultValue), new Action(ForgingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D8A2 RID: 120994
		private double LimitRefreshTime = -1.0;

		// Token: 0x0401D8A3 RID: 120995
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x0401D8A4 RID: 120996
		private EForgingViewType ForgingViewType;

		// Token: 0x0401D8A5 RID: 120997
		[Nullable(2)]
		public PlayFlow ForgingEnterFlow;

		// Token: 0x0401D8A6 RID: 120998
		[Nullable(2)]
		public PlayFlow ForgingSuccessFlow;

		// Token: 0x0401D8A7 RID: 120999
		[Nullable(2)]
		public PlayFlow ForgingFailFlow;

		// Token: 0x0401D8A8 RID: 121000
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IWeaponForgingData> ForgingDataList;

		// Token: 0x0401D8A9 RID: 121001
		private readonly Dictionary<int, IWeaponForgingData> ForgingDataMap = new Dictionary<int, IWeaponForgingData>();

		// Token: 0x0401D8AA RID: 121002
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonPopItemData> ForgingItemList;

		// Token: 0x0401D8AB RID: 121003
		private int ForgingRoleId;

		// Token: 0x0401D8AC RID: 121004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> ForgingRoleItemDataList;

		// Token: 0x0401D8AD RID: 121005
		[Nullable(2)]
		private static ForgingModel _Instance;
	}
}
