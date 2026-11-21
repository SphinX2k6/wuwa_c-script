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

// Token: 0x02001B76 RID: 7030
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class QuestTreeController : ControllerBase
{
	// Token: 0x17001A4F RID: 6735
	// (get) Token: 0x06011895 RID: 71829 RVA: 0x0052C3CC File Offset: 0x0052A5CC
	public bool IsGmSetAllNodeFinish
	{
		get
		{
			bool result = false;
			UKuroVariableFunctionLibrary.GetBoolValue("Gm_QuestTreeNode_Finish", ref result);
			return result;
		}
	}

	// Token: 0x06011896 RID: 71830 RVA: 0x0052C3E9 File Offset: 0x0052A5E9
	public void OpenMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestTreeMainView, null, null);
	}

	// Token: 0x06011897 RID: 71831 RVA: 0x0052C3FC File Offset: 0x0052A5FC
	public void OpenChapterView(int chapterId, int? id)
	{
		QuestTreeChapterViewParam param = new QuestTreeChapterViewParam
		{
			ChapterId = chapterId,
			NodeId = id
		};
		UiManager.Instance.OpenView(EUiViewName.QuestTreeChapterView, param, null);
	}

	// Token: 0x06011898 RID: 71832 RVA: 0x0052C430 File Offset: 0x0052A630
	public void OpenNodeDetailView(QuestTreeNodeData node)
	{
		QuestTreeNodeDetailView questTreeNodeDetailView = UiManager.Instance.GetViewByName(EUiViewName.QuestTreeNodeDetailView) as QuestTreeNodeDetailView;
		if (questTreeNodeDetailView != null)
		{
			questTreeNodeDetailView.ChangeData(node);
		}
		UiManager.Instance.OpenView(EUiViewName.QuestTreeNodeDetailView, node, null);
	}

	// Token: 0x06011899 RID: 71833 RVA: 0x0052C46D File Offset: 0x0052A66D
	public void CloseNodeDetailView()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestTreeNodeDetailView, null);
	}

	// Token: 0x0601189A RID: 71834 RVA: 0x0052C47F File Offset: 0x0052A67F
	public void OpenAvailableListView(List<QuestTreeNodeData> data)
	{
		UiManager.Instance.OpenView(EUiViewName.QuestTreeAvailableListView, data, null);
	}

	// Token: 0x0601189B RID: 71835 RVA: 0x0052C494 File Offset: 0x0052A694
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

	// Token: 0x0601189C RID: 71836 RVA: 0x0052C51A File Offset: 0x0052A71A
	public bool GotoNode(QuestTreeNodeData node)
	{
		return this.GotoNodeByQuestId(node.QuestId);
	}

	// Token: 0x0601189D RID: 71837 RVA: 0x0052C528 File Offset: 0x0052A728
	public bool GotoNodeNyQuestId(int questId)
	{
		return this.GotoNodeByQuestId(questId);
	}

	// Token: 0x0601189E RID: 71838 RVA: 0x0052C534 File Offset: 0x0052A734
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

	// Token: 0x0601189F RID: 71839 RVA: 0x0052C748 File Offset: 0x0052A948
	public void CancelTrackNode(QuestTreeNodeData node)
	{
		QuestNewController.Instance.RequestTrackQuest(node.QuestId, false, ERequestTrackOperate.Manual, ESetTrackReason.None, delegate
		{
			EventSystem.Instance.Emit<QuestTreeNodeData>(EEventName.QuestTreeNodeDataUpdate, node);
		});
	}

	// Token: 0x060118A0 RID: 71840 RVA: 0x0052C788 File Offset: 0x0052A988
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

	// Token: 0x060118A1 RID: 71841 RVA: 0x0052C984 File Offset: 0x0052AB84
	public int? TryAddMapMarkForNode(QuestTreeNodeData node)
	{
		return this.TryAddMapMarkForQuestId(node.QuestId);
	}

	// Token: 0x060118A2 RID: 71842 RVA: 0x0052C994 File Offset: 0x0052AB94
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

	// Token: 0x060118A3 RID: 71843 RVA: 0x0052CAF8 File Offset: 0x0052ACF8
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

	// Token: 0x060118A4 RID: 71844 RVA: 0x0052CC7C File Offset: 0x0052AE7C
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

	// Token: 0x060118A5 RID: 71845 RVA: 0x0052CCC7 File Offset: 0x0052AEC7
	public void GmSetAllNodeFinish()
	{
		UKuroVariableFunctionLibrary.RemoveBoolValue("Gm_QuestTreeNode_Finish");
		UKuroVariableFunctionLibrary.SetBoolValue("Gm_QuestTreeNode_Finish", true);
	}

	// Token: 0x060118A6 RID: 71846 RVA: 0x0052CCE0 File Offset: 0x0052AEE0
	public void GmResetAllNodeFinish()
	{
		UKuroVariableFunctionLibrary.RemoveBoolValue("Gm_QuestTreeNode_Finish");
		UKuroVariableFunctionLibrary.SetBoolValue("Gm_QuestTreeNode_Finish", false);
	}

	// Token: 0x060118A7 RID: 71847 RVA: 0x0052CCF9 File Offset: 0x0052AEF9
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<int, int>(EEventName.TsHandleQuestTreeNodeResponse, new Action<int, int>(this.OnTsHandleQuestTreeNodeResponse));
		Net.Instance.Register(ENotifyMessageId.QuestTreeInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestTreeInfoNotify));
		return true;
	}

	// Token: 0x060118A8 RID: 71848 RVA: 0x0052CD34 File Offset: 0x0052AF34
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.TsHandleQuestTreeNodeResponse, new Action<int, int>(this.OnTsHandleQuestTreeNodeResponse));
		Net.Instance.UnRegister(ENotifyMessageId.QuestTreeInfoNotify);
		return true;
	}

	// Token: 0x060118A9 RID: 71849 RVA: 0x0052CD64 File Offset: 0x0052AF64
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

	// Token: 0x060118AA RID: 71850 RVA: 0x0052CDE8 File Offset: 0x0052AFE8
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

	// Token: 0x060118AB RID: 71851 RVA: 0x0052CE98 File Offset: 0x0052B098
	public void ReportClickNode(QuestTreeNodeData node)
	{
		QuestTreeClickLogEvent questTreeClickLogEvent = new QuestTreeClickLogEvent();
		questTreeClickLogEvent.i_chapter_id = node.ChapterId;
		questTreeClickLogEvent.i_quest_id = node.QuestId;
		questTreeClickLogEvent.i_quest_status = (int)node.State;
		questTreeClickLogEvent.i_quest_type = node.Config.QuestType;
		LogReportController.Instance.LogReport(questTreeClickLogEvent);
	}

	// Token: 0x060118AC RID: 71852 RVA: 0x0052CEF0 File Offset: 0x0052B0F0
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

	// Token: 0x17001A50 RID: 6736
	// (get) Token: 0x060118AD RID: 71853 RVA: 0x0052CF4D File Offset: 0x0052B14D
	public static QuestTreeController Instance
	{
		get
		{
			return QuestTreeController._Instance;
		}
	}

	// Token: 0x060118AE RID: 71854 RVA: 0x0052CF54 File Offset: 0x0052B154
	public static QuestTreeController GetOrCreateInstance()
	{
		if (QuestTreeController._Instance == null)
		{
			QuestTreeController.CreateInstance();
		}
		return QuestTreeController._Instance;
	}

	// Token: 0x060118AF RID: 71855 RVA: 0x0052CF68 File Offset: 0x0052B168
	public static bool CreateInstance()
	{
		if (QuestTreeController._Instance != null)
		{
			return true;
		}
		QuestTreeController._Instance = new QuestTreeController();
		return true;
	}

	// Token: 0x060118B0 RID: 71856 RVA: 0x0052CF7E File Offset: 0x0052B17E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060118B1 RID: 71857 RVA: 0x0052CF80 File Offset: 0x0052B180
	public static void ResetStaticDefaultValue()
	{
		QuestTreeController._Instance = null;
	}

	// Token: 0x060118B2 RID: 71858 RVA: 0x0052CF88 File Offset: 0x0052B188
	static QuestTreeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeController.CreateStaticDefaultValue), new Action(QuestTreeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400997F RID: 39295
	[Nullable(2)]
	private static QuestTreeController _Instance;
}
