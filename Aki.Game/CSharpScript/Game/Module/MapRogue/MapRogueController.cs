using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004571 RID: 17777
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class MapRogueController : UiControllerBase
	{
		// Token: 0x0602CCD0 RID: 183504 RVA: 0x00C8AB90 File Offset: 0x00C88D90
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602CCD1 RID: 183505 RVA: 0x00C8AB94 File Offset: 0x00C88D94
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueResOpDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResOpDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResInstGlobalDataNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResInstGlobalDataNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResGridDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResGridDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResMoodUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResMoodUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResPlayerStatusUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResPlayerStatusUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResTeamLevelUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResTeamLevelUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResMoodRangeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResMoodRangeUpdateNotify));
		}

		// Token: 0x0602CCD2 RID: 183506 RVA: 0x00C8AC68 File Offset: 0x00C88E68
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueResOpDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResInstGlobalDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResGridDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResMoodUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResPlayerStatusUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResTeamLevelUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResMoodRangeUpdateNotify);
		}

		// Token: 0x0602CCD3 RID: 183507 RVA: 0x00C8ACE5 File Offset: 0x00C88EE5
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x0602CCD4 RID: 183508 RVA: 0x00C8AD03 File Offset: 0x00C88F03
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x0602CCD5 RID: 183509 RVA: 0x00C8AD24 File Offset: 0x00C88F24
		private void OnRogueResInstGlobalDataNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResInstGlobalDataNotify rogueResInstGlobalDataNotify = (RogueResInstGlobalDataNotify)msg;
			IGameInfoInitData gameInfo = new GameInfoInitData
			{
				InstanceId = rogueResInstGlobalDataNotify.InstId,
				RandomSeed = rogueResInstGlobalDataNotify.RandomSeedId,
				MapGrids = MapRogueModel.Instance.CreateMapGridDataList(rogueResInstGlobalDataNotify.RogueResGridDatas, rogueResInstGlobalDataNotify.RandomSeedId),
				MapWidth = rogueResInstGlobalDataNotify.Columns,
				MapHeight = rogueResInstGlobalDataNotify.Rows,
				PlayerGridIndex = rogueResInstGlobalDataNotify.Index,
				MoodMin = rogueResInstGlobalDataNotify.MinMood,
				MoodMax = rogueResInstGlobalDataNotify.MaxMood,
				InitMood = rogueResInstGlobalDataNotify.Mood,
				TeamLv = rogueResInstGlobalDataNotify.TeamLevel,
				InBattle = rogueResInstGlobalDataNotify.InBattle,
				CurrencyItemId = rogueResInstGlobalDataNotify.GoldItem,
				MoodRuleId = rogueResInstGlobalDataNotify.MoodRuleId,
				RoleLevel = rogueResInstGlobalDataNotify.RoleLevel,
				RoleMaxStar = rogueResInstGlobalDataNotify.RoleMaxStar
			};
			MapRogueModel.Instance.ResetGameInfo();
			MapRogueModel.Instance.RefreshGameInfo(gameInfo);
			RogueResOpDataNotify rogueResOpDataNotify = rogueResInstGlobalDataNotify.RogueResOpDataNotify;
			if (((rogueResOpDataNotify != null) ? rogueResOpDataNotify.RogueResOpDatas : null) != null)
			{
				MapRogueModel.Instance.GenerateOpList(rogueResInstGlobalDataNotify.RogueResOpDataNotify.RogueResOpDatas);
			}
			if (rogueResInstGlobalDataNotify.RogueResInstOptionsNotify != null)
			{
				RogueBattleModel instance = RogueBattleModel.Instance;
				if (instance != null)
				{
					instance.InitOptionData(rogueResInstGlobalDataNotify.RogueResInstOptionsNotify);
				}
			}
			if (rogueResInstGlobalDataNotify.RogueResGainDataTotalNotify != null)
			{
				RogueBattleModel instance2 = RogueBattleModel.Instance;
				if (instance2 != null)
				{
					instance2.InitGainData(rogueResInstGlobalDataNotify.RogueResGainDataTotalNotify);
				}
			}
			if (rogueResInstGlobalDataNotify.RogueResFormations != null)
			{
				RogueBattleModel.Instance.InitFormationData(new List<RogueResFormation>(rogueResInstGlobalDataNotify.RogueResFormations));
			}
			RogueBattleModel.Instance.MaxRoleStar = rogueResInstGlobalDataNotify.RoleMaxStar;
		}

		// Token: 0x0602CCD6 RID: 183510 RVA: 0x00C8AEAC File Offset: 0x00C890AC
		private void OnRogueResGridDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResGridDataUpdateNotify rogueResGridDataUpdateNotify = (RogueResGridDataUpdateNotify)msg;
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			foreach (KeyValuePair<int, RogueResGridData> keyValuePair in rogueResGridDataUpdateNotify.RogueResGridDataDict)
			{
				int key = keyValuePair.Key;
				RogueResGridData value = keyValuePair.Value;
				MapRogueModel.Instance.RefreshMapGridData(key, value);
			}
			if (rogueResGridDataUpdateNotify.HasPlayerIndex)
			{
				gameInfo.PlayerGridIndex = rogueResGridDataUpdateNotify.PlayerIndex;
			}
		}

		// Token: 0x0602CCD7 RID: 183511 RVA: 0x00C8AF3C File Offset: 0x00C8913C
		private void OnRogueResMoodUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResMoodUpdateNotify rogueResMoodUpdateNotify = (RogueResMoodUpdateNotify)msg;
			if (MapRogueModel.Instance.GameInfo == null)
			{
				return;
			}
			MapRogueModel.Instance.GameInfo.SetMood(rogueResMoodUpdateNotify.Mood, new int?(rogueResMoodUpdateNotify.EventType), null, null, rogueResMoodUpdateNotify.IgnorePerformance);
			MapRogueModel.Instance.GameInfo.MoodRuleId = rogueResMoodUpdateNotify.MoodRuleId;
		}

		// Token: 0x0602CCD8 RID: 183512 RVA: 0x00C8AFAC File Offset: 0x00C891AC
		private void OnRogueResMoodRangeUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResMoodRangeUpdateNotify rogueResMoodRangeUpdateNotify = (RogueResMoodRangeUpdateNotify)msg;
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			gameInfo.SetMood(gameInfo.Mood, null, new int?(rogueResMoodRangeUpdateNotify.MinMood), new int?(rogueResMoodRangeUpdateNotify.MaxMood), false);
		}

		// Token: 0x0602CCD9 RID: 183513 RVA: 0x00C8AFFC File Offset: 0x00C891FC
		private void OnRogueResPlayerStatusUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResPlayerStatusUpdateNotify rogueResPlayerStatusUpdateNotify = (RogueResPlayerStatusUpdateNotify)msg;
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			gameInfo.InBattle = rogueResPlayerStatusUpdateNotify.InBattle;
			if (gameInfo.IsEnd)
			{
				return;
			}
			if (rogueResPlayerStatusUpdateNotify.InBattle)
			{
				if (gameInfo.HasBindView)
				{
					gameInfo.EnterBattleFlag = true;
					UiManager.Instance.CloseView(EUiViewName.MapRogueMainView, null);
				}
			}
			else if (!gameInfo.HasBindView)
			{
				UiManager.Instance.OpenView(EUiViewName.MapRogueMainView, null, null);
			}
			foreach (MapRogueOp mapRogueOp in MapRogueModel.Instance.GetAllOpData())
			{
				mapRogueOp.BattleStateUpdate(rogueResPlayerStatusUpdateNotify.InBattle, gameInfo);
			}
			if (!rogueResPlayerStatusUpdateNotify.InBattle)
			{
				foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity != null)
					{
						BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
						if (component != null)
						{
							component.StopAllSkills("RogueBattleStateUpdate");
						}
					}
				}
			}
		}

		// Token: 0x0602CCDA RID: 183514 RVA: 0x00C8B12C File Offset: 0x00C8932C
		private void OnRogueResTeamLevelUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResTeamLevelUpdateNotify rogueResTeamLevelUpdateNotify = (RogueResTeamLevelUpdateNotify)msg;
			if (MapRogueModel.Instance.GameInfo == null)
			{
				return;
			}
			MapRogueModel.Instance.GameInfo.SetTeamLv(rogueResTeamLevelUpdateNotify.TeamLevel, new int?(rogueResTeamLevelUpdateNotify.EventType));
			MapRogueModel.Instance.SetRoleLevel(rogueResTeamLevelUpdateNotify.RoleLevel);
		}

		// Token: 0x0602CCDB RID: 183515 RVA: 0x00C8B180 File Offset: 0x00C89380
		public UniTask RequestInstResultEnd()
		{
			MapRogueController.<RequestInstResultEnd>d__11 <RequestInstResultEnd>d__;
			<RequestInstResultEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestInstResultEnd>d__.<>1__state = -1;
			<RequestInstResultEnd>d__.<>t__builder.Start<MapRogueController.<RequestInstResultEnd>d__11>(ref <RequestInstResultEnd>d__);
			return <RequestInstResultEnd>d__.<>t__builder.Task;
		}

		// Token: 0x0602CCDC RID: 183516 RVA: 0x00C8B1BC File Offset: 0x00C893BC
		public void RequestInstLeave()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			if (instanceId != 0)
			{
				ActivityPermanentRogueController.Instance.SetReturnToWorld(instanceId);
			}
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo != null)
			{
				gameInfo.IsEnd = true;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).ContinueWith(delegate(bool success)
			{
				if (gameInfo != null)
				{
					gameInfo.IsEnd = success;
				}
				if (success)
				{
					MapRogueModel.Instance.ResetGameInfo();
				}
			});
		}

		// Token: 0x0602CCDD RID: 183517 RVA: 0x00C8B22C File Offset: 0x00C8942C
		public void RequestBackToMap(Action<bool> callback = null)
		{
			RogueResGridEventRequest message = RogueResGridEventRequest.Create();
			Net.Instance.Call(ERequestMessageId.RogueResGridEventRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResGridEventResponse rogueResGridEventResponse = (RogueResGridEventResponse)msg;
				if (rogueResGridEventResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (rogueResGridEventResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResGridEventResponse.ErrCode, EResponseMessageId.RogueResGridEventResponse, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x0602CCDE RID: 183518 RVA: 0x00C8B269 File Offset: 0x00C89469
		private void OnWorldDoneAndCloseLoading()
		{
			if (MapRogueModel.Instance.GameInfo == null)
			{
				return;
			}
			if (!this.CheckInMapRogueInstance())
			{
				return;
			}
			MapRogueModel.Instance.ExecuteOpDataList();
		}

		// Token: 0x0602CCDF RID: 183519 RVA: 0x00C8B28C File Offset: 0x00C8948C
		private void OnRogueResOpDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResOpDataUpdateNotify rogueResOpDataUpdateNotify = (RogueResOpDataUpdateNotify)msg;
			if (MapRogueModel.Instance.GameInfo == null)
			{
				return;
			}
			foreach (int incId in rogueResOpDataUpdateNotify.Removes)
			{
				MapRogueModel.Instance.RemoveOpData(incId);
			}
			foreach (RogueResOpData data in rogueResOpDataUpdateNotify.Updates)
			{
				MapRogueModel.Instance.UpdateOpData(data);
			}
			foreach (RogueResOpData data2 in rogueResOpDataUpdateNotify.Adds)
			{
				MapRogueModel.Instance.AddOpData(data2, true);
			}
			MapRogueModel.Instance.ExecuteOpDataList();
		}

		// Token: 0x0602CCE0 RID: 183520 RVA: 0x00C8B380 File Offset: 0x00C89580
		[NullableContext(1)]
		public void RequestMove(List<int> pathList, [Nullable(2)] Action<bool> callback = null)
		{
			RogueResMoveRequest rogueResMoveRequest = RogueResMoveRequest.Create();
			MoveOp moveOp = MoveOp.Create();
			moveOp.Paths.AddRange(pathList);
			rogueResMoveRequest.MoveOp = moveOp;
			Net.Instance.Call(ERequestMessageId.RogueResMoveRequest, rogueResMoveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResMoveResponse rogueResMoveResponse = (RogueResMoveResponse)msg;
				if (rogueResMoveResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (rogueResMoveResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResMoveResponse.ErrCode, EResponseMessageId.RogueResMoveResponse, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x0602CCE1 RID: 183521 RVA: 0x00C8B3D8 File Offset: 0x00C895D8
		public void RequestExecuteOp(int incId, int clientId, Action<bool> callback = null)
		{
			RogueResOpDoneRequest rogueResOpDoneRequest = RogueResOpDoneRequest.Create();
			rogueResOpDoneRequest.IncId = incId;
			rogueResOpDoneRequest.ClientSelectId = clientId;
			Net.Instance.Call(ERequestMessageId.RogueResOpDoneRequest, rogueResOpDoneRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResOpDoneResponse rogueResOpDoneResponse = (RogueResOpDoneResponse)msg;
				if (rogueResOpDoneResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					if (rogueResOpDoneResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResOpDoneResponse.ErrCode, EResponseMessageId.RogueResOpDoneResponse, null, true, true);
						Action<bool> callback3 = callback;
						if (callback3 != null)
						{
							callback3(false);
						}
					}
					Action<bool> callback4 = callback;
					if (callback4 != null)
					{
						callback4(true);
					}
					MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
					if (gameInfo == null)
					{
						return;
					}
					gameInfo.SetInteractAvailable(EMapForbiddenTag.WaitExecuteOp, true);
					return;
				}
			}, 0);
		}

		// Token: 0x0602CCE2 RID: 183522 RVA: 0x00C8B424 File Offset: 0x00C89624
		[NullableContext(1)]
		public void RequestExecuteOpMultiSelect(int incId, List<int> clientIds, [Nullable(2)] Action<bool> callback = null)
		{
			RogueResOpDoneRequest rogueResOpDoneRequest = RogueResOpDoneRequest.Create();
			rogueResOpDoneRequest.IncId = incId;
			rogueResOpDoneRequest.ClientSelectIds.AddRange(clientIds);
			Net.Instance.Call(ERequestMessageId.RogueResOpDoneRequest, rogueResOpDoneRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResOpDoneResponse rogueResOpDoneResponse = (RogueResOpDoneResponse)msg;
				if (rogueResOpDoneResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					if (rogueResOpDoneResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResOpDoneResponse.ErrCode, EResponseMessageId.RogueResOpDoneResponse, null, true, true);
						Action<bool> callback3 = callback;
						if (callback3 != null)
						{
							callback3(false);
						}
					}
					Action<bool> callback4 = callback;
					if (callback4 != null)
					{
						callback4(true);
					}
					MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
					if (gameInfo == null)
					{
						return;
					}
					gameInfo.SetInteractAvailable(EMapForbiddenTag.WaitExecuteOp, true);
					return;
				}
			}, 0);
		}

		// Token: 0x0602CCE3 RID: 183523 RVA: 0x00C8B474 File Offset: 0x00C89674
		public bool CheckInMapRogueInstance()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 34;
		}

		// Token: 0x0602CCE4 RID: 183524 RVA: 0x00C8B4C5 File Offset: 0x00C896C5
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.MapRogueMainView, new Func<EUiViewName, object, bool>(this.CanOpenMainView), "MapRogueController.CanOpenMainView");
		}

		// Token: 0x0602CCE5 RID: 183525 RVA: 0x00C8B4E7 File Offset: 0x00C896E7
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.MapRogueMainView, new Func<EUiViewName, object, bool>(this.CanOpenMainView));
		}

		// Token: 0x0602CCE6 RID: 183526 RVA: 0x00C8B504 File Offset: 0x00C89704
		[NullableContext(1)]
		private bool CanOpenMainView(EUiViewName viewName, object param)
		{
			if (!this.CheckInMapRogueInstance())
			{
				return false;
			}
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			return gameInfo != null && !gameInfo.InBattle;
		}

		// Token: 0x0602CCE7 RID: 183527 RVA: 0x00C8B538 File Offset: 0x00C89738
		[NullableContext(1)]
		public void OpenRogueTipsView(ERogueTipsType type, string textId, [Nullable(new byte[]
		{
			2,
			1
		})] string[] textParam = null, [Nullable(2)] Action finishCallback = null)
		{
			RogueTipsData param = new RogueTipsData
			{
				TextId = textId,
				TextParam = (textParam ?? new string[0]),
				FinishCallback = finishCallback
			};
			if (type == ERogueTipsType.Normal)
			{
				UiManager.Instance.OpenView(EUiViewName.MapRogueFloatTipsAView, param, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MapRogueFloatTipsBView, param, null);
		}

		// Token: 0x0602CCE8 RID: 183528 RVA: 0x00C8B591 File Offset: 0x00C89791
		public void OpenRogueMenuView()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapSummaryView, null, null);
		}

		// Token: 0x0602CCE9 RID: 183529 RVA: 0x00C8B5A4 File Offset: 0x00C897A4
		public void OpenRogueFetterView(int? fetterId = null)
		{
			RogueBattleMapSummeryOpenInfo param = new RogueBattleMapSummeryOpenInfo
			{
				TabName = EUiTabViewName.RogueBattleMapSummaryFettersTabView,
				FetterId = fetterId
			};
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapSummaryView, param, null);
		}

		// Token: 0x0602CCEA RID: 183530 RVA: 0x00C8B5DC File Offset: 0x00C897DC
		public void OpenExploreEnd(bool exitToMap = false)
		{
			ExploreEndViewData exploreEndViewData = new ExploreEndViewData();
			exploreEndViewData.ExitToMap = exitToMap;
			UiManager.Instance.OpenView(EUiViewName.MapRogueExploreEndView, exploreEndViewData, null);
		}

		// Token: 0x0602CCEB RID: 183531 RVA: 0x00C8B608 File Offset: 0x00C89808
		public void OpenExplore()
		{
			ExploreEndViewData param = new ExploreEndViewData();
			UiManager.Instance.OpenView(EUiViewName.MapRogueExploreView, param, null);
		}

		// Token: 0x0602CCEC RID: 183532 RVA: 0x00C8B62C File Offset: 0x00C8982C
		public void OpenMapHelpView()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapHelpView, null, null);
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x0602CCED RID: 183533 RVA: 0x00C8B63F File Offset: 0x00C8983F
		[Nullable(1)]
		public static MapRogueController Instance
		{
			[NullableContext(1)]
			get
			{
				return MapRogueController._Instance;
			}
		}

		// Token: 0x0602CCEE RID: 183534 RVA: 0x00C8B646 File Offset: 0x00C89846
		[NullableContext(1)]
		public static MapRogueController GetOrCreateInstance()
		{
			if (MapRogueController._Instance == null)
			{
				MapRogueController.CreateInstance();
			}
			return MapRogueController._Instance;
		}

		// Token: 0x0602CCEF RID: 183535 RVA: 0x00C8B65A File Offset: 0x00C8985A
		public static bool CreateInstance()
		{
			if (MapRogueController._Instance != null)
			{
				return true;
			}
			MapRogueController._Instance = new MapRogueController();
			return true;
		}

		// Token: 0x0602CCF0 RID: 183536 RVA: 0x00C8B670 File Offset: 0x00C89870
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602CCF1 RID: 183537 RVA: 0x00C8B672 File Offset: 0x00C89872
		public static void ResetStaticDefaultValue()
		{
			MapRogueController._Instance = null;
		}

		// Token: 0x0602CCF2 RID: 183538 RVA: 0x00C8B67A File Offset: 0x00C8987A
		static MapRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueController.CreateStaticDefaultValue), new Action(MapRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x0401800E RID: 98318
		private static MapRogueController _Instance;
	}
}
