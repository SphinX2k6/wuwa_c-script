using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A9 RID: 30889
	public class IShowHidedGroupT
	{
		// Token: 0x1700E291 RID: 58001
		// (get) Token: 0x0603659F RID: 222623 RVA: 0x00746F83 File Offset: 0x00745183
		// (set) Token: 0x060365A0 RID: 222624 RVA: 0x00746F8B File Offset: 0x0074518B
		public string GroupKey { get; set; }

		// Token: 0x1700E292 RID: 58002
		// (get) Token: 0x060365A1 RID: 222625 RVA: 0x00746F94 File Offset: 0x00745194
		// (set) Token: 0x060365A2 RID: 222626 RVA: 0x00746F9C File Offset: 0x0074519C
		public bool DelayShow { get; set; }

		// Token: 0x060365A3 RID: 222627 RVA: 0x00746FA5 File Offset: 0x007451A5
		public IShowHidedGroupT()
		{
			this.GroupKey = null;
			this.DelayShow = false;
		}
	}
}
