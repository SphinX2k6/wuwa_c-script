using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02002BB2 RID: 11186
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TimeOfDayModel : ModelBase
{
	// Token: 0x17001F50 RID: 8016
	// (get) Token: 0x060172E6 RID: 94950 RVA: 0x005DFF2E File Offset: 0x005DE12E
	public TodDayTime GameTime
	{
		get
		{
			return this.GameTimeInternal;
		}
	}

	// Token: 0x060172E7 RID: 94951 RVA: 0x005DFF36 File Offset: 0x005DE136
	public void SetTimeRunLockStateClient(bool state, bool needNotifyTs = true)
	{
		this.TimeRunLockStateClient = state;
		if (needNotifyTs)
		{
			EventSystem.Instance.Emit<bool>(EEventName.CsRequestLockTimeRunStateClient, state);
		}
	}

	// Token: 0x17001F51 RID: 8017
	// (get) Token: 0x060172E8 RID: 94952 RVA: 0x005DFF53 File Offset: 0x005DE153
	public bool TimeRunLockState
	{
		get
		{
			if (this.IsClientState == null || !this.IsClientState.Value)
			{
				return this.TimeRunLockStateServer;
			}
			return this.TimeRunLockStateClient;
		}
	}

	// Token: 0x060172E9 RID: 94953 RVA: 0x005DFF7C File Offset: 0x005DE17C
	public void SetTimeSyncLockStateClient(bool state, bool needNotifyTs = true)
	{
		this.TimeSyncLockStateClient = state;
		if (needNotifyTs)
		{
			EventSystem.Instance.Emit<bool>(EEventName.CsRequestLockTimeSyncLockStateClient, state);
		}
	}

	// Token: 0x17001F52 RID: 8018
	// (get) Token: 0x060172EA RID: 94954 RVA: 0x005DFF99 File Offset: 0x005DE199
	public bool TimeSynLockState
	{
		get
		{
			if (this.IsClientState == null || !this.IsClientState.Value)
			{
				return this.TimeSyncLockStateServer;
			}
			return this.TimeSyncLockStateClient;
		}
	}

	// Token: 0x060172EB RID: 94955 RVA: 0x005DFFC2 File Offset: 0x005DE1C2
	public double GetPassSceneTime()
	{
		return this.PassSceneTime;
	}

	// Token: 0x060172EC RID: 94956 RVA: 0x005DFFCA File Offset: 0x005DE1CA
	public void SetPassSceneTime(double time)
	{
		this.PassSceneTime = time;
	}

	// Token: 0x17001F53 RID: 8019
	// (get) Token: 0x060172ED RID: 94957 RVA: 0x005DFFD3 File Offset: 0x005DE1D3
	public float OldTimeScale
	{
		get
		{
			return this.OldTimeScaleInternal;
		}
	}

	// Token: 0x060172EE RID: 94958 RVA: 0x005DFFDB File Offset: 0x005DE1DB
	public void SetTimeScale(float value, bool needNotifyTs = true)
	{
		if (this.FreezeTimeScale)
		{
			return;
		}
		if (value < 0f)
		{
			return;
		}
		this.OldTimeScaleInternal = this.TimeScaleInternal;
		this.TimeScaleInternal = value;
		if (needNotifyTs)
		{
			EventSystem.Instance.Emit<float>(EEventName.CsRequestSetTimeScale, value);
		}
	}

	// Token: 0x17001F54 RID: 8020
	// (get) Token: 0x060172EF RID: 94959 RVA: 0x005E0016 File Offset: 0x005DE216
	public float TimeScale
	{
		get
		{
			return this.TimeScaleInternal;
		}
	}

	// Token: 0x060172F0 RID: 94960 RVA: 0x005E001E File Offset: 0x005DE21E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060172F1 RID: 94961 RVA: 0x005E0021 File Offset: 0x005DE221
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060172F2 RID: 94962 RVA: 0x005E0024 File Offset: 0x005DE224
	public void CacheTimeRecords()
	{
		this.CurrentCachedSecondInternal = this.GameTime.Second;
		this.LastCacheRecordTime = Time.Instance.Now;
	}

	// Token: 0x060172F3 RID: 94963 RVA: 0x005E0047 File Offset: 0x005DE247
	public bool CheckCanCacheRecord()
	{
		return this.LastCacheRecordTime == 0.0 || Time.Instance.Now - this.LastCacheRecordTime >= 120000.0;
	}

	// Token: 0x060172F4 RID: 94964 RVA: 0x005E007C File Offset: 0x005DE27C
	public bool IsCurrentTimePassedNormally()
	{
		if (this.CurrentCachedSecondInternal == 0.0)
		{
			return this.GameTime.Second >= 86280.0;
		}
		if (this.GameTime.Second < 120.0)
		{
			return this.CurrentCachedSecondInternal >= 86280.0 + this.GameTime.Second || this.CurrentCachedSecondInternal <= this.GameTime.Second;
		}
		return this.GameTime.Second - this.CurrentCachedSecondInternal > 0.0 && this.GameTime.Second - this.CurrentCachedSecondInternal < 120.0;
	}

	// Token: 0x060172F5 RID: 94965 RVA: 0x005E013C File Offset: 0x005DE33C
	public TimeOfDaySecondItemSt[] GetTimeOfDayShowData()
	{
		List<TimeOfDaySecondItemSt> list = new List<TimeOfDaySecondItemSt>();
		TimeOfDay? config = TimeOfDayConfig.Instance.GetConfig();
		int timePresetLength = config.Value.TimePresetLength;
		int num = 0;
		double second = this.GameTime.Second;
		IReadOnlyList<DaySelectPreset> dayTimeChangePresets = TimeOfDayConfig.Instance.GetDayTimeChangePresets();
		for (int i = 0; i < dayTimeChangePresets.Count; i++)
		{
			for (int j = 0; j < timePresetLength; j++)
			{
				DicIntString? dicIntString = config.Value.TimePreset(j);
				if (dayTimeChangePresets[i].ChangeDayNum != 0 || second <= (double)dicIntString.Value.Key)
				{
					list.Add(new TimeOfDaySecondItemSt
					{
						Id = num,
						ChangeDayIndex = i,
						SetTime = dicIntString.Value.Key,
						ShowName = ConfigMultiTextLang.GetLocalTextNew(dayTimeChangePresets[i].Title, null)
					});
					num++;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x060172F6 RID: 94966 RVA: 0x005E0255 File Offset: 0x005DE455
	public void SetCurrentDay(double day)
	{
		double currentDay = this.CurrentDay;
		this.CurrentDay = day;
	}

	// Token: 0x060172F7 RID: 94967 RVA: 0x005E0267 File Offset: 0x005DE467
	public double GetCurrentDay()
	{
		return this.CurrentDay;
	}

	// Token: 0x060172F8 RID: 94968 RVA: 0x005E0270 File Offset: 0x005DE470
	public void SetUseClientLockState(bool enable)
	{
		this.IsClientState = new bool?(enable);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeOfDay;
		ELogAuthor author = ELogAuthor.FZX;
		string message = "使用客户端时间锁定状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("enable", enable);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x17001F55 RID: 8021
	// (get) Token: 0x060172F9 RID: 94969 RVA: 0x005E02B5 File Offset: 0x005DE4B5
	public static TimeOfDayModel Instance
	{
		get
		{
			return TimeOfDayModel._Instance;
		}
	}

	// Token: 0x060172FA RID: 94970 RVA: 0x005E02BC File Offset: 0x005DE4BC
	public static TimeOfDayModel GetOrCreateInstance()
	{
		if (TimeOfDayModel._Instance == null)
		{
			TimeOfDayModel.CreateInstance();
		}
		return TimeOfDayModel._Instance;
	}

	// Token: 0x060172FB RID: 94971 RVA: 0x005E02D0 File Offset: 0x005DE4D0
	public static bool CreateInstance()
	{
		if (TimeOfDayModel._Instance != null)
		{
			return true;
		}
		TimeOfDayModel._Instance = new TimeOfDayModel();
		return true;
	}

	// Token: 0x060172FC RID: 94972 RVA: 0x005E02E6 File Offset: 0x005DE4E6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060172FD RID: 94973 RVA: 0x005E02E8 File Offset: 0x005DE4E8
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayModel._Instance = null;
	}

	// Token: 0x060172FE RID: 94974 RVA: 0x005E02F0 File Offset: 0x005DE4F0
	static TimeOfDayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayModel.CreateStaticDefaultValue), new Action(TimeOfDayModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AD80 RID: 44416
	private readonly TodDayTime GameTimeInternal = new TodDayTime();

	// Token: 0x0400AD81 RID: 44417
	private double LastCacheRecordTime;

	// Token: 0x0400AD82 RID: 44418
	private float TimeScaleInternal = 1f;

	// Token: 0x0400AD83 RID: 44419
	private float OldTimeScaleInternal = 1f;

	// Token: 0x0400AD84 RID: 44420
	public bool FreezeTimeScale;

	// Token: 0x0400AD85 RID: 44421
	[Nullable(2)]
	public string PlayerAccount;

	// Token: 0x0400AD86 RID: 44422
	[Nullable(2)]
	public TimeOfDaySecondItemSt CurrentSelectTimeItemSt;

	// Token: 0x0400AD87 RID: 44423
	private double CurrentCachedSecondInternal;

	// Token: 0x0400AD88 RID: 44424
	private double CurrentDay;

	// Token: 0x0400AD89 RID: 44425
	private double PassSceneTime;

	// Token: 0x0400AD8A RID: 44426
	private bool? IsClientState;

	// Token: 0x0400AD8B RID: 44427
	public bool TimeRunLockStateClient;

	// Token: 0x0400AD8C RID: 44428
	public bool TimeRunLockStateServer;

	// Token: 0x0400AD8D RID: 44429
	public bool TimeSyncLockStateClient;

	// Token: 0x0400AD8E RID: 44430
	public bool TimeSyncLockStateServer;

	// Token: 0x0400AD8F RID: 44431
	[Nullable(2)]
	private static TimeOfDayModel _Instance;
}
