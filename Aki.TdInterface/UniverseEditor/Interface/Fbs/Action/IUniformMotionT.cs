using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B8 RID: 29880
	public class IUniformMotionT
	{
		// Token: 0x1700E2D0 RID: 58064
		// (get) Token: 0x06036536 RID: 222518 RVA: 0x0076218C File Offset: 0x0076038C
		// (set) Token: 0x06036537 RID: 222519 RVA: 0x00762194 File Offset: 0x00760394
		public EMoveMotion Type { get; set; }

		// Token: 0x1700E2D1 RID: 58065
		// (get) Token: 0x06036538 RID: 222520 RVA: 0x0076219D File Offset: 0x0076039D
		// (set) Token: 0x06036539 RID: 222521 RVA: 0x007621A5 File Offset: 0x007603A5
		public float Time { get; set; }

		// Token: 0x0603653A RID: 222522 RVA: 0x007621AE File Offset: 0x007603AE
		public IUniformMotionT()
		{
			this.Type = EMoveMotion.UniformMotion;
			this.Time = 0f;
		}
	}
}
