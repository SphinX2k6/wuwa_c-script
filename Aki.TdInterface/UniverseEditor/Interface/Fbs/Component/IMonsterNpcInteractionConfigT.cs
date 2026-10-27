using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005582 RID: 21890
	public class IMonsterNpcInteractionConfigT
	{
		// Token: 0x1700A1C8 RID: 41416
		// (get) Token: 0x060243D3 RID: 148435 RVA: 0x005012BA File Offset: 0x004FF4BA
		// (set) Token: 0x060243D4 RID: 148436 RVA: 0x005012C2 File Offset: 0x004FF4C2
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x060243D5 RID: 148437 RVA: 0x005012CB File Offset: 0x004FF4CB
		public IMonsterNpcInteractionConfigT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
