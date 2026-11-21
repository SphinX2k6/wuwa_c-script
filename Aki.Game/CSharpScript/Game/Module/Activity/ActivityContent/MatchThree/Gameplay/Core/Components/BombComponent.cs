using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054AB RID: 21675
	public sealed class BombComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x06035BD2 RID: 220114 RVA: 0x00F03AE5 File Offset: 0x00F01CE5
		public BombComponent(int rows, int cols)
		{
		}

		// Token: 0x06035BD3 RID: 220115 RVA: 0x00F03AFC File Offset: 0x00F01CFC
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

		// Token: 0x0401C72B RID: 116523
		[CompilerGenerated]
		private int <rows>P = rows;

		// Token: 0x0401C72C RID: 116524
		[CompilerGenerated]
		private int <cols>P = cols;
	}
}
