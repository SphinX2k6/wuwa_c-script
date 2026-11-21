using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704D RID: 28749
	public class IInteractPointT
	{
		// Token: 0x1700D299 RID: 53913
		// (get) Token: 0x06031DA9 RID: 204201 RVA: 0x006BFE49 File Offset: 0x006BE049
		// (set) Token: 0x06031DAA RID: 204202 RVA: 0x006BFE51 File Offset: 0x006BE051
		public int Tag { get; set; }

		// Token: 0x1700D29A RID: 53914
		// (get) Token: 0x06031DAB RID: 204203 RVA: 0x006BFE5A File Offset: 0x006BE05A
		// (set) Token: 0x06031DAC RID: 204204 RVA: 0x006BFE62 File Offset: 0x006BE062
		public List<TInteractEffectUnion> InteractEffects { get; set; }

		// Token: 0x1700D29B RID: 53915
		// (get) Token: 0x06031DAD RID: 204205 RVA: 0x006BFE6B File Offset: 0x006BE06B
		// (set) Token: 0x06031DAE RID: 204206 RVA: 0x006BFE73 File Offset: 0x006BE073
		public bool IsValidPoint { get; set; }

		// Token: 0x1700D29C RID: 53916
		// (get) Token: 0x06031DAF RID: 204207 RVA: 0x006BFE7C File Offset: 0x006BE07C
		// (set) Token: 0x06031DB0 RID: 204208 RVA: 0x006BFE84 File Offset: 0x006BE084
		public float ProtectTime { get; set; }

		// Token: 0x1700D29D RID: 53917
		// (get) Token: 0x06031DB1 RID: 204209 RVA: 0x006BFE8D File Offset: 0x006BE08D
		// (set) Token: 0x06031DB2 RID: 204210 RVA: 0x006BFE95 File Offset: 0x006BE095
		public bool CancelRaycast { get; set; }

		// Token: 0x1700D29E RID: 53918
		// (get) Token: 0x06031DB3 RID: 204211 RVA: 0x006BFE9E File Offset: 0x006BE09E
		// (set) Token: 0x06031DB4 RID: 204212 RVA: 0x006BFEA6 File Offset: 0x006BE0A6
		public IDragInteractPointInteractionT InteractionConfig { get; set; }

		// Token: 0x1700D29F RID: 53919
		// (get) Token: 0x06031DB5 RID: 204213 RVA: 0x006BFEAF File Offset: 0x006BE0AF
		// (set) Token: 0x06031DB6 RID: 204214 RVA: 0x006BFEB7 File Offset: 0x006BE0B7
		public byte NullMask { get; set; }

		// Token: 0x06031DB7 RID: 204215 RVA: 0x006BFEC0 File Offset: 0x006BE0C0
		public IInteractPointT()
		{
			this.Tag = 0;
			this.InteractEffects = null;
			this.IsValidPoint = false;
			this.ProtectTime = 0f;
			this.CancelRaycast = false;
			this.InteractionConfig = null;
			this.NullMask = 0;
		}
	}
}
