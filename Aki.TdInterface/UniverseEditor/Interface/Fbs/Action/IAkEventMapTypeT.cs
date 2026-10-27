using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006183 RID: 24963
	public class IAkEventMapTypeT
	{
		// Token: 0x1700BA26 RID: 47654
		// (get) Token: 0x0602B00C RID: 176140 RVA: 0x005EEC6A File Offset: 0x005ECE6A
		// (set) Token: 0x0602B00D RID: 176141 RVA: 0x005EEC72 File Offset: 0x005ECE72
		public EAkEventMap Type { get; set; }

		// Token: 0x0602B00E RID: 176142 RVA: 0x005EEC7B File Offset: 0x005ECE7B
		public IAkEventMapTypeT()
		{
			this.Type = EAkEventMap.PlayMapMusic;
		}
	}
}
