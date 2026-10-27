using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x02002203 RID: 8707
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MarqueeModel : ModelBase
{
	// Token: 0x1700157F RID: 5503
	// (get) Token: 0x06010ED7 RID: 69335 RVA: 0x0041E5DD File Offset: 0x0041C7DD
	// (set) Token: 0x06010ED8 RID: 69336 RVA: 0x0041E5E5 File Offset: 0x0041C7E5
	[Nullable(2)]
	public TimerHandle TimerId
	{
		[NullableContext(2)]
		get
		{
			return this.TimerIdInternal;
		}
		[NullableContext(2)]
		set
		{
			this.TimerIdInternal = value;
		}
	}

	// Token: 0x17001580 RID: 5504
	// (get) Token: 0x06010ED9 RID: 69337 RVA: 0x0041E5EE File Offset: 0x0041C7EE
	// (set) Token: 0x06010EDA RID: 69338 RVA: 0x0041E5F6 File Offset: 0x0041C7F6
	[Nullable(2)]
	public MarqueeData CurMarquee
	{
		[NullableContext(2)]
		get
		{
			return this.CurMarqueeInternal;
		}
		[NullableContext(2)]
		set
		{
			this.CurMarqueeInternal = value;
		}
	}

	// Token: 0x17001581 RID: 5505
	// (get) Token: 0x06010EDB RID: 69339 RVA: 0x0041E5FF File Offset: 0x0041C7FF
	public List<MarqueeData> MarqueeQueue
	{
		get
		{
			return this.MarqueeQueueInternal;
		}
	}

	// Token: 0x06010EDC RID: 69340 RVA: 0x0041E607 File Offset: 0x0041C807
	protected override bool OnClear()
	{
		this.RemoveAllMarqueeData();
		this.SeverMarqueeStorageDataMap.Clear();
		this.ClientMarqueeStorageDataMap.Clear();
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
		return true;
	}

	// Token: 0x06010EDD RID: 69341 RVA: 0x0041E646 File Offset: 0x0041C846
	public void InitMarqueeStorageDataMap()
	{
		this.SeverMarqueeStorageDataMap = (LocalStorage.GetPlayer<Dictionary<string, MarqueeStorageData>>(ELocalStoragePlayerKey.MarqueeScrollingMap, null) ?? new Dictionary<string, MarqueeStorageData>());
	}

	// Token: 0x06010EDE RID: 69342 RVA: 0x0041E660 File Offset: 0x0041C860
	public void AddOrUpdateMarqueeDate(MarqueeData data)
	{
		if (!data.IsClientMarquee && !data.CheckPlatformAndChannelIfShow())
		{
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (data.EndTime <= serverTime)
		{
			return;
		}
		if (this.GetScrollingTime(data) >= data.ScrollTimes)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < this.MarqueeQueueInternal.Count; i++)
		{
			if (this.MarqueeQueueInternal[i].Id == data.Id)
			{
				num = i;
			}
		}
		if (num >= 0)
		{
			this.MarqueeQueueInternal[num] = data;
			if (num == 0)
			{
				this.CurMarqueeInternal = data;
			}
		}
		else
		{
			this.MarqueeQueueInternal.Add(data);
		}
		this.AddOrUpdateMarqueeStorageData(data);
		this.CleanMarqueeStorageDataMap(serverTime);
		this.SaveMarqueeStorageDataMap();
	}

	// Token: 0x06010EDF RID: 69343 RVA: 0x0041E71C File Offset: 0x0041C91C
	public void CleanMarqueeStorageDataMap(double serverTime)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, MarqueeStorageData> keyValuePair in this.SeverMarqueeStorageDataMap)
		{
			if (keyValuePair.Value.EndTime <= serverTime)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (string key in list)
		{
			this.SeverMarqueeStorageDataMap.Remove(key);
		}
		list.Clear();
		foreach (KeyValuePair<string, MarqueeStorageData> keyValuePair2 in this.ClientMarqueeStorageDataMap)
		{
			if (keyValuePair2.Value.EndTime <= serverTime)
			{
				list.Add(keyValuePair2.Key);
			}
		}
		foreach (string key2 in list)
		{
			this.ClientMarqueeStorageDataMap.Remove(key2);
		}
	}

	// Token: 0x06010EE0 RID: 69344 RVA: 0x0041E874 File Offset: 0x0041CA74
	public void UpdateMarqueeStorageDataByDate(MarqueeData data)
	{
		MarqueeStorageData marqueeStorageData = this.GetMarqueeStorageData(data);
		if (marqueeStorageData == null)
		{
			marqueeStorageData = this.AddOrUpdateMarqueeStorageData(data);
		}
		marqueeStorageData.ScrollingTime++;
		this.SaveMarqueeStorageDataMap();
	}

	// Token: 0x06010EE1 RID: 69345 RVA: 0x0041E8A8 File Offset: 0x0041CAA8
	public int GetScrollingTime(MarqueeData data)
	{
		MarqueeStorageData marqueeStorageData = this.GetMarqueeStorageData(data);
		if (marqueeStorageData == null)
		{
			return 0;
		}
		return marqueeStorageData.ScrollingTime;
	}

	// Token: 0x06010EE2 RID: 69346 RVA: 0x0041E8BC File Offset: 0x0041CABC
	[return: Nullable(2)]
	public MarqueeStorageData GetMarqueeStorageData(MarqueeData data)
	{
		if (!data.IsClientMarquee)
		{
			MarqueeStorageData result;
			if (!this.SeverMarqueeStorageDataMap.TryGetValue(data.Id, out result))
			{
				return null;
			}
			return result;
		}
		else
		{
			MarqueeStorageData result2;
			if (!this.ClientMarqueeStorageDataMap.TryGetValue(data.Id, out result2))
			{
				return null;
			}
			return result2;
		}
	}

	// Token: 0x06010EE3 RID: 69347 RVA: 0x0041E904 File Offset: 0x0041CB04
	private MarqueeStorageData AddOrUpdateMarqueeStorageData(MarqueeData data)
	{
		MarqueeStorageData marqueeStorageData = this.GetMarqueeStorageData(data);
		if (marqueeStorageData == null)
		{
			marqueeStorageData = new MarqueeStorageData(data.EndTime);
			if (data.IsClientMarquee)
			{
				this.ClientMarqueeStorageDataMap[data.Id] = marqueeStorageData;
			}
			else
			{
				this.SeverMarqueeStorageDataMap[data.Id] = marqueeStorageData;
			}
		}
		else
		{
			marqueeStorageData.EndTime = data.EndTime;
		}
		return marqueeStorageData;
	}

	// Token: 0x06010EE4 RID: 69348 RVA: 0x0041E965 File Offset: 0x0041CB65
	private void SaveMarqueeStorageDataMap()
	{
		LocalStorage.SetPlayer<Dictionary<string, MarqueeStorageData>>(ELocalStoragePlayerKey.MarqueeScrollingMap, this.SeverMarqueeStorageDataMap);
	}

	// Token: 0x06010EE5 RID: 69349 RVA: 0x0041E975 File Offset: 0x0041CB75
	[NullableContext(2)]
	public MarqueeData PeekMarqueeData()
	{
		if (this.MarqueeQueueInternal == null || this.MarqueeQueueInternal.Count <= 0)
		{
			return null;
		}
		return this.MarqueeQueueInternal[0];
	}

	// Token: 0x06010EE6 RID: 69350 RVA: 0x0041E99B File Offset: 0x0041CB9B
	[NullableContext(2)]
	public MarqueeData GetNextMarquee()
	{
		if (this.MarqueeQueueInternal == null || this.MarqueeQueueInternal.Count <= 1)
		{
			return null;
		}
		return this.MarqueeQueueInternal[1];
	}

	// Token: 0x06010EE7 RID: 69351 RVA: 0x0041E9C4 File Offset: 0x0041CBC4
	[NullableContext(2)]
	public MarqueeData RemoveMarqueeData(string incId)
	{
		for (int i = 0; i < this.MarqueeQueueInternal.Count; i++)
		{
			MarqueeData marqueeData = this.MarqueeQueueInternal[i];
			if (marqueeData.Id == incId)
			{
				this.MarqueeQueueInternal.RemoveAt(i);
				return marqueeData;
			}
		}
		return null;
	}

	// Token: 0x06010EE8 RID: 69352 RVA: 0x0041EA11 File Offset: 0x0041CC11
	public void RemoveAllMarqueeData()
	{
		this.CurMarqueeInternal = null;
		this.MarqueeQueueInternal = new List<MarqueeData>();
	}

	// Token: 0x06010EE9 RID: 69353 RVA: 0x0041EA28 File Offset: 0x0041CC28
	public void RemoveServerMarqueeData()
	{
		this.CurMarqueeInternal = null;
		List<MarqueeData> list = new List<MarqueeData>();
		foreach (MarqueeData marqueeData in this.MarqueeQueueInternal)
		{
			if (marqueeData.IsClientMarquee)
			{
				list.Add(marqueeData);
			}
		}
		this.MarqueeQueueInternal = list;
	}

	// Token: 0x06010EEA RID: 69354 RVA: 0x0041EA98 File Offset: 0x0041CC98
	public void SortMarqueeQueue()
	{
		List<MarqueeData> marqueeQueueInternal = this.MarqueeQueueInternal;
		if (marqueeQueueInternal == null)
		{
			return;
		}
		marqueeQueueInternal.Sort((MarqueeData a, MarqueeData b) => a.BeginTime.CompareTo(b.BeginTime));
	}

	// Token: 0x06010EEB RID: 69355 RVA: 0x0041EACC File Offset: 0x0041CCCC
	public double GetMarqueeDataLeftTime(MarqueeData data)
	{
		double num = data.EndTime - TimeUtil.Instance.GetServerTime();
		if (num <= 0.0)
		{
			num = 1.0;
		}
		return num;
	}

	// Token: 0x17001582 RID: 5506
	// (get) Token: 0x06010EEC RID: 69356 RVA: 0x0041EB03 File Offset: 0x0041CD03
	public static MarqueeModel Instance
	{
		get
		{
			return MarqueeModel._Instance;
		}
	}

	// Token: 0x06010EED RID: 69357 RVA: 0x0041EB0A File Offset: 0x0041CD0A
	public static MarqueeModel GetOrCreateInstance()
	{
		if (MarqueeModel._Instance == null)
		{
			MarqueeModel.CreateInstance();
		}
		return MarqueeModel._Instance;
	}

	// Token: 0x06010EEE RID: 69358 RVA: 0x0041EB1E File Offset: 0x0041CD1E
	public static bool CreateInstance()
	{
		if (MarqueeModel._Instance != null)
		{
			return true;
		}
		MarqueeModel._Instance = new MarqueeModel();
		return true;
	}

	// Token: 0x06010EEF RID: 69359 RVA: 0x0041EB34 File Offset: 0x0041CD34
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010EF0 RID: 69360 RVA: 0x0041EB36 File Offset: 0x0041CD36
	public static void ResetStaticDefaultValue()
	{
		MarqueeModel._Instance = null;
	}

	// Token: 0x06010EF1 RID: 69361 RVA: 0x0041EB3E File Offset: 0x0041CD3E
	static MarqueeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MarqueeModel.CreateStaticDefaultValue), new Action(MarqueeModel.ResetStaticDefaultValue));
	}

	// Token: 0x040080BE RID: 32958
	[Nullable(2)]
	private TimerHandle TimerIdInternal;

	// Token: 0x040080BF RID: 32959
	[Nullable(2)]
	private MarqueeData CurMarqueeInternal;

	// Token: 0x040080C0 RID: 32960
	private List<MarqueeData> MarqueeQueueInternal = new List<MarqueeData>();

	// Token: 0x040080C1 RID: 32961
	private Dictionary<string, MarqueeStorageData> SeverMarqueeStorageDataMap = new Dictionary<string, MarqueeStorageData>();

	// Token: 0x040080C2 RID: 32962
	private readonly Dictionary<string, MarqueeStorageData> ClientMarqueeStorageDataMap = new Dictionary<string, MarqueeStorageData>();

	// Token: 0x040080C3 RID: 32963
	[Nullable(2)]
	private static MarqueeModel _Instance;
}
