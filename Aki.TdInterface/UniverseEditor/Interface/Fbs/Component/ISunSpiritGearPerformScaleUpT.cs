using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A02 RID: 23042
	public class ISunSpiritGearPerformScaleUpT
	{
		// Token: 0x1700AD1E RID: 44318
		// (get) Token: 0x060271B6 RID: 160182 RVA: 0x00561371 File Offset: 0x0055F571
		// (set) Token: 0x060271B7 RID: 160183 RVA: 0x00561379 File Offset: 0x0055F579
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x1700AD1F RID: 44319
		// (get) Token: 0x060271B8 RID: 160184 RVA: 0x00561382 File Offset: 0x0055F582
		// (set) Token: 0x060271B9 RID: 160185 RVA: 0x0056138A File Offset: 0x0055F58A
		public float Scale { get; set; }

		// Token: 0x1700AD20 RID: 44320
		// (get) Token: 0x060271BA RID: 160186 RVA: 0x00561393 File Offset: 0x0055F593
		// (set) Token: 0x060271BB RID: 160187 RVA: 0x0056139B File Offset: 0x0055F59B
		public IScaleUpSpiritPerformConfigT ScaleUpPerformConfig { get; set; }

		// Token: 0x060271BC RID: 160188 RVA: 0x005613A4 File Offset: 0x0055F5A4
		public ISunSpiritGearPerformScaleUpT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
			this.Scale = 0f;
			this.ScaleUpPerformConfig = null;
		}
	}
}
