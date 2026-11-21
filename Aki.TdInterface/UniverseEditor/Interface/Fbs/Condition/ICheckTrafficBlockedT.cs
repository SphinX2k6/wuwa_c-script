using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200504A RID: 20554
	public class ICheckTrafficBlockedT
	{
		// Token: 0x1700931C RID: 37660
		// (get) Token: 0x06020209 RID: 131593 RVA: 0x00474D73 File Offset: 0x00472F73
		// (set) Token: 0x0602020A RID: 131594 RVA: 0x00474D7B File Offset: 0x00472F7B
		public ECondition Type { get; set; }

		// Token: 0x1700931D RID: 37661
		// (get) Token: 0x0602020B RID: 131595 RVA: 0x00474D84 File Offset: 0x00472F84
		// (set) Token: 0x0602020C RID: 131596 RVA: 0x00474D8C File Offset: 0x00472F8C
		public bool IsBlocked { get; set; }

		// Token: 0x1700931E RID: 37662
		// (get) Token: 0x0602020D RID: 131597 RVA: 0x00474D95 File Offset: 0x00472F95
		// (set) Token: 0x0602020E RID: 131598 RVA: 0x00474D9D File Offset: 0x00472F9D
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700931F RID: 37663
		// (get) Token: 0x0602020F RID: 131599 RVA: 0x00474DA6 File Offset: 0x00472FA6
		// (set) Token: 0x06020210 RID: 131600 RVA: 0x00474DAE File Offset: 0x00472FAE
		public ITrafficMatchTargetT MatchTarget { get; set; }

		// Token: 0x06020211 RID: 131601 RVA: 0x00474DB7 File Offset: 0x00472FB7
		public ICheckTrafficBlockedT()
		{
			this.Type = ECondition.CompareVar;
			this.IsBlocked = false;
			this.Target = null;
			this.MatchTarget = null;
		}
	}
}
