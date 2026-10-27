using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006534 RID: 25908
	public sealed class LandRemoveComponent : IPieceComponent, ILandBehavior
	{
		// Token: 0x1700952E RID: 38190
		// (get) Token: 0x06040F1D RID: 266013 RVA: 0x00FBCC44 File Offset: 0x00FBAE44
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Land;
			}
		}

		// Token: 0x06040F1E RID: 266014 RVA: 0x00FBCC48 File Offset: 0x00FBAE48
		[NullableContext(1)]
		public void OnLandedBottom(IDispatchContext sink, Piece self, GridPosition pos)
		{
			sink.RemovePiece(pos);
		}
	}
}
