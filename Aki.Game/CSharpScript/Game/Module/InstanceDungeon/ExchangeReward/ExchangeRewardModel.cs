using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x0200488E RID: 18574
	[NullableContext(1)]
	[Nullable(0)]
	public class ExchangeRewardModel : ModelBase
	{
		// Token: 0x0602EB2A RID: 191274 RVA: 0x00D088F9 File Offset: 0x00D06AF9
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602EB2B RID: 191275 RVA: 0x00D088FC File Offset: 0x00D06AFC
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

		// Token: 0x0602EB2C RID: 191276 RVA: 0x00D089EC File Offset: 0x00D06BEC
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

		// Token: 0x0602EB2D RID: 191277 RVA: 0x00D08A38 File Offset: 0x00D06C38
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

		// Token: 0x0602EB2E RID: 191278 RVA: 0x00D08AB8 File Offset: 0x00D06CB8
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

		// Token: 0x0602EB2F RID: 191279 RVA: 0x00D08B84 File Offset: 0x00D06D84
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

		// Token: 0x0602EB30 RID: 191280 RVA: 0x00D08C2C File Offset: 0x00D06E2C
		public int GetExchangeRewardShareCount(int shareId)
		{
			ExchangeShareData exchangeShareData;
			if (this.ExchangeShareMap.TryGetValue(shareId, out exchangeShareData))
			{
				return exchangeShareData.GetCount();
			}
			return 0;
		}

		// Token: 0x0602EB31 RID: 191281 RVA: 0x00D08C54 File Offset: 0x00D06E54
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

		// Token: 0x0602EB32 RID: 191282 RVA: 0x00D08CFC File Offset: 0x00D06EFC
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

		// Token: 0x0602EB33 RID: 191283 RVA: 0x00D08D90 File Offset: 0x00D06F90
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

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x0602EB34 RID: 191284 RVA: 0x00D08E4D File Offset: 0x00D0704D
		public static ExchangeRewardModel Instance
		{
			get
			{
				return ExchangeRewardModel._Instance;
			}
		}

		// Token: 0x0602EB35 RID: 191285 RVA: 0x00D08E54 File Offset: 0x00D07054
		public static ExchangeRewardModel GetOrCreateInstance()
		{
			if (ExchangeRewardModel._Instance == null)
			{
				ExchangeRewardModel.CreateInstance();
			}
			return ExchangeRewardModel._Instance;
		}

		// Token: 0x0602EB36 RID: 191286 RVA: 0x00D08E68 File Offset: 0x00D07068
		public static bool CreateInstance()
		{
			if (ExchangeRewardModel._Instance != null)
			{
				return true;
			}
			ExchangeRewardModel._Instance = new ExchangeRewardModel();
			return true;
		}

		// Token: 0x0602EB37 RID: 191287 RVA: 0x00D08E7E File Offset: 0x00D0707E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB38 RID: 191288 RVA: 0x00D08E80 File Offset: 0x00D07080
		public static void ResetStaticDefaultValue()
		{
			ExchangeRewardModel._Instance = null;
		}

		// Token: 0x0602EB39 RID: 191289 RVA: 0x00D08E88 File Offset: 0x00D07088
		static ExchangeRewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardModel.CreateStaticDefaultValue), new Action(ExchangeRewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018D23 RID: 101667
		public const int POWER_DISCOUNT_HELP_ID = 26;

		// Token: 0x04018D24 RID: 101668
		private readonly Dictionary<int, ExchangeRewardData> ExchangeRewardMap = new Dictionary<int, ExchangeRewardData>();

		// Token: 0x04018D25 RID: 101669
		private readonly Dictionary<int, ExchangeShareData> ExchangeShareMap = new Dictionary<int, ExchangeShareData>();

		// Token: 0x04018D26 RID: 101670
		[Nullable(2)]
		private static ExchangeRewardModel _Instance;
	}
}
