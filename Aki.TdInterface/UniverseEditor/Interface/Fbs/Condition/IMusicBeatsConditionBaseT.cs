using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005152 RID: 20818
	public class IMusicBeatsConditionBaseT
	{
		// Token: 0x17009530 RID: 38192
		// (get) Token: 0x06020C05 RID: 134149 RVA: 0x00489566 File Offset: 0x00487766
		// (set) Token: 0x06020C06 RID: 134150 RVA: 0x0048956E File Offset: 0x0048776E
		public EMusicEventType Type { get; set; }

		// Token: 0x06020C07 RID: 134151 RVA: 0x00489577 File Offset: 0x00487777
		public IMusicBeatsConditionBaseT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
		}
	}
}
