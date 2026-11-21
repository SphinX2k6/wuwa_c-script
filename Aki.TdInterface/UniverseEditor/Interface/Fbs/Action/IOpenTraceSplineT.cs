using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AD RID: 29613
	public class IOpenTraceSplineT
	{
		// Token: 0x1700D987 RID: 55687
		// (get) Token: 0x06033C95 RID: 212117 RVA: 0x006FC422 File Offset: 0x006FA622
		// (set) Token: 0x06033C96 RID: 212118 RVA: 0x006FC42A File Offset: 0x006FA62A
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x1700D988 RID: 55688
		// (get) Token: 0x06033C97 RID: 212119 RVA: 0x006FC433 File Offset: 0x006FA633
		// (set) Token: 0x06033C98 RID: 212120 RVA: 0x006FC43B File Offset: 0x006FA63B
		public int SplineEntityId { get; set; }

		// Token: 0x1700D989 RID: 55689
		// (get) Token: 0x06033C99 RID: 212121 RVA: 0x006FC444 File Offset: 0x006FA644
		// (set) Token: 0x06033C9A RID: 212122 RVA: 0x006FC44C File Offset: 0x006FA64C
		public float Duration { get; set; }

		// Token: 0x06033C9B RID: 212123 RVA: 0x006FC455 File Offset: 0x006FA655
		public IOpenTraceSplineT()
		{
			this.Type = ETraceSplineOptionType.Open;
			this.SplineEntityId = 0;
			this.Duration = 0f;
		}
	}
}
