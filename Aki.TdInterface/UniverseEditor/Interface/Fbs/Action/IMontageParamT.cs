using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B01 RID: 27393
	public class IMontageParamT
	{
		// Token: 0x1700CB5F RID: 52063
		// (get) Token: 0x060300AC RID: 196780 RVA: 0x006881F5 File Offset: 0x006863F5
		// (set) Token: 0x060300AD RID: 196781 RVA: 0x006881FD File Offset: 0x006863FD
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700CB60 RID: 52064
		// (get) Token: 0x060300AE RID: 196782 RVA: 0x00688206 File Offset: 0x00686406
		// (set) Token: 0x060300AF RID: 196783 RVA: 0x0068820E File Offset: 0x0068640E
		public bool IsLoop { get; set; }

		// Token: 0x1700CB61 RID: 52065
		// (get) Token: 0x060300B0 RID: 196784 RVA: 0x00688217 File Offset: 0x00686417
		// (set) Token: 0x060300B1 RID: 196785 RVA: 0x0068821F File Offset: 0x0068641F
		public bool KeepPose { get; set; }

		// Token: 0x1700CB62 RID: 52066
		// (get) Token: 0x060300B2 RID: 196786 RVA: 0x00688228 File Offset: 0x00686428
		// (set) Token: 0x060300B3 RID: 196787 RVA: 0x00688230 File Offset: 0x00686430
		public float DelayTime { get; set; }

		// Token: 0x1700CB63 RID: 52067
		// (get) Token: 0x060300B4 RID: 196788 RVA: 0x00688239 File Offset: 0x00686439
		// (set) Token: 0x060300B5 RID: 196789 RVA: 0x00688241 File Offset: 0x00686441
		public byte NullMask { get; set; }

		// Token: 0x060300B6 RID: 196790 RVA: 0x0068824A File Offset: 0x0068644A
		public IMontageParamT()
		{
			this.MontageId = null;
			this.IsLoop = false;
			this.KeepPose = false;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
