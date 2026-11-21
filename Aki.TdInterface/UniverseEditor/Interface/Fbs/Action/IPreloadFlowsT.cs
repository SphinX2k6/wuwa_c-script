using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750E RID: 29966
	public class IPreloadFlowsT
	{
		// Token: 0x1700DC87 RID: 56455
		// (get) Token: 0x060348D1 RID: 215249 RVA: 0x00712CEB File Offset: 0x00710EEB
		// (set) Token: 0x060348D2 RID: 215250 RVA: 0x00712CF3 File Offset: 0x00710EF3
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700DC88 RID: 56456
		// (get) Token: 0x060348D3 RID: 215251 RVA: 0x00712CFC File Offset: 0x00710EFC
		// (set) Token: 0x060348D4 RID: 215252 RVA: 0x00712D04 File Offset: 0x00710F04
		public IPlayFlowT FlowData { get; set; }

		// Token: 0x060348D5 RID: 215253 RVA: 0x00712D0D File Offset: 0x00710F0D
		public IPreloadFlowsT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.FlowData = null;
		}
	}
}
