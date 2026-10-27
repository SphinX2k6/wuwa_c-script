using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004F24 RID: 20260
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RacingBetsModel : ModelBase
	{
		// Token: 0x06033F2F RID: 212783 RVA: 0x00C2D1AF File Offset: 0x00C2B3AF
		protected override bool OnClear()
		{
			this.ClearDungeonEffects();
			this.RemoveRankTimer();
			return true;
		}

		// Token: 0x06033F30 RID: 212784 RVA: 0x00C2D1C0 File Offset: 0x00C2B3C0
		public void OnPlayerInfoUpdate(RacingBetPlayerInfo playerInfo)
		{
			if (this.SeasonData == null)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "OnPlayerInfoUpdate SeasonData is not undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SeasonData.RefreshPlayerData(playerInfo);
		}

		// Token: 0x06033F31 RID: 212785 RVA: 0x00C2D201 File Offset: 0x00C2B401
		public void OnRacingBetsTaskNotify(RacingBetsTaskNotify message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.RefreshRewardData(message.TaskDatas.ToList<ConditionTaskData>());
		}

		// Token: 0x06033F32 RID: 212786 RVA: 0x00C2D222 File Offset: 0x00C2B422
		public void OnRacingBetsMatchInfoRefresh(RacingBetsMatchInfoResponse message)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.RefreshMatchInfo(message);
		}

		// Token: 0x06033F33 RID: 212787 RVA: 0x00C2D23C File Offset: 0x00C2B43C
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

		// Token: 0x06033F34 RID: 212788 RVA: 0x00C2D27C File Offset: 0x00C2B47C
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

		// Token: 0x06033F35 RID: 212789 RVA: 0x00C2D2AF File Offset: 0x00C2B4AF
		public void OnRacingBetsCloseSettleMenu(int legMatchId)
		{
			if (this.SeasonData == null)
			{
				return;
			}
			this.SeasonData.AddCloseSettleLegMatchId(legMatchId);
		}

		// Token: 0x06033F36 RID: 212790 RVA: 0x00C2D2C8 File Offset: 0x00C2B4C8
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

		// Token: 0x06033F37 RID: 212791 RVA: 0x00C2D316 File Offset: 0x00C2B516
		[NullableContext(2)]
		public RacingBetsSeasonData GetRacingBetsSeasonData()
		{
			return this.SeasonData;
		}

		// Token: 0x06033F38 RID: 212792 RVA: 0x00C2D320 File Offset: 0x00C2B520
		public void SetRacingBetsSeasonData(RacingBetsSeasonData data)
		{
			if (this.SeasonData != null)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "SetRacingBetsSeasonData SeasonData is not undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SeasonData = data;
		}

		// Token: 0x06033F39 RID: 212793 RVA: 0x00C2D35C File Offset: 0x00C2B55C
		[NullableContext(2)]
		public RacingBetsLegMatchData GetRacingBetsLegMatchData(int legMatchId)
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return this.SeasonData.GetLegMatchData(legMatchId);
		}

		// Token: 0x06033F3A RID: 212794 RVA: 0x00C2D374 File Offset: 0x00C2B574
		[NullableContext(2)]
		public RacingBetLegMatchResultNotify GetLegMatchResultData()
		{
			return this.LegMatchResult;
		}

		// Token: 0x06033F3B RID: 212795 RVA: 0x00C2D37C File Offset: 0x00C2B57C
		[NullableContext(2)]
		public void SetLegMatchResultData(RacingBetLegMatchResultNotify data)
		{
			this.LegMatchResult = data;
		}

		// Token: 0x06033F3C RID: 212796 RVA: 0x00C2D385 File Offset: 0x00C2B585
		[NullableContext(2)]
		public RacingBetsGroupMatchData GetRacingBetsGroupMatchData(int matchId)
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return this.SeasonData.GetGroupMatchData(matchId);
		}

		// Token: 0x06033F3D RID: 212797 RVA: 0x00C2D39D File Offset: 0x00C2B59D
		[NullableContext(2)]
		public IReadOnlyList<RacingBettingGear> GetRacingBetsGearList()
		{
			if (this.SeasonData == null)
			{
				return null;
			}
			return RacingBetsConfig.Instance.GetRacingBettingGearList(this.SeasonData.Id);
		}

		// Token: 0x06033F3E RID: 212798 RVA: 0x00C2D3C0 File Offset: 0x00C2B5C0
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

		// Token: 0x06033F3F RID: 212799 RVA: 0x00C2D45C File Offset: 0x00C2B65C
		public bool IsFinalLegMatch(int legMatchId)
		{
			return this.SeasonData != null && this.SeasonData.IsFinalLegMatch(legMatchId);
		}

		// Token: 0x06033F40 RID: 212800 RVA: 0x00C2D474 File Offset: 0x00C2B674
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
			this.InitDungeonDangoInfo(message.DangoInfo.ToList<RacingBetsInstanceDangoInfo>());
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

		// Token: 0x06033F41 RID: 212801 RVA: 0x00C2D55C File Offset: 0x00C2B75C
		private void InitDungeonDangoInfo(List<RacingBetsInstanceDangoInfo> dangoInfoList)
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

		// Token: 0x06033F42 RID: 212802 RVA: 0x00C2D664 File Offset: 0x00C2B864
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

		// Token: 0x06033F43 RID: 212803 RVA: 0x00C2D6C0 File Offset: 0x00C2B8C0
		public void RacingBetsMatchPreview(int legMatchId, RacingBetMatchInfoResponse message)
		{
			if (this.IsDungeonPlaying)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "RacingBets玩法重复开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IsDungeonPlaying = true;
			this.DungeonMatchId = legMatchId;
			this.InitDungeonDangoInfo(message.DangoInfo.ToList<RacingBetsInstanceDangoInfo>());
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
					goto IL_D3;
				}
			}
			list = this.DungeonAllDangoList;
			IL_D3:
			this.PushDungeonInitCommand(list);
			this.PushOpenGamePlayerPreviewViewCommand(true);
			this.CommandQueue.Execute().Forget();
		}

		// Token: 0x06033F44 RID: 212804 RVA: 0x00C2D7D0 File Offset: 0x00C2B9D0
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
					racingBetsCommandBase = this.PushRacingBetsDiceCommand(roundData.RoundRank, racingBetsInstanceRoundAction.DiceInfo.DiceInfo.ToList<DangoIdToDiceNum>());
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
					racingBetsCommandBase = this.PushRacingBetsDangoRankChangeCommand(racingBetsInstanceRoundAction.UpdateRank.DangoId.ToList<int>());
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
				racingBetsCommandBase.PushBulletScreenTimes(racingBetsInstanceRoundAction.BulletScreenTimes.ToList<BulletScreenTimes>());
			}
		}

		// Token: 0x06033F45 RID: 212805 RVA: 0x00C2D97C File Offset: 0x00C2BB7C
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

		// Token: 0x06033F46 RID: 212806 RVA: 0x00C2DA34 File Offset: 0x00C2BC34
		private RacingBetsCommandBase PushDungeonInitCommand(List<RacingBetsDungeonDangoInfo> dangoInfoList)
		{
			int id = this.SeasonData.Id;
			IReadOnlyList<RacingBetMapPoint> racingBetMapPointList = RacingBetsConfig.Instance.GetRacingBetMapPointList(id);
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsInitDungeonCommand(dangoInfoList, racingBetMapPointList, id);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F47 RID: 212807 RVA: 0x00C2DA70 File Offset: 0x00C2BC70
		private RacingBetsCommandBase PushOpenGamePlayViewCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateOpenRacingBetsGameplayView();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F48 RID: 212808 RVA: 0x00C2DA90 File Offset: 0x00C2BC90
		private RacingBetsCommandBase PushOpenGamePlayerPreviewViewCommand(bool canCameraInput = false)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateOpenRacingBetsGamePlayPreviewView(canCameraInput);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F49 RID: 212809 RVA: 0x00C2DAB4 File Offset: 0x00C2BCB4
		private RacingBetsCommandBase PushRacingBetsDungeonBeginCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDungeonBeginCommand();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F4A RID: 212810 RVA: 0x00C2DAD4 File Offset: 0x00C2BCD4
		private RacingBetsCommandBase PushRacingBetsRoundStartCommand()
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsRoundStartCommand();
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F4B RID: 212811 RVA: 0x00C2DAF4 File Offset: 0x00C2BCF4
		private RacingBetsCommandBase PushRacingBetsDangoRoundStartCommand(int dangoId)
		{
			RacingBetsDangoRoundStartCommand racingBetsDangoRoundStartCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoRoundStartCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsDangoRoundStartCommand);
			return racingBetsDangoRoundStartCommand;
		}

		// Token: 0x06033F4C RID: 212812 RVA: 0x00C2DB18 File Offset: 0x00C2BD18
		private RacingBetsCommandBase PushRacingBetsDiceCommand(int round, List<DangoIdToDiceNum> dangoDiceList)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDiceCommand(round, dangoDiceList);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F4D RID: 212813 RVA: 0x00C2DB3C File Offset: 0x00C2BD3C
		private RacingBetsCommandBase PushRacingBetsSkillCommand(RacingBetsDangoActionSkill skillAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsSkillCommand(skillAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F4E RID: 212814 RVA: 0x00C2DB60 File Offset: 0x00C2BD60
		private RacingBetsCommandBase PushRacingBetsDangoMoveCommand(RacingBetsDangoActionMove moveAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoMoveCommand(moveAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F4F RID: 212815 RVA: 0x00C2DB84 File Offset: 0x00C2BD84
		private RacingBetsCommandBase PushRacingBetsDangoChangeHighCommand(RacingBetsDangoActionChangeHigh changeHighAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoChangeHighCommand(changeHighAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F50 RID: 212816 RVA: 0x00C2DBA8 File Offset: 0x00C2BDA8
		private RacingBetsCommandBase PushRacingBetsChangeDangoCameraBlendCommand(int dangoId)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsChangeDangoCameraBlendCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F51 RID: 212817 RVA: 0x00C2DBCC File Offset: 0x00C2BDCC
		private RacingBetsCommandBase PushRacingBetsNextRoundRequestCommand(int activityId, int legMatchId, int roundId)
		{
			RacingBetsNextRoundRequestCommand racingBetsNextRoundRequestCommand = DangoDungeonCommandFactory.CreateRacingBetsNextRoundRequestCommand(activityId, legMatchId, roundId);
			this.CommandQueue.AddCommand(racingBetsNextRoundRequestCommand);
			return racingBetsNextRoundRequestCommand;
		}

		// Token: 0x06033F52 RID: 212818 RVA: 0x00C2DBF0 File Offset: 0x00C2BDF0
		private RacingBetsCommandBase PushOpenRacingBetsDungeonResultViewCommand(RacingBetsLegMatchData legMatchData)
		{
			OpenRacingBetsDungeonResultViewCommand openRacingBetsDungeonResultViewCommand = DangoDungeonCommandFactory.CreateOpenRacingBetsDungeonResultView(legMatchData);
			this.CommandQueue.AddCommand(openRacingBetsDungeonResultViewCommand);
			return openRacingBetsDungeonResultViewCommand;
		}

		// Token: 0x06033F53 RID: 212819 RVA: 0x00C2DC14 File Offset: 0x00C2BE14
		private RacingBetsCommandBase PushRacingBetsDangoDestinationCommand(int dangoId)
		{
			RacingBetsDangoDestinationCommand racingBetsDangoDestinationCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoDestinationCommand(dangoId);
			this.CommandQueue.AddCommand(racingBetsDangoDestinationCommand);
			return racingBetsDangoDestinationCommand;
		}

		// Token: 0x06033F54 RID: 212820 RVA: 0x00C2DC38 File Offset: 0x00C2BE38
		private RacingBetsCommandBase PushRacingBetsDangoRankChangeCommand(List<int> rankList)
		{
			RacingBetsDangoRankChangeCommand racingBetsDangoRankChangeCommand = DangoDungeonCommandFactory.CreateRacingBetsDangoRankChangeCommand(rankList);
			this.CommandQueue.AddCommand(racingBetsDangoRankChangeCommand);
			return racingBetsDangoRankChangeCommand;
		}

		// Token: 0x06033F55 RID: 212821 RVA: 0x00C2DC5C File Offset: 0x00C2BE5C
		private RacingBetsCommandBase PushRacingBetsDangoTransmitCommand(RacingBetsDangoActionTransmit transmitAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsDangoTransmitCommand(transmitAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F56 RID: 212822 RVA: 0x00C2DC80 File Offset: 0x00C2BE80
		private RacingBetsCommandBase PushRacingBetsBlackHoleTransmitCommand(RacingBetsDangoActionBlackHoleTransmit transmitAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsBlackHoleTransmitCommand(transmitAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F57 RID: 212823 RVA: 0x00C2DCA4 File Offset: 0x00C2BEA4
		private RacingBetsCommandBase PushRacingBetsOrganEffectCommand(RacingBetsOrganEffect organEffectAction)
		{
			RacingBetsCommandBase racingBetsCommandBase = DangoDungeonCommandFactory.CreateRacingBetsOrganEffectCommand(organEffectAction);
			this.CommandQueue.AddCommand(racingBetsCommandBase);
			return racingBetsCommandBase;
		}

		// Token: 0x06033F58 RID: 212824 RVA: 0x00C2DCC8 File Offset: 0x00C2BEC8
		public UniTask OnDangoDungeonEnd(bool isAborted)
		{
			RacingBetsModel.<OnDangoDungeonEnd>d__53 <OnDangoDungeonEnd>d__;
			<OnDangoDungeonEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDangoDungeonEnd>d__.<>4__this = this;
			<OnDangoDungeonEnd>d__.<>1__state = -1;
			<OnDangoDungeonEnd>d__.<>t__builder.Start<RacingBetsModel.<OnDangoDungeonEnd>d__53>(ref <OnDangoDungeonEnd>d__);
			return <OnDangoDungeonEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06033F59 RID: 212825 RVA: 0x00C2DD0B File Offset: 0x00C2BF0B
		public void OnDangoDungeonPreviewEnd(bool isAborted)
		{
			if (this.LeaveDungeonOnEnd)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
			}
		}

		// Token: 0x06033F5A RID: 212826 RVA: 0x00C2DD28 File Offset: 0x00C2BF28
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

		// Token: 0x06033F5B RID: 212827 RVA: 0x00C2DD78 File Offset: 0x00C2BF78
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

		// Token: 0x06033F5C RID: 212828 RVA: 0x00C2DE00 File Offset: 0x00C2C000
		public void RacingBetsAbortDungeon()
		{
			DangoDungeonCommandQueue commandQueue = this.CommandQueue;
			if (commandQueue == null)
			{
				return;
			}
			commandQueue.Abort();
		}

		// Token: 0x06033F5D RID: 212829 RVA: 0x00C2DE14 File Offset: 0x00C2C014
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

		// Token: 0x06033F5E RID: 212830 RVA: 0x00C2DEA4 File Offset: 0x00C2C0A4
		private void RefreshDangoActivityAudio()
		{
			if (this.SeasonData.GetCurLegMatchData().GetLegMatchState() == ERacingBetsLegMatchState.EndOfMatch)
			{
				AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceFinals.ToString(), true);
				return;
			}
			AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.None.ToString(), true);
		}

		// Token: 0x06033F5F RID: 212831 RVA: 0x00C2DF05 File Offset: 0x00C2C105
		public List<RacingBetsDungeonDangoInfo> GetDungeonRankDangoList()
		{
			return this.DungeonDangoSortList;
		}

		// Token: 0x06033F60 RID: 212832 RVA: 0x00C2DF10 File Offset: 0x00C2C110
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

		// Token: 0x06033F61 RID: 212833 RVA: 0x00C2DF94 File Offset: 0x00C2C194
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

		// Token: 0x06033F62 RID: 212834 RVA: 0x00C2DFB4 File Offset: 0x00C2C1B4
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

		// Token: 0x06033F63 RID: 212835 RVA: 0x00C2E00C File Offset: 0x00C2C20C
		public bool IsDungeonBettingDango(int dangoId)
		{
			RacingBetsLegMatchData racingBetsLegMatchData = this.GetRacingBetsLegMatchData(this.DungeonMatchId);
			return racingBetsLegMatchData != null && racingBetsLegMatchData.BetDangoId == dangoId;
		}

		// Token: 0x06033F64 RID: 212836 RVA: 0x00C2E034 File Offset: 0x00C2C234
		public int GetCommandActionIndex()
		{
			return this.CommandQueue.CurCommandActionIndex;
		}

		// Token: 0x06033F65 RID: 212837 RVA: 0x00C2E044 File Offset: 0x00C2C244
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

		// Token: 0x06033F66 RID: 212838 RVA: 0x00C2E088 File Offset: 0x00C2C288
		public bool CheckInRacingBetsDungeon()
		{
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon;
			return instance != null && ((instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null).GetValueOrDefault() == 31 && GameModeController.Instance.IsInInstance();
		}

		// Token: 0x06033F67 RID: 212839 RVA: 0x00C2E0F3 File Offset: 0x00C2C2F3
		public void AddDungeonEffectHandle(int effectId)
		{
			if (effectId != 0)
			{
				this.DungeonEffectHandles.Add(effectId);
			}
		}

		// Token: 0x06033F68 RID: 212840 RVA: 0x00C2E104 File Offset: 0x00C2C304
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

		// Token: 0x06033F69 RID: 212841 RVA: 0x00C2E144 File Offset: 0x00C2C344
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

		// Token: 0x06033F6A RID: 212842 RVA: 0x00C2E238 File Offset: 0x00C2C438
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

		// Token: 0x06033F6B RID: 212843 RVA: 0x00C2E30C File Offset: 0x00C2C50C
		public void RefreshPointsDynamicEffects(List<int> pointIds)
		{
			foreach (int pointId in new HashSet<int>(pointIds))
			{
				this.RefreshPointDynamicEffect(pointId);
			}
		}

		// Token: 0x06033F6C RID: 212844 RVA: 0x00C2E360 File Offset: 0x00C2C560
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

		// Token: 0x06033F6D RID: 212845 RVA: 0x00C2E3D4 File Offset: 0x00C2C5D4
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

		// Token: 0x06033F6E RID: 212846 RVA: 0x00C2E460 File Offset: 0x00C2C660
		public bool GetIsFromActivityOpenDungeon()
		{
			bool isFromActivityOpenDungeon = this.IsFromActivityOpenDungeon;
			this.IsFromActivityOpenDungeon = false;
			return isFromActivityOpenDungeon;
		}

		// Token: 0x06033F6F RID: 212847 RVA: 0x00C2E46F File Offset: 0x00C2C66F
		public void SetIsFromActivityOpenDungeon()
		{
			this.IsFromActivityOpenDungeon = true;
		}

		// Token: 0x06033F70 RID: 212848 RVA: 0x00C2E478 File Offset: 0x00C2C678
		public List<IRacingBetsRankData> GetRankData()
		{
			return this.RankData;
		}

		// Token: 0x06033F71 RID: 212849 RVA: 0x00C2E480 File Offset: 0x00C2C680
		[NullableContext(2)]
		public IRacingBetsSelfRankData GetSelfRank()
		{
			return this.SelfRankData;
		}

		// Token: 0x06033F72 RID: 212850 RVA: 0x00C2E488 File Offset: 0x00C2C688
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

		// Token: 0x06033F73 RID: 212851 RVA: 0x00C2E640 File Offset: 0x00C2C840
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

		// Token: 0x06033F74 RID: 212852 RVA: 0x00C2E6B4 File Offset: 0x00C2C8B4
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

		// Token: 0x06033F75 RID: 212853 RVA: 0x00C2E6E4 File Offset: 0x00C2C8E4
		public RacingBetsRedDotState CreateDefaultRedDotState()
		{
			return new RacingBetsRedDotState
			{
				HasViewed = true,
				LastViewedData = 0L
			};
		}

		// Token: 0x06033F76 RID: 212854 RVA: 0x00C2E6FA File Offset: 0x00C2C8FA
		[NullableContext(2)]
		private static object GetSettlementMainViewRecordRaw()
		{
			return LocalStorage.GetPlayer<object>(ELocalStoragePlayerKey.RacingBetsSettlementMainViewRecord, null);
		}

		// Token: 0x06033F77 RID: 212855 RVA: 0x00C2E708 File Offset: 0x00C2C908
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

		// Token: 0x06033F78 RID: 212856 RVA: 0x00C2E7E0 File Offset: 0x00C2C9E0
		public bool HasViewedSettlementMainView(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetSettlementMainViewRecordRaw());
			return racingBetsSettlementMainViewRecord != null && racingBetsSettlementMainViewRecord.SeasonId == seasonId && racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId);
		}

		// Token: 0x06033F79 RID: 212857 RVA: 0x00C2E814 File Offset: 0x00C2CA14
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

		// Token: 0x06033F7A RID: 212858 RVA: 0x00C2E876 File Offset: 0x00C2CA76
		[NullableContext(2)]
		private static object GetBettingMainViewRecordRaw()
		{
			return LocalStorage.GetPlayer<object>(ELocalStoragePlayerKey.RacingBetsBettingMainViewRecord, null);
		}

		// Token: 0x06033F7B RID: 212859 RVA: 0x00C2E884 File Offset: 0x00C2CA84
		public bool HasEnteredBettingMainView(int seasonId, int legMatchId)
		{
			IRacingBetsSettlementMainViewRecord racingBetsSettlementMainViewRecord = RacingBetsModel.ParseSettlementMainViewRecord(RacingBetsModel.GetBettingMainViewRecordRaw());
			return racingBetsSettlementMainViewRecord != null && racingBetsSettlementMainViewRecord.SeasonId == seasonId && racingBetsSettlementMainViewRecord.ViewedLegMatchIds.Contains(legMatchId);
		}

		// Token: 0x06033F7C RID: 212860 RVA: 0x00C2E8B8 File Offset: 0x00C2CAB8
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

		// Token: 0x06033F7D RID: 212861 RVA: 0x00C2E91A File Offset: 0x00C2CB1A
		private void SetRankRedDotTimer(int delayTime)
		{
			this.RankTimerHandle = TimerSystem.RealTimeInstance.EmitOnTime(delegate(float _)
			{
				this.CheckRankRedDot();
			}, (double)(delayTime * TimeUtil.Instance.InverseMillisecond + 20), null, null, true, 1f);
		}

		// Token: 0x06033F7E RID: 212862 RVA: 0x00C2E950 File Offset: 0x00C2CB50
		private void RemoveRankTimer()
		{
			if (this.RankTimerHandle != null)
			{
				TimerSystem.RealTimeInstance.Remove(this.RankTimerHandle);
				this.RankTimerHandle = null;
			}
		}

		// Token: 0x06033F7F RID: 212863 RVA: 0x00C2E974 File Offset: 0x00C2CB74
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

		// Token: 0x06033F80 RID: 212864 RVA: 0x00C2EA68 File Offset: 0x00C2CC68
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

		// Token: 0x06033F81 RID: 212865 RVA: 0x00C2EB03 File Offset: 0x00C2CD03
		public int GetRacingBetsBulletScreenAlpha()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenAlphaRecord, 100);
		}

		// Token: 0x06033F82 RID: 212866 RVA: 0x00C2EB11 File Offset: 0x00C2CD11
		public void SetRacingBetsBulletScreenAlpha(int alpha)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenAlphaRecord, alpha);
		}

		// Token: 0x06033F83 RID: 212867 RVA: 0x00C2EB1F File Offset: 0x00C2CD1F
		public int GetRacingBetsBulletScreenShowType()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenShowTypeRecord, 2);
		}

		// Token: 0x06033F84 RID: 212868 RVA: 0x00C2EB2C File Offset: 0x00C2CD2C
		public void SetRacingBetsBulletScreenShowType(int showType)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsBulletScreenShowTypeRecord, showType);
		}

		// Token: 0x17007F41 RID: 32577
		// (get) Token: 0x06033F85 RID: 212869 RVA: 0x00C2EB3A File Offset: 0x00C2CD3A
		public int RayTracingShadowsValue
		{
			get
			{
				return this.RayTracingShadowsValueInternal;
			}
		}

		// Token: 0x17007F42 RID: 32578
		// (get) Token: 0x06033F86 RID: 212870 RVA: 0x00C2EB42 File Offset: 0x00C2CD42
		public int DlssValue
		{
			get
			{
				return this.DlssValueInternal;
			}
		}

		// Token: 0x06033F87 RID: 212871 RVA: 0x00C2EB4A File Offset: 0x00C2CD4A
		public void SetVisionValue(int rayTracingValue, int dlssValue)
		{
			this.RayTracingShadowsValueInternal = rayTracingValue;
			this.DlssValueInternal = dlssValue;
		}

		// Token: 0x06033F88 RID: 212872 RVA: 0x00C2EB5C File Offset: 0x00C2CD5C
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

		// Token: 0x17007F43 RID: 32579
		// (get) Token: 0x06033F89 RID: 212873 RVA: 0x00C2EBB7 File Offset: 0x00C2CDB7
		public static RacingBetsModel Instance
		{
			get
			{
				return RacingBetsModel._Instance;
			}
		}

		// Token: 0x06033F8A RID: 212874 RVA: 0x00C2EBBE File Offset: 0x00C2CDBE
		public static RacingBetsModel GetOrCreateInstance()
		{
			if (RacingBetsModel._Instance == null)
			{
				RacingBetsModel.CreateInstance();
			}
			return RacingBetsModel._Instance;
		}

		// Token: 0x06033F8B RID: 212875 RVA: 0x00C2EBD2 File Offset: 0x00C2CDD2
		public static bool CreateInstance()
		{
			if (RacingBetsModel._Instance != null)
			{
				return true;
			}
			RacingBetsModel._Instance = new RacingBetsModel();
			return true;
		}

		// Token: 0x06033F8C RID: 212876 RVA: 0x00C2EBE8 File Offset: 0x00C2CDE8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033F8D RID: 212877 RVA: 0x00C2EBEA File Offset: 0x00C2CDEA
		public static void ResetStaticDefaultValue()
		{
			RacingBetsModel._Instance = null;
		}

		// Token: 0x06033F8E RID: 212878 RVA: 0x00C2EBF2 File Offset: 0x00C2CDF2
		static RacingBetsModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsModel.CreateStaticDefaultValue), new Action(RacingBetsModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B999 RID: 113049
		[Nullable(2)]
		private RacingBetsSeasonData SeasonData;

		// Token: 0x0401B99A RID: 113050
		[Nullable(2)]
		private RacingBetLegMatchResultNotify LegMatchResult;

		// Token: 0x0401B99B RID: 113051
		public bool UseGmState;

		// Token: 0x0401B99C RID: 113052
		private readonly Dictionary<int, RacingBetsDungeonDangoInfo> DungeonDangoMap = new Dictionary<int, RacingBetsDungeonDangoInfo>();

		// Token: 0x0401B99D RID: 113053
		private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

		// Token: 0x0401B99E RID: 113054
		private List<RacingBetsDungeonDangoInfo> DungeonAllDangoList = new List<RacingBetsDungeonDangoInfo>();

		// Token: 0x0401B99F RID: 113055
		private readonly DangoDungeonCommandQueue CommandQueue = new DangoDungeonCommandQueue();

		// Token: 0x0401B9A0 RID: 113056
		[Nullable(2)]
		private UMaterialParameterCollection DiceMaterialParameterCollection;

		// Token: 0x0401B9A1 RID: 113057
		public bool IsDungeonPlaying;

		// Token: 0x0401B9A2 RID: 113058
		public int DungeonMatchId;

		// Token: 0x0401B9A3 RID: 113059
		public bool IsReplayDungeon;

		// Token: 0x0401B9A4 RID: 113060
		public bool LeaveDungeonOnEnd;

		// Token: 0x0401B9A5 RID: 113061
		private readonly List<int> DungeonEffectHandles = new List<int>();

		// Token: 0x0401B9A6 RID: 113062
		private readonly Dictionary<int, List<IRacingBetsEffectData>> DungeonPointEffectMap = new Dictionary<int, List<IRacingBetsEffectData>>();

		// Token: 0x0401B9A7 RID: 113063
		private List<IRacingBetsRankData> RankData = new List<IRacingBetsRankData>();

		// Token: 0x0401B9A8 RID: 113064
		[Nullable(2)]
		private IRacingBetsSelfRankData SelfRankData;

		// Token: 0x0401B9A9 RID: 113065
		[Nullable(2)]
		private TimerHandle RankTimerHandle;

		// Token: 0x0401B9AA RID: 113066
		private bool IsFromActivityOpenDungeon;

		// Token: 0x0401B9AB RID: 113067
		private int RayTracingShadowsValueInternal;

		// Token: 0x0401B9AC RID: 113068
		private int DlssValueInternal;

		// Token: 0x0401B9AD RID: 113069
		[Nullable(2)]
		private static RacingBetsModel _Instance;
	}
}
