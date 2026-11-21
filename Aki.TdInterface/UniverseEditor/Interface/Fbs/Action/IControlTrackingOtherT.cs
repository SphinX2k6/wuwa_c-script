using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B43 RID: 27459
	public class IControlTrackingOtherT
	{
		// Token: 0x1700C9A7 RID: 51623
		// (get) Token: 0x0602F412 RID: 193554 RVA: 0x006739DF File Offset: 0x00671BDF
		// (set) Token: 0x0602F413 RID: 193555 RVA: 0x006739E7 File Offset: 0x00671BE7
		public EControlTrackingType Type { get; set; }

		// Token: 0x1700C9A8 RID: 51624
		// (get) Token: 0x0602F414 RID: 193556 RVA: 0x006739F0 File Offset: 0x00671BF0
		// (set) Token: 0x0602F415 RID: 193557 RVA: 0x006739F8 File Offset: 0x00671BF8
		public List<int> Entities { get; set; }

		// Token: 0x0602F416 RID: 193558 RVA: 0x00673A01 File Offset: 0x00671C01
		public IControlTrackingOtherT()
		{
			this.Type = EControlTrackingType.Self;
			this.Entities = null;
		}
	}
}
