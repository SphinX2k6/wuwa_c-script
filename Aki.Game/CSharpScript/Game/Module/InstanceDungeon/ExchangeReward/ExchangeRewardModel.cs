using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x020058B6 RID: 22710
	[NullableContext(1)]
	[Nullable(0)]
	public class ExchangeRewardModel : ModelBase
	{
		// Token: 0x06039C07 RID: 236551 RVA: 0x00DB99E1 File Offset: 0x00DB7BE1
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06039C08 RID: 236552 RVA: 0x00DB99E4 File Offset: 0x00DB7BE4
		public void Phrase(ExchangeRewardInfoResponse message)
		{
			this.ExchangeRewardMap.Clear();
			this.ExchangeShareMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in message.SharedDict)
			{
				ExchangeShareData exchangeShareData = new ExchangeShareData();
				exchangeShareData.Phrase(keyValuePair.Key, keyValuePair.Value);
				this.ExchangeShareMap.Add(exchangeShareData.GetId(), exchangeShareData);
			}
			foreach (KeyValuePair<int, int> keyValuePair2 in message.ExchangeRewardDict)
			{
				ExchangeRewardData exchangeRewardData = new ExchangeRewardData();
				exchangeRewardData.Phrase(keyValuePair2.Key, keyValuePair2.Value);
				this.ExchangeRewardMap.Add(exchangeRewardData.GetId(), exchangeRewardData);
			}
		}

		// Token: 0x06039C09 RID: 236553 RVA: 0x00DB9AD4 File Offset: 0x00DB7CD4
		public void OnExchangeRewardNotify(ExchangeRewardInfoNotify message)
		{
			ExchangeRewardData exchangeRewardData;
			if (!this.ExchangeRewardMap.TryGetValue(message.ExchangeRewardId, out exchangeRewardData))
			{
				exchangeRewardData = new ExchangeRewardData();
				this.ExchangeRewardMap.Add(message.ExchangeRewardId, exchangeRewardData);
			}
			exchangeRewardData.Phrase(message.ExchangeRewardId, message.Count);
		}

		// Token: 0x06039C0A RID: 236554 RVA: 0x00DB9B20 File Offset: 0x00DB7D20
		public void OnShareInfoNotify(ExchangeSharedInfoNotify message)
		{
			foreach (KeyValuePair<int, int> keyValuePair in message.SharedUpdateDict)
			{
				int key = keyValuePair.Key;
				ExchangeShareData exchangeShareData;
				if (!this.ExchangeShareMap.TryGetValue(key, out exchangeShareData))
				{
					exchangeShareData = new ExchangeShareData();
					this.ExchangeShareMap.Add(key, exchangeShareData);
				}
				exchangeShareData.Phrase(key, keyValuePair.Value);
			}
		}

		// Token: 0x06039C0B RID: 236555 RVA: 0x00DB9BA0 File Offset: 0x00DB7DA0
		public bool GetInstanceDungeonIfCanExchange(int instanceDungeonId)
		{
			int rewardId = InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId).Value.RewardId;
			if (rewardId == 0)
			{
				return true;
			}
			int? exchangeShareId = ExchangeRewardConfig.Instance.GetExchangeShareId(rewardId);
			int? num = new int?(0);
			int num2;
			if (exchangeShareId != null && exchangeShareId.GetValueOrDefault() != 0)
			{
				num2 = ExchangeRewardConfig.Instance.GetShareMaxCount(exchangeShareId.Value);
				ExchangeShareData exchangeShareData;
				if (this.ExchangeShareMap.TryGetValue(exchangeShareId.Value, out exchangeShareData))
				{
					num = new int?(exchangeShareData.GetCount());
				}
			}
			else
			{
				num2 = ExchangeRewardConfig.Instance.GetExchangeRewardMaxCount(rewardId);
				ExchangeRewardData exchangeRewardData;
				if (this.ExchangeRewardMap.TryGetValue(rewardId, out exchangeRewardData))
				{
					num = new int?(exchangeRewardData.GetCount());
				}
			}
			return num2 == 0 || num.Value < num2;
		}

		// Token: 0x06039C0C RID: 236556 RVA: 0x00DB9C6C File Offset: 0x00DB7E6C
		public bool GetRewardIfCanExchange(int rewardId)
		{
			int? exchangeShareId = ExchangeRewardConfig.Instance.GetExchangeShareId(rewardId);
			int? num = new int?(0);
			int num2;
			if (exchangeShareId != null && exchangeShareId.GetValueOrDefault() != 0)
			{
				num2 = ExchangeRewardConfig.Instance.GetShareMaxCount(exchangeShareId.Value);
				ExchangeShareData exchangeShareData;
				if (this.ExchangeShareMap.TryGetValue(exchangeShareId.Value, out exchangeShareData))
				{
					num = new int?(exchangeShareData.GetCount());
				}
			}
			else
			{
				num2 = ExchangeRewardConfig.Instance.GetExchangeRewardMaxCount(rewardId);
				ExchangeRewardData exchangeRewardData;
				if (this.ExchangeRewardMap.TryGetValue(rewardId, out exchangeRewardData))
				{
					num = new int?(exchangeRewardData.GetCount());
				}
			}
			return num2 == 0 || num.Value < num2;
		}

		// Token: 0x06039C0D RID: 236557 RVA: 0x00DB9D14 File Offset: 0x00DB7F14
		public int GetExchangeRewardShareCount(int shareId)
		{
			ExchangeShareData exchangeShareData;
			if (this.ExchangeShareMap.TryGetValue(shareId, out exchangeShareData))
			{
				return exchangeShareData.GetCount();
			}
			return 0;
		}

		// Token: 0x06039C0E RID: 236558 RVA: 0x00DB9D3C File Offset: 0x00DB7F3C
		[NullableContext(2)]
		public List<TItem> GetExchangeNormalConsume(int instanceDungeonId)
		{
			int rewardId = InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId).Value.RewardId;
			if (rewardId == 0)
			{
				return null;
			}
			Dictionary<int, int> exchangeCost = ExchangeRewardConfig.Instance.GetExchangeCost(rewardId);
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in exchangeCost)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06039C0F RID: 236559 RVA: 0x00DB9DE4 File Offset: 0x00DB7FE4
		public bool IsFinishInstance(int instanceId)
		{
			int? instanceFirstRewardId = InstanceDungeonConfig.Instance.GetInstanceFirstRewardId(instanceId);
			bool flag = (instanceFirstRewardId ?? 0) == 0;
			if (flag)
			{
				return false;
			}
			int exchangeRewardMaxCount = ExchangeRewardConfig.Instance.GetExchangeRewardMaxCount(instanceFirstRewardId.Value);
			ExchangeRewardData exchangeRewardData;
			int? num = this.ExchangeRewardMap.TryGetValue(instanceFirstRewardId.Value, out exchangeRewardData) ? new int?(exchangeRewardData.GetCount()) : null;
			return exchangeRewardMaxCount != 0 && num != null && num.Value >= exchangeRewardMaxCount;
		}

		// Token: 0x06039C10 RID: 236560 RVA: 0x00DB9E78 File Offset: 0x00DB8078
		public bool IsFinishInstanceCompatible(int instanceId)
		{
			InstanceDungeon? instanceDungeon;
			int? num = (InstanceDungeonConfig.Instance.GetConfig(instanceId) != null) ? new int?(instanceDungeon.GetValueOrDefault().RewardId) : null;
			bool flag = (num ?? 0) == 0;
			if (flag)
			{
				return false;
			}
			if (ExchangeRewardConfig.Instance.GetExchangeRewardMaxCount(num.Value) != 1)
			{
				return false;
			}
			int? num2 = null;
			ExchangeRewardData exchangeRewardData;
			if (this.ExchangeRewardMap.TryGetValue(num.Value, out exchangeRewardData))
			{
				num2 = new int?(exchangeRewardData.GetCount());
			}
			return num2 != null && num2.Value >= 1;
		}

		// Token: 0x17008A9D RID: 35485
		// (get) Token: 0x06039C11 RID: 236561 RVA: 0x00DB9F35 File Offset: 0x00DB8135
		public static ExchangeRewardModel Instance
		{
			get
			{
				return ExchangeRewardModel._Instance;
			}
		}

		// Token: 0x06039C12 RID: 236562 RVA: 0x00DB9F3C File Offset: 0x00DB813C
		public static ExchangeRewardModel GetOrCreateInstance()
		{
			if (ExchangeRewardModel._Instance == null)
			{
				ExchangeRewardModel.CreateInstance();
			}
			return ExchangeRewardModel._Instance;
		}

		// Token: 0x06039C13 RID: 236563 RVA: 0x00DB9F50 File Offset: 0x00DB8150
		public static bool CreateInstance()
		{
			if (ExchangeRewardModel._Instance != null)
			{
				return true;
			}
			ExchangeRewardModel._Instance = new ExchangeRewardModel();
			return true;
		}

		// Token: 0x06039C14 RID: 236564 RVA: 0x00DB9F66 File Offset: 0x00DB8166
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039C15 RID: 236565 RVA: 0x00DB9F68 File Offset: 0x00DB8168
		public static void ResetStaticDefaultValue()
		{
			ExchangeRewardModel._Instance = null;
		}

		// Token: 0x06039C16 RID: 236566 RVA: 0x00DB9F70 File Offset: 0x00DB8170
		static ExchangeRewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardModel.CreateStaticDefaultValue), new Action(ExchangeRewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E286 RID: 123526
		public const int POWER_DISCOUNT_HELP_ID = 26;

		// Token: 0x0401E287 RID: 123527
		private readonly Dictionary<int, ExchangeRewardData> ExchangeRewardMap = new Dictionary<int, ExchangeRewardData>();

		// Token: 0x0401E288 RID: 123528
		private readonly Dictionary<int, ExchangeShareData> ExchangeShareMap = new Dictionary<int, ExchangeShareData>();

		// Token: 0x0401E289 RID: 123529
		[Nullable(2)]
		private static ExchangeRewardModel _Instance;
	}
}
