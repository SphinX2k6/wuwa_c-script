using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DAA RID: 32170
	public class IVisualNovelPerformanceModifyRoleT
	{
		// Token: 0x1700F0D6 RID: 61654
		// (get) Token: 0x0603A1BC RID: 238012 RVA: 0x007D5693 File Offset: 0x007D3893
		// (set) Token: 0x0603A1BD RID: 238013 RVA: 0x007D569B File Offset: 0x007D389B
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0D7 RID: 61655
		// (get) Token: 0x0603A1BE RID: 238014 RVA: 0x007D56A4 File Offset: 0x007D38A4
		// (set) Token: 0x0603A1BF RID: 238015 RVA: 0x007D56AC File Offset: 0x007D38AC
		public float StartTime { get; set; }

		// Token: 0x1700F0D8 RID: 61656
		// (get) Token: 0x0603A1C0 RID: 238016 RVA: 0x007D56B5 File Offset: 0x007D38B5
		// (set) Token: 0x0603A1C1 RID: 238017 RVA: 0x007D56BD File Offset: 0x007D38BD
		public int WhoId { get; set; }

		// Token: 0x1700F0D9 RID: 61657
		// (get) Token: 0x0603A1C2 RID: 238018 RVA: 0x007D56C6 File Offset: 0x007D38C6
		// (set) Token: 0x0603A1C3 RID: 238019 RVA: 0x007D56CE File Offset: 0x007D38CE
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700F0DA RID: 61658
		// (get) Token: 0x0603A1C4 RID: 238020 RVA: 0x007D56D7 File Offset: 0x007D38D7
		// (set) Token: 0x0603A1C5 RID: 238021 RVA: 0x007D56DF File Offset: 0x007D38DF
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700F0DB RID: 61659
		// (get) Token: 0x0603A1C6 RID: 238022 RVA: 0x007D56E8 File Offset: 0x007D38E8
		// (set) Token: 0x0603A1C7 RID: 238023 RVA: 0x007D56F0 File Offset: 0x007D38F0
		public byte NullMask { get; set; }

		// Token: 0x0603A1C8 RID: 238024 RVA: 0x007D56F9 File Offset: 0x007D38F9
		public IVisualNovelPerformanceModifyRoleT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
