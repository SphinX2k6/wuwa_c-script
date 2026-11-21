using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B29 RID: 23337
	public class IMonsterNpcInteractionGazePerformT
	{
		// Token: 0x1700AA59 RID: 43609
		// (get) Token: 0x06026626 RID: 157222 RVA: 0x0054212A File Offset: 0x0054032A
		// (set) Token: 0x06026627 RID: 157223 RVA: 0x00542132 File Offset: 0x00540332
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x06026628 RID: 157224 RVA: 0x0054213B File Offset: 0x0054033B
		public IMonsterNpcInteractionGazePerformT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
