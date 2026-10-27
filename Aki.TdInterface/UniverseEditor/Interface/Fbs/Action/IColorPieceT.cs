using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200645B RID: 25691
	public class IColorPieceT
	{
		// Token: 0x1700BF34 RID: 48948
		// (get) Token: 0x0602C755 RID: 182101 RVA: 0x00618F7E File Offset: 0x0061717E
		// (set) Token: 0x0602C756 RID: 182102 RVA: 0x00618F86 File Offset: 0x00617186
		public EPieceColorType Color { get; set; }

		// Token: 0x0602C757 RID: 182103 RVA: 0x00618F8F File Offset: 0x0061718F
		public IColorPieceT()
		{
			this.Color = EPieceColorType.White;
		}
	}
}
