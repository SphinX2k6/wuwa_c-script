using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CF RID: 20943
	public class IExhibitComponentT
	{
		// Token: 0x17009948 RID: 39240
		// (get) Token: 0x06021F60 RID: 139104 RVA: 0x004B6259 File Offset: 0x004B4459
		// (set) Token: 0x06021F61 RID: 139105 RVA: 0x004B6261 File Offset: 0x004B4461
		public bool Disabled { get; set; }

		// Token: 0x17009949 RID: 39241
		// (get) Token: 0x06021F62 RID: 139106 RVA: 0x004B626A File Offset: 0x004B446A
		// (set) Token: 0x06021F63 RID: 139107 RVA: 0x004B6272 File Offset: 0x004B4472
		public TExhibitConfigUnion ExhibitConfig { get; set; }

		// Token: 0x1700994A RID: 39242
		// (get) Token: 0x06021F64 RID: 139108 RVA: 0x004B627B File Offset: 0x004B447B
		// (set) Token: 0x06021F65 RID: 139109 RVA: 0x004B6283 File Offset: 0x004B4483
		public byte NullMask { get; set; }

		// Token: 0x06021F66 RID: 139110 RVA: 0x004B628C File Offset: 0x004B448C
		public IExhibitComponentT()
		{
			this.Disabled = false;
			this.ExhibitConfig = null;
			this.NullMask = 0;
		}
	}
}
