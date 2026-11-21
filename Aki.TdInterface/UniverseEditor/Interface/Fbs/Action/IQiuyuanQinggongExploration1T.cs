using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755C RID: 30044
	public class IQiuyuanQinggongExploration1T
	{
		// Token: 0x1700DCF8 RID: 56568
		// (get) Token: 0x06034AF9 RID: 215801 RVA: 0x00716212 File Offset: 0x00714412
		// (set) Token: 0x06034AFA RID: 215802 RVA: 0x0071621A File Offset: 0x0071441A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034AFB RID: 215803 RVA: 0x00716223 File Offset: 0x00714423
		public IQiuyuanQinggongExploration1T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
