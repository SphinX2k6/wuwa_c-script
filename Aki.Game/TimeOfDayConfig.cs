using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002127 RID: 8487
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TimeOfDayConfig : ConfigBase
{
	// Token: 0x06014CB3 RID: 85171 RVA: 0x0060B679 File Offset: 0x00609879
	public TimeOfDay? GetConfig()
	{
		return ConfigTimeOfDayById.GetConfig(1, true);
	}

	// Token: 0x06014CB4 RID: 85172 RVA: 0x0060B684 File Offset: 0x00609884
	public double GetInitTimeSecond()
	{
		TimeOfDay? timeOfDay;
		return (double)(((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().InitTime : 0) * 60);
	}

	// Token: 0x06014CB5 RID: 85173 RVA: 0x0060B6B8 File Offset: 0x006098B8
	public double GetMaxV()
	{
		TimeOfDay? timeOfDay;
		return (double)(60 * ((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().V : 0));
	}

	// Token: 0x06014CB6 RID: 85174 RVA: 0x0060B6EC File Offset: 0x006098EC
	public double GetA()
	{
		TimeOfDay? timeOfDay;
		return (double)(60 * ((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().A : 0));
	}

	// Token: 0x06014CB7 RID: 85175 RVA: 0x0060B720 File Offset: 0x00609920
	public double GetRate()
	{
		if (this.GetConfig() == null)
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "时间流速比未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0.0;
		}
		return (double)this.GetConfig().Value.Rate;
	}

	// Token: 0x06014CB8 RID: 85176 RVA: 0x0060B77C File Offset: 0x0060997C
	public bool InitDayStateTimeSpanList()
	{
		if (this.GetConfig() == null)
		{
			return false;
		}
		TimeOfDay? config = this.GetConfig();
		if (config == null || config.Value.StateSpanLength <= 0)
		{
			return false;
		}
		this.DayStateMinuteSpanList.Clear();
		int stateSpanLength = config.Value.StateSpanLength;
		for (int i = 0; i < stateSpanLength; i++)
		{
			DicIntInt? dicIntInt = config.Value.StateSpan(i);
			TTodTimeSpan item = new TTodTimeSpan(dicIntInt.Value.Key, dicIntInt.Value.Value);
			this.DayStateMinuteSpanList.Add(item);
		}
		this.DayStateMinuteSpanList.Sort((TTodTimeSpan a, TTodTimeSpan b) => (a.StartTime < b.StartTime) ? 1 : 0);
		return true;
	}

	// Token: 0x06014CB9 RID: 85177 RVA: 0x0060B85C File Offset: 0x00609A5C
	public ETodDayState GetDayStateByGameTimeMinute(double minute)
	{
		if (this.DayStateMinuteSpanList.Count == 0 && !this.InitDayStateTimeSpanList())
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "时间区间配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return ETodDayState.One;
		}
		ETodDayState etodDayState = ETodDayState.One;
		foreach (TTodTimeSpan ttodTimeSpan in this.DayStateMinuteSpanList)
		{
			if (TodDayTime.CheckInMinuteSpan(minute, ttodTimeSpan))
			{
				etodDayState = (ETodDayState)this.DayStateMinuteSpanList.IndexOf(ttodTimeSpan);
				break;
			}
		}
		if (etodDayState >= ETodDayState.Count)
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "时间区间配置超出范围", default(ReadOnlySpan<ValueTuple<string, object>>));
			return ETodDayState.One;
		}
		return etodDayState;
	}

	// Token: 0x06014CBA RID: 85178 RVA: 0x0060B918 File Offset: 0x00609B18
	public List<FGameplayTag> GetBanGameplayTags()
	{
		if (this.BanGameplayTagList.Count > 0)
		{
			return this.BanGameplayTagList;
		}
		TimeOfDay? config = this.GetConfig();
		if (config == null)
		{
			return this.BanGameplayTagList;
		}
		int banTagLength = config.Value.BanTagLength;
		for (int i = 0; i < banTagLength; i++)
		{
			FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName(config.Value.BanTag(i));
			if (gameplayTagByName != null)
			{
				this.BanGameplayTagList.Add(gameplayTagByName.Value);
			}
		}
		return this.BanGameplayTagList;
	}

	// Token: 0x06014CBB RID: 85179 RVA: 0x0060B9A5 File Offset: 0x00609BA5
	[NullableContext(2)]
	public IReadOnlyList<DaySelectPreset> GetDayTimeChangePresets()
	{
		return ConfigDaySelectPresetAll.GetConfigList(true);
	}

	// Token: 0x06014CBC RID: 85180 RVA: 0x0060B9B0 File Offset: 0x00609BB0
	public DaySelectPreset? GetDayTimeChangeConfig(int id)
	{
		DaySelectPreset? config = ConfigDaySelectPresetById.GetConfig(id, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x06014CBD RID: 85181 RVA: 0x0060B9DC File Offset: 0x00609BDC
	public string GetTimeChangeText(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetDayTimeChangeConfig(id).Value.Title, null) ?? "";
	}

	// Token: 0x17001F9E RID: 8094
	// (get) Token: 0x06014CBE RID: 85182 RVA: 0x0060BA0F File Offset: 0x00609C0F
	public static TimeOfDayConfig Instance
	{
		get
		{
			return TimeOfDayConfig._Instance;
		}
	}

	// Token: 0x06014CBF RID: 85183 RVA: 0x0060BA16 File Offset: 0x00609C16
	public static TimeOfDayConfig GetOrCreateInstance()
	{
		if (TimeOfDayConfig._Instance == null)
		{
			TimeOfDayConfig.CreateInstance();
		}
		return TimeOfDayConfig._Instance;
	}

	// Token: 0x06014CC0 RID: 85184 RVA: 0x0060BA2A File Offset: 0x00609C2A
	public static bool CreateInstance()
	{
		if (TimeOfDayConfig._Instance != null)
		{
			return true;
		}
		TimeOfDayConfig._Instance = new TimeOfDayConfig();
		return true;
	}

	// Token: 0x06014CC1 RID: 85185 RVA: 0x0060BA40 File Offset: 0x00609C40
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014CC2 RID: 85186 RVA: 0x0060BA42 File Offset: 0x00609C42
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayConfig._Instance = null;
	}

	// Token: 0x06014CC3 RID: 85187 RVA: 0x0060BA4A File Offset: 0x00609C4A
	static TimeOfDayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayConfig.CreateStaticDefaultValue), new Action(TimeOfDayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B155 RID: 45397
	private List<TTodTimeSpan> DayStateMinuteSpanList = new List<TTodTimeSpan>();

	// Token: 0x0400B156 RID: 45398
	private readonly List<FGameplayTag> BanGameplayTagList = new List<FGameplayTag>();

	// Token: 0x0400B157 RID: 45399
	[Nullable(2)]
	private static TimeOfDayConfig _Instance;
}
