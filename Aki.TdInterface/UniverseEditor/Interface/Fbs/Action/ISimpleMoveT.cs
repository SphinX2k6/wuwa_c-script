using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007113 RID: 28947
	public class ISimpleMoveT
	{
		// Token: 0x1700D72D RID: 55085
		// (get) Token: 0x0603351F RID: 210207 RVA: 0x006EB179 File Offset: 0x006E9379
		// (set) Token: 0x06033520 RID: 210208 RVA: 0x006EB181 File Offset: 0x006E9381
		public int Who { get; set; }

		// Token: 0x1700D72E RID: 55086
		// (get) Token: 0x06033521 RID: 210209 RVA: 0x006EB18A File Offset: 0x006E938A
		// (set) Token: 0x06033522 RID: 210210 RVA: 0x006EB192 File Offset: 0x006E9392
		public float UseTime { get; set; }

		// Token: 0x1700D72F RID: 55087
		// (get) Token: 0x06033523 RID: 210211 RVA: 0x006EB19B File Offset: 0x006E939B
		// (set) Token: 0x06033524 RID: 210212 RVA: 0x006EB1A3 File Offset: 0x006E93A3
		public IVectorInfoT Pos { get; set; }

		// Token: 0x06033525 RID: 210213 RVA: 0x006EB1AC File Offset: 0x006E93AC
		public ISimpleMoveT()
		{
			this.Who = 0;
			this.UseTime = 0f;
			this.Pos = null;
		}
	}
}
