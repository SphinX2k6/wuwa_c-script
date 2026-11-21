using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410A RID: 16650
	public class IAddInteractOptionT
	{
		// Token: 0x170070AF RID: 28847
		// (get) Token: 0x06016D17 RID: 93463 RVA: 0x00341FDB File Offset: 0x003401DB
		// (set) Token: 0x06016D18 RID: 93464 RVA: 0x00341FE3 File Offset: 0x003401E3
		public IInteractOptionT Option { get; set; }

		// Token: 0x170070B0 RID: 28848
		// (get) Token: 0x06016D19 RID: 93465 RVA: 0x00341FEC File Offset: 0x003401EC
		// (set) Token: 0x06016D1A RID: 93466 RVA: 0x00341FF4 File Offset: 0x003401F4
		public int EntityId { get; set; }

		// Token: 0x170070B1 RID: 28849
		// (get) Token: 0x06016D1B RID: 93467 RVA: 0x00341FFD File Offset: 0x003401FD
		// (set) Token: 0x06016D1C RID: 93468 RVA: 0x00342005 File Offset: 0x00340205
		public bool IsManualFinish { get; set; }

		// Token: 0x170070B2 RID: 28850
		// (get) Token: 0x06016D1D RID: 93469 RVA: 0x0034200E File Offset: 0x0034020E
		// (set) Token: 0x06016D1E RID: 93470 RVA: 0x00342016 File Offset: 0x00340216
		public bool IsManualDelete { get; set; }

		// Token: 0x170070B3 RID: 28851
		// (get) Token: 0x06016D1F RID: 93471 RVA: 0x0034201F File Offset: 0x0034021F
		// (set) Token: 0x06016D20 RID: 93472 RVA: 0x00342027 File Offset: 0x00340227
		public string InteractToken { get; set; }

		// Token: 0x170070B4 RID: 28852
		// (get) Token: 0x06016D21 RID: 93473 RVA: 0x00342030 File Offset: 0x00340230
		// (set) Token: 0x06016D22 RID: 93474 RVA: 0x00342038 File Offset: 0x00340238
		public byte NullMask { get; set; }

		// Token: 0x06016D23 RID: 93475 RVA: 0x00342041 File Offset: 0x00340241
		public IAddInteractOptionT()
		{
			this.Option = null;
			this.EntityId = 0;
			this.IsManualFinish = false;
			this.IsManualDelete = false;
			this.InteractToken = null;
			this.NullMask = 0;
		}
	}
}
