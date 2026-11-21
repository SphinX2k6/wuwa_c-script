using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200470D RID: 18189
	public class IZaxisViewRangeT
	{
		// Token: 0x17007F5B RID: 32603
		// (get) Token: 0x0601AC31 RID: 109617 RVA: 0x003CD2F2 File Offset: 0x003CB4F2
		// (set) Token: 0x0601AC32 RID: 109618 RVA: 0x003CD2FA File Offset: 0x003CB4FA
		public int Up { get; set; }

		// Token: 0x17007F5C RID: 32604
		// (get) Token: 0x0601AC33 RID: 109619 RVA: 0x003CD303 File Offset: 0x003CB503
		// (set) Token: 0x0601AC34 RID: 109620 RVA: 0x003CD30B File Offset: 0x003CB50B
		public int Down { get; set; }

		// Token: 0x17007F5D RID: 32605
		// (get) Token: 0x0601AC35 RID: 109621 RVA: 0x003CD314 File Offset: 0x003CB514
		// (set) Token: 0x0601AC36 RID: 109622 RVA: 0x003CD31C File Offset: 0x003CB51C
		public byte NullMask { get; set; }

		// Token: 0x0601AC37 RID: 109623 RVA: 0x003CD325 File Offset: 0x003CB525
		public IZaxisViewRangeT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
