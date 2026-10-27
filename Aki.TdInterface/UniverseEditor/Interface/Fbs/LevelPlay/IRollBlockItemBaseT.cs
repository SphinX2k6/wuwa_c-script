using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004591 RID: 17809
	public class IRollBlockItemBaseT
	{
		// Token: 0x17007E87 RID: 32391
		// (get) Token: 0x0601AE77 RID: 110199 RVA: 0x003D6B2E File Offset: 0x003D4D2E
		// (set) Token: 0x0601AE78 RID: 110200 RVA: 0x003D6B36 File Offset: 0x003D4D36
		public ERollBlockItemType Type { get; set; }

		// Token: 0x0601AE79 RID: 110201 RVA: 0x003D6B3F File Offset: 0x003D4D3F
		public IRollBlockItemBaseT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
		}
	}
}
