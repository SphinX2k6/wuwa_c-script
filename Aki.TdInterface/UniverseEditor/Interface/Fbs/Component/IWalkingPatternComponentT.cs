using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B48 RID: 23368
	public class IWalkingPatternComponentT
	{
		// Token: 0x1700B06C RID: 45164
		// (get) Token: 0x06027F47 RID: 163655 RVA: 0x0057E624 File Offset: 0x0057C824
		// (set) Token: 0x06027F48 RID: 163656 RVA: 0x0057E62C File Offset: 0x0057C82C
		public bool Disabled { get; set; }

		// Token: 0x1700B06D RID: 45165
		// (get) Token: 0x06027F49 RID: 163657 RVA: 0x0057E635 File Offset: 0x0057C835
		// (set) Token: 0x06027F4A RID: 163658 RVA: 0x0057E63D File Offset: 0x0057C83D
		public int SplineEntityId { get; set; }

		// Token: 0x1700B06E RID: 45166
		// (get) Token: 0x06027F4B RID: 163659 RVA: 0x0057E646 File Offset: 0x0057C846
		// (set) Token: 0x06027F4C RID: 163660 RVA: 0x0057E64E File Offset: 0x0057C84E
		public int EndEntityId { get; set; }

		// Token: 0x1700B06F RID: 45167
		// (get) Token: 0x06027F4D RID: 163661 RVA: 0x0057E657 File Offset: 0x0057C857
		// (set) Token: 0x06027F4E RID: 163662 RVA: 0x0057E65F File Offset: 0x0057C85F
		public TVarRefUnion ScoreVar { get; set; }

		// Token: 0x1700B070 RID: 45168
		// (get) Token: 0x06027F4F RID: 163663 RVA: 0x0057E668 File Offset: 0x0057C868
		// (set) Token: 0x06027F50 RID: 163664 RVA: 0x0057E670 File Offset: 0x0057C870
		public float SpineEffectExistDuration { get; set; }

		// Token: 0x1700B071 RID: 45169
		// (get) Token: 0x06027F51 RID: 163665 RVA: 0x0057E679 File Offset: 0x0057C879
		// (set) Token: 0x06027F52 RID: 163666 RVA: 0x0057E681 File Offset: 0x0057C881
		public string ReplaySpineEffect { get; set; }

		// Token: 0x1700B072 RID: 45170
		// (get) Token: 0x06027F53 RID: 163667 RVA: 0x0057E68A File Offset: 0x0057C88A
		// (set) Token: 0x06027F54 RID: 163668 RVA: 0x0057E692 File Offset: 0x0057C892
		public IWalkingPatternStayAwayConfigT StayAwayFailConfig { get; set; }

		// Token: 0x1700B073 RID: 45171
		// (get) Token: 0x06027F55 RID: 163669 RVA: 0x0057E69B File Offset: 0x0057C89B
		// (set) Token: 0x06027F56 RID: 163670 RVA: 0x0057E6A3 File Offset: 0x0057C8A3
		public byte NullMask { get; set; }

		// Token: 0x06027F57 RID: 163671 RVA: 0x0057E6AC File Offset: 0x0057C8AC
		public IWalkingPatternComponentT()
		{
			this.Disabled = false;
			this.SplineEntityId = 0;
			this.EndEntityId = 0;
			this.ScoreVar = null;
			this.SpineEffectExistDuration = 0f;
			this.ReplaySpineEffect = null;
			this.StayAwayFailConfig = null;
			this.NullMask = 0;
		}
	}
}
