using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E16 RID: 28182
	public class IFadeOutScreenT
	{
		// Token: 0x1700CE91 RID: 52881
		// (get) Token: 0x06030A94 RID: 199316 RVA: 0x0069B011 File Offset: 0x00699211
		// (set) Token: 0x06030A95 RID: 199317 RVA: 0x0069B019 File Offset: 0x00699219
		public IEaseDataT Ease { get; set; }

		// Token: 0x1700CE92 RID: 52882
		// (get) Token: 0x06030A96 RID: 199318 RVA: 0x0069B022 File Offset: 0x00699222
		// (set) Token: 0x06030A97 RID: 199319 RVA: 0x0069B02A File Offset: 0x0069922A
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700CE93 RID: 52883
		// (get) Token: 0x06030A98 RID: 199320 RVA: 0x0069B033 File Offset: 0x00699233
		// (set) Token: 0x06030A99 RID: 199321 RVA: 0x0069B03B File Offset: 0x0069923B
		public byte NullMask { get; set; }

		// Token: 0x06030A9A RID: 199322 RVA: 0x0069B044 File Offset: 0x00699244
		public IFadeOutScreenT()
		{
			this.Ease = null;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
