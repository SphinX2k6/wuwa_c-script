using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F3 RID: 21491
	public class IIndependentSystemRewardTypeT
	{
		// Token: 0x17009E2B RID: 40491
		// (get) Token: 0x060234B7 RID: 144567 RVA: 0x004E2F2E File Offset: 0x004E112E
		// (set) Token: 0x060234B8 RID: 144568 RVA: 0x004E2F36 File Offset: 0x004E1136
		public EIndependentSystemRewardType Type { get; set; }

		// Token: 0x060234B9 RID: 144569 RVA: 0x004E2F3F File Offset: 0x004E113F
		public IIndependentSystemRewardTypeT()
		{
			this.Type = EIndependentSystemRewardType.DarkTide;
		}
	}
}
