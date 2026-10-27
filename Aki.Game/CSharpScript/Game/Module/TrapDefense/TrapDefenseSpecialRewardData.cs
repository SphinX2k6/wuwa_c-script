using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A19 RID: 18969
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSpecialRewardData
	{
		// Token: 0x060313EA RID: 201706 RVA: 0x00B6B886 File Offset: 0x00B69A86
		public static TrapDefenseSpecialRewardData Create(TrapDefenseSpecialReward config)
		{
			TrapDefenseSpecialRewardData trapDefenseSpecialRewardData = new TrapDefenseSpecialRewardData();
			trapDefenseSpecialRewardData.Config = config;
			trapDefenseSpecialRewardData.Init();
			return trapDefenseSpecialRewardData;
		}

		// Token: 0x060313EB RID: 201707 RVA: 0x00B6B89A File Offset: 0x00B69A9A
		public void UpdateByServerData(TrapDefenseRewardInfo serverData)
		{
			this.State = TrapDefenseDefine.trapDefenseRewardServerState2ClientState[serverData.TaskInfo.Status];
			this.CurrentProgress = serverData.TaskInfo.Current;
			this.TotalProgress = serverData.TaskInfo.Target;
		}

		// Token: 0x060313EC RID: 201708 RVA: 0x00B6B8D9 File Offset: 0x00B69AD9
		private void Init()
		{
			this.Id = this.Config.Id;
			this.Desc = this.Config.Desc;
			this.InitRewardItemList();
		}

		// Token: 0x060313ED RID: 201709 RVA: 0x00B6B904 File Offset: 0x00B69B04
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

		// Token: 0x0401A542 RID: 107842
		private TrapDefenseSpecialReward Config;

		// Token: 0x0401A543 RID: 107843
		public int Id;

		// Token: 0x0401A544 RID: 107844
		public string Desc = "";

		// Token: 0x0401A545 RID: 107845
		public List<TItem> ItemList = new List<TItem>();

		// Token: 0x0401A546 RID: 107846
		public int CurrentProgress;

		// Token: 0x0401A547 RID: 107847
		public int TotalProgress;

		// Token: 0x0401A548 RID: 107848
		public ETrapDefenseRewardState State = ETrapDefenseRewardState.InProgress;
	}
}
