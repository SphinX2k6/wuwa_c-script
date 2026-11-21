using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DAD RID: 32173
	public class IVisualNovelPerformanceMoveT
	{
		// Token: 0x1700F0E5 RID: 61669
		// (get) Token: 0x0603A1EA RID: 238058 RVA: 0x007D5E14 File Offset: 0x007D4014
		// (set) Token: 0x0603A1EB RID: 238059 RVA: 0x007D5E1C File Offset: 0x007D401C
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0E6 RID: 61670
		// (get) Token: 0x0603A1EC RID: 238060 RVA: 0x007D5E25 File Offset: 0x007D4025
		// (set) Token: 0x0603A1ED RID: 238061 RVA: 0x007D5E2D File Offset: 0x007D402D
		public float StartTime { get; set; }

		// Token: 0x1700F0E7 RID: 61671
		// (get) Token: 0x0603A1EE RID: 238062 RVA: 0x007D5E36 File Offset: 0x007D4036
		// (set) Token: 0x0603A1EF RID: 238063 RVA: 0x007D5E3E File Offset: 0x007D403E
		public int WhoId { get; set; }

		// Token: 0x1700F0E8 RID: 61672
		// (get) Token: 0x0603A1F0 RID: 238064 RVA: 0x007D5E47 File Offset: 0x007D4047
		// (set) Token: 0x0603A1F1 RID: 238065 RVA: 0x007D5E4F File Offset: 0x007D404F
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700F0E9 RID: 61673
		// (get) Token: 0x0603A1F2 RID: 238066 RVA: 0x007D5E58 File Offset: 0x007D4058
		// (set) Token: 0x0603A1F3 RID: 238067 RVA: 0x007D5E60 File Offset: 0x007D4060
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700F0EA RID: 61674
		// (get) Token: 0x0603A1F4 RID: 238068 RVA: 0x007D5E69 File Offset: 0x007D4069
		// (set) Token: 0x0603A1F5 RID: 238069 RVA: 0x007D5E71 File Offset: 0x007D4071
		public float Duration { get; set; }

		// Token: 0x1700F0EB RID: 61675
		// (get) Token: 0x0603A1F6 RID: 238070 RVA: 0x007D5E7A File Offset: 0x007D407A
		// (set) Token: 0x0603A1F7 RID: 238071 RVA: 0x007D5E82 File Offset: 0x007D4082
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700F0EC RID: 61676
		// (get) Token: 0x0603A1F8 RID: 238072 RVA: 0x007D5E8B File Offset: 0x007D408B
		// (set) Token: 0x0603A1F9 RID: 238073 RVA: 0x007D5E93 File Offset: 0x007D4093
		public byte NullMask { get; set; }

		// Token: 0x0603A1FA RID: 238074 RVA: 0x007D5E9C File Offset: 0x007D409C
		public IVisualNovelPerformanceMoveT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.EaseCurve = null;
			this.Duration = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
