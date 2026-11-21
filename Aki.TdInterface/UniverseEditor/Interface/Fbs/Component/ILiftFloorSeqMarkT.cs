using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A87 RID: 23175
	public class ILiftFloorSeqMarkT
	{
		// Token: 0x1700A8E5 RID: 43237
		// (get) Token: 0x06025FBB RID: 155579 RVA: 0x00534F8B File Offset: 0x0053318B
		// (set) Token: 0x06025FBC RID: 155580 RVA: 0x00534F93 File Offset: 0x00533193
		public int Floor { get; set; }

		// Token: 0x1700A8E6 RID: 43238
		// (get) Token: 0x06025FBD RID: 155581 RVA: 0x00534F9C File Offset: 0x0053319C
		// (set) Token: 0x06025FBE RID: 155582 RVA: 0x00534FA4 File Offset: 0x005331A4
		public string Mark { get; set; }

		// Token: 0x06025FBF RID: 155583 RVA: 0x00534FAD File Offset: 0x005331AD
		public ILiftFloorSeqMarkT()
		{
			this.Floor = 0;
			this.Mark = null;
		}
	}
}
