using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D1 RID: 26833
	public class IHeadStyleNormalT
	{
		// Token: 0x1700C71A RID: 50970
		// (get) Token: 0x0602ECD6 RID: 191702 RVA: 0x00662FC0 File Offset: 0x006611C0
		// (set) Token: 0x0602ECD7 RID: 191703 RVA: 0x00662FC8 File Offset: 0x006611C8
		public EHeadStyle Type { get; set; }

		// Token: 0x1700C71B RID: 50971
		// (get) Token: 0x0602ECD8 RID: 191704 RVA: 0x00662FD1 File Offset: 0x006611D1
		// (set) Token: 0x0602ECD9 RID: 191705 RVA: 0x00662FD9 File Offset: 0x006611D9
		public int WhoId { get; set; }

		// Token: 0x0602ECDA RID: 191706 RVA: 0x00662FE2 File Offset: 0x006611E2
		public IHeadStyleNormalT()
		{
			this.Type = EHeadStyle.Normal;
			this.WhoId = 0;
		}
	}
}
