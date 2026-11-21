using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004233 RID: 16947
	public class IEnterDungeonT
	{
		// Token: 0x17007389 RID: 29577
		// (get) Token: 0x0601792C RID: 96556 RVA: 0x0035D122 File Offset: 0x0035B322
		// (set) Token: 0x0601792D RID: 96557 RVA: 0x0035D12A File Offset: 0x0035B32A
		public EDungeonConditionType Type { get; set; }

		// Token: 0x0601792E RID: 96558 RVA: 0x0035D133 File Offset: 0x0035B333
		public IEnterDungeonT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
		}
	}
}
