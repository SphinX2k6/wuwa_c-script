using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC3 RID: 27331
	public class IColorPieceT
	{
		// Token: 0x1700C8B6 RID: 51382
		// (get) Token: 0x0602EE9A RID: 192154 RVA: 0x0066404A File Offset: 0x0066224A
		// (set) Token: 0x0602EE9B RID: 192155 RVA: 0x00664052 File Offset: 0x00662252
		public EPieceColorType Color { get; set; }

		// Token: 0x0602EE9C RID: 192156 RVA: 0x0066405B File Offset: 0x0066225B
		public IColorPieceT()
		{
			this.Color = EPieceColorType.White;
		}
	}
}
