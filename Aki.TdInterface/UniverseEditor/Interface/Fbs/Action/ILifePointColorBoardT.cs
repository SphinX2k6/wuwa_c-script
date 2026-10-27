using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FA RID: 27130
	public class ILifePointColorBoardT
	{
		// Token: 0x1700C94F RID: 51535
		// (get) Token: 0x0602F799 RID: 194457 RVA: 0x006774D5 File Offset: 0x006756D5
		// (set) Token: 0x0602F79A RID: 194458 RVA: 0x006774DD File Offset: 0x006756DD
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x1700C950 RID: 51536
		// (get) Token: 0x0602F79B RID: 194459 RVA: 0x006774E6 File Offset: 0x006756E6
		// (set) Token: 0x0602F79C RID: 194460 RVA: 0x006774EE File Offset: 0x006756EE
		public List<EPieceColorType> Colors { get; set; }

		// Token: 0x1700C951 RID: 51537
		// (get) Token: 0x0602F79D RID: 194461 RVA: 0x006774F7 File Offset: 0x006756F7
		// (set) Token: 0x0602F79E RID: 194462 RVA: 0x006774FF File Offset: 0x006756FF
		public EPieceColorType TargetColor { get; set; }

		// Token: 0x0602F79F RID: 194463 RVA: 0x00677508 File Offset: 0x00675708
		public ILifePointColorBoardT()
		{
			this.Config = null;
			this.Colors = null;
			this.TargetColor = EPieceColorType.White;
		}
	}
}
