using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200514F RID: 20815
	public class IMonsterBuffContainerT
	{
		// Token: 0x1700952C RID: 38188
		// (get) Token: 0x06020BF1 RID: 134129 RVA: 0x004893C8 File Offset: 0x004875C8
		// (set) Token: 0x06020BF2 RID: 134130 RVA: 0x004893D0 File Offset: 0x004875D0
		public ETargetBuffContainer Type { get; set; }

		// Token: 0x1700952D RID: 38189
		// (get) Token: 0x06020BF3 RID: 134131 RVA: 0x004893D9 File Offset: 0x004875D9
		// (set) Token: 0x06020BF4 RID: 134132 RVA: 0x004893E1 File Offset: 0x004875E1
		public int MonsterEntityId { get; set; }

		// Token: 0x06020BF5 RID: 134133 RVA: 0x004893EA File Offset: 0x004875EA
		public IMonsterBuffContainerT()
		{
			this.Type = ETargetBuffContainer.Monster;
			this.MonsterEntityId = 0;
		}
	}
}
