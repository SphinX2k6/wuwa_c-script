using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BF RID: 25023
	public class IAvgFocusRoleT
	{
		// Token: 0x1700BA8B RID: 47755
		// (get) Token: 0x0602B1DE RID: 176606 RVA: 0x005F1C0E File Offset: 0x005EFE0E
		// (set) Token: 0x0602B1DF RID: 176607 RVA: 0x005F1C16 File Offset: 0x005EFE16
		public bool IsFocus { get; set; }

		// Token: 0x0602B1E0 RID: 176608 RVA: 0x005F1C1F File Offset: 0x005EFE1F
		public IAvgFocusRoleT()
		{
			this.IsFocus = false;
		}
	}
}
