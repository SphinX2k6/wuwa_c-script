using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D3 RID: 29907
	public class IUnLockDangoCollectSystemItemT
	{
		// Token: 0x1700E2F6 RID: 58102
		// (get) Token: 0x060365EF RID: 222703 RVA: 0x0076343C File Offset: 0x0076163C
		// (set) Token: 0x060365F0 RID: 222704 RVA: 0x00763444 File Offset: 0x00761644
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700E2F7 RID: 58103
		// (get) Token: 0x060365F1 RID: 222705 RVA: 0x0076344D File Offset: 0x0076164D
		// (set) Token: 0x060365F2 RID: 222706 RVA: 0x00763455 File Offset: 0x00761655
		public int Id { get; set; }

		// Token: 0x060365F3 RID: 222707 RVA: 0x0076345E File Offset: 0x0076165E
		public IUnLockDangoCollectSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
