using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007485 RID: 29829
	public class ITriggerHookPointSkillT
	{
		// Token: 0x1700E274 RID: 57972
		// (get) Token: 0x0603635C RID: 222044 RVA: 0x0075EC48 File Offset: 0x0075CE48
		// (set) Token: 0x0603635D RID: 222045 RVA: 0x0075EC50 File Offset: 0x0075CE50
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700E275 RID: 57973
		// (get) Token: 0x0603635E RID: 222046 RVA: 0x0075EC59 File Offset: 0x0075CE59
		// (set) Token: 0x0603635F RID: 222047 RVA: 0x0075EC61 File Offset: 0x0075CE61
		public int HookEntityId { get; set; }

		// Token: 0x1700E276 RID: 57974
		// (get) Token: 0x06036360 RID: 222048 RVA: 0x0075EC6A File Offset: 0x0075CE6A
		// (set) Token: 0x06036361 RID: 222049 RVA: 0x0075EC72 File Offset: 0x0075CE72
		public EHookTriggerType SpecTriggerType { get; set; }

		// Token: 0x1700E277 RID: 57975
		// (get) Token: 0x06036362 RID: 222050 RVA: 0x0075EC7B File Offset: 0x0075CE7B
		// (set) Token: 0x06036363 RID: 222051 RVA: 0x0075EC83 File Offset: 0x0075CE83
		public byte NullMask { get; set; }

		// Token: 0x06036364 RID: 222052 RVA: 0x0075EC8C File Offset: 0x0075CE8C
		public ITriggerHookPointSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.HookEntityId = 0;
			this.SpecTriggerType = EHookTriggerType.Motor;
			this.NullMask = 0;
		}
	}
}
