using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A98 RID: 27288
	public class IMechStuntHighSpeedT
	{
		// Token: 0x1700CA8E RID: 51854
		// (get) Token: 0x0602FD26 RID: 195878 RVA: 0x00681ADE File Offset: 0x0067FCDE
		// (set) Token: 0x0602FD27 RID: 195879 RVA: 0x00681AE6 File Offset: 0x0067FCE6
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FD28 RID: 195880 RVA: 0x00681AEF File Offset: 0x0067FCEF
		public IMechStuntHighSpeedT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
