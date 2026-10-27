using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D25 RID: 19749
	public class IWeatherT
	{
		// Token: 0x17008F30 RID: 36656
		// (get) Token: 0x0601F592 RID: 128402 RVA: 0x0045EDF2 File Offset: 0x0045CFF2
		// (set) Token: 0x0601F593 RID: 128403 RVA: 0x0045EDFA File Offset: 0x0045CFFA
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008F31 RID: 36657
		// (get) Token: 0x0601F594 RID: 128404 RVA: 0x0045EE03 File Offset: 0x0045D003
		// (set) Token: 0x0601F595 RID: 128405 RVA: 0x0045EE0B File Offset: 0x0045D00B
		public ECompare Compare { get; set; }

		// Token: 0x17008F32 RID: 36658
		// (get) Token: 0x0601F596 RID: 128406 RVA: 0x0045EE14 File Offset: 0x0045D014
		// (set) Token: 0x0601F597 RID: 128407 RVA: 0x0045EE1C File Offset: 0x0045D01C
		public EWeather Weather { get; set; }

		// Token: 0x17008F33 RID: 36659
		// (get) Token: 0x0601F598 RID: 128408 RVA: 0x0045EE25 File Offset: 0x0045D025
		// (set) Token: 0x0601F599 RID: 128409 RVA: 0x0045EE2D File Offset: 0x0045D02D
		public int WeatherId { get; set; }

		// Token: 0x17008F34 RID: 36660
		// (get) Token: 0x0601F59A RID: 128410 RVA: 0x0045EE36 File Offset: 0x0045D036
		// (set) Token: 0x0601F59B RID: 128411 RVA: 0x0045EE3E File Offset: 0x0045D03E
		public byte NullMask { get; set; }

		// Token: 0x0601F59C RID: 128412 RVA: 0x0045EE47 File Offset: 0x0045D047
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
