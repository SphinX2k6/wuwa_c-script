using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD1 RID: 23505
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalRewardData
	{
		// Token: 0x0603B6BD RID: 243389 RVA: 0x00E2B8A0 File Offset: 0x00E29AA0
		public CiacconaGalRewardData(CiacconaActivityReward config)
		{
			this.Config = config;
		}

		// Token: 0x17008D39 RID: 36153
		// (get) Token: 0x0603B6BE RID: 243390 RVA: 0x00E2B8B0 File Offset: 0x00E29AB0
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D3A RID: 36154
		// (get) Token: 0x0603B6BF RID: 243391 RVA: 0x00E2B8CC File Offset: 0x00E29ACC
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x17008D3B RID: 36155
		// (get) Token: 0x0603B6C0 RID: 243392 RVA: 0x00E2B8E8 File Offset: 0x00E29AE8
		public int RewardId
		{
			get
			{
				return this.Config.RewardId;
			}
		}

		// Token: 0x17008D3C RID: 36156
		// (get) Token: 0x0603B6C1 RID: 243393 RVA: 0x00E2B904 File Offset: 0x00E29B04
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

		// Token: 0x17008D3D RID: 36157
		// (get) Token: 0x0603B6C2 RID: 243394 RVA: 0x00E2B9C0 File Offset: 0x00E29BC0
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17008D3E RID: 36158
		// (get) Token: 0x0603B6C3 RID: 243395 RVA: 0x00E2B9DC File Offset: 0x00E29BDC
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17008D3F RID: 36159
		// (get) Token: 0x0603B6C4 RID: 243396 RVA: 0x00E2B9F7 File Offset: 0x00E29BF7
		public bool CanReceive
		{
			get
			{
				return this.CanReceiveInternal;
			}
		}

		// Token: 0x17008D40 RID: 36160
		// (get) Token: 0x0603B6C5 RID: 243397 RVA: 0x00E2B9FF File Offset: 0x00E29BFF
		public bool IsReceived
		{
			get
			{
				return this.IsReceivedInternal;
			}
		}

		// Token: 0x0603B6C6 RID: 243398 RVA: 0x00E2BA07 File Offset: 0x00E29C07
		public void UpdateByServerData(CiacconaScheduleRewardPbData data)
		{
			this.CanReceiveInternal = data.CanReward;
			this.IsReceivedInternal = data.TakeReward;
		}

		// Token: 0x0401EF74 RID: 126836
		private bool IsReceivedInternal;

		// Token: 0x0401EF75 RID: 126837
		private bool CanReceiveInternal;

		// Token: 0x0401EF76 RID: 126838
		private readonly CiacconaActivityReward Config;
	}
}
