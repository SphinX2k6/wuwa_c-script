using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005512 RID: 21778
	public class ICollectComponentT
	{
		// Token: 0x17009BA6 RID: 39846
		// (get) Token: 0x060226B5 RID: 140981 RVA: 0x004BE3DA File Offset: 0x004BC5DA
		// (set) Token: 0x060226B6 RID: 140982 RVA: 0x004BE3E2 File Offset: 0x004BC5E2
		public bool Disabled { get; set; }

		// Token: 0x17009BA7 RID: 39847
		// (get) Token: 0x060226B7 RID: 140983 RVA: 0x004BE3EB File Offset: 0x004BC5EB
		// (set) Token: 0x060226B8 RID: 140984 RVA: 0x004BE3F3 File Offset: 0x004BC5F3
		public bool IsDisableOneClickCollection { get; set; }

		// Token: 0x17009BA8 RID: 39848
		// (get) Token: 0x060226B9 RID: 140985 RVA: 0x004BE3FC File Offset: 0x004BC5FC
		// (set) Token: 0x060226BA RID: 140986 RVA: 0x004BE404 File Offset: 0x004BC604
		public byte NullMask { get; set; }

		// Token: 0x060226BB RID: 140987 RVA: 0x004BE40D File Offset: 0x004BC60D
		public ICollectComponentT()
		{
			this.Disabled = false;
			this.IsDisableOneClickCollection = false;
			this.NullMask = 0;
		}
	}
}
