using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200268B RID: 9867
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class QuestTreeController : ControllerBase
{
	// Token: 0x17001A17 RID: 6679
	// (get) Token: 0x060143B3 RID: 82867 RVA: 0x0051D694 File Offset: 0x0051B894
	public bool IsGmSetAllNodeFinish
	{
		get
		{
			bool result = false;
			UKuroVariableFunctionLibrary.GetBoolValue("Gm_QuestTreeNode_Finish", ref result);
			return result;
		}
	}

	// Token: 0x060143B4 RID: 82868 RVA: 0x0051D6B1 File Offset: 0x0051B8B1
	public void OpenMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestTreeMainView, null, null);
	}

	// Token: 0x060143B5 RID: 82869 RVA: 0x0051D6C4 File Offset: 0x0051B8C4
	public void OpenChapterView(int chapterId, int? id)
	{
		QuestTreeChapterViewParam param = new QuestTreeChapterViewParam
		{
			ChapterId = chapterId,
			NodeId = id
		};
		UiManager.Instance.OpenView(EUiViewName.QuestTreeChapterView, param, null);
	}

	// Token: 0x060143B6 RID: 82870 RVA: 0x0051D6F8 File Offset: 0x0051B8F8
	public void OpenNodeDetailView(QuestTreeNodeData node)
	{
		QuestTreeNodeDetailView questTreeNodeDetailView = UiManager.Instance.GetViewByName(EUiViewName.QuestTreeNodeDetailView) as QuestTreeNodeDetailView;
		if (questTreeNodeDetailView != null)
		{
			questTreeNodeDetailView.ChangeData(node);
		}
		UiManager.Instance.OpenView(EUiViewName.QuestTreeNodeDetailView, node, null);
	}

	// Token: 0x060143B7 RID: 82871 RVA: 0x0051D735 File Offset: 0x0051B935
	public void CloseNodeDetailView()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestTreeNodeDetailView, null);
	}

	// Token: 0x060143B8 RID: 82872 RVA: 0x0051D747 File Offset: 0x0051B947
	public void OpenAvailableListView(List<QuestTreeNodeData> data)
	{
		UiManager.Instance.OpenView(EUiViewName.QuestTreeAvailableListView, data, null);
	}

	// Token: 0x060143B9 RID: 82873 RVA: 0x0051D75C File Offset: 0x0051B95C
	public void TrackNode(QuestTreeNodeData node, bool gotoAfterTrack = true)
	{
		int questId = node.QuestId;
		ESetTrackResult esetTrackResult = QuestNewController.Instance.RequestTrackQuest(questId, true, ERequestTrackOperate.Manual, ESetTrackReason.None, null);
		EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
		switch (esetTrackResult)
		{
		case ESetTrackResult.QuestNotExist:
			return;
		case ESetTrackResult.QuestIsSuspend:
			ScrollingTipsController.Instance.ShowTipsByTextId("Task_NoSwitch_Tips", Array.Empty<object>());
			return;
		case ESetTrackResult.QuestNotCanShowTrackExpression:
			ScrollingTipsController.Instance.ShowTipsById("FollowQuestStepGuide", Array.Empty<object>());
			return;
		case ESetTrackResult.FocusModeCanNotTrackOtherQuest:
			return;
		default:
			if (gotoAfterTrack)
			{
				this.GotoNode(node);
			}
			return;
		}
	}

	// Token: 0x060143BA RID: 82874 RVA: 0x0051D7E2 File Offset: 0x0051B9E2
	public bool GotoNode(QuestTreeNodeData node)
	{
		return this.GotoNodeByQuestId(node.QuestId);
	}

	// Token: 0x060143BB RID: 82875 RVA: 0x0051D7F0 File Offset: 0x0051B9F0
	public bool GotoNodeNyQuestId(int questId)
	{
		return this.GotoNodeByQuestId(questId);
	}

	// Token: 0x060143BC RID: 82876 RVA: 0x0051D7FC File Offset: 0x0051B9FC
	public bool GotoNodeByQuestId(int questId)
	{
		global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
		if (quest == null)
		{
			return false;
		}
		ITrackCustomBoard currentTrackCustomBoard = quest.GetCurrentTrackCustomBoard();
		if (((currentTrackCustomBoard != null) ? currentTrackCustomBoard.TrackPhoneMessageBoard : null) != null && QuestUtil.Instance.HandleTrackCustomBoard(currentTrackCustomBoard, false))
		{
			UiManager.Instance.CloseView(EUiViewName.QuestTreeNodeDetailView, null);
			return true;
		}
		List<BehaviorNodeBase> currentActiveChildQuestNodes = quest.GetCurrentActiveChildQuestNodes();
		if (currentActiveChildQuestNodes == null || currentActiveChildQuestNodes.Count == 0)
		{
			return false;
		}
		foreach (BehaviorNodeBase behaviorNodeBase in currentActiveChildQuestNodes)
		{
			QuestTreeController.<>c__DisplayClass10_0 CS$<>8__locals1 = new QuestTreeController.<>c__DisplayClass10_0();
			int? defaultMark = quest.GetDefaultMark(behaviorNodeBase.NodeId);
			bool flag = (defaultMark ?? 0) == 0;
			if (!flag)
			{
				if (MapUtil.GetDungeonsRelation(CreatureModel.Instance.GetInstanceId(), quest.DungeonId) == EDungeonRelationType.SameDungeon)
				{
					float trackDistanceByMarkId = MapUtil.GetTrackDistanceByMarkId(defaultMark.GetValueOrDefault());
					if (trackDistanceByMarkId == 0f)
					{
						continue;
					}
					int valueOrDefault = ConfigCommonParamById.GetIntConfig("QuestTrackNeedOpenWordMapDistance").GetValueOrDefault(50);
					if (trackDistanceByMarkId < (float)valueOrDefault)
					{
						UiManager.Instance.ResetToBattleView(null);
						return true;
					}
				}
				CS$<>8__locals1.param = new WorldMapViewOpenParams();
				CS$<>8__locals1.param.MarkType = EMarkType.Quest;
				CS$<>8__locals1.param.MarkId = defaultMark;
				CS$<>8__locals1.param.IsNotFocusTween = new bool?(true);
				CS$<>8__locals1.param.OpenFogId = new int?(0);
				UiLayer.Instance.SetShowMaskLayer("QuestNodeGoto", true);
				if (UiManager.Instance.GetViewByName(EUiViewName.WorldMapView) != null)
				{
					UiManager.Instance.CloseViewAsync(EUiViewName.WorldMapView).ContinueWith(delegate(bool _)
					{
						base.<GotoNodeByQuestId>g__OpenWorldMapView|0();
					});
				}
				else
				{
					CS$<>8__locals1.<GotoNodeByQuestId>g__OpenWorldMapView|0();
				}
				UiManager.Instance.CloseView(EUiViewName.QuestTreeNodeDetailView, null);
				return true;
			}
		}
		ScrollingTipsController.Instance.ShowTipsById("FollowQuestStepGuide", Array.Empty<object>());
		return false;
	}

	// Token: 0x060143BD RID: 82877 RVA: 0x0051DA10 File Offset: 0x0051BC10
	public void CancelTrackNode(QuestTreeNodeData node)
	{
		QuestNewController.Instance.RequestTrackQuest(node.QuestId, false, ERequestTrackOperate.Manual, ESetTrackReason.None, delegate
		{
			EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
		});
	}

	// Token: 0x060143BE RID: 82878 RVA: 0x0051DA50 File Offset: 0x0051BC50
	public void TrackOrGotoNode(QuestTreeNodeData node)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		int questId = node.QuestId;
		global::Quest quest = instance.GetQuest(questId);
		if (quest == null)
		{
			return;
		}
		switch (instance.GetQuestSpecialState(quest))
		{
		case EQuestSpecialState.LockByLackResource:
			QuestNewController.Instance.SetVideoResourceDownloadTriggerId(quest.Id);
			SubPackageDownLoadModel.Instance.OpenSubPackageByQuest(quest.Id);
			return;
		case EQuestSpecialState.ResourceReadyButLock:
			QuestNewController.Instance.ConfirmQuestResourceRequest(quest.Id, delegate
			{
				EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
			});
			return;
		case EQuestSpecialState.Suspend:
		{
			if (instance.IsInFocusMode() && !instance.IsInFocusOnQuest(questId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FocusModeSwitchToCommonQuest);
				Action <>9__6;
				Action <>9__5;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					int curFocusQuestId = QuestNewModel.Instance.GetCurFocusQuestId();
					QuestNewController instance2 = QuestNewController.Instance;
					int questId2 = curFocusQuestId;
					Action callback;
					if ((callback = <>9__5) == null)
					{
						callback = (<>9__5 = delegate()
						{
							GeneralLogicTreeController instance3 = GeneralLogicTreeController.Instance;
							long valueOrDefault = quest.TreeId.GetValueOrDefault();
							Action callback2;
							if ((callback2 = <>9__6) == null)
							{
								callback2 = (<>9__6 = delegate()
								{
									this.TrackNode(node, true);
								});
							}
							instance3.RequestForcedOccupation(valueOrDefault, callback2);
						});
					}
					instance2.RequestCancelQuestFocusMode(questId2, callback);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuestForceOccupy);
			Action <>9__8;
			confirmBoxDataNew2.FunctionMap[2] = delegate()
			{
				GeneralLogicTreeController instance2 = GeneralLogicTreeController.Instance;
				long valueOrDefault = quest.TreeId.GetValueOrDefault();
				Action callback;
				if ((callback = <>9__8) == null)
				{
					callback = (<>9__8 = delegate()
					{
						this.TrackNode(node, true);
					});
				}
				instance2.RequestForcedOccupation(valueOrDefault, callback);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		case EQuestSpecialState.LockByFocusMode:
		{
			ConfirmBoxDataNew confirmBoxDataNew3 = new ConfirmBoxDataNew(EConfirmBoxConfigId.FocusModeSwitchToCommonQuest);
			Action <>9__10;
			Action <>9__9;
			confirmBoxDataNew3.FunctionMap[2] = delegate()
			{
				int curFocusQuestId = QuestNewModel.Instance.GetCurFocusQuestId();
				QuestNewController instance2 = QuestNewController.Instance;
				int questId2 = curFocusQuestId;
				Action callback;
				if ((callback = <>9__9) == null)
				{
					callback = (<>9__9 = delegate()
					{
						QuestNewController instance3 = QuestNewController.Instance;
						int id = quest.Id;
						Action callback2;
						if ((callback2 = <>9__10) == null)
						{
							callback2 = (<>9__10 = delegate()
							{
								this.GotoNode(node);
								EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
							});
						}
						instance3.RequestAcceptFocusWaitQuest(id, callback2);
					});
				}
				instance2.RequestCancelQuestFocusMode(questId2, callback);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew3);
			return;
		}
		case EQuestSpecialState.NotInFocusModeButLock:
			QuestNewController.Instance.RequestAcceptFocusWaitQuest(quest.Id, delegate
			{
				EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
			});
			return;
		case EQuestSpecialState.FocusOtherQuest:
		{
			ConfirmBoxDataNew confirmBoxDataNew4 = new ConfirmBoxDataNew(EConfirmBoxConfigId.FocusModeSwitchConfirm);
			Action<bool> <>9__11;
			confirmBoxDataNew4.FunctionMap[2] = delegate()
			{
				QuestNewController instance2 = QuestNewController.Instance;
				int id = quest.Id;
				Action<bool> callback;
				if ((callback = <>9__11) == null)
				{
					callback = (<>9__11 = delegate(bool _)
					{
						this.TrackNode(node, true);
					});
				}
				instance2.RequestSetQuestFocusMode(id, callback);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew4);
			return;
		}
		}
		if (node.IsTracking)
		{
			this.GotoNode(node);
			return;
		}
		this.TrackNode(node, true);
	}

	// Token: 0x060143BF RID: 82879 RVA: 0x0051DC4C File Offset: 0x0051BE4C
	public int? TryAddMapMarkForNode(QuestTreeNodeData node)
	{
		return this.TryAddMapMarkForQuestId(node.QuestId);
	}

	// Token: 0x060143C0 RID: 82880 RVA: 0x0051DC5C File Offset: 0x0051BE5C
	public int? TryAddMapMarkForQuestId(int questId)
	{
		IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(questId);
		if (questConfig == null)
		{
			return null;
		}
		IAddInteractOption addInteractOption = questConfig.AddInteractOption;
		QuestType? questTypeConfig = QuestNewConfig.Instance.GetQuestTypeConfig((int)questConfig.Type);
		if (addInteractOption == null || questTypeConfig == null)
		{
			return null;
		}
		int? questMarkId = QuestUtil.Instance.GetQuestMarkId(questTypeConfig.Value.MainId, new int?(questId));
		bool flag = (questMarkId ?? 0) == 0;
		if (flag)
		{
			return null;
		}
		int num;
		if (QuestNewModel.Instance.QuestIdToExternalAddedQuestMarkId.TryGetValue(questId, out num) && num != 0)
		{
			return new int?(num);
		}
		QuestMarkCreateInfo info = new QuestMarkCreateInfo(new QuestMarkCreateParams
		{
			TrackTarget = addInteractOption.EntityId,
			MarkConfigId = questMarkId.Value,
			MarkType = EMarkType.Quest,
			TrackSource = new ETrackSource?(ETrackSource.Quest),
			TreeId = (long)questId,
			NodeId = 0,
			EntityConfigId = new int?(addInteractOption.EntityId),
			MapAndDungeonInfo = new MapAndDungeonInfo
			{
				DungeonId = new int?(questConfig.DungeonId)
			}
		});
		int value = MapModel.Instance.CreateMapMark(info);
		QuestNewModel.Instance.QuestIdToExternalAddedQuestMarkId[questId] = value;
		return new int?(value);
	}

	// Token: 0x060143C1 RID: 82881 RVA: 0x0051DDC0 File Offset: 0x0051BFC0
	public void JumpToQuest(int questId)
	{
		QuestTreeNodeData nodeDataFromQuestId = QuestTreeModel.Instance.GetNodeDataFromQuestId(questId);
		int? num2;
		int num3;
		if (nodeDataFromQuestId == null)
		{
			if (!this.GotoNodeByQuestId(questId))
			{
				UiManager.Instance.CloseView(EUiViewName.QuestTreeNodeDetailView, null);
				global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
				int? num = null;
				if (quest != null && quest.GetCanAcceptMapMarkId() > 0)
				{
					num = new int?(quest.GetCanAcceptMapMarkId());
				}
				num2 = num;
				if (num2 == null)
				{
					num = this.TryAddMapMarkForQuestId(questId);
				}
				WorldMapViewOpenParams worldMapViewOpenParams = new WorldMapViewOpenParams();
				num2 = num;
				num3 = 0;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					worldMapViewOpenParams.MarkType = EMarkType.Quest;
					worldMapViewOpenParams.MarkId = num;
				}
				else
				{
					worldMapViewOpenParams.MarkType = EMarkType.None;
					worldMapViewOpenParams.MarkId = new int?(0);
				}
				worldMapViewOpenParams.OpenFogId = new int?(0);
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, worldMapViewOpenParams, delegate(bool isSuccess, int _)
				{
					if (isSuccess)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("QuestTree_NotTreeNode_Unavailable", Array.Empty<object>());
					}
				});
			}
			return;
		}
		if (nodeDataFromQuestId.State == EQuestTreeNodeState.None)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("QuestTree_NotTreeNode_Unavailable", Array.Empty<object>());
			return;
		}
		QuestTreeNodeData selectedData = QuestTreeModel.Instance.ViewModelChapter.SelectedData;
		num2 = ((selectedData != null) ? new int?(selectedData.ChapterId) : null);
		num3 = nodeDataFromQuestId.ChapterId;
		if (num2.GetValueOrDefault() == num3 & num2 != null)
		{
			QuestTreeModel.Instance.ViewModelChapter.SelectData(nodeDataFromQuestId);
			this.OpenNodeDetailView(nodeDataFromQuestId);
			return;
		}
		this.JumpToQuestOutOfThisChapter(nodeDataFromQuestId).Forget();
	}

	// Token: 0x060143C2 RID: 82882 RVA: 0x0051DF44 File Offset: 0x0051C144
	private UniTask JumpToQuestOutOfThisChapter(QuestTreeNodeData node)
	{
		QuestTreeController.<JumpToQuestOutOfThisChapter>d__16 <JumpToQuestOutOfThisChapter>d__;
		<JumpToQuestOutOfThisChapter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<JumpToQuestOutOfThisChapter>d__.<>4__this = this;
		<JumpToQuestOutOfThisChapter>d__.node = node;
		<JumpToQuestOutOfThisChapter>d__.<>1__state = -1;
		<JumpToQuestOutOfThisChapter>d__.<>t__builder.Start<QuestTreeController.<JumpToQuestOutOfThisChapter>d__16>(ref <JumpToQuestOutOfThisChapter>d__);
		return <JumpToQuestOutOfThisChapter>d__.<>t__builder.Task;
	}

	// Token: 0x060143C3 RID: 82883 RVA: 0x0051DF8F File Offset: 0x0051C18F
	public void GmSetAllNodeFinish()
	{
		UKuroVariableFunctionLibrary.RemoveBoolValue("Gm_QuestTreeNode_Finish");
		UKuroVariableFunctionLibrary.SetBoolValue("Gm_QuestTreeNode_Finish", true);
	}

	// Token: 0x060143C4 RID: 82884 RVA: 0x0051DFA8 File Offset: 0x0051C1A8
	public void GmResetAllNodeFinish()
	{
		UKuroVariableFunctionLibrary.RemoveBoolValue("Gm_QuestTreeNode_Finish");
		UKuroVariableFunctionLibrary.SetBoolValue("Gm_QuestTreeNode_Finish", false);
	}

	// Token: 0x060143C5 RID: 82885 RVA: 0x0051DFC1 File Offset: 0x0051C1C1
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<int, int>(EEventName.TsHandleQuestTreeNodeResponse, new Action<int, int>(this.OnTsHandleQuestTreeNodeResponse));
		Net.Instance.Register(ENotifyMessageId.QuestTreeInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestTreeInfoNotify));
		return true;
	}

	// Token: 0x060143C6 RID: 82886 RVA: 0x0051DFFC File Offset: 0x0051C1FC
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.TsHandleQuestTreeNodeResponse, new Action<int, int>(this.OnTsHandleQuestTreeNodeResponse));
		Net.Instance.UnRegister(ENotifyMessageId.QuestTreeInfoNotify);
		return true;
	}

	// Token: 0x060143C7 RID: 82887 RVA: 0x0051E02C File Offset: 0x0051C22C
	[NullableContext(2)]
	private void OnQuestTreeInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestTreeInfoNotify questTreeInfoNotify = (QuestTreeInfoNotify)msg;
		QuestTreeModel.Instance.UpdateServerUnlockInfo(questTreeInfoNotify.UnlockChapterIds, questTreeInfoNotify.UnlockChapterNodeIds);
		foreach (int nodeId in questTreeInfoNotify.UnlockChapterNodeIds)
		{
			QuestTreeNodeData nodeDataFromNodeId = QuestTreeModel.Instance.GetNodeDataFromNodeId(nodeId);
			if (nodeDataFromNodeId != null)
			{
				EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, nodeDataFromNodeId);
			}
		}
	}

	// Token: 0x060143C8 RID: 82888 RVA: 0x0051E0B0 File Offset: 0x0051C2B0
	private void OnTsHandleQuestTreeNodeResponse(int type, int nodeId)
	{
		QuestTreeNodeData nodeDataFromNodeId = QuestTreeModel.Instance.GetNodeDataFromNodeId(nodeId);
		if (nodeDataFromNodeId == null)
		{
			return;
		}
		switch (type)
		{
		case 1:
			QuestNewModel.Instance.SetQuestTrackState(nodeDataFromNodeId.QuestId, true, ESetTrackReason.None);
			EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, nodeDataFromNodeId);
			return;
		case 2:
			EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, nodeDataFromNodeId);
			return;
		case 3:
		{
			global::Quest quest = QuestNewModel.Instance.GetQuest(nodeDataFromNodeId.QuestId);
			if (quest != null && quest.LockByFocusMode)
			{
				QuestNewModel.Instance.RemovePendingAcceptQuestOnFocusMode(nodeDataFromNodeId.QuestId);
				return;
			}
			break;
		}
		case 4:
			QuestNewModel.Instance.RemoveLackResourceQuest(nodeDataFromNodeId.QuestId);
			break;
		default:
			return;
		}
	}

	// Token: 0x060143C9 RID: 82889 RVA: 0x0051E160 File Offset: 0x0051C360
	public void ReportClickNode(QuestTreeNodeData node)
	{
		QuestTreeClickLogEvent questTreeClickLogEvent = new QuestTreeClickLogEvent();
		questTreeClickLogEvent.i_chapter_id = node.ChapterId;
		questTreeClickLogEvent.i_quest_id = node.QuestId;
		questTreeClickLogEvent.i_quest_status = (int)node.State;
		questTreeClickLogEvent.i_quest_type = node.Config.QuestType;
		LogReportController.Instance.LogReport(questTreeClickLogEvent);
	}

	// Token: 0x060143CA RID: 82890 RVA: 0x0051E1B8 File Offset: 0x0051C3B8
	public void ReportJump(QuestTreeNodeData node, EQuestTreeLogReportJumpMotion motion)
	{
		QuestTreeJumpLogEvent questTreeJumpLogEvent = new QuestTreeJumpLogEvent();
		questTreeJumpLogEvent.i_chapter_id = node.ChapterId;
		questTreeJumpLogEvent.i_quest_id = node.QuestId;
		questTreeJumpLogEvent.i_quest_status = (int)node.State;
		questTreeJumpLogEvent.i_quest_type = node.Config.QuestType;
		questTreeJumpLogEvent.i_motion = (int)motion;
		LogReportController.Instance.LogReport(questTreeJumpLogEvent);
	}

	// Token: 0x17001A18 RID: 6680
	// (get) Token: 0x060143CB RID: 82891 RVA: 0x0051E215 File Offset: 0x0051C415
	public static QuestTreeController Instance
	{
		get
		{
			return QuestTreeController._Instance;
		}
	}

	// Token: 0x060143CC RID: 82892 RVA: 0x0051E21C File Offset: 0x0051C41C
	public static QuestTreeController GetOrCreateInstance()
	{
		if (QuestTreeController._Instance == null)
		{
			QuestTreeController.CreateInstance();
		}
		return QuestTreeController._Instance;
	}

	// Token: 0x060143CD RID: 82893 RVA: 0x0051E230 File Offset: 0x0051C430
	public static bool CreateInstance()
	{
		if (QuestTreeController._Instance != null)
		{
			return true;
		}
		QuestTreeController._Instance = new QuestTreeController();
		return true;
	}

	// Token: 0x060143CE RID: 82894 RVA: 0x0051E246 File Offset: 0x0051C446
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060143CF RID: 82895 RVA: 0x0051E248 File Offset: 0x0051C448
	public static void ResetStaticDefaultValue()
	{
		QuestTreeController._Instance = null;
	}

	// Token: 0x060143D0 RID: 82896 RVA: 0x0051E250 File Offset: 0x0051C450
	static QuestTreeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeController.CreateStaticDefaultValue), new Action(QuestTreeController.ResetStaticDefaultValue));
	}

	// Token: 0x04009827 RID: 38951
	[Nullable(2)]
	private static QuestTreeController _Instance;
}
