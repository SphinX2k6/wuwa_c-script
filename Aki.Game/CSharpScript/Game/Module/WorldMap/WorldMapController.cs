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
	// Token: 0x0200477E RID: 18302
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapController : UiControllerBase
	{
		// Token: 0x0602FDEC RID: 196076 RVA: 0x00B1825A File Offset: 0x00B1645A
		protected override bool OnInit()
		{
			InputManager.Instance.RegisterOpenViewFunc(EUiViewName.WorldMapView, new Action(this.RegisterOpenView));
			return true;
		}

		// Token: 0x0602FDED RID: 196077 RVA: 0x00B18278 File Offset: 0x00B16478
		private void RegisterOpenView()
		{
			this.OpenView(EOpenMapType.HotKey, true, null, null);
		}

		// Token: 0x0602FDEE RID: 196078 RVA: 0x00B18284 File Offset: 0x00B16484
		protected override bool OnLeaveLevel()
		{
			if (this.CheckStreamingCompletedTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.CheckStreamingCompletedTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckStreamingCompletedTimerId);
			}
			return true;
		}

		// Token: 0x0602FDEF RID: 196079 RVA: 0x00B182B4 File Offset: 0x00B164B4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenFunctionView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseFunctionView));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.CsNotifyTsOpenWorldMapView, new Action<EMarkType, int, bool>(this.OnCsNotifyOpenWorldMapView));
		}

		// Token: 0x0602FDF0 RID: 196080 RVA: 0x00B1832C File Offset: 0x00B1652C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenFunctionView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseFunctionView));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.CsNotifyTsOpenWorldMapView, new Action<EMarkType, int, bool>(this.OnCsNotifyOpenWorldMapView));
		}

		// Token: 0x0602FDF1 RID: 196081 RVA: 0x00B183A2 File Offset: 0x00B165A2
		private void OnOpenFunctionView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FunctionOpenView)
			{
				return;
			}
			this.OpenFuncList = FunctionModel.Instance.GetNewOpenFunctionIdList();
		}

		// Token: 0x0602FDF2 RID: 196082 RVA: 0x00B183C4 File Offset: 0x00B165C4
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

		// Token: 0x0602FDF3 RID: 196083 RVA: 0x00B18550 File Offset: 0x00B16750
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
			global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(teleportConfigById.Value.TeleportEntityConfigId, teleportConfigById.Value.MapId);
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

		// Token: 0x0602FDF4 RID: 196084 RVA: 0x00B18698 File Offset: 0x00B16898
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

		// Token: 0x0602FDF5 RID: 196085 RVA: 0x00B186F0 File Offset: 0x00B168F0
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

		// Token: 0x0602FDF6 RID: 196086 RVA: 0x00B18744 File Offset: 0x00B16944
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

		// Token: 0x0602FDF7 RID: 196087 RVA: 0x00B187CC File Offset: 0x00B169CC
		public void MapOpenPush(int openType)
		{
			MapOpenPush message = new MapOpenPush
			{
				OpenType = (MapOpenType)openType
			};
			Net.Instance.Send(EPushMessageId.MapOpenPush, message);
		}

		// Token: 0x0602FDF8 RID: 196088 RVA: 0x00B187F8 File Offset: 0x00B169F8
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

		// Token: 0x0602FDF9 RID: 196089 RVA: 0x00B188D8 File Offset: 0x00B16AD8
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

		// Token: 0x0602FDFA RID: 196090 RVA: 0x00B18A11 File Offset: 0x00B16C11
		public void ClearFocalMarkItem()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			instance.CurrentFocalMarkType = null;
			instance.CurrentFocalMarkId = null;
		}

		// Token: 0x0602FDFB RID: 196091 RVA: 0x00B18A30 File Offset: 0x00B16C30
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

		// Token: 0x0602FDFC RID: 196092 RVA: 0x00B18A8B File Offset: 0x00B16C8B
		protected override bool OnClear()
		{
			if (this.CheckStreamingCompletedTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckStreamingCompletedTimerId);
				this.CheckStreamingCompletedTimerId = null;
			}
			return true;
		}

		// Token: 0x0602FDFD RID: 196093 RVA: 0x00B18AAE File Offset: 0x00B16CAE
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.WorldMapView, new Func<EUiViewName, object, bool>(this.CanOpenView), "WorldMapController.CanOpenView");
		}

		// Token: 0x0602FDFE RID: 196094 RVA: 0x00B18AD0 File Offset: 0x00B16CD0
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.WorldMapView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		}

		// Token: 0x0602FDFF RID: 196095 RVA: 0x00B18AF0 File Offset: 0x00B16CF0
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

		// Token: 0x0602FE00 RID: 196096 RVA: 0x00B18B6E File Offset: 0x00B16D6E
		private void OnWorldDone()
		{
			this.CheckAndRequestLastBigSceneInfo();
		}

		// Token: 0x0602FE01 RID: 196097 RVA: 0x00B18B78 File Offset: 0x00B16D78
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

		// Token: 0x0602FE02 RID: 196098 RVA: 0x00B18BD8 File Offset: 0x00B16DD8
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

		// Token: 0x0602FE03 RID: 196099 RVA: 0x00B18C48 File Offset: 0x00B16E48
		private void RequestLastBigSceneMiniMapInfo(int dungeonId)
		{
			LastBigSceneMiniMapInfoRequest message = LastBigSceneMiniMapInfoRequest.Create();
			Net.Instance.Call(ERequestMessageId.LastBigSceneMiniMapInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				LastBigSceneMiniMapInfoResponse lastBigSceneMiniMapInfoResponse = (LastBigSceneMiniMapInfoResponse)msg;
				if (lastBigSceneMiniMapInfoResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(lastBigSceneMiniMapInfoResponse.Code, 23770, null, true, true);
				}
				LastBigSceneMiniMapInfo lastBigSceneMiniMapInfo = new LastBigSceneMiniMapInfo
				{
					InstanceDungeonId = dungeonId,
					Position = global::Vector.Create((double)lastBigSceneMiniMapInfoResponse.PosX, (double)lastBigSceneMiniMapInfoResponse.PosY, (double)lastBigSceneMiniMapInfoResponse.PosZ)
				};
				WorldMapModel.Instance.LastBigSceneMiniMapInfo = lastBigSceneMiniMapInfo;
			}, 0);
		}

		// Token: 0x0602FE04 RID: 196100 RVA: 0x00B18C88 File Offset: 0x00B16E88
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

		// Token: 0x0602FE05 RID: 196101 RVA: 0x00B18D20 File Offset: 0x00B16F20
		public void StartListenChildQuestNodeStatusChangedAndOpenWorldMap(int questId)
		{
			WorldMapModel.Instance.PendingOpenWorldMapQuestId = new int?(questId);
			if (!EventSystem.Instance.Has(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged)))
			{
				EventSystem.Instance.Add<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(EEventName.AfterLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(this.OnChildQuestNodeStatusChanged));
			}
		}

		// Token: 0x0602FE06 RID: 196102 RVA: 0x00B18D78 File Offset: 0x00B16F78
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

		// Token: 0x0602FE07 RID: 196103 RVA: 0x00B18EE4 File Offset: 0x00B170E4
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

		// Token: 0x0602FE08 RID: 196104 RVA: 0x00B18F34 File Offset: 0x00B17134
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(navigationFindPathResponse.ErrorCode, 25627, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602FE09 RID: 196105 RVA: 0x00B18FE2 File Offset: 0x00B171E2
		public void EnableWorldNavigationDebug(bool isEnable)
		{
			WorldNavigation.SetEnableDebug(isEnable);
		}

		// Token: 0x0602FE0A RID: 196106 RVA: 0x00B18FEC File Offset: 0x00B171EC
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

		// Token: 0x1700777E RID: 30590
		// (get) Token: 0x0602FE0B RID: 196107 RVA: 0x00B19074 File Offset: 0x00B17274
		public static WorldMapController Instance
		{
			get
			{
				return WorldMapController._Instance;
			}
		}

		// Token: 0x0602FE0C RID: 196108 RVA: 0x00B1907B File Offset: 0x00B1727B
		public static WorldMapController GetOrCreateInstance()
		{
			if (WorldMapController._Instance == null)
			{
				WorldMapController.CreateInstance();
			}
			return WorldMapController._Instance;
		}

		// Token: 0x0602FE0D RID: 196109 RVA: 0x00B1908F File Offset: 0x00B1728F
		public static bool CreateInstance()
		{
			if (WorldMapController._Instance != null)
			{
				return true;
			}
			WorldMapController._Instance = new WorldMapController();
			return true;
		}

		// Token: 0x0602FE0E RID: 196110 RVA: 0x00B190A5 File Offset: 0x00B172A5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FE0F RID: 196111 RVA: 0x00B190A7 File Offset: 0x00B172A7
		public static void ResetStaticDefaultValue()
		{
			WorldMapController._Instance = null;
		}

		// Token: 0x0602FE10 RID: 196112 RVA: 0x00B190AF File Offset: 0x00B172AF
		static WorldMapController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WorldMapController.CreateStaticDefaultValue), new Action(WorldMapController.ResetStaticDefaultValue));
		}

		// Token: 0x04019D03 RID: 105731
		[Nullable(2)]
		private TimerHandle CheckStreamingCompletedTimerId;

		// Token: 0x04019D04 RID: 105732
		[Nullable(2)]
		private List<int> OpenFuncList;

		// Token: 0x04019D05 RID: 105733
		[Nullable(2)]
		private static WorldMapController _Instance;
	}
}
