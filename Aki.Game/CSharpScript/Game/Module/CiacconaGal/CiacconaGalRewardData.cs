using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB1 RID: 19377
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalRewardData
	{
		// Token: 0x06030608 RID: 198152 RVA: 0x00D7BBA8 File Offset: 0x00D79DA8
		public CiacconaGalRewardData(CiacconaActivityReward config)
		{
			this.Config = config;
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x06030609 RID: 198153 RVA: 0x00D7BBB8 File Offset: 0x00D79DB8
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x0603060A RID: 198154 RVA: 0x00D7BBD4 File Offset: 0x00D79DD4
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x0603060B RID: 198155 RVA: 0x00D7BBF0 File Offset: 0x00D79DF0
		public int RewardId
		{
			get
			{
				return this.Config.RewardId;
			}
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x0603060C RID: 198156 RVA: 0x00D7BC0C File Offset: 0x00D79E0C
		public TItem[] RewardItemDataList
		{
			get
			{
				List<TItem> list = new List<TItem>();
				DropPackage? config = ConfigDropPackageById.GetConfig(this.RewardId, true);
				if (config == null)
				{
					return list.ToArray();
				}
				foreach (KeyValuePair<int, int> keyValuePair in config.Value.DropPreview())
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int itemId = num;
					int count = num2;
					list.Add(new TItem
					{
						ItemData = new InventoryDefine.GetItemData(itemId, 0),
						Count = count
					});
				}
				return list.ToArray();
			}
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x0603060D RID: 198157 RVA: 0x00D7BCC8 File Offset: 0x00D79EC8
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x0603060E RID: 198158 RVA: 0x00D7BCE4 File Offset: 0x00D79EE4
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x0603060F RID: 198159 RVA: 0x00D7BCFF File Offset: 0x00D79EFF
		public bool CanReceive
		{
			get
			{
				return this.CanReceiveInternal;
			}
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x06030610 RID: 198160 RVA: 0x00D7BD07 File Offset: 0x00D79F07
		public bool IsReceived
		{
			get
			{
				return this.IsReceivedInternal;
			}
		}

		// Token: 0x06030611 RID: 198161 RVA: 0x00D7BD0F File Offset: 0x00D79F0F
		public void UpdateByServerData(CiacconaScheduleRewardPbData data)
		{
			this.CanReceiveInternal = data.CanReward;
			this.IsReceivedInternal = data.TakeReward;
		}

		// Token: 0x04019A25 RID: 104997
		private bool IsReceivedInternal;

		// Token: 0x04019A26 RID: 104998
		private bool CanReceiveInternal;

		// Token: 0x04019A27 RID: 104999
		private readonly CiacconaActivityReward Config;
	}
}
