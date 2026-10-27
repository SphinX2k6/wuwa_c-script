using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDA RID: 28378
	public class IRoboSoldierSpecialTriggerHookSkillT
	{
		// Token: 0x1700D328 RID: 54056
		// (get) Token: 0x06032267 RID: 205415 RVA: 0x006C74E0 File Offset: 0x006C56E0
		// (set) Token: 0x06032268 RID: 205416 RVA: 0x006C74E8 File Offset: 0x006C56E8
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700D329 RID: 54057
		// (get) Token: 0x06032269 RID: 205417 RVA: 0x006C74F1 File Offset: 0x006C56F1
		// (set) Token: 0x0603226A RID: 205418 RVA: 0x006C74F9 File Offset: 0x006C56F9
		public int HookEntityId { get; set; }

		// Token: 0x0603226B RID: 205419 RVA: 0x006C7502 File Offset: 0x006C5702
		public IRoboSoldierSpecialTriggerHookSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.HookEntityId = 0;
		}
	}
}
