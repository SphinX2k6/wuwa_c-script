using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02003512 RID: 13586
[NullableContext(1)]
[Nullable(0)]
public class TimeScheduleConfig : ConfigBase
{
	// Token: 0x0601DC79 RID: 121977 RVA: 0x00857D9D File Offset: 0x00855F9D
	protected override bool OnInit()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601DC7A RID: 121978 RVA: 0x00857DAB File Offset: 0x00855FAB
	protected override bool OnClear()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601DC7B RID: 121979 RVA: 0x00857DBC File Offset: 0x00855FBC
	[NullableContext(2)]
	public RawTimeScheduleConfigData GetTimeScheduleData(int id)
	{
		if (PublicUtil.Instance.UseDbConfig())
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
		else
		{
			this.ParseConfigFromJsonFile();
			RawTimeScheduleConfigData result2;
			if (this.ConfigDataMap.TryGetValue(id, out result2))
			{
				return result2;
			}
			return null;
		}
	}

	// Token: 0x0601DC7C RID: 121980 RVA: 0x00857E3C File Offset: 0x0085603C
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

	// Token: 0x0601DC7D RID: 121981 RVA: 0x00857EDC File Offset: 0x008560DC
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

	// Token: 0x1700290D RID: 10509
	// (get) Token: 0x0601DC7E RID: 121982 RVA: 0x00857FB0 File Offset: 0x008561B0
	public static TimeScheduleConfig Instance
	{
		get
		{
			return TimeScheduleConfig._Instance;
		}
	}

	// Token: 0x0601DC7F RID: 121983 RVA: 0x00857FB7 File Offset: 0x008561B7
	public static TimeScheduleConfig GetOrCreateInstance()
	{
		if (TimeScheduleConfig._Instance == null)
		{
			TimeScheduleConfig.CreateInstance();
		}
		return TimeScheduleConfig._Instance;
	}

	// Token: 0x0601DC80 RID: 121984 RVA: 0x00857FCB File Offset: 0x008561CB
	public static bool CreateInstance()
	{
		if (TimeScheduleConfig._Instance != null)
		{
			return true;
		}
		TimeScheduleConfig._Instance = new TimeScheduleConfig();
		return true;
	}

	// Token: 0x0601DC81 RID: 121985 RVA: 0x00857FE1 File Offset: 0x008561E1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DC82 RID: 121986 RVA: 0x00857FE3 File Offset: 0x008561E3
	public static void ResetStaticDefaultValue()
	{
		TimeScheduleConfig._Instance = null;
	}

	// Token: 0x0601DC83 RID: 121987 RVA: 0x00857FEB File Offset: 0x008561EB
	static TimeScheduleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeScheduleConfig.CreateStaticDefaultValue), new Action(TimeScheduleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E9BA RID: 59834
	private readonly Dictionary<int, RawTimeScheduleConfigData> ConfigDataMap = new Dictionary<int, RawTimeScheduleConfigData>();

	// Token: 0x0400E9BB RID: 59835
	[Nullable(2)]
	private static TimeScheduleConfig _Instance;
}
