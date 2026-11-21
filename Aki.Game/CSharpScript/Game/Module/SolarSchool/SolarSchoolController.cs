using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200594C RID: 22860
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SolarSchoolController : ActivityControllerBase
	{
		// Token: 0x0603859F RID: 230815 RVA: 0x00FC1350 File Offset: 0x00FBF550
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060385A0 RID: 230816 RVA: 0x00FC1352 File Offset: 0x00FBF552
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_SolarSchoolActivityMain";
		}

		// Token: 0x060385A1 RID: 230817 RVA: 0x00FC1359 File Offset: 0x00FBF559
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new SolarSchoolActivityView();
		}

		// Token: 0x060385A2 RID: 230818 RVA: 0x00FC1360 File Offset: 0x00FBF560
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new SolarSchoolActivityData();
		}

		// Token: 0x060385A3 RID: 230819 RVA: 0x00FC1367 File Offset: 0x00FBF567
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060385A4 RID: 230820 RVA: 0x00FC136A File Offset: 0x00FBF56A
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SolarSchoolTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSolarSchoolTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SolarSchoolGalleryUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSolarSchoolGalleryUpdateNotify));
		}

		// Token: 0x060385A5 RID: 230821 RVA: 0x00FC13A4 File Offset: 0x00FBF5A4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SolarSchoolTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SolarSchoolGalleryUpdateNotify);
		}

		// Token: 0x060385A6 RID: 230822 RVA: 0x00FC13C8 File Offset: 0x00FBF5C8
		[NullableContext(2)]
		private void OnSolarSchoolGalleryUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			SolarSchoolGalleryUpdateNotify solarSchoolGalleryUpdateNotify = (SolarSchoolGalleryUpdateNotify)msg;
			SolarSchoolActivityData currentActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			currentActivityData.UpdateGalleryInfo(solarSchoolGalleryUpdateNotify.Gallery);
			currentActivityData.IsUnlockGallery |= solarSchoolGalleryUpdateNotify.GalleryEntryUnlocked;
			EventSystem.Instance.Emit(EEventName.SolarSchoolGalleryUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityData.Id);
		}

		// Token: 0x060385A7 RID: 230823 RVA: 0x00FC142C File Offset: 0x00FBF62C
		[NullableContext(2)]
		private void OnSolarSchoolTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			SolarSchoolTaskUpdateNotify solarSchoolTaskUpdateNotify = (SolarSchoolTaskUpdateNotify)msg;
			SolarSchoolActivityData currentActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			currentActivityData.UpdateTaskInfo(solarSchoolTaskUpdateNotify.Task);
			EventSystem.Instance.Emit(EEventName.SolarSchoolRewardTaskUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityData.Id);
		}

		// Token: 0x060385A8 RID: 230824 RVA: 0x00FC147D File Offset: 0x00FBF67D
		public bool StartGame(int activityId)
		{
			return SolarSchoolGamePlayModel.Instance.InitGame(activityId);
		}

		// Token: 0x060385A9 RID: 230825 RVA: 0x00FC148A File Offset: 0x00FBF68A
		public void RecordReadPlot(int flowId, int plotId)
		{
			this.ReadPlotQueue.Enqueue(new ValueTuple<int, int>(flowId, plotId));
			this.SendNextReadPlot();
		}

		// Token: 0x060385AA RID: 230826 RVA: 0x00FC14A4 File Offset: 0x00FBF6A4
		private void SendNextReadPlot()
		{
			if (this.IsSendingReadPlot || this.ReadPlotQueue.Count == 0)
			{
				return;
			}
			this.IsSendingReadPlot = true;
			ValueTuple<int, int> valueTuple = this.ReadPlotQueue.Peek();
			int flowId = valueTuple.Item1;
			int plotId = valueTuple.Item2;
			SolarSchoolSetFlowRequest solarSchoolSetFlowRequest = SolarSchoolSetFlowRequest.Create();
			solarSchoolSetFlowRequest.SolarSchoolFlowId = flowId;
			solarSchoolSetFlowRequest.ReadPlot.Add(plotId);
			Net.Instance.Call(ERequestMessageId.SolarSchoolSetFlowRequest, solarSchoolSetFlowRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SolarSchoolSetFlowResponse solarSchoolSetFlowResponse = msg as SolarSchoolSetFlowResponse;
				if (solarSchoolSetFlowResponse == null)
				{
					this.FinishReadPlotRequest();
					return;
				}
				if (solarSchoolSetFlowResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(solarSchoolSetFlowResponse.ErrorCode, 27809, null, true, true);
					this.FinishReadPlotRequest();
					return;
				}
				SolarSchoolModel.Instance.RecordReadPlot(flowId, plotId);
				this.FinishReadPlotRequest();
			}, 0);
		}

		// Token: 0x060385AB RID: 230827 RVA: 0x00FC153F File Offset: 0x00FBF73F
		private void FinishReadPlotRequest()
		{
			this.ReadPlotQueue.Dequeue();
			this.IsSendingReadPlot = false;
			this.SendNextReadPlot();
		}

		// Token: 0x060385AC RID: 230828 RVA: 0x00FC155C File Offset: 0x00FBF75C
		public void GetRewardTaskReward(SolarSchoolTaskType taskType, List<int> taskIds)
		{
			SolarSchoolOneKeyRewardRequest solarSchoolOneKeyRewardRequest = SolarSchoolOneKeyRewardRequest.Create();
			solarSchoolOneKeyRewardRequest.TaskType = taskType;
			solarSchoolOneKeyRewardRequest.TaskId.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.SolarSchoolOneKeyRewardRequest, solarSchoolOneKeyRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SolarSchoolOneKeyRewardResponse solarSchoolOneKeyRewardResponse = (SolarSchoolOneKeyRewardResponse)msg;
				if (solarSchoolOneKeyRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(solarSchoolOneKeyRewardResponse.ErrorCode, 26713, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060385AD RID: 230829 RVA: 0x00FC15B4 File Offset: 0x00FBF7B4
		public void GetRewardTaskProgressReward(int activity)
		{
			SolarSchoolTaskProgressRewardRequest solarSchoolTaskProgressRewardRequest = SolarSchoolTaskProgressRewardRequest.Create();
			solarSchoolTaskProgressRewardRequest.ActivityId = activity;
			Net.Instance.Call(ERequestMessageId.SolarSchoolTaskProgressRewardRequest, solarSchoolTaskProgressRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SolarSchoolTaskProgressRewardResponse solarSchoolTaskProgressRewardResponse = (SolarSchoolTaskProgressRewardResponse)msg;
				if (solarSchoolTaskProgressRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(solarSchoolTaskProgressRewardResponse.ErrorCode, 18486, null, true, true);
					return;
				}
				SolarSchoolActivityData currentActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
				if (currentActivityData != null)
				{
					currentActivityData.IsGetLimitTaskProgressReward = solarSchoolTaskProgressRewardResponse.Activity.LimitTaskProgressRewarded;
					EventSystem.Instance.Emit(EEventName.SolarSchoolRewardTaskUpdate);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityData.Id);
				}
			}, 0);
		}

		// Token: 0x060385AE RID: 230830 RVA: 0x00FC1600 File Offset: 0x00FBF800
		public void GetGalleryReward(List<int> ids)
		{
			SolarSchoolOneKeyGalleryRewardRequest solarSchoolOneKeyGalleryRewardRequest = SolarSchoolOneKeyGalleryRewardRequest.Create();
			solarSchoolOneKeyGalleryRewardRequest.Id.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.SolarSchoolOneKeyGalleryRewardRequest, solarSchoolOneKeyGalleryRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SolarSchoolOneKeyGalleryRewardResponse solarSchoolOneKeyGalleryRewardResponse = (SolarSchoolOneKeyGalleryRewardResponse)msg;
				if (solarSchoolOneKeyGalleryRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(solarSchoolOneKeyGalleryRewardResponse.ErrorCode, 19859, null, true, true);
					return;
				}
			}, 0);
		}

		// Token: 0x060385AF RID: 230831 RVA: 0x00FC1650 File Offset: 0x00FBF850
		public void EnqueueAttrChange(ESolarSchoolSecondAttr attr, int oldValue, int newValue)
		{
			int num = newValue - oldValue;
			if (num == 0)
			{
				return;
			}
			ValueTuple<AttrChangeSyncDataPb, int> valueTuple;
			if (!this.PendingAttrChangeMap.TryGetValue(attr, out valueTuple))
			{
				AttrChangeSyncDataPb attrChangeSyncDataPb = AttrChangeSyncDataPb.Create();
				attrChangeSyncDataPb.AttrType = (SolarSchoolAttrType)attr;
				SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
				solarSchoolBatchSyncData.AttrChange = attrChangeSyncDataPb;
				this.PendingSyncList.Add(solarSchoolBatchSyncData);
				valueTuple = new ValueTuple<AttrChangeSyncDataPb, int>(attrChangeSyncDataPb, oldValue);
				this.PendingAttrChangeMap.Add(attr, valueTuple);
			}
			if (num > 0)
			{
				valueTuple.Item1.AttrAdd += num;
				return;
			}
			valueTuple.Item1.AttrCost -= num;
		}

		// Token: 0x060385B0 RID: 230832 RVA: 0x00FC16DC File Offset: 0x00FBF8DC
		public void EnqueueUnlockNpc(int roleId)
		{
			UnlockNpcSyncDataPb unlockNpcSyncDataPb = UnlockNpcSyncDataPb.Create();
			unlockNpcSyncDataPb.NpcId.Add(roleId);
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.UnlockNpc = unlockNpcSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B1 RID: 230833 RVA: 0x00FC1714 File Offset: 0x00FBF914
		public void EnqueueNpcFavorChange(int roleId, int favorAbsolute, int favorLevel)
		{
			NpcFavorChangeSyncDataPb npcFavorChangeSyncDataPb = NpcFavorChangeSyncDataPb.Create();
			npcFavorChangeSyncDataPb.NpcId = roleId;
			npcFavorChangeSyncDataPb.FavorAbsolute = favorAbsolute;
			npcFavorChangeSyncDataPb.FavorLevel = favorLevel;
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.NpcFavorChange = npcFavorChangeSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B2 RID: 230834 RVA: 0x00FC1758 File Offset: 0x00FBF958
		public void EnqueueJoinInfluence(int influenceId)
		{
			JoinInfluenceSyncDataPb joinInfluenceSyncDataPb = JoinInfluenceSyncDataPb.Create();
			joinInfluenceSyncDataPb.InfluenceId.Add(influenceId);
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.JoinInfluence = joinInfluenceSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B3 RID: 230835 RVA: 0x00FC1790 File Offset: 0x00FBF990
		public void EnqueueBehave(int behaviorId, bool isSuccess, ESolarSchoolSpecialState specialState)
		{
			BehaveSyncDataPb behaveSyncDataPb = BehaveSyncDataPb.Create();
			behaveSyncDataPb.BehaviorId = behaviorId;
			behaveSyncDataPb.IsSuccess = isSuccess;
			behaveSyncDataPb.SpecialState = (int)specialState;
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.Behave = behaveSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B4 RID: 230836 RVA: 0x00FC17D4 File Offset: 0x00FBF9D4
		public void EnqueueItemChange(int itemId, int delta)
		{
			if (delta == 0)
			{
				return;
			}
			ItemDeltaPb itemDeltaPb;
			if (!this.PendingItemChangeMap.TryGetValue(itemId, out itemDeltaPb))
			{
				itemDeltaPb = ItemDeltaPb.Create();
				itemDeltaPb.ItemId = itemId;
				ItemChangeSyncDataPb itemChangeSyncDataPb = ItemChangeSyncDataPb.Create();
				itemChangeSyncDataPb.Item = itemDeltaPb;
				SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
				solarSchoolBatchSyncData.ItemChange = itemChangeSyncDataPb;
				this.PendingSyncList.Add(solarSchoolBatchSyncData);
				this.PendingItemChangeMap.Add(itemId, itemDeltaPb);
			}
			if (delta > 0)
			{
				itemDeltaPb.ItemAdd += delta;
				return;
			}
			itemDeltaPb.ItemCost -= delta;
		}

		// Token: 0x060385B5 RID: 230837 RVA: 0x00FC1858 File Offset: 0x00FBFA58
		public void EnqueueExamFinish(int examId, int score)
		{
			ExamFinishSyncDataPb examFinishSyncDataPb = ExamFinishSyncDataPb.Create();
			examFinishSyncDataPb.ExamId = examId;
			examFinishSyncDataPb.Score = score;
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.ExamFinish = examFinishSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B6 RID: 230838 RVA: 0x00FC1894 File Offset: 0x00FBFA94
		public void EnqueueShopBuy(int shopId, int goodsId, int count)
		{
			ShopBuySyncDataPb shopBuySyncDataPb = ShopBuySyncDataPb.Create();
			shopBuySyncDataPb.ShopId = shopId;
			shopBuySyncDataPb.GoodsId = goodsId;
			shopBuySyncDataPb.Count = count;
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.ShopBuy = shopBuySyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B7 RID: 230839 RVA: 0x00FC18D8 File Offset: 0x00FBFAD8
		public void EnqueueCompleteQuest(int questId)
		{
			CompleteQuestSyncDataPb completeQuestSyncDataPb = CompleteQuestSyncDataPb.Create();
			completeQuestSyncDataPb.QuestId.Add(questId);
			SolarSchoolBatchSyncData solarSchoolBatchSyncData = SolarSchoolBatchSyncData.Create();
			solarSchoolBatchSyncData.CompleteQuest = completeQuestSyncDataPb;
			this.PendingSyncList.Add(solarSchoolBatchSyncData);
		}

		// Token: 0x060385B8 RID: 230840 RVA: 0x00FC1910 File Offset: 0x00FBFB10
		public void ResetBatchSync()
		{
			this.ClearPendingSync();
			this.CurrentBatchSyncSession = new SolarSchoolController.BatchSyncSession();
		}

		// Token: 0x060385B9 RID: 230841 RVA: 0x00FC1923 File Offset: 0x00FBFB23
		private void ClearPendingSync()
		{
			this.PendingSyncList.Clear();
			this.PendingAttrChangeMap.Clear();
			this.PendingItemChangeMap.Clear();
		}

		// Token: 0x060385BA RID: 230842 RVA: 0x00FC1946 File Offset: 0x00FBFB46
		public void DiscardBatchSync()
		{
			this.CurrentBatchSyncSession.IsDiscarded = true;
			this.ResetBatchSync();
		}

		// Token: 0x060385BB RID: 230843 RVA: 0x00FC195C File Offset: 0x00FBFB5C
		public unsafe void DiscardPendingSyncBeforeNewCycle()
		{
			if (this.PendingSyncList.Count == 0)
			{
				return;
			}
			List<SolarSchoolBatchSyncData.DataOneofCase> list = new List<SolarSchoolBatchSyncData.DataOneofCase>(this.PendingSyncList.Count);
			foreach (SolarSchoolBatchSyncData solarSchoolBatchSyncData in this.PendingSyncList)
			{
				list.Add(solarSchoolBatchSyncData.DataCase);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 新周目存档前存在未发送的批量同步，已丢弃";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("count", this.PendingSyncList.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dataCases", string.Join<SolarSchoolBatchSyncData.DataOneofCase>(",", list));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ClearPendingSync();
		}

		// Token: 0x060385BC RID: 230844 RVA: 0x00FC1A48 File Offset: 0x00FBFC48
		public void FlushBatchSync()
		{
			this.QueueBatchSyncAsync(false).Forget<bool>();
		}

		// Token: 0x060385BD RID: 230845 RVA: 0x00FC1A56 File Offset: 0x00FBFC56
		public void FlushDayEndBatchSync()
		{
			this.QueueBatchSyncAsync(true).Forget<bool>();
		}

		// Token: 0x060385BE RID: 230846 RVA: 0x00FC1A64 File Offset: 0x00FBFC64
		[NullableContext(0)]
		private UniTask<bool> QueueBatchSyncAsync(bool sendWhenEmpty = false)
		{
			SolarSchoolController.BatchSyncSession session = this.CurrentBatchSyncSession;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int activityId = instance.ActivityId;
			SolarSchoolBatchSyncRequest request = null;
			if ((this.PendingSyncList.Count > 0 || sendWhenEmpty) && activityId != 0)
			{
				request = SolarSchoolBatchSyncRequest.Create();
				request.ActivityId = activityId;
				request.TraceId = instance.TraceId;
				request.GameDayNow = instance.TimeData.DayIndex;
				request.SyncData.AddRange(this.PendingSyncList);
				this.LogPendingSyncPredictErrors(request.GameDayNow);
				this.PredictedLastSyncedGameDay = request.GameDayNow;
			}
			if (this.PendingSyncList.Count > 0 && activityId == 0)
			{
				session.HasFailed = true;
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 批量同步丢弃：ActivityId 已清空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", this.PendingSyncList.Count);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.ClearPendingSync();
			UniTaskCompletionSource<bool> completionSource = new UniTaskCompletionSource<bool>();
			this.NetworkRequestQueue.Enqueue(() => this.SendBatchSyncAsync(session, request, completionSource));
			this.SendNetworkRequestsAsync().Forget();
			return completionSource.Task;
		}

		// Token: 0x060385BF RID: 230847 RVA: 0x00FC1BC0 File Offset: 0x00FBFDC0
		private unsafe void LogPendingSyncPredictErrors(int gameDayNow)
		{
			if (this.PendingSyncList.Count > 256)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 批量同步预判失败：条数超过服务器上限";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("count", this.PendingSyncList.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("max", 256);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (this.PendingSyncList.Count > 0 && gameDayNow <= this.PredictedLastSyncedGameDay)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 批量同步预判失败：该 GameDay 已同步过";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("gameDayNow", gameDayNow);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("lastSyncedGameDay", this.PredictedLastSyncedGameDay);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("count", this.PendingSyncList.Count);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			SolarSchoolGamePlayModel instance3 = SolarSchoolGamePlayModel.Instance;
			int num = Math.Max(gameDayNow - this.PredictedLastSyncedGameDay, 0);
			Dictionary<ESolarSchoolSecondAttr, long> pendingItemAttrQuota = this.GetPendingItemAttrQuota();
			foreach (KeyValuePair<ESolarSchoolSecondAttr, ValueTuple<AttrChangeSyncDataPb, int>> keyValuePair in this.PendingAttrChangeMap)
			{
				ESolarSchoolSecondAttr key = keyValuePair.Key;
				ValueTuple<AttrChangeSyncDataPb, int> value = keyValuePair.Value;
				AttrChangeSyncDataPb item = value.Item1;
				int item2 = value.Item2;
				SolarSchoolAttr? attrConfig = instance3.GetAttrConfig(key);
				if (attrConfig == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module3 = ELogModule.SolarSchool;
					ELogAuthor author3 = ELogAuthor.LRC;
					string message3 = "[SolarSchool] 批量同步预判失败：属性配置缺失";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("attr", key);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("activityId", instance3.ActivityId);
					instance4.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				}
				else
				{
					long num2 = (long)item.AttrAdd - (long)item.AttrCost;
					long num3 = (long)item2 + num2;
					if (num3 < (long)attrConfig.Value.MinValue || num3 > (long)attrConfig.Value.MaxValue)
					{
						Log instance5 = Log.Instance;
						ELogModule module4 = ELogModule.SolarSchool;
						ELogAuthor author4 = ELogAuthor.LRC;
						string message4 = "[SolarSchool] 批量同步预判失败：属性最终值越界";
						<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray7<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("attr", key);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("start", item2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("add", item.AttrAdd);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("cost", item.AttrCost);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("final", num3);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 5) = new ValueTuple<string, object>("min", attrConfig.Value.MinValue);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 6) = new ValueTuple<string, object>("max", attrConfig.Value.MaxValue);
						instance5.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 7));
					}
					long valueOrDefault = pendingItemAttrQuota.GetValueOrDefault(key, 0L);
					long num4 = valueOrDefault + (long)attrConfig.Value.DailyMax * (long)num;
					if (key != ESolarSchoolSecondAttr.Fatigue && num2 > num4)
					{
						Log instance6 = Log.Instance;
						ELogModule module5 = ELogModule.SolarSchool;
						ELogAuthor author5 = ELogAuthor.LRC;
						string message5 = "[SolarSchool] 批量同步预判失败：属性净增长超过额度";
						<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray7<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("attr", key);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("add", item.AttrAdd);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("cost", item.AttrCost);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("quota", num4);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("itemQuota", valueOrDefault);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 5) = new ValueTuple<string, object>("dailyMax", attrConfig.Value.DailyMax);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 6) = new ValueTuple<string, object>("dayFactor", num);
						instance6.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 7));
					}
					if (key == ESolarSchoolSecondAttr.Money && (long)item.AttrAdd > num4)
					{
						Log instance7 = Log.Instance;
						ELogModule module6 = ELogModule.SolarSchool;
						ELogAuthor author6 = ELogAuthor.LRC;
						string message6 = "[SolarSchool] 批量同步预判失败：货币总获得超过额度";
						<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray5<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("add", item.AttrAdd);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("quota", num4);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 2) = new ValueTuple<string, object>("itemQuota", valueOrDefault);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 3) = new ValueTuple<string, object>("dailyMax", attrConfig.Value.DailyMax);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 4) = new ValueTuple<string, object>("dayFactor", num);
						instance7.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 5));
					}
				}
			}
		}

		// Token: 0x060385C0 RID: 230848 RVA: 0x00FC2194 File Offset: 0x00FC0394
		private Dictionary<ESolarSchoolSecondAttr, long> GetPendingItemAttrQuota()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			Dictionary<ESolarSchoolSecondAttr, long> dictionary = new Dictionary<ESolarSchoolSecondAttr, long>();
			foreach (ItemDeltaPb itemDeltaPb in this.PendingItemChangeMap.Values)
			{
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemDeltaPb.ItemId);
				if (item != null)
				{
					SolarSchoolItem value = item.Value;
					long num = 0L;
					if (value.ItemType == 2)
					{
						num += (long)itemDeltaPb.ItemAdd;
					}
					if (value.CanUse)
					{
						num += (long)itemDeltaPb.ItemCost;
					}
					if (num != 0L)
					{
						foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetItemAttrDeltas(value))
						{
							ESolarSchoolSecondAttr item2 = valueTuple.Item1;
							int item3 = valueTuple.Item2;
							if (item3 > 0)
							{
								dictionary[item2] = dictionary.GetValueOrDefault(item2, 0L) + (long)item3 * num;
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060385C1 RID: 230849 RVA: 0x00FC22BC File Offset: 0x00FC04BC
		private UniTask SendBatchSyncAsync(SolarSchoolController.BatchSyncSession session, [Nullable(2)] SolarSchoolBatchSyncRequest request, UniTaskCompletionSource<bool> completionSource)
		{
			SolarSchoolController.<SendBatchSyncAsync>d__47 <SendBatchSyncAsync>d__;
			<SendBatchSyncAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendBatchSyncAsync>d__.<>4__this = this;
			<SendBatchSyncAsync>d__.session = session;
			<SendBatchSyncAsync>d__.request = request;
			<SendBatchSyncAsync>d__.completionSource = completionSource;
			<SendBatchSyncAsync>d__.<>1__state = -1;
			<SendBatchSyncAsync>d__.<>t__builder.Start<SolarSchoolController.<SendBatchSyncAsync>d__47>(ref <SendBatchSyncAsync>d__);
			return <SendBatchSyncAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385C2 RID: 230850 RVA: 0x00FC2318 File Offset: 0x00FC0518
		private UniTask WaitBatchSyncCooldownAsync()
		{
			SolarSchoolController.<WaitBatchSyncCooldownAsync>d__48 <WaitBatchSyncCooldownAsync>d__;
			<WaitBatchSyncCooldownAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitBatchSyncCooldownAsync>d__.<>4__this = this;
			<WaitBatchSyncCooldownAsync>d__.<>1__state = -1;
			<WaitBatchSyncCooldownAsync>d__.<>t__builder.Start<SolarSchoolController.<WaitBatchSyncCooldownAsync>d__48>(ref <WaitBatchSyncCooldownAsync>d__);
			return <WaitBatchSyncCooldownAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385C3 RID: 230851 RVA: 0x00FC235C File Offset: 0x00FC055C
		private UniTask SendNetworkRequestsAsync()
		{
			SolarSchoolController.<SendNetworkRequestsAsync>d__49 <SendNetworkRequestsAsync>d__;
			<SendNetworkRequestsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendNetworkRequestsAsync>d__.<>4__this = this;
			<SendNetworkRequestsAsync>d__.<>1__state = -1;
			<SendNetworkRequestsAsync>d__.<>t__builder.Start<SolarSchoolController.<SendNetworkRequestsAsync>d__49>(ref <SendNetworkRequestsAsync>d__);
			return <SendNetworkRequestsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385C4 RID: 230852 RVA: 0x00FC23A0 File Offset: 0x00FC05A0
		public unsafe void SendReachEnding(int endingId)
		{
			SolarSchoolReachEndingRequest solarSchoolReachEndingRequest = SolarSchoolReachEndingRequest.Create();
			solarSchoolReachEndingRequest.Id.Add(endingId);
			Net.Instance.Call(ERequestMessageId.SolarSchoolReachEndingRequest, solarSchoolReachEndingRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SolarSchoolReachEndingResponse solarSchoolReachEndingResponse = (SolarSchoolReachEndingResponse)msg;
				if (solarSchoolReachEndingResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 结局达成上报失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("errorCode", solarSchoolReachEndingResponse.ErrorCode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endingId", endingId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}, 0);
		}

		// Token: 0x060385C5 RID: 230853 RVA: 0x00FC23EE File Offset: 0x00FC05EE
		[NullableContext(2)]
		public void SendAutoSave(SolarSchoolSaveReason reason, Action<bool> onFinish = null)
		{
			this.SendSaveInternal(reason, 0, onFinish, 0);
		}

		// Token: 0x060385C6 RID: 230854 RVA: 0x00FC23FA File Offset: 0x00FC05FA
		[NullableContext(2)]
		private void SendLoadAutoSave(int sourceSlotId, Action<bool> onFinish)
		{
			this.SendSaveInternal(SolarSchoolSaveReason.SolarSchoolReasonLoad, 0, onFinish, sourceSlotId);
		}

		// Token: 0x060385C7 RID: 230855 RVA: 0x00FC2408 File Offset: 0x00FC0608
		[NullableContext(2)]
		public unsafe void SendManualSave(int slotId, Action<bool> onFinish = null)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			int saveSlotCount = SolarSchoolConfig.Instance.GetSaveSlotCount(activityId);
			if (slotId <= 0 || slotId >= saveSlotCount)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 手动存档失败：槽位越界或试图覆盖自动档";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("slotId", slotId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("activityId", activityId);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "可用范围";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("1~");
				defaultInterpolatedStringHandler.AppendFormatted<int>(saveSlotCount - 1);
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				if (onFinish != null)
				{
					onFinish(false);
				}
				return;
			}
			this.SendSaveInternal(SolarSchoolSaveReason.SolarSchoolReasonManual, slotId, onFinish, 0);
		}

		// Token: 0x060385C8 RID: 230856 RVA: 0x00FC24EC File Offset: 0x00FC06EC
		[NullableContext(2)]
		private unsafe void SendSaveInternal(SolarSchoolSaveReason reason, int slotId, Action<bool> onFinish, int loadSourceSlotId = 0)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int activityId = instance.ActivityId;
			SolarSchoolSavePb weekSnapshot = instance.GetWeekSnapshot();
			SolarSchoolSavePb solarSchoolSavePb = (weekSnapshot != null) ? weekSnapshot.Clone() : null;
			SolarSchoolSlotLocalData localRecordSnapshot = instance.GetWeekLocalRecordSnapshot();
			if (((solarSchoolSavePb != null) ? solarSchoolSavePb.Preview : null) != null)
			{
				solarSchoolSavePb.Preview.SlotId = slotId;
				solarSchoolSavePb.Preview.LastSaveTime = (long)TimeUtil.Instance.GetServerTime();
				solarSchoolSavePb.Version = SolarSchoolConfig.Instance.GetParamInt(activityId, "SolarSchoolCsCheckResVersion", 0);
				bool flag = reason - SolarSchoolSaveReason.SolarSchoolReasonNewWeek <= 1;
				if (flag)
				{
					this.PredictedLastSyncedGameDay = solarSchoolSavePb.Preview.GameDay - 1;
				}
				SolarSchoolController.BatchSyncSession session = this.CurrentBatchSyncSession;
				SolarSchoolSaveRequest request = SolarSchoolSaveRequest.Create();
				request.ActivityId = activityId;
				request.SavePb = solarSchoolSavePb;
				request.Reason = reason;
				request.LoadSourceSlotId = loadSourceSlotId;
				this.NetworkRequestQueue.Enqueue(() => this.SendSaveAsync(session, request, localRecordSnapshot, onFinish));
				this.SendNetworkRequestsAsync().Forget();
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 存档失败：本周快照尚未定格";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slotId", slotId);
			instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			Action<bool> onFinish2 = onFinish;
			if (onFinish2 == null)
			{
				return;
			}
			onFinish2(false);
		}

		// Token: 0x060385C9 RID: 230857 RVA: 0x00FC2684 File Offset: 0x00FC0884
		private UniTask SendSaveAsync(SolarSchoolController.BatchSyncSession session, SolarSchoolSaveRequest request, SolarSchoolSlotLocalData localRecordSnapshot, [Nullable(2)] Action<bool> onFinish)
		{
			SolarSchoolController.<SendSaveAsync>d__55 <SendSaveAsync>d__;
			<SendSaveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSaveAsync>d__.<>4__this = this;
			<SendSaveAsync>d__.session = session;
			<SendSaveAsync>d__.request = request;
			<SendSaveAsync>d__.localRecordSnapshot = localRecordSnapshot;
			<SendSaveAsync>d__.onFinish = onFinish;
			<SendSaveAsync>d__.<>1__state = -1;
			<SendSaveAsync>d__.<>t__builder.Start<SolarSchoolController.<SendSaveAsync>d__55>(ref <SendSaveAsync>d__);
			return <SendSaveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385CA RID: 230858 RVA: 0x00FC26E8 File Offset: 0x00FC08E8
		private void ExitGameplayOnServerFailed()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.IsInGamePlay)
			{
				return;
			}
			instance.ChangeState(ESolarSchoolStageStateType.GameExit);
			if (SolarSchoolModel.Instance.IsLoadingViewOpen())
			{
				SolarSchoolModel.Instance.FinishAllLoadingPhases();
			}
		}

		// Token: 0x060385CB RID: 230859 RVA: 0x00FC2724 File Offset: 0x00FC0924
		private void ShowServerFailedTip(Aki.Protocol.ErrorCode errorCode, EResponseMessageId messageId)
		{
			if (!ErrorCodeController.Instance.IsErrorCodeOpen)
			{
				return;
			}
			string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(errorCode);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
			ConfirmBoxDataNew confirmBoxDataNew2 = confirmBoxDataNew;
			string[] array = new string[1];
			int num = 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)messageId);
			defaultInterpolatedStringHandler.AppendLiteral("][");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)errorCode);
			defaultInterpolatedStringHandler.AppendLiteral("]:");
			defaultInterpolatedStringHandler.AppendFormatted(textByErrorId);
			array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
			confirmBoxDataNew2.SetTextArgs(array);
			confirmBoxDataNew.ErrorCode = new int?((int)errorCode);
			confirmBoxDataNew.NotAddChildToTopStackView = true;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060385CC RID: 230860 RVA: 0x00FC27CC File Offset: 0x00FC09CC
		[NullableContext(2)]
		public void RequestLoad(int activityId, int slotId, Action<bool> onFinish = null, Action onServerLoaded = null)
		{
			SolarSchoolLoadRequest request = SolarSchoolLoadRequest.Create();
			request.ActivityId = activityId;
			request.SlotId = slotId;
			request.SolarSchoolClientResVersion = SolarSchoolConfig.Instance.GetParamInt(activityId, "SolarSchoolCsCheckResVersion", 0);
			this.QueueBatchSyncAsync(false).Forget<bool>();
			this.NetworkRequestQueue.Enqueue(() => this.SendLoadAsync(request, onFinish, onServerLoaded));
			this.SendNetworkRequestsAsync().Forget();
		}

		// Token: 0x060385CD RID: 230861 RVA: 0x00FC2864 File Offset: 0x00FC0A64
		[NullableContext(2)]
		private UniTask SendLoadAsync([Nullable(1)] SolarSchoolLoadRequest request, Action<bool> onFinish, Action onServerLoaded)
		{
			SolarSchoolController.<SendLoadAsync>d__59 <SendLoadAsync>d__;
			<SendLoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendLoadAsync>d__.<>4__this = this;
			<SendLoadAsync>d__.request = request;
			<SendLoadAsync>d__.onFinish = onFinish;
			<SendLoadAsync>d__.onServerLoaded = onServerLoaded;
			<SendLoadAsync>d__.<>1__state = -1;
			<SendLoadAsync>d__.<>t__builder.Start<SolarSchoolController.<SendLoadAsync>d__59>(ref <SendLoadAsync>d__);
			return <SendLoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385CE RID: 230862 RVA: 0x00FC28C0 File Offset: 0x00FC0AC0
		private UniTask ApplyLoadedSave(int activityId, int slotId, SolarSchoolSavePb save, [Nullable(2)] Action<bool> onFinish)
		{
			SolarSchoolController.<ApplyLoadedSave>d__60 <ApplyLoadedSave>d__;
			<ApplyLoadedSave>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyLoadedSave>d__.<>4__this = this;
			<ApplyLoadedSave>d__.activityId = activityId;
			<ApplyLoadedSave>d__.slotId = slotId;
			<ApplyLoadedSave>d__.save = save;
			<ApplyLoadedSave>d__.onFinish = onFinish;
			<ApplyLoadedSave>d__.<>1__state = -1;
			<ApplyLoadedSave>d__.<>t__builder.Start<SolarSchoolController.<ApplyLoadedSave>d__60>(ref <ApplyLoadedSave>d__);
			return <ApplyLoadedSave>d__.<>t__builder.Task;
		}

		// Token: 0x060385CF RID: 230863 RVA: 0x00FC2924 File Offset: 0x00FC0B24
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			if (viewName == EUiViewName.SolarSchoolEntranceView)
			{
				UiManager.Instance.OpenView(EUiViewName.SolarSchoolEntranceView, null, null);
			}
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x060385D0 RID: 230864 RVA: 0x00FC294A File Offset: 0x00FC0B4A
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolActivityOpenTipsView, null, null);
		}

		// Token: 0x17006BE3 RID: 27619
		// (get) Token: 0x060385D1 RID: 230865 RVA: 0x00FC295D File Offset: 0x00FC0B5D
		public static SolarSchoolController Instance
		{
			get
			{
				return SolarSchoolController._Instance;
			}
		}

		// Token: 0x060385D2 RID: 230866 RVA: 0x00FC2964 File Offset: 0x00FC0B64
		public static SolarSchoolController GetOrCreateInstance()
		{
			if (SolarSchoolController._Instance == null)
			{
				SolarSchoolController.CreateInstance();
			}
			return SolarSchoolController._Instance;
		}

		// Token: 0x060385D3 RID: 230867 RVA: 0x00FC2978 File Offset: 0x00FC0B78
		public static bool CreateInstance()
		{
			if (SolarSchoolController._Instance != null)
			{
				return true;
			}
			SolarSchoolController._Instance = new SolarSchoolController();
			return true;
		}

		// Token: 0x060385D4 RID: 230868 RVA: 0x00FC298E File Offset: 0x00FC0B8E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060385D5 RID: 230869 RVA: 0x00FC2990 File Offset: 0x00FC0B90
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolController._Instance = null;
		}

		// Token: 0x060385D6 RID: 230870 RVA: 0x00FC2998 File Offset: 0x00FC0B98
		static SolarSchoolController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolController.CreateStaticDefaultValue), new Action(SolarSchoolController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA96 RID: 121494
		[TupleElementNames(new string[]
		{
			"FlowId",
			"PlotId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Queue<ValueTuple<int, int>> ReadPlotQueue = new Queue<ValueTuple<int, int>>();

		// Token: 0x0401DA97 RID: 121495
		private bool IsSendingReadPlot;

		// Token: 0x0401DA98 RID: 121496
		private readonly List<SolarSchoolBatchSyncData> PendingSyncList = new List<SolarSchoolBatchSyncData>();

		// Token: 0x0401DA99 RID: 121497
		[TupleElementNames(new string[]
		{
			"Change",
			"StartValue"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ESolarSchoolSecondAttr, ValueTuple<AttrChangeSyncDataPb, int>> PendingAttrChangeMap = new Dictionary<ESolarSchoolSecondAttr, ValueTuple<AttrChangeSyncDataPb, int>>();

		// Token: 0x0401DA9A RID: 121498
		private readonly Dictionary<int, ItemDeltaPb> PendingItemChangeMap = new Dictionary<int, ItemDeltaPb>();

		// Token: 0x0401DA9B RID: 121499
		private const int MaxBatchSyncCount = 256;

		// Token: 0x0401DA9C RID: 121500
		private int PredictedLastSyncedGameDay;

		// Token: 0x0401DA9D RID: 121501
		private readonly Queue<Func<UniTask>> NetworkRequestQueue = new Queue<Func<UniTask>>();

		// Token: 0x0401DA9E RID: 121502
		private bool IsSendingNetworkRequest;

		// Token: 0x0401DA9F RID: 121503
		private SolarSchoolController.BatchSyncSession CurrentBatchSyncSession = new SolarSchoolController.BatchSyncSession();

		// Token: 0x0401DAA0 RID: 121504
		private double? LastBatchSyncResponseTime;

		// Token: 0x0401DAA1 RID: 121505
		private const int BatchSyncCooldownMs = 500;

		// Token: 0x0401DAA2 RID: 121506
		[Nullable(2)]
		private static SolarSchoolController _Instance;

		// Token: 0x0200B505 RID: 46341
		[NullableContext(0)]
		private sealed class BatchSyncSession
		{
			// Token: 0x04037F83 RID: 229251
			public bool HasFailed;

			// Token: 0x04037F84 RID: 229252
			public bool IsDiscarded;
		}
	}
}
