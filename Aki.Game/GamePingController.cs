using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001D50 RID: 7504
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GamePingController : UiControllerBase
{
	// Token: 0x0600E394 RID: 58260 RVA: 0x00357480 File Offset: 0x00355680
	protected override bool OnInit()
	{
		this.InitTimer();
		return true;
	}

	// Token: 0x0600E395 RID: 58261 RVA: 0x00357489 File Offset: 0x00355689
	protected override bool OnClear()
	{
		this.CancelTimer();
		return true;
	}

	// Token: 0x0600E396 RID: 58262 RVA: 0x00357492 File Offset: 0x00355692
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600E397 RID: 58263 RVA: 0x003574B0 File Offset: 0x003556B0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600E398 RID: 58264 RVA: 0x003574CE File Offset: 0x003556CE
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PingView, new Func<EUiViewName, object, bool>(this.CanOpenView), "GamePingController.CanOpenView");
	}

	// Token: 0x0600E399 RID: 58265 RVA: 0x003574F0 File Offset: 0x003556F0
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return this.CheckCanOpenView();
	}

	// Token: 0x0600E39A RID: 58266 RVA: 0x00357500 File Offset: 0x00355700
	private bool CheckCanOpenView()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId == 0)
		{
			return true;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config == null || (config.Value.WorldDungeonSubType != 1 && config.Value.InstSubType != 57);
	}

	// Token: 0x0600E39B RID: 58267 RVA: 0x0035755E File Offset: 0x0035575E
	private void OnWorldDoneAndCloseLoading()
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PingView, null, null);
	}

	// Token: 0x0600E39C RID: 58268 RVA: 0x0035757E File Offset: 0x0035577E
	private void InitTimer()
	{
		this.GamePingTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.CheckPing), (float)this.REFRESH_PING_INTERVAL_MS, 1f, null, null, true);
	}

	// Token: 0x0600E39D RID: 58269 RVA: 0x003575AB File Offset: 0x003557AB
	private void CancelTimer()
	{
		if (this.GamePingTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.GamePingTimer);
			this.GamePingTimer = null;
		}
	}

	// Token: 0x0600E39E RID: 58270 RVA: 0x003575D0 File Offset: 0x003557D0
	private void CheckPing(float _)
	{
		int num = (int)Math.Ceiling((double)NetInfo.Instance.RttMs);
		num = Math.Min(num, this.MAX_PING_MS);
		num = Math.Max(num, this.MIN_PING_MS);
		GamePingModel.Instance.CurrentPing = num;
		EventSystem.Instance.Emit<int>(EEventName.OnCheckGamePing, num);
	}

	// Token: 0x1700122D RID: 4653
	// (get) Token: 0x0600E39F RID: 58271 RVA: 0x00357625 File Offset: 0x00355825
	public static GamePingController Instance
	{
		get
		{
			return GamePingController._Instance;
		}
	}

	// Token: 0x0600E3A0 RID: 58272 RVA: 0x0035762C File Offset: 0x0035582C
	public static GamePingController GetOrCreateInstance()
	{
		if (GamePingController._Instance == null)
		{
			GamePingController.CreateInstance();
		}
		return GamePingController._Instance;
	}

	// Token: 0x0600E3A1 RID: 58273 RVA: 0x00357640 File Offset: 0x00355840
	public static bool CreateInstance()
	{
		if (GamePingController._Instance != null)
		{
			return true;
		}
		GamePingController._Instance = new GamePingController();
		return true;
	}

	// Token: 0x0600E3A2 RID: 58274 RVA: 0x00357656 File Offset: 0x00355856
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E3A3 RID: 58275 RVA: 0x00357658 File Offset: 0x00355858
	public static void ResetStaticDefaultValue()
	{
		GamePingController._Instance = null;
	}

	// Token: 0x0600E3A4 RID: 58276 RVA: 0x00357660 File Offset: 0x00355860
	static GamePingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamePingController.CreateStaticDefaultValue), new Action(GamePingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400690D RID: 26893
	private int REFRESH_PING_INTERVAL_MS = 100;

	// Token: 0x0400690E RID: 26894
	private int MAX_PING_MS = 999;

	// Token: 0x0400690F RID: 26895
	private int MIN_PING_MS = 1;

	// Token: 0x04006910 RID: 26896
	[Nullable(2)]
	private TimerHandle GamePingTimer;

	// Token: 0x04006911 RID: 26897
	[Nullable(2)]
	private static GamePingController _Instance;
}
