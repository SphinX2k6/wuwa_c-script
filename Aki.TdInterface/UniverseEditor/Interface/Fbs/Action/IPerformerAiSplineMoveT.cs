using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F5 RID: 29685
	public class IPerformerAiSplineMoveT
	{
		// Token: 0x1700DA0D RID: 55821
		// (get) Token: 0x06033EE4 RID: 212708 RVA: 0x00700594 File Offset: 0x006FE794
		// (set) Token: 0x06033EE5 RID: 212709 RVA: 0x0070059C File Offset: 0x006FE79C
		public int SplineEntityId { get; set; }

		// Token: 0x1700DA0E RID: 55822
		// (get) Token: 0x06033EE6 RID: 212710 RVA: 0x007005A5 File Offset: 0x006FE7A5
		// (set) Token: 0x06033EE7 RID: 212711 RVA: 0x007005AD File Offset: 0x006FE7AD
		public byte NullMask { get; set; }

		// Token: 0x06033EE8 RID: 212712 RVA: 0x007005B6 File Offset: 0x006FE7B6
		public IPerformerAiSplineMoveT()
		{
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
