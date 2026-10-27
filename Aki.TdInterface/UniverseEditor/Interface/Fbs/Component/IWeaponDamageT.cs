using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6C RID: 23404
	public class IWeaponDamageT
	{
		// Token: 0x1700B0D6 RID: 45270
		// (get) Token: 0x060280D7 RID: 164055 RVA: 0x00581A5E File Offset: 0x0057FC5E
		// (set) Token: 0x060280D8 RID: 164056 RVA: 0x00581A66 File Offset: 0x0057FC66
		public int DefaultValue { get; set; }

		// Token: 0x1700B0D7 RID: 45271
		// (get) Token: 0x060280D9 RID: 164057 RVA: 0x00581A6F File Offset: 0x0057FC6F
		// (set) Token: 0x060280DA RID: 164058 RVA: 0x00581A77 File Offset: 0x0057FC77
		public int GreatSword { get; set; }

		// Token: 0x1700B0D8 RID: 45272
		// (get) Token: 0x060280DB RID: 164059 RVA: 0x00581A80 File Offset: 0x0057FC80
		// (set) Token: 0x060280DC RID: 164060 RVA: 0x00581A88 File Offset: 0x0057FC88
		public int Dagger { get; set; }

		// Token: 0x1700B0D9 RID: 45273
		// (get) Token: 0x060280DD RID: 164061 RVA: 0x00581A91 File Offset: 0x0057FC91
		// (set) Token: 0x060280DE RID: 164062 RVA: 0x00581A99 File Offset: 0x0057FC99
		public int Pistol { get; set; }

		// Token: 0x1700B0DA RID: 45274
		// (get) Token: 0x060280DF RID: 164063 RVA: 0x00581AA2 File Offset: 0x0057FCA2
		// (set) Token: 0x060280E0 RID: 164064 RVA: 0x00581AAA File Offset: 0x0057FCAA
		public int Pugilism { get; set; }

		// Token: 0x1700B0DB RID: 45275
		// (get) Token: 0x060280E1 RID: 164065 RVA: 0x00581AB3 File Offset: 0x0057FCB3
		// (set) Token: 0x060280E2 RID: 164066 RVA: 0x00581ABB File Offset: 0x0057FCBB
		public int Ring { get; set; }

		// Token: 0x1700B0DC RID: 45276
		// (get) Token: 0x060280E3 RID: 164067 RVA: 0x00581AC4 File Offset: 0x0057FCC4
		// (set) Token: 0x060280E4 RID: 164068 RVA: 0x00581ACC File Offset: 0x0057FCCC
		public byte NullMask { get; set; }

		// Token: 0x060280E5 RID: 164069 RVA: 0x00581AD5 File Offset: 0x0057FCD5
		public IWeaponDamageT()
		{
			this.DefaultValue = 0;
			this.GreatSword = 0;
			this.Dagger = 0;
			this.Pistol = 0;
			this.Pugilism = 0;
			this.Ring = 0;
			this.NullMask = 0;
		}
	}
}
