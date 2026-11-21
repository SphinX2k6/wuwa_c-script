using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F70 RID: 24432
	public class ISpawnMonsterStartConditionT
	{
		// Token: 0x1700B4F5 RID: 46325
		// (get) Token: 0x0602912F RID: 168239 RVA: 0x0059C1C6 File Offset: 0x0059A3C6
		// (set) Token: 0x06029130 RID: 168240 RVA: 0x0059C1CE File Offset: 0x0059A3CE
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x06029131 RID: 168241 RVA: 0x0059C1D7 File Offset: 0x0059A3D7
		public ISpawnMonsterStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
		}
	}
}
