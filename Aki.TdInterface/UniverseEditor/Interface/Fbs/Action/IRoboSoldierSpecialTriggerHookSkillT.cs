using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765E RID: 30302
	public class IRoboSoldierSpecialTriggerHookSkillT
	{
		// Token: 0x1700DE7F RID: 56959
		// (get) Token: 0x060352A7 RID: 217767 RVA: 0x00723214 File Offset: 0x00721414
		// (set) Token: 0x060352A8 RID: 217768 RVA: 0x0072321C File Offset: 0x0072141C
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700DE80 RID: 56960
		// (get) Token: 0x060352A9 RID: 217769 RVA: 0x00723225 File Offset: 0x00721425
		// (set) Token: 0x060352AA RID: 217770 RVA: 0x0072322D File Offset: 0x0072142D
		public int HookEntityId { get; set; }

		// Token: 0x060352AB RID: 217771 RVA: 0x00723236 File Offset: 0x00721436
		public IRoboSoldierSpecialTriggerHookSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.HookEntityId = 0;
		}
	}
}
