using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DA RID: 30170
	public class IRemovePreloadLinkResourceT
	{
		// Token: 0x1700DDC3 RID: 56771
		// (get) Token: 0x06034EDC RID: 216796 RVA: 0x0071CB28 File Offset: 0x0071AD28
		// (set) Token: 0x06034EDD RID: 216797 RVA: 0x0071CB30 File Offset: 0x0071AD30
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700DDC4 RID: 56772
		// (get) Token: 0x06034EDE RID: 216798 RVA: 0x0071CB39 File Offset: 0x0071AD39
		// (set) Token: 0x06034EDF RID: 216799 RVA: 0x0071CB41 File Offset: 0x0071AD41
		public int LinkResourceId { get; set; }

		// Token: 0x06034EE0 RID: 216800 RVA: 0x0071CB4A File Offset: 0x0071AD4A
		public IRemovePreloadLinkResourceT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.LinkResourceId = 0;
		}
	}
}
