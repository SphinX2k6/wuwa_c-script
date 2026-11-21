using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050BF RID: 20671
	public class ICompareWeatherT
	{
		// Token: 0x17009428 RID: 37928
		// (get) Token: 0x0602062D RID: 132653 RVA: 0x0047C5A6 File Offset: 0x0047A7A6
		// (set) Token: 0x0602062E RID: 132654 RVA: 0x0047C5AE File Offset: 0x0047A7AE
		public ECondition Type { get; set; }

		// Token: 0x17009429 RID: 37929
		// (get) Token: 0x0602062F RID: 132655 RVA: 0x0047C5B7 File Offset: 0x0047A7B7
		// (set) Token: 0x06020630 RID: 132656 RVA: 0x0047C5BF File Offset: 0x0047A7BF
		public ECompare Compare { get; set; }

		// Token: 0x1700942A RID: 37930
		// (get) Token: 0x06020631 RID: 132657 RVA: 0x0047C5C8 File Offset: 0x0047A7C8
		// (set) Token: 0x06020632 RID: 132658 RVA: 0x0047C5D0 File Offset: 0x0047A7D0
		public EWeather Weather { get; set; }

		// Token: 0x1700942B RID: 37931
		// (get) Token: 0x06020633 RID: 132659 RVA: 0x0047C5D9 File Offset: 0x0047A7D9
		// (set) Token: 0x06020634 RID: 132660 RVA: 0x0047C5E1 File Offset: 0x0047A7E1
		public int WeatherId { get; set; }

		// Token: 0x1700942C RID: 37932
		// (get) Token: 0x06020635 RID: 132661 RVA: 0x0047C5EA File Offset: 0x0047A7EA
		// (set) Token: 0x06020636 RID: 132662 RVA: 0x0047C5F2 File Offset: 0x0047A7F2
		public byte NullMask { get; set; }

		// Token: 0x06020637 RID: 132663 RVA: 0x0047C5FB File Offset: 0x0047A7FB
		public ICompareWeatherT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Weather = EWeather.Sunny;
			this.WeatherId = 0;
			this.NullMask = 0;
		}
	}
}
