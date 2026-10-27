using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006398 RID: 25496
	public class IClientEventFlyingFlowerEventT
	{
		// Token: 0x1700BE1B RID: 48667
		// (get) Token: 0x0602C1CD RID: 180685 RVA: 0x0060F216 File Offset: 0x0060D416
		// (set) Token: 0x0602C1CE RID: 180686 RVA: 0x0060F21E File Offset: 0x0060D41E
		public EClientEventFlyingFlowerEventType Type { get; set; }

		// Token: 0x0602C1CF RID: 180687 RVA: 0x0060F227 File Offset: 0x0060D427
		public IClientEventFlyingFlowerEventT()
		{
			this.Type = EClientEventFlyingFlowerEventType.UpdateSubtitle;
		}
	}
}
