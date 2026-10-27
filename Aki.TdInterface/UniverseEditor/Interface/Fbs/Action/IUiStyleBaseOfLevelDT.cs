using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AC RID: 29868
	public class IUiStyleBaseOfLevelDT
	{
		// Token: 0x1700E2BA RID: 58042
		// (get) Token: 0x060364DC RID: 222428 RVA: 0x0076179E File Offset: 0x0075F99E
		// (set) Token: 0x060364DD RID: 222429 RVA: 0x007617A6 File Offset: 0x0075F9A6
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x060364DE RID: 222430 RVA: 0x007617AF File Offset: 0x0075F9AF
		public IUiStyleBaseOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
		}
	}
}
