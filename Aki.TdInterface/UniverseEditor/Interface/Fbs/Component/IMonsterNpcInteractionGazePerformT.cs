using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558B RID: 21899
	public class IMonsterNpcInteractionGazePerformT
	{
		// Token: 0x1700A1D1 RID: 41425
		// (get) Token: 0x06024419 RID: 148505 RVA: 0x00501BB2 File Offset: 0x004FFDB2
		// (set) Token: 0x0602441A RID: 148506 RVA: 0x00501BBA File Offset: 0x004FFDBA
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602441B RID: 148507 RVA: 0x00501BC3 File Offset: 0x004FFDC3
		public IMonsterNpcInteractionGazePerformT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
