using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064ED RID: 25837
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class GenerateSpecialPieceMechanic : LevelMechanic
	{
		// Token: 0x06040D9E RID: 265630 RVA: 0x00FB57C8 File Offset: 0x00FB39C8
		public GenerateSpecialPieceMechanic(int envId, int triggerRound, int delayRounds, int count, EPieceType targetType, IReadOnlyList<CellZone> zones, [Nullable(2)] string tip)
		{
		}

		// Token: 0x170094E0 RID: 38112
		// (get) Token: 0x06040D9F RID: 265631 RVA: 0x00FB581F File Offset: 0x00FB3A1F
		public int EnvId { get; } = envId;

		// Token: 0x170094E1 RID: 38113
		// (get) Token: 0x06040DA0 RID: 265632 RVA: 0x00FB5827 File Offset: 0x00FB3A27
		public int MountRound { get; } = triggerRound;

		// Token: 0x170094E2 RID: 38114
		// (get) Token: 0x06040DA1 RID: 265633 RVA: 0x00FB582F File Offset: 0x00FB3A2F
		public int FireRound { get; } = triggerRound + delayRounds;

		// Token: 0x170094E3 RID: 38115
		// (get) Token: 0x06040DA2 RID: 265634 RVA: 0x00FB5837 File Offset: 0x00FB3A37
		public EPieceType TargetType { get; } = targetType;

		// Token: 0x170094E4 RID: 38116
		// (get) Token: 0x06040DA3 RID: 265635 RVA: 0x00FB583F File Offset: 0x00FB3A3F
		public int GenerateCount { get; } = count;

		// Token: 0x170094E5 RID: 38117
		// (get) Token: 0x06040DA4 RID: 265636 RVA: 0x00FB5847 File Offset: 0x00FB3A47
		public int Period { get; } = Math.Max(1, delayRounds);

		// Token: 0x06040DA5 RID: 265637 RVA: 0x00FB5850 File Offset: 0x00FB3A50
		public override MechanicTipEvent? CreateMountTip(int round)
		{
			if (round != this.MountRound || string.IsNullOrEmpty(this.<tip>P))
			{
				return null;
			}
			return new MechanicTipEvent?(new MechanicTipEvent(this.<tip>P, this.FireRound - round, this.GenerateCount));
		}

		// Token: 0x06040DA6 RID: 265638 RVA: 0x00FB589B File Offset: 0x00FB3A9B
		public int RoundsUntilFire(int round)
		{
			if (round >= this.FireRound)
			{
				return this.Period - (round - this.FireRound) % this.Period;
			}
			return this.FireRound - round;
		}

		// Token: 0x06040DA7 RID: 265639 RVA: 0x00FB58C8 File Offset: 0x00FB3AC8
		public override void OnRound(int round, IMechanicContext ctx)
		{
			MechanicTipEvent? mechanicTipEvent = this.CreateMountTip(round);
			if (mechanicTipEvent != null)
			{
				MechanicTipEvent value = mechanicTipEvent.Value;
				ctx.ShowTip(value.TextId, value.RemainingRounds, value.GenerateCount);
			}
			if (round < this.FireRound || (round - this.FireRound) % this.Period != 0)
			{
				return;
			}
			IReadOnlyList<GridPosition> readOnlyList = ctx.PickGenerateCells(this.GenerateCount, this.<zones>P);
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				ctx.TransformPiece(this.EnvId, readOnlyList[i], this.TargetType, null);
			}
		}

		// Token: 0x04021C96 RID: 138390
		[CompilerGenerated]
		private IReadOnlyList<CellZone> <zones>P = zones;

		// Token: 0x04021C97 RID: 138391
		[Nullable(2)]
		[CompilerGenerated]
		private string <tip>P = tip;
	}
}
