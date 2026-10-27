using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200508E RID: 20622
	public class IDirectionFillT
	{
		// Token: 0x170095C4 RID: 38340
		// (get) Token: 0x06021193 RID: 135571 RVA: 0x004996DE File Offset: 0x004978DE
		// (set) Token: 0x06021194 RID: 135572 RVA: 0x004996E6 File Offset: 0x004978E6
		public EFillType Type { get; set; }

		// Token: 0x170095C5 RID: 38341
		// (get) Token: 0x06021195 RID: 135573 RVA: 0x004996EF File Offset: 0x004978EF
		// (set) Token: 0x06021196 RID: 135574 RVA: 0x004996F7 File Offset: 0x004978F7
		public bool W { get; set; }

		// Token: 0x170095C6 RID: 38342
		// (get) Token: 0x06021197 RID: 135575 RVA: 0x00499700 File Offset: 0x00497900
		// (set) Token: 0x06021198 RID: 135576 RVA: 0x00499708 File Offset: 0x00497908
		public bool S { get; set; }

		// Token: 0x170095C7 RID: 38343
		// (get) Token: 0x06021199 RID: 135577 RVA: 0x00499711 File Offset: 0x00497911
		// (set) Token: 0x0602119A RID: 135578 RVA: 0x00499719 File Offset: 0x00497919
		public bool A { get; set; }

		// Token: 0x170095C8 RID: 38344
		// (get) Token: 0x0602119B RID: 135579 RVA: 0x00499722 File Offset: 0x00497922
		// (set) Token: 0x0602119C RID: 135580 RVA: 0x0049972A File Offset: 0x0049792A
		public bool D { get; set; }

		// Token: 0x0602119D RID: 135581 RVA: 0x00499733 File Offset: 0x00497933
		public IDirectionFillT()
		{
			this.Type = EFillType.Fixed;
			this.W = false;
			this.S = false;
			this.A = false;
			this.D = false;
		}
	}
}
