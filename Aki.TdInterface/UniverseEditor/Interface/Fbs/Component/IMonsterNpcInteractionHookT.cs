using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558E RID: 21902
	public class IMonsterNpcInteractionHookT
	{
		// Token: 0x1700A1D4 RID: 41428
		// (get) Token: 0x0602442B RID: 148523 RVA: 0x00501D2A File Offset: 0x004FFF2A
		// (set) Token: 0x0602442C RID: 148524 RVA: 0x00501D32 File Offset: 0x004FFF32
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602442D RID: 148525 RVA: 0x00501D3B File Offset: 0x004FFF3B
		public IMonsterNpcInteractionHookT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
