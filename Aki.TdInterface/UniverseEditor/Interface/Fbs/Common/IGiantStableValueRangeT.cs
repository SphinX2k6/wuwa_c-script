using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006411 RID: 25617
	public class IGiantStableValueRangeT
	{
		// Token: 0x1700BD38 RID: 48440
		// (get) Token: 0x0602B860 RID: 178272 RVA: 0x005ED6AA File Offset: 0x005EB8AA
		// (set) Token: 0x0602B861 RID: 178273 RVA: 0x005ED6B2 File Offset: 0x005EB8B2
		public IGiantStableValueT MinValue { get; set; }

		// Token: 0x1700BD39 RID: 48441
		// (get) Token: 0x0602B862 RID: 178274 RVA: 0x005ED6BB File Offset: 0x005EB8BB
		// (set) Token: 0x0602B863 RID: 178275 RVA: 0x005ED6C3 File Offset: 0x005EB8C3
		public IGiantStableValueT MaxValue { get; set; }

		// Token: 0x0602B864 RID: 178276 RVA: 0x005ED6CC File Offset: 0x005EB8CC
		public IGiantStableValueRangeT()
		{
			this.MinValue = null;
			this.MaxValue = null;
		}
	}
}
