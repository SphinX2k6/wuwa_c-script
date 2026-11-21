using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006857 RID: 26711
	public class IBaseTimeT
	{
		// Token: 0x1700C461 RID: 50273
		// (get) Token: 0x0602DA8C RID: 187020 RVA: 0x0063EE24 File Offset: 0x0063D024
		// (set) Token: 0x0602DA8D RID: 187021 RVA: 0x0063EE2C File Offset: 0x0063D02C
		public int Hour { get; set; }

		// Token: 0x1700C462 RID: 50274
		// (get) Token: 0x0602DA8E RID: 187022 RVA: 0x0063EE35 File Offset: 0x0063D035
		// (set) Token: 0x0602DA8F RID: 187023 RVA: 0x0063EE3D File Offset: 0x0063D03D
		public int Minute { get; set; }

		// Token: 0x0602DA90 RID: 187024 RVA: 0x0063EE46 File Offset: 0x0063D046
		public IBaseTimeT()
		{
			this.Hour = 0;
			this.Minute = 0;
		}
	}
}
