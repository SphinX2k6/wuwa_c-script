using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A4 RID: 22692
	public class ISceneBulletComponentT
	{
		// Token: 0x1700A9E4 RID: 43492
		// (get) Token: 0x06026480 RID: 156800 RVA: 0x00546F5F File Offset: 0x0054515F
		// (set) Token: 0x06026481 RID: 156801 RVA: 0x00546F67 File Offset: 0x00545167
		public bool Disabled { get; set; }

		// Token: 0x1700A9E5 RID: 43493
		// (get) Token: 0x06026482 RID: 156802 RVA: 0x00546F70 File Offset: 0x00545170
		// (set) Token: 0x06026483 RID: 156803 RVA: 0x00546F78 File Offset: 0x00545178
		public bool DisableGenerateByRange { get; set; }

		// Token: 0x1700A9E6 RID: 43494
		// (get) Token: 0x06026484 RID: 156804 RVA: 0x00546F81 File Offset: 0x00545181
		// (set) Token: 0x06026485 RID: 156805 RVA: 0x00546F89 File Offset: 0x00545189
		public List<ISceneBulletGroupT> BulletGroups { get; set; }

		// Token: 0x1700A9E7 RID: 43495
		// (get) Token: 0x06026486 RID: 156806 RVA: 0x00546F92 File Offset: 0x00545192
		// (set) Token: 0x06026487 RID: 156807 RVA: 0x00546F9A File Offset: 0x0054519A
		public byte NullMask { get; set; }

		// Token: 0x06026488 RID: 156808 RVA: 0x00546FA3 File Offset: 0x005451A3
		public ISceneBulletComponentT()
		{
			this.Disabled = false;
			this.DisableGenerateByRange = false;
			this.BulletGroups = null;
			this.NullMask = 0;
		}
	}
}
