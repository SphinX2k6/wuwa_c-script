using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D8 RID: 25816
	public class IControlTrackingOtherT
	{
		// Token: 0x1700C01A RID: 49178
		// (get) Token: 0x0602CC8E RID: 183438 RVA: 0x006278B7 File Offset: 0x00625AB7
		// (set) Token: 0x0602CC8F RID: 183439 RVA: 0x006278BF File Offset: 0x00625ABF
		public EControlTrackingType Type { get; set; }

		// Token: 0x1700C01B RID: 49179
		// (get) Token: 0x0602CC90 RID: 183440 RVA: 0x006278C8 File Offset: 0x00625AC8
		// (set) Token: 0x0602CC91 RID: 183441 RVA: 0x006278D0 File Offset: 0x00625AD0
		public List<int> Entities { get; set; }

		// Token: 0x0602CC92 RID: 183442 RVA: 0x006278D9 File Offset: 0x00625AD9
		public IControlTrackingOtherT()
		{
			this.Type = EControlTrackingType.Self;
			this.Entities = null;
		}
	}
}
