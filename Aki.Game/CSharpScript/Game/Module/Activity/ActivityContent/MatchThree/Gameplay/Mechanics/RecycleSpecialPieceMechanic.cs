using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x0200546C RID: 21612
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class RecycleSpecialPieceMechanic : LevelMechanic
	{
		// Token: 0x06035A6C RID: 219756 RVA: 0x00EFC98F File Offset: 0x00EFAB8F
		public RecycleSpecialPieceMechanic(int envId, int mountRound, EPieceType targetType, IReadOnlyList<CellZone> zones, [Nullable(2)] string tip)
		{
		}

		// Token: 0x17006848 RID: 26696
		// (get) Token: 0x06035A6D RID: 219757 RVA: 0x00EFC9BC File Offset: 0x00EFABBC
		public int EnvId { get; } = envId;

		// Token: 0x17006849 RID: 26697
		// (get) Token: 0x06035A6E RID: 219758 RVA: 0x00EFC9C4 File Offset: 0x00EFABC4
		public int MountRound { get; } = mountRound;

		// Token: 0x1700684A RID: 26698
		// (get) Token: 0x06035A6F RID: 219759 RVA: 0x00EFC9CC File Offset: 0x00EFABCC
		public EPieceType TargetType { get; } = targetType;

		// Token: 0x06035A70 RID: 219760 RVA: 0x00EFC9D4 File Offset: 0x00EFABD4
		public override MechanicTipEvent? CreateMountTip(int round)
		{
			if (round != this.MountRound || string.IsNullOrEmpty(this.<tip>P))
			{
				return null;
			}
			return new MechanicTipEvent?(new MechanicTipEvent(this.<tip>P, 0, 0));
		}

		// Token: 0x06035A71 RID: 219761 RVA: 0x00EFCA14 File Offset: 0x00EFAC14
		public override void OnRound(int round, IMechanicContext ctx)
		{
			MechanicTipEvent? mechanicTipEvent = this.CreateMountTip(round);
			if (mechanicTipEvent != null)
			{
				MechanicTipEvent value = mechanicTipEvent.Value;
				ctx.ShowTip(value.TextId, value.RemainingRounds, value.GenerateCount);
			}
			if (round <= this.MountRound)
			{
				return;
			}
			int recycleClearCount = ctx.GetRecycleClearCount(this.TargetType);
			if (recycleClearCount <= 0)
			{
				return;
			}
			IReadOnlyList<GridPosition> readOnlyList = ctx.PickGenerateCells(recycleClearCount, this.<zones>P);
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				ctx.TransformPiece(this.EnvId, readOnlyList[i], this.TargetType, null);
			}
		}

		// Token: 0x0401C5CF RID: 116175
		[CompilerGenerated]
		private IReadOnlyList<CellZone> <zones>P = zones;

		// Token: 0x0401C5D0 RID: 116176
		[Nullable(2)]
		[CompilerGenerated]
		private string <tip>P = tip;
	}
}
