using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E9 RID: 26345
	public class IActionParams_UnionT
	{
		// Token: 0x1700BF91 RID: 49041
		// (get) Token: 0x0602C648 RID: 181832 RVA: 0x00613681 File Offset: 0x00611881
		// (set) Token: 0x0602C649 RID: 181833 RVA: 0x00613689 File Offset: 0x00611889
		public byte UnionIndex { get; set; }

		// Token: 0x1700BF92 RID: 49042
		// (get) Token: 0x0602C64A RID: 181834 RVA: 0x00613692 File Offset: 0x00611892
		// (set) Token: 0x0602C64B RID: 181835 RVA: 0x0061369A File Offset: 0x0061189A
		public IActionParams_Union_0Union Data0 { get; set; }

		// Token: 0x1700BF93 RID: 49043
		// (get) Token: 0x0602C64C RID: 181836 RVA: 0x006136A3 File Offset: 0x006118A3
		// (set) Token: 0x0602C64D RID: 181837 RVA: 0x006136AB File Offset: 0x006118AB
		public IActionParams_Union_1Union Data1 { get; set; }

		// Token: 0x0602C64E RID: 181838 RVA: 0x006136B4 File Offset: 0x006118B4
		public IActionParams_UnionT()
		{
			this.UnionIndex = 0;
			this.Data0 = null;
			this.Data1 = null;
		}
	}
}
