using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B20 RID: 23328
	public class IMonsterNpcInteractionConfigT
	{
		// Token: 0x1700AA50 RID: 43600
		// (get) Token: 0x060265E0 RID: 157152 RVA: 0x00541832 File Offset: 0x0053FA32
		// (set) Token: 0x060265E1 RID: 157153 RVA: 0x0054183A File Offset: 0x0053FA3A
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x060265E2 RID: 157154 RVA: 0x00541843 File Offset: 0x0053FA43
		public IMonsterNpcInteractionConfigT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
