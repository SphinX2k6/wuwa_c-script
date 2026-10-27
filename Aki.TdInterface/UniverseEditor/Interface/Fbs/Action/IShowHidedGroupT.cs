using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DD RID: 28893
	public class IShowHidedGroupT
	{
		// Token: 0x1700D6AE RID: 54958
		// (get) Token: 0x060332FD RID: 209661 RVA: 0x006E6977 File Offset: 0x006E4B77
		// (set) Token: 0x060332FE RID: 209662 RVA: 0x006E697F File Offset: 0x006E4B7F
		public string GroupKey { get; set; }

		// Token: 0x1700D6AF RID: 54959
		// (get) Token: 0x060332FF RID: 209663 RVA: 0x006E6988 File Offset: 0x006E4B88
		// (set) Token: 0x06033300 RID: 209664 RVA: 0x006E6990 File Offset: 0x006E4B90
		public bool DelayShow { get; set; }

		// Token: 0x06033301 RID: 209665 RVA: 0x006E6999 File Offset: 0x006E4B99
		public IShowHidedGroupT()
		{
			this.GroupKey = null;
			this.DelayShow = false;
		}
	}
}
