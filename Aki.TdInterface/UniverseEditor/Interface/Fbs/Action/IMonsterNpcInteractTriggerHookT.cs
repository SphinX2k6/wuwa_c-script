using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE9 RID: 27369
	public class IMonsterNpcInteractTriggerHookT
	{
		// Token: 0x1700CB07 RID: 51975
		// (get) Token: 0x0602FF8E RID: 196494 RVA: 0x00685DD8 File Offset: 0x00683FD8
		// (set) Token: 0x0602FF8F RID: 196495 RVA: 0x00685DE0 File Offset: 0x00683FE0
		public EMonsterNpcInteractType Type { get; set; }

		// Token: 0x1700CB08 RID: 51976
		// (get) Token: 0x0602FF90 RID: 196496 RVA: 0x00685DE9 File Offset: 0x00683FE9
		// (set) Token: 0x0602FF91 RID: 196497 RVA: 0x00685DF1 File Offset: 0x00683FF1
		public int HookEntityId { get; set; }

		// Token: 0x0602FF92 RID: 196498 RVA: 0x00685DFA File Offset: 0x00683FFA
		public IMonsterNpcInteractTriggerHookT()
		{
			this.Type = EMonsterNpcInteractType.TriggerHook;
			this.HookEntityId = 0;
		}
	}
}
