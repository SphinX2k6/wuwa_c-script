using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C11 RID: 19473
	public class IEllipseConeRangeT
	{
		// Token: 0x17008D70 RID: 36208
		// (get) Token: 0x0601ED77 RID: 126327 RVA: 0x0045170C File Offset: 0x0044F90C
		// (set) Token: 0x0601ED78 RID: 126328 RVA: 0x00451714 File Offset: 0x0044F914
		public float HorizontalAngle { get; set; }

		// Token: 0x17008D71 RID: 36209
		// (get) Token: 0x0601ED79 RID: 126329 RVA: 0x0045171D File Offset: 0x0044F91D
		// (set) Token: 0x0601ED7A RID: 126330 RVA: 0x00451725 File Offset: 0x0044F925
		public float VerticalAngle { get; set; }

		// Token: 0x0601ED7B RID: 126331 RVA: 0x0045172E File Offset: 0x0044F92E
		public IEllipseConeRangeT()
		{
			this.HorizontalAngle = 0f;
			this.VerticalAngle = 0f;
		}
	}
}
