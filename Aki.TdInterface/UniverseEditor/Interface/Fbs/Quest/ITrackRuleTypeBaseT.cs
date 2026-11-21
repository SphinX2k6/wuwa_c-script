using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004671 RID: 18033
	public class ITrackRuleTypeBaseT
	{
		// Token: 0x17007E5D RID: 32349
		// (get) Token: 0x0601A773 RID: 108403 RVA: 0x003C47A2 File Offset: 0x003C29A2
		// (set) Token: 0x0601A774 RID: 108404 RVA: 0x003C47AA File Offset: 0x003C29AA
		public ETrackRuleType Type { get; set; }

		// Token: 0x0601A775 RID: 108405 RVA: 0x003C47B3 File Offset: 0x003C29B3
		public ITrackRuleTypeBaseT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
		}
	}
}
