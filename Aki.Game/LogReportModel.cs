using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001668 RID: 5736
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LogReportModel : ModelBase
{
	// Token: 0x0600DF49 RID: 57161 RVA: 0x004190BC File Offset: 0x004172BC
	protected override bool OnInit()
	{
		this.TimerAssemblyLogDataMap.Add("1012", new ExploreToolAssemblyLogData("1001"));
		this.TimerAssemblyLogDataMap.Add("1013", new ExploreToolAssemblyLogData("1003"));
		this.TimerAssemblyLogDataMap.Add("1014", new ExploreToolAssemblyLogData("1004"));
		this.TimerAssemblyLogDataMap.Add("1025", new ExploreToolAssemblyLogData("1013"));
		return true;
	}

	// Token: 0x17001559 RID: 5465
	// (get) Token: 0x0600DF4A RID: 57162 RVA: 0x00419132 File Offset: 0x00417332
	public double HangUpTime
	{
		get
		{
			return this.HangUpTimeInternal;
		}
	}

	// Token: 0x0600DF4B RID: 57163 RVA: 0x0041913C File Offset: 0x0041733C
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

	// Token: 0x0600DF4C RID: 57164 RVA: 0x004191EC File Offset: 0x004173EC
	public void SetTimerAssemblyLogData(string eventId, AssemblyLogData assemblyLogData)
	{
		this.TimerAssemblyLogDataMap[eventId] = assemblyLogData;
	}

	// Token: 0x0600DF4D RID: 57165 RVA: 0x004191FB File Offset: 0x004173FB
	[return: Nullable(2)]
	public AssemblyLogData GetTimerAssemblyLogData(string eventId)
	{
		return this.TimerAssemblyLogDataMap.GetValueOrDefault(eventId);
	}

	// Token: 0x0600DF4E RID: 57166 RVA: 0x00419209 File Offset: 0x00417409
	public ICollection<AssemblyLogData> GetAllTimerAssemblyLogData()
	{
		return this.TimerAssemblyLogDataMap.Values;
	}

	// Token: 0x0600DF4F RID: 57167 RVA: 0x00419218 File Offset: 0x00417418
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

	// Token: 0x1700155A RID: 5466
	// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x00419276 File Offset: 0x00417476
	public static LogReportModel Instance
	{
		get
		{
			return LogReportModel._Instance;
		}
	}

	// Token: 0x0600DF51 RID: 57169 RVA: 0x0041927D File Offset: 0x0041747D
	public static LogReportModel GetOrCreateInstance()
	{
		if (LogReportModel._Instance == null)
		{
			LogReportModel.CreateInstance();
		}
		return LogReportModel._Instance;
	}

	// Token: 0x0600DF52 RID: 57170 RVA: 0x00419291 File Offset: 0x00417491
	public static bool CreateInstance()
	{
		if (LogReportModel._Instance != null)
		{
			return true;
		}
		LogReportModel._Instance = new LogReportModel();
		return true;
	}

	// Token: 0x0600DF53 RID: 57171 RVA: 0x004192A7 File Offset: 0x004174A7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DF54 RID: 57172 RVA: 0x004192A9 File Offset: 0x004174A9
	public static void ResetStaticDefaultValue()
	{
		LogReportModel._Instance = null;
	}

	// Token: 0x0600DF55 RID: 57173 RVA: 0x004192B1 File Offset: 0x004174B1
	static LogReportModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportModel.CreateStaticDefaultValue), new Action(LogReportModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008038 RID: 32824
	private const int RECORD_HANG_UP_OFFSET = 30;

	// Token: 0x04008039 RID: 32825
	private double LastOperateTime;

	// Token: 0x0400803A RID: 32826
	private double HangUpTimeInternal;

	// Token: 0x0400803B RID: 32827
	private readonly Dictionary<string, double> HangUpRecord = new Dictionary<string, double>();

	// Token: 0x0400803C RID: 32828
	private readonly Dictionary<string, AssemblyLogData> TimerAssemblyLogDataMap = new Dictionary<string, AssemblyLogData>();

	// Token: 0x0400803D RID: 32829
	[Nullable(2)]
	private static LogReportModel _Instance;
}
