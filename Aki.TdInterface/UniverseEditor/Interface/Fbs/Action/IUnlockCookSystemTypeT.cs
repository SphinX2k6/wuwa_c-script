using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CD RID: 29901
	public class IUnlockCookSystemTypeT
	{
		// Token: 0x1700E2F0 RID: 58096
		// (get) Token: 0x060365CF RID: 222671 RVA: 0x00763166 File Offset: 0x00761366
		// (set) Token: 0x060365D0 RID: 222672 RVA: 0x0076316E File Offset: 0x0076136E
		public EUnlockCookSystemType Type { get; set; }

		// Token: 0x060365D1 RID: 222673 RVA: 0x00763177 File Offset: 0x00761377
		public IUnlockCookSystemTypeT()
		{
			this.Type = EUnlockCookSystemType.UnlockCookBook;
		}
	}
}
