using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570A RID: 22282
	public class IEntityPackageComponentT
	{
		// Token: 0x1700A0A6 RID: 41126
		// (get) Token: 0x06023C85 RID: 146565 RVA: 0x004EB333 File Offset: 0x004E9533
		// (set) Token: 0x06023C86 RID: 146566 RVA: 0x004EB33B File Offset: 0x004E953B
		public bool Disabled { get; set; }

		// Token: 0x1700A0A7 RID: 41127
		// (get) Token: 0x06023C87 RID: 146567 RVA: 0x004EB344 File Offset: 0x004E9544
		// (set) Token: 0x06023C88 RID: 146568 RVA: 0x004EB34C File Offset: 0x004E954C
		public bool BindTemplate { get; set; }

		// Token: 0x1700A0A8 RID: 41128
		// (get) Token: 0x06023C89 RID: 146569 RVA: 0x004EB355 File Offset: 0x004E9555
		// (set) Token: 0x06023C8A RID: 146570 RVA: 0x004EB35D File Offset: 0x004E955D
		public IEntityPackageDataT PackageData { get; set; }

		// Token: 0x1700A0A9 RID: 41129
		// (get) Token: 0x06023C8B RID: 146571 RVA: 0x004EB366 File Offset: 0x004E9566
		// (set) Token: 0x06023C8C RID: 146572 RVA: 0x004EB36E File Offset: 0x004E956E
		public byte NullMask { get; set; }

		// Token: 0x06023C8D RID: 146573 RVA: 0x004EB377 File Offset: 0x004E9577
		public IEntityPackageComponentT()
		{
			this.Disabled = false;
			this.BindTemplate = false;
			this.PackageData = null;
			this.NullMask = 0;
		}
	}
}
