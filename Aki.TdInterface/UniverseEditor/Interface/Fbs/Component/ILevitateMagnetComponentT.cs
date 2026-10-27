using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F5 RID: 21749
	public class ILevitateMagnetComponentT
	{
		// Token: 0x1700A07F RID: 41087
		// (get) Token: 0x06023E71 RID: 147057 RVA: 0x004F6CC0 File Offset: 0x004F4EC0
		// (set) Token: 0x06023E72 RID: 147058 RVA: 0x004F6CC8 File Offset: 0x004F4EC8
		public bool Disabled { get; set; }

		// Token: 0x1700A080 RID: 41088
		// (get) Token: 0x06023E73 RID: 147059 RVA: 0x004F6CD1 File Offset: 0x004F4ED1
		// (set) Token: 0x06023E74 RID: 147060 RVA: 0x004F6CD9 File Offset: 0x004F4ED9
		public int MoveSpeed { get; set; }

		// Token: 0x1700A081 RID: 41089
		// (get) Token: 0x06023E75 RID: 147061 RVA: 0x004F6CE2 File Offset: 0x004F4EE2
		// (set) Token: 0x06023E76 RID: 147062 RVA: 0x004F6CEA File Offset: 0x004F4EEA
		public int Test { get; set; }

		// Token: 0x1700A082 RID: 41090
		// (get) Token: 0x06023E77 RID: 147063 RVA: 0x004F6CF3 File Offset: 0x004F4EF3
		// (set) Token: 0x06023E78 RID: 147064 RVA: 0x004F6CFB File Offset: 0x004F4EFB
		public byte NullMask { get; set; }

		// Token: 0x06023E79 RID: 147065 RVA: 0x004F6D04 File Offset: 0x004F4F04
		public ILevitateMagnetComponentT()
		{
			this.Disabled = false;
			this.MoveSpeed = 0;
			this.Test = 0;
			this.NullMask = 0;
		}
	}
}
