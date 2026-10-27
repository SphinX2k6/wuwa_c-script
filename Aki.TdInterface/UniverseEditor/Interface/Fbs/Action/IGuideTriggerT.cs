using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B9 RID: 26809
	public class IGuideTriggerT
	{
		// Token: 0x1700C6FC RID: 50940
		// (get) Token: 0x0602EC3C RID: 191548 RVA: 0x0066213B File Offset: 0x0066033B
		// (set) Token: 0x0602EC3D RID: 191549 RVA: 0x00662143 File Offset: 0x00660343
		public EGuideTriggerType Type { get; set; }

		// Token: 0x1700C6FD RID: 50941
		// (get) Token: 0x0602EC3E RID: 191550 RVA: 0x0066214C File Offset: 0x0066034C
		// (set) Token: 0x0602EC3F RID: 191551 RVA: 0x00662154 File Offset: 0x00660354
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x1700C6FE RID: 50942
		// (get) Token: 0x0602EC40 RID: 191552 RVA: 0x0066215D File Offset: 0x0066035D
		// (set) Token: 0x0602EC41 RID: 191553 RVA: 0x00662165 File Offset: 0x00660365
		public int GuideId { get; set; }

		// Token: 0x1700C6FF RID: 50943
		// (get) Token: 0x0602EC42 RID: 191554 RVA: 0x0066216E File Offset: 0x0066036E
		// (set) Token: 0x0602EC43 RID: 191555 RVA: 0x00662176 File Offset: 0x00660376
		public byte NullMask { get; set; }

		// Token: 0x0602EC44 RID: 191556 RVA: 0x0066217F File Offset: 0x0066037F
		public IGuideTriggerT()
		{
			this.Type = EGuideTriggerType.BeginnerGuide;
			this.Conditions = null;
			this.GuideId = 0;
			this.NullMask = 0;
		}
	}
}
