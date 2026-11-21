using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B17 RID: 23319
	public class IMonsterGachaBaseComponentT
	{
		// Token: 0x1700AA3B RID: 43579
		// (get) Token: 0x06026588 RID: 157064 RVA: 0x00540ED5 File Offset: 0x0053F0D5
		// (set) Token: 0x06026589 RID: 157065 RVA: 0x00540EDD File Offset: 0x0053F0DD
		public bool Disabled { get; set; }

		// Token: 0x1700AA3C RID: 43580
		// (get) Token: 0x0602658A RID: 157066 RVA: 0x00540EE6 File Offset: 0x0053F0E6
		// (set) Token: 0x0602658B RID: 157067 RVA: 0x00540EEE File Offset: 0x0053F0EE
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700AA3D RID: 43581
		// (get) Token: 0x0602658C RID: 157068 RVA: 0x00540EF7 File Offset: 0x0053F0F7
		// (set) Token: 0x0602658D RID: 157069 RVA: 0x00540EFF File Offset: 0x0053F0FF
		public List<IMonsterGachaSlotT> Config { get; set; }

		// Token: 0x1700AA3E RID: 43582
		// (get) Token: 0x0602658E RID: 157070 RVA: 0x00540F08 File Offset: 0x0053F108
		// (set) Token: 0x0602658F RID: 157071 RVA: 0x00540F10 File Offset: 0x0053F110
		public List<IMonsterFormationT> Formation { get; set; }

		// Token: 0x1700AA3F RID: 43583
		// (get) Token: 0x06026590 RID: 157072 RVA: 0x00540F19 File Offset: 0x0053F119
		// (set) Token: 0x06026591 RID: 157073 RVA: 0x00540F21 File Offset: 0x0053F121
		public byte NullMask { get; set; }

		// Token: 0x06026592 RID: 157074 RVA: 0x00540F2A File Offset: 0x0053F12A
		public IMonsterGachaBaseComponentT()
		{
			this.Disabled = false;
			this.MonsterEntityIds = null;
			this.Config = null;
			this.Formation = null;
			this.NullMask = 0;
		}
	}
}
