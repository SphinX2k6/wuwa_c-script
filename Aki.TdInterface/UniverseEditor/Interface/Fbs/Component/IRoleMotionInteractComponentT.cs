using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587A RID: 22650
	public class IRoleMotionInteractComponentT
	{
		// Token: 0x1700A96A RID: 43370
		// (get) Token: 0x060262AA RID: 156330 RVA: 0x00543209 File Offset: 0x00541409
		// (set) Token: 0x060262AB RID: 156331 RVA: 0x00543211 File Offset: 0x00541411
		public bool Disabled { get; set; }

		// Token: 0x1700A96B RID: 43371
		// (get) Token: 0x060262AC RID: 156332 RVA: 0x0054321A File Offset: 0x0054141A
		// (set) Token: 0x060262AD RID: 156333 RVA: 0x00543222 File Offset: 0x00541422
		public IPetalGrabRoleMotionInteractT MotionInteractConfig { get; set; }

		// Token: 0x1700A96C RID: 43372
		// (get) Token: 0x060262AE RID: 156334 RVA: 0x0054322B File Offset: 0x0054142B
		// (set) Token: 0x060262AF RID: 156335 RVA: 0x00543233 File Offset: 0x00541433
		public byte NullMask { get; set; }

		// Token: 0x060262B0 RID: 156336 RVA: 0x0054323C File Offset: 0x0054143C
		public IRoleMotionInteractComponentT()
		{
			this.Disabled = false;
			this.MotionInteractConfig = null;
			this.NullMask = 0;
		}
	}
}
