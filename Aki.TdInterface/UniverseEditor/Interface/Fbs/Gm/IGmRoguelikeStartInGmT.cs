using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ACF RID: 19151
	public class IGmRoguelikeStartInGmT
	{
		// Token: 0x17008634 RID: 34356
		// (get) Token: 0x0601CD70 RID: 118128 RVA: 0x0040FC46 File Offset: 0x0040DE46
		// (set) Token: 0x0601CD71 RID: 118129 RVA: 0x0040FC4E File Offset: 0x0040DE4E
		public EGmCommand Type { get; set; }

		// Token: 0x17008635 RID: 34357
		// (get) Token: 0x0601CD72 RID: 118130 RVA: 0x0040FC57 File Offset: 0x0040DE57
		// (set) Token: 0x0601CD73 RID: 118131 RVA: 0x0040FC5F File Offset: 0x0040DE5F
		public int DungeonId { get; set; }

		// Token: 0x17008636 RID: 34358
		// (get) Token: 0x0601CD74 RID: 118132 RVA: 0x0040FC68 File Offset: 0x0040DE68
		// (set) Token: 0x0601CD75 RID: 118133 RVA: 0x0040FC70 File Offset: 0x0040DE70
		public int SeasonId { get; set; }

		// Token: 0x17008637 RID: 34359
		// (get) Token: 0x0601CD76 RID: 118134 RVA: 0x0040FC79 File Offset: 0x0040DE79
		// (set) Token: 0x0601CD77 RID: 118135 RVA: 0x0040FC81 File Offset: 0x0040DE81
		public int Inherit { get; set; }

		// Token: 0x17008638 RID: 34360
		// (get) Token: 0x0601CD78 RID: 118136 RVA: 0x0040FC8A File Offset: 0x0040DE8A
		// (set) Token: 0x0601CD79 RID: 118137 RVA: 0x0040FC92 File Offset: 0x0040DE92
		public int RoleId { get; set; }

		// Token: 0x0601CD7A RID: 118138 RVA: 0x0040FC9B File Offset: 0x0040DE9B
		public IGmRoguelikeStartInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.DungeonId = 0;
			this.SeasonId = 0;
			this.Inherit = 0;
			this.RoleId = 0;
		}
	}
}
