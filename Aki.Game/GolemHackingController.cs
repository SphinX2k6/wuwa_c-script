using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FF0 RID: 4080
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GolemHackingController : ActivityControllerBase
{
	// Token: 0x060068D2 RID: 26834 RVA: 0x0014DB20 File Offset: 0x0014BD20
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060068D3 RID: 26835 RVA: 0x0014DB22 File Offset: 0x0014BD22
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_GolemHackingActivityMain";
	}

	// Token: 0x060068D4 RID: 26836 RVA: 0x0014DB29 File Offset: 0x0014BD29
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new GolemHackingActivitySubView();
	}

	// Token: 0x060068D5 RID: 26837 RVA: 0x0014DB30 File Offset: 0x0014BD30
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new GolemHackingActivityData();
	}

	// Token: 0x060068D6 RID: 26838 RVA: 0x0014DB43 File Offset: 0x0014BD43
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060068D7 RID: 26839 RVA: 0x0014DB46 File Offset: 0x0014BD46
	[NullableContext(2)]
	public GolemHackingActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as GolemHackingActivityData;
	}

	// Token: 0x060068D8 RID: 26840 RVA: 0x0014DB60 File Offset: 0x0014BD60
	public void OnUiGameplayFinish(int configId)
	{
		GeneralLogicTreeController instance = GeneralLogicTreeController.Instance;
		UiGamePlayType type = UiGamePlayType.GolemCrack;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(configId);
		instance.RequestFinishUiGameplay(type, defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060068D9 RID: 26841 RVA: 0x0014DB90 File Offset: 0x0014BD90
	public int OpenGameplayView(List<int> randomList, Action<bool> closeCb, bool isMainLevel, [Nullable(2)] TOpenViewCallBack openCb = null)
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

	// Token: 0x060068DA RID: 26842 RVA: 0x0014DBE4 File Offset: 0x0014BDE4
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

	// Token: 0x060068DB RID: 26843 RVA: 0x0014DC34 File Offset: 0x0014BE34
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

	// Token: 0x060068DC RID: 26844 RVA: 0x0014DC80 File Offset: 0x0014BE80
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

	// Token: 0x1700087A RID: 2170
	// (get) Token: 0x060068DD RID: 26845 RVA: 0x0014DCE1 File Offset: 0x0014BEE1
	public static GolemHackingController Instance
	{
		get
		{
			return GolemHackingController._Instance;
		}
	}

	// Token: 0x060068DE RID: 26846 RVA: 0x0014DCE8 File Offset: 0x0014BEE8
	public static GolemHackingController GetOrCreateInstance()
	{
		if (GolemHackingController._Instance == null)
		{
			GolemHackingController.CreateInstance();
		}
		return GolemHackingController._Instance;
	}

	// Token: 0x060068DF RID: 26847 RVA: 0x0014DCFC File Offset: 0x0014BEFC
	public static bool CreateInstance()
	{
		if (GolemHackingController._Instance != null)
		{
			return true;
		}
		GolemHackingController._Instance = new GolemHackingController();
		return true;
	}

	// Token: 0x060068E0 RID: 26848 RVA: 0x0014DD12 File Offset: 0x0014BF12
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060068E1 RID: 26849 RVA: 0x0014DD14 File Offset: 0x0014BF14
	public static void ResetStaticDefaultValue()
	{
		GolemHackingController._Instance = null;
	}

	// Token: 0x060068E2 RID: 26850 RVA: 0x0014DD1C File Offset: 0x0014BF1C
	static GolemHackingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingController.CreateStaticDefaultValue), new Action(GolemHackingController.ResetStaticDefaultValue));
	}

	// Token: 0x060068E4 RID: 26852 RVA: 0x0014DD43 File Offset: 0x0014BF43
	[CompilerGenerated]
	internal static void <CloseActivityView>g__ConfirmCallback|16_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x04002FFB RID: 12283
	public int ActivityId;

	// Token: 0x04002FFC RID: 12284
	public bool IsActivityOpen;

	// Token: 0x04002FFD RID: 12285
	public int ActivityOpenTime;

	// Token: 0x04002FFE RID: 12286
	public int CacheLevelId;

	// Token: 0x04002FFF RID: 12287
	public bool CacheHardMode;

	// Token: 0x04003000 RID: 12288
	public bool CacheRewardFocus;

	// Token: 0x04003001 RID: 12289
	[Nullable(2)]
	private static GolemHackingController _Instance;
}
