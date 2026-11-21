using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200466B RID: 18027
	public class ITrackRuleFindFirstNotMatchStateT
	{
		// Token: 0x17007E54 RID: 32340
		// (get) Token: 0x0601A747 RID: 108359 RVA: 0x003C43D3 File Offset: 0x003C25D3
		// (set) Token: 0x0601A748 RID: 108360 RVA: 0x003C43DB File Offset: 0x003C25DB
		public ETrackRuleType Type { get; set; }

		// Token: 0x17007E55 RID: 32341
		// (get) Token: 0x0601A749 RID: 108361 RVA: 0x003C43E4 File Offset: 0x003C25E4
		// (set) Token: 0x0601A74A RID: 108362 RVA: 0x003C43EC File Offset: 0x003C25EC
		public string State { get; set; }

		// Token: 0x0601A74B RID: 108363 RVA: 0x003C43F5 File Offset: 0x003C25F5
		public ITrackRuleFindFirstNotMatchStateT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
			this.State = null;
		}
	}
}
