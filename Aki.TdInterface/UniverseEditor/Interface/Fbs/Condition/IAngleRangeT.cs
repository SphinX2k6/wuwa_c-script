using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E22 RID: 20002
	public class IAngleRangeT
	{
		// Token: 0x17008E84 RID: 36484
		// (get) Token: 0x0601EED7 RID: 126679 RVA: 0x00452314 File Offset: 0x00450514
		// (set) Token: 0x0601EED8 RID: 126680 RVA: 0x0045231C File Offset: 0x0045051C
		public float Min { get; set; }

		// Token: 0x17008E85 RID: 36485
		// (get) Token: 0x0601EED9 RID: 126681 RVA: 0x00452325 File Offset: 0x00450525
		// (set) Token: 0x0601EEDA RID: 126682 RVA: 0x0045232D File Offset: 0x0045052D
		public float Max { get; set; }

		// Token: 0x0601EEDB RID: 126683 RVA: 0x00452336 File Offset: 0x00450536
		public IAngleRangeT()
		{
			this.Min = 0f;
			this.Max = 0f;
		}
	}
}
