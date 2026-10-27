using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D15 RID: 27925
	public class IPlayFlowT
	{
		// Token: 0x1700CFEF RID: 53231
		// (get) Token: 0x060313E8 RID: 201704 RVA: 0x006ADDE2 File Offset: 0x006ABFE2
		// (set) Token: 0x060313E9 RID: 201705 RVA: 0x006ADDEA File Offset: 0x006ABFEA
		public string FlowListName { get; set; }

		// Token: 0x1700CFF0 RID: 53232
		// (get) Token: 0x060313EA RID: 201706 RVA: 0x006ADDF3 File Offset: 0x006ABFF3
		// (set) Token: 0x060313EB RID: 201707 RVA: 0x006ADDFB File Offset: 0x006ABFFB
		public int FlowId { get; set; }

		// Token: 0x1700CFF1 RID: 53233
		// (get) Token: 0x060313EC RID: 201708 RVA: 0x006ADE04 File Offset: 0x006AC004
		// (set) Token: 0x060313ED RID: 201709 RVA: 0x006ADE0C File Offset: 0x006AC00C
		public int StateId { get; set; }

		// Token: 0x1700CFF2 RID: 53234
		// (get) Token: 0x060313EE RID: 201710 RVA: 0x006ADE15 File Offset: 0x006AC015
		// (set) Token: 0x060313EF RID: 201711 RVA: 0x006ADE1D File Offset: 0x006AC01D
		public string FlowGuid { get; set; }

		// Token: 0x060313F0 RID: 201712 RVA: 0x006ADE26 File Offset: 0x006AC026
		public IPlayFlowT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
			this.FlowGuid = null;
		}
	}
}
