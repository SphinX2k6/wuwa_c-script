using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E6 RID: 20710
	public class IDistanceRangeT
	{
		// Token: 0x1700946C RID: 37996
		// (get) Token: 0x060208A3 RID: 133283 RVA: 0x00483B7E File Offset: 0x00481D7E
		// (set) Token: 0x060208A4 RID: 133284 RVA: 0x00483B86 File Offset: 0x00481D86
		public float Min { get; set; }

		// Token: 0x1700946D RID: 37997
		// (get) Token: 0x060208A5 RID: 133285 RVA: 0x00483B8F File Offset: 0x00481D8F
		// (set) Token: 0x060208A6 RID: 133286 RVA: 0x00483B97 File Offset: 0x00481D97
		public float Max { get; set; }

		// Token: 0x1700946E RID: 37998
		// (get) Token: 0x060208A7 RID: 133287 RVA: 0x00483BA0 File Offset: 0x00481DA0
		// (set) Token: 0x060208A8 RID: 133288 RVA: 0x00483BA8 File Offset: 0x00481DA8
		public byte NullMask { get; set; }

		// Token: 0x060208A9 RID: 133289 RVA: 0x00483BB1 File Offset: 0x00481DB1
		public IDistanceRangeT()
		{
			this.Min = 0f;
			this.Max = 0f;
			this.NullMask = 0;
		}
	}
}
