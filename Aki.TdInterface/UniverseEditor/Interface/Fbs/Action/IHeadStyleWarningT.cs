using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F87 RID: 28551
	public class IHeadStyleWarningT
	{
		// Token: 0x1700D11D RID: 53533
		// (get) Token: 0x060316B2 RID: 202418 RVA: 0x006B34A6 File Offset: 0x006B16A6
		// (set) Token: 0x060316B3 RID: 202419 RVA: 0x006B34AE File Offset: 0x006B16AE
		public EHeadStyle Type { get; set; }

		// Token: 0x060316B4 RID: 202420 RVA: 0x006B34B7 File Offset: 0x006B16B7
		public IHeadStyleWarningT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
