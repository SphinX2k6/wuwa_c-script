using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE3 RID: 27363
	public class IMonsterNpcInteractConfigBaseT
	{
		// Token: 0x1700CB01 RID: 51969
		// (get) Token: 0x0602FF6E RID: 196462 RVA: 0x00685B02 File Offset: 0x00683D02
		// (set) Token: 0x0602FF6F RID: 196463 RVA: 0x00685B0A File Offset: 0x00683D0A
		public EMonsterNpcInteractType Type { get; set; }

		// Token: 0x0602FF70 RID: 196464 RVA: 0x00685B13 File Offset: 0x00683D13
		public IMonsterNpcInteractConfigBaseT()
		{
			this.Type = EMonsterNpcInteractType.TriggerHook;
		}
	}
}
