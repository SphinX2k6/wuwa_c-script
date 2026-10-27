using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002672 RID: 9842
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewController : ControllerBase
{
	// Token: 0x060142B0 RID: 82608 RVA: 0x005179FE File Offset: 0x00515BFE
	protected override bool OnInit()
	{
		this.AddListeners();
		this.BurnFinishPromise = new CustomPromise<object>();
		this.FusionFinishPromise = new CustomPromise<object>();
		this.NewTabUnlockPromise = new CustomPromise<object>();
		return true;
	}

	// Token: 0x060142B1 RID: 82609 RVA: 0x00517A28 File Offset: 0x00515C28
	protected override bool OnClear()
	{
		this.ViewRefreshDelegates.Clear();
		this.RemoveListeners();
		return true;
	}

	// Token: 0x060142B2 RID: 82610 RVA: 0x00517A3C File Offset: 0x00515C3C
	public void AddViewRefreshDelegate(Action<int?> @delegate)
	{
		this.ViewRefreshDelegates.Add(@delegate);
	}

	// Token: 0x060142B3 RID: 82611 RVA: 0x00517A4C File Offset: 0x00515C4C
	public void RemoveViewRefreshDelegate(Action<int?> @delegate)
	{
		int num = this.ViewRefreshDelegates.IndexOf(@delegate);
		if (num >= 0)
		{
			this.ViewRefreshDelegates.RemoveAt(num);
		}
	}

	// Token: 0x060142B4 RID: 82612 RVA: 0x00517A78 File Offset: 0x00515C78
	public void TriggerViewRefresh(int tabId = 0)
	{
		foreach (Action<int?> action in this.ViewRefreshDelegates)
		{
			action(new int?(tabId));
		}
	}

	// Token: 0x060142B5 RID: 82613 RVA: 0x00517AD0 File Offset: 0x00515CD0
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

	// Token: 0x060142B6 RID: 82614 RVA: 0x00517B10 File Offset: 0x00515D10
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

	// Token: 0x060142B7 RID: 82615 RVA: 0x00517B5C File Offset: 0x00515D5C
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

	// Token: 0x060142B8 RID: 82616 RVA: 0x00517BA8 File Offset: 0x00515DA8
	public void OpenQuestNodeDetail(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = QuestReviewModel.Instance.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById != null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestReviewDetailView, questReviewNodeDataById, null);
		}
	}

	// Token: 0x060142B9 RID: 82617 RVA: 0x00517BD5 File Offset: 0x00515DD5
	private void AddListeners()
	{
		Net.Instance.Register(ENotifyMessageId.QuestReviewInfoNotify, this.OnQuestReviewInfoNotify);
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, this.OnEnterGameSuccess);
	}

	// Token: 0x060142BA RID: 82618 RVA: 0x00517C00 File Offset: 0x00515E00
	private void RemoveListeners()
	{
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, this.OnEnterGameSuccess);
		Net.Instance.UnRegister(ENotifyMessageId.QuestReviewInfoNotify);
	}

	// Token: 0x060142BB RID: 82619 RVA: 0x00517C28 File Offset: 0x00515E28
	public UniTask RequestQuestReviewData()
	{
		QuestReviewController.<RequestQuestReviewData>d__13 <RequestQuestReviewData>d__;
		<RequestQuestReviewData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestQuestReviewData>d__.<>1__state = -1;
		<RequestQuestReviewData>d__.<>t__builder.Start<QuestReviewController.<RequestQuestReviewData>d__13>(ref <RequestQuestReviewData>d__);
		return <RequestQuestReviewData>d__.<>t__builder.Task;
	}

	// Token: 0x170019EC RID: 6636
	// (get) Token: 0x060142BC RID: 82620 RVA: 0x00517C63 File Offset: 0x00515E63
	// (set) Token: 0x060142BD RID: 82621 RVA: 0x00517C6B File Offset: 0x00515E6B
	public CustomPromise<object> BurnFinishPromise { get; set; }

	// Token: 0x170019ED RID: 6637
	// (get) Token: 0x060142BE RID: 82622 RVA: 0x00517C74 File Offset: 0x00515E74
	// (set) Token: 0x060142BF RID: 82623 RVA: 0x00517C7C File Offset: 0x00515E7C
	public CustomPromise<object> FusionFinishPromise { get; set; }

	// Token: 0x170019EE RID: 6638
	// (get) Token: 0x060142C0 RID: 82624 RVA: 0x00517C85 File Offset: 0x00515E85
	// (set) Token: 0x060142C1 RID: 82625 RVA: 0x00517C8D File Offset: 0x00515E8D
	public CustomPromise<object> NewTabUnlockPromise { get; set; }

	// Token: 0x060142C2 RID: 82626 RVA: 0x00517C96 File Offset: 0x00515E96
	public void SetBurnFinish()
	{
		if (this.BurnFinishPromise != null)
		{
			this.BurnFinishPromise.SetResult(null);
			this.BurnFinishPromise = null;
		}
	}

	// Token: 0x060142C3 RID: 82627 RVA: 0x00517CB3 File Offset: 0x00515EB3
	public void SetFusionFinish()
	{
		if (this.FusionFinishPromise != null)
		{
			this.FusionFinishPromise.SetResult(null);
			this.FusionFinishPromise = null;
			QuestReviewController.Instance.TriggerViewRefresh(-1);
		}
	}

	// Token: 0x060142C4 RID: 82628 RVA: 0x00517CDB File Offset: 0x00515EDB
	public void SetNewTabUnlockFinish()
	{
		if (this.NewTabUnlockPromise != null)
		{
			this.NewTabUnlockPromise.SetResult(null);
			this.NewTabUnlockPromise = null;
			QuestReviewController.Instance.TriggerViewRefresh(-2);
		}
	}

	// Token: 0x060142C5 RID: 82629 RVA: 0x00517D04 File Offset: 0x00515F04
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

	// Token: 0x170019EF RID: 6639
	// (get) Token: 0x060142C6 RID: 82630 RVA: 0x00517DD9 File Offset: 0x00515FD9
	public static QuestReviewController Instance
	{
		get
		{
			return QuestReviewController._Instance;
		}
	}

	// Token: 0x060142C7 RID: 82631 RVA: 0x00517DE0 File Offset: 0x00515FE0
	public static QuestReviewController GetOrCreateInstance()
	{
		if (QuestReviewController._Instance == null)
		{
			QuestReviewController.CreateInstance();
		}
		return QuestReviewController._Instance;
	}

	// Token: 0x060142C8 RID: 82632 RVA: 0x00517DF4 File Offset: 0x00515FF4
	public static bool CreateInstance()
	{
		if (QuestReviewController._Instance != null)
		{
			return true;
		}
		QuestReviewController._Instance = new QuestReviewController();
		return true;
	}

	// Token: 0x060142C9 RID: 82633 RVA: 0x00517E0A File Offset: 0x0051600A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060142CA RID: 82634 RVA: 0x00517E0C File Offset: 0x0051600C
	public static void ResetStaticDefaultValue()
	{
		QuestReviewController._Instance = null;
	}

	// Token: 0x060142CB RID: 82635 RVA: 0x00517E14 File Offset: 0x00516014
	static QuestReviewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestReviewController.CreateStaticDefaultValue), new Action(QuestReviewController.ResetStaticDefaultValue));
	}

	// Token: 0x040097D9 RID: 38873
	private readonly List<Action<int?>> ViewRefreshDelegates = new List<Action<int?>>();

	// Token: 0x040097DA RID: 38874
	private readonly Action OnEnterGameSuccess = delegate()
	{
		QuestReviewController.Instance.RequestQuestReviewData();
	};

	// Token: 0x040097DB RID: 38875
	[Nullable(new byte[]
	{
		1,
		2,
		2
	})]
	private readonly Action<IMessage, Net.CallbackStatus> OnQuestReviewInfoNotify = delegate(IMessage __msg, Net.CallbackStatus _)
	{
		QuestReviewInfoNotify questReviewInfoNotify = (QuestReviewInfoNotify)__msg;
		QuestReviewModel.Instance.UpdateAllQuestReviewEntryData(questReviewInfoNotify.EntryInfos.ToList<QuestReviewEntryInfo>());
		QuestReviewModel.Instance.UpdateAllQuestReviewTabData(questReviewInfoNotify.TabInfos.ToList<QuestReviewTabInfo>());
		QuestReviewModel.Instance.UpdateAllQuestReviewLineData(questReviewInfoNotify.LineInfos.ToList<QuestReviewLineInfo>());
		QuestReviewModel.Instance.UpdateAllQuestReviewNodeData(questReviewInfoNotify.NodeInfos.ToList<QuestReviewNodeInfo>());
	};

	// Token: 0x040097DF RID: 38879
	[Nullable(2)]
	private static QuestReviewController _Instance;
}
