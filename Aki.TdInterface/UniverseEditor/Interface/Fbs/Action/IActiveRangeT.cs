using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006099 RID: 24729
	public class IActiveRangeT
	{
		// Token: 0x1700B636 RID: 46646
		// (get) Token: 0x0602A356 RID: 172886 RVA: 0x005D1D11 File Offset: 0x005CFF11
		// (set) Token: 0x0602A357 RID: 172887 RVA: 0x005D1D19 File Offset: 0x005CFF19
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x1700B637 RID: 46647
		// (get) Token: 0x0602A358 RID: 172888 RVA: 0x005D1D22 File Offset: 0x005CFF22
		// (set) Token: 0x0602A359 RID: 172889 RVA: 0x005D1D2A File Offset: 0x005CFF2A
		public int CheckEnterRange { get; set; }

		// Token: 0x1700B638 RID: 46648
		// (get) Token: 0x0602A35A RID: 172890 RVA: 0x005D1D33 File Offset: 0x005CFF33
		// (set) Token: 0x0602A35B RID: 172891 RVA: 0x005D1D3B File Offset: 0x005CFF3B
		public int CheckLeaveRange { get; set; }

		// Token: 0x1700B639 RID: 46649
		// (get) Token: 0x0602A35C RID: 172892 RVA: 0x005D1D44 File Offset: 0x005CFF44
		// (set) Token: 0x0602A35D RID: 172893 RVA: 0x005D1D4C File Offset: 0x005CFF4C
		public bool AllowRangeExceed { get; set; }

		// Token: 0x1700B63A RID: 46650
		// (get) Token: 0x0602A35E RID: 172894 RVA: 0x005D1D55 File Offset: 0x005CFF55
		// (set) Token: 0x0602A35F RID: 172895 RVA: 0x005D1D5D File Offset: 0x005CFF5D
		public byte NullMask { get; set; }

		// Token: 0x0602A360 RID: 172896 RVA: 0x005D1D66 File Offset: 0x005CFF66
		public IActiveRangeT()
		{
			this.CheckPoint = null;
			this.CheckEnterRange = 0;
			this.CheckLeaveRange = 0;
			this.AllowRangeExceed = false;
			this.NullMask = 0;
		}
	}
}
