using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF9 RID: 19449
	public class IDistanceRangeT
	{
		// Token: 0x17008D48 RID: 36168
		// (get) Token: 0x0601ECBD RID: 126141 RVA: 0x00450516 File Offset: 0x0044E716
		// (set) Token: 0x0601ECBE RID: 126142 RVA: 0x0045051E File Offset: 0x0044E71E
		public float Min { get; set; }

		// Token: 0x17008D49 RID: 36169
		// (get) Token: 0x0601ECBF RID: 126143 RVA: 0x00450527 File Offset: 0x0044E727
		// (set) Token: 0x0601ECC0 RID: 126144 RVA: 0x0045052F File Offset: 0x0044E72F
		public float Max { get; set; }

		// Token: 0x17008D4A RID: 36170
		// (get) Token: 0x0601ECC1 RID: 126145 RVA: 0x00450538 File Offset: 0x0044E738
		// (set) Token: 0x0601ECC2 RID: 126146 RVA: 0x00450540 File Offset: 0x0044E740
		public byte NullMask { get; set; }

		// Token: 0x0601ECC3 RID: 126147 RVA: 0x00450549 File Offset: 0x0044E749
		public IDistanceRangeT()
		{
			this.Min = 0f;
			this.Max = 0f;
			this.NullMask = 0;
		}
	}
}
