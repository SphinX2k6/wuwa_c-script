using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020000BF RID: 191
[NullableContext(1)]
[Nullable(0)]
public class LoadModeManager : Singleton
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060005E2 RID: 1506 RVA: 0x0001F528 File Offset: 0x0001D728
	// (remove) Token: 0x060005E3 RID: 1507 RVA: 0x0001F560 File Offset: 0x0001D760
	[Nullable(2)]
	[method: NullableContext(2)]
	[Nullable(2)]
	public event Action<ELoadMode> LoadModeApplied;

	// Token: 0x060005E4 RID: 1508 RVA: 0x0001F598 File Offset: 0x0001D798
	private ILoadModeHandler GetHandlerByLoadMode(ELoadMode mode)
	{
		LoadModeManager.LoadModeData loadModeData = this.LoadModeToDataRecord[mode];
		if (loadModeData.HandlerInstance != null)
		{
			return loadModeData.HandlerInstance;
		}
		loadModeData.HandlerInstance = loadModeData.HandlerCtor();
		return loadModeData.HandlerInstance;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
	private void CheckAndUpdateLoadMode()
	{
		this.UpdateLoadMode(this.GetTargetLoadMode());
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
	private ELoadMode GetTargetLoadMode()
	{
		ELoadMode targetLoadMode = ELoadMode.InGame;
		IEnumerable<ELoadMode> values = this.ReasonToLoadMode.Values;
		Func<ELoadMode, bool> <>9__0;
		Func<ELoadMode, bool> predicate;
		if ((predicate = <>9__0) == null)
		{
			predicate = (<>9__0 = ((ELoadMode mode) => this.LoadModeToDataRecord[mode].Priority > this.LoadModeToDataRecord[targetLoadMode].Priority));
		}
		foreach (ELoadMode targetLoadMode2 in values.Where(predicate))
		{
			targetLoadMode = targetLoadMode2;
		}
		return targetLoadMode;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0001F678 File Offset: 0x0001D878
	private unsafe void UpdateLoadMode(ELoadMode newLoadMode)
	{
		if (newLoadMode == this.LoadMode)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "[LoadModeManager] UpdateLoadMode";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldLoadMode", this.LoadMode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewLoadMode", newLoadMode);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.GetHandlerByLoadMode(this.LoadMode).ExitMode(Info.Instance.GameInstance);
		this.LoadMode = newLoadMode;
		this.GetHandlerByLoadMode(newLoadMode).EnterMode(Info.Instance.GameInstance);
		this.AfterUpdateLoadMode();
		Action<ELoadMode> loadModeApplied = this.LoadModeApplied;
		if (loadModeApplied == null)
		{
			return;
		}
		loadModeApplied(newLoadMode);
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0001F740 File Offset: 0x0001D940
	private void AfterUpdateLoadMode()
	{
		this.DisableLoadModeResetTimer();
		int sharedStayTimeLimit = this.LoadModeToDataRecord[this.LoadMode].SharedStayTimeLimit;
		if (sharedStayTimeLimit > 0)
		{
			this.EnableLoadModeResetTimer(sharedStayTimeLimit);
		}
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0001F775 File Offset: 0x0001D975
	private void EnableLoadModeResetTimer(int timeLimit)
	{
		this.DisableLoadModeResetTimer();
		this.LoadModeResetTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[LoadModeManager] 长时间处于限时LoadMode中，触发超时重置保底";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LoadMode", this.LoadMode);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DisableLoadModeResetTimer();
			this.ClearReasonAndResetLoadMode("LoadModeManager内部超时重置保底");
		}, (float)timeLimit, null, "LoadModeResetTimer", false, 1f);
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x0001F7A7 File Offset: 0x0001D9A7
	private void DisableLoadModeResetTimer()
	{
		if (this.LoadModeResetTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.LoadModeResetTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LoadModeResetTimerHandle);
		}
		this.LoadModeResetTimerHandle = null;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0001F7DB File Offset: 0x0001D9DB
	public ELoadMode GetLoadMode()
	{
		return this.LoadMode;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
	public unsafe void SetLoadModeByReason(ELoadMode mode, ELoadModeReason reason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "[LoadModeManager] SetLoadModeByReason";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LoadMode", mode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ELoadMode eloadMode = mode;
		if (mode == ELoadMode.None)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameMode;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[LoadModeManager] SetLoadModeByReason时发现传入了不允许外部设置的LoadMode，自动转为InGame";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			eloadMode = ELoadMode.InGame;
		}
		if (eloadMode == ELoadMode.InGame)
		{
			if (this.LoadMode != ELoadMode.None && !this.IsReasonTargetNotDefault(reason))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.GameMode;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[LoadModeManager] SetLoadModeByReason时发现不成对";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TargetLoadMode", eloadMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurrentLoadMode", this.ReasonToLoadMode.GetValueOrDefault(reason, ELoadMode.None));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", reason);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			this.ReasonToLoadMode.Remove(reason);
		}
		else
		{
			this.ReasonToLoadMode[reason] = eloadMode;
		}
		this.CheckAndUpdateLoadMode();
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0001F947 File Offset: 0x0001DB47
	public void ResetLoadModeByReason(ELoadModeReason reason)
	{
		this.SetLoadModeByReason(ELoadMode.InGame, reason);
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0001F951 File Offset: 0x0001DB51
	public bool IsReasonTargetNotDefault(ELoadModeReason reason)
	{
		return this.ReasonToLoadMode.GetValueOrDefault(reason, ELoadMode.InGame) != ELoadMode.InGame;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0001F968 File Offset: 0x0001DB68
	public unsafe void ClearReasonAndResetLoadMode(string debugReason)
	{
		if (this.ReasonToLoadMode.Count > 0 || this.GetLoadMode() != ELoadMode.InGame)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[LoadModeManager] 调用了特殊接口清除所有设置LoadMode的原因并重置LoadMode";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DebugReason", debugReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentLoadMode", this.GetLoadMode());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentReasonMap", this.ReasonToLoadMode);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		this.ReasonToLoadMode.Clear();
		this.CheckAndUpdateLoadMode();
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0001FA18 File Offset: 0x0001DC18
	public bool IsLoadModeInGameOrForceInGame()
	{
		ELoadMode loadMode = this.LoadMode;
		return loadMode == ELoadMode.InGame || loadMode == ELoadMode.ForceInGame;
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001FA3B File Offset: 0x0001DC3B
	public static LoadModeManager Instance
	{
		get
		{
			if (LoadModeManager._instance == null)
			{
				LoadModeManager._instance = new LoadModeManager();
				LoadModeManager._instance.OnInit();
			}
			return LoadModeManager._instance;
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0001FA5E File Offset: 0x0001DC5E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0001FA60 File Offset: 0x0001DC60
	public static void ResetStaticDefaultValue()
	{
		LoadModeManager instance = LoadModeManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LoadModeManager._instance = null;
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0001FA79 File Offset: 0x0001DC79
	static LoadModeManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadModeManager.CreateStaticDefaultValue), new Action(LoadModeManager.ResetStaticDefaultValue));
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001FA98 File Offset: 0x0001DC98
	public LoadModeManager()
	{
		Dictionary<ELoadMode, LoadModeManager.LoadModeData> dictionary = new Dictionary<ELoadMode, LoadModeManager.LoadModeData>();
		ELoadMode key = ELoadMode.None;
		LoadModeManager.LoadModeData loadModeData = new LoadModeManager.LoadModeData();
		loadModeData.Priority = -1;
		loadModeData.SharedStayTimeLimit = -1;
		loadModeData.HandlerCtor = (() => new LoadModeHandlerNone());
		dictionary.Add(key, loadModeData);
		ELoadMode key2 = ELoadMode.InGame;
		LoadModeManager.LoadModeData loadModeData2 = new LoadModeManager.LoadModeData();
		loadModeData2.Priority = 0;
		loadModeData2.SharedStayTimeLimit = -1;
		loadModeData2.HandlerCtor = (() => new LoadModeHandlerInGame());
		dictionary.Add(key2, loadModeData2);
		ELoadMode key3 = ELoadMode.InGameLoading;
		LoadModeManager.LoadModeData loadModeData3 = new LoadModeManager.LoadModeData();
		loadModeData3.Priority = 5;
		loadModeData3.SharedStayTimeLimit = (Info.Instance.IsPlayInEditor ? 900000 : 180000);
		loadModeData3.HandlerCtor = (() => new LoadModeHandlerInGameLoading());
		dictionary.Add(key3, loadModeData3);
		ELoadMode key4 = ELoadMode.Loading;
		LoadModeManager.LoadModeData loadModeData4 = new LoadModeManager.LoadModeData();
		loadModeData4.Priority = 10;
		loadModeData4.SharedStayTimeLimit = (Info.Instance.IsPlayInEditor ? 900000 : 180000);
		loadModeData4.HandlerCtor = (() => new LoadModeHandlerLoading());
		dictionary.Add(key4, loadModeData4);
		ELoadMode key5 = ELoadMode.ForceInGame;
		LoadModeManager.LoadModeData loadModeData5 = new LoadModeManager.LoadModeData();
		loadModeData5.Priority = 99;
		loadModeData5.SharedStayTimeLimit = -1;
		loadModeData5.HandlerCtor = (() => new LoadModeHandlerInGame());
		dictionary.Add(key5, loadModeData5);
		this.LoadModeToDataRecord = dictionary;
		this.ReasonToLoadMode = new Dictionary<ELoadModeReason, ELoadMode>();
		base..ctor();
	}

	// Token: 0x040004CA RID: 1226
	private const int RESET_TIME = 180000;

	// Token: 0x040004CB RID: 1227
	private const int RESET_TIME_PIE = 900000;

	// Token: 0x040004CC RID: 1228
	private readonly Dictionary<ELoadMode, LoadModeManager.LoadModeData> LoadModeToDataRecord;

	// Token: 0x040004CD RID: 1229
	private ELoadMode LoadMode;

	// Token: 0x040004CF RID: 1231
	private readonly Dictionary<ELoadModeReason, ELoadMode> ReasonToLoadMode;

	// Token: 0x040004D0 RID: 1232
	[Nullable(2)]
	private TimerHandle LoadModeResetTimerHandle;

	// Token: 0x040004D1 RID: 1233
	[Nullable(2)]
	private static LoadModeManager _instance;

	// Token: 0x020001C2 RID: 450
	[NullableContext(0)]
	[RequiredMember]
	private class LoadModeData
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x0003E4AE File Offset: 0x0003C6AE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LoadModeData()
		{
		}

		// Token: 0x0400084B RID: 2123
		public int Priority;

		// Token: 0x0400084C RID: 2124
		public int SharedStayTimeLimit;

		// Token: 0x0400084D RID: 2125
		[Nullable(1)]
		[RequiredMember]
		public Func<ILoadModeHandler> HandlerCtor;

		// Token: 0x0400084E RID: 2126
		[Nullable(2)]
		public ILoadModeHandler HandlerInstance;
	}
}
