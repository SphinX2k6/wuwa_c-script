using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000F0F RID: 3855
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class AchievementController : ControllerBase
{
	// Token: 0x0600612A RID: 24874 RVA: 0x0012F206 File Offset: 0x0012D406
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600612B RID: 24875 RVA: 0x0012F215 File Offset: 0x0012D415
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600612C RID: 24876 RVA: 0x0012F224 File Offset: 0x0012D424
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.BattleViewActiveSequenceFinish, new Action(this.OnBattleViewShow));
		EventSystem.Instance.Add<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(EEventName.TsSyncAchievementFinish, new Action<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(this.TsSyncAchievementFinish));
	}

	// Token: 0x0600612D RID: 24877 RVA: 0x0012F288 File Offset: 0x0012D488
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.BattleViewActiveSequenceFinish, new Action(this.OnBattleViewShow));
		EventSystem.Instance.Remove(EEventName.TsSyncAchievementFinish, new Action<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>, int, int>(this.TsSyncAchievementFinish));
	}

	// Token: 0x0600612E RID: 24878 RVA: 0x0012F2EC File Offset: 0x0012D4EC
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AchievementProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementGroupProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementGroupProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementListProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementListProgressNotify));
		Net.Instance.Register(ENotifyMessageId.AchievementCountChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAchievementCountChangeNotify));
	}

	// Token: 0x0600612F RID: 24879 RVA: 0x0012F36C File Offset: 0x0012D56C
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AchievementProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementGroupProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementListProgressNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AchievementCountChangeNotify);
	}

	// Token: 0x06006130 RID: 24880 RVA: 0x0012F3B9 File Offset: 0x0012D5B9
	public void OpenAchievementMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.AchievementMainView, null, null);
	}

	// Token: 0x06006131 RID: 24881 RVA: 0x0012F3CC File Offset: 0x0012D5CC
	public void ChangeAchievementPopViewShowState()
	{
		this.AchievementPopViewShowState = !this.AchievementPopViewShowState;
	}

	// Token: 0x06006132 RID: 24882 RVA: 0x0012F3E0 File Offset: 0x0012D5E0
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

	// Token: 0x06006133 RID: 24883 RVA: 0x0012F451 File Offset: 0x0012D651
	private void OnLoadingNetDataDone()
	{
		this.RequestAchievementBasicInfo();
	}

	// Token: 0x06006134 RID: 24884 RVA: 0x0012F45C File Offset: 0x0012D65C
	private UniTask RequestAchievementBasicInfo()
	{
		AchievementController.<RequestAchievementBasicInfo>d__11 <RequestAchievementBasicInfo>d__;
		<RequestAchievementBasicInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestAchievementBasicInfo>d__.<>1__state = -1;
		<RequestAchievementBasicInfo>d__.<>t__builder.Start<AchievementController.<RequestAchievementBasicInfo>d__11>(ref <RequestAchievementBasicInfo>d__);
		return <RequestAchievementBasicInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06006135 RID: 24885 RVA: 0x0012F498 File Offset: 0x0012D698
	public UniTask RequestUpdateAchievementInfo()
	{
		AchievementController.<RequestUpdateAchievementInfo>d__12 <RequestUpdateAchievementInfo>d__;
		<RequestUpdateAchievementInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdateAchievementInfo>d__.<>1__state = -1;
		<RequestUpdateAchievementInfo>d__.<>t__builder.Start<AchievementController.<RequestUpdateAchievementInfo>d__12>(ref <RequestUpdateAchievementInfo>d__);
		return <RequestUpdateAchievementInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06006136 RID: 24886 RVA: 0x0012F4D4 File Offset: 0x0012D6D4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(achievementReceiveResponse.ErrorCode, 22908, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06006137 RID: 24887 RVA: 0x0012F528 File Offset: 0x0012D728
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulAchievementReceiveResponse.ErrorCode, 29250, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x0012F584 File Offset: 0x0012D784
	public void RequestAchievementFinish(int id)
	{
		AchievementFinishRequest achievementFinishRequest = AchievementFinishRequest.Create();
		achievementFinishRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.AchievementFinishRequest, achievementFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AchievementFinishResponse achievementFinishResponse = (AchievementFinishResponse)msg;
			if (achievementFinishResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(achievementFinishResponse.ErrorCode, 21914, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x0012F5D0 File Offset: 0x0012D7D0
	private void OnAchievementProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementProgressNotify achievementProgressNotify = (AchievementProgressNotify)msg;
		this.UpdateAchievement(achievementProgressNotify.AchievementEntry);
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x0012F5F0 File Offset: 0x0012D7F0
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

	// Token: 0x0600613B RID: 24891 RVA: 0x0012F67B File Offset: 0x0012D87B
	private void OnBattleViewShow()
	{
		this.TryOpenAchievementFinishView();
	}

	// Token: 0x0600613C RID: 24892 RVA: 0x0012F684 File Offset: 0x0012D884
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

	// Token: 0x0600613D RID: 24893 RVA: 0x0012F6DC File Offset: 0x0012D8DC
	private void OnAchievementListProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementListProgressNotify achievementListProgressNotify = (AchievementListProgressNotify)msg;
		int count = achievementListProgressNotify.AchievementEntryList.Count;
		for (int i = 0; i < count; i++)
		{
			this.UpdateAchievement(achievementListProgressNotify.AchievementEntryList[i]);
		}
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x0012F71C File Offset: 0x0012D91C
	private void OnAchievementCountChangeNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementCountChangeNotify message = (AchievementCountChangeNotify)msg;
		AchievementModel.Instance.OnAchievementCountChangeNotify(message);
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x0012F73C File Offset: 0x0012D93C
	private void OnAchievementGroupProgressNotify(IMessage msg, Net.CallbackStatus _)
	{
		AchievementGroupProgressNotify message = (AchievementGroupProgressNotify)msg;
		AchievementModel.Instance.OnAchievementGroupProgressNotify(message);
	}

	// Token: 0x06006140 RID: 24896 RVA: 0x0012F75B File Offset: 0x0012D95B
	[NullableContext(1)]
	private void TsSyncAchievementFinish(IReadOnlyList<int> categoryIds, IReadOnlyList<int> groupIds, IReadOnlyList<int> achievementIds, int startCount, int finishCount)
	{
		AchievementModel.Instance.OnTsDataReady(categoryIds, groupIds, achievementIds, startCount, finishCount);
	}

	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x06006141 RID: 24897 RVA: 0x0012F76E File Offset: 0x0012D96E
	[Nullable(1)]
	public static AchievementController Instance
	{
		[NullableContext(1)]
		get
		{
			return AchievementController._Instance;
		}
	}

	// Token: 0x06006142 RID: 24898 RVA: 0x0012F775 File Offset: 0x0012D975
	[NullableContext(1)]
	public static AchievementController GetOrCreateInstance()
	{
		if (AchievementController._Instance == null)
		{
			AchievementController.CreateInstance();
		}
		return AchievementController._Instance;
	}

	// Token: 0x06006143 RID: 24899 RVA: 0x0012F789 File Offset: 0x0012D989
	public static bool CreateInstance()
	{
		if (AchievementController._Instance != null)
		{
			return true;
		}
		AchievementController._Instance = new AchievementController();
		return true;
	}

	// Token: 0x06006144 RID: 24900 RVA: 0x0012F79F File Offset: 0x0012D99F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006145 RID: 24901 RVA: 0x0012F7A1 File Offset: 0x0012D9A1
	public static void ResetStaticDefaultValue()
	{
		AchievementController._Instance = null;
	}

	// Token: 0x06006146 RID: 24902 RVA: 0x0012F7A9 File Offset: 0x0012D9A9
	static AchievementController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementController.CreateStaticDefaultValue), new Action(AchievementController.ResetStaticDefaultValue));
	}

	// Token: 0x04002C3B RID: 11323
	private bool AchievementPopViewShowState = true;

	// Token: 0x04002C3C RID: 11324
	private static AchievementController _Instance;
}
