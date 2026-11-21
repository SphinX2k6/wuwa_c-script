using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036AF RID: 13999
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapController : UiControllerBase
	{
		// Token: 0x060245B7 RID: 148919 RVA: 0x00A48138 File Offset: 0x00A46338
		protected override bool OnInit()
		{
			InputManager.Instance.RegisterOpenViewFunc(EUiViewName.WorldMapView, new Action(this.RegisterOpenView));
			return true;
		}

		// Token: 0x060245B8 RID: 148920 RVA: 0x00A48156 File Offset: 0x00A46356
		private void RegisterOpenView()
		{
			this.OpenView(EOpenMapType.HotKey, true, null, null);
		}

		// Token: 0x060245B9 RID: 148921 RVA: 0x00A48162 File Offset: 0x00A46362
		protected override bool OnLeaveLevel()
		{
			if (this.CheckStreamingCompletedTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.CheckStreamingCompletedTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckStreamingCompletedTimerId);
			}
			return true;
		}

		// Token: 0x060245BA RID: 148922 RVA: 0x00A48190 File Offset: 0x00A46390
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenFunctionView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseFunctionView));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.CsNotifyTsOpenWorldMapView, new Action<EMarkType, int, bool>(this.OnCsNotifyOpenWorldMapView));
		}

		// Token: 0x060245BB RID: 148923 RVA: 0x00A48208 File Offset: 0x00A46408
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenFunctionView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseFunctionView));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.CsNotifyTsOpenWorldMapView, new Action<EMarkType, int, bool>(this.OnCsNotifyOpenWorldMapView));
		}

		// Token: 0x060245BC RID: 148924 RVA: 0x00A4827E File Offset: 0x00A4647E
		private void OnOpenFunctionView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FunctionOpenView)
			{
				return;
			}
			this.OpenFuncList = FunctionModel.Instance.GetNewOpenFunctionIdList();
		}

		// Token: 0x060245BD RID: 148925 RVA: 0x00A482A0 File Offset: 0x00A464A0
		private void OnCloseFunctionView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FunctionOpenView)
			{
				return;
			}
			if (this.OpenFuncList == null)
			{
				return;
			}
			MapMarkRelativeSubType? mapMarkRelativeSubType = null;
			foreach (int functionType in this.OpenFuncList)
			{
				mapMarkRelativeSubType = MapConfig.Instance.GetMapMarkFuncTypeConfigByFuncId(functionType);
				if (mapMarkRelativeSubType != null)
				{
					break;
				}
			}
			if (mapMarkRelativeSubType != null)
			{
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkType = EMarkType.None,
					MarkId = new int?(0),
					StartWorldPosition = Vector2D.Create((double)mapMarkRelativeSubType.Value.Position.Value.X, (double)mapMarkRelativeSubType.Value.Position.Value.Y),
					StartScale = new float?(mapMarkRelativeSubType.Value.Scale),
					OpenFogId = new int?(0)
				};
				if (!LoadingModel.Instance.IsLoading)
				{
					this.OpenView(EOpenMapType.Other, false, data, null);
					MapLifeEventTriggerParam<MapLifeEventTriggerLevelPlayParam> value = new MapLifeEventTriggerParam<MapLifeEventTriggerLevelPlayParam>
					{
						State = true,
						Data = new MapLifeEventTriggerLevelPlayParam
						{
							RelativeType = EMarkRelativeType.LevelPlay,
							RelativeSubType = mapMarkRelativeSubType.Value.Id
						}
					};
					if (MapModel.Instance.MapLifeEventListenerTriggerMap != null)
					{
						MapModel.Instance.MapLifeEventListenerTriggerMap[EMapLifeEventListenerType.SceneGameplayUnlock] = value;
					}
				}
			}
		}

		// Token: 0x060245BE RID: 148926 RVA: 0x00A4842C File Offset: 0x00A4662C
		[NullableContext(2)]
		public void TryTeleport(int teleportId, TOnTelSuccessCallBack successAction = null)
		{
			if (!TeleportModel.Instance.AllowTeleportByUi)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleTransmitLimit", Array.Empty<object>());
				return;
			}
			if (this.TryRecallTeleport(teleportId, successAction))
			{
				return;
			}
			if (MapModel.Instance.IsInstanceTeleportUnlock(teleportId))
			{
				this.TryEntityTeleport(teleportId, successAction);
				return;
			}
			Teleporter? teleportConfigById = MapConfig.Instance.GetTeleportConfigById(teleportId);
			if (teleportConfigById == null)
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统]传送失败,找不到传送配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("teleportId", teleportId);
				MapLogger.Error(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(teleportConfigById.Value.TeleportEntityConfigId, teleportConfigById.Value.MapId, false);
			if (QuestNewController.Instance.IsTrackPositionOutFailRange(entityPosition))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TeleportOutOfQuestRangeConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					TeleportMisc.SendTeleportTransferRequest(teleportId);
					TOnTelSuccessCallBack successAction3 = successAction;
					if (successAction3 == null)
					{
						return;
					}
					successAction3();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			TeleportMisc.SendTeleportTransferRequest(teleportId);
			TOnTelSuccessCallBack successAction2 = successAction;
			if (successAction2 == null)
			{
				return;
			}
			successAction2();
		}

		// Token: 0x060245BF RID: 148927 RVA: 0x00A48574 File Offset: 0x00A46774
		[NullableContext(2)]
		public void TryEntityTeleport(int teleportId, TOnTelSuccessCallBack successAction = null)
		{
			if (!TeleportModel.Instance.AllowTeleportByUi)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleTransmitLimit", Array.Empty<object>());
				return;
			}
			if (this.TryRecallTeleport(teleportId, successAction))
			{
				return;
			}
			if (!MapModel.Instance.IsInstanceTeleportUnlock(teleportId))
			{
				return;
			}
			TeleportMisc.SendTeleportTransferRequestByEntityId(teleportId);
			if (successAction != null)
			{
				successAction();
			}
		}

		// Token: 0x060245C0 RID: 148928 RVA: 0x00A485CC File Offset: 0x00A467CC
		[NullableContext(2)]
		private bool TryRecallTeleport(int markId, TOnTelSuccessCallBack successAction)
		{
			MapMark? mapMark;
			if (MapConfig.Instance.GetConfigMark(markId) == null || mapMark.GetValueOrDefault().MarkFuncType != 1)
			{
				return false;
			}
			RecallQuestController.Instance.RequestRecallTeleportToMarkId(markId);
			if (successAction != null)
			{
				successAction();
			}
			return true;
		}

		// Token: 0x060245C1 RID: 148929 RVA: 0x00A48620 File Offset: 0x00A46820
		[NullableContext(2)]
		public void TryTeleportByEntityId(int instEntityTeleportId, TOnTelSuccessCallBack successAction = null)
		{
			if (!TeleportModel.Instance.AllowTeleportByUi)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleTransmitLimit", Array.Empty<object>());
				return;
			}
			if (!MapConfig.Instance.GetIsInstanceTeleporterExist(instEntityTeleportId))
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统]传送失败,找不到传送配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstEntityTeleportId", instEntityTeleportId);
				MapLogger.Error(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (MapConfig.Instance.GetInstEntityTeleportConfigById(instEntityTeleportId) == null)
			{
				return;
			}
			TeleportMisc.SendTeleportTransferRequestByEntityId(instEntityTeleportId);
			if (successAction != null)
			{
				successAction();
			}
		}

		// Token: 0x060245C2 RID: 148930 RVA: 0x00A486A8 File Offset: 0x00A468A8
		public void MapOpenPush(int openType)
		{
			MapOpenPush message = new MapOpenPush
			{
				OpenType = (MapOpenType)openType
			};
			Net.Instance.Send(EPushMessageId.MapOpenPush, message);
		}

		// Token: 0x060245C3 RID: 148931 RVA: 0x00A486D4 File Offset: 0x00A468D4
		[NullableContext(2)]
		public void OpenView(EOpenMapType openType, bool isBattleViewOpen, object data = null, Action<bool, int> callback = null)
		{
			WorldMapController.<>c__DisplayClass14_0 CS$<>8__locals1 = new WorldMapController.<>c__DisplayClass14_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.openType = openType;
			CS$<>8__locals1.callback = callback;
			if (WorldMapModel.Instance.PendingOpenWorldMapQuestId != null)
			{
				if (EventSystem.Instance.Has(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged)))
				{
					EventSystem.Instance.Remove(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged));
				}
				WorldMapModel.Instance.PendingOpenWorldMapQuestId = null;
			}
			WorldMapModel.Instance.IsBattleViewOpen = isBattleViewOpen;
			if (UiManager.Instance.IsViewOpen(EUiViewName.WorldMapView) || UiManager.Instance.IsViewHide(EUiViewName.WorldMapView))
			{
				UiManager.Instance.CloseViewAsync(EUiViewName.WorldMapView).ContinueWith(delegate(bool _)
				{
					base.<OpenView>g__OpenWorldMapViewFunc|0();
				});
				return;
			}
			CS$<>8__locals1.<OpenView>g__OpenWorldMapViewFunc|0();
		}

		// Token: 0x060245C4 RID: 148932 RVA: 0x00A487B4 File Offset: 0x00A469B4
		public void FocalMarkItem(EMarkType markType, int markId)
		{
			WorldMapModel instance = WorldMapModel.Instance;
			EMarkType? currentFocalMarkType = instance.CurrentFocalMarkType;
			int? currentFocalMarkId = instance.CurrentFocalMarkId;
			EMarkType? emarkType = currentFocalMarkType;
			if (emarkType.GetValueOrDefault() == markType & emarkType != null)
			{
				int? num = currentFocalMarkId;
				if (num.GetValueOrDefault() == markId & num != null)
				{
					goto IL_88;
				}
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.CommonRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.CommonRewardView, null);
			}
			IL_88:
			instance.CurrentFocalMarkType = new EMarkType?(markType);
			instance.CurrentFocalMarkId = new int?(markId);
			if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
			{
				UiManager.Instance.CloseAllPopView();
				EventSystem.Instance.Emit(EEventName.CloseAllExtraUiFromMap);
				EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnWorldMapTrackMarkItem, markType, markId);
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkType = markType,
				MarkId = new int?(markId),
				OpenFogId = new int?(0)
			};
			this.OpenView(EOpenMapType.Mouse, false, data, delegate(bool success, int viewId)
			{
				if (success)
				{
					UiManager.Instance.CloseAllPopView();
				}
			});
		}

		// Token: 0x060245C5 RID: 148933 RVA: 0x00A488ED File Offset: 0x00A46AED
		public void ClearFocalMarkItem()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			instance.CurrentFocalMarkType = null;
			instance.CurrentFocalMarkId = null;
		}

		// Token: 0x060245C6 RID: 148934 RVA: 0x00A4890C File Offset: 0x00A46B0C
		public void CloseWorldMap()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
			{
				EventSystem.Instance.Emit(EEventName.DestroyAllUiCameraAnimationHandles);
				UiManager.Instance.ResetToBattleView(null);
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.FunctionView))
			{
				UiManager.Instance.CloseView(EUiViewName.FunctionView, null);
			}
		}

		// Token: 0x060245C7 RID: 148935 RVA: 0x00A48967 File Offset: 0x00A46B67
		protected override bool OnClear()
		{
			if (this.CheckStreamingCompletedTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckStreamingCompletedTimerId);
				this.CheckStreamingCompletedTimerId = null;
			}
			return true;
		}

		// Token: 0x060245C8 RID: 148936 RVA: 0x00A4898A File Offset: 0x00A46B8A
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.WorldMapView, new Func<EUiViewName, object, bool>(this.CanOpenView), "WorldMapController.CanOpenView");
		}

		// Token: 0x060245C9 RID: 148937 RVA: 0x00A489AC File Offset: 0x00A46BAC
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.WorldMapView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		}

		// Token: 0x060245CA RID: 148938 RVA: 0x00A489CC File Offset: 0x00A46BCC
		private bool CanOpenView(EUiViewName viewName, object param)
		{
			if (WorldMapModel.Instance.LevelEventDisableFlag)
			{
				GenericPromptController.Instance.ShowPromptByCode("DisableMapView", Array.Empty<object>());
				return false;
			}
			if (!FunctionModel.Instance.IsOpen(10015))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomLock", Array.Empty<object>());
				return false;
			}
			if (FunctionModel.Instance.IsLockByBehaviorTree(10015))
			{
				ScrollingTipsController.Instance.ShowTipsById("UnableSystem", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x060245CB RID: 148939 RVA: 0x00A48A4A File Offset: 0x00A46C4A
		private void OnWorldDone()
		{
			this.CheckAndRequestLastBigSceneInfo();
		}

		// Token: 0x060245CC RID: 148940 RVA: 0x00A48A54 File Offset: 0x00A46C54
		public void FocusNearestTargetOnWorldMap(QueryNearestTeleporterResult result)
		{
			MapTeleportQueryInfo info = result.Info;
			int value = (info != null) ? info.MarkId : result.TargetMarkId;
			MapTeleportQueryInfo info2 = result.Info;
			EMarkType markType = (info2 != null) ? info2.MarkType : result.TargetMarkType;
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(value),
				MarkType = markType
			};
			this.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x060245CD RID: 148941 RVA: 0x00A48AB4 File Offset: 0x00A46CB4
		private void CheckAndRequestLastBigSceneInfo()
		{
			ILastBigSceneMiniMapInfo lastBigSceneMiniMapInfo = WorldMapModel.Instance.LastBigSceneMiniMapInfo;
			int num = (lastBigSceneMiniMapInfo != null) ? lastBigSceneMiniMapInfo.InstanceDungeonId : 0;
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (MapModel.Instance.CurrentInWorld)
			{
				WorldMapModel.Instance.LastBigSceneMiniMapInfo = null;
				return;
			}
			if (WorldMapModel.Instance.InstIsType(instanceId, InstanceType.BigWorldInstance, EDungeonSubType.WorldDungeon))
			{
				WorldMapModel.Instance.LastBigSceneMiniMapInfo = null;
				return;
			}
			if (num != instanceId)
			{
				this.RequestLastBigSceneMiniMapInfo(instanceId);
			}
		}

		// Token: 0x060245CE RID: 148942 RVA: 0x00A48B24 File Offset: 0x00A46D24
		private void RequestLastBigSceneMiniMapInfo(int dungeonId)
		{
			LastBigSceneMiniMapInfoRequest message = LastBigSceneMiniMapInfoRequest.Create();
			Net.Instance.Call(ERequestMessageId.LastBigSceneMiniMapInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				LastBigSceneMiniMapInfoResponse lastBigSceneMiniMapInfoResponse = (LastBigSceneMiniMapInfoResponse)msg;
				if (lastBigSceneMiniMapInfoResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(lastBigSceneMiniMapInfoResponse.Code, 20403, null, true, true);
				}
				LastBigSceneMiniMapInfo lastBigSceneMiniMapInfo = new LastBigSceneMiniMapInfo
				{
					InstanceDungeonId = dungeonId,
					Position = global::Vector.Create((double)lastBigSceneMiniMapInfoResponse.PosX, (double)lastBigSceneMiniMapInfoResponse.PosY, (double)lastBigSceneMiniMapInfoResponse.PosZ)
				};
				WorldMapModel.Instance.LastBigSceneMiniMapInfo = lastBigSceneMiniMapInfo;
			}, 0);
		}

		// Token: 0x060245CF RID: 148943 RVA: 0x00A48B64 File Offset: 0x00A46D64
		public void SkipToExploreAreaDetailView(int areaId, EExploreType? exploreType = null)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
			{
				EventSystem.Instance.Emit<int, EExploreType?>(EEventName.OpenExploreAreaDetailViewFromMap, areaId, exploreType);
				return;
			}
			WorldMapViewOpenParams worldMapViewOpenParams = new WorldMapViewOpenParams();
			worldMapViewOpenParams.MarkId = null;
			worldMapViewOpenParams.MarkType = EMarkType.None;
			WorldMapViewOpenParams worldMapViewOpenParams2 = worldMapViewOpenParams;
			int[] array = new int[2];
			array[0] = areaId;
			int num = 1;
			EExploreType? eexploreType = exploreType;
			array[num] = ((eexploreType != null) ? new int?((int)eexploreType.GetValueOrDefault()) : null).GetValueOrDefault();
			worldMapViewOpenParams2.SkipToExploreAreaDetailView = array;
			WorldMapViewOpenParams data = worldMapViewOpenParams;
			this.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x00A48BFC File Offset: 0x00A46DFC
		public void StartListenChildQuestNodeStatusChangedAndOpenWorldMap(int questId)
		{
			WorldMapModel.Instance.PendingOpenWorldMapQuestId = new int?(questId);
			if (!EventSystem.Instance.Has(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged)))
			{
				EventSystem.Instance.Add<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged));
			}
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x00A48C54 File Offset: 0x00A46E54
		private void OnChildQuestNodeStatusChanged(GeneralContext context, ChildQuestNodeStatus _2, ChildQuestNodeStatus _3)
		{
			int? pendingOpenWorldMapQuestId = WorldMapModel.Instance.PendingOpenWorldMapQuestId;
			if (pendingOpenWorldMapQuestId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "【疑难杂症】地图聚焦行为->任务id被提前清空了";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", pendingOpenWorldMapQuestId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				EventSystem.Instance.Remove(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged));
				return;
			}
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null)
			{
				int treeConfigId = generalLogicTreeContext.TreeConfigId;
				int? pendingOpenWorldMapQuestId2 = WorldMapModel.Instance.PendingOpenWorldMapQuestId;
				if (treeConfigId == pendingOpenWorldMapQuestId2.GetValueOrDefault() & pendingOpenWorldMapQuestId2 != null)
				{
					EventSystem.Instance.Remove(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged));
					int questIdValue = WorldMapModel.Instance.PendingOpenWorldMapQuestId.Value;
					WorldMapModel.Instance.PendingOpenWorldMapQuestId = null;
					QuestMarkCreateInfo markByQuestId = MapModel.Instance.GetMarkByQuestId(questIdValue);
					if (markByQuestId == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.LevelEvent;
						ELogAuthor author2 = ELogAuthor.LYX;
						string message2 = "地图聚焦行为失败->任务仍没有创建标记";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("questId", questIdValue);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return;
					}
					WorldMapViewOpenParams data = new WorldMapViewOpenParams
					{
						MarkId = markByQuestId.MarkId,
						MarkType = markByQuestId.MarkType
					};
					this.OpenView(EOpenMapType.Other, false, data, delegate(bool success, int viewId)
					{
						EventSystem.Instance.Emit<int>(EEventName.WorldMapOpenedForQuestMapFocus, questIdValue);
					});
				}
			}
		}

		// Token: 0x060245D2 RID: 148946 RVA: 0x00A48DC0 File Offset: 0x00A46FC0
		private void OnCsNotifyOpenWorldMapView(EMarkType markType, int markId, bool isNotFocusTween)
		{
			WorldMapViewOpenParams param = new WorldMapViewOpenParams
			{
				MarkType = markType,
				MarkId = new int?(markId),
				OpenFogId = new int?(0),
				IsNotFocusTween = new bool?(isNotFocusTween)
			};
			UiManager.Instance.OpenView(EUiViewName.WorldMapView, param, null);
		}

		// Token: 0x060245D3 RID: 148947 RVA: 0x00A48E10 File Offset: 0x00A47010
		public void RequestNavigationFindPath(global::Vector startPos, global::Vector endPos, int mapId)
		{
			NavigationFindPathRequest navigationFindPathRequest = NavigationFindPathRequest.Create();
			navigationFindPathRequest.StartPos = new Aki.Protocol.Vector
			{
				X = (float)startPos.X,
				Y = (float)startPos.Y,
				Z = (float)startPos.Z
			};
			navigationFindPathRequest.EndPos = new Aki.Protocol.Vector
			{
				X = (float)endPos.X,
				Y = (float)endPos.Y,
				Z = (float)endPos.Z
			};
			navigationFindPathRequest.MapId = mapId;
			Net.Instance.Call(ERequestMessageId.NavigationFindPathRequest, navigationFindPathRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				NavigationFindPathResponse navigationFindPathResponse = (NavigationFindPathResponse)msg;
				if (navigationFindPathResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(navigationFindPathResponse.ErrorCode, 27703, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060245D4 RID: 148948 RVA: 0x00A48EBE File Offset: 0x00A470BE
		public void EnableWorldNavigationDebug(bool isEnable)
		{
			WorldNavigation.SetEnableDebug(isEnable);
		}

		// Token: 0x060245D5 RID: 148949 RVA: 0x00A48EC8 File Offset: 0x00A470C8
		public void OpenExtraUi(EWorldMapExtraUiPanelName panelName, IWorldMapViewOpenParams mapOpenParam, [Nullable(2)] object param = null)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
			{
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = mapOpenParam.MarkId.Value,
					MarkType = mapOpenParam.MarkType,
					Focal = new bool?(false),
					FocusTween = new bool?(false)
				});
				EventSystem.Instance.Emit<EWorldMapExtraUiPanelName, object>(EEventName.OpenExtraUiFromMap, panelName, param);
				return;
			}
			this.OpenView(EOpenMapType.Other, false, mapOpenParam, null);
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x060245D6 RID: 148950 RVA: 0x00A48F50 File Offset: 0x00A47150
		public static WorldMapController Instance
		{
			get
			{
				return WorldMapController._Instance;
			}
		}

		// Token: 0x060245D7 RID: 148951 RVA: 0x00A48F57 File Offset: 0x00A47157
		public static WorldMapController GetOrCreateInstance()
		{
			if (WorldMapController._Instance == null)
			{
				WorldMapController.CreateInstance();
			}
			return WorldMapController._Instance;
		}

		// Token: 0x060245D8 RID: 148952 RVA: 0x00A48F6B File Offset: 0x00A4716B
		public static bool CreateInstance()
		{
			if (WorldMapController._Instance != null)
			{
				return true;
			}
			WorldMapController._Instance = new WorldMapController();
			return true;
		}

		// Token: 0x060245D9 RID: 148953 RVA: 0x00A48F81 File Offset: 0x00A47181
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060245DA RID: 148954 RVA: 0x00A48F83 File Offset: 0x00A47183
		public static void ResetStaticDefaultValue()
		{
			WorldMapController._Instance = null;
		}

		// Token: 0x060245DB RID: 148955 RVA: 0x00A48F8B File Offset: 0x00A4718B
		static WorldMapController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WorldMapController.CreateStaticDefaultValue), new Action(WorldMapController.ResetStaticDefaultValue));
		}

		// Token: 0x040143B3 RID: 82867
		[Nullable(2)]
		private TimerHandle CheckStreamingCompletedTimerId;

		// Token: 0x040143B4 RID: 82868
		[Nullable(2)]
		private List<int> OpenFuncList;

		// Token: 0x040143B5 RID: 82869
		[Nullable(2)]
		private static WorldMapController _Instance;
	}
}
