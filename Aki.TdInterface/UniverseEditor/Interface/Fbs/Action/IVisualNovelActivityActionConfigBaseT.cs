using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D47 RID: 32071
	public class IVisualNovelActivityActionConfigBaseT
	{
		// Token: 0x1700F008 RID: 61448
		// (get) Token: 0x06039E6A RID: 237162 RVA: 0x007CF57A File Offset: 0x007CD77A
		// (set) Token: 0x06039E6B RID: 237163 RVA: 0x007CF582 File Offset: 0x007CD782
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06039E6C RID: 237164 RVA: 0x007CF58B File Offset: 0x007CD78B
		public IVisualNovelActivityActionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
