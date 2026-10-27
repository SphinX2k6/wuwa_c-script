using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Plot.Flow;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053D4 RID: 21460
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MingSuModel : ModelBase
	{
		// Token: 0x06036D66 RID: 224614 RVA: 0x00CFCA7A File Offset: 0x00CFAC7A
		protected override bool OnInit()
		{
			this.InitData();
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			return true;
		}

		// Token: 0x06036D67 RID: 224615 RVA: 0x00CFCA9F File Offset: 0x00CFAC9F
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			return true;
		}

		// Token: 0x06036D68 RID: 224616 RVA: 0x00CFCABE File Offset: 0x00CFACBE
		public void InitData()
		{
			this.InitMingSuMap();
			this.InitDragonPoolCompositeRewardIdSet();
			this.InitMingSuItemIdSet();
		}

		// Token: 0x06036D69 RID: 224617 RVA: 0x00CFCAD2 File Offset: 0x00CFACD2
		public bool IsIdInDragonPoolCompositeRewardIdSet(int id)
		{
			return this.IsDragonPoolCompositeRewardIdSet.Contains(id);
		}

		// Token: 0x06036D6A RID: 224618 RVA: 0x00CFCAE0 File Offset: 0x00CFACE0
		public void SetCurrentDragonPoolId(int dragonPoolId)
		{
			this.CurrentDragonPoolId = dragonPoolId;
		}

		// Token: 0x06036D6B RID: 224619 RVA: 0x00CFCAE9 File Offset: 0x00CFACE9
		public int GetCurrentDragonPoolId()
		{
			return this.CurrentDragonPoolId;
		}

		// Token: 0x06036D6C RID: 224620 RVA: 0x00CFCAF1 File Offset: 0x00CFACF1
		public void SetCollectItemConfigId(int itemConfigId)
		{
			this.CollectItemConfigId = itemConfigId;
		}

		// Token: 0x06036D6D RID: 224621 RVA: 0x00CFCAFA File Offset: 0x00CFACFA
		public int GetCollectItemConfigId()
		{
			return this.CollectItemConfigId;
		}

		// Token: 0x06036D6E RID: 224622 RVA: 0x00CFCB04 File Offset: 0x00CFAD04
		public void RefreshDragonPoolActiveStatus(int dragonPoolId, int finishedLevel)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetDragonPoolState(finishedLevel);
			}
		}

		// Token: 0x06036D6F RID: 224623 RVA: 0x00CFCB28 File Offset: 0x00CFAD28
		public void RefreshDragonPoolDropItems(DragonPoolConf dragonPoolConf)
		{
			MingSuInstance mingSuInstance;
			if (!this.DragonPoolInstanceMap.TryGetValue(dragonPoolConf.DragonPoolId, out mingSuInstance))
			{
				return;
			}
			RepeatedField<ItemDict> dropItems = dragonPoolConf.DropItems;
			ItemDict[] array = new ItemDict[dropItems.Count];
			for (int i = 0; i < dropItems.Count; i++)
			{
				array[i] = dropItems[i];
			}
			mingSuInstance.SetDropItemList(array);
		}

		// Token: 0x06036D70 RID: 224624 RVA: 0x00CFCB80 File Offset: 0x00CFAD80
		public void RefreshDarkCoastGuardInfo(int dragonPoolId, int[] guardIds, int[] receivedList)
		{
			DarkCoastDeliveryData darkCoastDeliveryData = this.GetDragonPoolInstanceById(dragonPoolId) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return;
			}
			darkCoastDeliveryData.RefreshLevelDataState(guardIds, receivedList);
		}

		// Token: 0x06036D71 RID: 224625 RVA: 0x00CFCBA8 File Offset: 0x00CFADA8
		public void RefreshDragonPoolLevel(int dragonPoolId, int level)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetDragonPoolLevel(level);
			}
		}

		// Token: 0x06036D72 RID: 224626 RVA: 0x00CFCBCC File Offset: 0x00CFADCC
		public void RefreshDragonPoolHadCoreCount(int dragonPoolId, int coreCount)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetHadCoreCount(coreCount);
			}
		}

		// Token: 0x06036D73 RID: 224627 RVA: 0x00CFCBF0 File Offset: 0x00CFADF0
		public void RefreshDragonPoolLevelGains(int dragonPoolId, int levelGain)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetLevelGainList(levelGain);
			}
		}

		// Token: 0x06036D74 RID: 224628 RVA: 0x00CFCC14 File Offset: 0x00CFAE14
		public void UpdateDragonPoolInfoMap(RepeatedField<DragonPoolInfo> dragonPoolInfoList)
		{
			for (int i = 0; i < dragonPoolInfoList.Count; i++)
			{
				this.DoUpdateDragonPoolInfoMap(dragonPoolInfoList[i]);
			}
		}

		// Token: 0x06036D75 RID: 224629 RVA: 0x00CFCC3F File Offset: 0x00CFAE3F
		public void DoUpdateDragonPoolInfoMap(DragonPoolInfo dragonPoolInfo)
		{
			this.RefreshDragonPoolActiveStatus(dragonPoolInfo.DragonPoolId, dragonPoolInfo.LevelGains);
			this.RefreshDragonPoolLevel(dragonPoolInfo.DragonPoolId, dragonPoolInfo.Level);
			this.RefreshDragonPoolHadCoreCount(dragonPoolInfo.DragonPoolId, dragonPoolInfo.InjectedCoreItemCount);
		}

		// Token: 0x06036D76 RID: 224630 RVA: 0x00CFCC78 File Offset: 0x00CFAE78
		private void InitMingSuMap()
		{
			IReadOnlyList<DragonPool> configList = ConfigDragonPoolAll.GetConfigList(true);
			if (configList != null)
			{
				for (int i = 0; i < configList.Count; i++)
				{
					DragonPool dragonPool = configList[i];
					MingSuInstance mingSuInstanceById = this.GetMingSuInstanceById(dragonPool.Id);
					this.DragonPoolInstanceMap[dragonPool.Id] = mingSuInstanceById;
				}
			}
		}

		// Token: 0x06036D77 RID: 224631 RVA: 0x00CFCCCC File Offset: 0x00CFAECC
		private void InitDragonPoolCompositeRewardIdSet()
		{
			List<int> isDragonPoolCompositeRewardIdList = CollectItemConfig.Instance.GetIsDragonPoolCompositeRewardIdList();
			if (isDragonPoolCompositeRewardIdList == null)
			{
				return;
			}
			for (int i = 0; i < isDragonPoolCompositeRewardIdList.Count; i++)
			{
				this.IsDragonPoolCompositeRewardIdSet.Add(isDragonPoolCompositeRewardIdList[i]);
			}
		}

		// Token: 0x06036D78 RID: 224632 RVA: 0x00CFCD0C File Offset: 0x00CFAF0C
		private void InitMingSuItemIdSet()
		{
			IReadOnlyList<DragonPool> allDragonPoolConfigList = CollectItemConfig.Instance.GetAllDragonPoolConfigList();
			if (allDragonPoolConfigList == null)
			{
				return;
			}
			for (int i = 0; i < allDragonPoolConfigList.Count; i++)
			{
				DragonPool dragonPool = allDragonPoolConfigList[i];
				this.MingSuItemIdSet.Add(dragonPool.CoreId);
			}
		}

		// Token: 0x06036D79 RID: 224633 RVA: 0x00CFCD54 File Offset: 0x00CFAF54
		private MingSuInstance GetMingSuInstanceById(int id)
		{
			if (id == 3)
			{
				return new DarkCoastDeliveryData(id);
			}
			return new MingSuInstance(id);
		}

		// Token: 0x06036D7A RID: 224634 RVA: 0x00CFCD68 File Offset: 0x00CFAF68
		[NullableContext(2)]
		public MingSuInstance GetDragonPoolInstanceById(int dragonPoolId)
		{
			MingSuInstance result;
			this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out result);
			return result;
		}

		// Token: 0x06036D7B RID: 224635 RVA: 0x00CFCD88 File Offset: 0x00CFAF88
		public int GetTargetDragonPoolLevelById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolLevel();
			}
			return 0;
		}

		// Token: 0x06036D7C RID: 224636 RVA: 0x00CFCDA8 File Offset: 0x00CFAFA8
		public int GetTargetDragonPoolMaxLevelById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolMaxLevel();
			}
			return 0;
		}

		// Token: 0x06036D7D RID: 224637 RVA: 0x00CFCDC8 File Offset: 0x00CFAFC8
		public int GetTargetDragonPoolCoreCountById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetHadCoreCount();
			}
			return 0;
		}

		// Token: 0x06036D7E RID: 224638 RVA: 0x00CFCDE8 File Offset: 0x00CFAFE8
		public int GetTargetDragonPoolLevelNeedCoreById(int dragonPoolId, int level)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetNeedCoreCount(level);
			}
			return 0;
		}

		// Token: 0x06036D7F RID: 224639 RVA: 0x00CFCE0C File Offset: 0x00CFB00C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardItemData> GetTargetDragonPoolLevelRewardById(int dragonPoolId, int level)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById == null)
			{
				return null;
			}
			ItemDict[] dropItemList = dragonPoolInstanceById.GetDropItemList();
			if (dropItemList == null || dropItemList.Length <= level)
			{
				return null;
			}
			RepeatedField<ItemEntry> items = dropItemList[level].Items;
			if (items == null || items.Count == 0)
			{
				return null;
			}
			List<IRewardItemData> list = new List<IRewardItemData>();
			for (int i = 0; i < items.Count; i++)
			{
				ItemEntry itemEntry = items[i];
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemEntry.ItemId);
				if (itemConfigData != null)
				{
					list.Add(new RewardItemData
					{
						ItemInfo = itemConfigData,
						Count = itemEntry.ItemCount
					});
				}
			}
			return list;
		}

		// Token: 0x06036D80 RID: 224640 RVA: 0x00CFCEAC File Offset: 0x00CFB0AC
		[NullableContext(2)]
		public List<TItem> GetTargetDragonPoolLevelRewardByIdEx(int dragonPoolId, int level)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById == null)
			{
				return null;
			}
			ItemDict[] dropItemList = dragonPoolInstanceById.GetDropItemList();
			if (dropItemList == null || dropItemList.Length <= level)
			{
				return null;
			}
			RepeatedField<ItemEntry> items = dropItemList[level].Items;
			if (items == null || items.Count == 0)
			{
				return null;
			}
			List<TItem> list = new List<TItem>();
			for (int i = 0; i < items.Count; i++)
			{
				ItemEntry itemEntry = items[i];
				list.Add(new TItem(new InventoryDefine.GetItemData(itemEntry.ItemId, 0), itemEntry.ItemCount));
			}
			return list;
		}

		// Token: 0x06036D81 RID: 224641 RVA: 0x00CFCF34 File Offset: 0x00CFB134
		public int GetTargetDragonPoolCoreById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetCoreId();
			}
			return 0;
		}

		// Token: 0x06036D82 RID: 224642 RVA: 0x00CFCF54 File Offset: 0x00CFB154
		public int GetTargetDragonPoolActiveById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolState();
			}
			return 0;
		}

		// Token: 0x06036D83 RID: 224643 RVA: 0x00CFCF74 File Offset: 0x00CFB174
		public int GetItemCount(int itemId)
		{
			return InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		}

		// Token: 0x06036D84 RID: 224644 RVA: 0x00CFCF82 File Offset: 0x00CFB182
		public ItemInfo? GetItemInfoById(int itemId)
		{
			return ConfigItemInfoById.GetConfig(itemId, true);
		}

		// Token: 0x06036D85 RID: 224645 RVA: 0x00CFCF8C File Offset: 0x00CFB18C
		[NullableContext(2)]
		public DarkCoastDeliveryLevelData GetDarkCoastDeliveryDataByLevelPlayId(int levelPlayId)
		{
			DarkCoastDeliveryData darkCoastDeliveryData = this.GetDragonPoolInstanceById(3) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return null;
			}
			List<DarkCoastDeliveryLevelData> levelDataList = darkCoastDeliveryData.GetLevelDataList();
			for (int i = 0; i < levelDataList.Count; i++)
			{
				DarkCoastDeliveryLevelData darkCoastDeliveryLevelData = levelDataList[i];
				if (darkCoastDeliveryLevelData.Config.LevelPlayId == levelPlayId)
				{
					return darkCoastDeliveryLevelData;
				}
			}
			return null;
		}

		// Token: 0x06036D86 RID: 224646 RVA: 0x00CFCFE0 File Offset: 0x00CFB1E0
		public bool CheckUp(int dragonPoolId)
		{
			int i = this.GetTargetDragonPoolLevelById(dragonPoolId);
			int[] goalList = this.GetDragonPoolInstanceById(dragonPoolId).GetGoalList();
			int targetDragonPoolMaxLevelById = this.GetTargetDragonPoolMaxLevelById(dragonPoolId);
			int targetDragonPoolCoreCountById = this.GetTargetDragonPoolCoreCountById(dragonPoolId);
			int num = 0;
			while (i < targetDragonPoolMaxLevelById)
			{
				int num2 = goalList[i];
				num += num2;
				i++;
			}
			num -= targetDragonPoolCoreCountById;
			int targetDragonPoolCoreById = this.GetTargetDragonPoolCoreById(dragonPoolId);
			int itemCount = this.GetItemCount(targetDragonPoolCoreById);
			ItemInfo? itemInfoById = this.GetItemInfoById(targetDragonPoolCoreById);
			if (itemCount == 0)
			{
				return false;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemInfoById.Value.Name, null);
			this.SetUpData(new UpData
			{
				UseCoreCount = ((itemCount >= num) ? num : itemCount),
				CoreName = (localTextNew ?? "")
			});
			return true;
		}

		// Token: 0x06036D87 RID: 224647 RVA: 0x00CFD09C File Offset: 0x00CFB29C
		public bool CanLevelUp(int dragonPoolId)
		{
			int targetDragonPoolLevelById = this.GetTargetDragonPoolLevelById(dragonPoolId);
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById == null)
			{
				return false;
			}
			int needCoreCount = dragonPoolInstanceById.GetNeedCoreCount(targetDragonPoolLevelById);
			int hadCoreCount = dragonPoolInstanceById.GetHadCoreCount();
			int itemCount = this.GetItemCount(dragonPoolInstanceById.GetCoreId());
			return hadCoreCount + itemCount >= needCoreCount;
		}

		// Token: 0x06036D88 RID: 224648 RVA: 0x00CFD0E4 File Offset: 0x00CFB2E4
		public int GetCanUpPoolId()
		{
			int result = 0;
			foreach (KeyValuePair<int, MingSuInstance> keyValuePair in this.DragonPoolInstanceMap)
			{
				int key = keyValuePair.Key;
				MingSuInstance value = keyValuePair.Value;
				int dragonPoolLevel = value.GetDragonPoolLevel();
				int num = value.GetNeedCoreCount(dragonPoolLevel) - value.GetHadCoreCount();
				int targetDragonPoolCoreById = this.GetTargetDragonPoolCoreById(key);
				if (this.GetItemCount(targetDragonPoolCoreById) >= num)
				{
					result = key;
					break;
				}
			}
			return result;
		}

		// Token: 0x06036D89 RID: 224649 RVA: 0x00CFD17C File Offset: 0x00CFB37C
		private void SetUpData(IUpData upData)
		{
			EConfirmBoxConfigId configId = EConfirmBoxConfigId.MingsuTip;
			this.UpData = new ConfirmBoxDataNew(configId);
			this.UpData.SetTextArgs(new string[]
			{
				upData.CoreName,
				upData.UseCoreCount.ToString()
			});
		}

		// Token: 0x06036D8A RID: 224650 RVA: 0x00CFD1C3 File Offset: 0x00CFB3C3
		[NullableContext(2)]
		public ConfirmBoxDataNew GetUpData()
		{
			return this.UpData;
		}

		// Token: 0x170083CA RID: 33738
		// (get) Token: 0x06036D8C RID: 224652 RVA: 0x00CFD1D4 File Offset: 0x00CFB3D4
		// (set) Token: 0x06036D8B RID: 224651 RVA: 0x00CFD1CB File Offset: 0x00CFB3CB
		public int MingSuLastLevel
		{
			get
			{
				return this.LastLevel;
			}
			set
			{
				this.LastLevel = value;
			}
		}

		// Token: 0x06036D8D RID: 224653 RVA: 0x00CFD1DC File Offset: 0x00CFB3DC
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (!this.MingSuItemIdSet.Contains(configId))
			{
				return;
			}
			DragonPool? dragonPoolConfigByCoreId = CollectItemConfig.Instance.GetDragonPoolConfigByCoreId(configId);
			if (dragonPoolConfigByCoreId == null)
			{
				return;
			}
			if (!this.CheckDragonPoolJustCanLevelUp(dragonPoolConfigByCoreId.Value.Id))
			{
				return;
			}
			if (dragonPoolConfigByCoreId.Value.QuestId == 0)
			{
				if (dragonPoolConfigByCoreId.Value.CanLevelUpTipsLength == 3)
				{
					string flowListName = dragonPoolConfigByCoreId.Value.CanLevelUpTips(0);
					int flowId = int.Parse(dragonPoolConfigByCoreId.Value.CanLevelUpTips(1));
					int stateId = int.Parse(dragonPoolConfigByCoreId.Value.CanLevelUpTips(2));
					FlowController.Instance.StartFlow(flowListName, flowId, stateId, null, 0L, false, false, false, null);
				}
				return;
			}
			int questState = (int)QuestNewModel.Instance.GetQuestState(dragonPoolConfigByCoreId.Value.QuestId);
			int[] plotStateListArray = dragonPoolConfigByCoreId.Value.GetPlotStateListArray();
			if (plotStateListArray == null || plotStateListArray.Length <= questState)
			{
				return;
			}
			int num = plotStateListArray[questState];
			if (num == 0)
			{
				return;
			}
			MingSuPlot? mingSuPlotConfigById = CollectItemConfig.Instance.GetMingSuPlotConfigById(num);
			if (mingSuPlotConfigById == null || mingSuPlotConfigById.Value.CanLevelUpTipsLength < 3)
			{
				return;
			}
			string flowListName2 = mingSuPlotConfigById.Value.CanLevelUpTips(0);
			int flowId2 = int.Parse(mingSuPlotConfigById.Value.CanLevelUpTips(1));
			int stateId2 = int.Parse(mingSuPlotConfigById.Value.CanLevelUpTips(2));
			FlowController.Instance.StartFlow(flowListName2, flowId2, stateId2, null, 0L, false, false, false, null);
		}

		// Token: 0x06036D8E RID: 224654 RVA: 0x00CFD36C File Offset: 0x00CFB56C
		private bool CheckDragonPoolJustCanLevelUp(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			int[] goalList = dragonPoolInstanceById.GetGoalList();
			int targetDragonPoolCoreCountById = this.GetTargetDragonPoolCoreCountById(dragonPoolId);
			int itemCount = this.GetItemCount(dragonPoolInstanceById.GetCoreId());
			int num = targetDragonPoolCoreCountById + itemCount;
			int targetDragonPoolMaxLevelById = this.GetTargetDragonPoolMaxLevelById(dragonPoolId);
			int targetDragonPoolLevelById = this.GetTargetDragonPoolLevelById(dragonPoolId);
			int num2 = 0;
			for (int i = targetDragonPoolLevelById; i < targetDragonPoolMaxLevelById; i++)
			{
				int num3 = goalList[i];
				num2 += num3;
				if (num == num2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x170083CB RID: 33739
		// (get) Token: 0x06036D8F RID: 224655 RVA: 0x00CFD3D7 File Offset: 0x00CFB5D7
		public static MingSuModel Instance
		{
			get
			{
				return MingSuModel._Instance;
			}
		}

		// Token: 0x06036D90 RID: 224656 RVA: 0x00CFD3DE File Offset: 0x00CFB5DE
		public static MingSuModel GetOrCreateInstance()
		{
			if (MingSuModel._Instance == null)
			{
				MingSuModel.CreateInstance();
			}
			return MingSuModel._Instance;
		}

		// Token: 0x06036D91 RID: 224657 RVA: 0x00CFD3F2 File Offset: 0x00CFB5F2
		public static bool CreateInstance()
		{
			if (MingSuModel._Instance != null)
			{
				return true;
			}
			MingSuModel._Instance = new MingSuModel();
			return true;
		}

		// Token: 0x06036D92 RID: 224658 RVA: 0x00CFD408 File Offset: 0x00CFB608
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036D93 RID: 224659 RVA: 0x00CFD40A File Offset: 0x00CFB60A
		public static void ResetStaticDefaultValue()
		{
			MingSuModel._Instance = null;
		}

		// Token: 0x06036D94 RID: 224660 RVA: 0x00CFD412 File Offset: 0x00CFB612
		static MingSuModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MingSuModel.CreateStaticDefaultValue), new Action(MingSuModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CF24 RID: 118564
		private readonly Dictionary<int, MingSuInstance> DragonPoolInstanceMap = new Dictionary<int, MingSuInstance>();

		// Token: 0x0401CF25 RID: 118565
		private readonly HashSet<int> IsDragonPoolCompositeRewardIdSet = new HashSet<int>();

		// Token: 0x0401CF26 RID: 118566
		[Nullable(2)]
		private ConfirmBoxDataNew UpData;

		// Token: 0x0401CF27 RID: 118567
		private int CurrentDragonPoolId;

		// Token: 0x0401CF28 RID: 118568
		[Nullable(2)]
		public object UpgradeFlow;

		// Token: 0x0401CF29 RID: 118569
		public int CurrentPreviewLevel;

		// Token: 0x0401CF2A RID: 118570
		private int CollectItemConfigId;

		// Token: 0x0401CF2B RID: 118571
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x0401CF2C RID: 118572
		private readonly HashSet<int> MingSuItemIdSet = new HashSet<int>();

		// Token: 0x0401CF2D RID: 118573
		private int LastLevel;

		// Token: 0x0401CF2E RID: 118574
		[Nullable(2)]
		private static MingSuModel _Instance;
	}
}
