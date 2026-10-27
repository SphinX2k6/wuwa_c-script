using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF7 RID: 19191
	public class ICheckPlayerPositionT
	{
		// Token: 0x17008B2A RID: 35626
		// (get) Token: 0x0601E29B RID: 123547 RVA: 0x0043ADED File Offset: 0x00438FED
		// (set) Token: 0x0601E29C RID: 123548 RVA: 0x0043ADF5 File Offset: 0x00438FF5
		public ECondition Type { get; set; }

		// Token: 0x17008B2B RID: 35627
		// (get) Token: 0x0601E29D RID: 123549 RVA: 0x0043ADFE File Offset: 0x00438FFE
		// (set) Token: 0x0601E29E RID: 123550 RVA: 0x0043AE06 File Offset: 0x00439006
		public TRangeUnion Range { get; set; }

		// Token: 0x17008B2C RID: 35628
		// (get) Token: 0x0601E29F RID: 123551 RVA: 0x0043AE0F File Offset: 0x0043900F
		// (set) Token: 0x0601E2A0 RID: 123552 RVA: 0x0043AE17 File Offset: 0x00439017
		public bool IsOnRange { get; set; }

		// Token: 0x0601E2A1 RID: 123553 RVA: 0x0043AE20 File Offset: 0x00439020
		public ICheckPlayerPositionT()
		{
			this.Type = ECondition.CompareVar;
			this.Range = null;
			this.IsOnRange = false;
		}
	}
}
