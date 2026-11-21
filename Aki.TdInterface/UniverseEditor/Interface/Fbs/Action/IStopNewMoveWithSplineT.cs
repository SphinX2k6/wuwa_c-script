using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B1 RID: 31153
	public class IStopNewMoveWithSplineT
	{
		// Token: 0x1700E47C RID: 58492
		// (get) Token: 0x06036E4A RID: 224842 RVA: 0x0075779B File Offset: 0x0075599B
		// (set) Token: 0x06036E4B RID: 224843 RVA: 0x007577A3 File Offset: 0x007559A3
		public TNewSplineStopTargetUnion StopTarget { get; set; }

		// Token: 0x1700E47D RID: 58493
		// (get) Token: 0x06036E4C RID: 224844 RVA: 0x007577AC File Offset: 0x007559AC
		// (set) Token: 0x06036E4D RID: 224845 RVA: 0x007577B4 File Offset: 0x007559B4
		public TStopNewMoveWithSplineTypeUnion StopType { get; set; }

		// Token: 0x06036E4E RID: 224846 RVA: 0x007577BD File Offset: 0x007559BD
		public IStopNewMoveWithSplineT()
		{
			this.StopTarget = null;
			this.StopType = null;
		}
	}
}
