using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200466E RID: 18030
	public class ITrackRuleFindLastMatchStateT
	{
		// Token: 0x17007E59 RID: 32345
		// (get) Token: 0x0601A75F RID: 108383 RVA: 0x003C4607 File Offset: 0x003C2807
		// (set) Token: 0x0601A760 RID: 108384 RVA: 0x003C460F File Offset: 0x003C280F
		public ETrackRuleType Type { get; set; }

		// Token: 0x17007E5A RID: 32346
		// (get) Token: 0x0601A761 RID: 108385 RVA: 0x003C4618 File Offset: 0x003C2818
		// (set) Token: 0x0601A762 RID: 108386 RVA: 0x003C4620 File Offset: 0x003C2820
		public string State { get; set; }

		// Token: 0x0601A763 RID: 108387 RVA: 0x003C4629 File Offset: 0x003C2829
		public ITrackRuleFindLastMatchStateT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
			this.State = null;
		}
	}
}
