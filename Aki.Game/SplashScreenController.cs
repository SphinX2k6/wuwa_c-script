using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Ui;

// Token: 0x02002A89 RID: 10889
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SplashScreenController : ControllerBase
{
	// Token: 0x06016AC7 RID: 92871 RVA: 0x005BDD82 File Offset: 0x005BBF82
	protected override bool OnInit()
	{
		this.AddEvents();
		return true;
	}

	// Token: 0x06016AC8 RID: 92872 RVA: 0x005BDD8B File Offset: 0x005BBF8B
	protected override bool OnClear()
	{
		this.RemoveEvents();
		return true;
	}

	// Token: 0x06016AC9 RID: 92873 RVA: 0x005BDD94 File Offset: 0x005BBF94
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
	}

	// Token: 0x06016ACA RID: 92874 RVA: 0x005BDE14 File Offset: 0x005BC014
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
	}

	// Token: 0x06016ACB RID: 92875 RVA: 0x005BDE94 File Offset: 0x005BC094
	private void OnWorldDoneAndCloseLoading()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "WorldDoneAndCloseLoading 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x06016ACC RID: 92876 RVA: 0x005BDEC8 File Offset: 0x005BC0C8
	private void OnActiveBattleView()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "ActiveBattleView 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x06016ACD RID: 92877 RVA: 0x005BDEFC File Offset: 0x005BC0FC
	private void OnResetModuleByResetToBattleView()
	{
		Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "ResetModuleByResetToBattleView 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryRunSplashScreenTask();
	}

	// Token: 0x06016ACE RID: 92878 RVA: 0x005BDF2E File Offset: 0x005BC12E
	private void OnBeforeLoadMap()
	{
		this.ClearAllTasks();
	}

	// Token: 0x06016ACF RID: 92879 RVA: 0x005BDF38 File Offset: 0x005BC138
	public void PushSplashScreenTask(SplashScreenTask splashScreenTask, bool isInstantly = false)
	{
		if (splashScreenTask.Type == ESplashScreenType.Config && Info.Instance.IsPlayInEditor && this.IsForbidAddTask)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "添加开屏动画任务失败，当前处于禁止添加任务状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", splashScreenTask.SourceModule);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SplashScreenQueue.EnQueue(splashScreenTask);
		if (isInstantly)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SplashScreenTask;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "添加开屏动画任务且立即执行";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TaskSourceModule", splashScreenTask.SourceModule);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.TryRunSplashScreenTask();
		}
	}

	// Token: 0x06016AD0 RID: 92880 RVA: 0x005BDFE0 File Offset: 0x005BC1E0
	public void FinishCurTask(ESplashScreenSourceModuleType taskSourceModule = ESplashScreenSourceModuleType.None)
	{
		if (this.SplashScreenQueue.FinishTask(taskSourceModule))
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "FinishCurTask 尝试运行开屏动画任务", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.TryRunSplashScreenTask();
		}
	}

	// Token: 0x06016AD1 RID: 92881 RVA: 0x005BE020 File Offset: 0x005BC220
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

	// Token: 0x06016AD2 RID: 92882 RVA: 0x005BE229 File Offset: 0x005BC429
	public void ClearAllTasks()
	{
		this.SplashScreenQueue.ClearAllTask();
	}

	// Token: 0x17001E35 RID: 7733
	// (get) Token: 0x06016AD3 RID: 92883 RVA: 0x005BE236 File Offset: 0x005BC436
	public static SplashScreenController Instance
	{
		get
		{
			return SplashScreenController._Instance;
		}
	}

	// Token: 0x06016AD4 RID: 92884 RVA: 0x005BE23D File Offset: 0x005BC43D
	public static SplashScreenController GetOrCreateInstance()
	{
		if (SplashScreenController._Instance == null)
		{
			SplashScreenController.CreateInstance();
		}
		return SplashScreenController._Instance;
	}

	// Token: 0x06016AD5 RID: 92885 RVA: 0x005BE251 File Offset: 0x005BC451
	public static bool CreateInstance()
	{
		if (SplashScreenController._Instance != null)
		{
			return true;
		}
		SplashScreenController._Instance = new SplashScreenController();
		return true;
	}

	// Token: 0x06016AD6 RID: 92886 RVA: 0x005BE267 File Offset: 0x005BC467
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016AD7 RID: 92887 RVA: 0x005BE269 File Offset: 0x005BC469
	public static void ResetStaticDefaultValue()
	{
		SplashScreenController._Instance = null;
	}

	// Token: 0x06016AD8 RID: 92888 RVA: 0x005BE271 File Offset: 0x005BC471
	static SplashScreenController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SplashScreenController.CreateStaticDefaultValue), new Action(SplashScreenController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A82E RID: 43054
	protected SplashScreenQueue SplashScreenQueue = new SplashScreenQueue();

	// Token: 0x0400A82F RID: 43055
	public bool IsForbidAddTask = true;

	// Token: 0x0400A830 RID: 43056
	[Nullable(2)]
	private static SplashScreenController _Instance;
}
