using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.QuestNew.Controller;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02003EDC RID: 16092
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RecallQuestController : UiControllerBase
	{
		// Token: 0x06028CF0 RID: 167152 RVA: 0x00B73058 File Offset: 0x00B71258
		protected override void OnRegisterNetEvent()
		{
			base.OnRegisterNetEvent();
			Net.Instance.Register(ENotifyMessageId.RecallQuestListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallQuestListNotify));
			Net.Instance.Register(ENotifyMessageId.RecallQuestStatusUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallQuestStatusUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RecallQuestFinishListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallQuestFinishListNotify));
			Net.Instance.Register(ENotifyMessageId.DestroyRecallQuestsNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDestroyRecallQuestsNotify));
			Net.Instance.Register(ENotifyMessageId.LeaveQuestRecallNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLeaveQuestRecallNotify));
			Net.Instance.Register(ENotifyMessageId.RecallInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallInfoNotify));
			Net.Instance.Register(ENotifyMessageId.PlayerRecallInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPlayerRecallInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RecallQuestGiveUpNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallQuestGiveUpNotify));
			Net.Instance.Register(ENotifyMessageId.TraceRecallQuestNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTraceRecallQuestNotify));
			Net.Instance.Register(ENotifyMessageId.RecallInstSaveDataNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallInstSaveDataNotify));
			Net.Instance.Register(ENotifyMessageId.RecallItemBagDeltaNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallItemBagDeltaNotify));
			Net.Instance.Register(ENotifyMessageId.RecallItemBagObtainNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallItemBagObtainNotify));
			Net.Instance.Register(ENotifyMessageId.RecallItemBagRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallItemBagRemoveNotify));
			Net.Instance.Register(ENotifyMessageId.RecallItemRewardNotify, new Action<IMessage, Net.CallbackStatus>(ItemHintController.Instance.HandleRecallItemRewardNotify));
			Net.Instance.Register(ENotifyMessageId.RecallExploreSkillRouletteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallExploreSkillRouletteNotify));
			Net.Instance.Register(ENotifyMessageId.RecallMapMarkInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallMapMarkInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RecallMapMarkUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRecallMapMarkUpdateNotify));
		}

		// Token: 0x06028CF1 RID: 167153 RVA: 0x00B7324C File Offset: 0x00B7144C
		protected override void OnUnRegisterNetEvent()
		{
			base.OnUnRegisterNetEvent();
			Net.Instance.UnRegister(ENotifyMessageId.RecallQuestListNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TraceRecallQuestNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallQuestStatusUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallQuestFinishListNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DestroyRecallQuestsNotify);
			Net.Instance.UnRegister(ENotifyMessageId.LeaveQuestRecallNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PlayerRecallInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallQuestGiveUpNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallInstSaveDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallItemBagDeltaNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallItemBagObtainNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallItemBagRemoveNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallItemRewardNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallExploreSkillRouletteNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallMapMarkInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RecallMapMarkUpdateNotify);
		}

		// Token: 0x06028CF2 RID: 167154 RVA: 0x00B73370 File Offset: 0x00B71570
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.DoLeaveLevel, new Action(this.OnDoLeaveLevel));
			EventSystem.Instance.Add<string>(EEventName.InputDistribute, new Action<string>(this.OnInputDistribute));
		}

		// Token: 0x06028CF3 RID: 167155 RVA: 0x00B733D4 File Offset: 0x00B715D4
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.DoLeaveLevel, new Action(this.OnDoLeaveLevel));
			EventSystem.Instance.Remove(EEventName.InputDistribute, new Action<string>(this.OnInputDistribute));
		}

		// Token: 0x06028CF4 RID: 167156 RVA: 0x00B73438 File Offset: 0x00B71638
		public void LogReportRecallClick(int entranceId, int result)
		{
			RecallQuestClickLogEvent recallQuestClickLogEvent = new RecallQuestClickLogEvent();
			recallQuestClickLogEvent.i_recall_id = entranceId;
			recallQuestClickLogEvent.i_result = result;
			LogReportController.Instance.LogReport(recallQuestClickLogEvent);
		}

		// Token: 0x06028CF5 RID: 167157 RVA: 0x00B73464 File Offset: 0x00B71664
		private void SendReadyForGiveUpRequest(int recallId)
		{
			RecallQuestReadyForGiveUpRequest recallQuestReadyForGiveUpRequest = RecallQuestReadyForGiveUpRequest.Create();
			recallQuestReadyForGiveUpRequest.RecallQuestId = recallId;
			Net.Instance.Call(ERequestMessageId.RecallQuestReadyForGiveUpRequest, recallQuestReadyForGiveUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallQuestReadyForGiveUpResponse recallQuestReadyForGiveUpResponse = (RecallQuestReadyForGiveUpResponse)msg;
				if (recallQuestReadyForGiveUpResponse != null && recallQuestReadyForGiveUpResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestReadyForGiveUpResponse.ErrorId, 21194, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028CF6 RID: 167158 RVA: 0x00B734B0 File Offset: 0x00B716B0
		private unsafe void OnRecallQuestGiveUpNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallQuestGiveUpNotify recallQuestGiveUpNotify = (RecallQuestGiveUpNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestRecall;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "回顾任务 GiveUp 通知";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RecallQuestId", recallQuestGiveUpNotify.RecallQuestId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TreeIncId", recallQuestGiveUpNotify.TreeIncId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			QuestNewController.HandleGiveUpNotify(recallQuestGiveUpNotify.RecallQuestId, recallQuestGiveUpNotify.TreeIncId, recallQuestGiveUpNotify.FlowIncIds, new Action<int>(this.SendReadyForGiveUpRequest), "任务结束打断剧情");
		}

		// Token: 0x06028CF7 RID: 167159 RVA: 0x00B73554 File Offset: 0x00B71754
		private void OnRecallItemBagDeltaNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallItemBagDeltaNotify recallItemBagDeltaNotify = (RecallItemBagDeltaNotify)msg;
			RecallInventoryData inventoryData = RecallQuestModel.Instance.GetInventoryData();
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			List<IProto_NormalItem> list2 = new List<IProto_NormalItem>();
			List<int> list3 = new List<int>();
			int currentEquipItemId = RouletteModel.Instance.CurrentEquipItemId;
			foreach (RecallItemBagItem recallItemBagItem in recallItemBagDeltaNotify.Items)
			{
				int count = inventoryData.GetCount(recallItemBagItem.ItemId);
				int count2 = recallItemBagItem.Count;
				int num = count2 - count;
				if (count2 > 0)
				{
					inventoryData.SetItem(recallItemBagItem.ItemId, count2);
				}
				else
				{
					inventoryData.RemoveItem(recallItemBagItem.ItemId);
					list3.Add(recallItemBagItem.ItemId);
					int itemId = recallItemBagItem.ItemId;
				}
				EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, recallItemBagItem.ItemId, count2);
				NormalItem normalItem = new NormalItem();
				normalItem.Id = recallItemBagItem.ItemId;
				normalItem.Count = count2;
				EventSystem.Instance.Emit<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, normalItem, count2, count);
				if (num > 0)
				{
					list2.Add(new NormalItem
					{
						Id = recallItemBagItem.ItemId,
						Count = num
					});
					list.Add(new ValueTuple<int, int>(recallItemBagItem.ItemId, num));
				}
			}
			if (list3.Count > 0)
			{
				EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, list3);
			}
			EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, list2);
			EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, list2);
			if (list.Count > 0)
			{
				ItemHintController.Instance.AddRecallItemList(list.ToArray());
			}
		}

		// Token: 0x06028CF8 RID: 167160 RVA: 0x00B7371C File Offset: 0x00B7191C
		private void OnRecallItemBagObtainNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallItemBagObtainNotify recallItemBagObtainNotify = (RecallItemBagObtainNotify)msg;
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (RecallItemBagItem recallItemBagItem in recallItemBagObtainNotify.Items)
			{
				list.Add(new RewardItemData(recallItemBagItem.ItemId, recallItemBagItem.Count, null, EDropItemType.Normal));
			}
			if (list.Count > 0)
			{
				ItemRewardController.Instance.DispatchPackagedReward(recallItemBagObtainNotify.Reason, list, new List<RewardItemPackage>(), new List<RewardItemData>(), new List<RewardItemData>(), new List<RewardItemData>(), new List<RewardItemData>(), 0, null, null);
			}
		}

		// Token: 0x06028CF9 RID: 167161 RVA: 0x00B737C8 File Offset: 0x00B719C8
		private void OnRecallItemBagRemoveNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallItemBagRemoveNotify recallItemBagRemoveNotify = (RecallItemBagRemoveNotify)msg;
			int currentEquipItemId = RouletteModel.Instance.CurrentEquipItemId;
			bool flag = false;
			RecallInventoryData inventoryData = RecallQuestModel.Instance.GetInventoryData();
			foreach (int num in recallItemBagRemoveNotify.ItemIds)
			{
				inventoryData.RemoveItem(num);
				EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, num, 0);
				if (currentEquipItemId == num)
				{
					flag = true;
				}
			}
			if (recallItemBagRemoveNotify.ItemIds.Count > 0)
			{
				EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, recallItemBagRemoveNotify.ItemIds);
			}
			if (flag)
			{
				List<int> rouletteIdList = RouletteModel.Instance.GetCurrentExploreRouletteListData().GetRouletteIdList();
				CharacterExploreModel.Instance.SetExploreSkillId(rouletteIdList[0], EExploreSkillLayer.Roulette, "OnRecallItemBagRemoveNotify");
				RouletteController.Instance.ExploreSkillSetRequest(rouletteIdList[0], null, false);
			}
		}

		// Token: 0x06028CFA RID: 167162 RVA: 0x00B738BC File Offset: 0x00B71ABC
		private void OnQueryRecallItemBagResponse(IMessage msg, Net.CallbackStatus status)
		{
			QueryRecallItemBagResponse queryRecallItemBagResponse = (QueryRecallItemBagResponse)msg;
			if (queryRecallItemBagResponse == null || queryRecallItemBagResponse.ErrorCode != ErrorCode.Success)
			{
				return;
			}
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>(queryRecallItemBagResponse.Items.Count);
			foreach (RecallItemBagItem recallItemBagItem in queryRecallItemBagResponse.Items)
			{
				list.Add(new ValueTuple<int, int>(recallItemBagItem.ItemId, recallItemBagItem.Count));
			}
			RecallQuestModel instance = RecallQuestModel.Instance;
			instance.GetInventoryData().InitFromFullSnapshot(list);
			InventoryModel.Instance.SetInventoryDataProxy(new RecallInventoryDataProxy(instance.GetInventoryData()));
			foreach (ValueTuple<int, int> valueTuple in list)
			{
				EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, valueTuple.Item1, valueTuple.Item2);
			}
		}

		// Token: 0x06028CFB RID: 167163 RVA: 0x00B739C0 File Offset: 0x00B71BC0
		private void OnWorldDone()
		{
			RecallQuestModel instance = RecallQuestModel.Instance;
			if (!instance.IsInRecallInstance())
			{
				instance.ClearCachedExploreSkill();
				return;
			}
			if (instance.CacheRecallExploreSkillRouletteData != null)
			{
				this.ProcessRecallExploreSkillRouletteNotify(instance.CacheRecallExploreSkillRouletteData);
				instance.CacheRecallExploreSkillRouletteData = null;
			}
			RouletteController.Instance.ApplyCachedRecallExploreSkill();
			if (instance.HasQueriedItemBag)
			{
				return;
			}
			instance.HasQueriedItemBag = true;
			QueryRecallItemBagRequest queryRecallItemBagRequest = QueryRecallItemBagRequest.Create();
			queryRecallItemBagRequest.RecallId = instance.GetCurrentRecallId();
			Net.Instance.Call(ERequestMessageId.QueryRecallItemBagRequest, queryRecallItemBagRequest, new Action<IMessage, Net.CallbackStatus>(this.OnQueryRecallItemBagResponse), 0);
		}

		// Token: 0x06028CFC RID: 167164 RVA: 0x00B73A46 File Offset: 0x00B71C46
		private void OnDoLeaveLevel()
		{
		}

		// Token: 0x06028CFD RID: 167165 RVA: 0x00B73A48 File Offset: 0x00B71C48
		private void OnRecallInstSaveDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallInstSaveDataNotify recallInstSaveDataNotify = (RecallInstSaveDataNotify)msg;
			if (recallInstSaveDataNotify == null)
			{
				return;
			}
			List<int> list = new List<int>(recallInstSaveDataNotify.Ids.Count);
			foreach (long num in recallInstSaveDataNotify.Ids)
			{
				list.Add((int)num);
			}
			RecallQuestModel.Instance.SetInstanceIdsWithSaveData(recallInstSaveDataNotify.RecallId, list);
		}

		// Token: 0x06028CFE RID: 167166 RVA: 0x00B73AC4 File Offset: 0x00B71CC4
		private void OnRecallQuestListNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallQuestListNotify recallQuestListNotify = (RecallQuestListNotify)msg;
			if (!this.IsTrackSlotAttached)
			{
				QuestNewModel.Instance.AttachTrackSlot(new RecallQuestTrackProxy());
				this.IsTrackSlotAttached = true;
				Log.Instance.Info(ELogModule.QuestRecall, ELogAuthor.YZY, "回顾副本：QuestTrack Slot 已挂载", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			List<QuestListItem> list = new List<QuestListItem>();
			foreach (RecallQuestInfo recallQuestInfo in recallQuestListNotify.RecallQuestInfos)
			{
				int recallQuestId = recallQuestInfo.RecallQuestId;
				RecallQuestModel.Instance.RecordCurrentRecallQuestId(recallQuestId);
				ERecallQuestStatus status2 = RecallQuestDefine.ToStatus((int)recallQuestInfo.Status);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "下发回顾任务列表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", recallQuestId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				list.Add(new QuestListItem
				{
					QuestId = recallQuestId,
					State = RecallQuestDefine.ToProtoQuestState(status2),
					UpdateReason = RecallQuestDefine.ToQuestUpdateReason(ERecallStatusUpdateReason.ReLogin)
				});
			}
			QuestNewController.HandleQuestListNotify(list);
			RecallQuestModel.Instance.TryReTrackRecallQuest();
		}

		// Token: 0x06028CFF RID: 167167 RVA: 0x00B73BDC File Offset: 0x00B71DDC
		private unsafe void OnRecallQuestStatusUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallQuestStatusUpdateNotify recallQuestStatusUpdateNotify = (RecallQuestStatusUpdateNotify)msg;
			if (!this.IsTrackSlotAttached)
			{
				QuestNewModel.Instance.AttachTrackSlot(new RecallQuestTrackProxy());
				this.IsTrackSlotAttached = true;
			}
			int recallQuestId = recallQuestStatusUpdateNotify.RecallQuestId;
			RecallQuestModel.Instance.RecordCurrentRecallQuestId(recallQuestId);
			ERecallQuestStatus status2 = RecallQuestDefine.ToStatus((int)recallQuestStatusUpdateNotify.Status);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestRecall;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "回顾任务状态变更";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", recallQuestId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", recallQuestStatusUpdateNotify.Status);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			QuestNewController.HandleQuestStateUpdate(new QuestStateUpdateData
			{
				QuestId = recallQuestId,
				State = RecallQuestDefine.ToProtoQuestState(status2),
				UpdateReason = RecallQuestDefine.ToQuestUpdateReason(ERecallStatusUpdateReason.NotifyChange)
			});
		}

		// Token: 0x06028D00 RID: 167168 RVA: 0x00B73CB8 File Offset: 0x00B71EB8
		private void OnRecallQuestFinishListNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallQuestFinishListNotify recallQuestFinishListNotify = (RecallQuestFinishListNotify)msg;
			RecallQuestModel.Instance.RecordCurrentRecallQuestIds(recallQuestFinishListNotify.RecallQuestIds);
			FinishListNotifyData finishListNotifyData = new FinishListNotifyData();
			finishListNotifyData.QuestIds = new List<int>(recallQuestFinishListNotify.RecallQuestIds);
			finishListNotifyData.EmitEventName = EEventName.OnQuestFinishListNotify;
			finishListNotifyData.TryChangeTrackedQuest = delegate()
			{
				QuestNewController.Instance.TryChangeTrackedQuest2(null);
			};
			QuestNewController.HandleFinishListNotify(finishListNotifyData);
		}

		// Token: 0x06028D01 RID: 167169 RVA: 0x00B73D28 File Offset: 0x00B71F28
		private void OnDestroyRecallQuestsNotify(IMessage msg, Net.CallbackStatus status)
		{
			DestroyRecallQuestsNotify destroyRecallQuestsNotify = (DestroyRecallQuestsNotify)msg;
			RecallQuestModel.Instance.RecordCurrentRecallQuestIds(destroyRecallQuestsNotify.RecallQuestIds);
			foreach (int num in destroyRecallQuestsNotify.RecallQuestIds)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "销毁回顾任务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RecallId", num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
				if (curTrackedQuest != null && curTrackedQuest.Id == num)
				{
					QuestNewModel.Instance.SetQuestTrackState(num, false, ESetTrackReason.None);
				}
				this.ClearAcceptQuestTrack(num);
				QuestNewModel.Instance.RemoveQuest(num);
			}
		}

		// Token: 0x06028D02 RID: 167170 RVA: 0x00B73DEC File Offset: 0x00B71FEC
		public void ClearAcceptQuestTrack(int questId)
		{
			global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
			if (quest == null || quest.Type != EQuest.Recall)
			{
				return;
			}
			int canAcceptMapMarkId = quest.GetCanAcceptMapMarkId();
			if (canAcceptMapMarkId == 0)
			{
				return;
			}
			MapModel instance = MapModel.Instance;
			TrackMapMarkParams curTrackMark = instance.GetCurTrackMark();
			if (curTrackMark != null && curTrackMark.MarkType == EMarkType.Quest && curTrackMark.MarkId == canAcceptMapMarkId)
			{
				instance.SetCurTrackMark(null);
			}
			TrackController.Instance.EndTrack(ETrackSource.Quest, canAcceptMapMarkId);
			TrackController.Instance.EndTrack(ETrackSource.MapMark, canAcceptMapMarkId);
		}

		// Token: 0x06028D03 RID: 167171 RVA: 0x00B73E6C File Offset: 0x00B7206C
		private void OnLeaveQuestRecallNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallQuestModel.Instance.ClearCachedExploreSkill();
			LeaveQuestRecallNotify leaveQuestRecallNotify = (LeaveQuestRecallNotify)msg;
			HashSet<int> hashSet = new HashSet<int>(RecallQuestModel.Instance.TakeCurrentRecallQuestIds());
			foreach (int item in leaveQuestRecallNotify.DestroyRecallQuestIds)
			{
				hashSet.Add(item);
			}
			foreach (global::Quest quest in QuestNewModel.Instance.GetQuests())
			{
				if (quest.Type == EQuest.Recall)
				{
					hashSet.Add(quest.Id);
				}
			}
			foreach (int num in hashSet)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "离开回顾销毁任务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RecallId", num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
				if (curTrackedQuest != null && curTrackedQuest.Id == num)
				{
					QuestNewModel.Instance.SetQuestTrackState(num, false, ESetTrackReason.None);
				}
				this.ClearAcceptQuestTrack(num);
				QuestNewModel.Instance.RemoveQuest(num);
				QuestNewModel.Instance.RemoveCanAcceptQuest(num);
				QuestNewModel.Instance.RemoveFinishedQuest(num);
			}
			RouletteListDataBase rouletteListDataBase;
			if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Explore, out rouletteListDataBase))
			{
				RouletteListDataExplore rouletteListDataExplore = rouletteListDataBase as RouletteListDataExplore;
				if (rouletteListDataExplore != null)
				{
					rouletteListDataExplore.SetExtraItemIdProxy(null);
					Log.Instance.Info(ELogModule.QuestRecall, ELogAuthor.YZY, "退出回顾：探索轮盘 ExtraItemIdProxy 已还原为 Normal", default(ReadOnlySpan<ValueTuple<string, object>>));
					EventSystem.Instance.Emit<int?>(EEventName.OnSpecialItemUpdate, new int?(rouletteListDataExplore.GetExtraItemId()));
				}
			}
			if (!this.IsTrackSlotAttached)
			{
				return;
			}
			QuestNewModel instance2 = QuestNewModel.Instance;
			if (instance2 != null)
			{
				instance2.DetachTrackSlot();
			}
			this.IsTrackSlotAttached = false;
			Log.Instance.Info(ELogModule.QuestRecall, ELogAuthor.YZY, "回顾副本：QuestTrack Slot 已卸下", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06028D04 RID: 167172 RVA: 0x00B74094 File Offset: 0x00B72294
		private void OnRecallExploreSkillRouletteNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallExploreSkillRouletteNotify recallExploreSkillRouletteNotify = (RecallExploreSkillRouletteNotify)msg;
			if (!GameModeModel.Instance.WorldDone)
			{
				RecallQuestModel.Instance.CacheRecallExploreSkillRouletteData = recallExploreSkillRouletteNotify;
				return;
			}
			this.ProcessRecallExploreSkillRouletteNotify(recallExploreSkillRouletteNotify);
		}

		// Token: 0x06028D05 RID: 167173 RVA: 0x00B740C8 File Offset: 0x00B722C8
		[NullableContext(1)]
		private void ProcessRecallExploreSkillRouletteNotify(RecallExploreSkillRouletteNotify notify)
		{
			RouletteListDataBase rouletteListDataBase;
			if (!RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Explore, out rouletteListDataBase))
			{
				Log.Instance.Error(ELogModule.QuestRecall, ELogAuthor.YZY, "收到 RecallExploreSkillRouletteNotify 但探索轮盘数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RouletteListDataExplore rouletteListDataExplore = rouletteListDataBase as RouletteListDataExplore;
			if (rouletteListDataExplore == null)
			{
				Log.Instance.Error(ELogModule.QuestRecall, ELogAuthor.YZY, "收到 RecallExploreSkillRouletteNotify 但探索轮盘数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int extraItemId = notify.ExtraItemId;
			RecallExtraItemIdProxy recallExtraItemIdProxy = rouletteListDataExplore.GetExtraItemIdProxy() as RecallExtraItemIdProxy;
			if (recallExtraItemIdProxy != null)
			{
				recallExtraItemIdProxy.ApplyServerSnapshot(extraItemId);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "回顾道具同步：复用现有 Recall Proxy 灌入服务端值";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ExtraItemId", extraItemId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				RecallExtraItemIdProxy recallExtraItemIdProxy2 = new RecallExtraItemIdProxy();
				rouletteListDataExplore.SetExtraItemIdProxy(recallExtraItemIdProxy2);
				recallExtraItemIdProxy2.ApplyServerSnapshot(extraItemId);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.QuestRecall;
				ELogAuthor author2 = ELogAuthor.YZY;
				string message2 = "进入回顾：切换 ExtraItemIdProxy 为 Recall";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ExtraItemId", extraItemId);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (RecallQuestModel.Instance.CacheRecallExploreSkillRouletteData == null && RecallQuestModel.Instance.CacheRecallExploreSkillId == null && extraItemId == 0)
			{
				List<int> rouletteIdList = RouletteModel.Instance.GetCurrentExploreRouletteListData().GetRouletteIdList();
				CharacterExploreModel.Instance.SetExploreSkillId(rouletteIdList[0], EExploreSkillLayer.Roulette, "OnRecallItemBagRemoveNotify");
				RouletteController.Instance.ExploreSkillSetRequest(rouletteIdList[0], null, false);
			}
			EventSystem.Instance.Emit<int?>(EEventName.OnSpecialItemUpdate, new int?(rouletteListDataExplore.GetExtraItemId()));
		}

		// Token: 0x06028D06 RID: 167174 RVA: 0x00B74238 File Offset: 0x00B72438
		public void SendRecallExploreSkillRouletteSet(int itemId, Action<bool> callback = null)
		{
			RecallExploreSkillRouletteSetRequest recallExploreSkillRouletteSetRequest = RecallExploreSkillRouletteSetRequest.Create();
			recallExploreSkillRouletteSetRequest.ExtraItemId = itemId;
			Net.Instance.Call(ERequestMessageId.RecallExploreSkillRouletteSetRequest, recallExploreSkillRouletteSetRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallExploreSkillRouletteSetResponse recallExploreSkillRouletteSetResponse = (RecallExploreSkillRouletteSetResponse)msg;
				if (recallExploreSkillRouletteSetResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (recallExploreSkillRouletteSetResponse.ErrorId == ErrorCode.Success)
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
				else
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallExploreSkillRouletteSetResponse.ErrorId, 25464, null, true, true);
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(false);
					return;
				}
			}, 0);
		}

		// Token: 0x06028D07 RID: 167175 RVA: 0x00B7427C File Offset: 0x00B7247C
		private void OnRecallInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			RecallInfoNotify recallInfoNotify = (RecallInfoNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestRecall;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "回顾任务信息推送";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RecallIds", recallInfoNotify.RecallInfos);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RecallQuestModel.Instance.SetPastRecallIds(recallInfoNotify.RecallInfos);
		}

		// Token: 0x06028D08 RID: 167176 RVA: 0x00B742CC File Offset: 0x00B724CC
		private void OnTraceRecallQuestNotify(IMessage msg, Net.CallbackStatus status)
		{
			int recallQuestId = ((TraceRecallQuestNotify)msg).RecallQuestId;
			if (QuestNewModel.Instance.GetQuest(recallQuestId) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "回顾任务跟踪目标修改：本地未找到对应Quest，忽略 Notify";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RecallQuestId", recallQuestId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.QuestRecall;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "回顾任务跟踪目标修改";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RecallQuestId", recallQuestId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			QuestNewController.NotifyTraceQuestFromServer(recallQuestId);
		}

		// Token: 0x06028D09 RID: 167177 RVA: 0x00B74354 File Offset: 0x00B72554
		private void OnPlayerRecallInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			int curRecallId = ((PlayerRecallInfoNotify)msg).CurRecallId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestRecall;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "玩家当前回顾信息推送";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurRecallId", curRecallId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RecallQuestModel.Instance.SetCurrentRecallId(curRecallId);
		}

		// Token: 0x06028D0A RID: 167178 RVA: 0x00B743A4 File Offset: 0x00B725A4
		private void OnRecallMapMarkInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (MapMarkShowInfo mapMarkShowInfo in ((RecallMapMarkInfoNotify)msg).MapMarkShowInfos)
			{
				MapModel.Instance.SetMarkExtraShowState(mapMarkShowInfo.MarkId, false, (MapMarkShowFlag)mapMarkShowInfo.ShowFlag);
			}
		}

		// Token: 0x06028D0B RID: 167179 RVA: 0x00B74408 File Offset: 0x00B72608
		private void OnRecallMapMarkUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MapMarkShowInfo markInfo = ((RecallMapMarkUpdateNotify)msg).MarkInfo;
			if (markInfo == null)
			{
				return;
			}
			MapModel.Instance.SetMarkExtraShowState(markInfo.MarkId, false, (MapMarkShowFlag)markInfo.ShowFlag);
		}

		// Token: 0x06028D0C RID: 167180 RVA: 0x00B7443C File Offset: 0x00B7263C
		public void RequestRecallQuestFinishAction(int questId, int nodeId, int actionId, ActionTime actTime)
		{
			RecallQuestFinishActionRequest recallQuestFinishActionRequest = RecallQuestFinishActionRequest.Create();
			recallQuestFinishActionRequest.RecallQuestId = questId;
			recallQuestFinishActionRequest.NodeId = nodeId;
			recallQuestFinishActionRequest.ActionId = actionId;
			recallQuestFinishActionRequest.ActTime = actTime;
			Net.Instance.Call(ERequestMessageId.RecallQuestFinishActionRequest, recallQuestFinishActionRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallQuestFinishActionResponse recallQuestFinishActionResponse = (RecallQuestFinishActionResponse)msg;
				if (recallQuestFinishActionResponse != null && recallQuestFinishActionResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestFinishActionResponse.ErrorId, 15780, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028D0D RID: 167181 RVA: 0x00B7449C File Offset: 0x00B7269C
		public void RequestRecallAction(int questId, int nodeId, int actionId, ActionTime actTime)
		{
			RecallQuestActionRequest recallQuestActionRequest = RecallQuestActionRequest.Create();
			recallQuestActionRequest.RecallQuestId = questId;
			recallQuestActionRequest.NodeId = nodeId;
			recallQuestActionRequest.ActionId = actionId;
			recallQuestActionRequest.ActTime = actTime;
			Net.Instance.Call(ERequestMessageId.RecallQuestActionRequest, recallQuestActionRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallQuestActionResponse recallQuestActionResponse = (RecallQuestActionResponse)msg;
				if (recallQuestActionResponse != null && recallQuestActionResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestActionResponse.ErrorId, 22619, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028D0E RID: 167182 RVA: 0x00B744FC File Offset: 0x00B726FC
		public void RequestRecallQuestNpcMoveOver(long entityId)
		{
			RecallQuestNpcMoveOverRequest recallQuestNpcMoveOverRequest = RecallQuestNpcMoveOverRequest.Create();
			recallQuestNpcMoveOverRequest.EntityId = entityId;
			Net.Instance.Call(ERequestMessageId.RecallQuestNpcMoveOverRequest, recallQuestNpcMoveOverRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallQuestNpcMoveOverResponse recallQuestNpcMoveOverResponse = (RecallQuestNpcMoveOverResponse)msg;
				if (recallQuestNpcMoveOverResponse != null && recallQuestNpcMoveOverResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestNpcMoveOverResponse.ErrorId, 19333, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028D0F RID: 167183 RVA: 0x00B74548 File Offset: 0x00B72748
		public void RequestRecallTeleportToMarkId(int markId)
		{
			RecallTeleportToMarkIdRequest recallTeleportToMarkIdRequest = RecallTeleportToMarkIdRequest.Create();
			recallTeleportToMarkIdRequest.MarkId = markId;
			Net.Instance.Call(ERequestMessageId.RecallTeleportToMarkIdRequest, recallTeleportToMarkIdRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallTeleportToMarkIdResponse recallTeleportToMarkIdResponse = (RecallTeleportToMarkIdResponse)msg;
				if (recallTeleportToMarkIdResponse != null && recallTeleportToMarkIdResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallTeleportToMarkIdResponse.ErrorId, 19697, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028D10 RID: 167184 RVA: 0x00B74594 File Offset: 0x00B72794
		[NullableContext(1)]
		public void RequestRecallFinishActionEnd(List<int> questIds)
		{
			RecallQuestFinishActionEndRequest recallQuestFinishActionEndRequest = RecallQuestFinishActionEndRequest.Create();
			foreach (int item in questIds)
			{
				recallQuestFinishActionEndRequest.RecallQuestId.Add(item);
			}
			Net.Instance.Call(ERequestMessageId.RecallQuestFinishActionEndRequest, recallQuestFinishActionEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RecallQuestFinishActionEndResponse recallQuestFinishActionEndResponse = (RecallQuestFinishActionEndResponse)msg;
				if (recallQuestFinishActionEndResponse != null && recallQuestFinishActionEndResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestFinishActionEndResponse.ErrorId, 18345, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06028D11 RID: 167185 RVA: 0x00B74620 File Offset: 0x00B72820
		[NullableContext(1)]
		public void RequestItemUse(int configId, int count, Action<ErrorCode?> callBack)
		{
			RecallQuestController.<>c__DisplayClass34_0 CS$<>8__locals1 = new RecallQuestController.<>c__DisplayClass34_0();
			CS$<>8__locals1.callBack = callBack;
			RecallItemUseRequest recallItemUseRequest = RecallItemUseRequest.Create();
			recallItemUseRequest.ItemId = configId;
			recallItemUseRequest.Count = count;
			Net.Instance.Call(ERequestMessageId.RecallItemUseRequest, recallItemUseRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestItemUse>g__responseItemUse|0), 0);
		}

		// Token: 0x06028D12 RID: 167186 RVA: 0x00B7466C File Offset: 0x00B7286C
		public void RequestStartRecall(int recallId, bool bContinue)
		{
			if (!SubPackageDownLoadModel.Instance.CheckAndDownLoadRecallResource(recallId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SubPackageDownLoad;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "回顾资源不完备，需要下载对应任务资源";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("recallId", recallId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (QuestNewModel.Instance.IsInFocusMode())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CloseFocusQuestTips);
				Action <>9__1;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					int curFocusQuestId = QuestNewModel.Instance.GetCurFocusQuestId();
					QuestNewController instance2 = QuestNewController.Instance;
					int questId = curFocusQuestId;
					Action callback;
					if ((callback = <>9__1) == null)
					{
						callback = (<>9__1 = delegate()
						{
							this.StartRecall(recallId, bContinue);
						});
					}
					instance2.RequestCancelQuestFocusMode(questId, callback);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.StartRecall(recallId, bContinue);
		}

		// Token: 0x06028D13 RID: 167187 RVA: 0x00B74728 File Offset: 0x00B72928
		private void StartRecall(int recallId, bool bContinue)
		{
			StartRecallRequest startRecallRequest = StartRecallRequest.Create();
			startRecallRequest.RecallId = recallId;
			startRecallRequest.Continue = bContinue;
			Net.Instance.Call(ERequestMessageId.StartRecallRequest, startRecallRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				StartRecallResponse startRecallResponse = (StartRecallResponse)msg;
				if (startRecallResponse != null && startRecallResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(startRecallResponse.ErrorCode, 22108, null, true, true);
					return;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "开始回顾";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CanContinue", (startRecallResponse != null) ? new bool?(startRecallResponse.CanContinue) : null);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				RecallQuestModel.Instance.SetCurrentRecallId(recallId);
				bool @continue = startRecallResponse != null && startRecallResponse.CanContinue;
				QuestRecallInstCtx questRecallInstCtx = new QuestRecallInstCtx
				{
					RecallId = recallId,
					Continue = @continue
				};
				FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
				List<int> list = (currentFormationData != null) ? currentFormationData.RoleIdList : null;
				InstanceDungeonModel.Instance.InstanceEnterContentText.QuestRecallInstCtx = questRecallInstCtx;
				InstanceDungeonController.Instance.PrewarTeamFightRequest(startRecallResponse.EnterInstId, (list == null) ? new List<int>() : new List<int>(list), 0, 0, null, null);
			}, 0);
		}

		// Token: 0x06028D14 RID: 167188 RVA: 0x00B74778 File Offset: 0x00B72978
		[NullableContext(1)]
		private void OnInputDistribute(string input)
		{
			if (GameModeController.Instance.IsInInstance() && input == "功能菜单" && RecallQuestModel.Instance.IsInRecallInstance() && !LevelEventLockInputState.Instance.InputLimitEsc)
			{
				UiManager.Instance.OpenView(EUiViewName.RecallFunctionView, null, null);
			}
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x06028D15 RID: 167189 RVA: 0x00B747C7 File Offset: 0x00B729C7
		[Nullable(1)]
		public static RecallQuestController Instance
		{
			[NullableContext(1)]
			get
			{
				return RecallQuestController._Instance;
			}
		}

		// Token: 0x06028D16 RID: 167190 RVA: 0x00B747CE File Offset: 0x00B729CE
		[NullableContext(1)]
		public static RecallQuestController GetOrCreateInstance()
		{
			if (RecallQuestController._Instance == null)
			{
				RecallQuestController.CreateInstance();
			}
			return RecallQuestController._Instance;
		}

		// Token: 0x06028D17 RID: 167191 RVA: 0x00B747E2 File Offset: 0x00B729E2
		public static bool CreateInstance()
		{
			if (RecallQuestController._Instance != null)
			{
				return true;
			}
			RecallQuestController._Instance = new RecallQuestController();
			return true;
		}

		// Token: 0x06028D18 RID: 167192 RVA: 0x00B747F8 File Offset: 0x00B729F8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028D19 RID: 167193 RVA: 0x00B747FA File Offset: 0x00B729FA
		public static void ResetStaticDefaultValue()
		{
			RecallQuestController._Instance = null;
		}

		// Token: 0x06028D1A RID: 167194 RVA: 0x00B74802 File Offset: 0x00B72A02
		static RecallQuestController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RecallQuestController.CreateStaticDefaultValue), new Action(RecallQuestController.ResetStaticDefaultValue));
		}

		// Token: 0x04016336 RID: 90934
		private bool IsTrackSlotAttached;

		// Token: 0x04016337 RID: 90935
		private static RecallQuestController _Instance;
	}
}
