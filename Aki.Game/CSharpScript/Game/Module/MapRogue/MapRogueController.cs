using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200559B RID: 21915
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class MapRogueController : UiControllerBase
	{
		// Token: 0x06037DD2 RID: 228818 RVA: 0x00D3CE48 File Offset: 0x00D3B048
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06037DD3 RID: 228819 RVA: 0x00D3CE4C File Offset: 0x00D3B04C
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

		// Token: 0x06037DD4 RID: 228820 RVA: 0x00D3CF20 File Offset: 0x00D3B120
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

		// Token: 0x06037DD5 RID: 228821 RVA: 0x00D3CF9D File Offset: 0x00D3B19D
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06037DD6 RID: 228822 RVA: 0x00D3CFBB File Offset: 0x00D3B1BB
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06037DD7 RID: 228823 RVA: 0x00D3CFDC File Offset: 0x00D3B1DC
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
				RogueBattleModel.Instance.InitFormationData(rogueResInstGlobalDataNotify.RogueResFormations.ToList<RogueResFormation>());
			}
			RogueBattleModel.Instance.MaxRoleStar = rogueResInstGlobalDataNotify.RoleMaxStar;
		}

		// Token: 0x06037DD8 RID: 228824 RVA: 0x00D3D164 File Offset: 0x00D3B364
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

		// Token: 0x06037DD9 RID: 228825 RVA: 0x00D3D1F4 File Offset: 0x00D3B3F4
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

		// Token: 0x06037DDA RID: 228826 RVA: 0x00D3D264 File Offset: 0x00D3B464
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

		// Token: 0x06037DDB RID: 228827 RVA: 0x00D3D2B4 File Offset: 0x00D3B4B4
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

		// Token: 0x06037DDC RID: 228828 RVA: 0x00D3D3E4 File Offset: 0x00D3B5E4
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

		// Token: 0x06037DDD RID: 228829 RVA: 0x00D3D438 File Offset: 0x00D3B638
		public UniTask RequestInstResultEnd()
		{
			MapRogueController.<RequestInstResultEnd>d__11 <RequestInstResultEnd>d__;
			<RequestInstResultEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestInstResultEnd>d__.<>1__state = -1;
			<RequestInstResultEnd>d__.<>t__builder.Start<MapRogueController.<RequestInstResultEnd>d__11>(ref <RequestInstResultEnd>d__);
			return <RequestInstResultEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06037DDE RID: 228830 RVA: 0x00D3D474 File Offset: 0x00D3B674
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

		// Token: 0x06037DDF RID: 228831 RVA: 0x00D3D4E4 File Offset: 0x00D3B6E4
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

		// Token: 0x06037DE0 RID: 228832 RVA: 0x00D3D521 File Offset: 0x00D3B721
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

		// Token: 0x06037DE1 RID: 228833 RVA: 0x00D3D544 File Offset: 0x00D3B744
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

		// Token: 0x06037DE2 RID: 228834 RVA: 0x00D3D638 File Offset: 0x00D3B838
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

		// Token: 0x06037DE3 RID: 228835 RVA: 0x00D3D690 File Offset: 0x00D3B890
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

		// Token: 0x06037DE4 RID: 228836 RVA: 0x00D3D6DC File Offset: 0x00D3B8DC
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

		// Token: 0x06037DE5 RID: 228837 RVA: 0x00D3D72C File Offset: 0x00D3B92C
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

		// Token: 0x06037DE6 RID: 228838 RVA: 0x00D3D77D File Offset: 0x00D3B97D
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.MapRogueMainView, new Func<EUiViewName, object, bool>(this.CanOpenMainView), "MapRogueController.CanOpenMainView");
		}

		// Token: 0x06037DE7 RID: 228839 RVA: 0x00D3D79F File Offset: 0x00D3B99F
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.MapRogueMainView, new Func<EUiViewName, object, bool>(this.CanOpenMainView));
		}

		// Token: 0x06037DE8 RID: 228840 RVA: 0x00D3D7BC File Offset: 0x00D3B9BC
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

		// Token: 0x06037DE9 RID: 228841 RVA: 0x00D3D7F0 File Offset: 0x00D3B9F0
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

		// Token: 0x06037DEA RID: 228842 RVA: 0x00D3D849 File Offset: 0x00D3BA49
		public void OpenRogueMenuView()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapSummaryView, null, null);
		}

		// Token: 0x06037DEB RID: 228843 RVA: 0x00D3D85C File Offset: 0x00D3BA5C
		public void OpenRogueFetterView(int? fetterId = null)
		{
			RogueBattleMapSummeryOpenInfo param = new RogueBattleMapSummeryOpenInfo
			{
				TabName = EUiTabViewName.RogueBattleMapSummaryFettersTabView,
				FetterId = fetterId
			};
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapSummaryView, param, null);
		}

		// Token: 0x06037DEC RID: 228844 RVA: 0x00D3D894 File Offset: 0x00D3BA94
		public void OpenExploreEnd(bool exitToMap = false)
		{
			ExploreEndViewData exploreEndViewData = new ExploreEndViewData();
			exploreEndViewData.ExitToMap = exitToMap;
			UiManager.Instance.OpenView(EUiViewName.MapRogueExploreEndView, exploreEndViewData, null);
		}

		// Token: 0x06037DED RID: 228845 RVA: 0x00D3D8C0 File Offset: 0x00D3BAC0
		public void OpenExplore()
		{
			ExploreEndViewData param = new ExploreEndViewData();
			UiManager.Instance.OpenView(EUiViewName.MapRogueExploreView, param, null);
		}

		// Token: 0x06037DEE RID: 228846 RVA: 0x00D3D8E4 File Offset: 0x00D3BAE4
		public void OpenMapHelpView()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleMapHelpView, null, null);
		}

		// Token: 0x1700867E RID: 34430
		// (get) Token: 0x06037DEF RID: 228847 RVA: 0x00D3D8F7 File Offset: 0x00D3BAF7
		[Nullable(1)]
		public static MapRogueController Instance
		{
			[NullableContext(1)]
			get
			{
				return MapRogueController._Instance;
			}
		}

		// Token: 0x06037DF0 RID: 228848 RVA: 0x00D3D8FE File Offset: 0x00D3BAFE
		[NullableContext(1)]
		public static MapRogueController GetOrCreateInstance()
		{
			if (MapRogueController._Instance == null)
			{
				MapRogueController.CreateInstance();
			}
			return MapRogueController._Instance;
		}

		// Token: 0x06037DF1 RID: 228849 RVA: 0x00D3D912 File Offset: 0x00D3BB12
		public static bool CreateInstance()
		{
			if (MapRogueController._Instance != null)
			{
				return true;
			}
			MapRogueController._Instance = new MapRogueController();
			return true;
		}

		// Token: 0x06037DF2 RID: 228850 RVA: 0x00D3D928 File Offset: 0x00D3BB28
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037DF3 RID: 228851 RVA: 0x00D3D92A File Offset: 0x00D3BB2A
		public static void ResetStaticDefaultValue()
		{
			MapRogueController._Instance = null;
		}

		// Token: 0x06037DF4 RID: 228852 RVA: 0x00D3D932 File Offset: 0x00D3BB32
		static MapRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueController.CreateStaticDefaultValue), new Action(MapRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D583 RID: 120195
		private static MapRogueController _Instance;
	}
}
