using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B42 RID: 23362
	public class IVisionDisplayComponentT
	{
		// Token: 0x1700B057 RID: 45143
		// (get) Token: 0x06027EFC RID: 163580 RVA: 0x0057DBAD File Offset: 0x0057BDAD
		// (set) Token: 0x06027EFD RID: 163581 RVA: 0x0057DBB5 File Offset: 0x0057BDB5
		public bool Disabled { get; set; }

		// Token: 0x1700B058 RID: 45144
		// (get) Token: 0x06027EFE RID: 163582 RVA: 0x0057DBBE File Offset: 0x0057BDBE
		// (set) Token: 0x06027EFF RID: 163583 RVA: 0x0057DBC6 File Offset: 0x0057BDC6
		public bool IsNeedInView { get; set; }

		// Token: 0x1700B059 RID: 45145
		// (get) Token: 0x06027F00 RID: 163584 RVA: 0x0057DBCF File Offset: 0x0057BDCF
		// (set) Token: 0x06027F01 RID: 163585 RVA: 0x0057DBD7 File Offset: 0x0057BDD7
		public bool IsBanOcclusion { get; set; }

		// Token: 0x1700B05A RID: 45146
		// (get) Token: 0x06027F02 RID: 163586 RVA: 0x0057DBE0 File Offset: 0x0057BDE0
		// (set) Token: 0x06027F03 RID: 163587 RVA: 0x0057DBE8 File Offset: 0x0057BDE8
		public int ViewEntityId { get; set; }

		// Token: 0x1700B05B RID: 45147
		// (get) Token: 0x06027F04 RID: 163588 RVA: 0x0057DBF1 File Offset: 0x0057BDF1
		// (set) Token: 0x06027F05 RID: 163589 RVA: 0x0057DBF9 File Offset: 0x0057BDF9
		public bool IsBornInTargetPoint { get; set; }

		// Token: 0x1700B05C RID: 45148
		// (get) Token: 0x06027F06 RID: 163590 RVA: 0x0057DC02 File Offset: 0x0057BE02
		// (set) Token: 0x06027F07 RID: 163591 RVA: 0x0057DC0A File Offset: 0x0057BE0A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B05D RID: 45149
		// (get) Token: 0x06027F08 RID: 163592 RVA: 0x0057DC13 File Offset: 0x0057BE13
		// (set) Token: 0x06027F09 RID: 163593 RVA: 0x0057DC1B File Offset: 0x0057BE1B
		public byte NullMask { get; set; }

		// Token: 0x06027F0A RID: 163594 RVA: 0x0057DC24 File Offset: 0x0057BE24
		public IVisionDisplayComponentT()
		{
			this.Disabled = false;
			this.IsNeedInView = false;
			this.IsBanOcclusion = false;
			this.ViewEntityId = 0;
			this.IsBornInTargetPoint = false;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
