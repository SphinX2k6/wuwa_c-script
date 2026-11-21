using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001212 RID: 4626
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GamePingController : UiControllerBase
{
	// Token: 0x0600B7B1 RID: 47025 RVA: 0x00362EF3 File Offset: 0x003610F3
	protected override bool OnInit()
	{
		this.InitTimer();
		return true;
	}

	// Token: 0x0600B7B2 RID: 47026 RVA: 0x00362EFC File Offset: 0x003610FC
	protected override bool OnClear()
	{
		this.CancelTimer();
		return true;
	}

	// Token: 0x0600B7B3 RID: 47027 RVA: 0x00362F05 File Offset: 0x00361105
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600B7B4 RID: 47028 RVA: 0x00362F23 File Offset: 0x00361123
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600B7B5 RID: 47029 RVA: 0x00362F41 File Offset: 0x00361141
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PingView, new Func<EUiViewName, object, bool>(this.CanOpenView), "GamePingController.CanOpenView");
	}

	// Token: 0x0600B7B6 RID: 47030 RVA: 0x00362F63 File Offset: 0x00361163
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return this.CheckCanOpenView();
	}

	// Token: 0x0600B7B7 RID: 47031 RVA: 0x00362F70 File Offset: 0x00361170
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

	// Token: 0x0600B7B8 RID: 47032 RVA: 0x00362FCE File Offset: 0x003611CE
	private void OnWorldDoneAndCloseLoading()
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PingView, null, null);
	}

	// Token: 0x0600B7B9 RID: 47033 RVA: 0x00362FEE File Offset: 0x003611EE
	private void InitTimer()
	{
		this.GamePingTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.CheckPing), (float)this.REFRESH_PING_INTERVAL_MS, 1f, null, null, true);
	}

	// Token: 0x0600B7BA RID: 47034 RVA: 0x0036301B File Offset: 0x0036121B
	private void CancelTimer()
	{
		if (this.GamePingTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.GamePingTimer);
			this.GamePingTimer = null;
		}
	}

	// Token: 0x0600B7BB RID: 47035 RVA: 0x00363040 File Offset: 0x00361240
	private void CheckPing(float _)
	{
		int num = (int)Math.Ceiling((double)NetInfo.Instance.RttMs);
		num = Math.Min(num, this.MAX_PING_MS);
		num = Math.Max(num, this.MIN_PING_MS);
		GamePingModel.Instance.CurrentPing = num;
		EventSystem.Instance.Emit<int>(EEventName.OnCheckGamePing, num);
	}

	// Token: 0x17001257 RID: 4695
	// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x00363095 File Offset: 0x00361295
	public static GamePingController Instance
	{
		get
		{
			return GamePingController._Instance;
		}
	}

	// Token: 0x0600B7BD RID: 47037 RVA: 0x0036309C File Offset: 0x0036129C
	public static GamePingController GetOrCreateInstance()
	{
		if (GamePingController._Instance == null)
		{
			GamePingController.CreateInstance();
		}
		return GamePingController._Instance;
	}

	// Token: 0x0600B7BE RID: 47038 RVA: 0x003630B0 File Offset: 0x003612B0
	public static bool CreateInstance()
	{
		if (GamePingController._Instance != null)
		{
			return true;
		}
		GamePingController._Instance = new GamePingController();
		return true;
	}

	// Token: 0x0600B7BF RID: 47039 RVA: 0x003630C6 File Offset: 0x003612C6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B7C0 RID: 47040 RVA: 0x003630C8 File Offset: 0x003612C8
	public static void ResetStaticDefaultValue()
	{
		GamePingController._Instance = null;
	}

	// Token: 0x0600B7C1 RID: 47041 RVA: 0x003630D0 File Offset: 0x003612D0
	static GamePingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamePingController.CreateStaticDefaultValue), new Action(GamePingController.ResetStaticDefaultValue));
	}

	// Token: 0x040069EC RID: 27116
	private int REFRESH_PING_INTERVAL_MS = 100;

	// Token: 0x040069ED RID: 27117
	private int MAX_PING_MS = 999;

	// Token: 0x040069EE RID: 27118
	private int MIN_PING_MS = 1;

	// Token: 0x040069EF RID: 27119
	[Nullable(2)]
	private TimerHandle GamePingTimer;

	// Token: 0x040069F0 RID: 27120
	[Nullable(2)]
	private static GamePingController _Instance;
}
