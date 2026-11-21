using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200403B RID: 16443
	public class IRangeT
	{
		// Token: 0x17006FC1 RID: 28609
		// (get) Token: 0x06016949 RID: 92489 RVA: 0x0033AE92 File Offset: 0x00339092
		// (set) Token: 0x0601694A RID: 92490 RVA: 0x0033AE9A File Offset: 0x0033909A
		public ERangeType Type { get; set; }

		// Token: 0x0601694B RID: 92491 RVA: 0x0033AEA3 File Offset: 0x003390A3
		public IRangeT()
		{
			this.Type = ERangeType.CircleRange;
		}
	}
}
