using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F67 RID: 24423
	public class ISpawnMonsterPreConditonTypeT
	{
		// Token: 0x1700B4EB RID: 46315
		// (get) Token: 0x060290F3 RID: 168179 RVA: 0x0059BC26 File Offset: 0x00599E26
		// (set) Token: 0x060290F4 RID: 168180 RVA: 0x0059BC2E File Offset: 0x00599E2E
		public ESpawnMonsterPreCondition Type { get; set; }

		// Token: 0x060290F5 RID: 168181 RVA: 0x0059BC37 File Offset: 0x00599E37
		public ISpawnMonsterPreConditonTypeT()
		{
			this.Type = ESpawnMonsterPreCondition.DependOnPreceding;
		}
	}
}
