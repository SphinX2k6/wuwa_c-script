using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020014BF RID: 5311
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ItemExchangeModel : ModelBase
{
	// Token: 0x0600D485 RID: 54405 RVA: 0x003F2D64 File Offset: 0x003F0F64
	protected override bool OnInit()
	{
		this.ItemExchangeTimeInfo = new Dictionary<int, ItemExchangeInfo>();
		return true;
	}

	// Token: 0x0600D486 RID: 54406 RVA: 0x003F2D72 File Offset: 0x003F0F72
	protected override bool OnClear()
	{
		this.ItemExchangeTimeInfo = null;
		return true;
	}

	// Token: 0x0600D487 RID: 54407 RVA: 0x003F2D7C File Offset: 0x003F0F7C
	public void InitItemExchangeTimeInfo(IEnumerable<ItemExchangeInfo> info)
	{
		foreach (ItemExchangeInfo itemExchangeInfo in info)
		{
			this.ItemExchangeTimeInfo[itemExchangeInfo.ItemId] = itemExchangeInfo;
		}
	}

	// Token: 0x0600D488 RID: 54408 RVA: 0x003F2DD0 File Offset: 0x003F0FD0
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

	// Token: 0x0600D489 RID: 54409 RVA: 0x003F2E30 File Offset: 0x003F1030
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

	// Token: 0x0600D48A RID: 54410 RVA: 0x003F2E58 File Offset: 0x003F1058
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

	// Token: 0x0600D48B RID: 54411 RVA: 0x003F2E94 File Offset: 0x003F1094
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

	// Token: 0x0600D48C RID: 54412 RVA: 0x003F310C File Offset: 0x003F130C
	private int GetRestExChangeTime(int itemId)
	{
		ItemExchangeInfo exchangeInfo = this.GetExchangeInfo(itemId);
		int val = (exchangeInfo.TotalLimit > 0) ? (exchangeInfo.TotalLimit - exchangeInfo.TotalTimes) : 999999999;
		int val2 = (exchangeInfo.DailyLimit > 0) ? (exchangeInfo.DailyLimit - exchangeInfo.TodayTimes) : 999999999;
		return Math.Min(val, val2);
	}

	// Token: 0x0600D48D RID: 54413 RVA: 0x003F3164 File Offset: 0x003F1364
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

	// Token: 0x0600D48E RID: 54414 RVA: 0x003F3230 File Offset: 0x003F1430
	public bool CheckIsMaxExChangeTime(int itemId, int addTime = 0)
	{
		ItemExchangeInfo exchangeInfo = this.GetExchangeInfo(itemId);
		return (exchangeInfo.TotalLimit > 0 && exchangeInfo.TotalTimes + addTime >= exchangeInfo.TotalLimit) || (exchangeInfo.DailyLimit > 0 && exchangeInfo.TodayTimes + addTime >= exchangeInfo.DailyLimit);
	}

	// Token: 0x0600D48F RID: 54415 RVA: 0x003F327C File Offset: 0x003F147C
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

	// Token: 0x17001393 RID: 5011
	// (get) Token: 0x0600D490 RID: 54416 RVA: 0x003F32A6 File Offset: 0x003F14A6
	public static ItemExchangeModel Instance
	{
		get
		{
			return ItemExchangeModel._Instance;
		}
	}

	// Token: 0x0600D491 RID: 54417 RVA: 0x003F32AD File Offset: 0x003F14AD
	public static ItemExchangeModel GetOrCreateInstance()
	{
		if (ItemExchangeModel._Instance == null)
		{
			ItemExchangeModel.CreateInstance();
		}
		return ItemExchangeModel._Instance;
	}

	// Token: 0x0600D492 RID: 54418 RVA: 0x003F32C1 File Offset: 0x003F14C1
	public static bool CreateInstance()
	{
		if (ItemExchangeModel._Instance != null)
		{
			return true;
		}
		ItemExchangeModel._Instance = new ItemExchangeModel();
		return true;
	}

	// Token: 0x0600D493 RID: 54419 RVA: 0x003F32D7 File Offset: 0x003F14D7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D494 RID: 54420 RVA: 0x003F32D9 File Offset: 0x003F14D9
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeModel._Instance = null;
	}

	// Token: 0x0600D495 RID: 54421 RVA: 0x003F32E1 File Offset: 0x003F14E1
	static ItemExchangeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeModel.CreateStaticDefaultValue), new Action(ItemExchangeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400776E RID: 30574
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, ItemExchangeInfo> ItemExchangeTimeInfo;

	// Token: 0x0400776F RID: 30575
	[Nullable(2)]
	private static ItemExchangeModel _Instance;
}
