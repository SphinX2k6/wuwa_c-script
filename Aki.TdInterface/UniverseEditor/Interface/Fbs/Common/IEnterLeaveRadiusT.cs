using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E1 RID: 25569
	public class IEnterLeaveRadiusT
	{
		// Token: 0x1700BCF1 RID: 48369
		// (get) Token: 0x0602B708 RID: 177928 RVA: 0x005EB390 File Offset: 0x005E9590
		// (set) Token: 0x0602B709 RID: 177929 RVA: 0x005EB398 File Offset: 0x005E9598
		public int EnterRadius { get; set; }

		// Token: 0x1700BCF2 RID: 48370
		// (get) Token: 0x0602B70A RID: 177930 RVA: 0x005EB3A1 File Offset: 0x005E95A1
		// (set) Token: 0x0602B70B RID: 177931 RVA: 0x005EB3A9 File Offset: 0x005E95A9
		public int LeaveRadius { get; set; }

		// Token: 0x0602B70C RID: 177932 RVA: 0x005EB3B2 File Offset: 0x005E95B2
		public IEnterLeaveRadiusT()
		{
			this.EnterRadius = 0;
			this.LeaveRadius = 0;
		}
	}
}
