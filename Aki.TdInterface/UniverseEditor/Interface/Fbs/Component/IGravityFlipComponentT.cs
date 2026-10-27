using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005322 RID: 21282
	public class IGravityFlipComponentT
	{
		// Token: 0x17009C47 RID: 40007
		// (get) Token: 0x06022C6E RID: 142446 RVA: 0x004D1707 File Offset: 0x004CF907
		// (set) Token: 0x06022C6F RID: 142447 RVA: 0x004D170F File Offset: 0x004CF90F
		public bool Disabled { get; set; }

		// Token: 0x17009C48 RID: 40008
		// (get) Token: 0x06022C70 RID: 142448 RVA: 0x004D1718 File Offset: 0x004CF918
		// (set) Token: 0x06022C71 RID: 142449 RVA: 0x004D1720 File Offset: 0x004CF920
		public List<IGravityFlipConfigT> Config { get; set; }

		// Token: 0x17009C49 RID: 40009
		// (get) Token: 0x06022C72 RID: 142450 RVA: 0x004D1729 File Offset: 0x004CF929
		// (set) Token: 0x06022C73 RID: 142451 RVA: 0x004D1731 File Offset: 0x004CF931
		public EGravityFlipType DefaultGravity { get; set; }

		// Token: 0x17009C4A RID: 40010
		// (get) Token: 0x06022C74 RID: 142452 RVA: 0x004D173A File Offset: 0x004CF93A
		// (set) Token: 0x06022C75 RID: 142453 RVA: 0x004D1742 File Offset: 0x004CF942
		public byte NullMask { get; set; }

		// Token: 0x06022C76 RID: 142454 RVA: 0x004D174B File Offset: 0x004CF94B
		public IGravityFlipComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.DefaultGravity = EGravityFlipType.None;
			this.NullMask = 0;
		}
	}
}
