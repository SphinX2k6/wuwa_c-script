using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC5 RID: 24005
	public class IGiantResponsePlayFlowT
	{
		// Token: 0x1700B3BA RID: 46010
		// (get) Token: 0x0602916A RID: 168298 RVA: 0x005A3E77 File Offset: 0x005A2077
		// (set) Token: 0x0602916B RID: 168299 RVA: 0x005A3E7F File Offset: 0x005A207F
		public EGiantResponseType Type { get; set; }

		// Token: 0x1700B3BB RID: 46011
		// (get) Token: 0x0602916C RID: 168300 RVA: 0x005A3E88 File Offset: 0x005A2088
		// (set) Token: 0x0602916D RID: 168301 RVA: 0x005A3E90 File Offset: 0x005A2090
		public IGiantFlowConfigT FlowConfig { get; set; }

		// Token: 0x0602916E RID: 168302 RVA: 0x005A3E99 File Offset: 0x005A2099
		public IGiantResponsePlayFlowT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
			this.FlowConfig = null;
		}
	}
}
