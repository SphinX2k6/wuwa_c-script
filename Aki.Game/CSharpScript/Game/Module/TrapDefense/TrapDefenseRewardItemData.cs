using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A18 RID: 18968
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardItemData
	{
		// Token: 0x060313E4 RID: 201700 RVA: 0x00B6B5FD File Offset: 0x00B697FD
		public static TrapDefenseRewardItemData Create(TrapDefenseReward config)
		{
			TrapDefenseRewardItemData trapDefenseRewardItemData = new TrapDefenseRewardItemData();
			trapDefenseRewardItemData.Config = new TrapDefenseReward?(config);
			trapDefenseRewardItemData.Id = config.Id;
			trapDefenseRewardItemData.Init();
			return trapDefenseRewardItemData;
		}

		// Token: 0x060313E5 RID: 201701 RVA: 0x00B6B624 File Offset: 0x00B69824
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

		// Token: 0x060313E6 RID: 201702 RVA: 0x00B6B6F0 File Offset: 0x00B698F0
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

		// Token: 0x060313E7 RID: 201703 RVA: 0x00B6B754 File Offset: 0x00B69954
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

		// Token: 0x060313E8 RID: 201704 RVA: 0x00B6B7A8 File Offset: 0x00B699A8
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

		// Token: 0x0401A539 RID: 107833
		private TrapDefenseReward? Config;

		// Token: 0x0401A53A RID: 107834
		public int Id;

		// Token: 0x0401A53B RID: 107835
		public ETrapDefenseRewardType Type;

		// Token: 0x0401A53C RID: 107836
		public string Desc = "";

		// Token: 0x0401A53D RID: 107837
		public List<TItem> ItemList = new List<TItem>();

		// Token: 0x0401A53E RID: 107838
		public ETrapDefenseRewardState State;

		// Token: 0x0401A53F RID: 107839
		public double StartTime;

		// Token: 0x0401A540 RID: 107840
		public int CurProgress;

		// Token: 0x0401A541 RID: 107841
		public int Target;
	}
}
