using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A02 RID: 18946
	public class IRollBlockItemLaserEmitterT
	{
		// Token: 0x170084D8 RID: 34008
		// (get) Token: 0x0601C690 RID: 116368 RVA: 0x0040356E File Offset: 0x0040176E
		// (set) Token: 0x0601C691 RID: 116369 RVA: 0x00403576 File Offset: 0x00401776
		public ERollBlockItemType Type { get; set; }

		// Token: 0x170084D9 RID: 34009
		// (get) Token: 0x0601C692 RID: 116370 RVA: 0x0040357F File Offset: 0x0040177F
		// (set) Token: 0x0601C693 RID: 116371 RVA: 0x00403587 File Offset: 0x00401787
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x170084DA RID: 34010
		// (get) Token: 0x0601C694 RID: 116372 RVA: 0x00403590 File Offset: 0x00401790
		// (set) Token: 0x0601C695 RID: 116373 RVA: 0x00403598 File Offset: 0x00401798
		public int Length { get; set; }

		// Token: 0x170084DB RID: 34011
		// (get) Token: 0x0601C696 RID: 116374 RVA: 0x004035A1 File Offset: 0x004017A1
		// (set) Token: 0x0601C697 RID: 116375 RVA: 0x004035A9 File Offset: 0x004017A9
		public int Height { get; set; }

		// Token: 0x170084DC RID: 34012
		// (get) Token: 0x0601C698 RID: 116376 RVA: 0x004035B2 File Offset: 0x004017B2
		// (set) Token: 0x0601C699 RID: 116377 RVA: 0x004035BA File Offset: 0x004017BA
		public byte NullMask { get; set; }

		// Token: 0x0601C69A RID: 116378 RVA: 0x004035C3 File Offset: 0x004017C3
		public IRollBlockItemLaserEmitterT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.Direction = ERollBlockLayType.Left;
			this.Length = 0;
			this.Height = 0;
			this.NullMask = 0;
		}
	}
}
