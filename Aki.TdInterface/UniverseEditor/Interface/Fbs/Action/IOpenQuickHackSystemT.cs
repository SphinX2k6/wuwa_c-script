using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738F RID: 29583
	public class IOpenQuickHackSystemT
	{
		// Token: 0x1700D90C RID: 55564
		// (get) Token: 0x06033A89 RID: 211593 RVA: 0x006F69C7 File Offset: 0x006F4BC7
		// (set) Token: 0x06033A8A RID: 211594 RVA: 0x006F69CF File Offset: 0x006F4BCF
		public int DeviceId { get; set; }

		// Token: 0x1700D90D RID: 55565
		// (get) Token: 0x06033A8B RID: 211595 RVA: 0x006F69D8 File Offset: 0x006F4BD8
		// (set) Token: 0x06033A8C RID: 211596 RVA: 0x006F69E0 File Offset: 0x006F4BE0
		public List<int> Entities { get; set; }

		// Token: 0x1700D90E RID: 55566
		// (get) Token: 0x06033A8D RID: 211597 RVA: 0x006F69E9 File Offset: 0x006F4BE9
		// (set) Token: 0x06033A8E RID: 211598 RVA: 0x006F69F1 File Offset: 0x006F4BF1
		public IOpenQuickHackCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700D90F RID: 55567
		// (get) Token: 0x06033A8F RID: 211599 RVA: 0x006F69FA File Offset: 0x006F4BFA
		// (set) Token: 0x06033A90 RID: 211600 RVA: 0x006F6A02 File Offset: 0x006F4C02
		public byte NullMask { get; set; }

		// Token: 0x06033A91 RID: 211601 RVA: 0x006F6A0B File Offset: 0x006F4C0B
		public IOpenQuickHackSystemT()
		{
			this.DeviceId = 0;
			this.Entities = null;
			this.CameraConfig = null;
			this.NullMask = 0;
		}
	}
}
