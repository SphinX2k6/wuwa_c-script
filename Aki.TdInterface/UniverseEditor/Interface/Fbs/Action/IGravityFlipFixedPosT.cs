using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3F RID: 28479
	public class IGravityFlipFixedPosT
	{
		// Token: 0x1700D0BC RID: 53436
		// (get) Token: 0x060314A0 RID: 201888 RVA: 0x006AD564 File Offset: 0x006AB764
		// (set) Token: 0x060314A1 RID: 201889 RVA: 0x006AD56C File Offset: 0x006AB76C
		public ETeleportType Type { get; set; }

		// Token: 0x1700D0BD RID: 53437
		// (get) Token: 0x060314A2 RID: 201890 RVA: 0x006AD575 File Offset: 0x006AB775
		// (set) Token: 0x060314A3 RID: 201891 RVA: 0x006AD57D File Offset: 0x006AB77D
		public int GravityAndPosEntityId { get; set; }

		// Token: 0x060314A4 RID: 201892 RVA: 0x006AD586 File Offset: 0x006AB786
		public IGravityFlipFixedPosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.GravityAndPosEntityId = 0;
		}
	}
}
