using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D1 RID: 22737
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolInventoryData : SolarSchoolRecordBase
	{
		// Token: 0x17006B67 RID: 27495
		// (get) Token: 0x06037FDA RID: 229338 RVA: 0x00FA684B File Offset: 0x00FA4A4B
		public IReadOnlyDictionary<int, SolarSchoolItemData> Items
		{
			get
			{
				return this.itemMap;
			}
		}

		// Token: 0x06037FDB RID: 229339 RVA: 0x00FA6853 File Offset: 0x00FA4A53
		[NullableContext(2)]
		public SolarSchoolItemData GetItemData(int itemId)
		{
			return this.itemMap.GetValueOrDefault(itemId);
		}

		// Token: 0x06037FDC RID: 229340 RVA: 0x00FA6861 File Offset: 0x00FA4A61
		public int GetItemCount(int itemId)
		{
			SolarSchoolItemData itemData = this.GetItemData(itemId);
			if (itemData == null)
			{
				return 0;
			}
			return itemData.Count;
		}

		// Token: 0x06037FDD RID: 229341 RVA: 0x00FA6875 File Offset: 0x00FA4A75
		public bool HasAcquiredItem(int itemId)
		{
			return this.acquiredItemIds.Contains(itemId);
		}

		// Token: 0x06037FDE RID: 229342 RVA: 0x00FA6883 File Offset: 0x00FA4A83
		public bool CanAddItem(int itemId, int value, int stackLimit)
		{
			return value > 0 && (long)this.GetItemCount(itemId) + (long)value <= (long)stackLimit;
		}

		// Token: 0x06037FDF RID: 229343 RVA: 0x00FA689D File Offset: 0x00FA4A9D
		public void AddInheritedItem(int itemId, int count)
		{
			if (count <= 0)
			{
				return;
			}
			this.itemMap[itemId] = new SolarSchoolItemData(itemId, count);
			this.acquiredItemIds.Add(itemId);
		}

		// Token: 0x06037FE0 RID: 229344 RVA: 0x00FA68C4 File Offset: 0x00FA4AC4
		public int AddItem(int itemId, int value, int stackLimit, out bool firstAcquired)
		{
			firstAcquired = false;
			int itemCount = this.GetItemCount(itemId);
			int num = (int)Math.Clamp((long)itemCount + (long)value, 0L, (long)stackLimit);
			if (num == itemCount)
			{
				return num;
			}
			SolarSchoolItemData solarSchoolItemData;
			if (num == 0)
			{
				this.itemMap.Remove(itemId);
			}
			else if (this.itemMap.TryGetValue(itemId, out solarSchoolItemData))
			{
				solarSchoolItemData.SetCount(num);
			}
			else
			{
				this.itemMap.Add(itemId, new SolarSchoolItemData(itemId, num));
			}
			firstAcquired = (num > itemCount && this.acquiredItemIds.Add(itemId));
			SolarSchoolController.Instance.EnqueueItemChange(itemId, num - itemCount);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolItemChanged, itemId);
			return num;
		}

		// Token: 0x06037FE1 RID: 229345 RVA: 0x00FA6968 File Offset: 0x00FA4B68
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolInventoryDataPb solarSchoolInventoryDataPb = SolarSchoolInventoryDataPb.Create();
			foreach (KeyValuePair<int, SolarSchoolItemData> keyValuePair in this.itemMap)
			{
				SolarSchoolIdCountPb solarSchoolIdCountPb = SolarSchoolIdCountPb.Create();
				solarSchoolIdCountPb.Id = keyValuePair.Key;
				solarSchoolIdCountPb.Count = keyValuePair.Value.Count;
				solarSchoolInventoryDataPb.Items.Add(solarSchoolIdCountPb);
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolItem solarSchoolItem in SolarSchoolConfig.Instance.GetItemListByActivityId(activityId))
			{
				if (this.acquiredItemIds.Contains(solarSchoolItem.Id))
				{
					SolarSchoolUtils.SetSaveBit(solarSchoolInventoryDataPb.GotItemBit, solarSchoolItem.BitFlag);
				}
			}
			gameData.Inventory = solarSchoolInventoryDataPb;
		}

		// Token: 0x06037FE2 RID: 229346 RVA: 0x00FA6A68 File Offset: 0x00FA4C68
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.itemMap.Clear();
			this.acquiredItemIds.Clear();
			if (gameData.Inventory == null)
			{
				return;
			}
			foreach (SolarSchoolIdCountPb solarSchoolIdCountPb in gameData.Inventory.Items)
			{
				if (solarSchoolIdCountPb.Count > 0)
				{
					this.itemMap[solarSchoolIdCountPb.Id] = new SolarSchoolItemData(solarSchoolIdCountPb.Id, solarSchoolIdCountPb.Count);
				}
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolItem solarSchoolItem in SolarSchoolConfig.Instance.GetItemListByActivityId(activityId))
			{
				if (SolarSchoolUtils.GetSaveBit(gameData.Inventory.GotItemBit, solarSchoolItem.BitFlag))
				{
					this.acquiredItemIds.Add(solarSchoolItem.Id);
				}
			}
		}

		// Token: 0x0401D877 RID: 120951
		private readonly Dictionary<int, SolarSchoolItemData> itemMap = new Dictionary<int, SolarSchoolItemData>();

		// Token: 0x0401D878 RID: 120952
		private readonly HashSet<int> acquiredItemIds = new HashSet<int>();
	}
}
