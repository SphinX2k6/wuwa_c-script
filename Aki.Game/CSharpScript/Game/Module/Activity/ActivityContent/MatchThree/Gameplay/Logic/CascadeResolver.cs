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
	// Token: 0x02005470 RID: 21616
	[NullableContext(1)]
	[Nullable(0)]
	public class CascadeResolver
	{
		// Token: 0x1700684B RID: 26699
		// (get) Token: 0x06035A8F RID: 219791 RVA: 0x00EFDA6A File Offset: 0x00EFBC6A
		// (set) Token: 0x06035A90 RID: 219792 RVA: 0x00EFDA72 File Offset: 0x00EFBC72
		private int LastSegmentScore { get; set; }

		// Token: 0x1700684C RID: 26700
		// (get) Token: 0x06035A91 RID: 219793 RVA: 0x00EFDA7B File Offset: 0x00EFBC7B
		// (set) Token: 0x06035A92 RID: 219794 RVA: 0x00EFDA83 File Offset: 0x00EFBC83
		private int LastSegmentCharge { get; set; }

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x06035A93 RID: 219795 RVA: 0x00EFDA8C File Offset: 0x00EFBC8C
		// (set) Token: 0x06035A94 RID: 219796 RVA: 0x00EFDA94 File Offset: 0x00EFBC94
		private int LastSegmentTrailCharge { get; set; }

		// Token: 0x06035A95 RID: 219797 RVA: 0x00EFDAA0 File Offset: 0x00EFBCA0
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

		// Token: 0x06035A96 RID: 219798 RVA: 0x00EFDCA8 File Offset: 0x00EFBEA8
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

		// Token: 0x06035A97 RID: 219799 RVA: 0x00EFDE8F File Offset: 0x00EFC08F
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

		// Token: 0x06035A98 RID: 219800 RVA: 0x00EFDEC8 File Offset: 0x00EFC0C8
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

		// Token: 0x06035A99 RID: 219801 RVA: 0x00EFDFC0 File Offset: 0x00EFC1C0
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

		// Token: 0x06035A9A RID: 219802 RVA: 0x00EFE018 File Offset: 0x00EFC218
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

		// Token: 0x06035A9B RID: 219803 RVA: 0x00EFE0C8 File Offset: 0x00EFC2C8
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

		// Token: 0x06035A9C RID: 219804 RVA: 0x00EFE120 File Offset: 0x00EFC320
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

		// Token: 0x06035A9D RID: 219805 RVA: 0x00EFE20D File Offset: 0x00EFC40D
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> ResolveTurnSettle(SolvedData solved)
		{
			return null;
		}

		// Token: 0x06035A9E RID: 219806 RVA: 0x00EFE210 File Offset: 0x00EFC410
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

		// Token: 0x06035A9F RID: 219807 RVA: 0x00EFE2C4 File Offset: 0x00EFC4C4
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

		// Token: 0x06035AA0 RID: 219808 RVA: 0x00EFE36C File Offset: 0x00EFC56C
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

		// Token: 0x06035AA1 RID: 219809 RVA: 0x00EFE448 File Offset: 0x00EFC648
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

		// Token: 0x06035AA2 RID: 219810 RVA: 0x00EFE52C File Offset: 0x00EFC72C
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

		// Token: 0x06035AA3 RID: 219811 RVA: 0x00EFE5F8 File Offset: 0x00EFC7F8
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

		// Token: 0x06035AA4 RID: 219812 RVA: 0x00EFE64C File Offset: 0x00EFC84C
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

		// Token: 0x06035AA5 RID: 219813 RVA: 0x00EFE69C File Offset: 0x00EFC89C
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

		// Token: 0x06035AA6 RID: 219814 RVA: 0x00EFE6EC File Offset: 0x00EFC8EC
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

		// Token: 0x06035AA7 RID: 219815 RVA: 0x00EFEA10 File Offset: 0x00EFCC10
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

		// Token: 0x06035AA8 RID: 219816 RVA: 0x00EFEB34 File Offset: 0x00EFCD34
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

		// Token: 0x06035AA9 RID: 219817 RVA: 0x00EFEF7B File Offset: 0x00EFD17B
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

		// Token: 0x06035AAA RID: 219818 RVA: 0x00EFEF8C File Offset: 0x00EFD18C
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

		// Token: 0x06035AAB RID: 219819 RVA: 0x00EFF031 File Offset: 0x00EFD231
		private bool WouldCreateDetonationCycle(GridPosition target, GridPosition source)
		{
			Array.Clear(this.DetonationDependencyVisited, 0, this.DetonationDependencyVisited.Length);
			return this.DependsOnPosition(source, target);
		}

		// Token: 0x06035AAC RID: 219820 RVA: 0x00EFF050 File Offset: 0x00EFD250
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

		// Token: 0x06035AAD RID: 219821 RVA: 0x00EFF146 File Offset: 0x00EFD346
		private bool DependencyReachesTarget(GridPosition? dependency, GridPosition target)
		{
			return dependency != null && this.DependsOnPosition(dependency.Value, target);
		}

		// Token: 0x06035AAE RID: 219822 RVA: 0x00EFF161 File Offset: 0x00EFD361
		private static bool IsSamePosition(GridPosition? position, GridPosition target)
		{
			return position != null && position.Value.Row == target.Row && position.Value.Col == target.Col;
		}

		// Token: 0x06035AAF RID: 219823 RVA: 0x00EFF198 File Offset: 0x00EFD398
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

		// Token: 0x06035AB0 RID: 219824 RVA: 0x00EFF1D8 File Offset: 0x00EFD3D8
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

		// Token: 0x06035AB1 RID: 219825 RVA: 0x00EFF2A4 File Offset: 0x00EFD4A4
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

		// Token: 0x06035AB2 RID: 219826 RVA: 0x00EFF2F0 File Offset: 0x00EFD4F0
		private void TickChainGroup(SolvedData solved)
		{
			this.SharedChainBomb = null;
			this.SharedChainCross = null;
			int num = this.PrepareChainGroupEffects();
			GridPosition source = this.SelectChainDetonationSource();
			bool hasTrailTargets = !this.SuppressChainDetonationTrails && num > this.DirectChainHits.Count;
			this.TickChainPieces(solved, source, hasTrailTargets);
		}

		// Token: 0x06035AB3 RID: 219827 RVA: 0x00EFF340 File Offset: 0x00EFD540
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

		// Token: 0x06035AB4 RID: 219828 RVA: 0x00EFF3BC File Offset: 0x00EFD5BC
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

		// Token: 0x06035AB5 RID: 219829 RVA: 0x00EFF508 File Offset: 0x00EFD708
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

		// Token: 0x06035AB6 RID: 219830 RVA: 0x00EFF568 File Offset: 0x00EFD768
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

		// Token: 0x06035AB7 RID: 219831 RVA: 0x00EFF5B8 File Offset: 0x00EFD7B8
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

		// Token: 0x06035AB8 RID: 219832 RVA: 0x00EFF77C File Offset: 0x00EFD97C
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

		// Token: 0x06035AB9 RID: 219833 RVA: 0x00EFF807 File Offset: 0x00EFDA07
		private bool IsDirectChainHit(GridPosition pos)
		{
			return this.DirectChainHitCells[pos.Row * 8 + pos.Col];
		}

		// Token: 0x06035ABA RID: 219834 RVA: 0x00EFF820 File Offset: 0x00EFDA20
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

		// Token: 0x06035ABB RID: 219835 RVA: 0x00EFF888 File Offset: 0x00EFDA88
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

		// Token: 0x06035ABC RID: 219836 RVA: 0x00EFF918 File Offset: 0x00EFDB18
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

		// Token: 0x06035ABD RID: 219837 RVA: 0x00EFF988 File Offset: 0x00EFDB88
		private static int ChainDurability(Piece piece)
		{
			ChainComponent chainComponent = CascadeResolver.FindComponent<ChainComponent>(piece);
			if (chainComponent != null)
			{
				return piece.StateOf(chainComponent).Val1;
			}
			return 0;
		}

		// Token: 0x06035ABE RID: 219838 RVA: 0x00EFF9B0 File Offset: 0x00EFDBB0
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

		// Token: 0x06035ABF RID: 219839 RVA: 0x00EFFA0C File Offset: 0x00EFDC0C
		private static bool HasBuff(Piece piece)
		{
			return CascadeResolver.HasComponent<BombComponent>(piece) || CascadeResolver.HasComponent<CrossClearComponent>(piece) || piece.Has(EPieceCaps.Chain);
		}

		// Token: 0x06035AC0 RID: 219840 RVA: 0x00EFFA2C File Offset: 0x00EFDC2C
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

		// Token: 0x06035AC1 RID: 219841 RVA: 0x00EFFBFC File Offset: 0x00EFDDFC
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

		// Token: 0x06035AC2 RID: 219842 RVA: 0x00EFFC74 File Offset: 0x00EFDE74
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

		// Token: 0x06035AC3 RID: 219843 RVA: 0x00EFFF18 File Offset: 0x00EFE118
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

		// Token: 0x0401C5F3 RID: 116211
		private readonly Board Board;

		// Token: 0x0401C5F4 RID: 116212
		private readonly SequenceDetector Detector;

		// Token: 0x0401C5F5 RID: 116213
		private readonly BoardFillStrategy FillStrategy;

		// Token: 0x0401C5F6 RID: 116214
		private readonly EnergyPool Energy;

		// Token: 0x0401C5F7 RID: 116215
		private readonly GameRandom Rng;

		// Token: 0x0401C5F8 RID: 116216
		private readonly HashSet<int> DirtyCols = new HashSet<int>();

		// Token: 0x0401C5F9 RID: 116217
		private readonly List<PieceClearEvent> PieceClears = new List<PieceClearEvent>();

		// Token: 0x0401C5FA RID: 116218
		private readonly List<PieceHitEvent> PieceHits = new List<PieceHitEvent>();

		// Token: 0x0401C5FB RID: 116219
		private readonly List<PieceTransformEvent> PieceTransforms = new List<PieceTransformEvent>();

		// Token: 0x0401C5FC RID: 116220
		private readonly List<PieceAttachEvent> PieceAttaches = new List<PieceAttachEvent>();

		// Token: 0x0401C5FD RID: 116221
		private readonly List<PieceRecolorEvent> PieceRecolors = new List<PieceRecolorEvent>();

		// Token: 0x0401C5FE RID: 116222
		private readonly List<PieceMoveEvent> PieceMoves = new List<PieceMoveEvent>();

		// Token: 0x0401C5FF RID: 116223
		private readonly List<MechanicTipEvent> MechanicTips = new List<MechanicTipEvent>();

		// Token: 0x0401C600 RID: 116224
		private readonly List<SkillTipEvent> SkillTips = new List<SkillTipEvent>();

		// Token: 0x0401C601 RID: 116225
		private readonly List<ScorePopEvent> ScorePops = new List<ScorePopEvent>();

		// Token: 0x0401C602 RID: 116226
		private int EnergyTrailCharged;

		// Token: 0x0401C603 RID: 116227
		private readonly List<SkillTrailEvent> SkillTrails = new List<SkillTrailEvent>();

		// Token: 0x0401C604 RID: 116228
		private readonly List<MechanicTrailEvent> MechanicTrails = new List<MechanicTrailEvent>();

		// Token: 0x0401C605 RID: 116229
		private readonly List<RecycleTrailSettleEvent> RecycleTrailSettles = new List<RecycleTrailSettleEvent>();

		// Token: 0x0401C606 RID: 116230
		public readonly List<int> LandedCols = new List<int>();

		// Token: 0x0401C607 RID: 116231
		private readonly SegmentJobs[] SegmentBuffers = new SegmentJobs[]
		{
			new SegmentJobs(),
			new SegmentJobs()
		};

		// Token: 0x0401C608 RID: 116232
		private int SegmentBufferIndex;

		// Token: 0x0401C609 RID: 116233
		private readonly Queue<CascadeResolver.ClearRequest> ClearQueue = new Queue<CascadeResolver.ClearRequest>(56);

		// Token: 0x0401C60A RID: 116234
		private readonly bool[] RequestedClearCells;

		// Token: 0x0401C60B RID: 116235
		private readonly bool[] RequestedRejudgeCells;

		// Token: 0x0401C60C RID: 116236
		private readonly bool[] RequestedDirectChainHitCells;

		// Token: 0x0401C60D RID: 116237
		private readonly int[] PendingHealthClearCounts;

		// Token: 0x0401C60E RID: 116238
		private readonly bool[] ClearedCells;

		// Token: 0x0401C60F RID: 116239
		private readonly bool[] ClaimedCenters;

		// Token: 0x0401C610 RID: 116240
		private readonly bool[] HitCells;

		// Token: 0x0401C611 RID: 116241
		private readonly bool[] DirectChainHitCells;

		// Token: 0x0401C612 RID: 116242
		private readonly List<CascadeResolver.ChainDirectHitData> DirectChainHits = new List<CascadeResolver.ChainDirectHitData>();

		// Token: 0x0401C613 RID: 116243
		private readonly bool[] DetonationDependencyVisited;

		// Token: 0x0401C614 RID: 116244
		private readonly int[] ClearEventIdx;

		// Token: 0x0401C615 RID: 116245
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly EliminateRule[] SeqCellRule;

		// Token: 0x0401C616 RID: 116246
		[Nullable(2)]
		private EliminateRule CurrentRule;

		// Token: 0x0401C617 RID: 116247
		private readonly CascadeResolver.CascadeResolverContext Context;

		// Token: 0x0401C618 RID: 116248
		private readonly CascadeResolver.MechanicContext MechanicCtx;

		// Token: 0x0401C619 RID: 116249
		[Nullable(2)]
		private SolvedData CurrentSolved;

		// Token: 0x0401C61A RID: 116250
		private readonly Action<int, int> EnqueueCell;

		// Token: 0x0401C61B RID: 116251
		private readonly int[] Dr;

		// Token: 0x0401C61C RID: 116252
		private readonly int[] Dc;

		// Token: 0x0401C61D RID: 116253
		private readonly Dictionary<EPieceType, IReadOnlyList<EliminateRule>> RulesByType;

		// Token: 0x0401C621 RID: 116257
		private EPieceType? CurrentDetonator;

		// Token: 0x0401C622 RID: 116258
		private bool CurrentRequestIsChainFollowUp;

		// Token: 0x0401C623 RID: 116259
		[Nullable(2)]
		private EliminateRule CurrentClearRule;

		// Token: 0x0401C624 RID: 116260
		private int CurrentClearDelayMs;

		// Token: 0x0401C625 RID: 116261
		private GridPosition? CurrentLandAnchor;

		// Token: 0x0401C626 RID: 116262
		[Nullable(2)]
		private BombComponent SharedChainBomb;

		// Token: 0x0401C627 RID: 116263
		[Nullable(2)]
		private CrossClearComponent SharedChainCross;

		// Token: 0x0401C628 RID: 116264
		private bool ChainTicked;

		// Token: 0x0401C629 RID: 116265
		private GridPosition? PreferredChainSource;

		// Token: 0x0401C62A RID: 116266
		private GridPosition? AlternateChainSource;

		// Token: 0x0401C62B RID: 116267
		private bool SuppressChainDetonationTrails;

		// Token: 0x0401C62C RID: 116268
		private readonly List<ItemSequence> SpawnSlotSeqs;

		// Token: 0x0401C62D RID: 116269
		private readonly MatchThreeStatsKeeper Stats;

		// Token: 0x0200B111 RID: 45329
		[NullableContext(0)]
		private readonly struct ChainDirectHitData
		{
			// Token: 0x06047388 RID: 291720 RVA: 0x01596975 File Offset: 0x01594B75
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

			// Token: 0x04036C14 RID: 224276
			public readonly GridPosition Pos;

			// Token: 0x04036C15 RID: 224277
			public readonly int DelayMs;

			// Token: 0x04036C16 RID: 224278
			public readonly EPieceClearReason Reason;

			// Token: 0x04036C17 RID: 224279
			public readonly GridPosition? TrailOrigin;

			// Token: 0x04036C18 RID: 224280
			public readonly GridPosition? LandAnchor;

			// Token: 0x04036C19 RID: 224281
			public readonly EDirectedTrailType DirectedTrail;

			// Token: 0x04036C1A RID: 224282
			public readonly GridPosition? DetonationSource;
		}

		// Token: 0x0200B112 RID: 45330
		[NullableContext(0)]
		private readonly struct ClearRequest
		{
			// Token: 0x06047389 RID: 291721 RVA: 0x015969AC File Offset: 0x01594BAC
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

			// Token: 0x04036C1B RID: 224283
			public readonly GridPosition Pos;

			// Token: 0x04036C1C RID: 224284
			public readonly int DelayMs;

			// Token: 0x04036C1D RID: 224285
			public readonly EPieceClearReason Reason;

			// Token: 0x04036C1E RID: 224286
			public readonly EPieceType? Source;

			// Token: 0x04036C1F RID: 224287
			public readonly GridPosition? TrailOrigin;

			// Token: 0x04036C20 RID: 224288
			public readonly GridPosition? LandAnchor;

			// Token: 0x04036C21 RID: 224289
			public readonly EDirectedTrailType DirectedTrail;

			// Token: 0x04036C22 RID: 224290
			public readonly bool OpensDirectedTrails;

			// Token: 0x04036C23 RID: 224291
			public readonly bool IsChainFollowUp;

			// Token: 0x04036C24 RID: 224292
			public readonly GridPosition? DetonationSource;

			// Token: 0x04036C25 RID: 224293
			public readonly bool IsRejudgeOnly;
		}

		// Token: 0x0200B113 RID: 45331
		[Nullable(0)]
		private sealed class CascadeResolverContext : IDispatchContext
		{
			// Token: 0x0604738A RID: 291722 RVA: 0x01596A0E File Offset: 0x01594C0E
			public CascadeResolverContext(CascadeResolver owner)
			{
			}

			// Token: 0x17007A29 RID: 31273
			// (get) Token: 0x0604738B RID: 291723 RVA: 0x01596A1D File Offset: 0x01594C1D
			public Board Board
			{
				get
				{
					return this.Owner.Board;
				}
			}

			// Token: 0x0604738C RID: 291724 RVA: 0x01596A2C File Offset: 0x01594C2C
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

			// Token: 0x0604738D RID: 291725 RVA: 0x01596AE4 File Offset: 0x01594CE4
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

			// Token: 0x0604738E RID: 291726 RVA: 0x01596C34 File Offset: 0x01594E34
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

			// Token: 0x0604738F RID: 291727 RVA: 0x01596D84 File Offset: 0x01594F84
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

			// Token: 0x06047390 RID: 291728 RVA: 0x01596DF4 File Offset: 0x01594FF4
			public void RemovePiece(GridPosition pos)
			{
				if (!this.Board.InBounds(pos.Row, pos.Col))
				{
					return;
				}
				this.Owner.ClearCell(this.Owner.CurrentSolved, pos, true, 0, EPieceClearReason.ClearSelf, null, null, null, EDirectedTrailType.None, false, null);
			}

			// Token: 0x17007A2A RID: 31274
			// (get) Token: 0x06047391 RID: 291729 RVA: 0x01596E5B File Offset: 0x0159505B
			[Nullable(2)]
			public EliminateRule CurrentClearRule
			{
				[NullableContext(2)]
				get
				{
					return this.Owner.CurrentClearRule;
				}
			}

			// Token: 0x06047392 RID: 291730 RVA: 0x01596E68 File Offset: 0x01595068
			public void AddScore(int amount)
			{
				this.Owner.LastSegmentScore += amount;
			}

			// Token: 0x06047393 RID: 291731 RVA: 0x01596E7D File Offset: 0x0159507D
			public void AddCharge(int amount)
			{
				this.Owner.LastSegmentCharge += amount;
			}

			// Token: 0x06047394 RID: 291732 RVA: 0x01596E92 File Offset: 0x01595092
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

			// Token: 0x06047395 RID: 291733 RVA: 0x01596EBF File Offset: 0x015950BF
			public void EmitEnergyTrail(int energy)
			{
				this.Owner.EnergyTrailCharged += energy;
				this.Owner.LastSegmentTrailCharge += energy;
			}

			// Token: 0x06047396 RID: 291734 RVA: 0x01596EE7 File Offset: 0x015950E7
			public int NextRandom(int maxExclusive)
			{
				return this.Owner.Rng.Next(maxExclusive);
			}

			// Token: 0x04036C26 RID: 224294
			private readonly CascadeResolver Owner = owner;
		}

		// Token: 0x0200B114 RID: 45332
		[Nullable(0)]
		private sealed class MechanicContext : IMechanicContext, ISkillContext
		{
			// Token: 0x06047397 RID: 291735 RVA: 0x01596EFC File Offset: 0x015950FC
			public MechanicContext(CascadeResolver owner)
			{
			}

			// Token: 0x06047398 RID: 291736 RVA: 0x01596F7E File Offset: 0x0159517E
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

			// Token: 0x06047399 RID: 291737 RVA: 0x01596FBC File Offset: 0x015951BC
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

			// Token: 0x0604739A RID: 291738 RVA: 0x015970B8 File Offset: 0x015952B8
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

			// Token: 0x0604739B RID: 291739 RVA: 0x015970E8 File Offset: 0x015952E8
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

			// Token: 0x0604739C RID: 291740 RVA: 0x0159715A File Offset: 0x0159535A
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

			// Token: 0x0604739D RID: 291741 RVA: 0x01597198 File Offset: 0x01595398
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

			// Token: 0x0604739E RID: 291742 RVA: 0x015971F9 File Offset: 0x015953F9
			[NullableContext(2)]
			public void ShowTip(string textId, int remainingRounds, int generateCount)
			{
				if (string.IsNullOrEmpty(textId))
				{
					return;
				}
				this.Owner.MechanicTips.Add(new MechanicTipEvent(textId, remainingRounds, generateCount));
			}

			// Token: 0x0604739F RID: 291743 RVA: 0x0159721C File Offset: 0x0159541C
			public int NextRandom(int maxExclusive)
			{
				return this.Owner.Rng.Next(maxExclusive);
			}

			// Token: 0x060473A0 RID: 291744 RVA: 0x01597230 File Offset: 0x01595430
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

			// Token: 0x060473A1 RID: 291745 RVA: 0x0159725B File Offset: 0x0159545B
			private bool TryApplyAllureWindowByLength(int skillId, int length)
			{
				return this.TryApplyAllureWindowInArea(skillId, length, true) || this.TryApplyAllureWindowInArea(skillId, length, false);
			}

			// Token: 0x060473A2 RID: 291746 RVA: 0x01597274 File Offset: 0x01595474
			private bool TryApplyAllureWindowInArea(int skillId, int length, bool centerArea)
			{
				int rowStart = (centerArea > false) ? 1 : 0;
				int rowEnd = centerArea ? 5 : 6;
				int colStart = (centerArea > false) ? 1 : 0;
				int colEnd = centerArea ? 6 : 7;
				bool flag = this.Owner.Rng.Next(2) == 0;
				return this.TryApplyAllureWindowInDirection(skillId, length, rowStart, rowEnd, colStart, colEnd, flag, centerArea) || this.TryApplyAllureWindowInDirection(skillId, length, rowStart, rowEnd, colStart, colEnd, !flag, centerArea);
			}

			// Token: 0x060473A3 RID: 291747 RVA: 0x015972D8 File Offset: 0x015954D8
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

			// Token: 0x060473A4 RID: 291748 RVA: 0x01597340 File Offset: 0x01595540
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

			// Token: 0x060473A5 RID: 291749 RVA: 0x015973D0 File Offset: 0x015955D0
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

			// Token: 0x060473A6 RID: 291750 RVA: 0x0159742C File Offset: 0x0159562C
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

			// Token: 0x060473A7 RID: 291751 RVA: 0x015974A8 File Offset: 0x015956A8
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

			// Token: 0x060473A8 RID: 291752 RVA: 0x01597548 File Offset: 0x01595748
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

			// Token: 0x060473A9 RID: 291753 RVA: 0x01597640 File Offset: 0x01595840
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

			// Token: 0x060473AA RID: 291754 RVA: 0x01597680 File Offset: 0x01595880
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

			// Token: 0x060473AB RID: 291755 RVA: 0x01597730 File Offset: 0x01595930
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

			// Token: 0x060473AC RID: 291756 RVA: 0x015978D4 File Offset: 0x01595AD4
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

			// Token: 0x060473AD RID: 291757 RVA: 0x01597918 File Offset: 0x01595B18
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

			// Token: 0x060473AE RID: 291758 RVA: 0x01597970 File Offset: 0x01595B70
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

			// Token: 0x060473AF RID: 291759 RVA: 0x01597994 File Offset: 0x01595B94
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

			// Token: 0x060473B0 RID: 291760 RVA: 0x015979F4 File Offset: 0x01595BF4
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

			// Token: 0x060473B1 RID: 291761 RVA: 0x01597A1C File Offset: 0x01595C1C
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

			// Token: 0x060473B2 RID: 291762 RVA: 0x01597A80 File Offset: 0x01595C80
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

			// Token: 0x060473B3 RID: 291763 RVA: 0x01597AB0 File Offset: 0x01595CB0
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

			// Token: 0x060473B4 RID: 291764 RVA: 0x01597C14 File Offset: 0x01595E14
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

			// Token: 0x060473B5 RID: 291765 RVA: 0x01597CA0 File Offset: 0x01595EA0
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

			// Token: 0x060473B6 RID: 291766 RVA: 0x01597E48 File Offset: 0x01596048
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

			// Token: 0x060473B7 RID: 291767 RVA: 0x01597FB8 File Offset: 0x015961B8
			private void TakeEffectSpread(int count, int distance)
			{
				bool flag = this.TakeOneEffectSpread(count, distance);
				while (flag)
				{
					flag = this.TakeOneEffectSpread(count, distance);
				}
			}

			// Token: 0x060473B8 RID: 291768 RVA: 0x01597FDC File Offset: 0x015961DC
			private void TakeNormalSpread(int count, int distance)
			{
				bool flag = this.TakeOneSpread(this.Candidates, count, distance);
				while (flag)
				{
					flag = this.TakeOneSpread(this.Candidates, count, distance);
				}
			}

			// Token: 0x060473B9 RID: 291769 RVA: 0x0159800C File Offset: 0x0159620C
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

			// Token: 0x060473BA RID: 291770 RVA: 0x015980A8 File Offset: 0x015962A8
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

			// Token: 0x060473BB RID: 291771 RVA: 0x015980E4 File Offset: 0x015962E4
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

			// Token: 0x060473BC RID: 291772 RVA: 0x0159813E File Offset: 0x0159633E
			private bool FarEnough(GridPosition pos, int distance)
			{
				return CascadeResolver.MechanicContext.FarFromAll(this.PickResult, pos, distance) && CascadeResolver.MechanicContext.FarFromAll(this.ExistingBlocks, pos, distance);
			}

			// Token: 0x060473BD RID: 291773 RVA: 0x01598160 File Offset: 0x01596360
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

			// Token: 0x060473BE RID: 291774 RVA: 0x015981B8 File Offset: 0x015963B8
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

			// Token: 0x04036C27 RID: 224295
			private readonly CascadeResolver Owner = owner;

			// Token: 0x04036C28 RID: 224296
			private readonly List<GridPosition> Candidates = new List<GridPosition>();

			// Token: 0x04036C29 RID: 224297
			private readonly List<GridPosition> PickResult = new List<GridPosition>();

			// Token: 0x04036C2A RID: 224298
			private readonly List<GridPosition> BombCandidates = new List<GridPosition>();

			// Token: 0x04036C2B RID: 224299
			private readonly List<GridPosition> CrossCandidates = new List<GridPosition>();

			// Token: 0x04036C2C RID: 224300
			private readonly List<GridPosition> ExistingBlocks = new List<GridPosition>();

			// Token: 0x04036C2D RID: 224301
			private bool PickedEffectCarrier;

			// Token: 0x04036C2E RID: 224302
			private int PickedBombCount;

			// Token: 0x04036C2F RID: 224303
			private int PickedCrossCount;

			// Token: 0x04036C30 RID: 224304
			private readonly List<CascadeResolver.MechanicContext.AllureWindowCandidate> AllureWindowCandidates = new List<CascadeResolver.MechanicContext.AllureWindowCandidate>();

			// Token: 0x04036C31 RID: 224305
			private readonly List<GridPosition> AllureRandomCells = new List<GridPosition>();

			// Token: 0x04036C32 RID: 224306
			private readonly List<EPieceType> AllureColors = new List<EPieceType>();

			// Token: 0x04036C33 RID: 224307
			private const int AllureCenterRowStart = 1;

			// Token: 0x04036C34 RID: 224308
			private const int AllureCenterRowEnd = 5;

			// Token: 0x04036C35 RID: 224309
			private const int AllureCenterColStart = 1;

			// Token: 0x04036C36 RID: 224310
			private const int AllureCenterColEnd = 6;

			// Token: 0x04036C37 RID: 224311
			private const int AllureFallbackCount = 3;

			// Token: 0x04036C38 RID: 224312
			private readonly int[] BombExtra = new int[]
			{
				3
			};

			// Token: 0x0200BD83 RID: 48515
			[NullableContext(0)]
			private readonly struct AllureWindowCandidate
			{
				// Token: 0x06048E1F RID: 298527 RVA: 0x0163DF02 File Offset: 0x0163C102
				public AllureWindowCandidate(int row, int col, int length, bool horizontal)
				{
					this.Row = row;
					this.Col = col;
					this.Length = length;
					this.Horizontal = horizontal;
				}

				// Token: 0x0403A2D0 RID: 238288
				public readonly int Row;

				// Token: 0x0403A2D1 RID: 238289
				public readonly int Col;

				// Token: 0x0403A2D2 RID: 238290
				public readonly int Length;

				// Token: 0x0403A2D3 RID: 238291
				public readonly bool Horizontal;
			}
		}
	}
}
