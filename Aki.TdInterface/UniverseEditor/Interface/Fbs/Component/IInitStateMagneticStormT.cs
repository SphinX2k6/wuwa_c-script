using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AC RID: 22956
	public class IInitStateMagneticStormT
	{
		// Token: 0x1700A6AB RID: 42667
		// (get) Token: 0x060256D1 RID: 153297 RVA: 0x0052242E File Offset: 0x0052062E
		// (set) Token: 0x060256D2 RID: 153298 RVA: 0x00522436 File Offset: 0x00520636
		public EInitStateType Type { get; set; }

		// Token: 0x060256D3 RID: 153299 RVA: 0x0052243F File Offset: 0x0052063F
		public IInitStateMagneticStormT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
