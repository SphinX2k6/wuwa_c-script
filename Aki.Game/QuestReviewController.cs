using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001B5D RID: 7005
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewController : ControllerBase
{
	// Token: 0x06011792 RID: 71570 RVA: 0x00526756 File Offset: 0x00524956
	protected override bool OnInit()
	{
		this.AddListeners();
		this.BurnFinishPromise = new CustomPromise<object>();
		this.FusionFinishPromise = new CustomPromise<object>();
		this.NewTabUnlockPromise = new CustomPromise<object>();
		return true;
	}

	// Token: 0x06011793 RID: 71571 RVA: 0x00526780 File Offset: 0x00524980
	protected override bool OnClear()
	{
		this.ViewRefreshDelegates.Clear();
		this.RemoveListeners();
		return true;
	}

	// Token: 0x06011794 RID: 71572 RVA: 0x00526794 File Offset: 0x00524994
	public void AddViewRefreshDelegate(Action<int?> @delegate)
	{
		this.ViewRefreshDelegates.Add(@delegate);
	}

	// Token: 0x06011795 RID: 71573 RVA: 0x005267A4 File Offset: 0x005249A4
	public void RemoveViewRefreshDelegate(Action<int?> @delegate)
	{
		int num = this.ViewRefreshDelegates.IndexOf(@delegate);
		if (num >= 0)
		{
			this.ViewRefreshDelegates.RemoveAt(num);
		}
	}

	// Token: 0x06011796 RID: 71574 RVA: 0x005267D0 File Offset: 0x005249D0
	public void TriggerViewRefresh(int tabId = 0)
	{
		foreach (Action<int?> action in this.ViewRefreshDelegates)
		{
			action(new int?(tabId));
		}
	}

	// Token: 0x06011797 RID: 71575 RVA: 0x00526828 File Offset: 0x00524A28
	public void OpenQuestReview(int entryId, bool useLoopMusic = true)
	{
		QuestReviewEntryData questReviewEntryDataById = QuestReviewModel.Instance.GetQuestReviewEntryDataById(entryId);
		if (questReviewEntryDataById != null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestReviewMainView, new object[]
			{
				questReviewEntryDataById,
				useLoopMusic
			}, null);
		}
	}

	// Token: 0x06011798 RID: 71576 RVA: 0x00526868 File Offset: 0x00524A68
	[NullableContext(0)]
	public UniTask<bool> OpenQuestReviewAsync(int entryId, bool useLoopMusic = true)
	{
		QuestReviewController.<OpenQuestReviewAsync>d__7 <OpenQuestReviewAsync>d__;
		<OpenQuestReviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenQuestReviewAsync>d__.entryId = entryId;
		<OpenQuestReviewAsync>d__.useLoopMusic = useLoopMusic;
		<OpenQuestReviewAsync>d__.<>1__state = -1;
		<OpenQuestReviewAsync>d__.<>t__builder.Start<QuestReviewController.<OpenQuestReviewAsync>d__7>(ref <OpenQuestReviewAsync>d__);
		return <OpenQuestReviewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011799 RID: 71577 RVA: 0x005268B4 File Offset: 0x00524AB4
	[NullableContext(0)]
	public UniTask<bool> OpenQuestReviewTipsViewAsync(int entryId, int nodeId)
	{
		QuestReviewController.<OpenQuestReviewTipsViewAsync>d__8 <OpenQuestReviewTipsViewAsync>d__;
		<OpenQuestReviewTipsViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenQuestReviewTipsViewAsync>d__.entryId = entryId;
		<OpenQuestReviewTipsViewAsync>d__.nodeId = nodeId;
		<OpenQuestReviewTipsViewAsync>d__.<>1__state = -1;
		<OpenQuestReviewTipsViewAsync>d__.<>t__builder.Start<QuestReviewController.<OpenQuestReviewTipsViewAsync>d__8>(ref <OpenQuestReviewTipsViewAsync>d__);
		return <OpenQuestReviewTipsViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601179A RID: 71578 RVA: 0x00526900 File Offset: 0x00524B00
	public void OpenQuestNodeDetail(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = QuestReviewModel.Instance.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById != null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestReviewDetailView, questReviewNodeDataById, null);
		}
	}

	// Token: 0x0601179B RID: 71579 RVA: 0x0052692D File Offset: 0x00524B2D
	private void AddListeners()
	{
		Net.Instance.Register(ENotifyMessageId.QuestReviewInfoNotify, this.OnQuestReviewInfoNotify);
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, this.OnEnterGameSuccess);
	}

	// Token: 0x0601179C RID: 71580 RVA: 0x00526958 File Offset: 0x00524B58
	private void RemoveListeners()
	{
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, this.OnEnterGameSuccess);
		Net.Instance.UnRegister(ENotifyMessageId.QuestReviewInfoNotify);
	}

	// Token: 0x0601179D RID: 71581 RVA: 0x00526980 File Offset: 0x00524B80
	public UniTask RequestQuestReviewData()
	{
		QuestReviewController.<RequestQuestReviewData>d__13 <RequestQuestReviewData>d__;
		<RequestQuestReviewData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestQuestReviewData>d__.<>1__state = -1;
		<RequestQuestReviewData>d__.<>t__builder.Start<QuestReviewController.<RequestQuestReviewData>d__13>(ref <RequestQuestReviewData>d__);
		return <RequestQuestReviewData>d__.<>t__builder.Task;
	}

	// Token: 0x17001A24 RID: 6692
	// (get) Token: 0x0601179E RID: 71582 RVA: 0x005269BB File Offset: 0x00524BBB
	// (set) Token: 0x0601179F RID: 71583 RVA: 0x005269C3 File Offset: 0x00524BC3
	public CustomPromise<object> BurnFinishPromise { get; set; }

	// Token: 0x17001A25 RID: 6693
	// (get) Token: 0x060117A0 RID: 71584 RVA: 0x005269CC File Offset: 0x00524BCC
	// (set) Token: 0x060117A1 RID: 71585 RVA: 0x005269D4 File Offset: 0x00524BD4
	public CustomPromise<object> FusionFinishPromise { get; set; }

	// Token: 0x17001A26 RID: 6694
	// (get) Token: 0x060117A2 RID: 71586 RVA: 0x005269DD File Offset: 0x00524BDD
	// (set) Token: 0x060117A3 RID: 71587 RVA: 0x005269E5 File Offset: 0x00524BE5
	public CustomPromise<object> NewTabUnlockPromise { get; set; }

	// Token: 0x060117A4 RID: 71588 RVA: 0x005269EE File Offset: 0x00524BEE
	public void SetBurnFinish()
	{
		if (this.BurnFinishPromise != null)
		{
			this.BurnFinishPromise.SetResult(null);
			this.BurnFinishPromise = null;
		}
	}

	// Token: 0x060117A5 RID: 71589 RVA: 0x00526A0B File Offset: 0x00524C0B
	public void SetFusionFinish()
	{
		if (this.FusionFinishPromise != null)
		{
			this.FusionFinishPromise.SetResult(null);
			this.FusionFinishPromise = null;
			QuestReviewController.Instance.TriggerViewRefresh(-1);
		}
	}

	// Token: 0x060117A6 RID: 71590 RVA: 0x00526A33 File Offset: 0x00524C33
	public void SetNewTabUnlockFinish()
	{
		if (this.NewTabUnlockPromise != null)
		{
			this.NewTabUnlockPromise.SetResult(null);
			this.NewTabUnlockPromise = null;
			QuestReviewController.Instance.TriggerViewRefresh(-2);
		}
	}

	// Token: 0x060117A7 RID: 71591 RVA: 0x00526A5C File Offset: 0x00524C5C
	public void GmResetBurn()
	{
		this.SetBurnFinish();
		this.SetFusionFinish();
		this.BurnFinishPromise = new CustomPromise<object>();
		this.FusionFinishPromise = new CustomPromise<object>();
		this.NewTabUnlockPromise = new CustomPromise<object>();
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3200).HasFused = false;
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3200).IsFirstTimeShow = true;
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3100).IsFirstTimeDestroy = true;
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3400).IsFirstTimeDestroy = true;
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3500).IsFirstTimeDestroy = true;
		QuestReviewModel.Instance.GetQuestReviewLineDataById(3600).IsFirstTimeDestroy = true;
		QuestReviewModel.Instance.GetQuestReviewTabDataById(3).IsFirstTimeShow = true;
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewHasFused, false);
	}

	// Token: 0x17001A27 RID: 6695
	// (get) Token: 0x060117A8 RID: 71592 RVA: 0x00526B31 File Offset: 0x00524D31
	public static QuestReviewController Instance
	{
		get
		{
			return QuestReviewController._Instance;
		}
	}

	// Token: 0x060117A9 RID: 71593 RVA: 0x00526B38 File Offset: 0x00524D38
	public static QuestReviewController GetOrCreateInstance()
	{
		if (QuestReviewController._Instance == null)
		{
			QuestReviewController.CreateInstance();
		}
		return QuestReviewController._Instance;
	}

	// Token: 0x060117AA RID: 71594 RVA: 0x00526B4C File Offset: 0x00524D4C
	public static bool CreateInstance()
	{
		if (QuestReviewController._Instance != null)
		{
			return true;
		}
		QuestReviewController._Instance = new QuestReviewController();
		return true;
	}

	// Token: 0x060117AB RID: 71595 RVA: 0x00526B62 File Offset: 0x00524D62
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060117AC RID: 71596 RVA: 0x00526B64 File Offset: 0x00524D64
	public static void ResetStaticDefaultValue()
	{
		QuestReviewController._Instance = null;
	}

	// Token: 0x060117AD RID: 71597 RVA: 0x00526B6C File Offset: 0x00524D6C
	static QuestReviewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestReviewController.CreateStaticDefaultValue), new Action(QuestReviewController.ResetStaticDefaultValue));
	}

	// Token: 0x04009931 RID: 39217
	private readonly List<Action<int?>> ViewRefreshDelegates = new List<Action<int?>>();

	// Token: 0x04009932 RID: 39218
	private readonly Action OnEnterGameSuccess = delegate()
	{
		QuestReviewController.Instance.RequestQuestReviewData();
	};

	// Token: 0x04009933 RID: 39219
	[Nullable(new byte[]
	{
		1,
		2,
		2
	})]
	private readonly Action<IMessage, Net.CallbackStatus> OnQuestReviewInfoNotify = delegate(IMessage __msg, Net.CallbackStatus _)
	{
		QuestReviewInfoNotify questReviewInfoNotify = (QuestReviewInfoNotify)__msg;
		QuestReviewModel.Instance.UpdateAllQuestReviewEntryData(questReviewInfoNotify.EntryInfos);
		QuestReviewModel.Instance.UpdateAllQuestReviewTabData(questReviewInfoNotify.TabInfos);
		QuestReviewModel.Instance.UpdateAllQuestReviewLineData(questReviewInfoNotify.LineInfos);
		QuestReviewModel.Instance.UpdateAllQuestReviewNodeData(questReviewInfoNotify.NodeInfos);
	};

	// Token: 0x04009937 RID: 39223
	[Nullable(2)]
	private static QuestReviewController _Instance;
}
