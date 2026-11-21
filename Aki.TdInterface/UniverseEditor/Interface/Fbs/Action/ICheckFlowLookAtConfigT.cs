using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D0 RID: 27088
	public class ICheckFlowLookAtConfigT
	{
		// Token: 0x1700C756 RID: 51030
		// (get) Token: 0x0602E799 RID: 190361 RVA: 0x00657642 File Offset: 0x00655842
		// (set) Token: 0x0602E79A RID: 190362 RVA: 0x0065764A File Offset: 0x0065584A
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700C757 RID: 51031
		// (get) Token: 0x0602E79B RID: 190363 RVA: 0x00657653 File Offset: 0x00655853
		// (set) Token: 0x0602E79C RID: 190364 RVA: 0x0065765B File Offset: 0x0065585B
		public TCheckFlowLookAtTargetUnion Target { get; set; }

		// Token: 0x1700C758 RID: 51032
		// (get) Token: 0x0602E79D RID: 190365 RVA: 0x00657664 File Offset: 0x00655864
		// (set) Token: 0x0602E79E RID: 190366 RVA: 0x0065766C File Offset: 0x0065586C
		public IEntityLookAtPerformT EntityLookAtPerform { get; set; }

		// Token: 0x0602E79F RID: 190367 RVA: 0x00657675 File Offset: 0x00655875
		public ICheckFlowLookAtConfigT()
		{
			this.Flow = null;
			this.Target = null;
			this.EntityLookAtPerform = null;
		}
	}
}
