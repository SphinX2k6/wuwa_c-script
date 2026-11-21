using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002A87 RID: 10887
[NullableContext(1)]
[Nullable(0)]
public class TimeScheduleConfig : ConfigBase
{
	// Token: 0x0601B993 RID: 113043 RVA: 0x00880369 File Offset: 0x0087E569
	protected override bool OnInit()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601B994 RID: 113044 RVA: 0x00880377 File Offset: 0x0087E577
	protected override bool OnClear()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601B995 RID: 113045 RVA: 0x00880388 File Offset: 0x0087E588
	[NullableContext(2)]
	public RawTimeScheduleConfigData GetTimeScheduleData(int id)
	{
		if (!this.ConfigDataMap.ContainsKey(id))
		{
			TimeSchedule? config = ConfigTimeScheduleById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			this.ConfigDataMap[id] = TimeScheduleConfig.FbToTimeScheduleData(config.Value);
		}
		RawTimeScheduleConfigData result;
		if (!this.ConfigDataMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601B996 RID: 113046 RVA: 0x008803E4 File Offset: 0x0087E5E4
	private static RawTimeScheduleConfigData FbToTimeScheduleData(TimeSchedule fb)
	{
		return new RawTimeScheduleConfigData
		{
			Id = fb.Id,
			TimeScheduleTag = (fb.TimeScheduleTag ?? ""),
			StartTime = (fb.StartTime ?? ""),
			Position = fb.GetPositionArray(),
			Rotation = fb.GetRotationArray(),
			BehaviorTree = fb.BehaviorTree,
			SplineEntityUid = (fb.SplineEntityUid ?? ""),
			CommonBtOverride = (fb.CommonBtOverride ?? "")
		};
	}

	// Token: 0x0601B997 RID: 113047 RVA: 0x00880484 File Offset: 0x0087E684
	private void ParseConfigFromJsonFile()
	{
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/TimeSchedule.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/TimeSchedule.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "不存在TimeSchedule.json文件。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, configPath);
		List<RawTimeScheduleConfigData> list = Json.Parse<List<RawTimeScheduleConfigData>>(text, null);
		if (list == null)
		{
			return;
		}
		foreach (RawTimeScheduleConfigData rawTimeScheduleConfigData in list)
		{
			this.ConfigDataMap[rawTimeScheduleConfigData.Id] = rawTimeScheduleConfigData;
		}
	}

	// Token: 0x17002CA6 RID: 11430
	// (get) Token: 0x0601B998 RID: 113048 RVA: 0x00880558 File Offset: 0x0087E758
	public static TimeScheduleConfig Instance
	{
		get
		{
			return TimeScheduleConfig._Instance;
		}
	}

	// Token: 0x0601B999 RID: 113049 RVA: 0x0088055F File Offset: 0x0087E75F
	public static TimeScheduleConfig GetOrCreateInstance()
	{
		if (TimeScheduleConfig._Instance == null)
		{
			TimeScheduleConfig.CreateInstance();
		}
		return TimeScheduleConfig._Instance;
	}

	// Token: 0x0601B99A RID: 113050 RVA: 0x00880573 File Offset: 0x0087E773
	public static bool CreateInstance()
	{
		if (TimeScheduleConfig._Instance != null)
		{
			return true;
		}
		TimeScheduleConfig._Instance = new TimeScheduleConfig();
		return true;
	}

	// Token: 0x0601B99B RID: 113051 RVA: 0x00880589 File Offset: 0x0087E789
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B99C RID: 113052 RVA: 0x0088058B File Offset: 0x0087E78B
	public static void ResetStaticDefaultValue()
	{
		TimeScheduleConfig._Instance = null;
	}

	// Token: 0x0601B99D RID: 113053 RVA: 0x00880593 File Offset: 0x0087E793
	static TimeScheduleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeScheduleConfig.CreateStaticDefaultValue), new Action(TimeScheduleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EE75 RID: 61045
	private readonly Dictionary<int, RawTimeScheduleConfigData> ConfigDataMap = new Dictionary<int, RawTimeScheduleConfigData>();

	// Token: 0x0400EE76 RID: 61046
	[Nullable(2)]
	private static TimeScheduleConfig _Instance;
}
