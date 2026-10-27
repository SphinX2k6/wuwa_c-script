using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D7A RID: 15738
	public class ICheckTrapDefenseEventBaseT
	{
		// Token: 0x17006C03 RID: 27651
		// (get) Token: 0x06015CA7 RID: 89255 RVA: 0x00324352 File Offset: 0x00322552
		// (set) Token: 0x06015CA8 RID: 89256 RVA: 0x0032435A File Offset: 0x0032255A
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x06015CA9 RID: 89257 RVA: 0x00324363 File Offset: 0x00322563
		public ICheckTrapDefenseEventBaseT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
		}
	}
}
