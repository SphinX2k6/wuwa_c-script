using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Ui;

// Token: 0x02002005 RID: 8197
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SplashScreenController : ControllerBase
{
	// Token: 0x060144EC RID: 83180 RVA: 0x005E9FB2 File Offset: 0x005E81B2
	protected override bool OnInit()
	{
		this.AddEvents();
		return true;
	}

	// Token: 0x060144ED RID: 83181 RVA: 0x005E9FBB File Offset: 0x005E81BB
	protected override bool OnClear()
	{
		this.RemoveEvents();
		return true;
	}

	// Token: 0x060144EE RID: 83182 RVA: 0x005E9FC4 File Offset: 0x005E81C4
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
	}

	// Token: 0x060144EF RID: 83183 RVA: 0x005EA044 File Offset: 0x005E8244
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
	}

	// Token: 0x060144F0 RID: 83184 RVA: 0x005EA0C4 File Offset: 0x005E82C4
	private void OnWorldDoneAndCloseLoading()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "WorldDoneAndCloseLoading 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x060144F1 RID: 83185 RVA: 0x005EA0F8 File Offset: 0x005E82F8
	private void OnActiveBattleView()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "ActiveBattleView 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x060144F2 RID: 83186 RVA: 0x005EA12C File Offset: 0x005E832C
	private void OnResetModuleByResetToBattleView()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "ResetModuleByResetToBattleView 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x060144F3 RID: 83187 RVA: 0x005EA15E File Offset: 0x005E835E
	private void OnBeforeLoadMap()
	{
		this.ClearAllTasks();
	}

	// Token: 0x060144F4 RID: 83188 RVA: 0x005EA168 File Offset: 0x005E8368
	public void PushSplashScreenTask(SplashScreenTask splashScreenTask, bool isInstantly = false)
	{
		ESplashScreenType type = splashScreenTask.Type;
		this.SplashScreenQueue.EnQueue(splashScreenTask);
		if (isInstantly)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "添加开屏动画任务且立即执行";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", splashScreenTask.SourceModule);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TryRunSplashScreenTask();
		}
	}

	// Token: 0x060144F5 RID: 83189 RVA: 0x005EA1C8 File Offset: 0x005E83C8
	public void FinishCurTask(ESplashScreenSourceModuleType taskSourceModule = ESplashScreenSourceModuleType.None)
	{
		if (this.SplashScreenQueue.FinishTask(taskSourceModule))
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "FinishCurTask 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.TryRunSplashScreenTask();
		}
	}

	// Token: 0x060144F6 RID: 83190 RVA: 0x005EA208 File Offset: 0x005E8408
	public void TryRunSplashScreenTask()
	{
		if (this.SplashScreenQueue.TaskQueue == null || this.SplashScreenQueue.TaskQueue.Count == 0)
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "开屏任务队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!GameModeModel.Instance.WorldDoneAndLoadingClosed)
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "世界未加载完成，且加载界面未关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!UiManager.Instance.IsViewShow(EUiViewName.BattleView))
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "未在战斗主界面，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!UiManager.Instance.IsNormalContainerEmpty())
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "待打开界面队列不为空，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "当前角色实体不存在，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BaseTagComponent component = worldEntity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "处于战斗中，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "处于副本中，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (MovieModeController.Instance.IsInMovieMode())
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CB, "处于电影模式中，不运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int[] runningGroupIdList = GuideModel.Instance.GetRunningGroupIdList();
		if (runningGroupIdList.Length != 0)
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "处于引导中，不运行开屏动画任务，引导GroupId: " + string.Join<int>(", ", runningGroupIdList), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SplashScreenQueue.ProcessQueue();
	}

	// Token: 0x060144F7 RID: 83191 RVA: 0x005EA411 File Offset: 0x005E8611
	public void ClearAllTasks()
	{
		this.SplashScreenQueue.ClearAllTask();
	}

	// Token: 0x17001E8D RID: 7821
	// (get) Token: 0x060144F8 RID: 83192 RVA: 0x005EA41E File Offset: 0x005E861E
	public static SplashScreenController Instance
	{
		get
		{
			return SplashScreenController._Instance;
		}
	}

	// Token: 0x060144F9 RID: 83193 RVA: 0x005EA425 File Offset: 0x005E8625
	public static SplashScreenController GetOrCreateInstance()
	{
		if (SplashScreenController._Instance == null)
		{
			SplashScreenController.CreateInstance();
		}
		return SplashScreenController._Instance;
	}

	// Token: 0x060144FA RID: 83194 RVA: 0x005EA439 File Offset: 0x005E8639
	public static bool CreateInstance()
	{
		if (SplashScreenController._Instance != null)
		{
			return true;
		}
		SplashScreenController._Instance = new SplashScreenController();
		return true;
	}

	// Token: 0x060144FB RID: 83195 RVA: 0x005EA44F File Offset: 0x005E864F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060144FC RID: 83196 RVA: 0x005EA451 File Offset: 0x005E8651
	public static void ResetStaticDefaultValue()
	{
		SplashScreenController._Instance = null;
	}

	// Token: 0x060144FD RID: 83197 RVA: 0x005EA459 File Offset: 0x005E8659
	static SplashScreenController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SplashScreenController.CreateStaticDefaultValue), new Action(SplashScreenController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC33 RID: 44083
	protected SplashScreenQueue SplashScreenQueue = new SplashScreenQueue();

	// Token: 0x0400AC34 RID: 44084
	public bool IsForbidAddTask = true;

	// Token: 0x0400AC35 RID: 44085
	[Nullable(2)]
	private static SplashScreenController _Instance;
}
