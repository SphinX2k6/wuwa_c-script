using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FE9 RID: 24553
	public class TetrisCellData
	{
		// Token: 0x0603E36C RID: 254828 RVA: 0x00F05793 File Offset: 0x00F03993
		public void Reset()
		{
			this.Type = ECellType.Empty;
			this.SealState = ESealState.None;
			this.GemType = EGemType.None;
			this.ColorId = 0;
		}

		// Token: 0x17009047 RID: 36935
		// (get) Token: 0x0603E36D RID: 254829 RVA: 0x00F057B1 File Offset: 0x00F039B1
		public bool IsOccupied
		{
			get
			{
				return this.Type > ECellType.Empty;
			}
		}

		// Token: 0x17009048 RID: 36936
		// (get) Token: 0x0603E36E RID: 254830 RVA: 0x00F057BC File Offset: 0x00F039BC
		public bool CanBeCleared
		{
			get
			{
				return this.Type != ECellType.Fixed;
			}
		}

		// Token: 0x0603E36F RID: 254831 RVA: 0x00F057CA File Offset: 0x00F039CA
		[NullableContext(1)]
		public TetrisCellData Clone()
		{
			return new TetrisCellData
			{
				Type = this.Type,
				SealState = this.SealState,
				GemType = this.GemType,
				ColorId = this.ColorId
			};
		}

		// Token: 0x040207F9 RID: 133113
		public ECellType Type;

		// Token: 0x040207FA RID: 133114
		public ESealState SealState;

		// Token: 0x040207FB RID: 133115
		public EGemType GemType;

		// Token: 0x040207FC RID: 133116
		public int ColorId;
	}
}
