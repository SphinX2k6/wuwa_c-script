using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002184 RID: 8580
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LogReportModel : ModelBase
{
	// Token: 0x06010AB8 RID: 68280 RVA: 0x0040C7E0 File Offset: 0x0040A9E0
	protected override bool OnInit()
	{
		this.TimerAssemblyLogDataMap.Add("1012", new ExploreToolAssemblyLogData("1001"));
		this.TimerAssemblyLogDataMap.Add("1013", new ExploreToolAssemblyLogData("1003"));
		this.TimerAssemblyLogDataMap.Add("1014", new ExploreToolAssemblyLogData("1004"));
		this.TimerAssemblyLogDataMap.Add("1025", new ExploreToolAssemblyLogData("1013"));
		return true;
	}

	// Token: 0x17001522 RID: 5410
	// (get) Token: 0x06010AB9 RID: 68281 RVA: 0x0040C856 File Offset: 0x0040AA56
	public double HangUpTime
	{
		get
		{
			return this.HangUpTimeInternal;
		}
	}

	// Token: 0x06010ABA RID: 68282 RVA: 0x0040C860 File Offset: 0x0040AA60
	public void RecordOperateTime(bool isCheck = false, string key = "", double value = 0.0)
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (this.LastOperateTime == 0.0)
		{
			this.LastOperateTime = serverTimeStamp;
		}
		if (isCheck && !string.IsNullOrEmpty(key))
		{
			double num;
			if (this.HangUpRecord.TryGetValue(key, out num) && num == value)
			{
				return;
			}
			this.HangUpRecord[key] = value;
		}
		double num2 = (serverTimeStamp - this.LastOperateTime) * TimeUtil.Instance.Millisecond;
		if (num2 > 30.0)
		{
			this.HangUpTimeInternal += num2;
			HangUpTimeLogData hangUpTimeLogData = new HangUpTimeLogData();
			hangUpTimeLogData.f_hang_up_time = num2.ToString();
			LogReportController.Instance.LogReport(hangUpTimeLogData);
		}
		this.LastOperateTime = serverTimeStamp;
	}

	// Token: 0x06010ABB RID: 68283 RVA: 0x0040C910 File Offset: 0x0040AB10
	public void SetTimerAssemblyLogData(string eventId, AssemblyLogData assemblyLogData)
	{
		this.TimerAssemblyLogDataMap[eventId] = assemblyLogData;
	}

	// Token: 0x06010ABC RID: 68284 RVA: 0x0040C91F File Offset: 0x0040AB1F
	[return: Nullable(2)]
	public AssemblyLogData GetTimerAssemblyLogData(string eventId)
	{
		return this.TimerAssemblyLogDataMap.GetValueOrDefault(eventId);
	}

	// Token: 0x06010ABD RID: 68285 RVA: 0x0040C92D File Offset: 0x0040AB2D
	public ICollection<AssemblyLogData> GetAllTimerAssemblyLogData()
	{
		return this.TimerAssemblyLogDataMap.Values;
	}

	// Token: 0x06010ABE RID: 68286 RVA: 0x0040C93C File Offset: 0x0040AB3C
	public PresetProperties GetPresetProperties()
	{
		PresetProperties presetProperties = new PresetProperties();
		presetProperties.system_language = UKismetInternationalizationLibrary.GetCurrentLanguage();
		presetProperties.os_version = UKuroStaticLibrary.GetOSVersion();
		presetProperties.device_id = UThinkingAnalytics.GetDeviceId(0);
		FVector2D gameResolution = UKuroRenderingRuntimeBPPluginBPLibrary.GetGameResolution();
		presetProperties.screen_height = gameResolution.Y.ToString();
		presetProperties.screen_width = gameResolution.X.ToString();
		return presetProperties;
	}

	// Token: 0x17001523 RID: 5411
	// (get) Token: 0x06010ABF RID: 68287 RVA: 0x0040C99A File Offset: 0x0040AB9A
	public static LogReportModel Instance
	{
		get
		{
			return LogReportModel._Instance;
		}
	}

	// Token: 0x06010AC0 RID: 68288 RVA: 0x0040C9A1 File Offset: 0x0040ABA1
	public static LogReportModel GetOrCreateInstance()
	{
		if (LogReportModel._Instance == null)
		{
			LogReportModel.CreateInstance();
		}
		return LogReportModel._Instance;
	}

	// Token: 0x06010AC1 RID: 68289 RVA: 0x0040C9B5 File Offset: 0x0040ABB5
	public static bool CreateInstance()
	{
		if (LogReportModel._Instance != null)
		{
			return true;
		}
		LogReportModel._Instance = new LogReportModel();
		return true;
	}

	// Token: 0x06010AC2 RID: 68290 RVA: 0x0040C9CB File Offset: 0x0040ABCB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010AC3 RID: 68291 RVA: 0x0040C9CD File Offset: 0x0040ABCD
	public static void ResetStaticDefaultValue()
	{
		LogReportModel._Instance = null;
	}

	// Token: 0x06010AC4 RID: 68292 RVA: 0x0040C9D5 File Offset: 0x0040ABD5
	static LogReportModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportModel.CreateStaticDefaultValue), new Action(LogReportModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007EF1 RID: 32497
	private const int RECORD_HANG_UP_OFFSET = 30;

	// Token: 0x04007EF2 RID: 32498
	private double LastOperateTime;

	// Token: 0x04007EF3 RID: 32499
	private double HangUpTimeInternal;

	// Token: 0x04007EF4 RID: 32500
	private readonly Dictionary<string, double> HangUpRecord = new Dictionary<string, double>();

	// Token: 0x04007EF5 RID: 32501
	private readonly Dictionary<string, AssemblyLogData> TimerAssemblyLogDataMap = new Dictionary<string, AssemblyLogData>();

	// Token: 0x04007EF6 RID: 32502
	[Nullable(2)]
	private static LogReportModel _Instance;
}
