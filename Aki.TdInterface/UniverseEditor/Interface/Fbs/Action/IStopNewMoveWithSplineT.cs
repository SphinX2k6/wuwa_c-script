using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DC RID: 29148
	public class IStopNewMoveWithSplineT
	{
		// Token: 0x1700D883 RID: 55427
		// (get) Token: 0x06033B48 RID: 211784 RVA: 0x006F643B File Offset: 0x006F463B
		// (set) Token: 0x06033B49 RID: 211785 RVA: 0x006F6443 File Offset: 0x006F4643
		public TNewSplineStopTargetUnion StopTarget { get; set; }

		// Token: 0x1700D884 RID: 55428
		// (get) Token: 0x06033B4A RID: 211786 RVA: 0x006F644C File Offset: 0x006F464C
		// (set) Token: 0x06033B4B RID: 211787 RVA: 0x006F6454 File Offset: 0x006F4654
		public TStopNewMoveWithSplineTypeUnion StopType { get; set; }

		// Token: 0x06033B4C RID: 211788 RVA: 0x006F645D File Offset: 0x006F465D
		public IStopNewMoveWithSplineT()
		{
			this.StopTarget = null;
			this.StopType = null;
		}
	}
}
