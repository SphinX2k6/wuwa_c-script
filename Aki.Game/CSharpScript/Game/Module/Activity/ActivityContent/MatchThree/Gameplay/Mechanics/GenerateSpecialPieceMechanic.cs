using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x0200546B RID: 21611
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class GenerateSpecialPieceMechanic : LevelMechanic
	{
		// Token: 0x06035A62 RID: 219746 RVA: 0x00EFC7F8 File Offset: 0x00EFA9F8
		public GenerateSpecialPieceMechanic(int envId, int triggerRound, int delayRounds, int count, EPieceType targetType, IReadOnlyList<CellZone> zones, [Nullable(2)] string tip)
		{
		}

		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x06035A63 RID: 219747 RVA: 0x00EFC84F File Offset: 0x00EFAA4F
		public int EnvId { get; } = envId;

		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x06035A64 RID: 219748 RVA: 0x00EFC857 File Offset: 0x00EFAA57
		public int MountRound { get; } = triggerRound;

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x06035A65 RID: 219749 RVA: 0x00EFC85F File Offset: 0x00EFAA5F
		public int FireRound { get; } = triggerRound + delayRounds;

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x06035A66 RID: 219750 RVA: 0x00EFC867 File Offset: 0x00EFAA67
		public EPieceType TargetType { get; } = targetType;

		// Token: 0x17006846 RID: 26694
		// (get) Token: 0x06035A67 RID: 219751 RVA: 0x00EFC86F File Offset: 0x00EFAA6F
		public int GenerateCount { get; } = count;

		// Token: 0x17006847 RID: 26695
		// (get) Token: 0x06035A68 RID: 219752 RVA: 0x00EFC877 File Offset: 0x00EFAA77
		public int Period { get; } = Math.Max(1, delayRounds);

		// Token: 0x06035A69 RID: 219753 RVA: 0x00EFC880 File Offset: 0x00EFAA80
		public override MechanicTipEvent? CreateMountTip(int round)
		{
			if (round != this.MountRound || string.IsNullOrEmpty(this.<tip>P))
			{
				return null;
			}
			return new MechanicTipEvent?(new MechanicTipEvent(this.<tip>P, this.FireRound - round, this.GenerateCount));
		}

		// Token: 0x06035A6A RID: 219754 RVA: 0x00EFC8CB File Offset: 0x00EFAACB
		public int RoundsUntilFire(int round)
		{
			if (round >= this.FireRound)
			{
				return this.Period - (round - this.FireRound) % this.Period;
			}
			return this.FireRound - round;
		}

		// Token: 0x06035A6B RID: 219755 RVA: 0x00EFC8F8 File Offset: 0x00EFAAF8
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

		// Token: 0x0401C5C7 RID: 116167
		[CompilerGenerated]
		private IReadOnlyList<CellZone> <zones>P = zones;

		// Token: 0x0401C5C8 RID: 116168
		[Nullable(2)]
		[CompilerGenerated]
		private string <tip>P = tip;
	}
}
