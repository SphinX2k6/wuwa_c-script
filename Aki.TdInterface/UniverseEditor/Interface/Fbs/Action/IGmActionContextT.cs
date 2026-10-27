using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006898 RID: 26776
	public class IGmActionContextT
	{
		// Token: 0x1700C6C9 RID: 50889
		// (get) Token: 0x0602EB2E RID: 191278 RVA: 0x0065DE4D File Offset: 0x0065C04D
		// (set) Token: 0x0602EB2F RID: 191279 RVA: 0x0065DE55 File Offset: 0x0065C055
		public string Type { get; set; }

		// Token: 0x0602EB30 RID: 191280 RVA: 0x0065DE5E File Offset: 0x0065C05E
		public IGmActionContextT()
		{
			this.Type = null;
		}
	}
}
