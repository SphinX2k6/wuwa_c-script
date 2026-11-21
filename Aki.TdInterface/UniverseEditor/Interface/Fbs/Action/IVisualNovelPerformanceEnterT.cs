using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9E RID: 32158
	public class IVisualNovelPerformanceEnterT
	{
		// Token: 0x1700F0A1 RID: 61601
		// (get) Token: 0x0603A11A RID: 237850 RVA: 0x007D4065 File Offset: 0x007D2265
		// (set) Token: 0x0603A11B RID: 237851 RVA: 0x007D406D File Offset: 0x007D226D
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0A2 RID: 61602
		// (get) Token: 0x0603A11C RID: 237852 RVA: 0x007D4076 File Offset: 0x007D2276
		// (set) Token: 0x0603A11D RID: 237853 RVA: 0x007D407E File Offset: 0x007D227E
		public float StartTime { get; set; }

		// Token: 0x1700F0A3 RID: 61603
		// (get) Token: 0x0603A11E RID: 237854 RVA: 0x007D4087 File Offset: 0x007D2287
		// (set) Token: 0x0603A11F RID: 237855 RVA: 0x007D408F File Offset: 0x007D228F
		public int WhoId { get; set; }

		// Token: 0x1700F0A4 RID: 61604
		// (get) Token: 0x0603A120 RID: 237856 RVA: 0x007D4098 File Offset: 0x007D2298
		// (set) Token: 0x0603A121 RID: 237857 RVA: 0x007D40A0 File Offset: 0x007D22A0
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700F0A5 RID: 61605
		// (get) Token: 0x0603A122 RID: 237858 RVA: 0x007D40A9 File Offset: 0x007D22A9
		// (set) Token: 0x0603A123 RID: 237859 RVA: 0x007D40B1 File Offset: 0x007D22B1
		public float FadeInTime { get; set; }

		// Token: 0x1700F0A6 RID: 61606
		// (get) Token: 0x0603A124 RID: 237860 RVA: 0x007D40BA File Offset: 0x007D22BA
		// (set) Token: 0x0603A125 RID: 237861 RVA: 0x007D40C2 File Offset: 0x007D22C2
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700F0A7 RID: 61607
		// (get) Token: 0x0603A126 RID: 237862 RVA: 0x007D40CB File Offset: 0x007D22CB
		// (set) Token: 0x0603A127 RID: 237863 RVA: 0x007D40D3 File Offset: 0x007D22D3
		public byte NullMask { get; set; }

		// Token: 0x0603A128 RID: 237864 RVA: 0x007D40DC File Offset: 0x007D22DC
		public IVisualNovelPerformanceEnterT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.FadeInTime = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
