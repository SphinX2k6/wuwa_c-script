using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005221 RID: 21025
	public class IWeatherT
	{
		// Token: 0x17009669 RID: 38505
		// (get) Token: 0x060211D9 RID: 135641 RVA: 0x00492D82 File Offset: 0x00490F82
		// (set) Token: 0x060211DA RID: 135642 RVA: 0x00492D8A File Offset: 0x00490F8A
		public EVisibleCondition Type { get; set; }

		// Token: 0x1700966A RID: 38506
		// (get) Token: 0x060211DB RID: 135643 RVA: 0x00492D93 File Offset: 0x00490F93
		// (set) Token: 0x060211DC RID: 135644 RVA: 0x00492D9B File Offset: 0x00490F9B
		public ECompare Compare { get; set; }

		// Token: 0x1700966B RID: 38507
		// (get) Token: 0x060211DD RID: 135645 RVA: 0x00492DA4 File Offset: 0x00490FA4
		// (set) Token: 0x060211DE RID: 135646 RVA: 0x00492DAC File Offset: 0x00490FAC
		public EWeather Weather { get; set; }

		// Token: 0x1700966C RID: 38508
		// (get) Token: 0x060211DF RID: 135647 RVA: 0x00492DB5 File Offset: 0x00490FB5
		// (set) Token: 0x060211E0 RID: 135648 RVA: 0x00492DBD File Offset: 0x00490FBD
		public int WeatherId { get; set; }

		// Token: 0x1700966D RID: 38509
		// (get) Token: 0x060211E1 RID: 135649 RVA: 0x00492DC6 File Offset: 0x00490FC6
		// (set) Token: 0x060211E2 RID: 135650 RVA: 0x00492DCE File Offset: 0x00490FCE
		public byte NullMask { get; set; }

		// Token: 0x060211E3 RID: 135651 RVA: 0x00492DD7 File Offset: 0x00490FD7
		public IWeatherT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Weather = EWeather.Sunny;
			this.WeatherId = 0;
			this.NullMask = 0;
		}
	}
}
