using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020003C4 RID: 964
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class AchievementController : ControllerBase
{
	// Token: 0x060034C2 RID: 13506 RVA: 0x00137B2A File Offset: 0x00135D2A
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x00137B39 File Offset: 0x00135D39
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00137B48 File Offset: 0x00135D48
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.BattleViewActiveSequenceFinish, new Action(this.OnBattleViewShow));
		EventSystem.Instance.Add<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(EEventName.TsSyncAchievementFinish, new Action<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(this.TsSyncAchievementFinish));
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x00137BAC File Offset: 0x00135DAC
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.BattleViewActiveSequenceFinish, new Action(this.OnBattleViewShow));
		EventSystem.Instance.Remove(EEventName.TsSyncAchievementFinish, new Action<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(this.TsSyncAchievementFinish));
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x00137C10 File Offset: 0x00135E10
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AchievementProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementGroupProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementGroupProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementListProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementListProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementCountChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementCountChangeNotify));
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00137C90 File Offset: 0x00135E90
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AchievementProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementGroupProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementListProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementCountChangeNotify);
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x00137CDD File Offset: 0x00135EDD
	public void OpenAchievementMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.AchievementMainView, null, null);
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x00137CF0 File Offset: 0x00135EF0
	public void ChangeAchievementPopViewShowState()
	{
		this.AchievementPopViewShowState = !this.AchievementPopViewShowState;
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00137D04 File Offset: 0x00135F04
	public void OpenAchievementDetailView(int categoryId, int? groupId, int achievementId = -1)
	{
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(groupId);
		AchievementCategoryData category = AchievementModel.Instance.GetCategory(categoryId);
		AchievementModel.Instance.CurrentSelectCategory = category;
		AchievementModel.Instance.CurrentSelectGroup = achievementGroupData;
		AchievementModel.Instance.AchievementSearchState = false;
		AchievementModel.Instance.CurrentSelectAchievementId = achievementId;
		AchievementModel.Instance.CurrentSearchText = "";
		UiManager.Instance.OpenView(EUiViewName.AchievementDetailView, null, null);
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00137D75 File Offset: 0x00135F75
	private void OnLoadingNetDataDone()
	{
		this.RequestAchievementBasicInfo();
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00137D80 File Offset: 0x00135F80
	private UniTask RequestAchievementBasicInfo()
	{
		AchievementController.<RequestAchievementBasicInfo>d__11 <RequestAchievementBasicInfo>d__;
		<RequestAchievementBasicInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestAchievementBasicInfo>d__.<>1__state = -1;
		<RequestAchievementBasicInfo>d__.<>t__builder.Start<AchievementController.<RequestAchievementBasicInfo>d__11>(ref <RequestAchievementBasicInfo>d__);
		return <RequestAchievementBasicInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00137DBC File Offset: 0x00135FBC
	public UniTask RequestUpdateAchievementInfo()
	{
		AchievementController.<RequestUpdateAchievementInfo>d__12 <RequestUpdateAchievementInfo>d__;
		<RequestUpdateAchievementInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdateAchievementInfo>d__.<>1__state = -1;
		<RequestUpdateAchievementInfo>d__.<>t__builder.Start<AchievementController.<RequestUpdateAchievementInfo>d__12>(ref <RequestUpdateAchievementInfo>d__);
		return <RequestUpdateAchievementInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00137DF8 File Offset: 0x00135FF8
	public void RequestGetAchievementReward(bool isGroup, int id)
	{
		AchievementReceiveRequest achievementReceiveRequest = AchievementReceiveRequest.Create();
		achievementReceiveRequest.Id = id;
		achievementReceiveRequest.IsGroupId = isGroup;
		Net.Instance.Call(ERequestMessageId.AchievementReceiveRequest, achievementReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AchievementReceiveResponse achievementReceiveResponse = (AchievementReceiveResponse)msg;
			if (achievementReceiveResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(achievementReceiveResponse.ErrorCode, 25408, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x00137E4C File Offset: 0x0013604C
	[NullableContext(1)]
	public void RequestGetMultiAchievementReward(int[] ids, int[] groupIds)
	{
		MulAchievementReceiveRequest mulAchievementReceiveRequest = MulAchievementReceiveRequest.Create();
		mulAchievementReceiveRequest.AchievementIds.AddRange(ids);
		mulAchievementReceiveRequest.AchievementGroupIds.AddRange(groupIds);
		Net.Instance.Call(ERequestMessageId.MulAchievementReceiveRequest, mulAchievementReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MulAchievementReceiveResponse mulAchievementReceiveResponse = (MulAchievementReceiveResponse)msg;
			if (mulAchievementReceiveResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulAchievementReceiveResponse.ErrorCode, 19770, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x00137EA8 File Offset: 0x001360A8
	public void RequestAchievementFinish(int id)
	{
		AchievementFinishRequest achievementFinishRequest = AchievementFinishRequest.Create();
		achievementFinishRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.AchievementFinishRequest, achievementFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AchievementFinishResponse achievementFinishResponse = (AchievementFinishResponse)msg;
			if (achievementFinishResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(achievementFinishResponse.ErrorCode, 19182, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x00137EF4 File Offset: 0x001360F4
	private void OnAchievementProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementProgressNotify achievementProgressNotify = (AchievementProgressNotify)msg;
		this.UpdateAchievement(achievementProgressNotify.AchievementEntry);
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00137F14 File Offset: 0x00136114
	private void UpdateAchievement(AchievementEntry data)
	{
		EAchievementStateEnum finishState = AchievementModel.Instance.GetAchievementData(data.Id).GetFinishState();
		AchievementModel.Instance.OnAchievementProgressNotify(data);
		EAchievementStateEnum finishState2 = AchievementModel.Instance.GetAchievementData(data.Id).GetFinishState();
		if (finishState != finishState2 && finishState2 != EAchievementStateEnum.HaveGetReward && finishState2 != EAchievementStateEnum.UnFinished)
		{
			AchievementData achievementData = AchievementModel.Instance.GetAchievementData(data.Id);
			if (!AchievementModel.Instance.IsHideAchievementGroup(achievementData.GetGroupId()))
			{
				AchievementModel.Instance.CurrentFinishAchievementArray.Add(data.Id);
				this.TryOpenAchievementFinishView();
			}
		}
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x00137F9F File Offset: 0x0013619F
	private void OnBattleViewShow()
	{
		this.TryOpenAchievementFinishView();
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00137FA8 File Offset: 0x001361A8
	private void TryOpenAchievementFinishView()
	{
		if (!this.AchievementPopViewShowState)
		{
			return;
		}
		List<int> currentFinishAchievementArray = AchievementModel.Instance.CurrentFinishAchievementArray;
		while (currentFinishAchievementArray.Count > 0)
		{
			int id = currentFinishAchievementArray[0];
			currentFinishAchievementArray.RemoveAt(0);
			AchievementData achievementData = AchievementModel.Instance.GetAchievementData(id);
			UiManager.Instance.OpenView(EUiViewName.AchievementCompleteTipsView, achievementData, null);
		}
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x00138000 File Offset: 0x00136200
	private void OnAchievementListProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementListProgressNotify achievementListProgressNotify = (AchievementListProgressNotify)msg;
		int count = achievementListProgressNotify.AchievementEntryList.Count;
		for (int i = 0; i < count; i++)
		{
			this.UpdateAchievement(achievementListProgressNotify.AchievementEntryList[i]);
		}
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x00138040 File Offset: 0x00136240
	private void OnAchievementCountChangeNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementCountChangeNotify message = (AchievementCountChangeNotify)msg;
		AchievementModel.Instance.OnAchievementCountChangeNotify(message);
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x00138060 File Offset: 0x00136260
	private void OnAchievementGroupProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementGroupProgressNotify message = (AchievementGroupProgressNotify)msg;
		AchievementModel.Instance.OnAchievementGroupProgressNotify(message);
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x0013807F File Offset: 0x0013627F
	[NullableContext(1)]
	private void TsSyncAchievementFinish(IReadOnlyList<int> categoryIds, IReadOnlyList<int> groupIds, IReadOnlyList<int> achievementIds, int startCount, int finishCount)
	{
		AchievementModel.Instance.OnTsDataReady(categoryIds, groupIds, achievementIds, startCount, finishCount);
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x060034D9 RID: 13529 RVA: 0x00138092 File Offset: 0x00136292
	[Nullable(1)]
	public static AchievementController Instance
	{
		[NullableContext(1)]
		get
		{
			return AchievementController._Instance;
		}
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x00138099 File Offset: 0x00136299
	[NullableContext(1)]
	public static AchievementController GetOrCreateInstance()
	{
		if (AchievementController._Instance == null)
		{
			AchievementController.CreateInstance();
		}
		return AchievementController._Instance;
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x001380AD File Offset: 0x001362AD
	public static bool CreateInstance()
	{
		if (AchievementController._Instance != null)
		{
			return true;
		}
		AchievementController._Instance = new AchievementController();
		return true;
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x001380C3 File Offset: 0x001362C3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x001380C5 File Offset: 0x001362C5
	public static void ResetStaticDefaultValue()
	{
		AchievementController._Instance = null;
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x001380CD File Offset: 0x001362CD
	static AchievementController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementController.CreateStaticDefaultValue), new Action(AchievementController.ResetStaticDefaultValue));
	}

	// Token: 0x04002CD4 RID: 11476
	private bool AchievementPopViewShowState = true;

	// Token: 0x04002CD5 RID: 11477
	private static AchievementController _Instance;
}
