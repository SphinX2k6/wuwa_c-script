using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD2 RID: 19410
	public class ICompareWeatherT
	{
		// Token: 0x17008D04 RID: 36100
		// (get) Token: 0x0601EA5F RID: 125535 RVA: 0x0044969A File Offset: 0x0044789A
		// (set) Token: 0x0601EA60 RID: 125536 RVA: 0x004496A2 File Offset: 0x004478A2
		public ECondition Type { get; set; }

		// Token: 0x17008D05 RID: 36101
		// (get) Token: 0x0601EA61 RID: 125537 RVA: 0x004496AB File Offset: 0x004478AB
		// (set) Token: 0x0601EA62 RID: 125538 RVA: 0x004496B3 File Offset: 0x004478B3
		public ECompare Compare { get; set; }

		// Token: 0x17008D06 RID: 36102
		// (get) Token: 0x0601EA63 RID: 125539 RVA: 0x004496BC File Offset: 0x004478BC
		// (set) Token: 0x0601EA64 RID: 125540 RVA: 0x004496C4 File Offset: 0x004478C4
		public EWeather Weather { get; set; }

		// Token: 0x17008D07 RID: 36103
		// (get) Token: 0x0601EA65 RID: 125541 RVA: 0x004496CD File Offset: 0x004478CD
		// (set) Token: 0x0601EA66 RID: 125542 RVA: 0x004496D5 File Offset: 0x004478D5
		public int WeatherId { get; set; }

		// Token: 0x17008D08 RID: 36104
		// (get) Token: 0x0601EA67 RID: 125543 RVA: 0x004496DE File Offset: 0x004478DE
		// (set) Token: 0x0601EA68 RID: 125544 RVA: 0x004496E6 File Offset: 0x004478E6
		public byte NullMask { get; set; }

		// Token: 0x0601EA69 RID: 125545 RVA: 0x004496EF File Offset: 0x004478EF
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
