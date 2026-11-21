using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743D RID: 29757
	public class IPhotographPlayerPerformT
	{
		// Token: 0x1700DA8E RID: 55950
		// (get) Token: 0x06034118 RID: 213272 RVA: 0x007042CE File Offset: 0x007024CE
		// (set) Token: 0x06034119 RID: 213273 RVA: 0x007042D6 File Offset: 0x007024D6
		public int MontageId { get; set; }

		// Token: 0x1700DA8F RID: 55951
		// (get) Token: 0x0603411A RID: 213274 RVA: 0x007042DF File Offset: 0x007024DF
		// (set) Token: 0x0603411B RID: 213275 RVA: 0x007042E7 File Offset: 0x007024E7
		public int FaceId { get; set; }

		// Token: 0x1700DA90 RID: 55952
		// (get) Token: 0x0603411C RID: 213276 RVA: 0x007042F0 File Offset: 0x007024F0
		// (set) Token: 0x0603411D RID: 213277 RVA: 0x007042F8 File Offset: 0x007024F8
		public byte NullMask { get; set; }

		// Token: 0x0603411E RID: 213278 RVA: 0x00704301 File Offset: 0x00702501
		public IPhotographPlayerPerformT()
		{
			this.MontageId = 0;
			this.FaceId = 0;
			this.NullMask = 0;
		}
	}
}
