using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AA RID: 28842
	public class ILifePointColorBoardT
	{
		// Token: 0x1700D34F RID: 54095
		// (get) Token: 0x06032159 RID: 205145 RVA: 0x006C782D File Offset: 0x006C5A2D
		// (set) Token: 0x0603215A RID: 205146 RVA: 0x006C7835 File Offset: 0x006C5A35
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x1700D350 RID: 54096
		// (get) Token: 0x0603215B RID: 205147 RVA: 0x006C783E File Offset: 0x006C5A3E
		// (set) Token: 0x0603215C RID: 205148 RVA: 0x006C7846 File Offset: 0x006C5A46
		public List<EPieceColorType> Colors { get; set; }

		// Token: 0x1700D351 RID: 54097
		// (get) Token: 0x0603215D RID: 205149 RVA: 0x006C784F File Offset: 0x006C5A4F
		// (set) Token: 0x0603215E RID: 205150 RVA: 0x006C7857 File Offset: 0x006C5A57
		public EPieceColorType TargetColor { get; set; }

		// Token: 0x0603215F RID: 205151 RVA: 0x006C7860 File Offset: 0x006C5A60
		public ILifePointColorBoardT()
		{
			this.Config = null;
			this.Colors = null;
			this.TargetColor = EPieceColorType.White;
		}
	}
}
