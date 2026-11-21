using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAD RID: 23469
	public class INoRenderPortalComponentT
	{
		// Token: 0x1700AB91 RID: 43921
		// (get) Token: 0x06026B19 RID: 158489 RVA: 0x0054C141 File Offset: 0x0054A341
		// (set) Token: 0x06026B1A RID: 158490 RVA: 0x0054C149 File Offset: 0x0054A349
		public bool Disabled { get; set; }

		// Token: 0x1700AB92 RID: 43922
		// (get) Token: 0x06026B1B RID: 158491 RVA: 0x0054C152 File Offset: 0x0054A352
		// (set) Token: 0x06026B1C RID: 158492 RVA: 0x0054C15A File Offset: 0x0054A35A
		public IStaticNoRenderPortalT Config { get; set; }

		// Token: 0x1700AB93 RID: 43923
		// (get) Token: 0x06026B1D RID: 158493 RVA: 0x0054C163 File Offset: 0x0054A363
		// (set) Token: 0x06026B1E RID: 158494 RVA: 0x0054C16B File Offset: 0x0054A36B
		public byte NullMask { get; set; }

		// Token: 0x06026B1F RID: 158495 RVA: 0x0054C174 File Offset: 0x0054A374
		public INoRenderPortalComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
