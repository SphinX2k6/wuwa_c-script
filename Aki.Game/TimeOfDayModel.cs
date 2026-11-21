using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x0200212E RID: 8494
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TimeOfDayModel : ModelBase
{
	// Token: 0x17001FA8 RID: 8104
	// (get) Token: 0x06014D17 RID: 85271 RVA: 0x0060CB02 File Offset: 0x0060AD02
	public TodDayTime GameTime
	{
		get
		{
			return this.GameTimeInternal;
		}
	}

	// Token: 0x06014D18 RID: 85272 RVA: 0x0060CB0A File Offset: 0x0060AD0A
	public void SetTimeRunLockStateClient(bool state, bool needNotifyTs = true)
	{
		this.TimeRunLockStateClient = state;
		if (needNotifyTs)
		{
			EventSystem.Instance.Emit<bool>(EEventName.CsRequestLockTimeRunStateClient, state);
		}
	}

	// Token: 0x17001FA9 RID: 8105
	// (get) Token: 0x06014D19 RID: 85273 RVA: 0x0060CB27 File Offset: 0x0060AD27
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

	// Token: 0x06014D1A RID: 85274 RVA: 0x0060CB50 File Offset: 0x0060AD50
	public void SetTimeSyncLockStateClient(bool state, bool needNotifyTs = true)
	{
		this.TimeSyncLockStateClient = state;
		if (needNotifyTs)
		{
			EventSystem.Instance.Emit<bool>(EEventName.CsRequestLockTimeSyncLockStateClient, state);
		}
	}

	// Token: 0x17001FAA RID: 8106
	// (get) Token: 0x06014D1B RID: 85275 RVA: 0x0060CB6D File Offset: 0x0060AD6D
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

	// Token: 0x06014D1C RID: 85276 RVA: 0x0060CB96 File Offset: 0x0060AD96
	public double GetPassSceneTime()
	{
		return this.PassSceneTime;
	}

	// Token: 0x06014D1D RID: 85277 RVA: 0x0060CB9E File Offset: 0x0060AD9E
	public void SetPassSceneTime(double time)
	{
		this.PassSceneTime = time;
	}

	// Token: 0x17001FAB RID: 8107
	// (get) Token: 0x06014D1E RID: 85278 RVA: 0x0060CBA7 File Offset: 0x0060ADA7
	public float OldTimeScale
	{
		get
		{
			return this.OldTimeScaleInternal;
		}
	}

	// Token: 0x06014D1F RID: 85279 RVA: 0x0060CBAF File Offset: 0x0060ADAF
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

	// Token: 0x17001FAC RID: 8108
	// (get) Token: 0x06014D20 RID: 85280 RVA: 0x0060CBEA File Offset: 0x0060ADEA
	public float TimeScale
	{
		get
		{
			return this.TimeScaleInternal;
		}
	}

	// Token: 0x06014D21 RID: 85281 RVA: 0x0060CBF2 File Offset: 0x0060ADF2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06014D22 RID: 85282 RVA: 0x0060CBF5 File Offset: 0x0060ADF5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06014D23 RID: 85283 RVA: 0x0060CBF8 File Offset: 0x0060ADF8
	public void CacheTimeRecords()
	{
		this.CurrentCachedSecondInternal = this.GameTime.Second;
		this.LastCacheRecordTime = Time.Instance.Now;
	}

	// Token: 0x06014D24 RID: 85284 RVA: 0x0060CC1B File Offset: 0x0060AE1B
	public bool CheckCanCacheRecord()
	{
		return this.LastCacheRecordTime == 0.0 || Time.Instance.Now - this.LastCacheRecordTime >= 120000.0;
	}

	// Token: 0x06014D25 RID: 85285 RVA: 0x0060CC50 File Offset: 0x0060AE50
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

	// Token: 0x06014D26 RID: 85286 RVA: 0x0060CD10 File Offset: 0x0060AF10
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

	// Token: 0x06014D27 RID: 85287 RVA: 0x0060CE29 File Offset: 0x0060B029
	public void SetCurrentDay(double day)
	{
		double currentDay = this.CurrentDay;
		this.CurrentDay = day;
	}

	// Token: 0x06014D28 RID: 85288 RVA: 0x0060CE3B File Offset: 0x0060B03B
	public double GetCurrentDay()
	{
		return this.CurrentDay;
	}

	// Token: 0x06014D29 RID: 85289 RVA: 0x0060CE44 File Offset: 0x0060B044
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

	// Token: 0x17001FAD RID: 8109
	// (get) Token: 0x06014D2A RID: 85290 RVA: 0x0060CE89 File Offset: 0x0060B089
	public static TimeOfDayModel Instance
	{
		get
		{
			return TimeOfDayModel._Instance;
		}
	}

	// Token: 0x06014D2B RID: 85291 RVA: 0x0060CE90 File Offset: 0x0060B090
	public static TimeOfDayModel GetOrCreateInstance()
	{
		if (TimeOfDayModel._Instance == null)
		{
			TimeOfDayModel.CreateInstance();
		}
		return TimeOfDayModel._Instance;
	}

	// Token: 0x06014D2C RID: 85292 RVA: 0x0060CEA4 File Offset: 0x0060B0A4
	public static bool CreateInstance()
	{
		if (TimeOfDayModel._Instance != null)
		{
			return true;
		}
		TimeOfDayModel._Instance = new TimeOfDayModel();
		return true;
	}

	// Token: 0x06014D2D RID: 85293 RVA: 0x0060CEBA File Offset: 0x0060B0BA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014D2E RID: 85294 RVA: 0x0060CEBC File Offset: 0x0060B0BC
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayModel._Instance = null;
	}

	// Token: 0x06014D2F RID: 85295 RVA: 0x0060CEC4 File Offset: 0x0060B0C4
	static TimeOfDayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayModel.CreateStaticDefaultValue), new Action(TimeOfDayModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B187 RID: 45447
	private readonly TodDayTime GameTimeInternal = new TodDayTime();

	// Token: 0x0400B188 RID: 45448
	private double LastCacheRecordTime;

	// Token: 0x0400B189 RID: 45449
	private float TimeScaleInternal = 1f;

	// Token: 0x0400B18A RID: 45450
	private float OldTimeScaleInternal = 1f;

	// Token: 0x0400B18B RID: 45451
	public bool FreezeTimeScale;

	// Token: 0x0400B18C RID: 45452
	[Nullable(2)]
	public string PlayerAccount;

	// Token: 0x0400B18D RID: 45453
	[Nullable(2)]
	public TimeOfDaySecondItemSt CurrentSelectTimeItemSt;

	// Token: 0x0400B18E RID: 45454
	private double CurrentCachedSecondInternal;

	// Token: 0x0400B18F RID: 45455
	private double CurrentDay;

	// Token: 0x0400B190 RID: 45456
	private double PassSceneTime;

	// Token: 0x0400B191 RID: 45457
	private bool? IsClientState;

	// Token: 0x0400B192 RID: 45458
	public bool TimeRunLockStateClient;

	// Token: 0x0400B193 RID: 45459
	public bool TimeRunLockStateServer;

	// Token: 0x0400B194 RID: 45460
	public bool TimeSyncLockStateClient;

	// Token: 0x0400B195 RID: 45461
	public bool TimeSyncLockStateServer;

	// Token: 0x0400B196 RID: 45462
	[Nullable(2)]
	private static TimeOfDayModel _Instance;
}
