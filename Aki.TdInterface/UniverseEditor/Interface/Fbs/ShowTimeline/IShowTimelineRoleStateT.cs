using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC9 RID: 15305
	public class IShowTimelineRoleStateT
	{
		// Token: 0x17006908 RID: 26888
		// (get) Token: 0x0601509B RID: 86171 RVA: 0x0030CE48 File Offset: 0x0030B048
		// (set) Token: 0x0601509C RID: 86172 RVA: 0x0030CE50 File Offset: 0x0030B050
		public int RoleId { get; set; }

		// Token: 0x17006909 RID: 26889
		// (get) Token: 0x0601509D RID: 86173 RVA: 0x0030CE59 File Offset: 0x0030B059
		// (set) Token: 0x0601509E RID: 86174 RVA: 0x0030CE61 File Offset: 0x0030B061
		public ITransformT Transform { get; set; }

		// Token: 0x1700690A RID: 26890
		// (get) Token: 0x0601509F RID: 86175 RVA: 0x0030CE6A File Offset: 0x0030B06A
		// (set) Token: 0x060150A0 RID: 86176 RVA: 0x0030CE72 File Offset: 0x0030B072
		public List<int> Attributes { get; set; }

		// Token: 0x1700690B RID: 26891
		// (get) Token: 0x060150A1 RID: 86177 RVA: 0x0030CE7B File Offset: 0x0030B07B
		// (set) Token: 0x060150A2 RID: 86178 RVA: 0x0030CE83 File Offset: 0x0030B083
		public List<int> Buffs { get; set; }

		// Token: 0x1700690C RID: 26892
		// (get) Token: 0x060150A3 RID: 86179 RVA: 0x0030CE8C File Offset: 0x0030B08C
		// (set) Token: 0x060150A4 RID: 86180 RVA: 0x0030CE94 File Offset: 0x0030B094
		public List<long> BuffIds { get; set; }

		// Token: 0x1700690D RID: 26893
		// (get) Token: 0x060150A5 RID: 86181 RVA: 0x0030CE9D File Offset: 0x0030B09D
		// (set) Token: 0x060150A6 RID: 86182 RVA: 0x0030CEA5 File Offset: 0x0030B0A5
		public List<string> BuffDebugNames { get; set; }

		// Token: 0x1700690E RID: 26894
		// (get) Token: 0x060150A7 RID: 86183 RVA: 0x0030CEAE File Offset: 0x0030B0AE
		// (set) Token: 0x060150A8 RID: 86184 RVA: 0x0030CEB6 File Offset: 0x0030B0B6
		public List<string> Tags { get; set; }

		// Token: 0x060150A9 RID: 86185 RVA: 0x0030CEBF File Offset: 0x0030B0BF
		public IShowTimelineRoleStateT()
		{
			this.RoleId = 0;
			this.Transform = null;
			this.Attributes = null;
			this.Buffs = null;
			this.BuffIds = null;
			this.BuffDebugNames = null;
			this.Tags = null;
		}
	}
}
