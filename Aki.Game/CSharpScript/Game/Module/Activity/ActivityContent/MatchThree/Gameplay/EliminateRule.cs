using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005432 RID: 21554
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class EliminateRule
	{
		// Token: 0x06035863 RID: 219235 RVA: 0x00EF27F4 File Offset: 0x00EF09F4
		public EliminateRule(EMatchShape shape, int matchDir, int spawnType, int[] spawnExtraComponents, int pieceEnergy, int pieceScore)
		{
		}

		// Token: 0x0401C46B RID: 115819
		public readonly EMatchShape Shape = shape;

		// Token: 0x0401C46C RID: 115820
		public readonly int MatchDir = matchDir;

		// Token: 0x0401C46D RID: 115821
		public readonly int SpawnType = spawnType;

		// Token: 0x0401C46E RID: 115822
		public readonly int[] SpawnExtraComponents = spawnExtraComponents;

		// Token: 0x0401C46F RID: 115823
		public readonly int PieceEnergy = pieceEnergy;

		// Token: 0x0401C470 RID: 115824
		public readonly int PieceScore = pieceScore;
	}
}
