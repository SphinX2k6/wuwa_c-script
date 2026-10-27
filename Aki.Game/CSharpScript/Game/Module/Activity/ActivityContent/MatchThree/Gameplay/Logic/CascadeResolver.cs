using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F2 RID: 25842
	[NullableContext(1)]
	[Nullable(0)]
	public class CascadeResolver
	{
		// Token: 0x170094E9 RID: 38121
		// (get) Token: 0x06040DCB RID: 265675 RVA: 0x00FB6A3A File Offset: 0x00FB4C3A
		// (set) Token: 0x06040DCC RID: 265676 RVA: 0x00FB6A42 File Offset: 0x00FB4C42
		private int LastSegmentScore { get; set; }

		// Token: 0x170094EA RID: 38122
		// (get) Token: 0x06040DCD RID: 265677 RVA: 0x00FB6A4B File Offset: 0x00FB4C4B
		// (set) Token: 0x06040DCE RID: 265678 RVA: 0x00FB6A53 File Offset: 0x00FB4C53
		private int LastSegmentCharge { get; set; }

		// Token: 0x170094EB RID: 38123
		// (get) Token: 0x06040DCF RID: 265679 RVA: 0x00FB6A5C File Offset: 0x00FB4C5C
		// (set) Token: 0x06040DD0 RID: 265680 RVA: 0x00FB6A64 File Offset: 0x00FB4C64
		private int LastSegmentTrailCharge { get; set; }

		// Token: 0x06040DD1 RID: 265681 RVA: 0x00FB6A70 File Offset: 0x00FB4C70
		public CascadeResolver(Board board, SequenceDetector detector, BoardFillStrategy fillStrategy, EnergyPool energy, GameRandom rng, MatchThreeStatsKeeper stats)
		{
			int[] array = new int[4];
			array[0] = -1;
			array[1] = 1;
			this.Dr = array;
			this.Dc = new int[]
			{
				0,
				0,
				-1,
				1
			};
			this.RulesByType = new Dictionary<EPieceType, IReadOnlyList<EliminateRule>>();
			this.SpawnSlotSeqs = new List<ItemSequence>();
			base..ctor();
			this.Board = board;
			this.Detector = detector;
			this.FillStrategy = fillStrategy;
			this.Energy = energy;
			this.Rng = rng;
			this.Stats = stats;
			this.RequestedClearCells = new bool[56];
			this.RequestedRejudgeCells = new bool[56];
			this.RequestedDirectChainHitCells = new bool[56];
			this.PendingHealthClearCounts = new int[56];
			this.ClearedCells = new bool[56];
			this.ClaimedCenters = new bool[56];
			this.HitCells = new bool[56];
			this.DirectChainHitCells = new bool[56];
			this.DetonationDependencyVisited = new bool[56];
			this.ClearEventIdx = new int[56];
			this.SeqCellRule = new EliminateRule[56];
			this.Context = new CascadeResolver.CascadeResolverContext(this);
			this.MechanicCtx = new CascadeResolver.MechanicContext(this);
			this.EnqueueCell = delegate(int r, int c)
			{
				this.EnqueueClearRequest(new CascadeResolver.ClearRequest(new GridPosition(r, c), 0, EPieceClearReason.Matched, null, null, null, EDirectedTrailType.None, false, false, null, false));
				ref EliminateRule ptr = ref this.SeqCellRule[r * 8 + c];
				if (ptr == null)
				{
					ptr = this.CurrentRule;
				}
			};
		}

		// Token: 0x06040DD2 RID: 265682 RVA: 0x00FB6C78 File Offset: 0x00FB4E78
		private void BeginSegment(SolvedData solved, GridPosition? preferredChainSource = null, GridPosition? alternateChainSource = null, bool suppressChainDetonationTrails = false)
		{
			this.ClearQueue.Clear();
			Array.Clear(this.RequestedClearCells, 0, this.RequestedClearCells.Length);
			Array.Clear(this.RequestedRejudgeCells, 0, this.RequestedRejudgeCells.Length);
			Array.Clear(this.RequestedDirectChainHitCells, 0, this.RequestedDirectChainHitCells.Length);
			Array.Clear(this.PendingHealthClearCounts, 0, this.PendingHealthClearCounts.Length);
			Array.Clear(this.ClearedCells, 0, this.ClearedCells.Length);
			Array.Clear(this.ClaimedCenters, 0, this.ClaimedCenters.Length);
			Array.Clear(this.HitCells, 0, this.HitCells.Length);
			Array.Clear(this.DirectChainHitCells, 0, this.DirectChainHitCells.Length);
			Array.Fill<int>(this.ClearEventIdx, -1);
			Array.Clear(this.SeqCellRule, 0, this.SeqCellRule.Length);
			this.PieceClears.Clear();
			this.PieceHits.Clear();
			this.PieceTransforms.Clear();
			this.PieceAttaches.Clear();
			this.PieceRecolors.Clear();
			this.PieceMoves.Clear();
			this.MechanicTips.Clear();
			this.SkillTips.Clear();
			this.ScorePops.Clear();
			this.SkillTrails.Clear();
			this.MechanicTrails.Clear();
			this.RecycleTrailSettles.Clear();
			this.DirtyCols.Clear();
			this.LandedCols.Clear();
			this.SharedChainBomb = null;
			this.SharedChainCross = null;
			this.ChainTicked = false;
			this.DirectChainHits.Clear();
			this.PreferredChainSource = preferredChainSource;
			this.AlternateChainSource = alternateChainSource;
			this.SuppressChainDetonationTrails = suppressChainDetonationTrails;
			this.CurrentRequestIsChainFollowUp = false;
			solved.SpecialItemSlots.Clear();
			this.SpawnSlotSeqs.Clear();
			solved.BeginSegment();
			this.CurrentSolved = solved;
			this.LastSegmentScore = 0;
			this.LastSegmentCharge = 0;
			this.LastSegmentTrailCharge = 0;
		}

		// Token: 0x06040DD3 RID: 265683 RVA: 0x00FB6E5F File Offset: 0x00FB505F
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveOneSegment(SolvedData solved, GridPosition? preferredChainSource = null, GridPosition? alternateChainSource = null)
		{
			if (solved.Sequences.Count == 0)
			{
				return null;
			}
			this.BeginSegment(solved, preferredChainSource, alternateChainSource, false);
			this.EnqueueSequences(solved);
			List<IJob> list = this.DrainAndPack(solved);
			if (list == null)
			{
				solved.Sequences.Clear();
			}
			return list;
		}

		// Token: 0x06040DD4 RID: 265684 RVA: 0x00FB6E98 File Offset: 0x00FB5098
		private void EnqueueSequences(SolvedData solved)
		{
			foreach (ItemSequence itemSequence in solved.Sequences)
			{
				EliminateRule eliminateRule = this.ResolveRule(itemSequence);
				if (eliminateRule != null)
				{
					if (eliminateRule.SpawnType != -1)
					{
						GridPosition gridPosition = new GridPosition(itemSequence.CenterRow, itemSequence.CenterCol);
						int num = gridPosition.Row * 8 + gridPosition.Col;
						if (!this.ClaimedCenters[num])
						{
							this.ClaimedCenters[num] = true;
							solved.SpecialItemSlots.Add((eliminateRule.SpawnType == 0) ? new SpawnSlot(gridPosition, itemSequence.Type, eliminateRule.SpawnExtraComponents) : new SpawnSlot(gridPosition, (EPieceType)eliminateRule.SpawnType, null));
							this.SpawnSlotSeqs.Add(itemSequence);
						}
					}
					this.CurrentRule = eliminateRule;
					itemSequence.ForEachCell(this.EnqueueCell);
				}
			}
		}

		// Token: 0x06040DD5 RID: 265685 RVA: 0x00FB6F90 File Offset: 0x00FB5190
		[NullableContext(2)]
		private void CountGeneratedSpecial(EPieceType type, int[] extra)
		{
			if (type == EPieceType.Ultimate)
			{
				this.Stats.AddGeneratedUltimate();
			}
			if (extra == null)
			{
				return;
			}
			foreach (EPieceComponentId epieceComponentId in extra)
			{
				if (epieceComponentId != EPieceComponentId.Bomb)
				{
					if (epieceComponentId == EPieceComponentId.CrossClear)
					{
						this.Stats.AddGeneratedCross();
					}
				}
				else
				{
					this.Stats.AddGeneratedBomb();
				}
			}
		}

		// Token: 0x06040DD6 RID: 265686 RVA: 0x00FB6FE8 File Offset: 0x00FB51E8
		[NullableContext(2)]
		private EliminateRule ResolveRule(in ItemSequence seq)
		{
			Piece piece = this.Board.GetPiece(seq.CenterRow, seq.CenterCol);
			if (piece == null)
			{
				return null;
			}
			IReadOnlyList<EliminateRule> matchRules = this.GetMatchRules(piece);
			if (matchRules == null || matchRules.Count == 0)
			{
				return null;
			}
			ItemSequence itemSequence = seq;
			int num = (itemSequence.HLen > 0 && itemSequence.VLen > 0) ? 0 : ((seq.HLen > 0) ? 1 : 2);
			for (int i = 0; i < matchRules.Count; i++)
			{
				EliminateRule eliminateRule = matchRules[i];
				if (eliminateRule.Shape == seq.Shape && (eliminateRule.MatchDir == 0 || eliminateRule.MatchDir == num))
				{
					return eliminateRule;
				}
			}
			return null;
		}

		// Token: 0x06040DD7 RID: 265687 RVA: 0x00FB7098 File Offset: 0x00FB5298
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<EliminateRule> GetMatchRules(Piece piece)
		{
			if (!piece.Has(EPieceCaps.Matchable))
			{
				return null;
			}
			IReadOnlyList<EliminateRule> result;
			if (this.RulesByType.TryGetValue(piece.Type, out result))
			{
				return result;
			}
			List<EliminateRule> list = CascadeResolver.BuildRules(piece.Type);
			if (list == null)
			{
				return null;
			}
			this.RulesByType[piece.Type] = list;
			return list;
		}

		// Token: 0x06040DD8 RID: 265688 RVA: 0x00FB70F0 File Offset: 0x00FB52F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<EliminateRule> BuildRules(EPieceType type)
		{
			MatchThreePiece? pieceConfig = MatchThreeConfig.Instance.GetPieceConfig((int)type);
			int[] array = (pieceConfig != null) ? pieceConfig.GetValueOrDefault().GetEliminatesArray() : null;
			if (array == null || array.Length == 0)
			{
				return null;
			}
			List<EliminateRule> list = new List<EliminateRule>(array.Length);
			foreach (int id in array)
			{
				MatchThreeEliminate? eliminateConfig = MatchThreeConfig.Instance.GetEliminateConfig(id);
				if (eliminateConfig != null)
				{
					list.Add(new EliminateRule((EMatchShape)eliminateConfig.Value.Shape, eliminateConfig.Value.MatchDir, eliminateConfig.Value.SpawnType, eliminateConfig.Value.GetSpawnExtraComponentsArray(), eliminateConfig.Value.PieceEnergy, eliminateConfig.Value.PieceScore));
				}
			}
			return list;
		}

		// Token: 0x06040DD9 RID: 265689 RVA: 0x00FB71DD File Offset: 0x00FB53DD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveTurnSettle(SolvedData solved)
		{
			return null;
		}

		// Token: 0x06040DDA RID: 265690 RVA: 0x00FB71E0 File Offset: 0x00FB53E0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveMechanics(SolvedData solved, int round, IReadOnlyList<LevelMechanic> mechanics)
		{
			if (mechanics.Count == 0)
			{
				return null;
			}
			this.BeginSegment(solved, null, null, false);
			foreach (LevelMechanic levelMechanic in mechanics)
			{
				levelMechanic.OnRound(round, this.MechanicCtx);
			}
			if (this.PieceTransforms.Count == 0 && this.MechanicTips.Count == 0)
			{
				return null;
			}
			List<IJob> result = this.PackSegment();
			solved.Sequences.Clear();
			this.Detector.DetectAll(this.Board, solved.Sequences);
			return result;
		}

		// Token: 0x06040DDB RID: 265691 RVA: 0x00FB7294 File Offset: 0x00FB5494
		public List<IJob> ResolveSkill(SolvedData solved, ISkill skill, bool isUltimate)
		{
			this.BeginSegment(solved, null, null, false);
			this.SkillTips.Add(new SkillTipEvent(skill.Icon, skill.Name, isUltimate, skill.CastEffect));
			skill.Release(this.MechanicCtx);
			List<IJob> result = this.DrainAndPack(solved) ?? this.PackSegment();
			if (this.PieceTransforms.Count > 0 || this.PieceRecolors.Count > 0)
			{
				solved.Sequences.Clear();
				this.Detector.DetectAll(this.Board, solved.Sequences);
			}
			return result;
		}

		// Token: 0x06040DDC RID: 265692 RVA: 0x00FB733C File Offset: 0x00FB553C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveLandedBottom(SolvedData solved, IReadOnlyList<int> landedCols)
		{
			if (landedCols.Count == 0)
			{
				return null;
			}
			this.BeginSegment(solved, null, null, false);
			int row = 6;
			foreach (int col in landedCols)
			{
				Piece piece = this.Board.GetPiece(row, col);
				if (piece != null && piece.Has(EPieceCaps.Land))
				{
					GridPosition pos = new GridPosition(row, col);
					List<IPieceComponent> components = piece.Components;
					for (int i = 0; i < components.Count; i++)
					{
						ILandBehavior landBehavior = components[i] as ILandBehavior;
						if (landBehavior != null)
						{
							landBehavior.OnLandedBottom(this.Context, piece, pos);
						}
					}
				}
			}
			return this.DrainAndPack(solved);
		}

		// Token: 0x06040DDD RID: 265693 RVA: 0x00FB7418 File Offset: 0x00FB5618
		[return: TupleElementNames(new string[]
		{
			"Self",
			"Other"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<Piece, Piece>? FindSwapEffectPair(GridPosition a, GridPosition b)
		{
			Piece piece = this.Board.GetPiece(a.Row, a.Col);
			Piece piece2 = this.Board.GetPiece(b.Row, b.Col);
			if (piece == null || piece2 == null)
			{
				return null;
			}
			if (!piece.Has(EPieceCaps.SwapEffect) && !piece2.Has(EPieceCaps.SwapEffect))
			{
				return null;
			}
			Piece piece3 = piece.Has(EPieceCaps.SwapEffect) ? piece : piece2;
			Piece piece4 = (piece3 == piece) ? piece2 : piece;
			IReadOnlyList<IPieceComponent> components = piece3.Components;
			for (int i = 0; i < components.Count; i++)
			{
				ISwapEffectBehavior swapEffectBehavior = components[i] as ISwapEffectBehavior;
				if (swapEffectBehavior != null && swapEffectBehavior.CanSwapWith(piece4))
				{
					return new ValueTuple<Piece, Piece>?(new ValueTuple<Piece, Piece>(piece3, piece4));
				}
			}
			return null;
		}

		// Token: 0x06040DDE RID: 265694 RVA: 0x00FB74FC File Offset: 0x00FB56FC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveSwap(SolvedData solved, GridPosition a, GridPosition b, GridPosition preferredChainSource, GridPosition alternateChainSource)
		{
			Piece piece = this.Board.GetPiece(a.Row, a.Col);
			Piece piece2 = this.Board.GetPiece(b.Row, b.Col);
			if (piece == null || piece2 == null)
			{
				return null;
			}
			ValueTuple<Piece, Piece>? valueTuple = this.FindSwapEffectPair(a, b);
			if (valueTuple == null)
			{
				if (piece.Has(EPieceCaps.SwapEffect) || piece2.Has(EPieceCaps.SwapEffect))
				{
					if (!piece.Has(EPieceCaps.SwapEffect))
					{
					}
				}
				return null;
			}
			Piece item = valueTuple.Value.Item1;
			Piece item2 = valueTuple.Value.Item2;
			GridPosition swapEffectPosition = (item == piece) ? a : b;
			GridPosition otherPosition = (item2 == piece) ? a : b;
			return this.ResolveSwapEffect(solved, item, swapEffectPosition, item2, otherPosition, preferredChainSource, alternateChainSource);
		}

		// Token: 0x06040DDF RID: 265695 RVA: 0x00FB75C8 File Offset: 0x00FB57C8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveMatchedSwapEffect(SolvedData solved, Piece swapEffectPiece, GridPosition swapEffectPosition, Piece otherPiece, GridPosition otherPosition, GridPosition preferredChainSource, GridPosition alternateChainSource)
		{
			bool suppressChainDetonationTrails = swapEffectPiece.Type == EPieceType.Ultimate && otherPiece.Type == EPieceType.Ultimate;
			this.BeginSegment(solved, new GridPosition?(preferredChainSource), new GridPosition?(alternateChainSource), suppressChainDetonationTrails);
			this.EnqueueSequences(solved);
			this.DispatchSwapEffect(swapEffectPiece, swapEffectPosition, otherPiece, otherPosition);
			return this.DrainAndPack(solved);
		}

		// Token: 0x06040DE0 RID: 265696 RVA: 0x00FB761C File Offset: 0x00FB581C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IJob> ResolveSwapEffect(SolvedData solved, Piece swapEffectPiece, GridPosition swapEffectPosition, Piece otherPiece, GridPosition otherPosition, GridPosition preferredChainSource, GridPosition alternateChainSource)
		{
			bool suppressChainDetonationTrails = swapEffectPiece.Type == EPieceType.Ultimate && otherPiece.Type == EPieceType.Ultimate;
			this.BeginSegment(solved, new GridPosition?(preferredChainSource), new GridPosition?(alternateChainSource), suppressChainDetonationTrails);
			this.DispatchSwapEffect(swapEffectPiece, swapEffectPosition, otherPiece, otherPosition);
			return this.DrainAndPack(solved);
		}

		// Token: 0x06040DE1 RID: 265697 RVA: 0x00FB766C File Offset: 0x00FB586C
		private void DispatchSwapEffect(Piece swapEffectPiece, GridPosition swapEffectPosition, Piece otherPiece, GridPosition otherPosition)
		{
			IReadOnlyList<IPieceComponent> components = swapEffectPiece.Components;
			for (int i = 0; i < components.Count; i++)
			{
				ISwapEffectBehavior swapEffectBehavior = components[i] as ISwapEffectBehavior;
				if (swapEffectBehavior != null && swapEffectBehavior.CanSwapWith(otherPiece))
				{
					swapEffectBehavior.OnSwapped(this.Context, swapEffectPiece, swapEffectPosition, otherPiece, otherPosition);
				}
			}
		}

		// Token: 0x06040DE2 RID: 265698 RVA: 0x00FB76BC File Offset: 0x00FB58BC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private unsafe List<IJob> DrainAndPack(SolvedData solved)
		{
			int num = 0;
			int num2 = 224;
			for (;;)
			{
				if (this.ClearQueue.Count > 0)
				{
					if (++num > num2)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.MatchThree;
						ELogAuthor author = ELogAuthor.CB;
						string message = "[DrainAndPack] 消除队列排空超上限，疑似死循环，强制中断";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("已出队", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("上限", num2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("残留队列", this.ClearQueue.Count);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("已消除", this.PieceClears.Count);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						this.ClearQueue.Clear();
					}
					else
					{
						CascadeResolver.ClearRequest clearRequest = this.ClearQueue.Dequeue();
						int num3 = clearRequest.Pos.Row * 8 + clearRequest.Pos.Col;
						if (clearRequest.IsRejudgeOnly)
						{
							this.RejudgeSplashed(num3, clearRequest.Reason, clearRequest.DelayMs, clearRequest.DetonationSource);
							continue;
						}
						if (this.PendingHealthClearCounts[num3] > 0)
						{
							this.PendingHealthClearCounts[num3]--;
						}
						bool currentRequestIsChainFollowUp = this.CurrentRequestIsChainFollowUp;
						this.CurrentRequestIsChainFollowUp = clearRequest.IsChainFollowUp;
						this.ClearCell(solved, clearRequest.Pos, false, clearRequest.DelayMs, clearRequest.Reason, clearRequest.Source, clearRequest.TrailOrigin, clearRequest.LandAnchor, clearRequest.DirectedTrail, clearRequest.OpensDirectedTrails, clearRequest.DetonationSource);
						this.CurrentRequestIsChainFollowUp = currentRequestIsChainFollowUp;
						continue;
					}
				}
				if (this.ChainTicked || this.DirectChainHits.Count == 0)
				{
					break;
				}
				this.ChainTicked = true;
				this.TickChainGroup(solved);
			}
			if (this.PieceClears.Count == 0 && this.PieceHits.Count == 0)
			{
				return null;
			}
			if (this.PieceClears.Count == 0)
			{
				solved.SegmentScore = this.LastSegmentScore;
				solved.SegmentCharge = this.LastSegmentCharge;
				solved.SegmentTrailCharge = this.LastSegmentTrailCharge;
				List<IJob> result = this.PackSegment();
				solved.Sequences.Clear();
				return result;
			}
			solved.SegmentScore = this.LastSegmentScore;
			solved.SegmentCharge = this.LastSegmentCharge;
			solved.SegmentTrailCharge = this.LastSegmentTrailCharge;
			if (this.LastSegmentScore > 0)
			{
				this.ScorePops.Add(new ScorePopEvent(this.LastSegmentScore));
			}
			this.SpawnSpecials(solved);
			int rowEnd = this.FillStrategy.RefillDirtyColumns(this.Board, this.DirtyCols, this.PieceMoves, this.LandedCols);
			if (solved.SegmentRecycleChargerClearCount > 0 || solved.SegmentRecycleHourglassClearCount > 0)
			{
				this.RecycleTrailSettles.Add(new RecycleTrailSettleEvent(solved.SegmentRecycleChargerClearCount, solved.SegmentRecycleHourglassClearCount, solved.SegmentTurnGain));
			}
			List<IJob> result2 = this.PackSegment();
			solved.Sequences.Clear();
			this.Detector.DetectInto(this.Board, 0, rowEnd, this.DirtyCols, solved.Sequences);
			return result2;
		}

		// Token: 0x06040DE3 RID: 265699 RVA: 0x00FB79E0 File Offset: 0x00FB5BE0
		private List<IJob> PackSegment()
		{
			SegmentJobs segmentJobs = this.SegmentBuffers[this.SegmentBufferIndex];
			this.SegmentBufferIndex ^= 1;
			segmentJobs.Jobs.Clear();
			SegmentJobs.Pack<MechanicTipEvent>(this.MechanicTips, segmentJobs.MechanicTips, segmentJobs.Jobs);
			SegmentJobs.Pack<SkillTipEvent>(this.SkillTips, segmentJobs.SkillTips, segmentJobs.Jobs);
			SegmentJobs.Pack<SkillTrailEvent>(this.SkillTrails, segmentJobs.SkillTrails, segmentJobs.Jobs);
			SegmentJobs.Pack<MechanicTrailEvent>(this.MechanicTrails, segmentJobs.MechanicTrails, segmentJobs.Jobs);
			SegmentJobs.Pack<RecycleTrailSettleEvent>(this.RecycleTrailSettles, segmentJobs.RecycleTrailSettles, segmentJobs.Jobs);
			SegmentJobs.Pack<ScorePopEvent>(this.ScorePops, segmentJobs.ScorePops, segmentJobs.Jobs);
			SegmentJobs.Pack<PieceTransformEvent>(this.PieceTransforms, segmentJobs.Transforms, segmentJobs.Jobs);
			SegmentJobs.Pack<PieceAttachEvent>(this.PieceAttaches, segmentJobs.Attaches, segmentJobs.Jobs);
			SegmentJobs.Pack<PieceRecolorEvent>(this.PieceRecolors, segmentJobs.Recolors, segmentJobs.Jobs);
			segmentJobs.PackBoard(this.PieceClears, this.PieceHits, this.PieceMoves);
			return segmentJobs.Jobs;
		}

		// Token: 0x06040DE4 RID: 265700 RVA: 0x00FB7B04 File Offset: 0x00FB5D04
		private void ClearCell(SolvedData solved, GridPosition pos, bool suppressClearEffect, int delayMs = 0, EPieceClearReason reason = EPieceClearReason.Matched, EPieceType? source = null, GridPosition? trailOrigin = null, GridPosition? landAnchor = null, EDirectedTrailType directedTrail = EDirectedTrailType.None, bool opensDirectedTrails = false, GridPosition? detonationSource = null)
		{
			int num = pos.Row * 8 + pos.Col;
			if (this.ClearedCells[num])
			{
				this.RejudgeSplashed(num, reason, delayMs, detonationSource);
				return;
			}
			Piece piece = this.Board.GetPiece(pos.Row, pos.Col);
			if (piece == null)
			{
				return;
			}
			if (!suppressClearEffect && !piece.Has(EPieceCaps.Clearable))
			{
				if (MatchThreeGameplayDefine.IsSplashed(reason) && !this.HitCells[num])
				{
					this.HitCells[num] = true;
					List<PieceHitEvent> pieceHits = this.PieceHits;
					PieceHitEvent item = new PieceHitEvent(pos, delayMs)
					{
						WaitLandAt = landAnchor,
						WaitDetonationAt = detonationSource
					};
					pieceHits.Add(item);
				}
				return;
			}
			if (piece.Has(EPieceCaps.Chain) && CascadeResolver.ChainDurability(piece) > 0)
			{
				if (!this.CurrentRequestIsChainFollowUp)
				{
					GridPosition? landAnchor2 = (trailOrigin != null) ? new GridPosition?(pos) : landAnchor;
					this.CollectDirectChainHit(pos, delayMs, reason, trailOrigin, landAnchor2, directedTrail, detonationSource);
				}
				return;
			}
			int lives;
			if (!suppressClearEffect && piece.Has(EPieceCaps.Health) && !CascadeResolver.TakeDamage(piece, out lives))
			{
				List<PieceHitEvent> pieceHits2 = this.PieceHits;
				PieceHitEvent item = new PieceHitEvent(pos, delayMs)
				{
					WaitLandAt = landAnchor,
					WaitDetonationAt = detonationSource,
					Lives = lives
				};
				pieceHits2.Add(item);
				return;
			}
			this.ClearedCells[num] = true;
			if (CascadeResolver.HasComponent<BombComponent>(piece))
			{
				this.Stats.AddClearedBomb();
			}
			if (CascadeResolver.HasComponent<CrossClearComponent>(piece))
			{
				this.Stats.AddClearedCross();
			}
			if (!suppressClearEffect && (CascadeResolver.HasComponent<BombComponent>(piece) || (piece.Has(EPieceCaps.Chain) && this.SharedChainBomb != null)))
			{
				reason = EPieceClearReason.BombSelf;
			}
			int count = this.PieceClears.Count;
			this.ClearEventIdx[num] = count;
			this.PieceClears.Add(new PieceClearEvent(pos, piece.Type, reason, delayMs)
			{
				TrailFrom = trailOrigin,
				DirectedTrail = directedTrail,
				OpensDirectedTrails = opensDirectedTrails,
				WaitLandAt = ((trailOrigin != null) ? null : landAnchor),
				WaitDetonationAt = detonationSource,
				RecycleTrail = this.GetRecycleTrailType(piece.Type)
			});
			solved.ClearedThisSegment.Add(piece.Type);
			if (piece.Type == EPieceType.Charger)
			{
				solved.SegmentRecycleChargerClearCount++;
				if (solved.TrackRecycleCharger)
				{
					solved.RecycleChargerClearCount++;
				}
			}
			else if (piece.Type == EPieceType.Hourglass)
			{
				solved.SegmentRecycleHourglassClearCount++;
				if (solved.TrackRecycleHourglass)
				{
					solved.RecycleHourglassClearCount++;
				}
			}
			this.DirtyCols.Add(pos.Col);
			EliminateRule currentClearRule = this.CurrentClearRule;
			this.CurrentClearRule = this.SeqCellRule[num];
			EPieceType? currentDetonator = this.CurrentDetonator;
			this.CurrentDetonator = ((!suppressClearEffect && MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type)) ? new EPieceType?(piece.Type) : null);
			int energyTrailCharged = this.EnergyTrailCharged;
			this.EnergyTrailCharged = 0;
			int currentClearDelayMs = this.CurrentClearDelayMs;
			this.CurrentClearDelayMs = delayMs;
			GridPosition? currentLandAnchor = this.CurrentLandAnchor;
			this.CurrentLandAnchor = ((trailOrigin != null) ? new GridPosition?(pos) : landAnchor);
			List<IPieceComponent> components = piece.Components;
			for (int i = 0; i < components.Count; i++)
			{
				IClearBehavior clearBehavior = components[i] as IClearBehavior;
				if (clearBehavior != null)
				{
					clearBehavior.OnCleared(this.Context, piece, pos, source);
				}
			}
			if (!suppressClearEffect && piece.Has(EPieceCaps.Chain))
			{
				if (this.SharedChainBomb != null && !CascadeResolver.HasComponent<BombComponent>(piece))
				{
					this.SharedChainBomb.OnCleared(this.Context, piece, pos, source);
				}
				if (this.SharedChainCross != null && !CascadeResolver.HasComponent<CrossClearComponent>(piece))
				{
					this.SharedChainCross.OnCleared(this.Context, piece, pos, source);
				}
			}
			this.CurrentDetonator = currentDetonator;
			this.CurrentClearRule = currentClearRule;
			this.CurrentClearDelayMs = currentClearDelayMs;
			this.CurrentLandAnchor = currentLandAnchor;
			if (this.EnergyTrailCharged > 0)
			{
				PieceClearEvent value = this.PieceClears[count];
				value.EnergyTrail = this.EnergyTrailCharged;
				this.PieceClears[count] = value;
			}
			this.EnergyTrailCharged = energyTrailCharged;
			if (this.SeqCellRule[num] != null)
			{
				this.DispatchAdjacent(pos, delayMs, landAnchor);
			}
			this.Board.ClearPiece(pos.Row, pos.Col);
		}

		// Token: 0x06040DE5 RID: 265701 RVA: 0x00FB7F4B File Offset: 0x00FB614B
		private ERecycleTrailType GetRecycleTrailType(EPieceType pieceType)
		{
			if (pieceType == EPieceType.Charger)
			{
				return ERecycleTrailType.Charger;
			}
			if (pieceType == EPieceType.Hourglass)
			{
				return ERecycleTrailType.Hourglass;
			}
			return ERecycleTrailType.None;
		}

		// Token: 0x06040DE6 RID: 265702 RVA: 0x00FB7F5C File Offset: 0x00FB615C
		private void RejudgeSplashed(int cellIdx, EPieceClearReason reason, int delayMs, GridPosition? detonationSource)
		{
			if (!MatchThreeGameplayDefine.IsSplashed(reason))
			{
				return;
			}
			int num = this.ClearEventIdx[cellIdx];
			if (num < 0)
			{
				return;
			}
			PieceClearEvent pieceClearEvent = this.PieceClears[num];
			if (pieceClearEvent.Reason != EPieceClearReason.Matched)
			{
				return;
			}
			pieceClearEvent.Reason = reason;
			if (detonationSource == null || CascadeResolver.IsSamePosition(new GridPosition?(detonationSource.Value), pieceClearEvent.Pos))
			{
				this.PieceClears[num] = pieceClearEvent;
				return;
			}
			if (!this.WouldCreateDetonationCycle(pieceClearEvent.Pos, detonationSource.Value))
			{
				pieceClearEvent.DelayMs = delayMs;
				pieceClearEvent.WaitDetonationAt = detonationSource;
			}
			this.PieceClears[num] = pieceClearEvent;
		}

		// Token: 0x06040DE7 RID: 265703 RVA: 0x00FB8001 File Offset: 0x00FB6201
		private bool WouldCreateDetonationCycle(GridPosition target, GridPosition source)
		{
			Array.Clear(this.DetonationDependencyVisited, 0, this.DetonationDependencyVisited.Length);
			return this.DependsOnPosition(source, target);
		}

		// Token: 0x06040DE8 RID: 265704 RVA: 0x00FB8020 File Offset: 0x00FB6220
		private bool DependsOnPosition(GridPosition current, GridPosition target)
		{
			if (CascadeResolver.IsSamePosition(new GridPosition?(current), target))
			{
				return true;
			}
			int num = current.Row * 8 + current.Col;
			if (this.DetonationDependencyVisited[num])
			{
				return false;
			}
			this.DetonationDependencyVisited[num] = true;
			int num2 = this.ClearEventIdx[num];
			if (num2 >= 0)
			{
				PieceClearEvent pieceClearEvent = this.PieceClears[num2];
				if (this.DependencyReachesTarget(pieceClearEvent.TrailFrom, target) || this.DependencyReachesTarget(pieceClearEvent.WaitLandAt, target) || this.DependencyReachesTarget(pieceClearEvent.WaitDetonationAt, target))
				{
					return true;
				}
			}
			for (int i = 0; i < this.PieceHits.Count; i++)
			{
				PieceHitEvent pieceHitEvent = this.PieceHits[i];
				if (CascadeResolver.IsSamePosition(new GridPosition?(pieceHitEvent.Pos), current) && (this.DependencyReachesTarget(pieceHitEvent.TrailFrom, target) || this.DependencyReachesTarget(pieceHitEvent.WaitLandAt, target) || this.DependencyReachesTarget(pieceHitEvent.WaitDetonationAt, target)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040DE9 RID: 265705 RVA: 0x00FB8116 File Offset: 0x00FB6316
		private bool DependencyReachesTarget(GridPosition? dependency, GridPosition target)
		{
			return dependency != null && this.DependsOnPosition(dependency.Value, target);
		}

		// Token: 0x06040DEA RID: 265706 RVA: 0x00FB8131 File Offset: 0x00FB6331
		private static bool IsSamePosition(GridPosition? position, GridPosition target)
		{
			return position != null && position.Value.Row == target.Row && position.Value.Col == target.Col;
		}

		// Token: 0x06040DEB RID: 265707 RVA: 0x00FB8168 File Offset: 0x00FB6368
		private static bool TakeDamage(Piece piece, out int lives)
		{
			lives = 0;
			HealthComponent healthComponent = CascadeResolver.FindComponent<HealthComponent>(piece);
			if (healthComponent == null)
			{
				return true;
			}
			ref PieceComponentState ptr = ref piece.StateOf(healthComponent);
			ptr.Val1--;
			lives = ptr.Val1;
			return lives <= 0;
		}

		// Token: 0x06040DEC RID: 265708 RVA: 0x00FB81A8 File Offset: 0x00FB63A8
		private void DispatchAdjacent(GridPosition pos, int delayMs, GridPosition? landAnchor)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = pos.Row + this.Dr[i];
				int num2 = pos.Col + this.Dc[i];
				if (this.Board.InBounds(num, num2) && !this.ClearedCells[num * 8 + num2])
				{
					Piece piece = this.Board.GetPiece(num, num2);
					if (piece != null && piece.Has(EPieceCaps.AdjacentClear))
					{
						GridPosition pos2 = new GridPosition(num, num2);
						int lives;
						if (CascadeResolver.TakeDamage(piece, out lives))
						{
							this.Context.RemovePiece(pos2);
						}
						else
						{
							this.PieceHits.Add(new PieceHitEvent(pos2, delayMs)
							{
								WaitLandAt = landAnchor,
								Lives = lives,
								PlayAnim = false
							});
						}
					}
				}
			}
		}

		// Token: 0x06040DED RID: 265709 RVA: 0x00FB8274 File Offset: 0x00FB6474
		private void CollectDirectChainHit(GridPosition pos, int delayMs, EPieceClearReason reason, GridPosition? trailOrigin, GridPosition? landAnchor, EDirectedTrailType directedTrail, GridPosition? detonationSource)
		{
			int num = pos.Row * 8 + pos.Col;
			if (this.DirectChainHitCells[num])
			{
				return;
			}
			this.DirectChainHitCells[num] = true;
			this.DirectChainHits.Add(new CascadeResolver.ChainDirectHitData(pos, delayMs, reason, trailOrigin, landAnchor, directedTrail, detonationSource));
		}

		// Token: 0x06040DEE RID: 265710 RVA: 0x00FB82C0 File Offset: 0x00FB64C0
		private void TickChainGroup(SolvedData solved)
		{
			this.SharedChainBomb = null;
			this.SharedChainCross = null;
			int num = this.PrepareChainGroupEffects();
			GridPosition source = this.SelectChainDetonationSource();
			bool hasTrailTargets = !this.SuppressChainDetonationTrails && num > this.DirectChainHits.Count;
			this.TickChainPieces(solved, source, hasTrailTargets);
		}

		// Token: 0x06040DEF RID: 265711 RVA: 0x00FB8310 File Offset: 0x00FB6510
		private int PrepareChainGroupEffects()
		{
			int num = 0;
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = this.Board.GetPiece(i, j);
					if (piece != null && piece.Has(EPieceCaps.Chain) && CascadeResolver.FindComponent<ChainComponent>(piece) != null)
					{
						num++;
						if (this.SharedChainBomb == null)
						{
							this.SharedChainBomb = CascadeResolver.FindComponent<BombComponent>(piece);
						}
						if (this.SharedChainCross == null)
						{
							this.SharedChainCross = CascadeResolver.FindComponent<CrossClearComponent>(piece);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06040DF0 RID: 265712 RVA: 0x00FB838C File Offset: 0x00FB658C
		private int TickChainPieces(SolvedData solved, GridPosition source, bool hasTrailTargets)
		{
			int num = this.ReduceChainDurabilityAt(source);
			for (int i = 0; i < this.DirectChainHits.Count; i++)
			{
				GridPosition pos = this.DirectChainHits[i].Pos;
				if (pos.Row != source.Row || pos.Col != source.Col)
				{
					num += this.ReduceChainDurabilityAt(pos);
				}
			}
			for (int j = 0; j < 7; j++)
			{
				for (int k = 0; k < 8; k++)
				{
					int num2 = j * 8 + k;
					if (!this.DirectChainHitCells[num2])
					{
						num += this.ReduceChainDurabilityAt(new GridPosition(j, k));
					}
				}
			}
			this.DispatchChainPieceAt(solved, source, source, hasTrailTargets);
			for (int l = 0; l < this.DirectChainHits.Count; l++)
			{
				GridPosition pos2 = this.DirectChainHits[l].Pos;
				if (pos2.Row != source.Row || pos2.Col != source.Col)
				{
					this.DispatchChainPieceAt(solved, pos2, source, hasTrailTargets);
				}
			}
			for (int m = 0; m < 7; m++)
			{
				for (int n = 0; n < 8; n++)
				{
					int num3 = m * 8 + n;
					if (!this.DirectChainHitCells[num3])
					{
						this.DispatchChainPieceAt(solved, new GridPosition(m, n), source, hasTrailTargets);
					}
				}
			}
			return num;
		}

		// Token: 0x06040DF1 RID: 265713 RVA: 0x00FB84D8 File Offset: 0x00FB66D8
		private int ReduceChainDurabilityAt(GridPosition pos)
		{
			Piece piece = this.Board.GetPiece(pos.Row, pos.Col);
			if (piece == null || !piece.Has(EPieceCaps.Chain))
			{
				return 0;
			}
			ChainComponent chainComponent = CascadeResolver.FindComponent<ChainComponent>(piece);
			if (chainComponent == null)
			{
				return 0;
			}
			ref PieceComponentState ptr = ref piece.StateOf(chainComponent);
			ptr.Val1--;
			return (ptr.Val1 <= 0) ? 1 : 0;
		}

		// Token: 0x06040DF2 RID: 265714 RVA: 0x00FB8538 File Offset: 0x00FB6738
		private void DispatchChainPieceAt(SolvedData solved, GridPosition pos, GridPosition source, bool hasTrailTargets)
		{
			Piece piece = this.Board.GetPiece(pos.Row, pos.Col);
			if (piece == null || !piece.Has(EPieceCaps.Chain))
			{
				return;
			}
			ChainComponent chainComponent = CascadeResolver.FindComponent<ChainComponent>(piece);
			if (chainComponent == null)
			{
				return;
			}
			this.DispatchChainPiece(solved, pos, piece, chainComponent, source, hasTrailTargets);
		}

		// Token: 0x06040DF3 RID: 265715 RVA: 0x00FB8588 File Offset: 0x00FB6788
		private void DispatchChainPiece(SolvedData solved, GridPosition pos, Piece piece, ChainComponent chain, GridPosition source, bool hasTrailTargets)
		{
			CascadeResolver.ChainDirectHitData? chainDirectHitData = this.FindDirectChainHit(pos);
			GridPosition? gridPosition = null;
			GridPosition? gridPosition2 = null;
			EDirectedTrailType directedTrail = EDirectedTrailType.None;
			GridPosition? gridPosition3 = null;
			int delayMs = 0;
			if (chainDirectHitData != null)
			{
				delayMs = chainDirectHitData.Value.DelayMs;
				gridPosition = chainDirectHitData.Value.TrailOrigin;
				gridPosition2 = chainDirectHitData.Value.LandAnchor;
				directedTrail = chainDirectHitData.Value.DirectedTrail;
				gridPosition3 = chainDirectHitData.Value.DetonationSource;
			}
			else if (!this.SuppressChainDetonationTrails)
			{
				gridPosition = new GridPosition?(source);
				directedTrail = EDirectedTrailType.ChainDetonation;
			}
			ref PieceComponentState ptr = ref piece.StateOf(chain);
			bool opensDirectedTrails = hasTrailTargets && pos.Row == source.Row && pos.Col == source.Col;
			if (ptr.Val1 <= 0)
			{
				EPieceClearReason reason = (chainDirectHitData != null) ? chainDirectHitData.Value.Reason : EPieceClearReason.ClearSelf;
				bool currentRequestIsChainFollowUp = this.CurrentRequestIsChainFollowUp;
				this.CurrentRequestIsChainFollowUp = true;
				this.ClearCell(solved, pos, false, delayMs, reason, null, gridPosition, (gridPosition != null) ? null : gridPosition2, directedTrail, opensDirectedTrails, gridPosition3);
				this.CurrentRequestIsChainFollowUp = currentRequestIsChainFollowUp;
				return;
			}
			this.PieceHits.Add(new PieceHitEvent(pos, delayMs)
			{
				TrailFrom = gridPosition,
				DirectedTrail = directedTrail,
				OpensDirectedTrails = opensDirectedTrails,
				WaitLandAt = ((gridPosition != null) ? null : gridPosition2),
				WaitDetonationAt = gridPosition3,
				StatePiece = piece
			});
			GridPosition? landAnchor = (gridPosition != null) ? new GridPosition?(pos) : gridPosition2;
			bool currentRequestIsChainFollowUp2 = this.CurrentRequestIsChainFollowUp;
			this.CurrentRequestIsChainFollowUp = true;
			this.DispatchChainEffects(pos, piece, delayMs, landAnchor);
			this.CurrentRequestIsChainFollowUp = currentRequestIsChainFollowUp2;
		}

		// Token: 0x06040DF4 RID: 265716 RVA: 0x00FB874C File Offset: 0x00FB694C
		private GridPosition SelectChainDetonationSource()
		{
			if (this.PreferredChainSource != null && this.IsDirectChainHit(this.PreferredChainSource.Value))
			{
				return this.PreferredChainSource.Value;
			}
			if (this.AlternateChainSource != null && this.IsDirectChainHit(this.AlternateChainSource.Value))
			{
				return this.AlternateChainSource.Value;
			}
			return this.DirectChainHits[this.Rng.Next(this.DirectChainHits.Count)].Pos;
		}

		// Token: 0x06040DF5 RID: 265717 RVA: 0x00FB87D7 File Offset: 0x00FB69D7
		private bool IsDirectChainHit(GridPosition pos)
		{
			return this.DirectChainHitCells[pos.Row * 8 + pos.Col];
		}

		// Token: 0x06040DF6 RID: 265718 RVA: 0x00FB87F0 File Offset: 0x00FB69F0
		private CascadeResolver.ChainDirectHitData? FindDirectChainHit(GridPosition pos)
		{
			for (int i = 0; i < this.DirectChainHits.Count; i++)
			{
				CascadeResolver.ChainDirectHitData chainDirectHitData = this.DirectChainHits[i];
				if (chainDirectHitData.Pos.Row == pos.Row && chainDirectHitData.Pos.Col == pos.Col)
				{
					return new CascadeResolver.ChainDirectHitData?(chainDirectHitData);
				}
			}
			return null;
		}

		// Token: 0x06040DF7 RID: 265719 RVA: 0x00FB8858 File Offset: 0x00FB6A58
		private void DispatchChainEffects(GridPosition pos, Piece piece, int delayMs, GridPosition? landAnchor)
		{
			int currentClearDelayMs = this.CurrentClearDelayMs;
			GridPosition? currentLandAnchor = this.CurrentLandAnchor;
			this.CurrentClearDelayMs = delayMs;
			this.CurrentLandAnchor = landAnchor;
			BombComponent bombComponent = CascadeResolver.FindComponent<BombComponent>(piece) ?? this.SharedChainBomb;
			if (bombComponent != null)
			{
				bombComponent.OnCleared(this.Context, piece, pos, null);
			}
			CrossClearComponent crossClearComponent = CascadeResolver.FindComponent<CrossClearComponent>(piece) ?? this.SharedChainCross;
			if (crossClearComponent != null)
			{
				crossClearComponent.OnCleared(this.Context, piece, pos, null);
			}
			this.CurrentClearDelayMs = currentClearDelayMs;
			this.CurrentLandAnchor = currentLandAnchor;
		}

		// Token: 0x06040DF8 RID: 265720 RVA: 0x00FB88E8 File Offset: 0x00FB6AE8
		[return: Nullable(2)]
		private static T FindComponent<T>(Piece piece) where T : class, IPieceComponent
		{
			foreach (IPieceComponent pieceComponent in piece.Components)
			{
				T t = pieceComponent as T;
				if (t != null)
				{
					return t;
				}
			}
			return default(T);
		}

		// Token: 0x06040DF9 RID: 265721 RVA: 0x00FB8958 File Offset: 0x00FB6B58
		private static int ChainDurability(Piece piece)
		{
			ChainComponent chainComponent = CascadeResolver.FindComponent<ChainComponent>(piece);
			if (chainComponent != null)
			{
				return piece.StateOf(chainComponent).Val1;
			}
			return 0;
		}

		// Token: 0x06040DFA RID: 265722 RVA: 0x00FB8980 File Offset: 0x00FB6B80
		private static bool HasComponent<[Nullable(0)] T>(Piece piece) where T : IPieceComponent
		{
			using (List<IPieceComponent>.Enumerator enumerator = piece.Components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is T)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06040DFB RID: 265723 RVA: 0x00FB89DC File Offset: 0x00FB6BDC
		private static bool HasBuff(Piece piece)
		{
			return CascadeResolver.HasComponent<BombComponent>(piece) || CascadeResolver.HasComponent<CrossClearComponent>(piece) || piece.Has(EPieceCaps.Chain);
		}

		// Token: 0x06040DFC RID: 265724 RVA: 0x00FB89FC File Offset: 0x00FB6BFC
		private void EnqueueClearRequest(CascadeResolver.ClearRequest request)
		{
			int num = request.Pos.Row * 8 + request.Pos.Col;
			Piece piece = this.Board.GetPiece(request.Pos.Row, request.Pos.Col);
			if (!this.ClearedCells[num] && piece != null && piece.Has(EPieceCaps.Health))
			{
				HealthComponent healthComponent = CascadeResolver.FindComponent<HealthComponent>(piece);
				int num2 = (healthComponent == null) ? 1 : piece.StateOf(healthComponent).Val1;
				if (this.PendingHealthClearCounts[num] < num2)
				{
					this.PendingHealthClearCounts[num]++;
					this.RequestedClearCells[num] = true;
					if (piece.Has(EPieceCaps.Chain) && CascadeResolver.ChainDurability(piece) > 0 && !request.IsChainFollowUp)
					{
						this.RequestedDirectChainHitCells[num] = true;
					}
					this.ClearQueue.Enqueue(request);
					return;
				}
				if (piece.Has(EPieceCaps.Chain) && CascadeResolver.ChainDurability(piece) > 0 && !request.IsChainFollowUp && !this.RequestedDirectChainHitCells[num])
				{
					this.RequestedDirectChainHitCells[num] = true;
					this.ClearQueue.Enqueue(request);
					return;
				}
				this.EnqueueRejudgeRequest(request, num);
				return;
			}
			else
			{
				if (!this.ClearedCells[num] && !this.RequestedClearCells[num])
				{
					this.RequestedClearCells[num] = true;
					if (piece != null && piece.Has(EPieceCaps.Chain) && CascadeResolver.ChainDurability(piece) > 0 && !request.IsChainFollowUp)
					{
						this.RequestedDirectChainHitCells[num] = true;
					}
					this.ClearQueue.Enqueue(request);
					return;
				}
				if (!this.ClearedCells[num] && piece != null && piece.Has(EPieceCaps.Chain) && CascadeResolver.ChainDurability(piece) > 0 && !request.IsChainFollowUp && !this.RequestedDirectChainHitCells[num])
				{
					this.RequestedDirectChainHitCells[num] = true;
					this.ClearQueue.Enqueue(request);
					return;
				}
				this.EnqueueRejudgeRequest(request, num);
				return;
			}
		}

		// Token: 0x06040DFD RID: 265725 RVA: 0x00FB8BCC File Offset: 0x00FB6DCC
		private void EnqueueRejudgeRequest(CascadeResolver.ClearRequest request, int cellIndex)
		{
			if (!MatchThreeGameplayDefine.IsSplashed(request.Reason) || this.RequestedRejudgeCells[cellIndex])
			{
				return;
			}
			this.RequestedRejudgeCells[cellIndex] = true;
			Queue<CascadeResolver.ClearRequest> clearQueue = this.ClearQueue;
			GridPosition pos = request.Pos;
			int delayMs = request.DelayMs;
			EPieceClearReason reason = request.Reason;
			GridPosition? detonationSource = request.DetonationSource;
			clearQueue.Enqueue(new CascadeResolver.ClearRequest(pos, delayMs, reason, null, null, null, EDirectedTrailType.None, false, false, detonationSource, true));
		}

		// Token: 0x06040DFE RID: 265726 RVA: 0x00FB8C44 File Offset: 0x00FB6E44
		private unsafe void SpawnSpecials(SolvedData solved)
		{
			int i = 0;
			while (i < solved.SpecialItemSlots.Count)
			{
				SpawnSlot spawnSlot = solved.SpecialItemSlots[i];
				Piece piece = this.Board.GetPiece(spawnSlot.Pos.Row, spawnSlot.Pos.Col);
				if (piece == null)
				{
					piece = this.Board.RentPiece(spawnSlot.Type, spawnSlot.Extra);
					this.Board.SetPiece(spawnSlot.Pos.Row, spawnSlot.Pos.Col, piece);
					goto IL_124;
				}
				if (!piece.Has(EPieceCaps.Chain))
				{
					piece = this.Board.ReplacePiece(spawnSlot.Pos.Row, spawnSlot.Pos.Col, spawnSlot.Type, spawnSlot.Extra);
					goto IL_124;
				}
				if (i < this.SpawnSlotSeqs.Count)
				{
					ItemSequence itemSequence = this.SpawnSlotSeqs[i];
					GridPosition gridPosition;
					if (this.TryFindEmptyCellInSeq(itemSequence, spawnSlot.Pos, out gridPosition))
					{
						piece = this.Board.RentPiece(spawnSlot.Type, spawnSlot.Extra);
						this.Board.SetPiece(gridPosition.Row, gridPosition.Col, piece);
						spawnSlot.Pos = gridPosition;
						goto IL_124;
					}
				}
				IL_26C:
				i++;
				continue;
				IL_124:
				int num = spawnSlot.Pos.Row * 8 + spawnSlot.Pos.Col;
				int num2 = this.ClearEventIdx[num];
				if (num2 < 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.CB;
					string message = "[SpawnSpecials] 产物位本段没有消除事件，产物无处挂载";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "Pos";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted<int>(spawnSlot.Pos.Row);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(spawnSlot.Pos.Col);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", spawnSlot.Type);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					goto IL_26C;
				}
				PieceClearEvent value = this.PieceClears[num2];
				value.SpawnType = new EPieceType?(spawnSlot.Type);
				value.SpawnPiece = piece;
				this.PieceClears[num2] = value;
				this.DirtyCols.Add(spawnSlot.Pos.Col);
				this.CountGeneratedSpecial(spawnSlot.Type, spawnSlot.Extra);
				goto IL_26C;
			}
			solved.SpecialItemSlots.Clear();
			this.SpawnSlotSeqs.Clear();
		}

		// Token: 0x06040DFF RID: 265727 RVA: 0x00FB8EE8 File Offset: 0x00FB70E8
		private bool TryFindEmptyCellInSeq(in ItemSequence seq, GridPosition exclude, out GridPosition found)
		{
			for (int i = 0; i < seq.HLen; i++)
			{
				int hstartRow = seq.HStartRow;
				int num = seq.HStartCol + i;
				if ((hstartRow != exclude.Row || num != exclude.Col) && this.Board.GetPiece(hstartRow, num) == null)
				{
					found = new GridPosition(hstartRow, num);
					return true;
				}
			}
			for (int j = 0; j < seq.VLen; j++)
			{
				int num2 = seq.VStartRow + j;
				int vstartCol = seq.VStartCol;
				if ((num2 != exclude.Row || vstartCol != exclude.Col) && this.Board.GetPiece(num2, vstartCol) == null)
				{
					found = new GridPosition(num2, vstartCol);
					return true;
				}
			}
			found = default(GridPosition);
			return false;
		}

		// Token: 0x04021CC2 RID: 138434
		private readonly Board Board;

		// Token: 0x04021CC3 RID: 138435
		private readonly SequenceDetector Detector;

		// Token: 0x04021CC4 RID: 138436
		private readonly BoardFillStrategy FillStrategy;

		// Token: 0x04021CC5 RID: 138437
		private readonly EnergyPool Energy;

		// Token: 0x04021CC6 RID: 138438
		private readonly GameRandom Rng;

		// Token: 0x04021CC7 RID: 138439
		private readonly HashSet<int> DirtyCols = new HashSet<int>();

		// Token: 0x04021CC8 RID: 138440
		private readonly List<PieceClearEvent> PieceClears = new List<PieceClearEvent>();

		// Token: 0x04021CC9 RID: 138441
		private readonly List<PieceHitEvent> PieceHits = new List<PieceHitEvent>();

		// Token: 0x04021CCA RID: 138442
		private readonly List<PieceTransformEvent> PieceTransforms = new List<PieceTransformEvent>();

		// Token: 0x04021CCB RID: 138443
		private readonly List<PieceAttachEvent> PieceAttaches = new List<PieceAttachEvent>();

		// Token: 0x04021CCC RID: 138444
		private readonly List<PieceRecolorEvent> PieceRecolors = new List<PieceRecolorEvent>();

		// Token: 0x04021CCD RID: 138445
		private readonly List<PieceMoveEvent> PieceMoves = new List<PieceMoveEvent>();

		// Token: 0x04021CCE RID: 138446
		private readonly List<MechanicTipEvent> MechanicTips = new List<MechanicTipEvent>();

		// Token: 0x04021CCF RID: 138447
		private readonly List<SkillTipEvent> SkillTips = new List<SkillTipEvent>();

		// Token: 0x04021CD0 RID: 138448
		private readonly List<ScorePopEvent> ScorePops = new List<ScorePopEvent>();

		// Token: 0x04021CD1 RID: 138449
		private int EnergyTrailCharged;

		// Token: 0x04021CD2 RID: 138450
		private readonly List<SkillTrailEvent> SkillTrails = new List<SkillTrailEvent>();

		// Token: 0x04021CD3 RID: 138451
		private readonly List<MechanicTrailEvent> MechanicTrails = new List<MechanicTrailEvent>();

		// Token: 0x04021CD4 RID: 138452
		private readonly List<RecycleTrailSettleEvent> RecycleTrailSettles = new List<RecycleTrailSettleEvent>();

		// Token: 0x04021CD5 RID: 138453
		public readonly List<int> LandedCols = new List<int>();

		// Token: 0x04021CD6 RID: 138454
		private readonly SegmentJobs[] SegmentBuffers = new SegmentJobs[]
		{
			new SegmentJobs(),
			new SegmentJobs()
		};

		// Token: 0x04021CD7 RID: 138455
		private int SegmentBufferIndex;

		// Token: 0x04021CD8 RID: 138456
		private readonly Queue<CascadeResolver.ClearRequest> ClearQueue = new Queue<CascadeResolver.ClearRequest>(56);

		// Token: 0x04021CD9 RID: 138457
		private readonly bool[] RequestedClearCells;

		// Token: 0x04021CDA RID: 138458
		private readonly bool[] RequestedRejudgeCells;

		// Token: 0x04021CDB RID: 138459
		private readonly bool[] RequestedDirectChainHitCells;

		// Token: 0x04021CDC RID: 138460
		private readonly int[] PendingHealthClearCounts;

		// Token: 0x04021CDD RID: 138461
		private readonly bool[] ClearedCells;

		// Token: 0x04021CDE RID: 138462
		private readonly bool[] ClaimedCenters;

		// Token: 0x04021CDF RID: 138463
		private readonly bool[] HitCells;

		// Token: 0x04021CE0 RID: 138464
		private readonly bool[] DirectChainHitCells;

		// Token: 0x04021CE1 RID: 138465
		private readonly List<CascadeResolver.ChainDirectHitData> DirectChainHits = new List<CascadeResolver.ChainDirectHitData>();

		// Token: 0x04021CE2 RID: 138466
		private readonly bool[] DetonationDependencyVisited;

		// Token: 0x04021CE3 RID: 138467
		private readonly int[] ClearEventIdx;

		// Token: 0x04021CE4 RID: 138468
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly EliminateRule[] SeqCellRule;

		// Token: 0x04021CE5 RID: 138469
		[Nullable(2)]
		private EliminateRule CurrentRule;

		// Token: 0x04021CE6 RID: 138470
		private readonly CascadeResolver.CascadeResolverContext Context;

		// Token: 0x04021CE7 RID: 138471
		private readonly CascadeResolver.MechanicContext MechanicCtx;

		// Token: 0x04021CE8 RID: 138472
		[Nullable(2)]
		private SolvedData CurrentSolved;

		// Token: 0x04021CE9 RID: 138473
		private readonly Action<int, int> EnqueueCell;

		// Token: 0x04021CEA RID: 138474
		private readonly int[] Dr;

		// Token: 0x04021CEB RID: 138475
		private readonly int[] Dc;

		// Token: 0x04021CEC RID: 138476
		private readonly Dictionary<EPieceType, IReadOnlyList<EliminateRule>> RulesByType;

		// Token: 0x04021CF0 RID: 138480
		private EPieceType? CurrentDetonator;

		// Token: 0x04021CF1 RID: 138481
		private bool CurrentRequestIsChainFollowUp;

		// Token: 0x04021CF2 RID: 138482
		[Nullable(2)]
		private EliminateRule CurrentClearRule;

		// Token: 0x04021CF3 RID: 138483
		private int CurrentClearDelayMs;

		// Token: 0x04021CF4 RID: 138484
		private GridPosition? CurrentLandAnchor;

		// Token: 0x04021CF5 RID: 138485
		[Nullable(2)]
		private BombComponent SharedChainBomb;

		// Token: 0x04021CF6 RID: 138486
		[Nullable(2)]
		private CrossClearComponent SharedChainCross;

		// Token: 0x04021CF7 RID: 138487
		private bool ChainTicked;

		// Token: 0x04021CF8 RID: 138488
		private GridPosition? PreferredChainSource;

		// Token: 0x04021CF9 RID: 138489
		private GridPosition? AlternateChainSource;

		// Token: 0x04021CFA RID: 138490
		private bool SuppressChainDetonationTrails;

		// Token: 0x04021CFB RID: 138491
		private readonly List<ItemSequence> SpawnSlotSeqs;

		// Token: 0x04021CFC RID: 138492
		private readonly MatchThreeStatsKeeper Stats;

		// Token: 0x0200C72B RID: 50987
		[NullableContext(0)]
		private readonly struct ChainDirectHitData
		{
			// Token: 0x06050EA8 RID: 331432 RVA: 0x015DEC19 File Offset: 0x015DCE19
			public ChainDirectHitData(GridPosition pos, int delayMs, EPieceClearReason reason, GridPosition? trailOrigin, GridPosition? landAnchor, EDirectedTrailType directedTrail, GridPosition? detonationSource)
			{
				this.Pos = pos;
				this.DelayMs = delayMs;
				this.Reason = reason;
				this.TrailOrigin = trailOrigin;
				this.LandAnchor = landAnchor;
				this.DirectedTrail = directedTrail;
				this.DetonationSource = detonationSource;
			}

			// Token: 0x0403C2B9 RID: 246457
			public readonly GridPosition Pos;

			// Token: 0x0403C2BA RID: 246458
			public readonly int DelayMs;

			// Token: 0x0403C2BB RID: 246459
			public readonly EPieceClearReason Reason;

			// Token: 0x0403C2BC RID: 246460
			public readonly GridPosition? TrailOrigin;

			// Token: 0x0403C2BD RID: 246461
			public readonly GridPosition? LandAnchor;

			// Token: 0x0403C2BE RID: 246462
			public readonly EDirectedTrailType DirectedTrail;

			// Token: 0x0403C2BF RID: 246463
			public readonly GridPosition? DetonationSource;
		}

		// Token: 0x0200C72C RID: 50988
		[NullableContext(0)]
		private readonly struct ClearRequest
		{
			// Token: 0x06050EA9 RID: 331433 RVA: 0x015DEC50 File Offset: 0x015DCE50
			public ClearRequest(GridPosition pos, int delayMs, EPieceClearReason reason, EPieceType? source = null, GridPosition? trailOrigin = null, GridPosition? landAnchor = null, EDirectedTrailType directedTrail = EDirectedTrailType.None, bool opensDirectedTrails = false, bool isChainFollowUp = false, GridPosition? detonationSource = null, bool isRejudgeOnly = false)
			{
				this.Pos = pos;
				this.DelayMs = delayMs;
				this.Reason = reason;
				this.Source = source;
				this.TrailOrigin = trailOrigin;
				this.LandAnchor = landAnchor;
				this.DirectedTrail = directedTrail;
				this.OpensDirectedTrails = opensDirectedTrails;
				this.IsChainFollowUp = isChainFollowUp;
				this.DetonationSource = detonationSource;
				this.IsRejudgeOnly = isRejudgeOnly;
			}

			// Token: 0x0403C2C0 RID: 246464
			public readonly GridPosition Pos;

			// Token: 0x0403C2C1 RID: 246465
			public readonly int DelayMs;

			// Token: 0x0403C2C2 RID: 246466
			public readonly EPieceClearReason Reason;

			// Token: 0x0403C2C3 RID: 246467
			public readonly EPieceType? Source;

			// Token: 0x0403C2C4 RID: 246468
			public readonly GridPosition? TrailOrigin;

			// Token: 0x0403C2C5 RID: 246469
			public readonly GridPosition? LandAnchor;

			// Token: 0x0403C2C6 RID: 246470
			public readonly EDirectedTrailType DirectedTrail;

			// Token: 0x0403C2C7 RID: 246471
			public readonly bool OpensDirectedTrails;

			// Token: 0x0403C2C8 RID: 246472
			public readonly bool IsChainFollowUp;

			// Token: 0x0403C2C9 RID: 246473
			public readonly GridPosition? DetonationSource;

			// Token: 0x0403C2CA RID: 246474
			public readonly bool IsRejudgeOnly;
		}

		// Token: 0x0200C72D RID: 50989
		[Nullable(0)]
		private sealed class CascadeResolverContext : IDispatchContext
		{
			// Token: 0x06050EAA RID: 331434 RVA: 0x015DECB2 File Offset: 0x015DCEB2
			public CascadeResolverContext(CascadeResolver owner)
			{
			}

			// Token: 0x1700A28C RID: 41612
			// (get) Token: 0x06050EAB RID: 331435 RVA: 0x015DECC1 File Offset: 0x015DCEC1
			public Board Board
			{
				get
				{
					return this.Owner.Board;
				}
			}

			// Token: 0x06050EAC RID: 331436 RVA: 0x015DECD0 File Offset: 0x015DCED0
			public void RequestClear(GridPosition pos, int delayMs = 0, EPieceClearReason reason = EPieceClearReason.Matched, GridPosition? detonationSource = null)
			{
				if (!this.Board.InBounds(pos.Row, pos.Col))
				{
					return;
				}
				GridPosition? gridPosition = detonationSource;
				if (detonationSource != null && detonationSource.Value.Row == pos.Row && detonationSource.Value.Col == pos.Col)
				{
					gridPosition = null;
				}
				CascadeResolver owner = this.Owner;
				int delayMs2 = this.Owner.CurrentClearDelayMs + delayMs;
				EPieceType? currentDetonator = this.Owner.CurrentDetonator;
				GridPosition? currentLandAnchor = this.Owner.CurrentLandAnchor;
				bool currentRequestIsChainFollowUp = this.Owner.CurrentRequestIsChainFollowUp;
				GridPosition? detonationSource2 = gridPosition;
				owner.EnqueueClearRequest(new CascadeResolver.ClearRequest(pos, delayMs2, reason, currentDetonator, null, currentLandAnchor, EDirectedTrailType.None, false, currentRequestIsChainFollowUp, detonationSource2, false));
			}

			// Token: 0x06050EAD RID: 331437 RVA: 0x015DED88 File Offset: 0x015DCF88
			public void MarkCrossClearPresentation(GridPosition pos)
			{
				int num = pos.Row * 8 + pos.Col;
				int num2 = this.Owner.ClearEventIdx[num];
				if (num2 >= 0)
				{
					PieceClearEvent value = this.Owner.PieceClears[num2];
					value.PlayCrossClearAudio = true;
					this.Owner.PieceClears[num2] = value;
					return;
				}
				for (int i = this.Owner.PieceHits.Count - 1; i >= 0; i--)
				{
					PieceHitEvent pieceHitEvent = this.Owner.PieceHits[i];
					if (pieceHitEvent.Pos.Row == pos.Row && pieceHitEvent.Pos.Col == pos.Col)
					{
						pieceHitEvent.PlayCrossClearAudio = true;
						this.Owner.PieceHits[i] = pieceHitEvent;
						return;
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[MarkCrossClearPresentation] 十字引爆找不到对应表现事件";
				string item = "Pos";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}

			// Token: 0x06050EAE RID: 331438 RVA: 0x015DEED8 File Offset: 0x015DD0D8
			public void MarkDetonationPresentation(GridPosition pos)
			{
				int num = pos.Row * 8 + pos.Col;
				int num2 = this.Owner.ClearEventIdx[num];
				if (num2 >= 0)
				{
					PieceClearEvent value = this.Owner.PieceClears[num2];
					value.OpensDetonation = true;
					this.Owner.PieceClears[num2] = value;
					return;
				}
				for (int i = this.Owner.PieceHits.Count - 1; i >= 0; i--)
				{
					PieceHitEvent pieceHitEvent = this.Owner.PieceHits[i];
					if (pieceHitEvent.Pos.Row == pos.Row && pieceHitEvent.Pos.Col == pos.Col)
					{
						pieceHitEvent.OpensDetonation = true;
						this.Owner.PieceHits[i] = pieceHitEvent;
						return;
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[MarkDetonationPresentation] 引爆找不到对应表现事件";
				string item = "Pos";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}

			// Token: 0x06050EAF RID: 331439 RVA: 0x015DF028 File Offset: 0x015DD228
			public void RequestUltimateStrike(GridPosition origin, GridPosition target, EPieceClearReason reason)
			{
				if (!this.Board.InBounds(target.Row, target.Col))
				{
					return;
				}
				CascadeResolver owner = this.Owner;
				int delayMs = 0;
				EPieceType? currentDetonator = this.Owner.CurrentDetonator;
				GridPosition? trailOrigin = new GridPosition?(origin);
				bool currentRequestIsChainFollowUp = this.Owner.CurrentRequestIsChainFollowUp;
				owner.EnqueueClearRequest(new CascadeResolver.ClearRequest(target, delayMs, reason, currentDetonator, trailOrigin, null, EDirectedTrailType.Ultimate, false, currentRequestIsChainFollowUp, null, false));
			}

			// Token: 0x06050EB0 RID: 331440 RVA: 0x015DF098 File Offset: 0x015DD298
			public void RemovePiece(GridPosition pos)
			{
				if (!this.Board.InBounds(pos.Row, pos.Col))
				{
					return;
				}
				this.Owner.ClearCell(this.Owner.CurrentSolved, pos, true, 0, EPieceClearReason.ClearSelf, null, null, null, EDirectedTrailType.None, false, null);
			}

			// Token: 0x1700A28D RID: 41613
			// (get) Token: 0x06050EB1 RID: 331441 RVA: 0x015DF0FF File Offset: 0x015DD2FF
			[Nullable(2)]
			public EliminateRule CurrentClearRule
			{
				[NullableContext(2)]
				get
				{
					return this.Owner.CurrentClearRule;
				}
			}

			// Token: 0x06050EB2 RID: 331442 RVA: 0x015DF10C File Offset: 0x015DD30C
			public void AddScore(int amount)
			{
				this.Owner.LastSegmentScore += amount;
			}

			// Token: 0x06050EB3 RID: 331443 RVA: 0x015DF121 File Offset: 0x015DD321
			public void AddCharge(int amount)
			{
				this.Owner.LastSegmentCharge += amount;
			}

			// Token: 0x06050EB4 RID: 331444 RVA: 0x015DF136 File Offset: 0x015DD336
			public void AddTurns(int amount)
			{
				if (amount <= 0)
				{
					return;
				}
				SolvedData currentSolved = this.Owner.CurrentSolved;
				currentSolved.MovesDelta -= amount;
				currentSolved.SegmentTurnGain += amount;
			}

			// Token: 0x06050EB5 RID: 331445 RVA: 0x015DF163 File Offset: 0x015DD363
			public void EmitEnergyTrail(int energy)
			{
				this.Owner.EnergyTrailCharged += energy;
				this.Owner.LastSegmentTrailCharge += energy;
			}

			// Token: 0x06050EB6 RID: 331446 RVA: 0x015DF18B File Offset: 0x015DD38B
			public int NextRandom(int maxExclusive)
			{
				return this.Owner.Rng.Next(maxExclusive);
			}

			// Token: 0x0403C2CB RID: 246475
			private readonly CascadeResolver Owner = owner;
		}

		// Token: 0x0200C72E RID: 50990
		[Nullable(0)]
		private sealed class MechanicContext : IMechanicContext, ISkillContext
		{
			// Token: 0x06050EB7 RID: 331447 RVA: 0x015DF1A0 File Offset: 0x015DD3A0
			public MechanicContext(CascadeResolver owner)
			{
			}

			// Token: 0x06050EB8 RID: 331448 RVA: 0x015DF222 File Offset: 0x015DD422
			public IReadOnlyList<GridPosition> PickGenerateCells(int count, IReadOnlyList<CellZone> zones)
			{
				this.PickResult.Clear();
				if (count <= 0)
				{
					return this.PickResult;
				}
				this.PickGenerateCellsByBuff(count, zones, false);
				int count2 = this.PickResult.Count;
				this.PickGenerateCellsByBuff(count, zones, true);
				return this.PickResult;
			}

			// Token: 0x06050EB9 RID: 331449 RVA: 0x015DF260 File Offset: 0x015DD460
			private void PickGenerateCellsByBuff(int count, IReadOnlyList<CellZone> zones, bool buffed)
			{
				int num = 0;
				while (num < zones.Count && this.PickResult.Count < count)
				{
					CellZone cellZone = zones[num];
					this.Candidates.Clear();
					int num2 = Math.Min(cellZone.RowEnd, 6);
					int num3 = Math.Min(cellZone.ColEnd, 7);
					for (int i = Math.Max(cellZone.RowStart, 0); i <= num2; i++)
					{
						for (int j = Math.Max(cellZone.ColStart, 0); j <= num3; j++)
						{
							if (!CascadeResolver.MechanicContext.CoveredByEarlierZone(zones, num, i, j))
							{
								Piece piece = this.Owner.Board.GetPiece(i, j);
								if (piece != null && MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type) && CascadeResolver.HasBuff(piece) == buffed)
								{
									this.Candidates.Add(new GridPosition(i, j));
								}
							}
						}
					}
					this.TakeRandom(this.Candidates, count);
					num++;
				}
			}

			// Token: 0x06050EBA RID: 331450 RVA: 0x015DF35C File Offset: 0x015DD55C
			private static bool CoveredByEarlierZone(IReadOnlyList<CellZone> zones, int zoneIndex, int row, int col)
			{
				for (int i = 0; i < zoneIndex; i++)
				{
					if (zones[i].Contains(row, col))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06050EBB RID: 331451 RVA: 0x015DF38C File Offset: 0x015DD58C
			private void TakeRandom(List<GridPosition> candidates, int count)
			{
				while (this.PickResult.Count < count && candidates.Count > 0)
				{
					int index = this.Owner.Rng.Next(candidates.Count);
					this.PickResult.Add(candidates[index]);
					candidates[index] = candidates[candidates.Count - 1];
					candidates.RemoveAt(candidates.Count - 1);
				}
			}

			// Token: 0x06050EBC RID: 331452 RVA: 0x015DF3FE File Offset: 0x015DD5FE
			public int GetRecycleClearCount(EPieceType type)
			{
				if (this.Owner.CurrentSolved == null)
				{
					return 0;
				}
				if (type == EPieceType.Charger)
				{
					return this.Owner.CurrentSolved.RecycleChargerClearCount;
				}
				if (type == EPieceType.Hourglass)
				{
					return this.Owner.CurrentSolved.RecycleHourglassClearCount;
				}
				return 0;
			}

			// Token: 0x06050EBD RID: 331453 RVA: 0x015DF43C File Offset: 0x015DD63C
			[NullableContext(2)]
			public void TransformPiece(int envId, GridPosition pos, EPieceType type, int[] extra = null)
			{
				Piece piece = this.Owner.Board.ReplacePiece(pos.Row, pos.Col, type, extra);
				if (piece == null)
				{
					return;
				}
				this.Owner.MechanicTrails.Add(new MechanicTrailEvent(envId, pos, type));
				this.Owner.PieceTransforms.Add(new PieceTransformEvent(pos, type, piece));
			}

			// Token: 0x06050EBE RID: 331454 RVA: 0x015DF49D File Offset: 0x015DD69D
			[NullableContext(2)]
			public void ShowTip(string textId, int remainingRounds, int generateCount)
			{
				if (string.IsNullOrEmpty(textId))
				{
					return;
				}
				this.Owner.MechanicTips.Add(new MechanicTipEvent(textId, remainingRounds, generateCount));
			}

			// Token: 0x06050EBF RID: 331455 RVA: 0x015DF4C0 File Offset: 0x015DD6C0
			public int NextRandom(int maxExclusive)
			{
				return this.Owner.Rng.Next(maxExclusive);
			}

			// Token: 0x06050EC0 RID: 331456 RVA: 0x015DF4D4 File Offset: 0x015DD6D4
			public void ApplyAllureSmallRecolor(int skillId)
			{
				for (int i = 5; i >= 3; i--)
				{
					if (this.TryApplyAllureWindowByLength(skillId, i))
					{
						return;
					}
				}
				this.ApplyAllureRandomFallback(skillId);
			}

			// Token: 0x06050EC1 RID: 331457 RVA: 0x015DF4FF File Offset: 0x015DD6FF
			private bool TryApplyAllureWindowByLength(int skillId, int length)
			{
				return this.TryApplyAllureWindowInArea(skillId, length, true) || this.TryApplyAllureWindowInArea(skillId, length, false);
			}

			// Token: 0x06050EC2 RID: 331458 RVA: 0x015DF518 File Offset: 0x015DD718
			private bool TryApplyAllureWindowInArea(int skillId, int length, bool centerArea)
			{
				int rowStart = (centerArea > false) ? 1 : 0;
				int rowEnd = centerArea ? 5 : 6;
				int colStart = (centerArea > false) ? 1 : 0;
				int colEnd = centerArea ? 6 : 7;
				bool flag = this.Owner.Rng.Next(2) == 0;
				return this.TryApplyAllureWindowInDirection(skillId, length, rowStart, rowEnd, colStart, colEnd, flag, centerArea) || this.TryApplyAllureWindowInDirection(skillId, length, rowStart, rowEnd, colStart, colEnd, !flag, centerArea);
			}

			// Token: 0x06050EC3 RID: 331459 RVA: 0x015DF57C File Offset: 0x015DD77C
			private bool TryApplyAllureWindowInDirection(int skillId, int length, int rowStart, int rowEnd, int colStart, int colEnd, bool horizontal, bool centerArea)
			{
				this.AllureWindowCandidates.Clear();
				this.CollectAllureWindowCandidates(length, rowStart, rowEnd, colStart, colEnd, horizontal);
				if (this.AllureWindowCandidates.Count == 0)
				{
					return false;
				}
				CascadeResolver.MechanicContext.AllureWindowCandidate candidate = this.AllureWindowCandidates[this.Owner.Rng.Next(this.AllureWindowCandidates.Count)];
				this.ApplyAllureWindow(candidate, ESkillRecolorPresentation.AllureSmall);
				return true;
			}

			// Token: 0x06050EC4 RID: 331460 RVA: 0x015DF5E4 File Offset: 0x015DD7E4
			private void CollectAllureWindowCandidates(int length, int rowStart, int rowEnd, int colStart, int colEnd, bool horizontal)
			{
				if (horizontal)
				{
					for (int i = rowStart; i <= rowEnd; i++)
					{
						int num = colStart;
						while (num + length - 1 <= colEnd)
						{
							if (this.IsAllureWindowValid(i, num, length, true))
							{
								this.AllureWindowCandidates.Add(new CascadeResolver.MechanicContext.AllureWindowCandidate(i, num, length, true));
							}
							num++;
						}
					}
					return;
				}
				int num2 = rowStart;
				while (num2 + length - 1 <= rowEnd)
				{
					for (int j = colStart; j <= colEnd; j++)
					{
						if (this.IsAllureWindowValid(num2, j, length, false))
						{
							this.AllureWindowCandidates.Add(new CascadeResolver.MechanicContext.AllureWindowCandidate(num2, j, length, false));
						}
					}
					num2++;
				}
			}

			// Token: 0x06050EC5 RID: 331461 RVA: 0x015DF674 File Offset: 0x015DD874
			private bool IsAllureWindowValid(int row, int col, int length, bool horizontal)
			{
				for (int i = 0; i < length; i++)
				{
					int row2 = horizontal ? row : (row + i);
					int col2 = horizontal ? (col + i) : col;
					Piece piece = this.Owner.Board.GetPiece(row2, col2);
					if (piece == null || !MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06050EC6 RID: 331462 RVA: 0x015DF6D0 File Offset: 0x015DD8D0
			private int ApplyAllureWindow(CascadeResolver.MechanicContext.AllureWindowCandidate candidate, ESkillRecolorPresentation presentation)
			{
				this.PickResult.Clear();
				for (int i = 0; i < candidate.Length; i++)
				{
					int row = candidate.Horizontal ? candidate.Row : (candidate.Row + i);
					int col = candidate.Horizontal ? (candidate.Col + i) : candidate.Col;
					this.PickResult.Add(new GridPosition(row, col));
				}
				return this.ApplyAllurePositions(this.PickResult, presentation);
			}

			// Token: 0x06050EC7 RID: 331463 RVA: 0x015DF74C File Offset: 0x015DD94C
			private void ApplyAllureRandomFallback(int skillId)
			{
				this.AllureRandomCells.Clear();
				for (int i = 0; i < 7; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Piece piece = this.Owner.Board.GetPiece(i, j);
						if (piece != null && MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type))
						{
							this.AllureRandomCells.Add(new GridPosition(i, j));
						}
					}
				}
				this.PickResult.Clear();
				this.TakeRandom(this.AllureRandomCells, 3);
				if (this.PickResult.Count >= 3)
				{
					this.ApplyAllurePositions(this.PickResult, ESkillRecolorPresentation.AllureSmall);
				}
			}

			// Token: 0x06050EC8 RID: 331464 RVA: 0x015DF7EC File Offset: 0x015DD9EC
			private int ApplyAllurePositions(IReadOnlyList<GridPosition> positions, ESkillRecolorPresentation presentation)
			{
				this.AllureColors.Clear();
				for (int i = 0; i < positions.Count; i++)
				{
					GridPosition gridPosition = positions[i];
					Piece piece = this.Owner.Board.GetPiece(gridPosition.Row, gridPosition.Col);
					if (piece != null)
					{
						this.AddAllureColor(piece.Type);
					}
				}
				if (this.AllureColors.Count == 0)
				{
					return 0;
				}
				EPieceType epieceType = this.AllureColors[this.Owner.Rng.Next(this.AllureColors.Count)];
				int num = 0;
				for (int j = 0; j < positions.Count; j++)
				{
					GridPosition gridPosition2 = positions[j];
					Piece piece2 = this.Owner.Board.GetPiece(gridPosition2.Row, gridPosition2.Col);
					if (piece2 != null && piece2.Type != epieceType && this.AddRecolorEvent(gridPosition2, epieceType, presentation))
					{
						num++;
					}
				}
				return num;
			}

			// Token: 0x06050EC9 RID: 331465 RVA: 0x015DF8E4 File Offset: 0x015DDAE4
			private void AddAllureColor(EPieceType type)
			{
				for (int i = 0; i < this.AllureColors.Count; i++)
				{
					if (this.AllureColors[i] == type)
					{
						return;
					}
				}
				this.AllureColors.Add(type);
			}

			// Token: 0x06050ECA RID: 331466 RVA: 0x015DF924 File Offset: 0x015DDB24
			public void ApplyAllureUltimateRecolor(int skillId, IReadOnlyList<int> sourceRanks, int targetRank)
			{
				EPieceType[] array = new EPieceType[]
				{
					EPieceType.Red,
					EPieceType.Yellow,
					EPieceType.Blue,
					EPieceType.Green,
					EPieceType.Purple
				};
				int[] counts = new int[array.Length];
				this.ShuffleAllureColors(array);
				this.CountAllureColors(array, counts);
				CascadeResolver.MechanicContext.SortAllureColorsByCount(array, counts);
				int num = CascadeResolver.MechanicContext.CountNonZeroColors(counts);
				if (num <= 1)
				{
					return;
				}
				if (!this.ValidateAllureUltimateRanks(skillId, sourceRanks, targetRank, array.Length))
				{
					return;
				}
				bool flag = targetRank > num;
				int num2 = 0;
				while (num2 < sourceRanks.Count && !flag)
				{
					flag = (sourceRanks[num2] > num);
					num2++;
				}
				IReadOnlyList<int> sourceRanks2 = sourceRanks;
				int num3 = targetRank;
				if (flag)
				{
					sourceRanks2 = new int[]
					{
						1
					};
					num3 = 2;
				}
				EPieceType targetType = array[num3 - 1];
				this.RecolorAllureSourceColors(sourceRanks2, array, targetType);
			}

			// Token: 0x06050ECB RID: 331467 RVA: 0x015DF9D4 File Offset: 0x015DDBD4
			private unsafe bool ValidateAllureUltimateRanks(int skillId, IReadOnlyList<int> sourceRanks, int targetRank, int colorCount)
			{
				if (sourceRanks.Count == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.HMQ;
					string message = "[MechanicContext.ValidateAllureUltimateRanks] 心月狐大招来源颜色排名配置为空";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				if (targetRank <= 0 || targetRank > colorCount)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.MatchThree;
					ELogAuthor author2 = ELogAuthor.HMQ;
					string message2 = "[MechanicContext.ValidateAllureUltimateRanks] 心月狐大招目标颜色排名配置无效";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetRank", targetRank);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ColorCount", colorCount);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return false;
				}
				for (int i = 0; i < sourceRanks.Count; i++)
				{
					int num = sourceRanks[i];
					if (num <= 0 || num > colorCount || num == targetRank)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.MatchThree;
						ELogAuthor author3 = ELogAuthor.HMQ;
						string message3 = "[MechanicContext.ValidateAllureUltimateRanks] 心月狐大招来源颜色排名配置无效";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SkillId", skillId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SourceRank", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetRank", targetRank);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("ColorCount", colorCount);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
						return false;
					}
				}
				return true;
			}

			// Token: 0x06050ECC RID: 331468 RVA: 0x015DFB78 File Offset: 0x015DDD78
			private void ShuffleAllureColors(EPieceType[] colors)
			{
				for (int i = 0; i < colors.Length - 1; i++)
				{
					int num = i + this.Owner.Rng.Next(colors.Length - i);
					EPieceType epieceType = colors[i];
					colors[i] = colors[num];
					colors[num] = epieceType;
				}
			}

			// Token: 0x06050ECD RID: 331469 RVA: 0x015DFBBC File Offset: 0x015DDDBC
			private void CountAllureColors(EPieceType[] colors, int[] counts)
			{
				for (int i = 0; i < 7; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Piece piece = this.Owner.Board.GetPiece(i, j);
						if (piece != null)
						{
							int num = CascadeResolver.MechanicContext.IndexOfAllureColor(colors, piece.Type);
							if (num >= 0)
							{
								counts[num]++;
							}
						}
					}
				}
			}

			// Token: 0x06050ECE RID: 331470 RVA: 0x015DFC14 File Offset: 0x015DDE14
			private static int IndexOfAllureColor(EPieceType[] colors, EPieceType type)
			{
				for (int i = 0; i < colors.Length; i++)
				{
					if (colors[i] == type)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06050ECF RID: 331471 RVA: 0x015DFC38 File Offset: 0x015DDE38
			private static void SortAllureColorsByCount(EPieceType[] colors, int[] counts)
			{
				for (int i = 0; i < colors.Length - 1; i++)
				{
					int num = i;
					for (int j = i + 1; j < colors.Length; j++)
					{
						if (counts[j] > counts[num])
						{
							num = j;
						}
					}
					if (num != i)
					{
						int num2 = counts[i];
						counts[i] = counts[num];
						counts[num] = num2;
						EPieceType epieceType = colors[i];
						colors[i] = colors[num];
						colors[num] = epieceType;
					}
				}
			}

			// Token: 0x06050ED0 RID: 331472 RVA: 0x015DFC98 File Offset: 0x015DDE98
			private static int CountNonZeroColors(int[] counts)
			{
				int num = 0;
				for (int i = 0; i < counts.Length; i++)
				{
					if (counts[i] > 0)
					{
						num++;
					}
				}
				return num;
			}

			// Token: 0x06050ED1 RID: 331473 RVA: 0x015DFCC0 File Offset: 0x015DDEC0
			private int RecolorAllureSourceColors(IReadOnlyList<int> sourceRanks, EPieceType[] colors, EPieceType targetType)
			{
				int num = 0;
				for (int i = 0; i < 7; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Piece piece = this.Owner.Board.GetPiece(i, j);
						if (piece != null && this.IsAllureSourceType(piece.Type, sourceRanks, colors) && this.AddRecolorEvent(new GridPosition(i, j), targetType, ESkillRecolorPresentation.AllureUltimate))
						{
							num++;
						}
					}
				}
				return num;
			}

			// Token: 0x06050ED2 RID: 331474 RVA: 0x015DFD24 File Offset: 0x015DDF24
			private bool IsAllureSourceType(EPieceType pieceType, IReadOnlyList<int> sourceRanks, EPieceType[] colors)
			{
				for (int i = 0; i < sourceRanks.Count; i++)
				{
					if (pieceType == colors[sourceRanks[i] - 1])
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06050ED3 RID: 331475 RVA: 0x015DFD54 File Offset: 0x015DDF54
			private unsafe bool AddRecolorEvent(GridPosition pos, EPieceType targetType, ESkillRecolorPresentation presentation)
			{
				Piece piece = this.Owner.Board.GetPiece(pos.Row, pos.Col);
				if (piece == null || piece.Type == targetType)
				{
					return false;
				}
				EPieceType type = piece.Type;
				Piece piece2 = this.Owner.Board.RecolorPiece(pos.Row, pos.Col, targetType);
				if (piece2 == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.HMQ;
					string message = "[MechanicContext.AddRecolorEvent] 心月狐改色失败";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "Pos";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Row);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Col);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("From", type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Target", targetType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Presentation", presentation);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return false;
				}
				this.Owner.PieceRecolors.Add(new PieceRecolorEvent(pos, type, targetType, piece2, presentation));
				return true;
			}

			// Token: 0x06050ED4 RID: 331476 RVA: 0x015DFEB8 File Offset: 0x015DE0B8
			public void AttachChain(GridPosition pos, int[] chainExtra, bool withBomb, bool withTrail)
			{
				if (withBomb)
				{
					this.Owner.Board.AppendComponents(pos.Row, pos.Col, this.BombExtra);
				}
				Piece piece = this.Owner.Board.AppendComponents(pos.Row, pos.Col, chainExtra);
				if (piece == null)
				{
					return;
				}
				if (withTrail)
				{
					this.Owner.SkillTrails.Add(new SkillTrailEvent(pos, ESkillTrailType.Chain, piece));
					return;
				}
				this.Owner.PieceAttaches.Add(new PieceAttachEvent(pos, piece));
			}

			// Token: 0x06050ED5 RID: 331477 RVA: 0x015DFF44 File Offset: 0x015DE144
			public IReadOnlyList<GridPosition> PickChainCells(int count, out bool anyEffectCarrier)
			{
				this.PickResult.Clear();
				this.ExistingBlocks.Clear();
				this.PickedEffectCarrier = false;
				this.PickedBombCount = 0;
				this.PickedCrossCount = 0;
				this.BombCandidates.Clear();
				this.CrossCandidates.Clear();
				this.Candidates.Clear();
				for (int i = 0; i < 7; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Piece piece = this.Owner.Board.GetPiece(i, j);
						if (piece != null)
						{
							if (piece.Has(EPieceCaps.Block))
							{
								this.ExistingBlocks.Add(new GridPosition(i, j));
							}
							if (MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type) && !piece.Has(EPieceCaps.Chain))
							{
								(CascadeResolver.HasComponent<BombComponent>(piece) ? this.BombCandidates : (CascadeResolver.HasComponent<CrossClearComponent>(piece) ? this.CrossCandidates : this.Candidates)).Add(new GridPosition(i, j));
							}
						}
					}
				}
				this.Shuffle(this.BombCandidates);
				this.Shuffle(this.CrossCandidates);
				this.Shuffle(this.Candidates);
				int num = 3;
				int num2;
				if (this.TryTakeEffectTypePair(count, out num2))
				{
					num = num2;
				}
				for (;;)
				{
					this.TakeEffectSpread(count, num);
					if (this.PickResult.Count >= count || (this.BombCandidates.Count == 0 && this.CrossCandidates.Count == 0) || num <= 1)
					{
						break;
					}
					num--;
				}
				num = 3;
				for (;;)
				{
					this.TakeNormalSpread(count, num);
					if (this.PickResult.Count >= count || num <= 1)
					{
						break;
					}
					num--;
				}
				anyEffectCarrier = this.PickedEffectCarrier;
				return this.PickResult;
			}

			// Token: 0x06050ED6 RID: 331478 RVA: 0x015E00EC File Offset: 0x015DE2EC
			private bool TryTakeEffectTypePair(int count, out int pairDistance)
			{
				pairDistance = 3;
				if (count < 2 || this.BombCandidates.Count == 0 || this.CrossCandidates.Count == 0)
				{
					return false;
				}
				for (int i = 3; i >= 1; i--)
				{
					for (int j = 0; j < this.BombCandidates.Count; j++)
					{
						GridPosition gridPosition = this.BombCandidates[j];
						if (CascadeResolver.MechanicContext.FarFromAll(this.ExistingBlocks, gridPosition, i))
						{
							for (int k = 0; k < this.CrossCandidates.Count; k++)
							{
								GridPosition gridPosition2 = this.CrossCandidates[k];
								if (CascadeResolver.MechanicContext.FarFromAll(this.ExistingBlocks, gridPosition2, i) && Math.Abs(gridPosition.Row - gridPosition2.Row) + Math.Abs(gridPosition.Col - gridPosition2.Col) >= i)
								{
									this.BombCandidates.RemoveAt(j);
									this.CrossCandidates.RemoveAt(k);
									if (this.Owner.Rng.Next(2) == 0)
									{
										this.PickResult.Add(gridPosition);
										this.PickResult.Add(gridPosition2);
									}
									else
									{
										this.PickResult.Add(gridPosition2);
										this.PickResult.Add(gridPosition);
									}
									this.PickedEffectCarrier = true;
									this.PickedBombCount++;
									this.PickedCrossCount++;
									pairDistance = i;
									return true;
								}
							}
						}
					}
				}
				return false;
			}

			// Token: 0x06050ED7 RID: 331479 RVA: 0x015E025C File Offset: 0x015DE45C
			private void TakeEffectSpread(int count, int distance)
			{
				bool flag = this.TakeOneEffectSpread(count, distance);
				while (flag)
				{
					flag = this.TakeOneEffectSpread(count, distance);
				}
			}

			// Token: 0x06050ED8 RID: 331480 RVA: 0x015E0280 File Offset: 0x015DE480
			private void TakeNormalSpread(int count, int distance)
			{
				bool flag = this.TakeOneSpread(this.Candidates, count, distance);
				while (flag)
				{
					flag = this.TakeOneSpread(this.Candidates, count, distance);
				}
			}

			// Token: 0x06050ED9 RID: 331481 RVA: 0x015E02B0 File Offset: 0x015DE4B0
			private bool TakeOneEffectSpread(int count, int distance)
			{
				if (this.PickResult.Count >= count)
				{
					return false;
				}
				bool flag = this.BombCandidates.Count != 0 && (this.CrossCandidates.Count == 0 || this.Owner.Rng.Next(2) == 0);
				if (flag)
				{
					return this.TakeOneEffectCandidate(this.BombCandidates, true, count, distance) || this.TakeOneEffectCandidate(this.CrossCandidates, false, count, distance);
				}
				return this.TakeOneEffectCandidate(this.CrossCandidates, false, count, distance) || this.TakeOneEffectCandidate(this.BombCandidates, true, count, distance);
			}

			// Token: 0x06050EDA RID: 331482 RVA: 0x015E034C File Offset: 0x015DE54C
			private bool TakeOneEffectCandidate(List<GridPosition> candidates, bool isBomb, int count, int distance)
			{
				if (!this.TakeOneSpread(candidates, count, distance))
				{
					return false;
				}
				this.PickedEffectCarrier = true;
				if (isBomb)
				{
					this.PickedBombCount++;
				}
				else
				{
					this.PickedCrossCount++;
				}
				return true;
			}

			// Token: 0x06050EDB RID: 331483 RVA: 0x015E0388 File Offset: 0x015DE588
			private bool TakeOneSpread(List<GridPosition> candidates, int count, int distance)
			{
				if (this.PickResult.Count >= count)
				{
					return false;
				}
				for (int i = 0; i < candidates.Count; i++)
				{
					if (this.FarEnough(candidates[i], distance))
					{
						this.PickResult.Add(candidates[i]);
						candidates.RemoveAt(i);
						return true;
					}
				}
				return false;
			}

			// Token: 0x06050EDC RID: 331484 RVA: 0x015E03E2 File Offset: 0x015DE5E2
			private bool FarEnough(GridPosition pos, int distance)
			{
				return CascadeResolver.MechanicContext.FarFromAll(this.PickResult, pos, distance) && CascadeResolver.MechanicContext.FarFromAll(this.ExistingBlocks, pos, distance);
			}

			// Token: 0x06050EDD RID: 331485 RVA: 0x015E0404 File Offset: 0x015DE604
			private static bool FarFromAll(List<GridPosition> cells, GridPosition pos, int distance)
			{
				for (int i = 0; i < cells.Count; i++)
				{
					if (Math.Abs(cells[i].Row - pos.Row) + Math.Abs(cells[i].Col - pos.Col) < distance)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06050EDE RID: 331486 RVA: 0x015E045C File Offset: 0x015DE65C
			private void Shuffle(List<GridPosition> candidates)
			{
				for (int i = candidates.Count - 1; i > 0; i--)
				{
					int num = this.Owner.Rng.Next(i + 1);
					int index = i;
					int index2 = num;
					GridPosition value = candidates[num];
					GridPosition value2 = candidates[i];
					candidates[index] = value;
					candidates[index2] = value2;
				}
			}

			// Token: 0x0403C2CC RID: 246476
			private readonly CascadeResolver Owner = owner;

			// Token: 0x0403C2CD RID: 246477
			private readonly List<GridPosition> Candidates = new List<GridPosition>();

			// Token: 0x0403C2CE RID: 246478
			private readonly List<GridPosition> PickResult = new List<GridPosition>();

			// Token: 0x0403C2CF RID: 246479
			private readonly List<GridPosition> BombCandidates = new List<GridPosition>();

			// Token: 0x0403C2D0 RID: 246480
			private readonly List<GridPosition> CrossCandidates = new List<GridPosition>();

			// Token: 0x0403C2D1 RID: 246481
			private readonly List<GridPosition> ExistingBlocks = new List<GridPosition>();

			// Token: 0x0403C2D2 RID: 246482
			private bool PickedEffectCarrier;

			// Token: 0x0403C2D3 RID: 246483
			private int PickedBombCount;

			// Token: 0x0403C2D4 RID: 246484
			private int PickedCrossCount;

			// Token: 0x0403C2D5 RID: 246485
			private readonly List<CascadeResolver.MechanicContext.AllureWindowCandidate> AllureWindowCandidates = new List<CascadeResolver.MechanicContext.AllureWindowCandidate>();

			// Token: 0x0403C2D6 RID: 246486
			private readonly List<GridPosition> AllureRandomCells = new List<GridPosition>();

			// Token: 0x0403C2D7 RID: 246487
			private readonly List<EPieceType> AllureColors = new List<EPieceType>();

			// Token: 0x0403C2D8 RID: 246488
			private const int AllureCenterRowStart = 1;

			// Token: 0x0403C2D9 RID: 246489
			private const int AllureCenterRowEnd = 5;

			// Token: 0x0403C2DA RID: 246490
			private const int AllureCenterColStart = 1;

			// Token: 0x0403C2DB RID: 246491
			private const int AllureCenterColEnd = 6;

			// Token: 0x0403C2DC RID: 246492
			private const int AllureFallbackCount = 3;

			// Token: 0x0403C2DD RID: 246493
			private readonly int[] BombExtra = new int[]
			{
				3
			};

			// Token: 0x0200D1A5 RID: 53669
			[NullableContext(0)]
			private readonly struct AllureWindowCandidate
			{
				// Token: 0x06052580 RID: 337280 RVA: 0x0166893E File Offset: 0x01666B3E
				public AllureWindowCandidate(int row, int col, int length, bool horizontal)
				{
					this.Row = row;
					this.Col = col;
					this.Length = length;
					this.Horizontal = horizontal;
				}

				// Token: 0x0403EE88 RID: 257672
				public readonly int Row;

				// Token: 0x0403EE89 RID: 257673
				public readonly int Col;

				// Token: 0x0403EE8A RID: 257674
				public readonly int Length;

				// Token: 0x0403EE8B RID: 257675
				public readonly bool Horizontal;
			}
		}
	}
}
