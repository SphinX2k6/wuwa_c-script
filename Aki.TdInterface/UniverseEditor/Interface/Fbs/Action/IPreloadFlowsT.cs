using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D93 RID: 28051
	public class IPreloadFlowsT
	{
		// Token: 0x1700D13F RID: 53567
		// (get) Token: 0x060318D5 RID: 202965 RVA: 0x006B7603 File Offset: 0x006B5803
		// (set) Token: 0x060318D6 RID: 202966 RVA: 0x006B760B File Offset: 0x006B580B
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700D140 RID: 53568
		// (get) Token: 0x060318D7 RID: 202967 RVA: 0x006B7614 File Offset: 0x006B5814
		// (set) Token: 0x060318D8 RID: 202968 RVA: 0x006B761C File Offset: 0x006B581C
		public IPlayFlowT FlowData { get; set; }

		// Token: 0x060318D9 RID: 202969 RVA: 0x006B7625 File Offset: 0x006B5825
		public IPreloadFlowsT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.FlowData = null;
		}
	}
}
