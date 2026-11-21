using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E04 RID: 24068
	public class IRangeComponentT
	{
		// Token: 0x1700B16D RID: 45421
		// (get) Token: 0x06028307 RID: 164615 RVA: 0x0057F3F4 File Offset: 0x0057D5F4
		// (set) Token: 0x06028308 RID: 164616 RVA: 0x0057F3FC File Offset: 0x0057D5FC
		public bool Disabled { get; set; }

		// Token: 0x1700B16E RID: 45422
		// (get) Token: 0x06028309 RID: 164617 RVA: 0x0057F405 File Offset: 0x0057D605
		// (set) Token: 0x0602830A RID: 164618 RVA: 0x0057F40D File Offset: 0x0057D60D
		public List<ISetRangeActorCollisionResponseToChannelsT> SetRangeActorCollisionResponseToChannels { get; set; }

		// Token: 0x1700B16F RID: 45423
		// (get) Token: 0x0602830B RID: 164619 RVA: 0x0057F416 File Offset: 0x0057D616
		// (set) Token: 0x0602830C RID: 164620 RVA: 0x0057F41E File Offset: 0x0057D61E
		public TTriggerShapeUnion Shape { get; set; }

		// Token: 0x1700B170 RID: 45424
		// (get) Token: 0x0602830D RID: 164621 RVA: 0x0057F427 File Offset: 0x0057D627
		// (set) Token: 0x0602830E RID: 164622 RVA: 0x0057F42F File Offset: 0x0057D62F
		public int ExtraRange { get; set; }

		// Token: 0x1700B171 RID: 45425
		// (get) Token: 0x0602830F RID: 164623 RVA: 0x0057F438 File Offset: 0x0057D638
		// (set) Token: 0x06028310 RID: 164624 RVA: 0x0057F440 File Offset: 0x0057D640
		public byte NullMask { get; set; }

		// Token: 0x06028311 RID: 164625 RVA: 0x0057F449 File Offset: 0x0057D649
		public IRangeComponentT()
		{
			this.Disabled = false;
			this.SetRangeActorCollisionResponseToChannels = null;
			this.Shape = null;
			this.ExtraRange = 0;
			this.NullMask = 0;
		}
	}
}
