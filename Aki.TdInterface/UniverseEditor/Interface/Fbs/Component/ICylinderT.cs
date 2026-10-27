using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506D RID: 20589
	public class ICylinderT
	{
		// Token: 0x1700955C RID: 38236
		// (get) Token: 0x06020FFD RID: 135165 RVA: 0x00495CAF File Offset: 0x00493EAF
		// (set) Token: 0x06020FFE RID: 135166 RVA: 0x00495CB7 File Offset: 0x00493EB7
		public bool IsUse { get; set; }

		// Token: 0x1700955D RID: 38237
		// (get) Token: 0x06020FFF RID: 135167 RVA: 0x00495CC0 File Offset: 0x00493EC0
		// (set) Token: 0x06021000 RID: 135168 RVA: 0x00495CC8 File Offset: 0x00493EC8
		public int Radius { get; set; }

		// Token: 0x1700955E RID: 38238
		// (get) Token: 0x06021001 RID: 135169 RVA: 0x00495CD1 File Offset: 0x00493ED1
		// (set) Token: 0x06021002 RID: 135170 RVA: 0x00495CD9 File Offset: 0x00493ED9
		public int Height { get; set; }

		// Token: 0x1700955F RID: 38239
		// (get) Token: 0x06021003 RID: 135171 RVA: 0x00495CE2 File Offset: 0x00493EE2
		// (set) Token: 0x06021004 RID: 135172 RVA: 0x00495CEA File Offset: 0x00493EEA
		public IPosAT CylinderPos { get; set; }

		// Token: 0x06021005 RID: 135173 RVA: 0x00495CF3 File Offset: 0x00493EF3
		public ICylinderT()
		{
			this.IsUse = false;
			this.Radius = 0;
			this.Height = 0;
			this.CylinderPos = null;
		}
	}
}
