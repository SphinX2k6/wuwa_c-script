using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B8D RID: 19341
	public class IComparedAlertValueTypeT
	{
		// Token: 0x17008C5E RID: 35934
		// (get) Token: 0x0601E7CE RID: 124878 RVA: 0x0044489E File Offset: 0x00442A9E
		// (set) Token: 0x0601E7CF RID: 124879 RVA: 0x004448A6 File Offset: 0x00442AA6
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x0601E7D0 RID: 124880 RVA: 0x004448AF File Offset: 0x00442AAF
		public IComparedAlertValueTypeT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
