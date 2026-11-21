using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FB RID: 26363
	public class IActiveRangeT
	{
		// Token: 0x1700BFA1 RID: 49057
		// (get) Token: 0x0602CA37 RID: 182839 RVA: 0x0061BCB9 File Offset: 0x00619EB9
		// (set) Token: 0x0602CA38 RID: 182840 RVA: 0x0061BCC1 File Offset: 0x00619EC1
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x1700BFA2 RID: 49058
		// (get) Token: 0x0602CA39 RID: 182841 RVA: 0x0061BCCA File Offset: 0x00619ECA
		// (set) Token: 0x0602CA3A RID: 182842 RVA: 0x0061BCD2 File Offset: 0x00619ED2
		public int CheckEnterRange { get; set; }

		// Token: 0x1700BFA3 RID: 49059
		// (get) Token: 0x0602CA3B RID: 182843 RVA: 0x0061BCDB File Offset: 0x00619EDB
		// (set) Token: 0x0602CA3C RID: 182844 RVA: 0x0061BCE3 File Offset: 0x00619EE3
		public int CheckLeaveRange { get; set; }

		// Token: 0x1700BFA4 RID: 49060
		// (get) Token: 0x0602CA3D RID: 182845 RVA: 0x0061BCEC File Offset: 0x00619EEC
		// (set) Token: 0x0602CA3E RID: 182846 RVA: 0x0061BCF4 File Offset: 0x00619EF4
		public bool AllowRangeExceed { get; set; }

		// Token: 0x1700BFA5 RID: 49061
		// (get) Token: 0x0602CA3F RID: 182847 RVA: 0x0061BCFD File Offset: 0x00619EFD
		// (set) Token: 0x0602CA40 RID: 182848 RVA: 0x0061BD05 File Offset: 0x00619F05
		public byte NullMask { get; set; }

		// Token: 0x0602CA41 RID: 182849 RVA: 0x0061BD0E File Offset: 0x00619F0E
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
