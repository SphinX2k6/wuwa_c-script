using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2F RID: 20271
	public class IBuffConsumerComponentT
	{
		// Token: 0x1700921A RID: 37402
		// (get) Token: 0x06020156 RID: 131414 RVA: 0x00476C82 File Offset: 0x00474E82
		// (set) Token: 0x06020157 RID: 131415 RVA: 0x00476C8A File Offset: 0x00474E8A
		public bool Disabled { get; set; }

		// Token: 0x1700921B RID: 37403
		// (get) Token: 0x06020158 RID: 131416 RVA: 0x00476C93 File Offset: 0x00474E93
		// (set) Token: 0x06020159 RID: 131417 RVA: 0x00476C9B File Offset: 0x00474E9B
		public long BuffId { get; set; }

		// Token: 0x1700921C RID: 37404
		// (get) Token: 0x0602015A RID: 131418 RVA: 0x00476CA4 File Offset: 0x00474EA4
		// (set) Token: 0x0602015B RID: 131419 RVA: 0x00476CAC File Offset: 0x00474EAC
		public long BulletId { get; set; }

		// Token: 0x1700921D RID: 37405
		// (get) Token: 0x0602015C RID: 131420 RVA: 0x00476CB5 File Offset: 0x00474EB5
		// (set) Token: 0x0602015D RID: 131421 RVA: 0x00476CBD File Offset: 0x00474EBD
		public int ProducerEntityId { get; set; }

		// Token: 0x1700921E RID: 37406
		// (get) Token: 0x0602015E RID: 131422 RVA: 0x00476CC6 File Offset: 0x00474EC6
		// (set) Token: 0x0602015F RID: 131423 RVA: 0x00476CCE File Offset: 0x00474ECE
		public byte NullMask { get; set; }

		// Token: 0x06020160 RID: 131424 RVA: 0x00476CD7 File Offset: 0x00474ED7
		public IBuffConsumerComponentT()
		{
			this.Disabled = false;
			this.BuffId = 0L;
			this.BulletId = 0L;
			this.ProducerEntityId = 0;
			this.NullMask = 0;
		}
	}
}
