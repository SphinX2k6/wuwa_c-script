using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004191 RID: 16785
	public class ICheckTrapDefenseEventBaseT
	{
		// Token: 0x170071BD RID: 29117
		// (get) Token: 0x060171DF RID: 94687 RVA: 0x0034B5CA File Offset: 0x003497CA
		// (set) Token: 0x060171E0 RID: 94688 RVA: 0x0034B5D2 File Offset: 0x003497D2
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x060171E1 RID: 94689 RVA: 0x0034B5DB File Offset: 0x003497DB
		public ICheckTrapDefenseEventBaseT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
		}
	}
}
