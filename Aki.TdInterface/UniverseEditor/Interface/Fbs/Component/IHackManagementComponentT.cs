using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E6 RID: 22758
	public class IHackManagementComponentT
	{
		// Token: 0x1700A50C RID: 42252
		// (get) Token: 0x06024F6E RID: 151406 RVA: 0x00513108 File Offset: 0x00511308
		// (set) Token: 0x06024F6F RID: 151407 RVA: 0x00513110 File Offset: 0x00511310
		public bool Disabled { get; set; }

		// Token: 0x1700A50D RID: 42253
		// (get) Token: 0x06024F70 RID: 151408 RVA: 0x00513119 File Offset: 0x00511319
		// (set) Token: 0x06024F71 RID: 151409 RVA: 0x00513121 File Offset: 0x00511321
		public int MaxHackingCount { get; set; }

		// Token: 0x1700A50E RID: 42254
		// (get) Token: 0x06024F72 RID: 151410 RVA: 0x0051312A File Offset: 0x0051132A
		// (set) Token: 0x06024F73 RID: 151411 RVA: 0x00513132 File Offset: 0x00511332
		public float ValidDistance { get; set; }

		// Token: 0x1700A50F RID: 42255
		// (get) Token: 0x06024F74 RID: 151412 RVA: 0x0051313B File Offset: 0x0051133B
		// (set) Token: 0x06024F75 RID: 151413 RVA: 0x00513143 File Offset: 0x00511343
		public byte NullMask { get; set; }

		// Token: 0x06024F76 RID: 151414 RVA: 0x0051314C File Offset: 0x0051134C
		public IHackManagementComponentT()
		{
			this.Disabled = false;
			this.MaxHackingCount = 0;
			this.ValidDistance = 0f;
			this.NullMask = 0;
		}
	}
}
