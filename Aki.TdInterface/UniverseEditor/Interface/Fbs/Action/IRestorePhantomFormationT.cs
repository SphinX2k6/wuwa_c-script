using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763D RID: 30269
	public class IRestorePhantomFormationT
	{
		// Token: 0x1700DE55 RID: 56917
		// (get) Token: 0x060351D6 RID: 217558 RVA: 0x00721EC2 File Offset: 0x007200C2
		// (set) Token: 0x060351D7 RID: 217559 RVA: 0x00721ECA File Offset: 0x007200CA
		public int TeleportEntityId { get; set; }

		// Token: 0x1700DE56 RID: 56918
		// (get) Token: 0x060351D8 RID: 217560 RVA: 0x00721ED3 File Offset: 0x007200D3
		// (set) Token: 0x060351D9 RID: 217561 RVA: 0x00721EDB File Offset: 0x007200DB
		public bool RetainPhantom { get; set; }

		// Token: 0x1700DE57 RID: 56919
		// (get) Token: 0x060351DA RID: 217562 RVA: 0x00721EE4 File Offset: 0x007200E4
		// (set) Token: 0x060351DB RID: 217563 RVA: 0x00721EEC File Offset: 0x007200EC
		public byte NullMask { get; set; }

		// Token: 0x060351DC RID: 217564 RVA: 0x00721EF5 File Offset: 0x007200F5
		public IRestorePhantomFormationT()
		{
			this.TeleportEntityId = 0;
			this.RetainPhantom = false;
			this.NullMask = 0;
		}
	}
}
