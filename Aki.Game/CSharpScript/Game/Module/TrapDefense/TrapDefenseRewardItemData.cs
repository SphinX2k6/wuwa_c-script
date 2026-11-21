using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C0 RID: 14784
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardItemData
	{
		// Token: 0x06026174 RID: 156020 RVA: 0x00AAF5F9 File Offset: 0x00AAD7F9
		public static TrapDefenseRewardItemData Create(TrapDefenseReward config)
		{
			TrapDefenseRewardItemData trapDefenseRewardItemData = new TrapDefenseRewardItemData();
			trapDefenseRewardItemData.Config = new TrapDefenseReward?(config);
			trapDefenseRewardItemData.Id = config.Id;
			trapDefenseRewardItemData.Init();
			return trapDefenseRewardItemData;
		}

		// Token: 0x06026175 RID: 156021 RVA: 0x00AAF620 File Offset: 0x00AAD820
		public void UpdateByServerData(TrapDefenseRewardInfo serverData)
		{
			ConditionTask taskInfo = serverData.TaskInfo;
			int? num = (taskInfo != null) ? new int?(taskInfo.Id) : null;
			int id = this.Id;
			if (!(num.GetValueOrDefault() == id & num != null))
			{
				return;
			}
			this.State = TrapDefenseDefine.trapDefenseRewardServerState2ClientState[taskInfo.Status];
			double startTime = (double)serverData.LimitBeginTime * TimeUtil.Instance.Millisecond;
			double endTime = (double)serverData.LimitEndTime * TimeUtil.Instance.Millisecond;
			if (!TimeUtil.Instance.IsInTimeSpan(startTime, endTime))
			{
				this.State = ETrapDefenseRewardState.Lock;
			}
			this.StartTime = startTime;
			this.CurProgress = ((taskInfo != null) ? taskInfo.Current : 0);
			this.Target = ((taskInfo != null) ? taskInfo.Target : 0);
		}

		// Token: 0x06026176 RID: 156022 RVA: 0x00AAF6EC File Offset: 0x00AAD8EC
		public string GetUnlockRemainTimeStr()
		{
			if (this.State != ETrapDefenseRewardState.Lock)
			{
				return "";
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = this.StartTime - serverTime;
			if (num <= 0.0)
			{
				return "";
			}
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(num);
			return ((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? "";
		}

		// Token: 0x06026177 RID: 156023 RVA: 0x00AAF750 File Offset: 0x00AAD950
		private void Init()
		{
			if (this.Config == null)
			{
				return;
			}
			this.Type = (ETrapDefenseRewardType)this.Config.Value.Type;
			this.Desc = this.Config.Value.Desc;
			this.InitRewardItemList();
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x00AAF7A4 File Offset: 0x00AAD9A4
		private void InitRewardItemList()
		{
			this.ItemList.Clear();
			DropPackage? config = ConfigDropPackageById.GetConfig(this.Config.Value.RewardId, true);
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

		// Token: 0x04014E90 RID: 85648
		private TrapDefenseReward? Config;

		// Token: 0x04014E91 RID: 85649
		public int Id;

		// Token: 0x04014E92 RID: 85650
		public ETrapDefenseRewardType Type;

		// Token: 0x04014E93 RID: 85651
		public string Desc = "";

		// Token: 0x04014E94 RID: 85652
		public List<TItem> ItemList = new List<TItem>();

		// Token: 0x04014E95 RID: 85653
		public ETrapDefenseRewardState State;

		// Token: 0x04014E96 RID: 85654
		public double StartTime;

		// Token: 0x04014E97 RID: 85655
		public int CurProgress;

		// Token: 0x04014E98 RID: 85656
		public int Target;
	}
}
