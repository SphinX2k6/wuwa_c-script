using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006520 RID: 25888
	public class ICutCameraTimeParamsT
	{
		// Token: 0x1700C07D RID: 49277
		// (get) Token: 0x0602CE8D RID: 183949 RVA: 0x0062ADB2 File Offset: 0x00628FB2
		// (set) Token: 0x0602CE8E RID: 183950 RVA: 0x0062ADBA File Offset: 0x00628FBA
		public float CutStayTime { get; set; }

		// Token: 0x0602CE8F RID: 183951 RVA: 0x0062ADC3 File Offset: 0x00628FC3
		public ICutCameraTimeParamsT()
		{
			this.CutStayTime = 0f;
		}
	}
}
