using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020004A5 RID: 1189
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GolemHackingController : ActivityControllerBase
{
	// Token: 0x06003C6A RID: 15466 RVA: 0x001563E4 File Offset: 0x001545E4
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x001563E6 File Offset: 0x001545E6
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_GolemHackingActivityMain";
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x001563ED File Offset: 0x001545ED
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new GolemHackingActivitySubView();
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x001563F4 File Offset: 0x001545F4
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new GolemHackingActivityData();
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x00156407 File Offset: 0x00154607
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x0015640A File Offset: 0x0015460A
	[NullableContext(2)]
	public GolemHackingActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as GolemHackingActivityData;
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x00156424 File Offset: 0x00154624
	public void OnUiGameplayFinish(int configId)
	{
		GeneralLogicTreeController instance = GeneralLogicTreeController.Instance;
		UiGamePlayType type = UiGamePlayType.GolemCrack;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(configId);
		instance.RequestFinishUiGameplay(type, defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x00156454 File Offset: 0x00154654
	public int OpenGameplayView(IReadOnlyList<int> randomList, Action<bool> closeCb, bool isMainLevel, [Nullable(2)] TOpenViewCallBack openCb = null)
	{
		if (randomList.Count == 0)
		{
			return 0;
		}
		int randomItem = MathUtils.Instance.GetRandomItem<int>(randomList);
		GolemHackingOpenViewInfo param = new GolemHackingOpenViewInfo
		{
			ConfigId = randomItem,
			CloseCb = closeCb,
			IsMainLevel = isMainLevel
		};
		UiManager.Instance.OpenView(EUiViewName.GolemHackingGameView, param, openCb);
		return randomItem;
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x001564A8 File Offset: 0x001546A8
	public int OpenGameplayViewByPlot(List<int> randomList, Action<bool> closeCb, bool isMainLevel)
	{
		if (randomList.Count == 0)
		{
			return 0;
		}
		int randomItem = MathUtils.Instance.GetRandomItem<int>(randomList);
		GolemHackingOpenViewInfo param = new GolemHackingOpenViewInfo
		{
			ConfigId = randomItem,
			CloseCb = closeCb,
			IsMainLevel = isMainLevel
		};
		UiManager.Instance.OpenViewByPlot(EUiViewName.GolemHackingGameView, param, null);
		return randomItem;
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x001564F8 File Offset: 0x001546F8
	[NullableContext(0)]
	public UniTask<bool> RequestGolemCrackUpdate(int levelId)
	{
		GolemHackingController.<RequestGolemCrackUpdate>d__15 <RequestGolemCrackUpdate>d__;
		<RequestGolemCrackUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestGolemCrackUpdate>d__.<>4__this = this;
		<RequestGolemCrackUpdate>d__.levelId = levelId;
		<RequestGolemCrackUpdate>d__.<>1__state = -1;
		<RequestGolemCrackUpdate>d__.<>t__builder.Start<GolemHackingController.<RequestGolemCrackUpdate>d__15>(ref <RequestGolemCrackUpdate>d__);
		return <RequestGolemCrackUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06003C74 RID: 15476 RVA: 0x00156544 File Offset: 0x00154744
	public void CloseActivityView(IReadOnlySet<int> closeActivities, bool force = false)
	{
		if (closeActivities.Contains(this.ActivityId) || force)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap[1] = new Action(GolemHackingController.<CloseActivityView>g__ConfirmCallback|16_0);
			confirmBoxDataNew.FunctionMap[0] = new Action(GolemHackingController.<CloseActivityView>g__ConfirmCallback|16_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x1700089C RID: 2204
	// (get) Token: 0x06003C75 RID: 15477 RVA: 0x001565A5 File Offset: 0x001547A5
	public static GolemHackingController Instance
	{
		get
		{
			return GolemHackingController._Instance;
		}
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x001565AC File Offset: 0x001547AC
	public static GolemHackingController GetOrCreateInstance()
	{
		if (GolemHackingController._Instance == null)
		{
			GolemHackingController.CreateInstance();
		}
		return GolemHackingController._Instance;
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x001565C0 File Offset: 0x001547C0
	public static bool CreateInstance()
	{
		if (GolemHackingController._Instance != null)
		{
			return true;
		}
		GolemHackingController._Instance = new GolemHackingController();
		return true;
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x001565D6 File Offset: 0x001547D6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x001565D8 File Offset: 0x001547D8
	public static void ResetStaticDefaultValue()
	{
		GolemHackingController._Instance = null;
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x001565E0 File Offset: 0x001547E0
	static GolemHackingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingController.CreateStaticDefaultValue), new Action(GolemHackingController.ResetStaticDefaultValue));
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x00156607 File Offset: 0x00154807
	[CompilerGenerated]
	internal static void <CloseActivityView>g__ConfirmCallback|16_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x04003094 RID: 12436
	public int ActivityId;

	// Token: 0x04003095 RID: 12437
	public bool IsActivityOpen;

	// Token: 0x04003096 RID: 12438
	public int ActivityOpenTime;

	// Token: 0x04003097 RID: 12439
	public int CacheLevelId;

	// Token: 0x04003098 RID: 12440
	public bool CacheHardMode;

	// Token: 0x04003099 RID: 12441
	public bool CacheRewardFocus;

	// Token: 0x0400309A RID: 12442
	[Nullable(2)]
	private static GolemHackingController _Instance;
}
