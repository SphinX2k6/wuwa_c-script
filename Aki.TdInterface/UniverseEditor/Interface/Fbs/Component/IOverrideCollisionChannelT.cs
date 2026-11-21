using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C52 RID: 23634
	public class IOverrideCollisionChannelT
	{
		// Token: 0x1700AD9C RID: 44444
		// (get) Token: 0x060272FD RID: 160509 RVA: 0x0055E3FA File Offset: 0x0055C5FA
		// (set) Token: 0x060272FE RID: 160510 RVA: 0x0055E402 File Offset: 0x0055C602
		public ECollisionChannelPreset CollisionChannelPreset { get; set; }

		// Token: 0x1700AD9D RID: 44445
		// (get) Token: 0x060272FF RID: 160511 RVA: 0x0055E40B File Offset: 0x0055C60B
		// (set) Token: 0x06027300 RID: 160512 RVA: 0x0055E413 File Offset: 0x0055C613
		public float BlurResponseRadius { get; set; }

		// Token: 0x1700AD9E RID: 44446
		// (get) Token: 0x06027301 RID: 160513 RVA: 0x0055E41C File Offset: 0x0055C61C
		// (set) Token: 0x06027302 RID: 160514 RVA: 0x0055E424 File Offset: 0x0055C624
		public byte NullMask { get; set; }

		// Token: 0x06027303 RID: 160515 RVA: 0x0055E42D File Offset: 0x0055C62D
		public IOverrideCollisionChannelT()
		{
			this.CollisionChannelPreset = ECollisionChannelPreset.CanBePassedThrough;
			this.BlurResponseRadius = 0f;
			this.NullMask = 0;
		}
	}
}
