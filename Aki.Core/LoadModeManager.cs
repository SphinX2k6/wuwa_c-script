using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020000C1 RID: 193
[NullableContext(1)]
[Nullable(0)]
public class LoadModeManager : Singleton
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000623 RID: 1571 RVA: 0x0001FA8C File Offset: 0x0001DC8C
	// (remove) Token: 0x06000624 RID: 1572 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
	[Nullable(2)]
	[method: NullableContext(2)]
	[Nullable(2)]
	public event Action<ELoadMode> LoadModeApplied;

	// Token: 0x06000625 RID: 1573 RVA: 0x0001FAFC File Offset: 0x0001DCFC
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

	// Token: 0x06000626 RID: 1574 RVA: 0x0001FB3C File Offset: 0x0001DD3C
	private void CheckAndUpdateLoadMode()
	{
		this.UpdateLoadMode(this.GetTargetLoadMode());
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0001FB4C File Offset: 0x0001DD4C
	private ELoadMode GetTargetLoadMode()
	{
		ELoadMode eloadMode = ELoadMode.InGame;
		foreach (ELoadMode eloadMode2 in this.ReasonToLoadMode.Values)
		{
			if (this.LoadModeToDataRecord[eloadMode2].Priority > this.LoadModeToDataRecord[eloadMode].Priority)
			{
				eloadMode = eloadMode2;
			}
		}
		return eloadMode;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
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

	// Token: 0x06000629 RID: 1577 RVA: 0x0001FC90 File Offset: 0x0001DE90
	private void AfterUpdateLoadMode()
	{
		this.DisableLoadModeResetTimer();
		int sharedStayTimeLimit = this.LoadModeToDataRecord[this.LoadMode].SharedStayTimeLimit;
		if (sharedStayTimeLimit > 0)
		{
			this.EnableLoadModeResetTimer(sharedStayTimeLimit);
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0001FCC5 File Offset: 0x0001DEC5
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

	// Token: 0x0600062B RID: 1579 RVA: 0x0001FCF7 File Offset: 0x0001DEF7
	private void DisableLoadModeResetTimer()
	{
		if (this.LoadModeResetTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.LoadModeResetTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LoadModeResetTimerHandle);
		}
		this.LoadModeResetTimerHandle = null;
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0001FD2B File Offset: 0x0001DF2B
	public ELoadMode GetLoadMode()
	{
		return this.LoadMode;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0001FD34 File Offset: 0x0001DF34
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

	// Token: 0x0600062E RID: 1582 RVA: 0x0001FE97 File Offset: 0x0001E097
	public void ResetLoadModeByReason(ELoadModeReason reason)
	{
		this.SetLoadModeByReason(ELoadMode.InGame, reason);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0001FEA1 File Offset: 0x0001E0A1
	public bool IsReasonTargetNotDefault(ELoadModeReason reason)
	{
		return this.ReasonToLoadMode.GetValueOrDefault(reason, ELoadMode.InGame) != ELoadMode.InGame;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
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

	// Token: 0x06000631 RID: 1585 RVA: 0x0001FF68 File Offset: 0x0001E168
	public bool IsLoadModeInGameOrForceInGame()
	{
		ELoadMode loadMode = this.LoadMode;
		return loadMode == ELoadMode.InGame || loadMode == ELoadMode.ForceInGame;
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001FF8B File Offset: 0x0001E18B
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

	// Token: 0x06000633 RID: 1587 RVA: 0x0001FFAE File Offset: 0x0001E1AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
	public static void ResetStaticDefaultValue()
	{
		LoadModeManager instance = LoadModeManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LoadModeManager._instance = null;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0001FFC9 File Offset: 0x0001E1C9
	static LoadModeManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadModeManager.CreateStaticDefaultValue), new Action(LoadModeManager.ResetStaticDefaultValue));
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
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
		loadModeData3.SharedStayTimeLimit = 180000;
		loadModeData3.HandlerCtor = (() => new LoadModeHandlerInGameLoading());
		dictionary.Add(key3, loadModeData3);
		ELoadMode key4 = ELoadMode.Loading;
		LoadModeManager.LoadModeData loadModeData4 = new LoadModeManager.LoadModeData();
		loadModeData4.Priority = 10;
		loadModeData4.SharedStayTimeLimit = 180000;
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

	// Token: 0x040004D8 RID: 1240
	private const int RESET_TIME = 180000;

	// Token: 0x040004D9 RID: 1241
	private const int RESET_TIME_PIE = 900000;

	// Token: 0x040004DA RID: 1242
	private readonly Dictionary<ELoadMode, LoadModeManager.LoadModeData> LoadModeToDataRecord;

	// Token: 0x040004DB RID: 1243
	private ELoadMode LoadMode;

	// Token: 0x040004DD RID: 1245
	private readonly Dictionary<ELoadModeReason, ELoadMode> ReasonToLoadMode;

	// Token: 0x040004DE RID: 1246
	[Nullable(2)]
	private TimerHandle LoadModeResetTimerHandle;

	// Token: 0x040004DF RID: 1247
	[Nullable(2)]
	private static LoadModeManager _instance;

	// Token: 0x020001C8 RID: 456
	[NullableContext(0)]
	[RequiredMember]
	private class LoadModeData
	{
		// Token: 0x06000DAD RID: 3501 RVA: 0x0003F382 File Offset: 0x0003D582
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LoadModeData()
		{
		}

		// Token: 0x04000870 RID: 2160
		public int Priority;

		// Token: 0x04000871 RID: 2161
		public int SharedStayTimeLimit;

		// Token: 0x04000872 RID: 2162
		[Nullable(1)]
		[RequiredMember]
		public Func<ILoadModeHandler> HandlerCtor;

		// Token: 0x04000873 RID: 2163
		[Nullable(2)]
		public ILoadModeHandler HandlerInstance;
	}
}
