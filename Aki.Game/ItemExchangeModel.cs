using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001FEC RID: 8172
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ItemExchangeModel : ModelBase
{
	// Token: 0x0601001D RID: 65565 RVA: 0x003E6764 File Offset: 0x003E4964
	protected override bool OnInit()
	{
		this.ItemExchangeTimeInfo = new Dictionary<int, ItemExchangeInfo>();
		return true;
	}

	// Token: 0x0601001E RID: 65566 RVA: 0x003E6772 File Offset: 0x003E4972
	protected override bool OnClear()
	{
		this.ItemExchangeTimeInfo = null;
		return true;
	}

	// Token: 0x0601001F RID: 65567 RVA: 0x003E677C File Offset: 0x003E497C
	public void InitItemExchangeTimeInfo(List<ItemExchangeInfo> info)
	{
		foreach (ItemExchangeInfo itemExchangeInfo in info)
		{
			this.ItemExchangeTimeInfo[itemExchangeInfo.ItemId] = itemExchangeInfo;
		}
	}

	// Token: 0x06010020 RID: 65568 RVA: 0x003E67D8 File Offset: 0x003E49D8
	[NullableContext(2)]
	public ItemExchangeInfo GetExchangeInfo(int itemId)
	{
		ItemExchangeInfo itemExchangeInfo;
		this.ItemExchangeTimeInfo.TryGetValue(itemId, out itemExchangeInfo);
		if (itemExchangeInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ItemExchange;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "前后端版本可能不一致, 当前兑换的道具并没有后端配置!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		ItemExchangeInfo result;
		this.ItemExchangeTimeInfo.TryGetValue(itemId, out result);
		return result;
	}

	// Token: 0x06010021 RID: 65569 RVA: 0x003E6838 File Offset: 0x003E4A38
	public int GetExChangeTime(int itemId)
	{
		ItemExchangeInfo itemExchangeInfo;
		this.ItemExchangeTimeInfo.TryGetValue(itemId, out itemExchangeInfo);
		if (itemExchangeInfo == null)
		{
			return 0;
		}
		return itemExchangeInfo.TodayTimes;
	}

	// Token: 0x06010022 RID: 65570 RVA: 0x003E6860 File Offset: 0x003E4A60
	public void AddExchangeTime(int itemId, int exChangeTimes)
	{
		ItemExchangeInfo itemExchangeInfo;
		this.ItemExchangeTimeInfo.TryGetValue(itemId, out itemExchangeInfo);
		if (itemExchangeInfo != null)
		{
			itemExchangeInfo.TotalTimes += exChangeTimes;
			itemExchangeInfo.TodayTimes += exChangeTimes;
		}
	}

	// Token: 0x06010023 RID: 65571 RVA: 0x003E689C File Offset: 0x003E4A9C
	[NullableContext(2)]
	public ExchangeSimulation CalculateConsume(int itemId, int needCount = 0, int exChangeTime = 0, bool ignore = false)
	{
		int num = needCount;
		if (exChangeTime > 0)
		{
			num = 999999999;
		}
		IReadOnlyList<ItemExchangeContent> exChangeConfigList = ItemExchangeConfig.Instance.GetExChangeConfigList(itemId);
		if (exChangeConfigList == null || exChangeConfigList.Count <= 0)
		{
			return null;
		}
		int i = 0;
		int num2 = exChangeConfigList.Count - 1;
		int num3 = this.GetExChangeTime(itemId) + 1;
		int num4 = 0;
		for (int j = num2; j >= 0; j--)
		{
			ItemExchangeContent itemExchangeContent = exChangeConfigList[j];
			if (num3 >= itemExchangeContent.Times)
			{
				i = j;
				int? num5 = null;
				using (Dictionary<int, int>.Enumerator enumerator = itemExchangeContent.Consume().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						num5 = new int?(keyValuePair.Key);
					}
				}
				num4 = InventoryModel.Instance.GetItemCountByConfigId(num5.Value, 0);
				break;
			}
		}
		int restExChangeTime = this.GetRestExChangeTime(itemId);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		while (i <= num2)
		{
			ItemExchangeContent itemExchangeContent2 = exChangeConfigList[i];
			ItemExchangeContent? itemExchangeContent3 = (i < num2) ? new ItemExchangeContent?(exChangeConfigList[i + 1]) : null;
			int num9 = (int)Math.Ceiling((double)(num - num7) / (double)itemExchangeContent2.GainCount);
			if (itemExchangeContent3 != null)
			{
				int val = itemExchangeContent3.Value.Times - itemExchangeContent2.Times;
				num9 = Math.Min(num9, val);
			}
			if (exChangeTime > 0 && num9 + num6 > exChangeTime)
			{
				num9 = exChangeTime - num6;
			}
			if (num9 + num6 > restExChangeTime)
			{
				num9 = restExChangeTime - num6;
			}
			int? num10 = null;
			using (Dictionary<int, int>.Enumerator enumerator = itemExchangeContent2.Consume().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair2 = enumerator.Current;
					num10 = new int?(keyValuePair2.Value);
				}
			}
			if (!ignore && num8 + num9 * num10.Value > num4)
			{
				num9 = (int)Math.Floor((double)(num4 - num8) / (double)num10.Value);
			}
			num8 += num9 * num10.Value;
			num6 += num9;
			num7 += num9 * itemExchangeContent2.GainCount;
			if (num7 >= num || (exChangeTime > 0 && num6 >= exChangeTime) || num6 >= restExChangeTime || num8 >= num4)
			{
				break;
			}
			i++;
		}
		return new ExchangeSimulation
		{
			ExChangeTime = num6,
			ExChangeCount = num7,
			ConsumeCount = num8
		};
	}

	// Token: 0x06010024 RID: 65572 RVA: 0x003E6B14 File Offset: 0x003E4D14
	private int GetRestExChangeTime(int itemId)
	{
		ItemExchangeInfo exchangeInfo = this.GetExchangeInfo(itemId);
		int val = (exchangeInfo.TotalLimit > 0) ? (exchangeInfo.TotalLimit - exchangeInfo.TotalTimes) : 999999999;
		int val2 = (exchangeInfo.DailyLimit > 0) ? (exchangeInfo.DailyLimit - exchangeInfo.TodayTimes) : 999999999;
		return Math.Min(val, val2);
	}

	// Token: 0x06010025 RID: 65573 RVA: 0x003E6B6C File Offset: 0x003E4D6C
	public ExchangeInfo GetCurExchangeInfo(int itemId, int addTime = 0)
	{
		ExchangeInfo exchangeInfo = new ExchangeInfo();
		IReadOnlyList<ItemExchangeContent> exChangeConfigList = ItemExchangeConfig.Instance.GetExChangeConfigList(itemId);
		if (exChangeConfigList == null)
		{
			return exchangeInfo;
		}
		int num = this.GetExChangeTime(itemId) + addTime + 1;
		foreach (ItemExchangeContent itemExchangeContent in exChangeConfigList)
		{
			if (num < itemExchangeContent.Times)
			{
				break;
			}
			foreach (KeyValuePair<int, int> keyValuePair in itemExchangeContent.Consume())
			{
				exchangeInfo.ConsumeCount = keyValuePair.Value;
				exchangeInfo.GainCount = itemExchangeContent.GainCount;
			}
		}
		return exchangeInfo;
	}

	// Token: 0x06010026 RID: 65574 RVA: 0x003E6C38 File Offset: 0x003E4E38
	public bool CheckIsMaxExChangeTime(int itemId, int addTime = 0)
	{
		ItemExchangeInfo exchangeInfo = this.GetExchangeInfo(itemId);
		return (exchangeInfo.TotalLimit > 0 && exchangeInfo.TotalTimes + addTime >= exchangeInfo.TotalLimit) || (exchangeInfo.DailyLimit > 0 && exchangeInfo.TodayTimes + addTime >= exchangeInfo.DailyLimit);
	}

	// Token: 0x06010027 RID: 65575 RVA: 0x003E6C84 File Offset: 0x003E4E84
	public int GetMaxExChangeTime(int itemId)
	{
		int restExChangeTime = this.GetRestExChangeTime(itemId);
		ExchangeSimulation exchangeSimulation = this.CalculateConsume(itemId, 0, restExChangeTime, false);
		if (exchangeSimulation == null)
		{
			return 0;
		}
		return exchangeSimulation.ExChangeTime;
	}

	// Token: 0x17001366 RID: 4966
	// (get) Token: 0x06010028 RID: 65576 RVA: 0x003E6CAE File Offset: 0x003E4EAE
	public static ItemExchangeModel Instance
	{
		get
		{
			return ItemExchangeModel._Instance;
		}
	}

	// Token: 0x06010029 RID: 65577 RVA: 0x003E6CB5 File Offset: 0x003E4EB5
	public static ItemExchangeModel GetOrCreateInstance()
	{
		if (ItemExchangeModel._Instance == null)
		{
			ItemExchangeModel.CreateInstance();
		}
		return ItemExchangeModel._Instance;
	}

	// Token: 0x0601002A RID: 65578 RVA: 0x003E6CC9 File Offset: 0x003E4EC9
	public static bool CreateInstance()
	{
		if (ItemExchangeModel._Instance != null)
		{
			return true;
		}
		ItemExchangeModel._Instance = new ItemExchangeModel();
		return true;
	}

	// Token: 0x0601002B RID: 65579 RVA: 0x003E6CDF File Offset: 0x003E4EDF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601002C RID: 65580 RVA: 0x003E6CE1 File Offset: 0x003E4EE1
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeModel._Instance = null;
	}

	// Token: 0x0601002D RID: 65581 RVA: 0x003E6CE9 File Offset: 0x003E4EE9
	static ItemExchangeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeModel.CreateStaticDefaultValue), new Action(ItemExchangeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007685 RID: 30341
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, ItemExchangeInfo> ItemExchangeTimeInfo;

	// Token: 0x04007686 RID: 30342
	[Nullable(2)]
	private static ItemExchangeModel _Instance;
}
