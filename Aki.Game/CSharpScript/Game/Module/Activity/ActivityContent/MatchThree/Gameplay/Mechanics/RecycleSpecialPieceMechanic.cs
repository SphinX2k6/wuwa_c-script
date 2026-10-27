using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064EE RID: 25838
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class RecycleSpecialPieceMechanic : LevelMechanic
	{
		// Token: 0x06040DA8 RID: 265640 RVA: 0x00FB595F File Offset: 0x00FB3B5F
		public RecycleSpecialPieceMechanic(int envId, int mountRound, EPieceType targetType, IReadOnlyList<CellZone> zones, [Nullable(2)] string tip)
		{
		}

		// Token: 0x170094E6 RID: 38118
		// (get) Token: 0x06040DA9 RID: 265641 RVA: 0x00FB598C File Offset: 0x00FB3B8C
		public int EnvId { get; } = envId;

		// Token: 0x170094E7 RID: 38119
		// (get) Token: 0x06040DAA RID: 265642 RVA: 0x00FB5994 File Offset: 0x00FB3B94
		public int MountRound { get; } = mountRound;

		// Token: 0x170094E8 RID: 38120
		// (get) Token: 0x06040DAB RID: 265643 RVA: 0x00FB599C File Offset: 0x00FB3B9C
		public EPieceType TargetType { get; } = targetType;

		// Token: 0x06040DAC RID: 265644 RVA: 0x00FB59A4 File Offset: 0x00FB3BA4
		public override MechanicTipEvent? CreateMountTip(int round)
		{
			if (round != this.MountRound || string.IsNullOrEmpty(this.<tip>P))
			{
				return null;
			}
			return new MechanicTipEvent?(new MechanicTipEvent(this.<tip>P, 0, 0));
		}

		// Token: 0x06040DAD RID: 265645 RVA: 0x00FB59E4 File Offset: 0x00FB3BE4
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

		// Token: 0x04021C9E RID: 138398
		[CompilerGenerated]
		private IReadOnlyList<CellZone> <zones>P = zones;

		// Token: 0x04021C9F RID: 138399
		[Nullable(2)]
		[CompilerGenerated]
		private string <tip>P = tip;
	}
}
