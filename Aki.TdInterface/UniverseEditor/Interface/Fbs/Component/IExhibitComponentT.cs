using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005734 RID: 22324
	public class IExhibitComponentT
	{
		// Token: 0x1700A137 RID: 41271
		// (get) Token: 0x06023EB8 RID: 147128 RVA: 0x004F02C1 File Offset: 0x004EE4C1
		// (set) Token: 0x06023EB9 RID: 147129 RVA: 0x004F02C9 File Offset: 0x004EE4C9
		public bool Disabled { get; set; }

		// Token: 0x1700A138 RID: 41272
		// (get) Token: 0x06023EBA RID: 147130 RVA: 0x004F02D2 File Offset: 0x004EE4D2
		// (set) Token: 0x06023EBB RID: 147131 RVA: 0x004F02DA File Offset: 0x004EE4DA
		public TExhibitConfigUnion ExhibitConfig { get; set; }

		// Token: 0x1700A139 RID: 41273
		// (get) Token: 0x06023EBC RID: 147132 RVA: 0x004F02E3 File Offset: 0x004EE4E3
		// (set) Token: 0x06023EBD RID: 147133 RVA: 0x004F02EB File Offset: 0x004EE4EB
		public byte NullMask { get; set; }

		// Token: 0x06023EBE RID: 147134 RVA: 0x004F02F4 File Offset: 0x004EE4F4
		public IExhibitComponentT()
		{
			this.Disabled = false;
			this.ExhibitConfig = null;
			this.NullMask = 0;
		}
	}
}
