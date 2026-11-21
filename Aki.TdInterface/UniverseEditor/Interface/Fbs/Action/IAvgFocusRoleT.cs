using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682D RID: 26669
	public class IAvgFocusRoleT
	{
		// Token: 0x1700C40E RID: 50190
		// (get) Token: 0x0602D925 RID: 186661 RVA: 0x0063C682 File Offset: 0x0063A882
		// (set) Token: 0x0602D926 RID: 186662 RVA: 0x0063C68A File Offset: 0x0063A88A
		public bool IsFocus { get; set; }

		// Token: 0x0602D927 RID: 186663 RVA: 0x0063C693 File Offset: 0x0063A893
		public IAvgFocusRoleT()
		{
			this.IsFocus = false;
		}
	}
}
