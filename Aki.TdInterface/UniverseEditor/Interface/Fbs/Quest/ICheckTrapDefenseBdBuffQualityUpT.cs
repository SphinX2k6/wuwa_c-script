using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D77 RID: 15735
	public class ICheckTrapDefenseBdBuffQualityUpT
	{
		// Token: 0x17006C00 RID: 27648
		// (get) Token: 0x06015C95 RID: 89237 RVA: 0x003241DA File Offset: 0x003223DA
		// (set) Token: 0x06015C96 RID: 89238 RVA: 0x003241E2 File Offset: 0x003223E2
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x06015C97 RID: 89239 RVA: 0x003241EB File Offset: 0x003223EB
		public ICheckTrapDefenseBdBuffQualityUpT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
		}
	}
}
