using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A7 RID: 27047
	public class IChangeTimerUiConfigT
	{
		// Token: 0x1700C715 RID: 50965
		// (get) Token: 0x0602E654 RID: 190036 RVA: 0x0065500A File Offset: 0x0065320A
		// (set) Token: 0x0602E655 RID: 190037 RVA: 0x00655012 File Offset: 0x00653212
		public EChangeTimerUiType UiType { get; set; }

		// Token: 0x0602E656 RID: 190038 RVA: 0x0065501B File Offset: 0x0065321B
		public IChangeTimerUiConfigT()
		{
			this.UiType = EChangeTimerUiType.None;
		}
	}
}
