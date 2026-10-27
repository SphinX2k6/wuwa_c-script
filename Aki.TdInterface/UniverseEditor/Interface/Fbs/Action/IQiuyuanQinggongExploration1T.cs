using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE1 RID: 28129
	public class IQiuyuanQinggongExploration1T
	{
		// Token: 0x1700D1B0 RID: 53680
		// (get) Token: 0x06031AFD RID: 203517 RVA: 0x006BAB2A File Offset: 0x006B8D2A
		// (set) Token: 0x06031AFE RID: 203518 RVA: 0x006BAB32 File Offset: 0x006B8D32
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031AFF RID: 203519 RVA: 0x006BAB3B File Offset: 0x006B8D3B
		public IQiuyuanQinggongExploration1T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
