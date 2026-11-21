using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC6 RID: 27846
	public class IEnableClientFunctionT
	{
		// Token: 0x1700CC3F RID: 52287
		// (get) Token: 0x0602FFE6 RID: 196582 RVA: 0x00687FA6 File Offset: 0x006861A6
		// (set) Token: 0x0602FFE7 RID: 196583 RVA: 0x00687FAE File Offset: 0x006861AE
		public EEnableClientFunctionType Type { get; set; }

		// Token: 0x0602FFE8 RID: 196584 RVA: 0x00687FB7 File Offset: 0x006861B7
		public IEnableClientFunctionT()
		{
			this.Type = EEnableClientFunctionType.HealthBarDisplay;
		}
	}
}
