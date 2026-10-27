using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005963 RID: 22883
	public class ISpawnMonsterStartConditionT
	{
		// Token: 0x1700ABC1 RID: 43969
		// (get) Token: 0x06026BC5 RID: 158661 RVA: 0x0055555A File Offset: 0x0055375A
		// (set) Token: 0x06026BC6 RID: 158662 RVA: 0x00555562 File Offset: 0x00553762
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x06026BC7 RID: 158663 RVA: 0x0055556B File Offset: 0x0055376B
		public ISpawnMonsterStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
		}
	}
}
