using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B46 RID: 27462
	public class IControlTrackingSelfT
	{
		// Token: 0x1700C9AB RID: 51627
		// (get) Token: 0x0602F426 RID: 193574 RVA: 0x00673B7A File Offset: 0x00671D7A
		// (set) Token: 0x0602F427 RID: 193575 RVA: 0x00673B82 File Offset: 0x00671D82
		public EControlTrackingType Type { get; set; }

		// Token: 0x0602F428 RID: 193576 RVA: 0x00673B8B File Offset: 0x00671D8B
		public IControlTrackingSelfT()
		{
			this.Type = EControlTrackingType.Self;
		}
	}
}
