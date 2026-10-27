using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002BAB RID: 11179
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TimeOfDayConfig : ConfigBase
{
	// Token: 0x06017282 RID: 94850 RVA: 0x005DEAA5 File Offset: 0x005DCCA5
	public TimeOfDay? GetConfig()
	{
		return ConfigTimeOfDayById.GetConfig(1, true);
	}

	// Token: 0x06017283 RID: 94851 RVA: 0x005DEAB0 File Offset: 0x005DCCB0
	public double GetInitTimeSecond()
	{
		TimeOfDay? timeOfDay;
		return (double)(((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().InitTime : 0) * 60);
	}

	// Token: 0x06017284 RID: 94852 RVA: 0x005DEAE4 File Offset: 0x005DCCE4
	public double GetMaxV()
	{
		TimeOfDay? timeOfDay;
		return (double)(60 * ((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().V : 0));
	}

	// Token: 0x06017285 RID: 94853 RVA: 0x005DEB18 File Offset: 0x005DCD18
	public double GetA()
	{
		TimeOfDay? timeOfDay;
		return (double)(60 * ((this.GetConfig() != null) ? timeOfDay.GetValueOrDefault().A : 0));
	}

	// Token: 0x06017286 RID: 94854 RVA: 0x005DEB4C File Offset: 0x005DCD4C
	public double GetRate()
	{
		if (this.GetConfig() == null)
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "时间流速比未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0.0;
		}
		return (double)this.GetConfig().Value.Rate;
	}

	// Token: 0x06017287 RID: 94855 RVA: 0x005DEBA8 File Offset: 0x005DCDA8
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

	// Token: 0x06017288 RID: 94856 RVA: 0x005DEC88 File Offset: 0x005DCE88
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

	// Token: 0x06017289 RID: 94857 RVA: 0x005DED44 File Offset: 0x005DCF44
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

	// Token: 0x0601728A RID: 94858 RVA: 0x005DEDD1 File Offset: 0x005DCFD1
	[NullableContext(2)]
	public IReadOnlyList<DaySelectPreset> GetDayTimeChangePresets()
	{
		return ConfigDaySelectPresetAll.GetConfigList(true);
	}

	// Token: 0x0601728B RID: 94859 RVA: 0x005DEDDC File Offset: 0x005DCFDC
	public DaySelectPreset? GetDayTimeChangeConfig(int id)
	{
		DaySelectPreset? config = ConfigDaySelectPresetById.GetConfig(id, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x0601728C RID: 94860 RVA: 0x005DEE08 File Offset: 0x005DD008
	public string GetTimeChangeText(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetDayTimeChangeConfig(id).Value.Title, null) ?? "";
	}

	// Token: 0x17001F46 RID: 8006
	// (get) Token: 0x0601728D RID: 94861 RVA: 0x005DEE3B File Offset: 0x005DD03B
	public static TimeOfDayConfig Instance
	{
		get
		{
			return TimeOfDayConfig._Instance;
		}
	}

	// Token: 0x0601728E RID: 94862 RVA: 0x005DEE42 File Offset: 0x005DD042
	public static TimeOfDayConfig GetOrCreateInstance()
	{
		if (TimeOfDayConfig._Instance == null)
		{
			TimeOfDayConfig.CreateInstance();
		}
		return TimeOfDayConfig._Instance;
	}

	// Token: 0x0601728F RID: 94863 RVA: 0x005DEE56 File Offset: 0x005DD056
	public static bool CreateInstance()
	{
		if (TimeOfDayConfig._Instance != null)
		{
			return true;
		}
		TimeOfDayConfig._Instance = new TimeOfDayConfig();
		return true;
	}

	// Token: 0x06017290 RID: 94864 RVA: 0x005DEE6C File Offset: 0x005DD06C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017291 RID: 94865 RVA: 0x005DEE6E File Offset: 0x005DD06E
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayConfig._Instance = null;
	}

	// Token: 0x06017292 RID: 94866 RVA: 0x005DEE76 File Offset: 0x005DD076
	static TimeOfDayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayConfig.CreateStaticDefaultValue), new Action(TimeOfDayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AD4E RID: 44366
	private List<TTodTimeSpan> DayStateMinuteSpanList = new List<TTodTimeSpan>();

	// Token: 0x0400AD4F RID: 44367
	private readonly List<FGameplayTag> BanGameplayTagList = new List<FGameplayTag>();

	// Token: 0x0400AD50 RID: 44368
	[Nullable(2)]
	private static TimeOfDayConfig _Instance;
}
