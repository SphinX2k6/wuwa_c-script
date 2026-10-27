using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B8A RID: 19338
	public class ICompareCustomAlertValueT
	{
		// Token: 0x17008C5A RID: 35930
		// (get) Token: 0x0601E7BA RID: 124858 RVA: 0x004446FC File Offset: 0x004428FC
		// (set) Token: 0x0601E7BB RID: 124859 RVA: 0x00444704 File Offset: 0x00442904
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x17008C5B RID: 35931
		// (get) Token: 0x0601E7BC RID: 124860 RVA: 0x0044470D File Offset: 0x0044290D
		// (set) Token: 0x0601E7BD RID: 124861 RVA: 0x00444715 File Offset: 0x00442915
		public float CompareValue { get; set; }

		// Token: 0x0601E7BE RID: 124862 RVA: 0x0044471E File Offset: 0x0044291E
		public ICompareCustomAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
			this.CompareValue = 0f;
		}
	}
}
