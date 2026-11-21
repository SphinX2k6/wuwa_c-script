using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FEE RID: 24558
	public class IStreamingWaitConfigT
	{
		// Token: 0x1700B617 RID: 46615
		// (get) Token: 0x06029610 RID: 169488 RVA: 0x005A6030 File Offset: 0x005A4230
		// (set) Token: 0x06029611 RID: 169489 RVA: 0x005A6038 File Offset: 0x005A4238
		public float MinWaitStreamDuration { get; set; }

		// Token: 0x1700B618 RID: 46616
		// (get) Token: 0x06029612 RID: 169490 RVA: 0x005A6041 File Offset: 0x005A4241
		// (set) Token: 0x06029613 RID: 169491 RVA: 0x005A6049 File Offset: 0x005A4249
		public float MaxWaitStreamDuration { get; set; }

		// Token: 0x06029614 RID: 169492 RVA: 0x005A6052 File Offset: 0x005A4252
		public IStreamingWaitConfigT()
		{
			this.MinWaitStreamDuration = 0f;
			this.MaxWaitStreamDuration = 0f;
		}
	}
}
