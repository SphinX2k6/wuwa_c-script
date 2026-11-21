using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extensions;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020010EE RID: 4334
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FriendController : ControllerBase
{
	// Token: 0x0600ACD7 RID: 44247 RVA: 0x0032ED36 File Offset: 0x0032CF36
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600ACD8 RID: 44248 RVA: 0x0032ED45 File Offset: 0x0032CF45
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		this.CancelTimer();
		this.FirstCheckFriendState = false;
		this.PastWorldMutiState = false;
		return true;
	}

	// Token: 0x0600ACD9 RID: 44249 RVA: 0x0032ED68 File Offset: 0x0032CF68
	private void InitTimer()
	{
		this.CancelTimer();
		this.CheckFriendTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRequestFriendDataTimer), 30000f, 1f, null, null, true);
	}

	// Token: 0x0600ACDA RID: 44250 RVA: 0x0032ED99 File Offset: 0x0032CF99
	private void OnRequestFriendDataTimer(float delta)
	{
		this.RequestAllFriend(false, null);
	}

	// Token: 0x0600ACDB RID: 44251 RVA: 0x0032EDA3 File Offset: 0x0032CFA3
	private void CancelTimer()
	{
		if (this.CheckFriendTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CheckFriendTimer);
			this.CheckFriendTimer = null;
		}
	}

	// Token: 0x0600ACDC RID: 44252 RVA: 0x0032EDC8 File Offset: 0x0032CFC8
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(this.ValidateRedDot));
		EventSystem.Instance.Add(EEventName.ScenePlayerChanged, new Action(this.OnRefreshOnlineTeamList));
		EventSystem.Instance.Add<int>(EEventName.LoadTestFriendsByGm, new Action<int>(this.CallBackLoadTestFriendsByGm));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsOnRequestFriendInfoResponse, new Action<FArrayBuffer>(this.TsOnRequestFriendInfoResponse));
		EventSystem.Instance.Add<int, string>(EEventName.TsSyncChangePlayerRemark, new Action<int, string>(this.OnTsSyncChangePlayerRemark));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsSyncResponseSearchBasicData, new Action<FArrayBuffer>(this.OnTsSyncResponseSearchBasicData));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsSyncResponseSearchSdkData, new Action<FArrayBuffer>(this.OnTsSyncResponseSearchSdkData));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsResponseBlockData, new Action<FArrayBuffer>(this.OnTsResponseBlockData));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsResponseFriendRecentlyTeam, new Action<FArrayBuffer>(this.TsResponseFriendRecentlyTeam));
	}

	// Token: 0x0600ACDD RID: 44253 RVA: 0x0032EF28 File Offset: 0x0032D128
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(this.ValidateRedDot));
		EventSystem.Instance.Remove(EEventName.ScenePlayerChanged, new Action(this.OnRefreshOnlineTeamList));
		EventSystem.Instance.Remove(EEventName.LoadTestFriendsByGm, new Action<int>(this.CallBackLoadTestFriendsByGm));
		EventSystem.Instance.Remove(EEventName.TsOnRequestFriendInfoResponse, new Action<FArrayBuffer>(this.TsOnRequestFriendInfoResponse));
		EventSystem.Instance.Remove(EEventName.TsSyncChangePlayerRemark, new Action<int, string>(this.OnTsSyncChangePlayerRemark));
		EventSystem.Instance.Remove(EEventName.TsSyncResponseSearchBasicData, new Action<FArrayBuffer>(this.OnTsSyncResponseSearchBasicData));
		EventSystem.Instance.Remove(EEventName.TsSyncResponseSearchSdkData, new Action<FArrayBuffer>(this.OnTsSyncResponseSearchSdkData));
		EventSystem.Instance.Remove(EEventName.TsResponseBlockData, new Action<FArrayBuffer>(this.OnTsResponseBlockData));
		EventSystem.Instance.Remove(EEventName.TsResponseFriendRecentlyTeam, new Action<FArrayBuffer>(this.TsResponseFriendRecentlyTeam));
	}

	// Token: 0x0600ACDE RID: 44254 RVA: 0x0032F085 File Offset: 0x0032D285
	private void OnRefreshOnlineTeamList()
	{
		this.RequestAllFriend(true, null);
	}

	// Token: 0x0600ACDF RID: 44255 RVA: 0x0032F090 File Offset: 0x0032D290
	private void OnWorldDone()
	{
		if (!this.FirstCheckFriendState)
		{
			this.FirstCheckFriendState = true;
			return;
		}
		if (this.PastWorldMutiState != GameModeModel.Instance.IsMulti)
		{
			this.RequestAllFriend(true, new Action(FriendController.<OnWorldDone>g__callback|15_0));
		}
		this.PastWorldMutiState = GameModeModel.Instance.IsMulti;
	}

	// Token: 0x0600ACE0 RID: 44256 RVA: 0x0032F0E2 File Offset: 0x0032D2E2
	private void OnDataDone()
	{
		this.RequestAllFriend(true, new Action(FriendController.<OnDataDone>g__callback|16_0));
		this.InitTimer();
	}

	// Token: 0x0600ACE1 RID: 44257 RVA: 0x0032F0FD File Offset: 0x0032D2FD
	private void ValidateRedDot()
	{
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
	}

	// Token: 0x0600ACE2 RID: 44258 RVA: 0x0032F110 File Offset: 0x0032D310
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.FriendAddedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendAddedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendDeletedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendDeletedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendApplyReceivedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendApplyReceivedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendApplyDeletedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendApplyDeletedNotify));
	}

	// Token: 0x0600ACE3 RID: 44259 RVA: 0x0032F190 File Offset: 0x0032D390
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.FriendAddedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendDeletedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendApplyReceivedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendApplyDeletedNotify);
	}

	// Token: 0x0600ACE4 RID: 44260 RVA: 0x0032F1E0 File Offset: 0x0032D3E0
	[NullableContext(2)]
	public void RequestAllFriend(bool force = false, Action call = null)
	{
		if ((TimeUtil.Instance.GetServerTime() <= this.TargetRequestTimeStamp || !LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.EnterGameRet)) && !force)
		{
			return;
		}
		float num = 2.5f;
		if (force && TimeUtil.Instance.GetServerTime() - this.LastSendTime < (double)num)
		{
			TimerSystem.GameplayTimeInstance.Delay(delegate(float delta)
			{
				this.RequestAllFriend(force, call);
			}, 2500f, null, null, true, 1f);
			return;
		}
		FriendAllRequest message = FriendAllRequest.Create();
		this.TargetRequestTimeStamp = TimeUtil.Instance.GetServerTime() + 300.0;
		this.LastSendTime = TimeUtil.Instance.GetServerTime();
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		Net.Instance.Call(ERequestMessageId.FriendAllRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FriendAllResponse message2 = (FriendAllResponse)msg;
			Action call2 = call;
			if (call2 != null)
			{
				call2();
			}
			this.OnRequestAllFriendResponse(message2);
		}, 0);
	}

	// Token: 0x0600ACE5 RID: 44261 RVA: 0x0032F2D4 File Offset: 0x0032D4D4
	[NullableContext(2)]
	private UniTask OnRequestAllFriendResponse(FriendAllResponse message)
	{
		FriendController.<OnRequestAllFriendResponse>d__23 <OnRequestAllFriendResponse>d__;
		<OnRequestAllFriendResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnRequestAllFriendResponse>d__.message = message;
		<OnRequestAllFriendResponse>d__.<>1__state = -1;
		<OnRequestAllFriendResponse>d__.<>t__builder.Start<FriendController.<OnRequestAllFriendResponse>d__23>(ref <OnRequestAllFriendResponse>d__);
		return <OnRequestAllFriendResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACE6 RID: 44262 RVA: 0x0032F318 File Offset: 0x0032D518
	[NullableContext(2)]
	private void FriendAddedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendAddedNotify message = (FriendAddedNotify)msg;
		this.OnFriendAddedNotify(message);
	}

	// Token: 0x0600ACE7 RID: 44263 RVA: 0x0032F334 File Offset: 0x0032D534
	private UniTask OnFriendAddedNotify(FriendAddedNotify message)
	{
		FriendController.<OnFriendAddedNotify>d__25 <OnFriendAddedNotify>d__;
		<OnFriendAddedNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnFriendAddedNotify>d__.message = message;
		<OnFriendAddedNotify>d__.<>1__state = -1;
		<OnFriendAddedNotify>d__.<>t__builder.Start<FriendController.<OnFriendAddedNotify>d__25>(ref <OnFriendAddedNotify>d__);
		return <OnFriendAddedNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACE8 RID: 44264 RVA: 0x0032F378 File Offset: 0x0032D578
	[NullableContext(2)]
	private void FriendDeletedNotify(IMessage msg, Net.CallbackStatus status)
	{
		int id = ((FriendDeletedNotify)msg).Id;
		ChatController.Instance.TryActiveDeleteFriendTips(id);
		FriendModel.Instance.DeleteFriend(id);
	}

	// Token: 0x0600ACE9 RID: 44265 RVA: 0x0032F3A8 File Offset: 0x0032D5A8
	[NullableContext(2)]
	private void FriendApplyReceivedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendApplyReceivedNotify message = (FriendApplyReceivedNotify)msg;
		this.OnFriendApplyReceivedNotify(message);
	}

	// Token: 0x0600ACEA RID: 44266 RVA: 0x0032F3C4 File Offset: 0x0032D5C4
	private UniTask OnFriendApplyReceivedNotify(FriendApplyReceivedNotify message)
	{
		FriendController.<OnFriendApplyReceivedNotify>d__28 <OnFriendApplyReceivedNotify>d__;
		<OnFriendApplyReceivedNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnFriendApplyReceivedNotify>d__.message = message;
		<OnFriendApplyReceivedNotify>d__.<>1__state = -1;
		<OnFriendApplyReceivedNotify>d__.<>t__builder.Start<FriendController.<OnFriendApplyReceivedNotify>d__28>(ref <OnFriendApplyReceivedNotify>d__);
		return <OnFriendApplyReceivedNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACEB RID: 44267 RVA: 0x0032F408 File Offset: 0x0032D608
	[NullableContext(2)]
	private void FriendApplyDeletedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendApplyDeletedNotify friendApplyDeletedNotify = (FriendApplyDeletedNotify)msg;
		FriendModel.Instance.DeleteFriendApplication(friendApplyDeletedNotify.Id);
	}

	// Token: 0x0600ACEC RID: 44268 RVA: 0x0032F42C File Offset: 0x0032D62C
	public void RequestFriendApplyAddSend(int id, FriendApplyWay fromWhere)
	{
		if (this.LastApplyAddFriendRequestTime != 0.0 && Time.Instance.Now - this.LastApplyAddFriendRequestTime <= 1000.0)
		{
			return;
		}
		this.LastApplyAddFriendRequestTime = Time.Instance.Now;
		FriendApplySendRequest message = FriendApplySendRequest.Create();
		message.Id = id;
		message.Way = fromWhere;
		Net.Instance.Call(ERequestMessageId.FriendApplySendRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FriendApplySendResponse friendApplySendResponse = (FriendApplySendResponse)msg;
			if (friendApplySendResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrReceiverApplyListCountMax)
				{
					GenericPromptController.Instance.ShowPromptByCode("RecipientFriendListFull", Array.Empty<object>());
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrFriendApplySended)
				{
					FriendModel.Instance.AddPlayerToApplyFriendList(message.Id);
					GenericPromptController.Instance.ShowPromptByCode("FriendApplicationSent", Array.Empty<object>());
					EventSystem.Instance.Emit<int>(EEventName.ApplicationSent, message.Id);
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrAlreadyOnFriendApplyList)
				{
					GenericPromptController.Instance.ShowPromptByCode("FriendApplicationSent", Array.Empty<object>());
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrIsBlockedPlayer)
				{
					GenericPromptController.Instance.ShowPromptByCode("IsBlockedPlayer", Array.Empty<object>());
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrYouAreBlocked)
				{
					GenericPromptController.Instance.ShowPromptByCode("YouAreBlocked", Array.Empty<object>());
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrFriendApplyRequestLimit)
				{
					GenericPromptController.Instance.ShowPromptByCode("ApplicationTimesLimit", Array.Empty<object>());
					return;
				}
				if (friendApplySendResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrAlreadyOnFriendList)
				{
					GenericPromptController.Instance.ShowPromptByCode("AlreadyOnFriendList", Array.Empty<object>());
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(friendApplySendResponse.ErrorCode, 15562, null, true, true);
			}
			FriendModel.Instance.AddPlayerToApplyFriendList(message.Id);
			GenericPromptController.Instance.ShowPromptByCode("FriendApplicationSent", Array.Empty<object>());
			EventSystem.Instance.Emit<int>(EEventName.ApplicationSent, message.Id);
		}, 0);
	}

	// Token: 0x0600ACED RID: 44269 RVA: 0x0032F4C4 File Offset: 0x0032D6C4
	public void RequestFriendApplyHandle(List<int> ids, FriendApplyOperator operation)
	{
		FriendApplyHandleRequest message = FriendApplyHandleRequest.Create();
		if (ids.Count == 0)
		{
			EventSystem.Instance.Emit(EEventName.FriendApplicationListUpdate);
			EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
			return;
		}
		message.Ids.AddRange(ids);
		message.Operator = operation;
		Net.Instance.Call(ERequestMessageId.FriendApplyHandleRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FriendApplyHandleResponse friendApplyHandleResponse = (FriendApplyHandleResponse)msg;
			string errorCodeShowString = this.GetErrorCodeShowString(friendApplyHandleResponse.ErrorCode);
			bool flag = message.Ids.Count > 1;
			int num = 0;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, Aki.Protocol.ErrorCode> keyValuePair in friendApplyHandleResponse.HandledMap)
			{
				dictionary.Add(keyValuePair.Key, (int)keyValuePair.Value);
			}
			EventSystem.Instance.Emit<int, IReadOnlyDictionary<int, int>>(EEventName.CsRequestFriendHandle, (int)message.Operator, dictionary);
			if (message.Operator == FriendApplyOperator.Approve)
			{
				foreach (KeyValuePair<int, Aki.Protocol.ErrorCode> keyValuePair2 in friendApplyHandleResponse.HandledMap)
				{
					Aki.Protocol.ErrorCode value = keyValuePair2.Value;
					if (value == Aki.Protocol.ErrorCode.Success)
					{
						FriendData friendDataInApplicationById = FriendModel.Instance.GetFriendDataInApplicationById(keyValuePair2.Key);
						if (friendDataInApplicationById != null)
						{
							FriendModel.Instance.AddFriend(friendDataInApplicationById);
						}
					}
					else
					{
						if (value == Aki.Protocol.ErrorCode.ErrPlayerAccountDeactivation)
						{
							FriendModel.Instance.DeleteFriendApplication(keyValuePair2.Key);
						}
						if (errorCodeShowString == "")
						{
							errorCodeShowString = this.GetErrorCodeShowString(value);
						}
					}
				}
			}
			foreach (KeyValuePair<int, Aki.Protocol.ErrorCode> keyValuePair3 in friendApplyHandleResponse.HandledMap)
			{
				Aki.Protocol.ErrorCode value2 = keyValuePair3.Value;
				if (value2 == Aki.Protocol.ErrorCode.Success)
				{
					num++;
					FriendModel.Instance.DeleteFriendApplication(keyValuePair3.Key);
					if (message.Operator == FriendApplyOperator.Approve)
					{
						FriendModel.Instance.AddPlayerToApproveFriendList(keyValuePair3.Key);
					}
					else if (message.Operator == FriendApplyOperator.Reject)
					{
						FriendModel.Instance.AddPlayerToRefuseFriendList(keyValuePair3.Key);
					}
				}
				else if (errorCodeShowString == "")
				{
					errorCodeShowString = this.GetErrorCodeShowString(value2);
				}
			}
			if (errorCodeShowString != "")
			{
				if (!flag)
				{
					GenericPromptController.Instance.ShowPromptByCode(errorCodeShowString, Array.Empty<object>());
				}
				else if (flag && num == 0)
				{
					GenericPromptController.Instance.ShowPromptByCode(errorCodeShowString, Array.Empty<object>());
				}
			}
			EventSystem.Instance.Emit(EEventName.FriendApplicationListUpdate);
			EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
			if (operation == FriendApplyOperator.Reject)
			{
				EventSystem.Instance.Emit<EFriendItemOperation, IReadOnlyList<int>>(EEventName.ApplicationHandled, EFriendItemOperation.Refuse, ids);
				return;
			}
			if (operation == FriendApplyOperator.Approve)
			{
				EventSystem.Instance.Emit<EFriendItemOperation, IReadOnlyList<int>>(EEventName.ApplicationHandled, EFriendItemOperation.Approve, ids);
			}
		}, 0);
	}

	// Token: 0x0600ACEE RID: 44270 RVA: 0x0032F56E File Offset: 0x0032D76E
	private string GetErrorCodeShowString(Aki.Protocol.ErrorCode errorCode)
	{
		if (errorCode == Aki.Protocol.ErrorCode.Success)
		{
			return "";
		}
		if (errorCode == Aki.Protocol.ErrorCode.ErrInitiatorFriendListCountMax)
		{
			return "ApplicantFriendListFull";
		}
		if (errorCode == Aki.Protocol.ErrorCode.ErrFriendListCountMax)
		{
			return "FriendListFull";
		}
		if (errorCode == Aki.Protocol.ErrorCode.ErrPlayerAccountDeactivation)
		{
			return "PlayerDeleteSelf";
		}
		return "FriendApplicationInvalid";
	}

	// Token: 0x0600ACEF RID: 44271 RVA: 0x0032F5A8 File Offset: 0x0032D7A8
	public void LocalRemoveApplicationFriend(int friend)
	{
		FriendModel.Instance.DeleteFriendApplication(friend);
		EventSystem.Instance.Emit(EEventName.FriendApplicationListUpdate);
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
	}

	// Token: 0x0600ACF0 RID: 44272 RVA: 0x0032F5D8 File Offset: 0x0032D7D8
	[NullableContext(0)]
	public UniTask<Aki.Protocol.ErrorCode> RequestFriendRemarkChange(int? id, [Nullable(1)] string remark)
	{
		FriendController.<RequestFriendRemarkChange>d__34 <RequestFriendRemarkChange>d__;
		<RequestFriendRemarkChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
		<RequestFriendRemarkChange>d__.id = id;
		<RequestFriendRemarkChange>d__.remark = remark;
		<RequestFriendRemarkChange>d__.<>1__state = -1;
		<RequestFriendRemarkChange>d__.<>t__builder.Start<FriendController.<RequestFriendRemarkChange>d__34>(ref <RequestFriendRemarkChange>d__);
		return <RequestFriendRemarkChange>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACF1 RID: 44273 RVA: 0x0032F624 File Offset: 0x0032D824
	public void RequestFriendDelete(int id)
	{
		FriendDeleteRequest friendDeleteRequest = FriendDeleteRequest.Create();
		friendDeleteRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.FriendDeleteRequest, friendDeleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FriendDeleteResponse response = (FriendDeleteResponse)msg;
			this.OnRequestFriendDeleteResponse(response, id);
		}, 0);
	}

	// Token: 0x0600ACF2 RID: 44274 RVA: 0x0032F674 File Offset: 0x0032D874
	private void OnRequestFriendDeleteResponse(FriendDeleteResponse response, int id)
	{
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			GenericPromptController.Instance.ShowPromptByCode("FriendDeleteSuccess", Array.Empty<object>());
			FriendModel.Instance.DeleteFriend(id);
			EventSystem.Instance.Emit<int>(EEventName.CsRequestFriendDelete, id);
			EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.ErrNotOnFriendList)
		{
			GenericPromptController.Instance.ShowPromptByCode("NotOnFriendList", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 17425, null, true, true);
	}

	// Token: 0x0600ACF3 RID: 44275 RVA: 0x0032F714 File Offset: 0x0032D914
	public void RequestBlackList()
	{
		BlockListRequest message = BlockListRequest.Create();
		Net.Instance.Call(ERequestMessageId.BlockListRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BlockListResponse blockListResponse = (BlockListResponse)msg;
			if (blockListResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(blockListResponse.ErrorCode, 23512, null, true, true);
				return;
			}
			this.OnBlackListResponse(blockListResponse);
		}, 0);
	}

	// Token: 0x0600ACF4 RID: 44276 RVA: 0x0032F744 File Offset: 0x0032D944
	private UniTask OnBlackListResponse(BlockListResponse message)
	{
		FriendController.<OnBlackListResponse>d__38 <OnBlackListResponse>d__;
		<OnBlackListResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBlackListResponse>d__.message = message;
		<OnBlackListResponse>d__.<>1__state = -1;
		<OnBlackListResponse>d__.<>t__builder.Start<FriendController.<OnBlackListResponse>d__38>(ref <OnBlackListResponse>d__);
		return <OnBlackListResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACF5 RID: 44277 RVA: 0x0032F788 File Offset: 0x0032D988
	public void RequestBlockPlayer(int playerId)
	{
		BlockPlayerRequest blockPlayerRequest = BlockPlayerRequest.Create();
		blockPlayerRequest.Id = playerId;
		Net.Instance.Call(ERequestMessageId.BlockPlayerRequest, blockPlayerRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BlockPlayerResponse blockPlayerResponse = (BlockPlayerResponse)msg;
			if (blockPlayerResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				this.OnBlockPlayerResponse(playerId, blockPlayerResponse);
				return;
			}
			if (blockPlayerResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrIsBlockedPlayer)
			{
				GenericPromptController.Instance.ShowPromptByCode("IsBlockedPlayer", Array.Empty<object>());
				EventSystem.Instance.Emit(EEventName.UpdateBlackListShow);
				return;
			}
			if (blockPlayerResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrBlockListCountMax)
			{
				GenericPromptController.Instance.ShowPromptByCode("BlackListFull", Array.Empty<object>());
				EventSystem.Instance.Emit(EEventName.UpdateBlackListShow);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(blockPlayerResponse.ErrorCode, 25057, null, true, true);
		}, 0);
	}

	// Token: 0x0600ACF6 RID: 44278 RVA: 0x0032F7D8 File Offset: 0x0032D9D8
	private UniTask OnBlockPlayerResponse(int playerId, BlockPlayerResponse response)
	{
		FriendController.<OnBlockPlayerResponse>d__40 <OnBlockPlayerResponse>d__;
		<OnBlockPlayerResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBlockPlayerResponse>d__.playerId = playerId;
		<OnBlockPlayerResponse>d__.response = response;
		<OnBlockPlayerResponse>d__.<>1__state = -1;
		<OnBlockPlayerResponse>d__.<>t__builder.Start<FriendController.<OnBlockPlayerResponse>d__40>(ref <OnBlockPlayerResponse>d__);
		return <OnBlockPlayerResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACF7 RID: 44279 RVA: 0x0032F824 File Offset: 0x0032DA24
	public void RequestUnBlockPlayer(int playerId)
	{
		UnblockPlayerRequest unblockPlayerRequest = UnblockPlayerRequest.Create();
		unblockPlayerRequest.Id = playerId;
		Net.Instance.Call(ERequestMessageId.UnblockPlayerRequest, unblockPlayerRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			UnblockPlayerResponse unblockPlayerResponse = (UnblockPlayerResponse)msg;
			if (unblockPlayerResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				GenericPromptController.Instance.ShowPromptByCode("RemoveFromBlackListSucceeded", new object[]
				{
					FriendModel.Instance.GetBlockedPlayerById(playerId).GetBlockedPlayerData.PlayerName
				});
				FriendModel.Instance.DeleteBlockedPlayer(playerId);
				EventSystem.Instance.Emit(EEventName.UpdateBlackListShow);
				return;
			}
			if (unblockPlayerResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrIsNotBlockedPlayer)
			{
				GenericPromptController.Instance.ShowPromptByCode("IsNotBlockedPlayer", Array.Empty<object>());
				EventSystem.Instance.Emit(EEventName.UpdateBlackListShow);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(unblockPlayerResponse.ErrorCode, 26572, null, true, true);
		}, 0);
	}

	// Token: 0x0600ACF8 RID: 44280 RVA: 0x0032F870 File Offset: 0x0032DA70
	public void RequestSearchPlayerBasicInfoBySdkId(string thirdPartyId)
	{
		if (Info.Instance.IsPs5Platform())
		{
			PlayerPsnInfoGetRequest playerPsnInfoGetRequest = PlayerPsnInfoGetRequest.Create();
			playerPsnInfoGetRequest.PsnOnlineId = thirdPartyId;
			Net.Instance.Call(ERequestMessageId.PlayerPsnInfoGetRequest, playerPsnInfoGetRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PlayerPsnInfoGetResponse playerPsnInfoGetResponse = (PlayerPsnInfoGetResponse)msg;
				if (playerPsnInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					this.OnSearchPlayerBasicInfoResponse(playerPsnInfoGetResponse.Info);
					return;
				}
				if (playerPsnInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.InvalidUserId)
				{
					GenericPromptController.Instance.ShowPromptByCode("InvalidUserId", Array.Empty<object>());
					return;
				}
				if (playerPsnInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrCanNotGetSelfBasicInfo)
				{
					GenericPromptController.Instance.ShowPromptByCode("CanNotSearchSelf", Array.Empty<object>());
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerPsnInfoGetResponse.ErrorCode, 21086, null, true, true);
			}, 0);
			return;
		}
		if (Info.Instance.IsXboxPlatform())
		{
			PlayerXboxInfoGetRequest playerXboxInfoGetRequest = PlayerXboxInfoGetRequest.Create();
			playerXboxInfoGetRequest.XboxOnlineId = thirdPartyId;
			Net.Instance.Call(ERequestMessageId.PlayerXboxInfoGetRequest, playerXboxInfoGetRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PlayerXboxInfoGetResponse playerXboxInfoGetResponse = (PlayerXboxInfoGetResponse)msg;
				if (playerXboxInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					this.OnSearchPlayerBasicInfoResponse(playerXboxInfoGetResponse.Info);
					return;
				}
				if (playerXboxInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.InvalidUserId)
				{
					GenericPromptController.Instance.ShowPromptByCode("InvalidUserId", Array.Empty<object>());
					return;
				}
				if (playerXboxInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrCanNotGetSelfBasicInfo)
				{
					GenericPromptController.Instance.ShowPromptByCode("CanNotSearchSelf", Array.Empty<object>());
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerXboxInfoGetResponse.ErrorCode, 29123, null, true, true);
			}, 0);
		}
	}

	// Token: 0x0600ACF9 RID: 44281 RVA: 0x0032F8EC File Offset: 0x0032DAEC
	public void RequestPlayerCurrentDeactivationState(int playerId, Action<bool> callback)
	{
		PlayerBasicInfoGetRequest playerBasicInfoGetRequest = PlayerBasicInfoGetRequest.Create();
		playerBasicInfoGetRequest.Id = playerId;
		Net.Instance.Call(ERequestMessageId.PlayerBasicInfoGetRequest, playerBasicInfoGetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			if (((PlayerBasicInfoGetResponse)msg).ErrorCode == Aki.Protocol.ErrorCode.ErrPlayerAccountDeactivation)
			{
				callback(true);
				return;
			}
			callback(false);
		}, 0);
	}

	// Token: 0x0600ACFA RID: 44282 RVA: 0x0032F930 File Offset: 0x0032DB30
	public void RequestSearchPlayerBasicInfo(int playerId, bool silenceQuery = false)
	{
		PlayerBasicInfoGetRequest playerBasicInfoGetRequest = PlayerBasicInfoGetRequest.Create();
		playerBasicInfoGetRequest.Id = playerId;
		Net.Instance.Call(ERequestMessageId.PlayerBasicInfoGetRequest, playerBasicInfoGetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerBasicInfoGetResponse playerBasicInfoGetResponse = (PlayerBasicInfoGetResponse)msg;
			if (playerBasicInfoGetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success && !silenceQuery)
			{
				if (playerBasicInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.InvalidUserId)
				{
					GenericPromptController.Instance.ShowPromptByCode("InvalidUserId", Array.Empty<object>());
					return;
				}
				if (playerBasicInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrCanNotGetSelfBasicInfo)
				{
					GenericPromptController.Instance.ShowPromptByCode("CanNotSearchSelf", Array.Empty<object>());
					return;
				}
				if (playerBasicInfoGetResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPlayerAccountDeactivation)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PlayerDeleteSelf", null);
					GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new <>z__ReadOnlySingleElementList<object>(localTextNew), null, null, null, null, null, false, null);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerBasicInfoGetResponse.ErrorCode, 19022, null, true, true);
				return;
			}
			else
			{
				if (playerBasicInfoGetResponse.ErrorCode > Aki.Protocol.ErrorCode.Success & silenceQuery)
				{
					return;
				}
				this.OnSearchPlayerBasicInfoResponse(playerBasicInfoGetResponse.Info);
				return;
			}
		}, 0);
	}

	// Token: 0x0600ACFB RID: 44283 RVA: 0x0032F97C File Offset: 0x0032DB7C
	[NullableContext(2)]
	private UniTask OnSearchPlayerBasicInfoResponse(PlayerDetails info)
	{
		FriendController.<OnSearchPlayerBasicInfoResponse>d__45 <OnSearchPlayerBasicInfoResponse>d__;
		<OnSearchPlayerBasicInfoResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnSearchPlayerBasicInfoResponse>d__.info = info;
		<OnSearchPlayerBasicInfoResponse>d__.<>1__state = -1;
		<OnSearchPlayerBasicInfoResponse>d__.<>t__builder.Start<FriendController.<OnSearchPlayerBasicInfoResponse>d__45>(ref <OnSearchPlayerBasicInfoResponse>d__);
		return <OnSearchPlayerBasicInfoResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACFC RID: 44284 RVA: 0x0032F9C0 File Offset: 0x0032DBC0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, EFriendOfflineSection> GetOfflineSection(long offlineTimeStamp)
	{
		int num = TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)offlineTimeStamp, false);
		EFriendOfflineSection item = EFriendOfflineSection.Today;
		string item2 = "FriendOfflineToday";
		if (num <= 1)
		{
			item = EFriendOfflineSection.Today;
			item2 = "FriendOfflineToday";
		}
		else if (num > 1 && num <= 7)
		{
			item = EFriendOfflineSection.InWeek;
			item2 = "FriendOfflineInWeek";
		}
		else if (num > 1 && num <= 30)
		{
			item = EFriendOfflineSection.InMonth;
			item2 = "FriendOfflineInMonth";
		}
		else if (num > 30)
		{
			item = EFriendOfflineSection.OverMonth;
			item2 = "FriendOfflineOverMonth";
		}
		return new ValueTuple<string, EFriendOfflineSection>(item2, item);
	}

	// Token: 0x0600ACFD RID: 44285 RVA: 0x0032FA2A File Offset: 0x0032DC2A
	public bool CheckRemarkIsValid(string remark)
	{
		return !string.IsNullOrEmpty(remark);
	}

	// Token: 0x0600ACFE RID: 44286 RVA: 0x0032FA38 File Offset: 0x0032DC38
	public List<FriendItemSt> CreateFriendItemSt(IReadOnlyList<int> ids, EFriendItemOperation operationType)
	{
		List<FriendItemSt> list = new List<FriendItemSt>();
		foreach (int id in ids)
		{
			list.Add(new FriendItemSt
			{
				Id = id,
				OperationType = operationType
			});
		}
		return list;
	}

	// Token: 0x0600ACFF RID: 44287 RVA: 0x0032FA9C File Offset: 0x0032DC9C
	public bool CheckHasAnyApplied(int[] playerIdList)
	{
		FriendModel instance = FriendModel.Instance;
		foreach (int id in playerIdList)
		{
			if (instance.HasFriendApplication(id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AD00 RID: 44288 RVA: 0x0032FAD0 File Offset: 0x0032DCD0
	public List<int> GetSortedFriendListByRules(List<int> originalList, Func<int, int, int> callback)
	{
		List<int> list = new List<int>();
		for (int i = originalList.Count - 1; i >= 0; i--)
		{
			list.Add(originalList[i]);
		}
		list.Sort((int a, int b) => callback(a, b));
		return list;
	}

	// Token: 0x0600AD01 RID: 44289 RVA: 0x0032FB24 File Offset: 0x0032DD24
	public List<int> GetSortedBlackOrApplyList(List<int> originalList)
	{
		List<int> list = new List<int>();
		for (int i = originalList.Count - 1; i >= 0; i--)
		{
			list.Add(originalList[i]);
		}
		return list;
	}

	// Token: 0x0600AD02 RID: 44290 RVA: 0x0032FB58 File Offset: 0x0032DD58
	public int FriendListSortHook(int a, int b)
	{
		FriendData friendById = FriendModel.Instance.GetFriendById(a);
		FriendData friendById2 = FriendModel.Instance.GetFriendById(b);
		return this.FriendSortCondition(friendById, friendById2);
	}

	// Token: 0x0600AD03 RID: 44291 RVA: 0x0032FB88 File Offset: 0x0032DD88
	private int FriendSortCondition(FriendData aData, FriendData bData)
	{
		if (aData == null || bData == null)
		{
			return 1;
		}
		if (aData.PlayerIsOnline != bData.PlayerIsOnline)
		{
			if (aData.PlayerIsOnline || !bData.PlayerIsOnline)
			{
				return -1;
			}
			return 1;
		}
		else if (aData.PlayerIsOnline && bData.PlayerIsOnline)
		{
			if (aData.PlayerLevel == bData.PlayerLevel)
			{
				return aData.PlayerId - bData.PlayerId;
			}
			return -(aData.PlayerLevel - bData.PlayerLevel);
		}
		else
		{
			if (this.GetOfflineSection(aData.PlayerLastOfflineTime).Item2 != this.GetOfflineSection(bData.PlayerLastOfflineTime).Item2)
			{
				return -(this.GetOfflineSection(aData.PlayerLastOfflineTime).Item2 - this.GetOfflineSection(bData.PlayerLastOfflineTime).Item2);
			}
			if (aData.PlayerLevel == bData.PlayerLevel)
			{
				return aData.PlayerId - bData.PlayerId;
			}
			return -(aData.PlayerLevel - bData.PlayerLevel);
		}
	}

	// Token: 0x0600AD04 RID: 44292 RVA: 0x0032FC70 File Offset: 0x0032DE70
	private void CallBackLoadTestFriendsByGm(int count)
	{
		FriendModel.Instance.ClearTestFriendData();
		for (int i = 0; i < count; i++)
		{
			FriendData friendData = new FriendData();
			friendData.PlayerId = i + 1;
			FriendData friendData2 = friendData;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("测试员");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
			friendData2.PlayerName = defaultInterpolatedStringHandler.ToStringAndClear();
			FriendData friendData3 = friendData;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("仅供展示使用");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
			friendData3.FriendRemark = defaultInterpolatedStringHandler.ToStringAndClear();
			friendData.PlayerLevel = 1;
			friendData.PlayerIsOnline = true;
			friendData.PlayerLastOfflineTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			friendData.Debug = true;
			FriendApplyData friendApplyData = new FriendApplyData();
			FriendBlackListData friendBlackListData = new FriendBlackListData();
			friendApplyData.ApplyPlayerData = friendData;
			friendApplyData.ApplyCreatedTime = friendData.PlayerLastOfflineTime + (long)i;
			friendApplyData.Fresh = false;
			friendBlackListData.GetBlockedPlayerData = friendData;
			FriendModel.Instance.AddFriend(friendData);
			FriendModel.Instance.AddFriendApplication(friendApplyData);
			FriendModel.Instance.AddToBlackList(friendBlackListData);
			FriendModel.Instance.AddFriendSearchResults(friendData);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
		EventSystem.Instance.Emit(EEventName.UpdateBlackListShow);
		EventSystem.Instance.Emit<int>(EEventName.SearchPlayerInfo, count);
		FriendModel.Instance.TestDataLoaded = true;
	}

	// Token: 0x0600AD05 RID: 44293 RVA: 0x0032FDC4 File Offset: 0x0032DFC4
	public void RequestFriendRecentlyTeam()
	{
		FriendRecentlyTeamRequest message = FriendRecentlyTeamRequest.Create();
		Net.Instance.Call(ERequestMessageId.FriendRecentlyTeamRequest, message, new Action<IMessage, Net.CallbackStatus>(FriendController.<RequestFriendRecentlyTeam>g__response|55_0), 0);
	}

	// Token: 0x0600AD06 RID: 44294 RVA: 0x0032FDF4 File Offset: 0x0032DFF4
	public string GetOfflineTimeString(int day)
	{
		if (day <= 1)
		{
			return "FriendOfflineToday";
		}
		if (day > 1 && day <= 30)
		{
			return "FriendOfflineSomeDay";
		}
		if (day > 30)
		{
			return "FriendOfflineOverMonth";
		}
		return "FriendOfflineToday";
	}

	// Token: 0x0600AD07 RID: 44295 RVA: 0x0032FE20 File Offset: 0x0032E020
	private void TsOnRequestFriendInfoResponse(FArrayBuffer buffer)
	{
		FriendAllResponse friendAllResponse = new FriendAllResponse();
		friendAllResponse.MergeFrom(buffer.ToByteArray());
		if (friendAllResponse == null)
		{
			return;
		}
		this.OnRequestAllFriendResponse(friendAllResponse);
	}

	// Token: 0x0600AD08 RID: 44296 RVA: 0x0032FE4C File Offset: 0x0032E04C
	private void OnTsSyncChangePlayerRemark(int uid, string remark)
	{
		if (FriendModel.Instance.IsMyFriend(uid))
		{
			FriendModel.Instance.GetFriendById(uid).FriendRemark = remark;
			EventSystem.Instance.Emit<int, string>(EEventName.CsRequestChangeFriendRemark, uid, remark);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
	}

	// Token: 0x0600AD09 RID: 44297 RVA: 0x0032FE9C File Offset: 0x0032E09C
	private void OnTsSyncResponseSearchBasicData(FArrayBuffer buffer)
	{
		PlayerBasicInfoGetResponse playerBasicInfoGetResponse = new PlayerBasicInfoGetResponse();
		playerBasicInfoGetResponse.MergeFrom(buffer.ToByteArray());
		if (playerBasicInfoGetResponse == null)
		{
			return;
		}
		this.OnSearchPlayerBasicInfoResponse(playerBasicInfoGetResponse.Info);
	}

	// Token: 0x0600AD0A RID: 44298 RVA: 0x0032FECC File Offset: 0x0032E0CC
	private void OnTsSyncResponseSearchSdkData(FArrayBuffer buffer)
	{
		PlayerPsnInfoGetResponse playerPsnInfoGetResponse = new PlayerPsnInfoGetResponse();
		playerPsnInfoGetResponse.MergeFrom(buffer.ToByteArray());
		if (playerPsnInfoGetResponse == null)
		{
			return;
		}
		this.OnSearchPlayerBasicInfoResponse(playerPsnInfoGetResponse.Info);
	}

	// Token: 0x0600AD0B RID: 44299 RVA: 0x0032FEFC File Offset: 0x0032E0FC
	private void OnTsResponseBlockData(FArrayBuffer buffer)
	{
		BlockListResponse blockListResponse = new BlockListResponse();
		blockListResponse.MergeFrom(buffer.ToByteArray());
		if (blockListResponse == null)
		{
			return;
		}
		this.OnBlackListResponse(blockListResponse);
	}

	// Token: 0x0600AD0C RID: 44300 RVA: 0x0032FF28 File Offset: 0x0032E128
	private void TsResponseFriendRecentlyTeam(FArrayBuffer buffer)
	{
		FriendRecentlyTeamResponse friendRecentlyTeamResponse = new FriendRecentlyTeamResponse();
		friendRecentlyTeamResponse.MergeFrom(buffer.ToByteArray());
		if (friendRecentlyTeamResponse == null)
		{
			return;
		}
		if (friendRecentlyTeamResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			RecentlyTeamInfo[] array = new RecentlyTeamInfo[friendRecentlyTeamResponse.Infos.Count];
			friendRecentlyTeamResponse.Infos.CopyTo(array, 0);
			FriendModel.Instance.InitRecentlyTeamDataByResponse(array);
		}
	}

	// Token: 0x170011DF RID: 4575
	// (get) Token: 0x0600AD0D RID: 44301 RVA: 0x0032FF7D File Offset: 0x0032E17D
	public static FriendController Instance
	{
		get
		{
			return FriendController._Instance;
		}
	}

	// Token: 0x0600AD0E RID: 44302 RVA: 0x0032FF84 File Offset: 0x0032E184
	public static FriendController GetOrCreateInstance()
	{
		if (FriendController._Instance == null)
		{
			FriendController.CreateInstance();
		}
		return FriendController._Instance;
	}

	// Token: 0x0600AD0F RID: 44303 RVA: 0x0032FF98 File Offset: 0x0032E198
	public static bool CreateInstance()
	{
		if (FriendController._Instance != null)
		{
			return true;
		}
		FriendController._Instance = new FriendController();
		return true;
	}

	// Token: 0x0600AD10 RID: 44304 RVA: 0x0032FFAE File Offset: 0x0032E1AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AD11 RID: 44305 RVA: 0x0032FFB0 File Offset: 0x0032E1B0
	public static void ResetStaticDefaultValue()
	{
		FriendController._Instance = null;
	}

	// Token: 0x0600AD12 RID: 44306 RVA: 0x0032FFB8 File Offset: 0x0032E1B8
	static FriendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendController.CreateStaticDefaultValue), new Action(FriendController.ResetStaticDefaultValue));
	}

	// Token: 0x0600AD14 RID: 44308 RVA: 0x0032FFDF File Offset: 0x0032E1DF
	[CompilerGenerated]
	internal static void <OnWorldDone>g__callback|15_0()
	{
		EventSystem.Instance.Emit(EEventName.OnGetFriendInitData);
	}

	// Token: 0x0600AD15 RID: 44309 RVA: 0x0032FFF1 File Offset: 0x0032E1F1
	[CompilerGenerated]
	internal static void <OnDataDone>g__callback|16_0()
	{
		EventSystem.Instance.Emit(EEventName.OnGetFriendInitData);
	}

	// Token: 0x0600AD19 RID: 44313 RVA: 0x0033014C File Offset: 0x0032E34C
	[NullableContext(2)]
	[CompilerGenerated]
	internal static void <RequestFriendRecentlyTeam>g__response|55_0(IMessage msg, Net.CallbackStatus _)
	{
		FriendRecentlyTeamResponse friendRecentlyTeamResponse = (FriendRecentlyTeamResponse)msg;
		if (friendRecentlyTeamResponse == null)
		{
			return;
		}
		if (friendRecentlyTeamResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			RecentlyTeamInfo[] array = new RecentlyTeamInfo[friendRecentlyTeamResponse.Infos.Count];
			friendRecentlyTeamResponse.Infos.CopyTo(array, 0);
			FriendModel.Instance.InitRecentlyTeamDataByResponse(array);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(friendRecentlyTeamResponse.ErrorCode, 26286, null, true, true);
	}

	// Token: 0x040063B0 RID: 25520
	private const int CHECKGAP = 30000;

	// Token: 0x040063B1 RID: 25521
	private const int APPLYFRIENDCD = 1000;

	// Token: 0x040063B2 RID: 25522
	private const int SERVERREQUESTCD = 2500;

	// Token: 0x040063B3 RID: 25523
	[Nullable(2)]
	private TimerHandle CheckFriendTimer;

	// Token: 0x040063B4 RID: 25524
	private bool FirstCheckFriendState;

	// Token: 0x040063B5 RID: 25525
	private bool PastWorldMutiState;

	// Token: 0x040063B6 RID: 25526
	private double LastApplyAddFriendRequestTime;

	// Token: 0x040063B7 RID: 25527
	private double TargetRequestTimeStamp;

	// Token: 0x040063B8 RID: 25528
	private double LastSendTime;

	// Token: 0x040063B9 RID: 25529
	[Nullable(2)]
	private static FriendController _Instance;
}
