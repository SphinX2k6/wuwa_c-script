using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B7B RID: 19323
	public class IClientEventTargetT
	{
		// Token: 0x17008C3B RID: 35899
		// (get) Token: 0x0601E73F RID: 124735 RVA: 0x0044397A File Offset: 0x00441B7A
		// (set) Token: 0x0601E740 RID: 124736 RVA: 0x00443982 File Offset: 0x00441B82
		public EClientEventTarget Type { get; set; }

		// Token: 0x0601E741 RID: 124737 RVA: 0x0044398B File Offset: 0x00441B8B
		public IClientEventTargetT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
