using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006330 RID: 25392
	public class IChangeTimerTypeT
	{
		// Token: 0x1700BD88 RID: 48520
		// (get) Token: 0x0602BECE RID: 179918 RVA: 0x00609C2E File Offset: 0x00607E2E
		// (set) Token: 0x0602BECF RID: 179919 RVA: 0x00609C36 File Offset: 0x00607E36
		public EChangeTimerType Type { get; set; }

		// Token: 0x0602BED0 RID: 179920 RVA: 0x00609C3F File Offset: 0x00607E3F
		public IChangeTimerTypeT()
		{
			this.Type = EChangeTimerType.Add;
		}
	}
}
