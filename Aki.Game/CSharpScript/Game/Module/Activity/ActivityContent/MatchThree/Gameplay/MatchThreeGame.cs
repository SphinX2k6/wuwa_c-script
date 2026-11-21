using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005429 RID: 21545
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGame
	{
		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x06035837 RID: 219191 RVA: 0x00EF1CED File Offset: 0x00EEFEED
		public int MaxTurns { get; }

		// Token: 0x1700681F RID: 26655
		// (get) Token: 0x06035838 RID: 219192 RVA: 0x00EF1CF5 File Offset: 0x00EEFEF5
		public int Score
		{
			get
			{
				return this.ResultKeeper.Score;
			}
		}

		// Token: 0x06035839 RID: 219193 RVA: 0x00EF1D02 File Offset: 0x00EEFF02
		public int ClearedCountOf(EPieceType type)
		{
			return this.ResultKeeper.ClearedCountOf(type);
		}

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x0603583A RID: 219194 RVA: 0x00EF1D10 File Offset: 0x00EEFF10
		public MatchThreeStatsKeeper Stats { get; }

		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x0603583B RID: 219195 RVA: 0x00EF1D18 File Offset: 0x00EEFF18
		// (set) Token: 0x0603583C RID: 219196 RVA: 0x00EF1D20 File Offset: 0x00EEFF20
		public EMatchThreeGameState State { get; private set; }

		// Token: 0x17006822 RID: 26658
		// (get) Token: 0x0603583D RID: 219197 RVA: 0x00EF1D29 File Offset: 0x00EEFF29
		// (set) Token: 0x0603583E RID: 219198 RVA: 0x00EF1D31 File Offset: 0x00EEFF31
		public bool InputLocked { get; private set; }

		// Token: 0x17006823 RID: 26659
		// (get) Token: 0x0603583F RID: 219199 RVA: 0x00EF1D3A File Offset: 0x00EEFF3A
		public bool IsResolveAborted
		{
			get
			{
				return this.Resolver.IsAborted;
			}
		}

		// Token: 0x06035840 RID: 219200 RVA: 0x00EF1D47 File Offset: 0x00EEFF47
		public void AbortResolve()
		{
			this.Resolver.AbortResolve();
		}

		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x06035841 RID: 219201 RVA: 0x00EF1D54 File Offset: 0x00EEFF54
		// (set) Token: 0x06035842 RID: 219202 RVA: 0x00EF1D5C File Offset: 0x00EEFF5C
		public int RemainingTurns { get; private set; }

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x06035843 RID: 219203 RVA: 0x00EF1D65 File Offset: 0x00EEFF65
		// (set) Token: 0x06035844 RID: 219204 RVA: 0x00EF1D6D File Offset: 0x00EEFF6D
		public int LastTurnCostDelta { get; private set; }

		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x06035845 RID: 219205 RVA: 0x00EF1D76 File Offset: 0x00EEFF76
		public Board Board
		{
			get
			{
				return this.Resolver.Board;
			}
		}

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x06035846 RID: 219206 RVA: 0x00EF1D83 File Offset: 0x00EEFF83
		public IReadOnlyList<LevelMechanic> Mechanics
		{
			get
			{
				return this.Resolver.LevelMechanics;
			}
		}

		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x06035847 RID: 219207 RVA: 0x00EF1D90 File Offset: 0x00EEFF90
		public int Round
		{
			get
			{
				return this.Resolver.CurrentRound;
			}
		}

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x06035848 RID: 219208 RVA: 0x00EF1D9D File Offset: 0x00EEFF9D
		public int Energy
		{
			get
			{
				return this.Resolver.CurrentEnergy;
			}
		}

		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x06035849 RID: 219209 RVA: 0x00EF1DAA File Offset: 0x00EEFFAA
		public int FullEnergy
		{
			get
			{
				return this.Resolver.FullEnergy;
			}
		}

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x0603584A RID: 219210 RVA: 0x00EF1DB7 File Offset: 0x00EEFFB7
		public IReadOnlyList<ValidMove> LastValidMoves
		{
			get
			{
				return this.Resolver.LastValidMoves;
			}
		}

		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x0603584B RID: 219211 RVA: 0x00EF1DC4 File Offset: 0x00EEFFC4
		// (set) Token: 0x0603584C RID: 219212 RVA: 0x00EF1DCC File Offset: 0x00EEFFCC
		public bool LastSwapAccepted { get; private set; }

		// Token: 0x0603584D RID: 219213 RVA: 0x00EF1DD5 File Offset: 0x00EEFFD5
		public void CollectSkillPoints(List<SkillPointDisplayData> buffer, int displayEnergy)
		{
			this.Resolver.CollectSkillPoints(buffer, displayEnergy);
		}

		// Token: 0x0603584E RID: 219214 RVA: 0x00EF1DE4 File Offset: 0x00EEFFE4
		[NullableContext(2)]
		public static MatchThreeGame Create(int level, int roleId, int seed = 0)
		{
			MatchThreeGameplay? gameplayConfig = MatchThreeConfig.Instance.GetGameplayConfig(level);
			if (gameplayConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "局内配置缺失: MatchThreeGameplay";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", level);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			Board board = new Board();
			if (!board.Apply(gameplayConfig.Value.Board))
			{
				return null;
			}
			IReadOnlyList<LevelGoal> levelGoals = LevelGoalsProvider.GetLevelGoals(level);
			ResultKeeper resultKeeper = new ResultKeeper();
			List<ISolvedSequencesConsumer> list = new List<ISolvedSequencesConsumer>(levelGoals.Count + 2)
			{
				resultKeeper
			};
			foreach (LevelGoal item in levelGoals)
			{
				list.Add(item);
			}
			IReadOnlyList<LevelMechanic> levelMechanics = LevelMechanicProvider.GetLevelMechanics(level);
			GameRandom rng = new GameRandom((seed != 0) ? seed : Environment.TickCount);
			int[] fillRulesArray = gameplayConfig.Value.GetFillRulesArray();
			MatchThreeStatsKeeper matchThreeStatsKeeper = new MatchThreeStatsKeeper();
			list.Add(matchThreeStatsKeeper);
			return new MatchThreeGame(new GameplayResolver(board, MatchThreeGame.CreateSkills(roleId), list, levelMechanics, gameplayConfig.Value.ExchangeEnergy, fillRulesArray, rng, matchThreeStatsKeeper), levelGoals, gameplayConfig.Value.TurnCount, resultKeeper, matchThreeStatsKeeper, rng, gameplayConfig.Value.Board);
		}

		// Token: 0x0603584F RID: 219215 RVA: 0x00EF1F4C File Offset: 0x00EF014C
		private unsafe static List<ISkill> CreateSkills(int roleId)
		{
			List<ISkill> list = new List<ISkill>();
			if (roleId <= 0)
			{
				return list;
			}
			MatchThreeRole? roleConfig = MatchThreeConfig.Instance.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "角色配置缺失: MatchThreeRole";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", roleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			int[] skillsArray = roleConfig.Value.GetSkillsArray();
			if (skillsArray == null)
			{
				return list;
			}
			foreach (int num in skillsArray)
			{
				MatchThreeSkill? skillConfig = MatchThreeConfig.Instance.GetSkillConfig(num);
				if (skillConfig == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.MatchThree;
					ELogAuthor author2 = ELogAuthor.CB;
					string message2 = "技能配置缺失: MatchThreeSkill";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleId", roleId);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					MatchThreeSkill value = skillConfig.Value;
					ISkill skill = SkillFactory.Create(value);
					if (skill != null)
					{
						list.Add(skill);
					}
				}
			}
			return list;
		}

		// Token: 0x06035850 RID: 219216 RVA: 0x00EF2080 File Offset: 0x00EF0280
		public MatchThreeGame(GameplayResolver resolver, IReadOnlyList<LevelGoal> goals, int maxTurns, ResultKeeper resultKeeper, MatchThreeStatsKeeper stats, GameRandom rng, int boardId)
		{
			this.Resolver = resolver;
			this.Goals = goals;
			this.MaxTurns = maxTurns;
			this.RemainingTurns = maxTurns;
			this.BoardId = boardId;
			this.ResultKeeper = resultKeeper;
			this.Stats = stats;
			this.Rng = rng;
			this.Resolver.OnSegmentPlay = new Action<int>(this.RaiseSegmentPlay);
			this.Resolver.AllGoalsAchieved = new Func<bool>(this.HasAchievedAllGoals);
			this.Resolver.IsFinalTurn = new Func<int, bool>(this.WillExhaustTurns);
			this.Resolver.RefreshValidMove();
			foreach (LevelGoal levelGoal in this.Goals)
			{
				levelGoal.Achieved = (Action<LevelGoal>)Delegate.Combine(levelGoal.Achieved, new Action<LevelGoal>(this.HandleGoalAchieved));
			}
		}

		// Token: 0x06035851 RID: 219217 RVA: 0x00EF2190 File Offset: 0x00EF0390
		public bool Reset(int seed = 0)
		{
			if (this.InputLocked)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[Reset] 解算未结束，拒绝重开";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("State", this.State);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Rng.Reseed((seed != 0) ? seed : Environment.TickCount);
			if (!this.Board.Apply(this.BoardId))
			{
				return false;
			}
			this.Resolver.Reset();
			this.Resolver.RefreshValidMove();
			this.ResultKeeper.Reset();
			this.Stats.Reset();
			foreach (LevelGoal levelGoal in this.Goals)
			{
				levelGoal.Reset();
			}
			this.AchievedGoals = 0;
			this.RemainingTurns = this.MaxTurns;
			this.LastTurnCostDelta = 0;
			this.LastSwapAccepted = false;
			this.AcceptedSwaps.Clear();
			this.State = EMatchThreeGameState.WaitingInput;
			return true;
		}

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x06035852 RID: 219218 RVA: 0x00EF22A4 File Offset: 0x00EF04A4
		public bool CanRewind
		{
			get
			{
				return this.AcceptedSwaps.Count > 0 && this.State != EMatchThreeGameState.Win && this.State != EMatchThreeGameState.Lose;
			}
		}

		// Token: 0x06035853 RID: 219219 RVA: 0x00EF22CC File Offset: 0x00EF04CC
		[NullableContext(0)]
		public UniTask<bool> RewindAsync(int turns)
		{
			MatchThreeGame.<RewindAsync>d__62 <RewindAsync>d__;
			<RewindAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RewindAsync>d__.<>4__this = this;
			<RewindAsync>d__.turns = turns;
			<RewindAsync>d__.<>1__state = -1;
			<RewindAsync>d__.<>t__builder.Start<MatchThreeGame.<RewindAsync>d__62>(ref <RewindAsync>d__);
			return <RewindAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x06035854 RID: 219220 RVA: 0x00EF2318 File Offset: 0x00EF0518
		public bool CanLowerGoalDifficulty
		{
			get
			{
				using (IEnumerator<LevelGoal> enumerator = this.Goals.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.CanLowerDifficulty)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06035855 RID: 219221 RVA: 0x00EF236C File Offset: 0x00EF056C
		public void LowerGoalDifficulty()
		{
			foreach (LevelGoal levelGoal in this.Goals)
			{
				levelGoal.LowerDifficulty();
			}
		}

		// Token: 0x06035856 RID: 219222 RVA: 0x00EF23B8 File Offset: 0x00EF05B8
		private void RaiseSegmentPlay(int trailCharge)
		{
			Action<int> onSegmentPlay = this.OnSegmentPlay;
			if (onSegmentPlay == null)
			{
				return;
			}
			onSegmentPlay(trailCharge);
		}

		// Token: 0x06035857 RID: 219223 RVA: 0x00EF23CB File Offset: 0x00EF05CB
		public void BindPresenter(IMatchThreePresentation presenter)
		{
			this.Resolver.BindPresenter(presenter);
		}

		// Token: 0x06035858 RID: 219224 RVA: 0x00EF23DC File Offset: 0x00EF05DC
		public UniTask OnPlayerSwapInput(GridPosition a, GridPosition b)
		{
			MatchThreeGame.<OnPlayerSwapInput>d__68 <OnPlayerSwapInput>d__;
			<OnPlayerSwapInput>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayerSwapInput>d__.<>4__this = this;
			<OnPlayerSwapInput>d__.a = a;
			<OnPlayerSwapInput>d__.b = b;
			<OnPlayerSwapInput>d__.<>1__state = -1;
			<OnPlayerSwapInput>d__.<>t__builder.Start<MatchThreeGame.<OnPlayerSwapInput>d__68>(ref <OnPlayerSwapInput>d__);
			return <OnPlayerSwapInput>d__.<>t__builder.Task;
		}

		// Token: 0x06035859 RID: 219225 RVA: 0x00EF2430 File Offset: 0x00EF0630
		private void SettleOutcome(int turnCostDelta)
		{
			if (this.State == EMatchThreeGameState.Win || this.State == EMatchThreeGameState.Lose)
			{
				return;
			}
			this.LastTurnCostDelta = turnCostDelta;
			if (this.HasAchievedAllGoals())
			{
				this.State = EMatchThreeGameState.Win;
				Action onWin = this.OnWin;
				if (onWin == null)
				{
					return;
				}
				onWin();
				return;
			}
			else
			{
				this.RemainingTurns -= 1 + turnCostDelta;
				if (this.RemainingTurns < 0)
				{
					this.RemainingTurns = 0;
				}
				if (this.RemainingTurns > 0 && !this.Resolver.IsDeadlocked)
				{
					return;
				}
				if (this.AnyGoalUnachieved())
				{
					this.State = EMatchThreeGameState.Lose;
					Action onLose = this.OnLose;
					if (onLose == null)
					{
						return;
					}
					onLose();
					return;
				}
				else
				{
					this.State = EMatchThreeGameState.Win;
					Action onWin2 = this.OnWin;
					if (onWin2 == null)
					{
						return;
					}
					onWin2();
					return;
				}
			}
		}

		// Token: 0x0603585A RID: 219226 RVA: 0x00EF24E5 File Offset: 0x00EF06E5
		private void HandleGoalAchieved(LevelGoal goal)
		{
			this.AchievedGoals++;
		}

		// Token: 0x0603585B RID: 219227 RVA: 0x00EF24F5 File Offset: 0x00EF06F5
		private bool HasAchievedAllGoals()
		{
			return this.Goals.Count > 0 && this.AchievedGoals >= this.Goals.Count;
		}

		// Token: 0x0603585C RID: 219228 RVA: 0x00EF251D File Offset: 0x00EF071D
		private bool WillExhaustTurns(int turnCostDelta)
		{
			return this.RemainingTurns - (1 + turnCostDelta) <= 0;
		}

		// Token: 0x0603585D RID: 219229 RVA: 0x00EF2530 File Offset: 0x00EF0730
		private bool AnyGoalUnachieved()
		{
			using (IEnumerator<LevelGoal> enumerator = this.Goals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsAchieved)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603585E RID: 219230 RVA: 0x00EF2584 File Offset: 0x00EF0784
		public void Dispose()
		{
			this.Resolver.OnSegmentPlay = null;
			this.Resolver.AllGoalsAchieved = null;
			this.Resolver.IsFinalTurn = null;
			foreach (LevelGoal levelGoal in this.Goals)
			{
				levelGoal.Achieved = (Action<LevelGoal>)Delegate.Remove(levelGoal.Achieved, new Action<LevelGoal>(this.HandleGoalAchieved));
			}
		}

		// Token: 0x0401C400 RID: 115712
		private readonly GameplayResolver Resolver;

		// Token: 0x0401C401 RID: 115713
		private readonly ResultKeeper ResultKeeper;

		// Token: 0x0401C402 RID: 115714
		private readonly GameRandom Rng;

		// Token: 0x0401C403 RID: 115715
		[TupleElementNames(new string[]
		{
			"A",
			"B"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<GridPosition, GridPosition>> AcceptedSwaps = new List<ValueTuple<GridPosition, GridPosition>>();

		// Token: 0x0401C404 RID: 115716
		[TupleElementNames(new string[]
		{
			"A",
			"B"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<GridPosition, GridPosition>> ReplayBuffer = new List<ValueTuple<GridPosition, GridPosition>>();

		// Token: 0x0401C405 RID: 115717
		public readonly IReadOnlyList<LevelGoal> Goals;

		// Token: 0x0401C406 RID: 115718
		private readonly int BoardId;

		// Token: 0x0401C40B RID: 115723
		private int AchievedGoals;

		// Token: 0x0401C40E RID: 115726
		[Nullable(2)]
		public Action OnWin;

		// Token: 0x0401C40F RID: 115727
		[Nullable(2)]
		public Action OnLose;

		// Token: 0x0401C410 RID: 115728
		[Nullable(2)]
		public Action<int> OnSegmentPlay;
	}
}
