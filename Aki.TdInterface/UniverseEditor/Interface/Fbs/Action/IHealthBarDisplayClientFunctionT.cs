using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F90 RID: 28560
	public class IHealthBarDisplayClientFunctionT
	{
		// Token: 0x1700D127 RID: 53543
		// (get) Token: 0x060316EE RID: 202478 RVA: 0x006B3A6A File Offset: 0x006B1C6A
		// (set) Token: 0x060316EF RID: 202479 RVA: 0x006B3A72 File Offset: 0x006B1C72
		public EEnableClientFunctionType Type { get; set; }

		// Token: 0x1700D128 RID: 53544
		// (get) Token: 0x060316F0 RID: 202480 RVA: 0x006B3A7B File Offset: 0x006B1C7B
		// (set) Token: 0x060316F1 RID: 202481 RVA: 0x006B3A83 File Offset: 0x006B1C83
		public int EntityId { get; set; }

		// Token: 0x1700D129 RID: 53545
		// (get) Token: 0x060316F2 RID: 202482 RVA: 0x006B3A8C File Offset: 0x006B1C8C
		// (set) Token: 0x060316F3 RID: 202483 RVA: 0x006B3A94 File Offset: 0x006B1C94
		public bool IsVisible { get; set; }

		// Token: 0x060316F4 RID: 202484 RVA: 0x006B3A9D File Offset: 0x006B1C9D
		public IHealthBarDisplayClientFunctionT()
		{
			this.Type = EEnableClientFunctionType.HealthBarDisplay;
			this.EntityId = 0;
			this.IsVisible = false;
		}
	}
}
