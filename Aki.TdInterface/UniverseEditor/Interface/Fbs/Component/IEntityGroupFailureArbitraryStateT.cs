using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517E RID: 20862
	public class IEntityGroupFailureArbitraryStateT
	{
		// Token: 0x1700986F RID: 39023
		// (get) Token: 0x06021BBF RID: 138175 RVA: 0x004AE64F File Offset: 0x004AC84F
		// (set) Token: 0x06021BC0 RID: 138176 RVA: 0x004AE657 File Offset: 0x004AC857
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x17009870 RID: 39024
		// (get) Token: 0x06021BC1 RID: 138177 RVA: 0x004AE660 File Offset: 0x004AC860
		// (set) Token: 0x06021BC2 RID: 138178 RVA: 0x004AE668 File Offset: 0x004AC868
		public string State { get; set; }

		// Token: 0x06021BC3 RID: 138179 RVA: 0x004AE671 File Offset: 0x004AC871
		public IEntityGroupFailureArbitraryStateT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
			this.State = null;
		}
	}
}
