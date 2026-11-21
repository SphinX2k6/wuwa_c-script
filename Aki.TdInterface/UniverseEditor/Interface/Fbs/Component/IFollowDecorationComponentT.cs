using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F7 RID: 22519
	public class IFollowDecorationComponentT
	{
		// Token: 0x1700A2F8 RID: 41720
		// (get) Token: 0x060246B2 RID: 149170 RVA: 0x005013CD File Offset: 0x004FF5CD
		// (set) Token: 0x060246B3 RID: 149171 RVA: 0x005013D5 File Offset: 0x004FF5D5
		public bool Disabled { get; set; }

		// Token: 0x1700A2F9 RID: 41721
		// (get) Token: 0x060246B4 RID: 149172 RVA: 0x005013DE File Offset: 0x004FF5DE
		// (set) Token: 0x060246B5 RID: 149173 RVA: 0x005013E6 File Offset: 0x004FF5E6
		public IFollowDecorationChairConfigT DecorationConfig { get; set; }

		// Token: 0x1700A2FA RID: 41722
		// (get) Token: 0x060246B6 RID: 149174 RVA: 0x005013EF File Offset: 0x004FF5EF
		// (set) Token: 0x060246B7 RID: 149175 RVA: 0x005013F7 File Offset: 0x004FF5F7
		public byte NullMask { get; set; }

		// Token: 0x060246B8 RID: 149176 RVA: 0x00501400 File Offset: 0x004FF600
		public IFollowDecorationComponentT()
		{
			this.Disabled = false;
			this.DecorationConfig = null;
			this.NullMask = 0;
		}
	}
}
