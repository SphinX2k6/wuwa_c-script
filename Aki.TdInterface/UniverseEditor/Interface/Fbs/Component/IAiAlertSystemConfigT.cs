using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E75 RID: 20085
	public class IAiAlertSystemConfigT
	{
		// Token: 0x17008FD5 RID: 36821
		// (get) Token: 0x0601F8EC RID: 129260 RVA: 0x004650AE File Offset: 0x004632AE
		// (set) Token: 0x0601F8ED RID: 129261 RVA: 0x004650B6 File Offset: 0x004632B6
		public int AreaId { get; set; }

		// Token: 0x17008FD6 RID: 36822
		// (get) Token: 0x0601F8EE RID: 129262 RVA: 0x004650BF File Offset: 0x004632BF
		// (set) Token: 0x0601F8EF RID: 129263 RVA: 0x004650C7 File Offset: 0x004632C7
		public float PlayerHatredDeltaValue { get; set; }

		// Token: 0x17008FD7 RID: 36823
		// (get) Token: 0x0601F8F0 RID: 129264 RVA: 0x004650D0 File Offset: 0x004632D0
		// (set) Token: 0x0601F8F1 RID: 129265 RVA: 0x004650D8 File Offset: 0x004632D8
		public byte NullMask { get; set; }

		// Token: 0x0601F8F2 RID: 129266 RVA: 0x004650E1 File Offset: 0x004632E1
		public IAiAlertSystemConfigT()
		{
			this.AreaId = 0;
			this.PlayerHatredDeltaValue = 0f;
			this.NullMask = 0;
		}
	}
}
