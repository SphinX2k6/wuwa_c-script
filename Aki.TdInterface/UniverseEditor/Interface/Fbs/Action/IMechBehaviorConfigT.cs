using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7D RID: 27261
	public class IMechBehaviorConfigT
	{
		// Token: 0x1700CA5B RID: 51803
		// (get) Token: 0x0602FC3B RID: 195643 RVA: 0x0067FED7 File Offset: 0x0067E0D7
		// (set) Token: 0x0602FC3C RID: 195644 RVA: 0x0067FEDF File Offset: 0x0067E0DF
		public TMechStuntConfigUnion StuntConfig { get; set; }

		// Token: 0x1700CA5C RID: 51804
		// (get) Token: 0x0602FC3D RID: 195645 RVA: 0x0067FEE8 File Offset: 0x0067E0E8
		// (set) Token: 0x0602FC3E RID: 195646 RVA: 0x0067FEF0 File Offset: 0x0067E0F0
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700CA5D RID: 51805
		// (get) Token: 0x0602FC3F RID: 195647 RVA: 0x0067FEF9 File Offset: 0x0067E0F9
		// (set) Token: 0x0602FC40 RID: 195648 RVA: 0x0067FF01 File Offset: 0x0067E101
		public bool CanInterrupt { get; set; }

		// Token: 0x1700CA5E RID: 51806
		// (get) Token: 0x0602FC41 RID: 195649 RVA: 0x0067FF0A File Offset: 0x0067E10A
		// (set) Token: 0x0602FC42 RID: 195650 RVA: 0x0067FF12 File Offset: 0x0067E112
		public byte NullMask { get; set; }

		// Token: 0x0602FC43 RID: 195651 RVA: 0x0067FF1B File Offset: 0x0067E11B
		public IMechBehaviorConfigT()
		{
			this.StuntConfig = null;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
