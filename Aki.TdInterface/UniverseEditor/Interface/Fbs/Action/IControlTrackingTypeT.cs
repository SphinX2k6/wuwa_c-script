using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B49 RID: 27465
	public class IControlTrackingTypeT
	{
		// Token: 0x1700C9AE RID: 51630
		// (get) Token: 0x0602F438 RID: 193592 RVA: 0x00673CF2 File Offset: 0x00671EF2
		// (set) Token: 0x0602F439 RID: 193593 RVA: 0x00673CFA File Offset: 0x00671EFA
		public EControlTrackingType Type { get; set; }

		// Token: 0x0602F43A RID: 193594 RVA: 0x00673D03 File Offset: 0x00671F03
		public IControlTrackingTypeT()
		{
			this.Type = EControlTrackingType.Self;
		}
	}
}
