using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D83 RID: 15747
	public class ICheckTrapDefenseEventMonsterKilledT
	{
		// Token: 0x17006C10 RID: 27664
		// (get) Token: 0x06015CE7 RID: 89319 RVA: 0x00324B04 File Offset: 0x00322D04
		// (set) Token: 0x06015CE8 RID: 89320 RVA: 0x00324B0C File Offset: 0x00322D0C
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x17006C11 RID: 27665
		// (get) Token: 0x06015CE9 RID: 89321 RVA: 0x00324B15 File Offset: 0x00322D15
		// (set) Token: 0x06015CEA RID: 89322 RVA: 0x00324B1D File Offset: 0x00322D1D
		public int Id { get; set; }

		// Token: 0x06015CEB RID: 89323 RVA: 0x00324B26 File Offset: 0x00322D26
		public ICheckTrapDefenseEventMonsterKilledT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
			this.Id = 0;
		}
	}
}
