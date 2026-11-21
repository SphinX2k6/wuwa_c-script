using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770F RID: 30479
	public class ISeasonWeatherChangeToT
	{
		// Token: 0x1700DF88 RID: 57224
		// (get) Token: 0x060357AB RID: 219051 RVA: 0x0072BB26 File Offset: 0x00729D26
		// (set) Token: 0x060357AC RID: 219052 RVA: 0x0072BB2E File Offset: 0x00729D2E
		public int Season { get; set; }

		// Token: 0x1700DF89 RID: 57225
		// (get) Token: 0x060357AD RID: 219053 RVA: 0x0072BB37 File Offset: 0x00729D37
		// (set) Token: 0x060357AE RID: 219054 RVA: 0x0072BB3F File Offset: 0x00729D3F
		public int Weather { get; set; }

		// Token: 0x1700DF8A RID: 57226
		// (get) Token: 0x060357AF RID: 219055 RVA: 0x0072BB48 File Offset: 0x00729D48
		// (set) Token: 0x060357B0 RID: 219056 RVA: 0x0072BB50 File Offset: 0x00729D50
		public byte NullMask { get; set; }

		// Token: 0x060357B1 RID: 219057 RVA: 0x0072BB59 File Offset: 0x00729D59
		public ISeasonWeatherChangeToT()
		{
			this.Season = 0;
			this.Weather = 0;
			this.NullMask = 0;
		}
	}
}
