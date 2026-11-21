using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007715 RID: 30485
	public class ISeasonWeatherUnlockSpecialT
	{
		// Token: 0x1700DF90 RID: 57232
		// (get) Token: 0x060357D3 RID: 219091 RVA: 0x0072BE72 File Offset: 0x0072A072
		// (set) Token: 0x060357D4 RID: 219092 RVA: 0x0072BE7A File Offset: 0x0072A07A
		public int Weather { get; set; }

		// Token: 0x060357D5 RID: 219093 RVA: 0x0072BE83 File Offset: 0x0072A083
		public ISeasonWeatherUnlockSpecialT()
		{
			this.Weather = 0;
		}
	}
}
