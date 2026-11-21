using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x020016E7 RID: 5863
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MarqueeModel : ModelBase
{
	// Token: 0x170015B6 RID: 5558
	// (get) Token: 0x0600E36A RID: 58218 RVA: 0x0042AF81 File Offset: 0x00429181
	// (set) Token: 0x0600E36B RID: 58219 RVA: 0x0042AF89 File Offset: 0x00429189
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

	// Token: 0x170015B7 RID: 5559
	// (get) Token: 0x0600E36C RID: 58220 RVA: 0x0042AF92 File Offset: 0x00429192
	// (set) Token: 0x0600E36D RID: 58221 RVA: 0x0042AF9A File Offset: 0x0042919A
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

	// Token: 0x170015B8 RID: 5560
	// (get) Token: 0x0600E36E RID: 58222 RVA: 0x0042AFA3 File Offset: 0x004291A3
	public List<MarqueeData> MarqueeQueue
	{
		get
		{
			return this.MarqueeQueueInternal;
		}
	}

	// Token: 0x0600E36F RID: 58223 RVA: 0x0042AFAB File Offset: 0x004291AB
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

	// Token: 0x0600E370 RID: 58224 RVA: 0x0042AFEA File Offset: 0x004291EA
	public void InitMarqueeStorageDataMap()
	{
		this.SeverMarqueeStorageDataMap = (LocalStorage.GetPlayer<Dictionary<string, MarqueeStorageData>>(ELocalStoragePlayerKey.MarqueeScrollingMap, null) ?? new Dictionary<string, MarqueeStorageData>());
	}

	// Token: 0x0600E371 RID: 58225 RVA: 0x0042B004 File Offset: 0x00429204
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

	// Token: 0x0600E372 RID: 58226 RVA: 0x0042B0C0 File Offset: 0x004292C0
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

	// Token: 0x0600E373 RID: 58227 RVA: 0x0042B218 File Offset: 0x00429418
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

	// Token: 0x0600E374 RID: 58228 RVA: 0x0042B24C File Offset: 0x0042944C
	public int GetScrollingTime(MarqueeData data)
	{
		MarqueeStorageData marqueeStorageData = this.GetMarqueeStorageData(data);
		if (marqueeStorageData == null)
		{
			return 0;
		}
		return marqueeStorageData.ScrollingTime;
	}

	// Token: 0x0600E375 RID: 58229 RVA: 0x0042B260 File Offset: 0x00429460
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

	// Token: 0x0600E376 RID: 58230 RVA: 0x0042B2A8 File Offset: 0x004294A8
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

	// Token: 0x0600E377 RID: 58231 RVA: 0x0042B309 File Offset: 0x00429509
	private void SaveMarqueeStorageDataMap()
	{
		LocalStorage.SetPlayer<Dictionary<string, MarqueeStorageData>>(ELocalStoragePlayerKey.MarqueeScrollingMap, this.SeverMarqueeStorageDataMap);
	}

	// Token: 0x0600E378 RID: 58232 RVA: 0x0042B319 File Offset: 0x00429519
	[NullableContext(2)]
	public MarqueeData PeekMarqueeData()
	{
		if (this.MarqueeQueueInternal == null || this.MarqueeQueueInternal.Count <= 0)
		{
			return null;
		}
		return this.MarqueeQueueInternal[0];
	}

	// Token: 0x0600E379 RID: 58233 RVA: 0x0042B33F File Offset: 0x0042953F
	[NullableContext(2)]
	public MarqueeData GetNextMarquee()
	{
		if (this.MarqueeQueueInternal == null || this.MarqueeQueueInternal.Count <= 1)
		{
			return null;
		}
		return this.MarqueeQueueInternal[1];
	}

	// Token: 0x0600E37A RID: 58234 RVA: 0x0042B368 File Offset: 0x00429568
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

	// Token: 0x0600E37B RID: 58235 RVA: 0x0042B3B5 File Offset: 0x004295B5
	public void RemoveAllMarqueeData()
	{
		this.CurMarqueeInternal = null;
		this.MarqueeQueueInternal = new List<MarqueeData>();
	}

	// Token: 0x0600E37C RID: 58236 RVA: 0x0042B3CC File Offset: 0x004295CC
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

	// Token: 0x0600E37D RID: 58237 RVA: 0x0042B43C File Offset: 0x0042963C
	public void SortMarqueeQueue()
	{
		List<MarqueeData> marqueeQueueInternal = this.MarqueeQueueInternal;
		if (marqueeQueueInternal == null)
		{
			return;
		}
		marqueeQueueInternal.Sort((MarqueeData a, MarqueeData b) => a.BeginTime.CompareTo(b.BeginTime));
	}

	// Token: 0x0600E37E RID: 58238 RVA: 0x0042B470 File Offset: 0x00429670
	public double GetMarqueeDataLeftTime(MarqueeData data)
	{
		double num = data.EndTime - TimeUtil.Instance.GetServerTime();
		if (num <= 0.0)
		{
			num = 1.0;
		}
		return num;
	}

	// Token: 0x170015B9 RID: 5561
	// (get) Token: 0x0600E37F RID: 58239 RVA: 0x0042B4A7 File Offset: 0x004296A7
	public static MarqueeModel Instance
	{
		get
		{
			return MarqueeModel._Instance;
		}
	}

	// Token: 0x0600E380 RID: 58240 RVA: 0x0042B4AE File Offset: 0x004296AE
	public static MarqueeModel GetOrCreateInstance()
	{
		if (MarqueeModel._Instance == null)
		{
			MarqueeModel.CreateInstance();
		}
		return MarqueeModel._Instance;
	}

	// Token: 0x0600E381 RID: 58241 RVA: 0x0042B4C2 File Offset: 0x004296C2
	public static bool CreateInstance()
	{
		if (MarqueeModel._Instance != null)
		{
			return true;
		}
		MarqueeModel._Instance = new MarqueeModel();
		return true;
	}

	// Token: 0x0600E382 RID: 58242 RVA: 0x0042B4D8 File Offset: 0x004296D8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E383 RID: 58243 RVA: 0x0042B4DA File Offset: 0x004296DA
	public static void ResetStaticDefaultValue()
	{
		MarqueeModel._Instance = null;
	}

	// Token: 0x0600E384 RID: 58244 RVA: 0x0042B4E2 File Offset: 0x004296E2
	static MarqueeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MarqueeModel.CreateStaticDefaultValue), new Action(MarqueeModel.ResetStaticDefaultValue));
	}

	// Token: 0x040081FC RID: 33276
	[Nullable(2)]
	private TimerHandle TimerIdInternal;

	// Token: 0x040081FD RID: 33277
	[Nullable(2)]
	private MarqueeData CurMarqueeInternal;

	// Token: 0x040081FE RID: 33278
	private List<MarqueeData> MarqueeQueueInternal = new List<MarqueeData>();

	// Token: 0x040081FF RID: 33279
	private Dictionary<string, MarqueeStorageData> SeverMarqueeStorageDataMap = new Dictionary<string, MarqueeStorageData>();

	// Token: 0x04008200 RID: 33280
	private readonly Dictionary<string, MarqueeStorageData> ClientMarqueeStorageDataMap = new Dictionary<string, MarqueeStorageData>();

	// Token: 0x04008201 RID: 33281
	[Nullable(2)]
	private static MarqueeModel _Instance;
}
