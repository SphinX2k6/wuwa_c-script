using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200512E RID: 20782
	public class IHealthAttributeT
	{
		// Token: 0x170094EF RID: 38127
		// (get) Token: 0x06020AE9 RID: 133865 RVA: 0x00487626 File Offset: 0x00485826
		// (set) Token: 0x06020AEA RID: 133866 RVA: 0x0048762E File Offset: 0x0048582E
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x170094F0 RID: 38128
		// (get) Token: 0x06020AEB RID: 133867 RVA: 0x00487637 File Offset: 0x00485837
		// (set) Token: 0x06020AEC RID: 133868 RVA: 0x0048763F File Offset: 0x0048583F
		public ECompare Compare { get; set; }

		// Token: 0x170094F1 RID: 38129
		// (get) Token: 0x06020AED RID: 133869 RVA: 0x00487648 File Offset: 0x00485848
		// (set) Token: 0x06020AEE RID: 133870 RVA: 0x00487650 File Offset: 0x00485850
		public float Value { get; set; }

		// Token: 0x06020AEF RID: 133871 RVA: 0x00487659 File Offset: 0x00485859
		public IHealthAttributeT()
		{
			this.Type = EPlayerAttributeType.Health;
			this.Compare = ECompare.Eq;
			this.Value = 0f;
		}
	}
}
