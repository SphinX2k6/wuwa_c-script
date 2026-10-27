using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C05 RID: 15365
	public class IConeTriggerShapeT
	{
		// Token: 0x1700698E RID: 27022
		// (get) Token: 0x06015295 RID: 86677 RVA: 0x00310F1B File Offset: 0x0030F11B
		// (set) Token: 0x06015296 RID: 86678 RVA: 0x00310F23 File Offset: 0x0030F123
		public ETriggerShape Type { get; set; }

		// Token: 0x1700698F RID: 27023
		// (get) Token: 0x06015297 RID: 86679 RVA: 0x00310F2C File Offset: 0x0030F12C
		// (set) Token: 0x06015298 RID: 86680 RVA: 0x00310F34 File Offset: 0x0030F134
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006990 RID: 27024
		// (get) Token: 0x06015299 RID: 86681 RVA: 0x00310F3D File Offset: 0x0030F13D
		// (set) Token: 0x0601529A RID: 86682 RVA: 0x00310F45 File Offset: 0x0030F145
		public int Radius { get; set; }

		// Token: 0x17006991 RID: 27025
		// (get) Token: 0x0601529B RID: 86683 RVA: 0x00310F4E File Offset: 0x0030F14E
		// (set) Token: 0x0601529C RID: 86684 RVA: 0x00310F56 File Offset: 0x0030F156
		public int Height { get; set; }

		// Token: 0x0601529D RID: 86685 RVA: 0x00310F5F File Offset: 0x0030F15F
		public IConeTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}
