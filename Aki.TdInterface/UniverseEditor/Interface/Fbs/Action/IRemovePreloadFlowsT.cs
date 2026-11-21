using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D7 RID: 30167
	public class IRemovePreloadFlowsT
	{
		// Token: 0x1700DDBE RID: 56766
		// (get) Token: 0x06034EC6 RID: 216774 RVA: 0x0071C907 File Offset: 0x0071AB07
		// (set) Token: 0x06034EC7 RID: 216775 RVA: 0x0071C90F File Offset: 0x0071AB0F
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700DDBF RID: 56767
		// (get) Token: 0x06034EC8 RID: 216776 RVA: 0x0071C918 File Offset: 0x0071AB18
		// (set) Token: 0x06034EC9 RID: 216777 RVA: 0x0071C920 File Offset: 0x0071AB20
		public IPlayFlowT FlowId { get; set; }

		// Token: 0x06034ECA RID: 216778 RVA: 0x0071C929 File Offset: 0x0071AB29
		public IRemovePreloadFlowsT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.FlowId = null;
		}
	}
}
