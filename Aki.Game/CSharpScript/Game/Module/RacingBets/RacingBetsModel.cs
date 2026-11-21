using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets
{
	// Token: 0x02003EED RID: 16109
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RacingBetsModel : ModelBase
	{
		// Token: 0x06028D9D RID: 167325 RVA: 0x00B7696B File Offset: 0x00B74B6B
		protected override bool OnClear()
		{
			this.ClearDungeonEffects();
			this.RemoveRankTimer();
			return true;
		}

		// Token: 0x06028D9E RID: 167326 RVA: 0x00B7697C File Offset: 0x00B74B7C
		public void OnPlayerInfoUpdate(RacingBetPlayerInfo playerInfo)
		{
			if (this.SeasonData == null)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "OnPlayerInfoUpdate SeasonData is not undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SeasonData.RefreshPlayerData(playerInfo);
		}

		// Token: 0x06028D9F RID: 167327 RVA: 0x00B769BD File Offset: 0x00B74BBD
		public void OnRacingBetsTaskNotify(RacingBetsTaskNotify message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.RefreshRewardData(message.TaskDatas);
		}

		// Token: 0x06028DA0 RID: 167328 RVA: 0x00B769D9 File Offset: 0x00B74BD9
		public void OnRacingBetsMatchInfoRefresh(RacingBetsMatchInfoResponse message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.RefreshMatchInfo(message);
		}

		// Token: 0x06028DA1 RID: 167329 RVA: 0x00B769F0 File Offset: 0x00B74BF0
		public void OnRacingBetsMatchResultNotify(RacingBetLegMatchResultNotify message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.LegMatchResult = message;
			if (message != null)
			{
				int legMatchId = message.LegMatchId;
				RacingBetsLegMatchData legMatchData = this.SeasonData.GetLegMatchData(legMatchId);
				if (legMatchData != null)
				{
					legMatchData.RefreshLegMatchResultNotify(message);
				}
			}
		}

		// Token: 0x06028DA2 RID: 167330 RVA: 0x00B76A30 File Offset: 0x00B74C30
		public void OnRacingBetsOddsUpdate(RacingBetsUpdateOddsResponse message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			RacingBetsLegMatchData legMatchData = this.SeasonData.GetLegMatchData(message.LegMatchId);
			if (legMatchData == null)
			{
				return;
			}
			legMatchData.RefreshDangoOdds(message);
		}

		// Token: 0x06028DA3 RID: 167331 RVA: 0x00B76A63 File Offset: 0x00B74C63
		public void OnRacingBetsCloseSettleMenu(int legMatchId)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.AddCloseSettleLegMatchId(legMatchId);
		}

		// Token: 0x06028DA4 RID: 167332 RVA: 0x00B76A7C File Offset: 0x00B74C7C
		public void RefreshLegMatchResult(MatchResult matchResult)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			RacingBetsLegMatchData legMatchData = this.SeasonData.GetLegMatchData(matchResult.LegMatchId);
			if (legMatchData == null)
			{
				return;
			}
			legMatchData.RefreshLegMatchResult(matchResult);
			if (matchResult.PromoteNum > 0)
			{
				legMatchData.ParentGroupMatchData.RefreshGroupMatchResult(matchResult);
			}
			this.CheckMatchRedDot();
		}

		// Token: 0x06028DA5 RID: 167333 RVA: 0x00B76ACA File Offset: 0x00B74CCA
		[NullableContext(2)]
		public RacingBetsSeasonData GetRacingBetsSeasonData()
		{
			return this.SeasonData;
		}

		// Token: 0x06028DA6 RID: 167334 RVA: 0x00B76AD4 File Offset: 0x00B74CD4
		public void SetRacingBetsSeasonData(RacingBetsSeasonData data)
		{
			if (this.SeasonData != null)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "SetRacingBetsSeasonData SeasonData is not undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SeasonData = data;
		}

		// Token: 0x06028DA7 RID: 167335 RVA: 0x00B76B10 File Offset: 0x00B74D10
		[NullableContext(2)]
		public RacingBetsLegMatchData GetRacingBetsLegMatchData(int legMatchId)
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return this.SeasonData.GetLegMatchData(legMatchId);
		}

		// Token: 0x06028DA8 RID: 167336 RVA: 0x00B76B28 File Offset: 0x00B74D28
		[NullableContext(2)]
		public RacingBetLegMatchResultNotify GetLegMatchResultData()
		{
			return this.LegMatchResult;
		}

		// Token: 0x06028DA9 RID: 167337 RVA: 0x00B76B30 File Offset: 0x00B74D30
		[NullableContext(2)]
		public void SetLegMatchResultData(RacingBetLegMatchResultNotify data)
		{
			this.LegMatchResult = data;
		}

		// Token: 0x06028DAA RID: 167338 RVA: 0x00B76B39 File Offset: 0x00B74D39
		[NullableContext(2)]
		public RacingBetsGroupMatchData GetRacingBetsGroupMatchData(int matchId)
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return this.SeasonData.GetGroupMatchData(matchId);
		}

		// Token: 0x06028DAB RID: 167339 RVA: 0x00B76B51 File Offset: 0x00B74D51
		[NullableContext(2)]
		public IReadOnlyList<RacingBettingGear> GetRacingBetsGearList()
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return RacingBetsConfig.Instance.GetRacingBettingGearList(this.SeasonData.Id);
		}

		// Token: 0x06028DAC RID: 167340 RVA: 0x00B76B74 File Offset: 0x00B74D74
		public List<RacingBetsBulletScreen> GetRacingBetsBulletScreen(ERacingBetsBulletScreenType bulletType)
		{
			if (this.SeasonData == null)
			{
				return new List<RacingBetsBulletScreen>();
			}
			List<RacingBetsBulletScreen> list = new List<RacingBetsBulletScreen>();
			foreach (RacingBetsBulletScreen item in RacingBetsConfig.Instance.GetRacingBetsBulletScreenList(this.SeasonData.Id))
			{
				if (item.Type == (int)bulletType)
				{
					if (item.DangoId == 0)
					{
						list.Add(item);
					}
					else if (this.GetDungeonDangoInfo(item.DangoId) != null)
					{
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x06028DAD RID: 167341 RVA: 0x00B76C10 File Offset: 0x00B74E10
		public bool IsFinalLegMatch(int legMatchId)
		{
			return this.SeasonData != null && this.SeasonData.IsFinalLegMatch(legMatchId);
		}

		// Token: 0x06028DAE RID: 167342 RVA: 0x00B76C28 File Offset: 0x00B74E28
		public void RacingBetsMatchStart(int legMatchId, RacingBetMatchActionResponse message)
		{
			if (this.IsDungeonPlaying)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "RacingBets玩法重复开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IsDungeonPlaying = true;
			this.DungeonMatchId = legMatchId;
			this.IsReplayDungeon = message.Replay;
			this.InitDungeonDangoInfo(message.DangoInfo);
			this.RefreshDangoDungeonAudio(legMatchId);
			this.CommandQueue.Init();
			this.CommandQueue.BindCommandQueueEndCallBack(delegate(bool isAborted)
			{
				this.OnDangoDungeonEnd(isAborted).Forget();
			});
			this.PushDungeonInitCommand(this.DungeonAllDangoList);
			this.PushOpenGamePlayViewCommand();
			for (int i = 0; i < message.Rounds.Count; i++)
			{
				RacingBetsMatchRoundInfo roundData = message.Rounds[i];
				this.RacingBetsMatchRoundRefresh(legMatchId, roundData, i == message.Rounds.Count - 1);
			}
			this.CommandQueue.Execute().Forget();
		}

		// Token: 0x06028DAF RID: 167343 RVA: 0x00B76D0C File Offset: 0x00B74F0C
		private void InitDungeonDangoInfo(IEnumerable<RacingBetsInstanceDangoInfo> dangoInfoList)
		{
			this.DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();
			this.DungeonDangoMap.Clear();
			List<RacingBetsDungeonDangoInfo> list = new List<RacingBetsDungeonDangoInfo>();
			foreach (RacingBetsInstanceDangoInfo message in dangoInfoList)
			{
				RacingBetsDungeonDangoInfo racingBetsDungeonDangoInfo = new RacingBetsDungeonDangoInfo(message);
				this.DungeonDangoMap.Add(racingBetsDungeonDangoInfo.DangoId, racingBetsDungeonDangoInfo);
				if (racingBetsDungeonDangoInfo.IsAbuDango())
				{
					list.Add(racingBetsDungeonDangoInfo);
				}
				else
				{
					this.DungeonDangoSortList.Add(racingBetsDungeonDangoInfo);
				}
			}
			this.DungeonDangoSortList.Sort(delegate(RacingBetsDungeonDangoInfo a, RacingBetsDungeonDangoInfo b)
			{
				if (a.CurPoint != b.CurPoint)
				{
					return b.CurPoint.CompareTo(a.CurPoint);
				}
				return b.High.CompareTo(a.High);
			});
			for (int i = 0; i < this.DungeonDangoSortList.Count; i++)
			{
				this.DungeonDangoSortList[i].Rank = i + 1;
			}
			this.DungeonAllDangoList = new List<RacingBetsDungeonDangoInfo>(this.DungeonDangoSortList);
			this.DungeonAllDangoList.AddRange(list);
		}

		// Token: 0x06028DB0 RID: 167344 RVA: 0x00B76E10 File Offset: 0x00B75010
		public void RacingBetsMatchRoundRefresh(int legMatchId, RacingBetsMatchRoundInfo roundData, bool needRequireNextRound)
		{
			this.RacingBetsMatchRoundActionRefresh(roundData);
			if (roundData.IsFinalRound)
			{
				this.RefreshLegMatchResult(roundData.Result);
				RacingBetsLegMatchData legMatchData = this.SeasonData.GetLegMatchData(legMatchId);
				this.PushOpenRacingBetsDungeonResultViewCommand(legMatchData);
				return;
			}
			if (needRequireNextRound)
			{
				this.PushRacingBetsNextRoundRequestCommand(this.SeasonData.Id, legMatchId, roundData.RoundRank + 1);
			}
		}

		// Token: 0x06028DB1 RID: 167345 RVA: 0x00B76E6C File Offset: 0x00B7506C
		public void RacingBetsMatchPreview(int legMatchId, RacingBetMatchInfoResponse message)
		{
			if (this.IsDungeonPlaying)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "RacingBets玩法重复开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IsDungeonPlaying = true;
			this.DungeonMatchId = legMatchId;
			this.InitDungeonDangoInfo(message.DangoInfo);
			this.RefreshDangoDungeonAudio(legMatchId);
			this.CommandQueue.Init();
			this.CommandQueue.BindCommandQueueEndCallBack(new Action<bool>(this.OnDangoDungeonPreviewEnd));
			RacingBetsLegMatchData racingBetsLegMatchData = this.GetRacingBetsLegMatchData(legMatchId);
			bool flag = racingBetsLegMatchData != null && racingBetsLegMatchData.Type == 1;
			List<RacingBetsDungeonDangoInfo> list = new List<RacingBetsDungeonDangoInfo>();
			if (flag)
			{
				using (List<RacingBetsDungeonDangoInfo>.Enumerator enumerator = this.DungeonAllDangoList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						RacingBetsDungeonDangoInfo racingBetsDungeonDangoInfo = enumerator.Current;
						if (racingBetsDungeonDangoInfo.IsAbuDango())
						{
							list.Add(racingBetsDungeonDangoInfo);
						}
					}
					goto IL_CE;
				}
			}
			list = this.DungeonAllDangoList;
			IL_CE:
			this.PushDungeonInitCommand(list);
			this.PushOpenGamePlayerPreviewViewCommand(true);
			this.CommandQueue.Execute().Forget();
		}

		// Token: 0x06028DB2 RID: 167346 RVA: 0x00B76F78 File Offset: 0x00B75178
		public void RacingBetsMatchRoundActionRefresh(RacingBetsMatchRoundInfo roundData)
		{
			foreach (RacingBetsInstanceRoundAction racingBetsInstanceRoundAction in roundData.RoundAction)
			{
				RacingBetsCommandBase racingBetsCommandBase = null;
				switch (racingBetsInstanceRoundAction.ActionType)
				{
				case RacingBetsRoundActionType.MatchStart:
					racingBetsCommandBase = this.PushRacingBetsDungeonBeginCommand();
					break;
				case RacingBetsRoundActionType.RoundStart:
					racingBetsCommandBase = this.PushRacingBetsRoundStartCommand();
					break;
				case RacingBetsRoundActionType.DangoRoundStart:
					racingBetsCommandBase = this.PushRacingBetsDangoRoundStartCommand(racingBetsInstanceRoundAction.DangoStart.DangoId);
					break;
				case RacingBetsRoundActionType.MatchRoundDice:
					racingBetsCommandBase = this.PushRacingBetsDiceCommand(roundData.RoundRank, new List<DangoIdToDiceNum>(racingBetsInstanceRoundAction.DiceInfo.DiceInfo));
					break;
				case RacingBetsRoundActionType.DangoMove:
					racingBetsCommandBase = this.PushRacingBetsDangoMoveCommand(racingBetsInstanceRoundAction.Move);
					break;
				case RacingBetsRoundActionType.DangoSkill:
					racingBetsCommandBase = this.PushRacingBetsSkillCommand(racingBetsInstanceRoundAction.Skill);
					break;
				case RacingBetsRoundActionType.DangoChangeHigh:
					racingBetsCommandBase = this.PushRacingBetsDangoChangeHighCommand(racingBetsInstanceRoundAction.ChangeHigh);
					break;
				case RacingBetsRoundActionType.CameraMove:
					racingBetsCommandBase = this.PushRacingBetsChangeDangoCameraBlendCommand(racingBetsInstanceRoundAction.CameraMove.DangoId);
					break;
				case RacingBetsRoundActionType.Destination:
					racingBetsCommandBase = this.PushRacingBetsDangoDestinationCommand(racingBetsInstanceRoundAction.Destination.DangoId);
					break;
				case RacingBetsRoundActionType.UpdateRank:
					racingBetsCommandBase = this.PushRacingBetsDangoRankChangeCommand(new List<int>(racingBetsInstanceRoundAction.UpdateRank.DangoId));
					break;
				case RacingBetsRoundActionType.Transmit:
					racingBetsCommandBase = this.PushRacingBetsDangoTransmitCommand(racingBetsInstanceRoundAction.Transmit);
					break;
				case RacingBetsRoundActionType.OrganEffect:
					racingBetsCommandBase = this.PushRacingBetsOrganEffectCommand(racingBetsInstanceRoundAction.OrganEffect);
					break;
				case RacingBetsRoundActionType.BlackHoleTransmit:
					racingBetsCommandBase = this.PushRacingBetsBlackHoleTransmitCommand(racingBetsInstanceRoundAction.BlackHoleTransmit);
					break;
				}
				racingBetsCommandBase.ActionIndex = racingBetsInstanceRoundAction.ActionIndex;
				racingBetsCommandBase.PushBulletScreenTimes(new List<BulletScreenTimes>(racingBetsInstanceRoundAction.BulletScreenTimes));
			}
		}

		// Token: 0x06028DB3 RID: 167347 RVA: 0x00B77124 File Offset: 0x00B75324
		public bool RefreshBetsDangoRankInfo(List<int> dangoRankList)
		{
			bool flag = false;
			int num = 1;
			foreach (int key in dangoRankList)
			{
				RacingBetsDungeonDangoInfo racingBetsDungeonDangoInfo;
				if (this.DungeonDangoMap.TryGetValue(key, out racingBetsDungeonDangoInfo) && !racingBetsDungeonDangoInfo.IsAbuDango())
				{
					if (racingBetsDungeonDangoInfo.Rank != num)
					{
						flag = true;
					}
					racingBetsDungeonDangoInfo.LastRank = racingBetsDungeonDangoInfo.Rank;
					racingBetsDungeonDangoInfo.Rank = num;
					num++;
				}
			}
			if (flag)
			{
				this.DungeonDangoSortList.Sort((RacingBetsDungeonDangoInfo a, RacingBetsDungeonDangoInfo b) => a.Rank.CompareTo(b.Rank));
			}
			return flag;
		}

		// Token: 0x06028DB4 RID: 167348 RVA: 0x00B771DC File Offset: 0x00B753DC
		private RacingBetsCommandBase PushDungeonInitCommand(List<RacingBetsDungeonDangoInfo> dangoInfoList)
		{
			int id = this.SeasonData.Id;
			IReadOnlyList<RacingBetMapPoint> racingBetMapPointList = RacingBetsConfig.Instance.GetRacingBetMapPointList(id);
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsInitDungeonCommand(dangoInfoList, racingBetMapPointList, id);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DB5 RID: 167349 RVA: 0x00B77218 File Offset: 0x00B75418
		private RacingBetsCommandBase PushOpenGamePlayViewCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateOpenRacingBetsGameplayView();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DB6 RID: 167350 RVA: 0x00B77238 File Offset: 0x00B75438
		private RacingBetsCommandBase PushOpenGamePlayerPreviewViewCommand(bool canCameraInput = false)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateOpenRacingBetsGamePlayPreviewView(canCameraInput);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DB7 RID: 167351 RVA: 0x00B7725C File Offset: 0x00B7545C
		private RacingBetsCommandBase PushRacingBetsDungeonBeginCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDungeonBeginCommand();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DB8 RID: 167352 RVA: 0x00B7727C File Offset: 0x00B7547C
		private RacingBetsCommandBase PushRacingBetsRoundStartCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsRoundStartCommand();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DB9 RID: 167353 RVA: 0x00B7729C File Offset: 0x00B7549C
		private RacingBetsCommandBase PushRacingBetsDangoRoundStartCommand(int dangoId)
		{
			RacingBetsDangoRoundStartCommand racingBetsDangoRoundStartCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoRoundStartCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsDangoRoundStartCommand);
			return racingBetsDangoRoundStartCommand;
		}

		// Token: 0x06028DBA RID: 167354 RVA: 0x00B772C0 File Offset: 0x00B754C0
		private RacingBetsCommandBase PushRacingBetsDiceCommand(int round, List<DangoIdToDiceNum> dangoDiceList)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDiceCommand(round, dangoDiceList);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DBB RID: 167355 RVA: 0x00B772E4 File Offset: 0x00B754E4
		private RacingBetsCommandBase PushRacingBetsSkillCommand(RacingBetsDangoActionSkill skillAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsSkillCommand(skillAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DBC RID: 167356 RVA: 0x00B77308 File Offset: 0x00B75508
		private RacingBetsCommandBase PushRacingBetsDangoMoveCommand(RacingBetsDangoActionMove moveAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoMoveCommand(moveAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DBD RID: 167357 RVA: 0x00B7732C File Offset: 0x00B7552C
		private RacingBetsCommandBase PushRacingBetsDangoChangeHighCommand(RacingBetsDangoActionChangeHigh changeHighAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoChangeHighCommand(changeHighAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DBE RID: 167358 RVA: 0x00B77350 File Offset: 0x00B75550
		private RacingBetsCommandBase PushRacingBetsChangeDangoCameraBlendCommand(int dangoId)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsChangeDangoCameraBlendCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DBF RID: 167359 RVA: 0x00B77374 File Offset: 0x00B75574
		private RacingBetsCommandBase PushRacingBetsNextRoundRequestCommand(int activityId, int legMatchId, int roundId)
		{
			RacingBetsNextRoundRequestCommand racingBetsNextRoundRequestCommand = DangoDungeonCommandFactory.CreateRacingBetsNextRoundRequestCommand(activityId, legMatchId, roundId);
			this.CommandQueue.AddCommand(racingBetsNextRoundRequestCommand);
			return racingBetsNextRoundRequestCommand;
		}

		// Token: 0x06028DC0 RID: 167360 RVA: 0x00B77398 File Offset: 0x00B75598
		private RacingBetsCommandBase PushOpenRacingBetsDungeonResultViewCommand(RacingBetsLegMatchData legMatchData)
		{
			OpenRacingBetsDungeonResultViewCommand openRacingBetsDungeonResultViewCommand = DangoDungeonCommandFactory.CreateOpenRacingBetsDungeonResultView(legMatchData);
			this.CommandQueue.AddCommand(openRacingBetsDungeonResultViewCommand);
			return openRacingBetsDungeonResultViewCommand;
		}

		// Token: 0x06028DC1 RID: 167361 RVA: 0x00B773BC File Offset: 0x00B755BC
		private RacingBetsCommandBase PushRacingBetsDangoDestinationCommand(int dangoId)
		{
			RacingBetsDangoDestinationCommand racingBetsDangoDestinationCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoDestinationCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsDangoDestinationCommand);
			return racingBetsDangoDestinationCommand;
		}

		// Token: 0x06028DC2 RID: 167362 RVA: 0x00B773E0 File Offset: 0x00B755E0
		private RacingBetsCommandBase PushRacingBetsDangoRankChangeCommand(List<int> rankList)
		{
			RacingBetsDangoRankChangeCommand racingBetsDangoRankChangeCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoRankChangeCommand(rankList);
			this.CommandQueue.AddCommand(racingBetsDangoRankChangeCommand);
			return racingBetsDangoRankChangeCommand;
		}

		// Token: 0x06028DC3 RID: 167363 RVA: 0x00B77404 File Offset: 0x00B75604
		private RacingBetsCommandBase PushRacingBetsDangoTransmitCommand(RacingBetsDangoActionTransmit transmitAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoTransmitCommand(transmitAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DC4 RID: 167364 RVA: 0x00B77428 File Offset: 0x00B75628
		private RacingBetsCommandBase PushRacingBetsBlackHoleTransmitCommand(RacingBetsDangoActionBlackHoleTransmit transmitAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsBlackHoleTransmitCommand(transmitAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DC5 RID: 167365 RVA: 0x00B7744C File Offset: 0x00B7564C
		private RacingBetsCommandBase PushRacingBetsOrganEffectCommand(RacingBetsOrganEffect organEffectAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsOrganEffectCommand(organEffectAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06028DC6 RID: 167366 RVA: 0x00B77470 File Offset: 0x00B75670
		public UniTask OnDangoDungeonEnd(bool isAborted)
		{
			RacingBetsModel.<OnDangoDungeonEnd>d__53 <OnDangoDungeonEnd>d__;
			<OnDangoDungeonEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDangoDungeonEnd>d__.<>4__this = this;
			<OnDangoDungeonEnd>d__.<>1__state = -1;
			<OnDangoDungeonEnd>d__.<>t__builder.Start<RacingBetsModel.<OnDangoDungeonEnd>d__53>(ref <OnDangoDungeonEnd>d__);
			return <OnDangoDungeonEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06028DC7 RID: 167367 RVA: 0x00B774B3 File Offset: 0x00B756B3
		public void OnDangoDungeonPreviewEnd(bool isAborted)
		{
			if (this.LeaveDungeonOnEnd)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
			}
		}

		// Token: 0x06028DC8 RID: 167368 RVA: 0x00B774D0 File Offset: 0x00B756D0
		public void CloseDangoGamePlayPreviewView()
		{
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.RacingBetsGamePlayPreviewView.ToString(), true);
			UiSceneDangoActorManager.SetAllActorVisible(true);
			this.RefreshDangoActivityAudio();
			UiManager.Instance.CloseView(EUiViewName.RacingBetsGamePlayPreviewView, delegate(bool _)
			{
				this.ClearDungeonEffects();
				this.IsDungeonPlaying = false;
				this.HideAllDangoEntity();
				UiLayer.Instance.SetShowMaskLayer(EUiViewName.RacingBetsGamePlayPreviewView.ToString(), false);
			});
		}

		// Token: 0x06028DC9 RID: 167369 RVA: 0x00B77520 File Offset: 0x00B75720
		private void HideAllDangoEntity()
		{
			ChessModel.Instance.ClearAll();
			foreach (RacingBetsDungeonDangoInfo racingBetsDungeonDangoInfo in this.DungeonDangoMap.Values)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(racingBetsDungeonDangoInfo.EntityId);
				if (entity != null)
				{
					CreatureController.Instance.SetEntityEnable(entity.Entity, false, "RacingBetsModel inactive dango", false);
				}
			}
		}

		// Token: 0x06028DCA RID: 167370 RVA: 0x00B775A8 File Offset: 0x00B757A8
		public void RacingBetsAbortDungeon()
		{
			DangoDungeonCommandQueue commandQueue = this.CommandQueue;
			if (commandQueue == null)
			{
				return;
			}
			commandQueue.Abort();
		}

		// Token: 0x06028DCB RID: 167371 RVA: 0x00B775BC File Offset: 0x00B757BC
		private void RefreshDangoDungeonAudio(int dungeonMatchId)
		{
			RacingBetsLegMatchData legMatchData = this.SeasonData.GetLegMatchData(dungeonMatchId);
			if (legMatchData.GroupMatchType == ERacingBetsGroupMatchType.Final)
			{
				AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceFinals.ToString(), true);
				return;
			}
			if (legMatchData.Type == 1)
			{
				AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceGroupStage.ToString(), true);
				return;
			}
			AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceMatchPoint.ToString(), true);
		}

		// Token: 0x06028DCC RID: 167372 RVA: 0x00B7764C File Offset: 0x00B7584C
		private void RefreshDangoActivityAudio()
		{
			if (this.SeasonData.GetCurLegMatchData().GetLegMatchState() == ERacingBetsLegMatchState.EndOfMatch)
			{
				AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceFinals.ToString(), true);
				return;
			}
			AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.None.ToString(), true);
		}

		// Token: 0x06028DCD RID: 167373 RVA: 0x00B776AD File Offset: 0x00B758AD
		public List<RacingBetsDungeonDangoInfo> GetDungeonRankDangoList()
		{
			return this.DungeonDangoSortList;
		}

		// Token: 0x06028DCE RID: 167374 RVA: 0x00B776B8 File Offset: 0x00B758B8
		public List<RacingBetsDungeonDangoInfo> GetDungeonDangoListForGamePreview(RacingBetsLegMatchData legMatchData)
		{
			if (legMatchData.Type == 2)
			{
				return this.GetDungeonRankDangoList();
			}
			List<RacingBetsDungeonDangoInfo> list = new List<RacingBetsDungeonDangoInfo>();
			foreach (IRacingBetsDangoActorData racingBetsDangoActorData in legMatchData.GetAllDangoActorDataList())
			{
				if (!racingBetsDangoActorData.IsAbuDango)
				{
					RacingBetsDungeonDangoInfo dungeonDangoInfo = this.GetDungeonDangoInfo(racingBetsDangoActorData.DangoId);
					if (dungeonDangoInfo != null)
					{
						list.Add(dungeonDangoInfo);
					}
				}
			}
			return list;
		}

		// Token: 0x06028DCF RID: 167375 RVA: 0x00B7773C File Offset: 0x00B7593C
		[NullableContext(2)]
		public RacingBetsDungeonDangoInfo GetDungeonDangoInfo(int dangoId)
		{
			RacingBetsDungeonDangoInfo result;
			if (this.DungeonDangoMap.TryGetValue(dangoId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06028DD0 RID: 167376 RVA: 0x00B7775C File Offset: 0x00B7595C
		public int GetDungeonDangoEntityId(int dangoId)
		{
			RacingBetsDungeonDangoInfo racingBetsDungeonDangoInfo;
			if (!this.DungeonDangoMap.TryGetValue(dangoId, out racingBetsDungeonDangoInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.BB;
				string message = "团子副本无团子数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dangoId", dangoId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			return (int)racingBetsDungeonDangoInfo.EntityId;
		}

		// Token: 0x06028DD1 RID: 167377 RVA: 0x00B777B4 File Offset: 0x00B759B4
		public bool IsDungeonBettingDango(int dangoId)
		{
			RacingBetsLegMatchData racingBetsLegMatchData = this.GetRacingBetsLegMatchData(this.DungeonMatchId);
			return racingBetsLegMatchData != null && racingBetsLegMatchData.BetDangoId == dangoId;
		}

		// Token: 0x06028DD2 RID: 167378 RVA: 0x00B777DC File Offset: 0x00B759DC
		public int GetCommandActionIndex()
		{
			return this.CommandQueue.CurCommandActionIndex;
		}

		// Token: 0x06028DD3 RID: 167379 RVA: 0x00B777EC File Offset: 0x00B759EC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<UMaterialParameterCollection> LoadDiceMaterialParameterCollection()
		{
			RacingBetsModel.<LoadDiceMaterialParameterCollection>d__66 <LoadDiceMaterialParameterCollection>d__;
			<LoadDiceMaterialParameterCollection>d__.<>t__builder = AsyncUniTaskMethodBuilder<UMaterialParameterCollection>.Create();
			<LoadDiceMaterialParameterCollection>d__.<>4__this = this;
			<LoadDiceMaterialParameterCollection>d__.<>1__state = -1;
			<LoadDiceMaterialParameterCollection>d__.<>t__builder.Start<RacingBetsModel.<LoadDiceMaterialParameterCollection>d__66>(ref <LoadDiceMaterialParameterCollection>d__);
			return <LoadDiceMaterialParameterCollection>d__.<>t__builder.Task;
		}

		// Token: 0x06028DD4 RID: 167380 RVA: 0x00B77830 File Offset: 0x00B75A30
		public bool CheckInRacingBetsDungeon()
		{
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon;
			return instance != null && ((instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null).GetValueOrDefault() == 31 && GameModeController.Instance.IsInInstance();
		}

		// Token: 0x06028DD5 RID: 167381 RVA: 0x00B7789B File Offset: 0x00B75A9B
		public void AddDungeonEffectHandle(int effectId)
		{
			if (effectId != 0)
			{
				this.DungeonEffectHandles.Add(effectId);
			}
		}

		// Token: 0x06028DD6 RID: 167382 RVA: 0x00B778AC File Offset: 0x00B75AAC
		public void AddPointEffect(int pointId, IRacingBetsEffectData effectData)
		{
			if (effectData.Handle != 0)
			{
				List<IRacingBetsEffectData> list;
				if (!this.DungeonPointEffectMap.TryGetValue(pointId, out list))
				{
					list = new List<IRacingBetsEffectData>();
					this.DungeonPointEffectMap[pointId] = list;
				}
				list.Add(effectData);
			}
		}

		// Token: 0x06028DD7 RID: 167383 RVA: 0x00B778EC File Offset: 0x00B75AEC
		public void RefreshPointDynamicEffect(int pointId)
		{
			List<IRacingBetsEffectData> list;
			if (!this.DungeonPointEffectMap.TryGetValue(pointId, out list) || list.Count == 0)
			{
				return;
			}
			IRacingBetsEffectData racingBetsEffectData = null;
			foreach (IRacingBetsEffectData racingBetsEffectData2 in list)
			{
				if (EffectSystem.Instance.IsValid(racingBetsEffectData2.Handle) && racingBetsEffectData2.Type == ERacingBetsEffectType.Dynamic)
				{
					racingBetsEffectData = racingBetsEffectData2;
					break;
				}
			}
			if (racingBetsEffectData == null)
			{
				return;
			}
			StackableChessboardPoint stackableChessboardPoint = ChessModel.Instance.GetChessboardPoint(pointId) as StackableChessboardPoint;
			if (stackableChessboardPoint == null)
			{
				return;
			}
			bool flag = stackableChessboardPoint.HasItem();
			EffectSystem instance = EffectSystem.Instance;
			int handle = racingBetsEffectData.Handle;
			bool bHidden = flag;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[RefreshPointDynamicEffect] Point ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(pointId);
			defaultInterpolatedStringHandler.AppendLiteral(" has item: ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
			instance.SetEffectHidden(handle, bHidden, defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x06028DD8 RID: 167384 RVA: 0x00B779E0 File Offset: 0x00B75BE0
		public void SetActivePointEffect(int pointId, ERacingBetsEffectType type, bool isActive)
		{
			List<IRacingBetsEffectData> list;
			if (!this.DungeonPointEffectMap.TryGetValue(pointId, out list) || list.Count == 0)
			{
				return;
			}
			IRacingBetsEffectData racingBetsEffectData = null;
			foreach (IRacingBetsEffectData racingBetsEffectData2 in list)
			{
				if (EffectSystem.Instance.IsValid(racingBetsEffectData2.Handle) && racingBetsEffectData2.Type == type)
				{
					racingBetsEffectData = racingBetsEffectData2;
					break;
				}
			}
			if (racingBetsEffectData == null)
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			int handle = racingBetsEffectData.Handle;
			bool bHidden = !isActive;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[SetActivePointDynamicEffect] Point ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(pointId);
			defaultInterpolatedStringHandler.AppendLiteral(" is active: ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(isActive);
			instance.SetEffectHidden(handle, bHidden, defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x06028DD9 RID: 167385 RVA: 0x00B77AB4 File Offset: 0x00B75CB4
		public void RefreshPointsDynamicEffects(List<int> pointIds)
		{
			foreach (int pointId in new HashSet<int>(pointIds))
			{
				this.RefreshPointDynamicEffect(pointId);
			}
		}

		// Token: 0x06028DDA RID: 167386 RVA: 0x00B77B08 File Offset: 0x00B75D08
		[NullableContext(2)]
		public IRacingBetsEffectData GetPointEffectByType(int pointId, ERacingBetsEffectType type)
		{
			List<IRacingBetsEffectData> list;
			if (!this.DungeonPointEffectMap.TryGetValue(pointId, out list) || list.Count == 0)
			{
				return null;
			}
			foreach (IRacingBetsEffectData racingBetsEffectData in list)
			{
				if (racingBetsEffectData.Type == type)
				{
					return racingBetsEffectData;
				}
			}
			return null;
		}

		// Token: 0x06028DDB RID: 167387 RVA: 0x00B77B7C File Offset: 0x00B75D7C
		private void ClearDungeonEffects()
		{
			foreach (int num in this.DungeonEffectHandles)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, "[RacingBetsModel.ClearDungeonEffects]", true, null);
				}
			}
			this.DungeonEffectHandles.Clear();
			this.DungeonPointEffectMap.Clear();
		}

		// Token: 0x06028DDC RID: 167388 RVA: 0x00B77C08 File Offset: 0x00B75E08
		public bool GetIsFromActivityOpenDungeon()
		{
			bool isFromActivityOpenDungeon = this.IsFromActivityOpenDungeon;
			this.IsFromActivityOpenDungeon = false;
			return isFromActivityOpenDungeon;
		}

		// Token: 0x06028DDD RID: 167389 RVA: 0x00B77C17 File Offset: 0x00B75E17
		public void SetIsFromActivityOpenDungeon()
		{
			this.IsFromActivityOpenDungeon = true;
		}

		// Token: 0x06028DDE RID: 167390 RVA: 0x00B77C20 File Offset: 0x00B75E20
		public List<IRacingBetsRankData> GetRankData()
		{
			return this.RankData;
		}

		// Token: 0x06028DDF RID: 167391 RVA: 0x00B77C28 File Offset: 0x00B75E28
		[NullableContext(2)]
		public IRacingBetsSelfRankData GetSelfRank()
		{
			return this.SelfRankData;
		}

		// Token: 0x06028DE0 RID: 167392 RVA: 0x00B77C30 File Offset: 0x00B75E30
		public void RacingBetsRankRefresh(RacingBetsRankResponse data)
		{
			this.RankData = new List<IRacingBetsRankData>();
			if (data.SelfData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "团子排行榜数据异常，没有自身数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", data);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RacingBetsRankStatus status = data.Status;
			this.SelfRankData = new RacingBetsSelfRankData
			{
				RankStatus = status,
				RankNum = 0,
				HeadIcon = data.SelfData.HeadIcon,
				Name = data.SelfData.Name,
				HitNum = data.SelfData.HitNum,
				CashNum = data.SelfData.Cash
			};
			if (status == RacingBetsRankStatus.Top50)
			{
				this.SelfRankData.RankNum = data.PercentScore;
			}
			PlayerInfoModel instance2 = PlayerInfoModel.Instance;
			int? num = (instance2 != null) ? instance2.GetId() : null;
			foreach (RacingBetRankPlayerInfo racingBetRankPlayerInfo in data.PlayerInfo)
			{
				RacingBetsRankData racingBetsRankData = new RacingBetsRankData
				{
					PlayerId = racingBetRankPlayerInfo.PlayerId,
					PlayerHeadPhoto = racingBetRankPlayerInfo.HeadIcon,
					RankNum = racingBetRankPlayerInfo.Rank,
					Name = racingBetRankPlayerInfo.Name,
					HitNum = racingBetRankPlayerInfo.HitNum,
					CashNum = racingBetRankPlayerInfo.Cash
				};
				if (status == RacingBetsRankStatus.Rank)
				{
					int playerId = racingBetsRankData.PlayerId;
					int? num2 = num;
					if (playerId == num2.GetValueOrDefault() & num2 != null)
					{
						this.SelfRankData.RankNum = racingBetsRankData.RankNum;
					}
				}
				this.RankData.Add(racingBetsRankData);
			}
		}

		// Token: 0x06028DE1 RID: 167393 RVA: 0x00B77DE8 File Offset: 0x00B75FE8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RacingBetsLegMatchData> GetRacingBetsHistoryData()
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			List<RacingBetsLegMatchData> reverseLegMatchList = this.SeasonData.GetReverseLegMatchList();
			List<RacingBetsLegMatchData> list = new List<RacingBetsLegMatchData>();
			foreach (RacingBetsLegMatchData racingBetsLegMatchData in reverseLegMatchList)
			{
				if (racingBetsLegMatchData.GetLegMatchState() != ERacingBetsLegMatchState.NotOpen)
				{
					list.Add(racingBetsLegMatchData);
				}
			}
			return list;
		}

		// Token: 0x06028DE2 RID: 167394 RVA: 0x00B77E5C File Offset: 0x00B7605C
		public void SetViewRedDotState(ELocalStoragePlayerKey localStorageKey)
		{
			RacingBetsRedDotState racingBetsRedDotState = LocalStorage.GetPlayer<RacingBetsRedDotState>(localStorageKey, null);
			if (racingBetsRedDotState != null)
			{
				racingBetsRedDotState.HasViewed = true;
			}
			else
			{
				racingBetsRedDotState = this.CreateDefaultRedDotState();
			}
			LocalStorage.SetPlayer<RacingBetsRedDotState>(localStorageKey, racingBetsRedDotState);
		}

		// Token: 0x06028DE3 RID: 167395 RVA: 0x00B77E8C File Offset: 0x00B7608C
		public RacingBetsRedDotState CreateDefaultRedDotState()
		{
			return new RacingBetsRedDotState
			{
				HasViewed = true,
				LastViewedData = 0L
			};
		}

		// Token: 0x06028DE4 RID: 167396 RVA: 0x00B77EA2 File Offset: 0x00B760A2
		[NullableContext(2)]
		private static object GetSettlementMainViewRecordRaw()
		{
			return LocalStorage.GetPlayer<object>(ELocalStoragePlayerKey.RacingBetsSettlementMainViewRecord, null);
		}

		// Token: 0x06028DE5 RID: 167397 RVA: 0x00B77EB0 File Offset: 0x00B760B0
		[NullableContext(2)]
		private static IRacingBetsSettlementMainViewRecord ParseSettlementMainViewRecord(object raw)
		{
			if (raw != null)
			{
				Dictionary<string, object> dictionary = raw as Dictionary<string, object>;
				if (dictionary != null)
				{
					object obj;
					if (dictionary.TryGetValue("SeasonId", out obj) && obj is int)
					{
						int seasonId = (int)obj;
						object obj2;
						if (dictionary.TryGetValue("ViewedLegMatchIds", out obj2))
						{
							IList list = obj2 as IList;
							if (list != null)
							{
								List<int> list2 = new List<int>();
								foreach (object obj3 in list)
								{
									if (obj3 is int)
									{
										int item = (int)obj3;
										list2.Add(item);
									}
								}
								return new RacingBetsSettlementMainViewRecord
								{
									SeasonId = seasonId,
									ViewedLegMatchIds = list2
								};
							}
						}
						return null;
					}
					return null;
				}
			}
			return null;
		}

		// Token: 0x06028DE6 RID: 167398 RVA: 0x00B77F88 File Offset: 0x00B76188
		public bool HasViewedSettlementMainView(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetSettlementMainViewRecordRaw());
			return racingBetsSettlementMainViewRecord != null && racingBetsSettlementMainViewRecord.SeasonId == seasonId && racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId);
		}

		// Token: 0x06028DE7 RID: 167399 RVA: 0x00B77FBC File Offset: 0x00B761BC
		public void MarkSettlementMainViewViewed(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetSettlementMainViewRecordRaw());
			if (racingBetsSettlementMainViewRecord == null || racingBetsSettlementMainViewRecord.SeasonId != seasonId)
			{
				racingBetsSettlementMainViewRecord = new RacingBetsSettlementMainViewRecord
				{
					SeasonId = seasonId,
					ViewedLegMatchIds = new List<int>()
				};
			}
			if (!racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId))
			{
				racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Add(legMatchId);
				LocalStorage.SetPlayer<IRacingBetsSettlementMainViewRecord>(ELocalStoragePlayerKey.RacingBetsSettlementMainViewRecord, racingBetsSettlementMainViewRecord);
			}
		}

		// Token: 0x06028DE8 RID: 167400 RVA: 0x00B7801E File Offset: 0x00B7621E
		[NullableContext(2)]
		private static object GetBettingMainViewRecordRaw()
		{
			return LocalStorage.GetPlayer<object>(ELocalStoragePlayerKey.RacingBetsBettingMainViewRecord, null);
		}

		// Token: 0x06028DE9 RID: 167401 RVA: 0x00B7802C File Offset: 0x00B7622C
		public bool HasEnteredBettingMainView(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetBettingMainViewRecordRaw());
			return racingBetsSettlementMainViewRecord != null && racingBetsSettlementMainViewRecord.SeasonId == seasonId && racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId);
		}

		// Token: 0x06028DEA RID: 167402 RVA: 0x00B78060 File Offset: 0x00B76260
		public void MarkBettingMainViewEntered(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetBettingMainViewRecordRaw());
			if (racingBetsSettlementMainViewRecord == null || racingBetsSettlementMainViewRecord.SeasonId != seasonId)
			{
				racingBetsSettlementMainViewRecord = new RacingBetsSettlementMainViewRecord
				{
					SeasonId = seasonId,
					ViewedLegMatchIds = new List<int>()
				};
			}
			if (!racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId))
			{
				racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Add(legMatchId);
				LocalStorage.SetPlayer<IRacingBetsSettlementMainViewRecord>(ELocalStoragePlayerKey.RacingBetsBettingMainViewRecord, racingBetsSettlementMainViewRecord);
			}
		}

		// Token: 0x06028DEB RID: 167403 RVA: 0x00B780C2 File Offset: 0x00B762C2
		private void SetRankRedDotTimer(int delayTime)
		{
			this.RankTimerHandle = TimerSystem.RealTimeInstance.EmitOnTime(delegate(float _)
			{
				this.CheckRankRedDot();
			}, (double)(delayTime * TimeUtil.Instance.InverseMillisecond + 20), null, null, true, 1f);
		}

		// Token: 0x06028DEC RID: 167404 RVA: 0x00B780F8 File Offset: 0x00B762F8
		private void RemoveRankTimer()
		{
			if (this.RankTimerHandle != null)
			{
				TimerSystem.RealTimeInstance.Remove(this.RankTimerHandle);
				this.RankTimerHandle = null;
			}
		}

		// Token: 0x06028DED RID: 167405 RVA: 0x00B7811C File Offset: 0x00B7631C
		public void CheckRankRedDot()
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.RemoveRankTimer();
			RacingBetsRedDotState racingBetsRedDotState = LocalStorage.GetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsRankViewRecord, null) ?? RacingBetsModel.Instance.CreateDefaultRedDotState();
			ValueTuple<int, int> curLegMatchRankOpenTime = this.SeasonData.GetCurLegMatchRankOpenTime();
			int item = curLegMatchRankOpenTime.Item1;
			int item2 = curLegMatchRankOpenTime.Item2;
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			bool hasViewed = racingBetsRedDotState.HasViewed;
			long lastViewedData = racingBetsRedDotState.LastViewedData;
			if ((long)item > lastViewedData)
			{
				if ((double)item > serverTimeStamp)
				{
					this.SetRankRedDotTimer((int)((double)item - serverTimeStamp + 1.0));
					return;
				}
				racingBetsRedDotState.HasViewed = false;
				racingBetsRedDotState.LastViewedData = (long)item;
				LocalStorage.SetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsRankViewRecord, racingBetsRedDotState);
				EventSystem.Instance.Emit(EEventName.OnRacingBetsRedDotUpdate);
				if (item2 != 0 && (double)item2 > serverTimeStamp)
				{
					this.SetRankRedDotTimer((int)((double)item2 - serverTimeStamp + 1.0));
					return;
				}
			}
			else if (hasViewed && item2 != 0 && (double)item2 > serverTimeStamp)
			{
				this.SetRankRedDotTimer((int)((double)item2 - serverTimeStamp + 1.0));
			}
		}

		// Token: 0x06028DEE RID: 167406 RVA: 0x00B78210 File Offset: 0x00B76410
		public void CheckMatchRedDot()
		{
			if (this.SeasonData == null)
			{
				return;
			}
			RacingBetsRedDotState racingBetsRedDotState = LocalStorage.GetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsMatchViewRecord, null) ?? RacingBetsModel.Instance.CreateDefaultRedDotState();
			int num = 0;
			RacingBetsLegMatchData curLegMatchData = this.SeasonData.GetCurLegMatchData();
			if (curLegMatchData != null)
			{
				int id = curLegMatchData.Id;
				if (curLegMatchData.IsLegMatchFinished())
				{
					num = id;
				}
				else
				{
					num = Math.Max(0, id - 1);
				}
			}
			if (!racingBetsRedDotState.HasViewed || (long)num > racingBetsRedDotState.LastViewedData)
			{
				racingBetsRedDotState.HasViewed = false;
				racingBetsRedDotState.LastViewedData = (long)num;
				LocalStorage.SetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsMatchViewRecord, racingBetsRedDotState);
				EventSystem.Instance.Emit(EEventName.OnRacingBetsRedDotUpdate);
			}
		}

		// Token: 0x06028DEF RID: 167407 RVA: 0x00B782AB File Offset: 0x00B764AB
		public int GetRacingBetsBulletScreenAlpha()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenAlphaRecord, 100);
		}

		// Token: 0x06028DF0 RID: 167408 RVA: 0x00B782B9 File Offset: 0x00B764B9
		public void SetRacingBetsBulletScreenAlpha(int alpha)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenAlphaRecord, alpha);
		}

		// Token: 0x06028DF1 RID: 167409 RVA: 0x00B782C7 File Offset: 0x00B764C7
		public int GetRacingBetsBulletScreenShowType()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenShowTypeRecord, 2);
		}

		// Token: 0x06028DF2 RID: 167410 RVA: 0x00B782D4 File Offset: 0x00B764D4
		public void SetRacingBetsBulletScreenShowType(int showType)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenShowTypeRecord, showType);
		}

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x06028DF3 RID: 167411 RVA: 0x00B782E2 File Offset: 0x00B764E2
		public int RayTracingShadowsValue
		{
			get
			{
				return this.RayTracingShadowsValueInternal;
			}
		}

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x06028DF4 RID: 167412 RVA: 0x00B782EA File Offset: 0x00B764EA
		public int DlssValue
		{
			get
			{
				return this.DlssValueInternal;
			}
		}

		// Token: 0x06028DF5 RID: 167413 RVA: 0x00B782F2 File Offset: 0x00B764F2
		public void SetVisionValue(int rayTracingValue, int dlssValue)
		{
			this.RayTracingShadowsValueInternal = rayTracingValue;
			this.DlssValueInternal = dlssValue;
		}

		// Token: 0x06028DF6 RID: 167414 RVA: 0x00B78304 File Offset: 0x00B76504
		public List<int> GetAdvanceMatchDangoList(ERacingBetsMatchTableType matchType)
		{
			List<int> list = new List<int>();
			foreach (int matchId in RacingBetsConfig.Instance.GetMatchTableConfigById((int)matchType).Value.GetAdvancedDangoIdSourceGroupMatchListArray())
			{
				RacingBetsGroupMatchData racingBetsGroupMatchData = this.GetRacingBetsGroupMatchData(matchId);
				list.AddRange(racingBetsGroupMatchData.GetPromoteDangoList());
			}
			return list;
		}

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x06028DF7 RID: 167415 RVA: 0x00B7835F File Offset: 0x00B7655F
		public static RacingBetsModel Instance
		{
			get
			{
				return RacingBetsModel._Instance;
			}
		}

		// Token: 0x06028DF8 RID: 167416 RVA: 0x00B78366 File Offset: 0x00B76566
		public static RacingBetsModel GetOrCreateInstance()
		{
			if (RacingBetsModel._Instance == null)
			{
				RacingBetsModel.CreateInstance();
			}
			return RacingBetsModel._Instance;
		}

		// Token: 0x06028DF9 RID: 167417 RVA: 0x00B7837A File Offset: 0x00B7657A
		public static bool CreateInstance()
		{
			if (RacingBetsModel._Instance != null)
			{
				return true;
			}
			RacingBetsModel._Instance = new RacingBetsModel();
			return true;
		}

		// Token: 0x06028DFA RID: 167418 RVA: 0x00B78390 File Offset: 0x00B76590
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028DFB RID: 167419 RVA: 0x00B78392 File Offset: 0x00B76592
		public static void ResetStaticDefaultValue()
		{
			RacingBetsModel._Instance = null;
		}

		// Token: 0x06028DFC RID: 167420 RVA: 0x00B7839A File Offset: 0x00B7659A
		static RacingBetsModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsModel.CreateStaticDefaultValue), new Action(RacingBetsModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401636E RID: 90990
		[Nullable(2)]
		private RacingBetsSeasonData SeasonData;

		// Token: 0x0401636F RID: 90991
		[Nullable(2)]
		private RacingBetLegMatchResultNotify LegMatchResult;

		// Token: 0x04016370 RID: 90992
		public bool UseGmState;

		// Token: 0x04016371 RID: 90993
		private readonly Dictionary<int, RacingBetsDungeonDangoInfo> DungeonDangoMap = new Dictionary<int, RacingBetsDungeonDangoInfo>();

		// Token: 0x04016372 RID: 90994
		private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

		// Token: 0x04016373 RID: 90995
		private List<RacingBetsDungeonDangoInfo> DungeonAllDangoList = new List<RacingBetsDungeonDangoInfo>();

		// Token: 0x04016374 RID: 90996
		private readonly DangoDungeonCommandQueue CommandQueue = new DangoDungeonCommandQueue();

		// Token: 0x04016375 RID: 90997
		[Nullable(2)]
		private UMaterialParameterCollection DiceMaterialParameterCollection;

		// Token: 0x04016376 RID: 90998
		public bool IsDungeonPlaying;

		// Token: 0x04016377 RID: 90999
		public int DungeonMatchId;

		// Token: 0x04016378 RID: 91000
		public bool IsReplayDungeon;

		// Token: 0x04016379 RID: 91001
		public bool LeaveDungeonOnEnd;

		// Token: 0x0401637A RID: 91002
		private readonly List<int> DungeonEffectHandles = new List<int>();

		// Token: 0x0401637B RID: 91003
		private readonly Dictionary<int, List<IRacingBetsEffectData>> DungeonPointEffectMap = new Dictionary<int, List<IRacingBetsEffectData>>();

		// Token: 0x0401637C RID: 91004
		private List<IRacingBetsRankData> RankData = new List<IRacingBetsRankData>();

		// Token: 0x0401637D RID: 91005
		[Nullable(2)]
		private IRacingBetsSelfRankData SelfRankData;

		// Token: 0x0401637E RID: 91006
		[Nullable(2)]
		private TimerHandle RankTimerHandle;

		// Token: 0x0401637F RID: 91007
		private bool IsFromActivityOpenDungeon;

		// Token: 0x04016380 RID: 91008
		private int RayTracingShadowsValueInternal;

		// Token: 0x04016381 RID: 91009
		private int DlssValueInternal;

		// Token: 0x04016382 RID: 91010
		[Nullable(2)]
		private static RacingBetsModel _Instance;
	}
}
