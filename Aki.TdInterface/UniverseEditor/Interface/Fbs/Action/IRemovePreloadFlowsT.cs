using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E56 RID: 28246
	public class IRemovePreloadFlowsT
	{
		// Token: 0x1700D26C RID: 53868
		// (get) Token: 0x06031E9E RID: 204446 RVA: 0x006C0E07 File Offset: 0x006BF007
		// (set) Token: 0x06031E9F RID: 204447 RVA: 0x006C0E0F File Offset: 0x006BF00F
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700D26D RID: 53869
		// (get) Token: 0x06031EA0 RID: 204448 RVA: 0x006C0E18 File Offset: 0x006BF018
		// (set) Token: 0x06031EA1 RID: 204449 RVA: 0x006C0E20 File Offset: 0x006BF020
		public IPlayFlowT FlowId { get; set; }

		// Token: 0x06031EA2 RID: 204450 RVA: 0x006C0E29 File Offset: 0x006BF029
		public IRemovePreloadFlowsT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.FlowId = null;
		}
	}
}
