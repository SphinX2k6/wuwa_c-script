using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B0 RID: 17328
	public class IParallaxPointPairT
	{
		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x0601886A RID: 100458 RVA: 0x0037E9CE File Offset: 0x0037CBCE
		// (set) Token: 0x0601886B RID: 100459 RVA: 0x0037E9D6 File Offset: 0x0037CBD6
		public IVectorInfoT SourcePos { get; set; }

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x0601886C RID: 100460 RVA: 0x0037E9DF File Offset: 0x0037CBDF
		// (set) Token: 0x0601886D RID: 100461 RVA: 0x0037E9E7 File Offset: 0x0037CBE7
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x0601886E RID: 100462 RVA: 0x0037E9F0 File Offset: 0x0037CBF0
		// (set) Token: 0x0601886F RID: 100463 RVA: 0x0037E9F8 File Offset: 0x0037CBF8
		public float ErrorRange { get; set; }

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x06018870 RID: 100464 RVA: 0x0037EA01 File Offset: 0x0037CC01
		// (set) Token: 0x06018871 RID: 100465 RVA: 0x0037EA09 File Offset: 0x0037CC09
		public byte NullMask { get; set; }

		// Token: 0x06018872 RID: 100466 RVA: 0x0037EA12 File Offset: 0x0037CC12
		public IParallaxPointPairT()
		{
			this.SourcePos = null;
			this.TargetPos = null;
			this.ErrorRange = 0f;
			this.NullMask = 0;
		}
	}
}
