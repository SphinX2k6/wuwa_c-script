using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F3 RID: 25843
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayResolver
	{
		// Token: 0x170094EC RID: 38124
		// (get) Token: 0x06040E01 RID: 265729 RVA: 0x00FB900E File Offset: 0x00FB720E
		public Board Board { get; }

		// Token: 0x170094ED RID: 38125
		// (get) Token: 0x06040E02 RID: 265730 RVA: 0x00FB9016 File Offset: 0x00FB7216
		public bool IsAborted
		{
			get
			{
				return this.Aborted;
			}
		}

		// Token: 0x170094EE RID: 38126
		// (get) Token: 0x06040E03 RID: 265731 RVA: 0x00FB901E File Offset: 0x00FB721E
		public bool IsDeadlocked
		{
			get
			{
				return this.Deadlocked;
			}
		}

		// Token: 0x170094EF RID: 38127
		// (get) Token: 0x06040E04 RID: 265732 RVA: 0x00FB9026 File Offset: 0x00FB7226
		public IReadOnlyList<ValidMove> LastValidMoves
		{
			get
			{
				return this.ValidMoves;
			}
		}

		// Token: 0x170094F0 RID: 38128
		// (get) Token: 0x06040E05 RID: 265733 RVA: 0x00FB902E File Offset: 0x00FB722E
		public int CurrentRound
		{
			get
			{
				return this.Round;
			}
		}

		// Token: 0x170094F1 RID: 38129
		// (get) Token: 0x06040E06 RID: 265734 RVA: 0x00FB9036 File Offset: 0x00FB7236
		public IReadOnlyList<LevelMechanic> LevelMechanics
		{
			get
			{
				return this.Mechanics;
			}
		}

		// Token: 0x170094F2 RID: 38130
		// (get) Token: 0x06040E07 RID: 265735 RVA: 0x00FB903E File Offset: 0x00FB723E
		public int CurrentEnergy
		{
			get
			{
				return this.Energy.Energy;
			}
		}

		// Token: 0x170094F3 RID: 38131
		// (get) Token: 0x06040E08 RID: 265736 RVA: 0x00FB904B File Offset: 0x00FB724B
		public int FullEnergy
		{
			get
			{
				return this.SkillRunner.FullNode;
			}
		}

		// Token: 0x06040E09 RID: 265737 RVA: 0x00FB9058 File Offset: 0x00FB7258
		public void CollectSkillPoints(List<SkillPointDisplayData> buffer, int displayEnergy)
		{
			this.SkillRunner.CollectDisplays(buffer, displayEnergy);
		}

		// Token: 0x06040E0A RID: 265738 RVA: 0x00FB9068 File Offset: 0x00FB7268
		public GameplayResolver(Board board, List<ISkill> skills, List<ISolvedSequencesConsumer> consumers, IReadOnlyList<LevelMechanic> mechanics, int exchangeEnergy, [Nullable(2)] int[] fillRuleIds, GameRandom rng, MatchThreeStatsKeeper stats)
		{
			this.Board = board;
			this.Detector = new SequenceDetector();
			BoardFillStrategy fillStrategy = new BoardFillStrategy(this.Detector, fillRuleIds, rng);
			this.FillStrategy = fillStrategy;
			this.Energy = new EnergyPool();
			this.CascadeResolver = new CascadeResolver(board, this.Detector, fillStrategy, this.Energy, rng, stats);
			this.SkillRunner = new SkillRunner(this.Energy, skills);
			this.Reshuffler = new Reshuffler(this.Detector, rng);
			this.Player = new JobsPlayer();
			this.Consumers = consumers;
			this.Mechanics = mechanics;
			this.ExchangeEnergy = exchangeEnergy;
			this.Stats = stats;
		}

		// Token: 0x06040E0B RID: 265739 RVA: 0x00FB915D File Offset: 0x00FB735D
		public void BindPresenter(IMatchThreePresentation presenter)
		{
			this.Player.BindPresenter(presenter);
		}

		// Token: 0x06040E0C RID: 265740 RVA: 0x00FB916B File Offset: 0x00FB736B
		public void MutePresentation(bool muted)
		{
			this.Player.Muted = muted;
		}

		// Token: 0x06040E0D RID: 265741 RVA: 0x00FB9179 File Offset: 0x00FB7379
		public void RefreshValidMove()
		{
			this.Detector.CollectValidMoves(this.Board, this.ValidMoves);
		}

		// Token: 0x06040E0E RID: 265742 RVA: 0x00FB9192 File Offset: 0x00FB7392
		public void AbortResolve()
		{
			this.Aborted = true;
		}

		// Token: 0x06040E0F RID: 265743 RVA: 0x00FB919C File Offset: 0x00FB739C
		public void Reset()
		{
			this.Aborted = false;
			this.Deadlocked = false;
			this.ValidMoves.Clear();
			this.Round = 0;
			this.Energy.Reset();
			this.SkillRunner.Reset();
			this.FillStrategy.Reset();
		}

		// Token: 0x06040E10 RID: 265744 RVA: 0x00FB91EC File Offset: 0x00FB73EC
		[NullableContext(0)]
		public UniTask<int?> RunExchangeAsync(GridPosition a, GridPosition b)
		{
			GameplayResolver.<RunExchangeAsync>d__47 <RunExchangeAsync>d__;
			<RunExchangeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<RunExchangeAsync>d__.<>4__this = this;
			<RunExchangeAsync>d__.a = a;
			<RunExchangeAsync>d__.b = b;
			<RunExchangeAsync>d__.<>1__state = -1;
			<RunExchangeAsync>d__.<>t__builder.Start<GameplayResolver.<RunExchangeAsync>d__47>(ref <RunExchangeAsync>d__);
			return <RunExchangeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040E11 RID: 265745 RVA: 0x00FB9240 File Offset: 0x00FB7440
		[NullableContext(2)]
		public ResolveContext BeginExchange(GridPosition a, GridPosition b)
		{
			if (Math.Abs(a.Row - b.Row) + Math.Abs(a.Col - b.Col) != 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[BeginExchange] 交换门禁拒绝（非相邻格）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "A";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(a.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(a.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "B";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(b.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(b.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			Piece piece = this.Board.GetPiece(a.Row, a.Col);
			Piece piece2 = this.Board.GetPiece(b.Row, b.Col);
			if (piece == null || !piece.Has(EPieceCaps.Swappable) || piece2 == null || !piece2.Has(EPieceCaps.Swappable))
			{
				return null;
			}
			this.Board.SwapPiece(a, b);
			ResolveContext resolveContext = new ResolveContext
			{
				IsPlayerTurn = true
			};
			this.ConfigureRecycleTracking(resolveContext.Solved);
			ValueTuple<Piece, Piece>? swapEffectPair = this.CascadeResolver.FindSwapEffectPair(a, b);
			int rowStart = (a.Row < b.Row) ? a.Row : b.Row;
			int rowEnd = (a.Row > b.Row) ? a.Row : b.Row;
			this.SwapCols.Clear();
			this.SwapCols.Add(a.Col);
			this.SwapCols.Add(b.Col);
			this.SwapBuffer.Clear();
			this.Detector.DetectInto(this.Board, rowStart, rowEnd, this.SwapCols, this.SwapBuffer);
			List<IJob> list;
			if (this.SwapBuffer.Count > 0)
			{
				list = this.ResolveMatchedSwap(resolveContext, a, b, swapEffectPair);
			}
			else
			{
				list = this.CascadeResolver.ResolveSwap(resolveContext.Solved, a, b, b, a);
				if (list == null)
				{
					this.Board.SwapPiece(a, b);
					return null;
				}
			}
			this.SwapJob.Set(a, b);
			this.FirstJobs.Clear();
			this.FirstJobs.Add(this.SwapJob);
			if (list != null)
			{
				this.FirstJobs.AddRange(list);
				resolveContext.PendingLandedCols.AddRange(this.CascadeResolver.LandedCols);
				this.NotifyConsumers(resolveContext);
			}
			this.RegisterExchangedLandedPiece(resolveContext, b, piece);
			this.RegisterExchangedLandedPiece(resolveContext, a, piece2);
			GameplayResolver.AdvanceOrDrain(resolveContext, EResolvePhase.Cascade);
			if (this.ExchangeEnergy > 0)
			{
				this.Energy.Charge(this.ExchangeEnergy);
			}
			resolveContext.FirstSegment = this.FirstJobs;
			return resolveContext;
		}

		// Token: 0x06040E12 RID: 265746 RVA: 0x00FB955C File Offset: 0x00FB775C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IJob> ResolveMatchedSwap(ResolveContext ctx, GridPosition a, GridPosition b, [TupleElementNames(new string[]
		{
			"Self",
			"Other"
		})] [Nullable(new byte[]
		{
			0,
			1,
			1
		})] ValueTuple<Piece, Piece>? swapEffectPair)
		{
			GameplayResolver.RewriteCentersToSwap(this.SwapBuffer, a, b);
			ctx.Solved.Sequences.AddRange(this.SwapBuffer);
			if (swapEffectPair == null)
			{
				return this.CascadeResolver.ResolveOneSegment(ctx.Solved, new GridPosition?(b), new GridPosition?(a));
			}
			Piece item = swapEffectPair.Value.Item1;
			Piece item2 = swapEffectPair.Value.Item2;
			GridPosition swapEffectPosition = (this.Board.GetPiece(a.Row, a.Col) == item) ? a : b;
			GridPosition otherPosition = (this.Board.GetPiece(a.Row, a.Col) == item2) ? a : b;
			return this.CascadeResolver.ResolveMatchedSwapEffect(ctx.Solved, item, swapEffectPosition, item2, otherPosition, b, a);
		}

		// Token: 0x06040E13 RID: 265747 RVA: 0x00FB9624 File Offset: 0x00FB7824
		private void RegisterExchangedLandedPiece(ResolveContext ctx, GridPosition target, Piece piece)
		{
			int num = 6;
			if (target.Row != num || !piece.Has(EPieceCaps.Land))
			{
				return;
			}
			if (ctx.PendingLandedCols.Contains(target.Col))
			{
				return;
			}
			ctx.PendingLandedCols.Add(target.Col);
		}

		// Token: 0x06040E14 RID: 265748 RVA: 0x00FB966C File Offset: 0x00FB786C
		private void ConfigureRecycleTracking(SolvedData solved)
		{
			for (int i = 0; i < this.Mechanics.Count; i++)
			{
				RecycleSpecialPieceMechanic recycleSpecialPieceMechanic = this.Mechanics[i] as RecycleSpecialPieceMechanic;
				if (recycleSpecialPieceMechanic != null && this.Round >= recycleSpecialPieceMechanic.MountRound)
				{
					if (recycleSpecialPieceMechanic.TargetType == EPieceType.Charger)
					{
						solved.TrackRecycleCharger = true;
					}
					else if (recycleSpecialPieceMechanic.TargetType == EPieceType.Hourglass)
					{
						solved.TrackRecycleHourglass = true;
					}
				}
			}
		}

		// Token: 0x06040E15 RID: 265749 RVA: 0x00FB96D4 File Offset: 0x00FB78D4
		private static void RewriteCentersToSwap(List<ItemSequence> sequences, GridPosition a, GridPosition b)
		{
			int i = 0;
			while (i < sequences.Count)
			{
				ItemSequence value = sequences[i];
				if (value.Covers(a.Row, a.Col))
				{
					value.CenterRow = a.Row;
					value.CenterCol = a.Col;
					goto IL_6C;
				}
				if (value.Covers(b.Row, b.Col))
				{
					value.CenterRow = b.Row;
					value.CenterCol = b.Col;
					goto IL_6C;
				}
				IL_74:
				i++;
				continue;
				IL_6C:
				sequences[i] = value;
				goto IL_74;
			}
		}

		// Token: 0x06040E16 RID: 265750 RVA: 0x00FB9764 File Offset: 0x00FB7964
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ComputeNext(ResolveContext ctx)
		{
			List<IJob> list;
			List<IJob> list2;
			ISkill skill;
			List<IJob> list3;
			List<IJob> list4;
			List<IJob> result;
			for (;;)
			{
				switch (ctx.Phase)
				{
				case EResolvePhase.Cascade:
					list = this.CascadeResolver.ResolveOneSegment(ctx.Solved, null, null);
					if (list != null)
					{
						goto Block_1;
					}
					GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.Skill);
					continue;
				case EResolvePhase.Land:
					list2 = this.CascadeResolver.ResolveLandedBottom(ctx.Solved, ctx.PendingLandedCols);
					ctx.PendingLandedCols.Clear();
					if (list2 != null)
					{
						goto Block_2;
					}
					ctx.Phase = ctx.LandReturnPhase;
					continue;
				case EResolvePhase.Skill:
				{
					Func<bool> allGoalsAchieved = this.AllGoalsAchieved;
					if (allGoalsAchieved != null && allGoalsAchieved())
					{
						ctx.Phase = EResolvePhase.Done;
						continue;
					}
					skill = this.SkillRunner.TakeReleasable();
					if (skill == null)
					{
						GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.TurnSettle);
						continue;
					}
					goto IL_157;
				}
				case EResolvePhase.TurnSettle:
					if (ctx != null && ctx.IsPlayerTurn && !ctx.TurnSettled)
					{
						ctx.TurnSettled = true;
						this.Round++;
						list3 = this.CascadeResolver.ResolveTurnSettle(ctx.Solved);
						if (list3 != null && ctx.Solved.ClearedThisSegment.Count > 0)
						{
							goto Block_12;
						}
						if (list3 != null)
						{
							return list3;
						}
					}
					if (ctx != null && ctx.IsPlayerTurn && !ctx.MechanicsResolved)
					{
						Func<int, bool> isFinalTurn = this.IsFinalTurn;
						if (isFinalTurn != null && isFinalTurn(ctx.Solved.MovesDelta))
						{
							ctx.MechanicsResolved = true;
						}
					}
					if (ctx != null && ctx.IsPlayerTurn && !ctx.MechanicsResolved)
					{
						ctx.MechanicsResolved = true;
						list4 = this.CascadeResolver.ResolveMechanics(ctx.Solved, this.Round, this.Mechanics);
						if (list4 != null)
						{
							goto Block_22;
						}
					}
					GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.ValidMoveCheck);
					continue;
				case EResolvePhase.ValidMoveCheck:
					ctx.Phase = EResolvePhase.Done;
					this.Detector.CollectValidMoves(this.Board, this.ValidMoves);
					if (this.ValidMoves.Count != 0)
					{
						this.Deadlocked = false;
						continue;
					}
					result = this.Reshuffler.Reshuffle(this.Board);
					if (this.Reshuffler.LastLayoutFailed)
					{
						this.Deadlocked = true;
						Log.Instance.Error(ELogModule.MatchThree, ELogAuthor.CB, "[ComputeNext] ValidMoveCheck 重排凑不出可玩盘面，放弃重排并收口结算", default(ReadOnlySpan<ValueTuple<string, object>>));
						continue;
					}
					goto IL_380;
				}
				break;
			}
			goto IL_3AD;
			Block_1:
			ctx.PendingLandedCols.AddRange(this.CascadeResolver.LandedCols);
			this.NotifyConsumers(ctx);
			ctx.CascadeSegments++;
			GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.Cascade);
			return list;
			Block_2:
			ctx.PendingLandedCols.AddRange(this.CascadeResolver.LandedCols);
			this.NotifyConsumers(ctx);
			ctx.Solved.Sequences.Clear();
			this.Detector.DetectAll(this.Board, ctx.Solved.Sequences);
			GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.Cascade);
			return list2;
			IL_157:
			bool isUltimate = this.SkillRunner.IsUltimate(skill);
			List<IJob> result2 = this.CascadeResolver.ResolveSkill(ctx.Solved, skill, isUltimate);
			this.Stats.AddSkillCast(isUltimate);
			this.SkillRunner.CompleteRelease(skill);
			if (ctx.Solved.ClearedThisSegment.Count > 0)
			{
				this.NotifyConsumers(ctx);
			}
			ctx.PendingLandedCols.AddRange(this.CascadeResolver.LandedCols);
			EResolvePhase next = (ctx.Solved.Sequences.Count > 0) ? EResolvePhase.Cascade : EResolvePhase.Skill;
			GameplayResolver.AdvanceOrDrain(ctx, next);
			return result2;
			Block_12:
			ctx.PendingLandedCols.AddRange(this.CascadeResolver.LandedCols);
			this.NotifyConsumers(ctx);
			GameplayResolver.AdvanceOrDrain(ctx, EResolvePhase.Cascade);
			return list3;
			Block_22:
			ctx.Phase = ((ctx.Solved.Sequences.Count > 0) ? EResolvePhase.Cascade : EResolvePhase.ValidMoveCheck);
			return list4;
			IL_380:
			this.Detector.CollectValidMoves(this.Board, this.ValidMoves);
			this.Deadlocked = false;
			return result;
			IL_3AD:
			return null;
		}

		// Token: 0x06040E17 RID: 265751 RVA: 0x00FB9B1F File Offset: 0x00FB7D1F
		private static void AdvanceOrDrain(ResolveContext ctx, EResolvePhase next)
		{
			if (ctx.PendingLandedCols.Count > 0)
			{
				ctx.LandReturnPhase = next;
				ctx.Phase = EResolvePhase.Land;
				return;
			}
			ctx.Phase = next;
		}

		// Token: 0x06040E18 RID: 265752 RVA: 0x00FB9B48 File Offset: 0x00FB7D48
		private UniTask DriveAsync(ResolveContext ctx)
		{
			GameplayResolver.<DriveAsync>d__55 <DriveAsync>d__;
			<DriveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DriveAsync>d__.<>4__this = this;
			<DriveAsync>d__.ctx = ctx;
			<DriveAsync>d__.<>1__state = -1;
			<DriveAsync>d__.<>t__builder.Start<GameplayResolver.<DriveAsync>d__55>(ref <DriveAsync>d__);
			return <DriveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040E19 RID: 265753 RVA: 0x00FB9B94 File Offset: 0x00FB7D94
		private void NotifyConsumers(ResolveContext ctx)
		{
			ctx.EliminationSegments++;
			SolvedData solved = ctx.Solved;
			if (solved.SegmentCharge > 0)
			{
				this.Energy.Charge(solved.SegmentCharge);
			}
			foreach (ISolvedSequencesConsumer solvedSequencesConsumer in this.Consumers)
			{
				solvedSequencesConsumer.OnSequencesSolved(solved);
			}
		}

		// Token: 0x04021CFE RID: 138494
		private readonly SequenceDetector Detector;

		// Token: 0x04021CFF RID: 138495
		private readonly CascadeResolver CascadeResolver;

		// Token: 0x04021D00 RID: 138496
		private readonly SkillRunner SkillRunner;

		// Token: 0x04021D01 RID: 138497
		private readonly Reshuffler Reshuffler;

		// Token: 0x04021D02 RID: 138498
		private readonly JobsPlayer Player;

		// Token: 0x04021D03 RID: 138499
		private readonly EnergyPool Energy;

		// Token: 0x04021D04 RID: 138500
		private readonly BoardFillStrategy FillStrategy;

		// Token: 0x04021D05 RID: 138501
		private readonly List<ISolvedSequencesConsumer> Consumers;

		// Token: 0x04021D06 RID: 138502
		private readonly MatchThreeStatsKeeper Stats;

		// Token: 0x04021D07 RID: 138503
		private readonly IReadOnlyList<LevelMechanic> Mechanics;

		// Token: 0x04021D08 RID: 138504
		private readonly int ExchangeEnergy;

		// Token: 0x04021D09 RID: 138505
		private int Round;

		// Token: 0x04021D0A RID: 138506
		private bool Aborted;

		// Token: 0x04021D0B RID: 138507
		private bool Deadlocked;

		// Token: 0x04021D0C RID: 138508
		private readonly List<ValidMove> ValidMoves = new List<ValidMove>();

		// Token: 0x04021D0D RID: 138509
		[Nullable(2)]
		public Action<int> OnSegmentPlay;

		// Token: 0x04021D0E RID: 138510
		[Nullable(2)]
		public Func<bool> AllGoalsAchieved;

		// Token: 0x04021D0F RID: 138511
		[Nullable(2)]
		public Func<int, bool> IsFinalTurn;

		// Token: 0x04021D10 RID: 138512
		private readonly List<ItemSequence> SwapBuffer = new List<ItemSequence>();

		// Token: 0x04021D11 RID: 138513
		private readonly HashSet<int> SwapCols = new HashSet<int>();

		// Token: 0x04021D12 RID: 138514
		private readonly SwapJob SwapJob = new SwapJob();

		// Token: 0x04021D13 RID: 138515
		private readonly SwapFailJob SwapFailJob = new SwapFailJob();

		// Token: 0x04021D14 RID: 138516
		private readonly List<IJob> FirstJobs = new List<IJob>();
	}
}
