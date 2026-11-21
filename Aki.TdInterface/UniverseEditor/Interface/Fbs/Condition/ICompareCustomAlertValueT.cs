using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005071 RID: 20593
	public class ICompareCustomAlertValueT
	{
		// Token: 0x1700936A RID: 37738
		// (get) Token: 0x06020348 RID: 131912 RVA: 0x00476F48 File Offset: 0x00475148
		// (set) Token: 0x06020349 RID: 131913 RVA: 0x00476F50 File Offset: 0x00475150
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x1700936B RID: 37739
		// (get) Token: 0x0602034A RID: 131914 RVA: 0x00476F59 File Offset: 0x00475159
		// (set) Token: 0x0602034B RID: 131915 RVA: 0x00476F61 File Offset: 0x00475161
		public float CompareValue { get; set; }

		// Token: 0x0602034C RID: 131916 RVA: 0x00476F6A File Offset: 0x0047516A
		public ICompareCustomAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
			this.CompareValue = 0f;
		}
	}
}
