using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C1 RID: 14785
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSpecialRewardData
	{
		// Token: 0x0602617A RID: 156026 RVA: 0x00AAF882 File Offset: 0x00AADA82
		public static TrapDefenseSpecialRewardData Create(TrapDefenseSpecialReward config)
		{
			TrapDefenseSpecialRewardData trapDefenseSpecialRewardData = new TrapDefenseSpecialRewardData();
			trapDefenseSpecialRewardData.Config = config;
			trapDefenseSpecialRewardData.Init();
			return trapDefenseSpecialRewardData;
		}

		// Token: 0x0602617B RID: 156027 RVA: 0x00AAF896 File Offset: 0x00AADA96
		public void UpdateByServerData(TrapDefenseRewardInfo serverData)
		{
			this.State = TrapDefenseDefine.trapDefenseRewardServerState2ClientState[serverData.TaskInfo.Status];
			this.CurrentProgress = serverData.TaskInfo.Current;
			this.TotalProgress = serverData.TaskInfo.Target;
		}

		// Token: 0x0602617C RID: 156028 RVA: 0x00AAF8D5 File Offset: 0x00AADAD5
		private void Init()
		{
			this.Id = this.Config.Id;
			this.Desc = this.Config.Desc;
			this.InitRewardItemList();
		}

		// Token: 0x0602617D RID: 156029 RVA: 0x00AAF900 File Offset: 0x00AADB00
		private void InitRewardItemList()
		{
			this.ItemList.Clear();
			DropPackage? config = ConfigDropPackageById.GetConfig(this.Config.RewardId, true);
			if (config == null)
			{
				return;
			}
			foreach (DicIntInt dicIntInt in config.Value.DropPreviewIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				this.ItemList.Add(new TItem
				{
					ItemData = new InventoryDefine.GetItemData(key, 0),
					Count = value
				});
			}
		}

		// Token: 0x04014E99 RID: 85657
		private TrapDefenseSpecialReward Config;

		// Token: 0x04014E9A RID: 85658
		public int Id;

		// Token: 0x04014E9B RID: 85659
		public string Desc = "";

		// Token: 0x04014E9C RID: 85660
		public List<TItem> ItemList = new List<TItem>();

		// Token: 0x04014E9D RID: 85661
		public int CurrentProgress;

		// Token: 0x04014E9E RID: 85662
		public int TotalProgress;

		// Token: 0x04014E9F RID: 85663
		public ETrapDefenseRewardState State = ETrapDefenseRewardState.InProgress;
	}
}
