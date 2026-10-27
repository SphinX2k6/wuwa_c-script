using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064B4 RID: 25780
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class EliminateRule
	{
		// Token: 0x06040B9F RID: 265119 RVA: 0x00FAB7AC File Offset: 0x00FA99AC
		public EliminateRule(EMatchShape shape, int matchDir, int spawnType, int[] spawnExtraComponents, int pieceEnergy, int pieceScore)
		{
		}

		// Token: 0x04021B3A RID: 138042
		public readonly EMatchShape Shape = shape;

		// Token: 0x04021B3B RID: 138043
		public readonly int MatchDir = matchDir;

		// Token: 0x04021B3C RID: 138044
		public readonly int SpawnType = spawnType;

		// Token: 0x04021B3D RID: 138045
		public readonly int[] SpawnExtraComponents = spawnExtraComponents;

		// Token: 0x04021B3E RID: 138046
		public readonly int PieceEnergy = pieceEnergy;

		// Token: 0x04021B3F RID: 138047
		public readonly int PieceScore = pieceScore;
	}
}
