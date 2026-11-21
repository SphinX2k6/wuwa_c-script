using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AA RID: 29354
	public class IMoveToPosAT
	{
		// Token: 0x1700D729 RID: 55081
		// (get) Token: 0x0603328C RID: 209548 RVA: 0x006E726B File Offset: 0x006E546B
		// (set) Token: 0x0603328D RID: 209549 RVA: 0x006E7273 File Offset: 0x006E5473
		public float Timeout { get; set; }

		// Token: 0x1700D72A RID: 55082
		// (get) Token: 0x0603328E RID: 209550 RVA: 0x006E727C File Offset: 0x006E547C
		// (set) Token: 0x0603328F RID: 209551 RVA: 0x006E7284 File Offset: 0x006E5484
		public IPosAT Pos { get; set; }

		// Token: 0x06033290 RID: 209552 RVA: 0x006E728D File Offset: 0x006E548D
		public IMoveToPosAT()
		{
			this.Timeout = 0f;
			this.Pos = null;
		}
	}
}
