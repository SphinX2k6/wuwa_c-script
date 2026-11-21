using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9B RID: 28059
	public class IExitDungeonT
	{
		// Token: 0x1700CDC8 RID: 52680
		// (get) Token: 0x060306E3 RID: 198371 RVA: 0x006947EC File Offset: 0x006929EC
		// (set) Token: 0x060306E4 RID: 198372 RVA: 0x006947F4 File Offset: 0x006929F4
		public bool IsNeedSecondaryConfirmation { get; set; }

		// Token: 0x1700CDC9 RID: 52681
		// (get) Token: 0x060306E5 RID: 198373 RVA: 0x006947FD File Offset: 0x006929FD
		// (set) Token: 0x060306E6 RID: 198374 RVA: 0x00694805 File Offset: 0x00692A05
		public byte NullMask { get; set; }

		// Token: 0x060306E7 RID: 198375 RVA: 0x0069480E File Offset: 0x00692A0E
		public IExitDungeonT()
		{
			this.IsNeedSecondaryConfirmation = false;
			this.NullMask = 0;
		}
	}
}
