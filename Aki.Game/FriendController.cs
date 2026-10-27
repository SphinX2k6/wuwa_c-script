using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001C2F RID: 7215
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FriendController : ControllerBase
{
	// Token: 0x0600D8C1 RID: 55489 RVA: 0x0032395E File Offset: 0x00321B5E
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600D8C2 RID: 55490 RVA: 0x0032396D File Offset: 0x00321B6D
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		this.CancelTimer();
		this.FirstCheckFriendState = false;
		this.PastWorldMutiState = false;
		return true;
	}

	// Token: 0x0600D8C3 RID: 55491 RVA: 0x00323990 File Offset: 0x00321B90
	private void InitTimer()
	{
		this.CancelTimer();
		this.CheckFriendTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRequestFriendDataTimer), 30000f, 1f, null, null, true);
	}

	// Token: 0x0600D8C4 RID: 55492 RVA: 0x003239C1 File Offset: 0x00321BC1
	private void OnRequestFriendDataTimer(float delta)
	{
		this.RequestAllFriend(false, null);
	}

	// Token: 0x0600D8C5 RID: 55493 RVA: 0x003239CB File Offset: 0x00321BCB
	private void CancelTimer()
	{
		if (this.CheckFriendTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CheckFriendTimer);
			this.CheckFriendTimer = null;
		}
	}

	// Token: 0x0600D8C6 RID: 55494 RVA: 0x003239F0 File Offset: 0x00321BF0
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

	// Token: 0x0600D8C7 RID: 55495 RVA: 0x00323B50 File Offset: 0x00321D50
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

	// Token: 0x0600D8C8 RID: 55496 RVA: 0x00323CAD File Offset: 0x00321EAD
	private void OnRefreshOnlineTeamList()
	{
		this.RequestAllFriend(true, null);
	}

	// Token: 0x0600D8C9 RID: 55497 RVA: 0x00323CB8 File Offset: 0x00321EB8
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

	// Token: 0x0600D8CA RID: 55498 RVA: 0x00323D0A File Offset: 0x00321F0A
	private void OnDataDone()
	{
		this.RequestAllFriend(true, new Action(FriendController.<OnDataDone>g__callback|16_0));
		this.InitTimer();
	}

	// Token: 0x0600D8CB RID: 55499 RVA: 0x00323D25 File Offset: 0x00321F25
	private void ValidateRedDot()
	{
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
	}

	// Token: 0x0600D8CC RID: 55500 RVA: 0x00323D38 File Offset: 0x00321F38
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.FriendAddedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendAddedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendDeletedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendDeletedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendApplyReceivedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendApplyReceivedNotify));
		Net.Instance.Register(ENotifyMessageId.FriendApplyDeletedNotify, new Action<IMessage, Net.CallbackStatus>(this.FriendApplyDeletedNotify));
	}

	// Token: 0x0600D8CD RID: 55501 RVA: 0x00323DB8 File Offset: 0x00321FB8
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.FriendAddedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendDeletedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendApplyReceivedNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FriendApplyDeletedNotify);
	}

	// Token: 0x0600D8CE RID: 55502 RVA: 0x00323E08 File Offset: 0x00322008
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

	// Token: 0x0600D8CF RID: 55503 RVA: 0x00323EFC File Offset: 0x003220FC
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

	// Token: 0x0600D8D0 RID: 55504 RVA: 0x00323F40 File Offset: 0x00322140
	[NullableContext(2)]
	private void FriendAddedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendAddedNotify message = (FriendAddedNotify)msg;
		this.OnFriendAddedNotify(message);
	}

	// Token: 0x0600D8D1 RID: 55505 RVA: 0x00323F5C File Offset: 0x0032215C
	private UniTask OnFriendAddedNotify(FriendAddedNotify message)
	{
		FriendController.<OnFriendAddedNotify>d__25 <OnFriendAddedNotify>d__;
		<OnFriendAddedNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnFriendAddedNotify>d__.message = message;
		<OnFriendAddedNotify>d__.<>1__state = -1;
		<OnFriendAddedNotify>d__.<>t__builder.Start<FriendController.<OnFriendAddedNotify>d__25>(ref <OnFriendAddedNotify>d__);
		return <OnFriendAddedNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8D2 RID: 55506 RVA: 0x00323FA0 File Offset: 0x003221A0
	[NullableContext(2)]
	private void FriendDeletedNotify(IMessage msg, Net.CallbackStatus status)
	{
		int id = ((FriendDeletedNotify)msg).Id;
		ChatController.Instance.TryActiveDeleteFriendTips(id);
		FriendModel.Instance.DeleteFriend(id);
	}

	// Token: 0x0600D8D3 RID: 55507 RVA: 0x00323FD0 File Offset: 0x003221D0
	[NullableContext(2)]
	private void FriendApplyReceivedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendApplyReceivedNotify message = (FriendApplyReceivedNotify)msg;
		this.OnFriendApplyReceivedNotify(message);
	}

	// Token: 0x0600D8D4 RID: 55508 RVA: 0x00323FEC File Offset: 0x003221EC
	private UniTask OnFriendApplyReceivedNotify(FriendApplyReceivedNotify message)
	{
		FriendController.<OnFriendApplyReceivedNotify>d__28 <OnFriendApplyReceivedNotify>d__;
		<OnFriendApplyReceivedNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnFriendApplyReceivedNotify>d__.message = message;
		<OnFriendApplyReceivedNotify>d__.<>1__state = -1;
		<OnFriendApplyReceivedNotify>d__.<>t__builder.Start<FriendController.<OnFriendApplyReceivedNotify>d__28>(ref <OnFriendApplyReceivedNotify>d__);
		return <OnFriendApplyReceivedNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8D5 RID: 55509 RVA: 0x00324030 File Offset: 0x00322230
	[NullableContext(2)]
	private void FriendApplyDeletedNotify(IMessage msg, Net.CallbackStatus status)
	{
		FriendApplyDeletedNotify friendApplyDeletedNotify = (FriendApplyDeletedNotify)msg;
		FriendModel.Instance.DeleteFriendApplication(friendApplyDeletedNotify.Id);
	}

	// Token: 0x0600D8D6 RID: 55510 RVA: 0x00324054 File Offset: 0x00322254
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(friendApplySendResponse.ErrorCode, 19754, null, true, true);
			}
			FriendModel.Instance.AddPlayerToApplyFriendList(message.Id);
			GenericPromptController.Instance.ShowPromptByCode("FriendApplicationSent", Array.Empty<object>());
			EventSystem.Instance.Emit<int>(EEventName.ApplicationSent, message.Id);
		}, 0);
	}

	// Token: 0x0600D8D7 RID: 55511 RVA: 0x003240EC File Offset: 0x003222EC
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

	// Token: 0x0600D8D8 RID: 55512 RVA: 0x00324196 File Offset: 0x00322396
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

	// Token: 0x0600D8D9 RID: 55513 RVA: 0x003241D0 File Offset: 0x003223D0
	public void LocalRemoveApplicationFriend(int friend)
	{
		FriendModel.Instance.DeleteFriendApplication(friend);
		EventSystem.Instance.Emit(EEventName.FriendApplicationListUpdate);
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
	}

	// Token: 0x0600D8DA RID: 55514 RVA: 0x00324200 File Offset: 0x00322400
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

	// Token: 0x0600D8DB RID: 55515 RVA: 0x0032424C File Offset: 0x0032244C
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

	// Token: 0x0600D8DC RID: 55516 RVA: 0x0032429C File Offset: 0x0032249C
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
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 29748, null, true, true);
	}

	// Token: 0x0600D8DD RID: 55517 RVA: 0x0032433C File Offset: 0x0032253C
	public void RequestBlackList()
	{
		BlockListRequest message = BlockListRequest.Create();
		Net.Instance.Call(ERequestMessageId.BlockListRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BlockListResponse blockListResponse = (BlockListResponse)msg;
			if (blockListResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(blockListResponse.ErrorCode, 16716, null, true, true);
				return;
			}
			this.OnBlackListResponse(blockListResponse);
		}, 0);
	}

	// Token: 0x0600D8DE RID: 55518 RVA: 0x0032436C File Offset: 0x0032256C
	private UniTask OnBlackListResponse(BlockListResponse message)
	{
		FriendController.<OnBlackListResponse>d__38 <OnBlackListResponse>d__;
		<OnBlackListResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBlackListResponse>d__.message = message;
		<OnBlackListResponse>d__.<>1__state = -1;
		<OnBlackListResponse>d__.<>t__builder.Start<FriendController.<OnBlackListResponse>d__38>(ref <OnBlackListResponse>d__);
		return <OnBlackListResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8DF RID: 55519 RVA: 0x003243B0 File Offset: 0x003225B0
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(blockPlayerResponse.ErrorCode, 21431, null, true, true);
		}, 0);
	}

	// Token: 0x0600D8E0 RID: 55520 RVA: 0x00324400 File Offset: 0x00322600
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

	// Token: 0x0600D8E1 RID: 55521 RVA: 0x0032444C File Offset: 0x0032264C
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(unblockPlayerResponse.ErrorCode, 27927, null, true, true);
		}, 0);
	}

	// Token: 0x0600D8E2 RID: 55522 RVA: 0x00324498 File Offset: 0x00322698
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerPsnInfoGetResponse.ErrorCode, 15989, null, true, true);
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerXboxInfoGetResponse.ErrorCode, 27026, null, true, true);
			}, 0);
		}
	}

	// Token: 0x0600D8E3 RID: 55523 RVA: 0x00324514 File Offset: 0x00322714
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

	// Token: 0x0600D8E4 RID: 55524 RVA: 0x00324558 File Offset: 0x00322758
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerBasicInfoGetResponse.ErrorCode, 22549, null, true, true);
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

	// Token: 0x0600D8E5 RID: 55525 RVA: 0x003245A4 File Offset: 0x003227A4
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

	// Token: 0x0600D8E6 RID: 55526 RVA: 0x003245E8 File Offset: 0x003227E8
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

	// Token: 0x0600D8E7 RID: 55527 RVA: 0x00324652 File Offset: 0x00322852
	public bool CheckRemarkIsValid(string remark)
	{
		return !string.IsNullOrEmpty(remark);
	}

	// Token: 0x0600D8E8 RID: 55528 RVA: 0x00324660 File Offset: 0x00322860
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

	// Token: 0x0600D8E9 RID: 55529 RVA: 0x003246C4 File Offset: 0x003228C4
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

	// Token: 0x0600D8EA RID: 55530 RVA: 0x003246F8 File Offset: 0x003228F8
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

	// Token: 0x0600D8EB RID: 55531 RVA: 0x0032474C File Offset: 0x0032294C
	public List<int> GetSortedBlackOrApplyList(List<int> originalList)
	{
		List<int> list = new List<int>();
		for (int i = originalList.Count - 1; i >= 0; i--)
		{
			list.Add(originalList[i]);
		}
		return list;
	}

	// Token: 0x0600D8EC RID: 55532 RVA: 0x00324780 File Offset: 0x00322980
	public int FriendListSortHook(int a, int b)
	{
		FriendData friendById = FriendModel.Instance.GetFriendById(a);
		FriendData friendById2 = FriendModel.Instance.GetFriendById(b);
		return this.FriendSortCondition(friendById, friendById2);
	}

	// Token: 0x0600D8ED RID: 55533 RVA: 0x003247B0 File Offset: 0x003229B0
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

	// Token: 0x0600D8EE RID: 55534 RVA: 0x00324898 File Offset: 0x00322A98
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

	// Token: 0x0600D8EF RID: 55535 RVA: 0x003249EC File Offset: 0x00322BEC
	public void RequestFriendRecentlyTeam()
	{
		FriendRecentlyTeamRequest message = FriendRecentlyTeamRequest.Create();
		Net.Instance.Call(ERequestMessageId.FriendRecentlyTeamRequest, message, new Action<IMessage, Net.CallbackStatus>(FriendController.<RequestFriendRecentlyTeam>g__response|55_0), 0);
	}

	// Token: 0x0600D8F0 RID: 55536 RVA: 0x00324A1C File Offset: 0x00322C1C
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

	// Token: 0x0600D8F1 RID: 55537 RVA: 0x00324A48 File Offset: 0x00322C48
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

	// Token: 0x0600D8F2 RID: 55538 RVA: 0x00324A74 File Offset: 0x00322C74
	private void OnTsSyncChangePlayerRemark(int uid, string remark)
	{
		if (FriendModel.Instance.IsMyFriend(uid))
		{
			FriendModel.Instance.GetFriendById(uid).FriendRemark = remark;
			EventSystem.Instance.Emit<int, string>(EEventName.CsRequestChangeFriendRemark, uid, remark);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
	}

	// Token: 0x0600D8F3 RID: 55539 RVA: 0x00324AC4 File Offset: 0x00322CC4
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

	// Token: 0x0600D8F4 RID: 55540 RVA: 0x00324AF4 File Offset: 0x00322CF4
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

	// Token: 0x0600D8F5 RID: 55541 RVA: 0x00324B24 File Offset: 0x00322D24
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

	// Token: 0x0600D8F6 RID: 55542 RVA: 0x00324B50 File Offset: 0x00322D50
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
			FriendModel.Instance.InitRecentlyTeamDataByResponse(friendRecentlyTeamResponse.Infos.ToArray<RecentlyTeamInfo>());
		}
	}

	// Token: 0x170011B9 RID: 4537
	// (get) Token: 0x0600D8F7 RID: 55543 RVA: 0x00324B91 File Offset: 0x00322D91
	public static FriendController Instance
	{
		get
		{
			return FriendController._Instance;
		}
	}

	// Token: 0x0600D8F8 RID: 55544 RVA: 0x00324B98 File Offset: 0x00322D98
	public static FriendController GetOrCreateInstance()
	{
		if (FriendController._Instance == null)
		{
			FriendController.CreateInstance();
		}
		return FriendController._Instance;
	}

	// Token: 0x0600D8F9 RID: 55545 RVA: 0x00324BAC File Offset: 0x00322DAC
	public static bool CreateInstance()
	{
		if (FriendController._Instance != null)
		{
			return true;
		}
		FriendController._Instance = new FriendController();
		return true;
	}

	// Token: 0x0600D8FA RID: 55546 RVA: 0x00324BC2 File Offset: 0x00322DC2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D8FB RID: 55547 RVA: 0x00324BC4 File Offset: 0x00322DC4
	public static void ResetStaticDefaultValue()
	{
		FriendController._Instance = null;
	}

	// Token: 0x0600D8FC RID: 55548 RVA: 0x00324BCC File Offset: 0x00322DCC
	static FriendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendController.CreateStaticDefaultValue), new Action(FriendController.ResetStaticDefaultValue));
	}

	// Token: 0x0600D8FE RID: 55550 RVA: 0x00324BF3 File Offset: 0x00322DF3
	[CompilerGenerated]
	internal static void <OnWorldDone>g__callback|15_0()
	{
		EventSystem.Instance.Emit(EEventName.OnGetFriendInitData);
	}

	// Token: 0x0600D8FF RID: 55551 RVA: 0x00324C05 File Offset: 0x00322E05
	[CompilerGenerated]
	internal static void <OnDataDone>g__callback|16_0()
	{
		EventSystem.Instance.Emit(EEventName.OnGetFriendInitData);
	}

	// Token: 0x0600D903 RID: 55555 RVA: 0x00324D60 File Offset: 0x00322F60
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
			FriendModel.Instance.InitRecentlyTeamDataByResponse(friendRecentlyTeamResponse.Infos.ToArray<RecentlyTeamInfo>());
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(friendRecentlyTeamResponse.ErrorCode, 29522, null, true, true);
	}

	// Token: 0x040062DE RID: 25310
	private const int CHECKGAP = 30000;

	// Token: 0x040062DF RID: 25311
	private const int APPLYFRIENDCD = 1000;

	// Token: 0x040062E0 RID: 25312
	private const int SERVERREQUESTCD = 2500;

	// Token: 0x040062E1 RID: 25313
	[Nullable(2)]
	private TimerHandle CheckFriendTimer;

	// Token: 0x040062E2 RID: 25314
	private bool FirstCheckFriendState;

	// Token: 0x040062E3 RID: 25315
	private bool PastWorldMutiState;

	// Token: 0x040062E4 RID: 25316
	private double LastApplyAddFriendRequestTime;

	// Token: 0x040062E5 RID: 25317
	private double TargetRequestTimeStamp;

	// Token: 0x040062E6 RID: 25318
	private double LastSendTime;

	// Token: 0x040062E7 RID: 25319
	[Nullable(2)]
	private static FriendController _Instance;
}
