using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006437 RID: 25655
	public class ICloseSplineMoveT
	{
		// Token: 0x1700BF09 RID: 48905
		// (get) Token: 0x0602C674 RID: 181876 RVA: 0x00617AB5 File Offset: 0x00615CB5
		// (set) Token: 0x0602C675 RID: 181877 RVA: 0x00617ABD File Offset: 0x00615CBD
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700BF0A RID: 48906
		// (get) Token: 0x0602C676 RID: 181878 RVA: 0x00617AC6 File Offset: 0x00615CC6
		// (set) Token: 0x0602C677 RID: 181879 RVA: 0x00617ACE File Offset: 0x00615CCE
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700BF0B RID: 48907
		// (get) Token: 0x0602C678 RID: 181880 RVA: 0x00617AD7 File Offset: 0x00615CD7
		// (set) Token: 0x0602C679 RID: 181881 RVA: 0x00617ADF File Offset: 0x00615CDF
		public int SplineEntityId { get; set; }

		// Token: 0x0602C67A RID: 181882 RVA: 0x00617AE8 File Offset: 0x00615CE8
		public ICloseSplineMoveT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
		}
	}
}
