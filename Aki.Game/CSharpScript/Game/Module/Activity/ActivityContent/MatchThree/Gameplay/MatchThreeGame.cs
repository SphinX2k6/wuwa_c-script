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
	// Token: 0x020064AB RID: 25771
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGame
	{
		// Token: 0x170094BC RID: 38076
		// (get) Token: 0x06040B73 RID: 265075 RVA: 0x00FAACA5 File Offset: 0x00FA8EA5
		public int MaxTurns { get; }

		// Token: 0x170094BD RID: 38077
		// (get) Token: 0x06040B74 RID: 265076 RVA: 0x00FAACAD File Offset: 0x00FA8EAD
		public int Score
		{
			get
			{
				return this.ResultKeeper.Score;
			}
		}

		// Token: 0x06040B75 RID: 265077 RVA: 0x00FAACBA File Offset: 0x00FA8EBA
		public int ClearedCountOf(EPieceType type)
		{
			return this.ResultKeeper.ClearedCountOf(type);
		}

		// Token: 0x170094BE RID: 38078
		// (get) Token: 0x06040B76 RID: 265078 RVA: 0x00FAACC8 File Offset: 0x00FA8EC8
		public MatchThreeStatsKeeper Stats { get; }

		// Token: 0x170094BF RID: 38079
		// (get) Token: 0x06040B77 RID: 265079 RVA: 0x00FAACD0 File Offset: 0x00FA8ED0
		// (set) Token: 0x06040B78 RID: 265080 RVA: 0x00FAACD8 File Offset: 0x00FA8ED8
		public EMatchThreeGameState State { get; private set; }

		// Token: 0x170094C0 RID: 38080
		// (get) Token: 0x06040B79 RID: 265081 RVA: 0x00FAACE1 File Offset: 0x00FA8EE1
		// (set) Token: 0x06040B7A RID: 265082 RVA: 0x00FAACE9 File Offset: 0x00FA8EE9
		public bool InputLocked { get; private set; }

		// Token: 0x170094C1 RID: 38081
		// (get) Token: 0x06040B7B RID: 265083 RVA: 0x00FAACF2 File Offset: 0x00FA8EF2
		public bool IsResolveAborted
		{
			get
			{
				return this.Resolver.IsAborted;
			}
		}

		// Token: 0x06040B7C RID: 265084 RVA: 0x00FAACFF File Offset: 0x00FA8EFF
		public void AbortResolve()
		{
			this.Resolver.AbortResolve();
		}

		// Token: 0x170094C2 RID: 38082
		// (get) Token: 0x06040B7D RID: 265085 RVA: 0x00FAAD0C File Offset: 0x00FA8F0C
		// (set) Token: 0x06040B7E RID: 265086 RVA: 0x00FAAD14 File Offset: 0x00FA8F14
		public int RemainingTurns { get; private set; }

		// Token: 0x170094C3 RID: 38083
		// (get) Token: 0x06040B7F RID: 265087 RVA: 0x00FAAD1D File Offset: 0x00FA8F1D
		// (set) Token: 0x06040B80 RID: 265088 RVA: 0x00FAAD25 File Offset: 0x00FA8F25
		public int LastTurnCostDelta { get; private set; }

		// Token: 0x170094C4 RID: 38084
		// (get) Token: 0x06040B81 RID: 265089 RVA: 0x00FAAD2E File Offset: 0x00FA8F2E
		public Board Board
		{
			get
			{
				return this.Resolver.Board;
			}
		}

		// Token: 0x170094C5 RID: 38085
		// (get) Token: 0x06040B82 RID: 265090 RVA: 0x00FAAD3B File Offset: 0x00FA8F3B
		public IReadOnlyList<LevelMechanic> Mechanics
		{
			get
			{
				return this.Resolver.LevelMechanics;
			}
		}

		// Token: 0x170094C6 RID: 38086
		// (get) Token: 0x06040B83 RID: 265091 RVA: 0x00FAAD48 File Offset: 0x00FA8F48
		public int Round
		{
			get
			{
				return this.Resolver.CurrentRound;
			}
		}

		// Token: 0x170094C7 RID: 38087
		// (get) Token: 0x06040B84 RID: 265092 RVA: 0x00FAAD55 File Offset: 0x00FA8F55
		public int Energy
		{
			get
			{
				return this.Resolver.CurrentEnergy;
			}
		}

		// Token: 0x170094C8 RID: 38088
		// (get) Token: 0x06040B85 RID: 265093 RVA: 0x00FAAD62 File Offset: 0x00FA8F62
		public int FullEnergy
		{
			get
			{
				return this.Resolver.FullEnergy;
			}
		}

		// Token: 0x170094C9 RID: 38089
		// (get) Token: 0x06040B86 RID: 265094 RVA: 0x00FAAD6F File Offset: 0x00FA8F6F
		public IReadOnlyList<ValidMove> LastValidMoves
		{
			get
			{
				return this.Resolver.LastValidMoves;
			}
		}

		// Token: 0x170094CA RID: 38090
		// (get) Token: 0x06040B87 RID: 265095 RVA: 0x00FAAD7C File Offset: 0x00FA8F7C
		// (set) Token: 0x06040B88 RID: 265096 RVA: 0x00FAAD84 File Offset: 0x00FA8F84
		public bool LastSwapAccepted { get; private set; }

		// Token: 0x06040B89 RID: 265097 RVA: 0x00FAAD8D File Offset: 0x00FA8F8D
		public void CollectSkillPoints(List<SkillPointDisplayData> buffer, int displayEnergy)
		{
			this.Resolver.CollectSkillPoints(buffer, displayEnergy);
		}

		// Token: 0x06040B8A RID: 265098 RVA: 0x00FAAD9C File Offset: 0x00FA8F9C
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

		// Token: 0x06040B8B RID: 265099 RVA: 0x00FAAF04 File Offset: 0x00FA9104
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

		// Token: 0x06040B8C RID: 265100 RVA: 0x00FAB038 File Offset: 0x00FA9238
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

		// Token: 0x06040B8D RID: 265101 RVA: 0x00FAB148 File Offset: 0x00FA9348
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

		// Token: 0x170094CB RID: 38091
		// (get) Token: 0x06040B8E RID: 265102 RVA: 0x00FAB25C File Offset: 0x00FA945C
		public bool CanRewind
		{
			get
			{
				return this.AcceptedSwaps.Count > 0 && this.State != EMatchThreeGameState.Win && this.State != EMatchThreeGameState.Lose;
			}
		}

		// Token: 0x06040B8F RID: 265103 RVA: 0x00FAB284 File Offset: 0x00FA9484
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

		// Token: 0x170094CC RID: 38092
		// (get) Token: 0x06040B90 RID: 265104 RVA: 0x00FAB2D0 File Offset: 0x00FA94D0
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

		// Token: 0x06040B91 RID: 265105 RVA: 0x00FAB324 File Offset: 0x00FA9524
		public void LowerGoalDifficulty()
		{
			foreach (LevelGoal levelGoal in this.Goals)
			{
				levelGoal.LowerDifficulty();
			}
		}

		// Token: 0x06040B92 RID: 265106 RVA: 0x00FAB370 File Offset: 0x00FA9570
		private void RaiseSegmentPlay(int trailCharge)
		{
			Action<int> onSegmentPlay = this.OnSegmentPlay;
			if (onSegmentPlay == null)
			{
				return;
			}
			onSegmentPlay(trailCharge);
		}

		// Token: 0x06040B93 RID: 265107 RVA: 0x00FAB383 File Offset: 0x00FA9583
		public void BindPresenter(IMatchThreePresentation presenter)
		{
			this.Resolver.BindPresenter(presenter);
		}

		// Token: 0x06040B94 RID: 265108 RVA: 0x00FAB394 File Offset: 0x00FA9594
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

		// Token: 0x06040B95 RID: 265109 RVA: 0x00FAB3E8 File Offset: 0x00FA95E8
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

		// Token: 0x06040B96 RID: 265110 RVA: 0x00FAB49D File Offset: 0x00FA969D
		private void HandleGoalAchieved(LevelGoal goal)
		{
			this.AchievedGoals++;
		}

		// Token: 0x06040B97 RID: 265111 RVA: 0x00FAB4AD File Offset: 0x00FA96AD
		private bool HasAchievedAllGoals()
		{
			return this.Goals.Count > 0 && this.AchievedGoals >= this.Goals.Count;
		}

		// Token: 0x06040B98 RID: 265112 RVA: 0x00FAB4D5 File Offset: 0x00FA96D5
		private bool WillExhaustTurns(int turnCostDelta)
		{
			return this.RemainingTurns - (1 + turnCostDelta) <= 0;
		}

		// Token: 0x06040B99 RID: 265113 RVA: 0x00FAB4E8 File Offset: 0x00FA96E8
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

		// Token: 0x06040B9A RID: 265114 RVA: 0x00FAB53C File Offset: 0x00FA973C
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

		// Token: 0x04021ACF RID: 137935
		private readonly GameplayResolver Resolver;

		// Token: 0x04021AD0 RID: 137936
		private readonly ResultKeeper ResultKeeper;

		// Token: 0x04021AD1 RID: 137937
		private readonly GameRandom Rng;

		// Token: 0x04021AD2 RID: 137938
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

		// Token: 0x04021AD3 RID: 137939
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

		// Token: 0x04021AD4 RID: 137940
		public readonly IReadOnlyList<LevelGoal> Goals;

		// Token: 0x04021AD5 RID: 137941
		private readonly int BoardId;

		// Token: 0x04021ADA RID: 137946
		private int AchievedGoals;

		// Token: 0x04021ADD RID: 137949
		[Nullable(2)]
		public Action OnWin;

		// Token: 0x04021ADE RID: 137950
		[Nullable(2)]
		public Action OnLose;

		// Token: 0x04021ADF RID: 137951
		[Nullable(2)]
		public Action<int> OnSegmentPlay;
	}
}
