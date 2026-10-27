using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576A RID: 22378
	public class IPortalComponentT
	{
		// Token: 0x1700A6E9 RID: 42729
		// (get) Token: 0x06025811 RID: 153617 RVA: 0x0052C889 File Offset: 0x0052AA89
		// (set) Token: 0x06025812 RID: 153618 RVA: 0x0052C891 File Offset: 0x0052AA91
		public bool Disabled { get; set; }

		// Token: 0x1700A6EA RID: 42730
		// (get) Token: 0x06025813 RID: 153619 RVA: 0x0052C89A File Offset: 0x0052AA9A
		// (set) Token: 0x06025814 RID: 153620 RVA: 0x0052C8A2 File Offset: 0x0052AAA2
		public TPortalConfigUnion Config { get; set; }

		// Token: 0x1700A6EB RID: 42731
		// (get) Token: 0x06025815 RID: 153621 RVA: 0x0052C8AB File Offset: 0x0052AAAB
		// (set) Token: 0x06025816 RID: 153622 RVA: 0x0052C8B3 File Offset: 0x0052AAB3
		public byte NullMask { get; set; }

		// Token: 0x06025817 RID: 153623 RVA: 0x0052C8BC File Offset: 0x0052AABC
		public IPortalComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
