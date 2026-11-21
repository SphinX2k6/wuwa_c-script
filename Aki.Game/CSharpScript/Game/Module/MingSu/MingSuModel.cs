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
	// Token: 0x020043B7 RID: 17335
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MingSuModel : ModelBase
	{
		// Token: 0x0602BCAD RID: 179373 RVA: 0x00C4BB46 File Offset: 0x00C49D46
		protected override bool OnInit()
		{
			this.InitData();
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			return true;
		}

		// Token: 0x0602BCAE RID: 179374 RVA: 0x00C4BB6B File Offset: 0x00C49D6B
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			return true;
		}

		// Token: 0x0602BCAF RID: 179375 RVA: 0x00C4BB8A File Offset: 0x00C49D8A
		public void InitData()
		{
			this.InitMingSuMap();
			this.InitDragonPoolCompositeRewardIdSet();
			this.InitMingSuItemIdSet();
		}

		// Token: 0x0602BCB0 RID: 179376 RVA: 0x00C4BB9E File Offset: 0x00C49D9E
		public bool IsIdInDragonPoolCompositeRewardIdSet(int id)
		{
			return this.IsDragonPoolCompositeRewardIdSet.Contains(id);
		}

		// Token: 0x0602BCB1 RID: 179377 RVA: 0x00C4BBAC File Offset: 0x00C49DAC
		public void SetCurrentDragonPoolId(int dragonPoolId)
		{
			this.CurrentDragonPoolId = dragonPoolId;
		}

		// Token: 0x0602BCB2 RID: 179378 RVA: 0x00C4BBB5 File Offset: 0x00C49DB5
		public int GetCurrentDragonPoolId()
		{
			return this.CurrentDragonPoolId;
		}

		// Token: 0x0602BCB3 RID: 179379 RVA: 0x00C4BBBD File Offset: 0x00C49DBD
		public void SetCollectItemConfigId(int itemConfigId)
		{
			this.CollectItemConfigId = itemConfigId;
		}

		// Token: 0x0602BCB4 RID: 179380 RVA: 0x00C4BBC6 File Offset: 0x00C49DC6
		public int GetCollectItemConfigId()
		{
			return this.CollectItemConfigId;
		}

		// Token: 0x0602BCB5 RID: 179381 RVA: 0x00C4BBD0 File Offset: 0x00C49DD0
		public void RefreshDragonPoolActiveStatus(int dragonPoolId, int finishedLevel)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetDragonPoolState(finishedLevel);
			}
		}

		// Token: 0x0602BCB6 RID: 179382 RVA: 0x00C4BBF4 File Offset: 0x00C49DF4
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

		// Token: 0x0602BCB7 RID: 179383 RVA: 0x00C4BC4C File Offset: 0x00C49E4C
		public void RefreshDarkCoastGuardInfo(int dragonPoolId, int[] guardIds, int[] receivedList)
		{
			DarkCoastDeliveryData darkCoastDeliveryData = this.GetDragonPoolInstanceById(dragonPoolId) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return;
			}
			darkCoastDeliveryData.RefreshLevelDataState(guardIds, receivedList);
		}

		// Token: 0x0602BCB8 RID: 179384 RVA: 0x00C4BC74 File Offset: 0x00C49E74
		public void RefreshDragonPoolLevel(int dragonPoolId, int level)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetDragonPoolLevel(level);
			}
		}

		// Token: 0x0602BCB9 RID: 179385 RVA: 0x00C4BC98 File Offset: 0x00C49E98
		public void RefreshDragonPoolHadCoreCount(int dragonPoolId, int coreCount)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetHadCoreCount(coreCount);
			}
		}

		// Token: 0x0602BCBA RID: 179386 RVA: 0x00C4BCBC File Offset: 0x00C49EBC
		public void RefreshDragonPoolLevelGains(int dragonPoolId, int levelGain)
		{
			MingSuInstance mingSuInstance;
			if (this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out mingSuInstance))
			{
				mingSuInstance.SetLevelGainList(levelGain);
			}
		}

		// Token: 0x0602BCBB RID: 179387 RVA: 0x00C4BCE0 File Offset: 0x00C49EE0
		public void UpdateDragonPoolInfoMap(RepeatedField<DragonPoolInfo> dragonPoolInfoList)
		{
			for (int i = 0; i < dragonPoolInfoList.Count; i++)
			{
				this.DoUpdateDragonPoolInfoMap(dragonPoolInfoList[i]);
			}
		}

		// Token: 0x0602BCBC RID: 179388 RVA: 0x00C4BD0B File Offset: 0x00C49F0B
		public void DoUpdateDragonPoolInfoMap(DragonPoolInfo dragonPoolInfo)
		{
			this.RefreshDragonPoolActiveStatus(dragonPoolInfo.DragonPoolId, dragonPoolInfo.LevelGains);
			this.RefreshDragonPoolLevel(dragonPoolInfo.DragonPoolId, dragonPoolInfo.Level);
			this.RefreshDragonPoolHadCoreCount(dragonPoolInfo.DragonPoolId, dragonPoolInfo.InjectedCoreItemCount);
		}

		// Token: 0x0602BCBD RID: 179389 RVA: 0x00C4BD44 File Offset: 0x00C49F44
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

		// Token: 0x0602BCBE RID: 179390 RVA: 0x00C4BD98 File Offset: 0x00C49F98
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

		// Token: 0x0602BCBF RID: 179391 RVA: 0x00C4BDD8 File Offset: 0x00C49FD8
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

		// Token: 0x0602BCC0 RID: 179392 RVA: 0x00C4BE20 File Offset: 0x00C4A020
		private MingSuInstance GetMingSuInstanceById(int id)
		{
			if (id == 3)
			{
				return new DarkCoastDeliveryData(id);
			}
			return new MingSuInstance(id);
		}

		// Token: 0x0602BCC1 RID: 179393 RVA: 0x00C4BE34 File Offset: 0x00C4A034
		[NullableContext(2)]
		public MingSuInstance GetDragonPoolInstanceById(int dragonPoolId)
		{
			MingSuInstance result;
			this.DragonPoolInstanceMap.TryGetValue(dragonPoolId, out result);
			return result;
		}

		// Token: 0x0602BCC2 RID: 179394 RVA: 0x00C4BE54 File Offset: 0x00C4A054
		public int GetTargetDragonPoolLevelById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolLevel();
			}
			return 0;
		}

		// Token: 0x0602BCC3 RID: 179395 RVA: 0x00C4BE74 File Offset: 0x00C4A074
		public int GetTargetDragonPoolMaxLevelById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolMaxLevel();
			}
			return 0;
		}

		// Token: 0x0602BCC4 RID: 179396 RVA: 0x00C4BE94 File Offset: 0x00C4A094
		public int GetTargetDragonPoolCoreCountById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetHadCoreCount();
			}
			return 0;
		}

		// Token: 0x0602BCC5 RID: 179397 RVA: 0x00C4BEB4 File Offset: 0x00C4A0B4
		public int GetTargetDragonPoolLevelNeedCoreById(int dragonPoolId, int level)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetNeedCoreCount(level);
			}
			return 0;
		}

		// Token: 0x0602BCC6 RID: 179398 RVA: 0x00C4BED8 File Offset: 0x00C4A0D8
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

		// Token: 0x0602BCC7 RID: 179399 RVA: 0x00C4BF78 File Offset: 0x00C4A178
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

		// Token: 0x0602BCC8 RID: 179400 RVA: 0x00C4C000 File Offset: 0x00C4A200
		public int GetTargetDragonPoolCoreById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetCoreId();
			}
			return 0;
		}

		// Token: 0x0602BCC9 RID: 179401 RVA: 0x00C4C020 File Offset: 0x00C4A220
		public int GetTargetDragonPoolActiveById(int dragonPoolId)
		{
			MingSuInstance dragonPoolInstanceById = this.GetDragonPoolInstanceById(dragonPoolId);
			if (dragonPoolInstanceById != null)
			{
				return dragonPoolInstanceById.GetDragonPoolState();
			}
			return 0;
		}

		// Token: 0x0602BCCA RID: 179402 RVA: 0x00C4C040 File Offset: 0x00C4A240
		public int GetItemCount(int itemId)
		{
			return InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		}

		// Token: 0x0602BCCB RID: 179403 RVA: 0x00C4C04E File Offset: 0x00C4A24E
		public ItemInfo? GetItemInfoById(int itemId)
		{
			return ConfigItemInfoById.GetConfig(itemId, true);
		}

		// Token: 0x0602BCCC RID: 179404 RVA: 0x00C4C058 File Offset: 0x00C4A258
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

		// Token: 0x0602BCCD RID: 179405 RVA: 0x00C4C0AC File Offset: 0x00C4A2AC
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

		// Token: 0x0602BCCE RID: 179406 RVA: 0x00C4C168 File Offset: 0x00C4A368
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

		// Token: 0x0602BCCF RID: 179407 RVA: 0x00C4C1B0 File Offset: 0x00C4A3B0
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

		// Token: 0x0602BCD0 RID: 179408 RVA: 0x00C4C248 File Offset: 0x00C4A448
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

		// Token: 0x0602BCD1 RID: 179409 RVA: 0x00C4C28F File Offset: 0x00C4A48F
		[NullableContext(2)]
		public ConfirmBoxDataNew GetUpData()
		{
			return this.UpData;
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x0602BCD3 RID: 179411 RVA: 0x00C4C2A0 File Offset: 0x00C4A4A0
		// (set) Token: 0x0602BCD2 RID: 179410 RVA: 0x00C4C297 File Offset: 0x00C4A497
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

		// Token: 0x0602BCD4 RID: 179412 RVA: 0x00C4C2A8 File Offset: 0x00C4A4A8
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

		// Token: 0x0602BCD5 RID: 179413 RVA: 0x00C4C438 File Offset: 0x00C4A638
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

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x0602BCD6 RID: 179414 RVA: 0x00C4C4A3 File Offset: 0x00C4A6A3
		public static MingSuModel Instance
		{
			get
			{
				return MingSuModel._Instance;
			}
		}

		// Token: 0x0602BCD7 RID: 179415 RVA: 0x00C4C4AA File Offset: 0x00C4A6AA
		public static MingSuModel GetOrCreateInstance()
		{
			if (MingSuModel._Instance == null)
			{
				MingSuModel.CreateInstance();
			}
			return MingSuModel._Instance;
		}

		// Token: 0x0602BCD8 RID: 179416 RVA: 0x00C4C4BE File Offset: 0x00C4A6BE
		public static bool CreateInstance()
		{
			if (MingSuModel._Instance != null)
			{
				return true;
			}
			MingSuModel._Instance = new MingSuModel();
			return true;
		}

		// Token: 0x0602BCD9 RID: 179417 RVA: 0x00C4C4D4 File Offset: 0x00C4A6D4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BCDA RID: 179418 RVA: 0x00C4C4D6 File Offset: 0x00C4A6D6
		public static void ResetStaticDefaultValue()
		{
			MingSuModel._Instance = null;
		}

		// Token: 0x0602BCDB RID: 179419 RVA: 0x00C4C4DE File Offset: 0x00C4A6DE
		static MingSuModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MingSuModel.CreateStaticDefaultValue), new Action(MingSuModel.ResetStaticDefaultValue));
		}

		// Token: 0x040179BC RID: 96700
		private readonly Dictionary<int, MingSuInstance> DragonPoolInstanceMap = new Dictionary<int, MingSuInstance>();

		// Token: 0x040179BD RID: 96701
		private readonly HashSet<int> IsDragonPoolCompositeRewardIdSet = new HashSet<int>();

		// Token: 0x040179BE RID: 96702
		[Nullable(2)]
		private ConfirmBoxDataNew UpData;

		// Token: 0x040179BF RID: 96703
		private int CurrentDragonPoolId;

		// Token: 0x040179C0 RID: 96704
		[Nullable(2)]
		public object UpgradeFlow;

		// Token: 0x040179C1 RID: 96705
		public int CurrentPreviewLevel;

		// Token: 0x040179C2 RID: 96706
		private int CollectItemConfigId;

		// Token: 0x040179C3 RID: 96707
		public long? CurrentInteractCreatureDataLongId;

		// Token: 0x040179C4 RID: 96708
		private readonly HashSet<int> MingSuItemIdSet = new HashSet<int>();

		// Token: 0x040179C5 RID: 96709
		private int LastLevel;

		// Token: 0x040179C6 RID: 96710
		[Nullable(2)]
		private static MingSuModel _Instance;
	}
}
