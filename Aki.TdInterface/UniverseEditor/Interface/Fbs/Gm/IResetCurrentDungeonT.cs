using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004685 RID: 18053
	public class IResetCurrentDungeonT
	{
		// Token: 0x1700802F RID: 32815
		// (get) Token: 0x0601B68D RID: 112269 RVA: 0x003E50D2 File Offset: 0x003E32D2
		// (set) Token: 0x0601B68E RID: 112270 RVA: 0x003E50DA File Offset: 0x003E32DA
		public EGmCommand Type { get; set; }

		// Token: 0x0601B68F RID: 112271 RVA: 0x003E50E3 File Offset: 0x003E32E3
		public IResetCurrentDungeonT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
