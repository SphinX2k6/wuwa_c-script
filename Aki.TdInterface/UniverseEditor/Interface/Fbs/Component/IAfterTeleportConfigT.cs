using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005380 RID: 21376
	public class IAfterTeleportConfigT
	{
		// Token: 0x170096F9 RID: 38649
		// (get) Token: 0x060214EB RID: 136427 RVA: 0x004987F2 File Offset: 0x004969F2
		// (set) Token: 0x060214EC RID: 136428 RVA: 0x004987FA File Offset: 0x004969FA
		public IVectorInfoT Direction { get; set; }

		// Token: 0x170096FA RID: 38650
		// (get) Token: 0x060214ED RID: 136429 RVA: 0x00498803 File Offset: 0x00496A03
		// (set) Token: 0x060214EE RID: 136430 RVA: 0x0049880B File Offset: 0x00496A0B
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x170096FB RID: 38651
		// (get) Token: 0x060214EF RID: 136431 RVA: 0x00498814 File Offset: 0x00496A14
		// (set) Token: 0x060214F0 RID: 136432 RVA: 0x0049881C File Offset: 0x00496A1C
		public IVectorInfoT TeleportToSelfPos { get; set; }

		// Token: 0x170096FC RID: 38652
		// (get) Token: 0x060214F1 RID: 136433 RVA: 0x00498825 File Offset: 0x00496A25
		// (set) Token: 0x060214F2 RID: 136434 RVA: 0x0049882D File Offset: 0x00496A2D
		public int RailEntityId { get; set; }

		// Token: 0x170096FD RID: 38653
		// (get) Token: 0x060214F3 RID: 136435 RVA: 0x00498836 File Offset: 0x00496A36
		// (set) Token: 0x060214F4 RID: 136436 RVA: 0x0049883E File Offset: 0x00496A3E
		public string SlidePerformDaPath { get; set; }

		// Token: 0x170096FE RID: 38654
		// (get) Token: 0x060214F5 RID: 136437 RVA: 0x00498847 File Offset: 0x00496A47
		// (set) Token: 0x060214F6 RID: 136438 RVA: 0x0049884F File Offset: 0x00496A4F
		public byte NullMask { get; set; }

		// Token: 0x060214F7 RID: 136439 RVA: 0x00498858 File Offset: 0x00496A58
		public IAfterTeleportConfigT()
		{
			this.Direction = null;
			this.BuffEffectIds = null;
			this.TeleportToSelfPos = null;
			this.RailEntityId = 0;
			this.SlidePerformDaPath = null;
			this.NullMask = 0;
		}
	}
}
