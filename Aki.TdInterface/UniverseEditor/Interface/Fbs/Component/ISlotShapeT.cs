using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F49 RID: 24393
	public class ISlotShapeT
	{
		// Token: 0x1700B4AF RID: 46255
		// (get) Token: 0x06028FF0 RID: 167920 RVA: 0x00599CBE File Offset: 0x00597EBE
		// (set) Token: 0x06028FF1 RID: 167921 RVA: 0x00599CC6 File Offset: 0x00597EC6
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700B4B0 RID: 46256
		// (get) Token: 0x06028FF2 RID: 167922 RVA: 0x00599CCF File Offset: 0x00597ECF
		// (set) Token: 0x06028FF3 RID: 167923 RVA: 0x00599CD7 File Offset: 0x00597ED7
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700B4B1 RID: 46257
		// (get) Token: 0x06028FF4 RID: 167924 RVA: 0x00599CE0 File Offset: 0x00597EE0
		// (set) Token: 0x06028FF5 RID: 167925 RVA: 0x00599CE8 File Offset: 0x00597EE8
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x06028FF6 RID: 167926 RVA: 0x00599CF1 File Offset: 0x00597EF1
		public ISlotShapeT()
		{
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
