using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE6 RID: 27366
	public class ICommonTalkMessageT
	{
		// Token: 0x1700C8F7 RID: 51447
		// (get) Token: 0x0602F07F RID: 192639 RVA: 0x0066A329 File Offset: 0x00668529
		// (set) Token: 0x0602F080 RID: 192640 RVA: 0x0066A331 File Offset: 0x00668531
		public string Text { get; set; }

		// Token: 0x1700C8F8 RID: 51448
		// (get) Token: 0x0602F081 RID: 192641 RVA: 0x0066A33A File Offset: 0x0066853A
		// (set) Token: 0x0602F082 RID: 192642 RVA: 0x0066A342 File Offset: 0x00668542
		public int TalkerId { get; set; }

		// Token: 0x1700C8F9 RID: 51449
		// (get) Token: 0x0602F083 RID: 192643 RVA: 0x0066A34B File Offset: 0x0066854B
		// (set) Token: 0x0602F084 RID: 192644 RVA: 0x0066A353 File Offset: 0x00668553
		public float TextShowDelay { get; set; }

		// Token: 0x1700C8FA RID: 51450
		// (get) Token: 0x0602F085 RID: 192645 RVA: 0x0066A35C File Offset: 0x0066855C
		// (set) Token: 0x0602F086 RID: 192646 RVA: 0x0066A364 File Offset: 0x00668564
		public float TextShowDuration { get; set; }

		// Token: 0x1700C8FB RID: 51451
		// (get) Token: 0x0602F087 RID: 192647 RVA: 0x0066A36D File Offset: 0x0066856D
		// (set) Token: 0x0602F088 RID: 192648 RVA: 0x0066A375 File Offset: 0x00668575
		public byte NullMask { get; set; }

		// Token: 0x0602F089 RID: 192649 RVA: 0x0066A37E File Offset: 0x0066857E
		public ICommonTalkMessageT()
		{
			this.Text = null;
			this.TalkerId = 0;
			this.TextShowDelay = 0f;
			this.TextShowDuration = 0f;
			this.NullMask = 0;
		}
	}
}
