using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A72 RID: 23154
	public class ILevelQteComponentT
	{
		// Token: 0x1700A899 RID: 43161
		// (get) Token: 0x06025EAB RID: 155307 RVA: 0x00532C39 File Offset: 0x00530E39
		// (set) Token: 0x06025EAC RID: 155308 RVA: 0x00532C41 File Offset: 0x00530E41
		public bool Disabled { get; set; }

		// Token: 0x1700A89A RID: 43162
		// (get) Token: 0x06025EAD RID: 155309 RVA: 0x00532C4A File Offset: 0x00530E4A
		// (set) Token: 0x06025EAE RID: 155310 RVA: 0x00532C52 File Offset: 0x00530E52
		public ISingleBtnQteT QteConfig { get; set; }

		// Token: 0x1700A89B RID: 43163
		// (get) Token: 0x06025EAF RID: 155311 RVA: 0x00532C5B File Offset: 0x00530E5B
		// (set) Token: 0x06025EB0 RID: 155312 RVA: 0x00532C63 File Offset: 0x00530E63
		public byte NullMask { get; set; }

		// Token: 0x06025EB1 RID: 155313 RVA: 0x00532C6C File Offset: 0x00530E6C
		public ILevelQteComponentT()
		{
			this.Disabled = false;
			this.QteConfig = null;
			this.NullMask = 0;
		}
	}
}
