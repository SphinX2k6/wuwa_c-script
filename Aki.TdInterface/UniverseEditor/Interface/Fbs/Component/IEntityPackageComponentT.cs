using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A5 RID: 20901
	public class IEntityPackageComponentT
	{
		// Token: 0x170098B7 RID: 39095
		// (get) Token: 0x06021D2D RID: 138541 RVA: 0x004B12CB File Offset: 0x004AF4CB
		// (set) Token: 0x06021D2E RID: 138542 RVA: 0x004B12D3 File Offset: 0x004AF4D3
		public bool Disabled { get; set; }

		// Token: 0x170098B8 RID: 39096
		// (get) Token: 0x06021D2F RID: 138543 RVA: 0x004B12DC File Offset: 0x004AF4DC
		// (set) Token: 0x06021D30 RID: 138544 RVA: 0x004B12E4 File Offset: 0x004AF4E4
		public bool BindTemplate { get; set; }

		// Token: 0x170098B9 RID: 39097
		// (get) Token: 0x06021D31 RID: 138545 RVA: 0x004B12ED File Offset: 0x004AF4ED
		// (set) Token: 0x06021D32 RID: 138546 RVA: 0x004B12F5 File Offset: 0x004AF4F5
		public IEntityPackageDataT PackageData { get; set; }

		// Token: 0x170098BA RID: 39098
		// (get) Token: 0x06021D33 RID: 138547 RVA: 0x004B12FE File Offset: 0x004AF4FE
		// (set) Token: 0x06021D34 RID: 138548 RVA: 0x004B1306 File Offset: 0x004AF506
		public byte NullMask { get; set; }

		// Token: 0x06021D35 RID: 138549 RVA: 0x004B130F File Offset: 0x004AF50F
		public IEntityPackageComponentT()
		{
			this.Disabled = false;
			this.BindTemplate = false;
			this.PackageData = null;
			this.NullMask = 0;
		}
	}
}
