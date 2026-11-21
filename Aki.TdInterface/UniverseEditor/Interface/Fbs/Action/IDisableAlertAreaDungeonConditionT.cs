using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C33 RID: 27699
	public class IDisableAlertAreaDungeonConditionT
	{
		// Token: 0x1700CAF4 RID: 51956
		// (get) Token: 0x0602FAA0 RID: 195232 RVA: 0x0067E298 File Offset: 0x0067C498
		// (set) Token: 0x0602FAA1 RID: 195233 RVA: 0x0067E2A0 File Offset: 0x0067C4A0
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x1700CAF5 RID: 51957
		// (get) Token: 0x0602FAA2 RID: 195234 RVA: 0x0067E2A9 File Offset: 0x0067C4A9
		// (set) Token: 0x0602FAA3 RID: 195235 RVA: 0x0067E2B1 File Offset: 0x0067C4B1
		public int RelatedDungeonId { get; set; }

		// Token: 0x0602FAA4 RID: 195236 RVA: 0x0067E2BA File Offset: 0x0067C4BA
		public IDisableAlertAreaDungeonConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
			this.RelatedDungeonId = 0;
		}
	}
}
