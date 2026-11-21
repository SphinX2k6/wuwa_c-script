using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B85 RID: 31621
	public class ITeleportTransitionInDigitalScreenT
	{
		// Token: 0x1700ECB2 RID: 60594
		// (get) Token: 0x06038F18 RID: 233240 RVA: 0x007B250C File Offset: 0x007B070C
		// (set) Token: 0x06038F19 RID: 233241 RVA: 0x007B2514 File Offset: 0x007B0714
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECB3 RID: 60595
		// (get) Token: 0x06038F1A RID: 233242 RVA: 0x007B251D File Offset: 0x007B071D
		// (set) Token: 0x06038F1B RID: 233243 RVA: 0x007B2525 File Offset: 0x007B0725
		public int ConfigId { get; set; }

		// Token: 0x06038F1C RID: 233244 RVA: 0x007B252E File Offset: 0x007B072E
		public ITeleportTransitionInDigitalScreenT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ConfigId = 0;
		}
	}
}
