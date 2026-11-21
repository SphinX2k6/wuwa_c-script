using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007235 RID: 29237
	public class IMontageIdT
	{
		// Token: 0x1700D625 RID: 54821
		// (get) Token: 0x06032E62 RID: 208482 RVA: 0x006DF4D2 File Offset: 0x006DD6D2
		// (set) Token: 0x06032E63 RID: 208483 RVA: 0x006DF4DA File Offset: 0x006DD6DA
		public int MontageId { get; set; }

		// Token: 0x1700D626 RID: 54822
		// (get) Token: 0x06032E64 RID: 208484 RVA: 0x006DF4E3 File Offset: 0x006DD6E3
		// (set) Token: 0x06032E65 RID: 208485 RVA: 0x006DF4EB File Offset: 0x006DD6EB
		public bool IsAbp { get; set; }

		// Token: 0x1700D627 RID: 54823
		// (get) Token: 0x06032E66 RID: 208486 RVA: 0x006DF4F4 File Offset: 0x006DD6F4
		// (set) Token: 0x06032E67 RID: 208487 RVA: 0x006DF4FC File Offset: 0x006DD6FC
		public byte NullMask { get; set; }

		// Token: 0x06032E68 RID: 208488 RVA: 0x006DF505 File Offset: 0x006DD705
		public IMontageIdT()
		{
			this.MontageId = 0;
			this.IsAbp = false;
			this.NullMask = 0;
		}
	}
}
