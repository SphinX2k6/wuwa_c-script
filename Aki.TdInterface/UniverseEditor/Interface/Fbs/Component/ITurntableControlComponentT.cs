using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200610A RID: 24842
	public class ITurntableControlComponentT
	{
		// Token: 0x1700B8F1 RID: 47345
		// (get) Token: 0x0602A1C6 RID: 172486 RVA: 0x005BF729 File Offset: 0x005BD929
		// (set) Token: 0x0602A1C7 RID: 172487 RVA: 0x005BF731 File Offset: 0x005BD931
		public bool Disabled { get; set; }

		// Token: 0x1700B8F2 RID: 47346
		// (get) Token: 0x0602A1C8 RID: 172488 RVA: 0x005BF73A File Offset: 0x005BD93A
		// (set) Token: 0x0602A1C9 RID: 172489 RVA: 0x005BF742 File Offset: 0x005BD942
		public TTurntableControllerUnion Config { get; set; }

		// Token: 0x1700B8F3 RID: 47347
		// (get) Token: 0x0602A1CA RID: 172490 RVA: 0x005BF74B File Offset: 0x005BD94B
		// (set) Token: 0x0602A1CB RID: 172491 RVA: 0x005BF753 File Offset: 0x005BD953
		public byte NullMask { get; set; }

		// Token: 0x0602A1CC RID: 172492 RVA: 0x005BF75C File Offset: 0x005BD95C
		public ITurntableControlComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
