using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005665 RID: 22117
	public class IDynamicSpawnMonsterPointComponentT
	{
		// Token: 0x17009F01 RID: 40705
		// (get) Token: 0x060235D2 RID: 144850 RVA: 0x004DD91E File Offset: 0x004DBB1E
		// (set) Token: 0x060235D3 RID: 144851 RVA: 0x004DD926 File Offset: 0x004DBB26
		public bool Disabled { get; set; }

		// Token: 0x17009F02 RID: 40706
		// (get) Token: 0x060235D4 RID: 144852 RVA: 0x004DD92F File Offset: 0x004DBB2F
		// (set) Token: 0x060235D5 RID: 144853 RVA: 0x004DD937 File Offset: 0x004DBB37
		public int TagId { get; set; }

		// Token: 0x17009F03 RID: 40707
		// (get) Token: 0x060235D6 RID: 144854 RVA: 0x004DD940 File Offset: 0x004DBB40
		// (set) Token: 0x060235D7 RID: 144855 RVA: 0x004DD948 File Offset: 0x004DBB48
		public byte NullMask { get; set; }

		// Token: 0x060235D8 RID: 144856 RVA: 0x004DD951 File Offset: 0x004DBB51
		public IDynamicSpawnMonsterPointComponentT()
		{
			this.Disabled = false;
			this.TagId = 0;
			this.NullMask = 0;
		}
	}
}
