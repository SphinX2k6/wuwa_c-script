using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200652D RID: 25901
	public sealed class BombComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x06040F0D RID: 265997 RVA: 0x00FBCAA1 File Offset: 0x00FBACA1
		public BombComponent(int rows, int cols)
		{
		}

		// Token: 0x06040F0E RID: 265998 RVA: 0x00FBCAB8 File Offset: 0x00FBACB8
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			int num = this.<rows>P / 2;
			int num2 = this.<cols>P / 2;
			sink.MarkDetonationPresentation(pos);
			for (int i = -num; i <= num; i++)
			{
				for (int j = -num2; j <= num2; j++)
				{
					if (i != 0 || j != 0)
					{
						sink.RequestClear(new GridPosition(pos.Row + i, pos.Col + j), 0, EPieceClearReason.SplashedByBomb, new GridPosition?(pos));
					}
				}
			}
		}

		// Token: 0x04021DFA RID: 138746
		[CompilerGenerated]
		private int <rows>P = rows;

		// Token: 0x04021DFB RID: 138747
		[CompilerGenerated]
		private int <cols>P = cols;
	}
}
