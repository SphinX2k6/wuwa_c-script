using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C78 RID: 31864
	public class ITriggerHookPointSkillT
	{
		// Token: 0x1700EE92 RID: 61074
		// (get) Token: 0x06039747 RID: 235335 RVA: 0x007C19DA File Offset: 0x007BFBDA
		// (set) Token: 0x06039748 RID: 235336 RVA: 0x007C19E2 File Offset: 0x007BFBE2
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700EE93 RID: 61075
		// (get) Token: 0x06039749 RID: 235337 RVA: 0x007C19EB File Offset: 0x007BFBEB
		// (set) Token: 0x0603974A RID: 235338 RVA: 0x007C19F3 File Offset: 0x007BFBF3
		public int AssistCharacterId { get; set; }

		// Token: 0x1700EE94 RID: 61076
		// (get) Token: 0x0603974B RID: 235339 RVA: 0x007C19FC File Offset: 0x007BFBFC
		// (set) Token: 0x0603974C RID: 235340 RVA: 0x007C1A04 File Offset: 0x007BFC04
		public int HookEntityId { get; set; }

		// Token: 0x1700EE95 RID: 61077
		// (get) Token: 0x0603974D RID: 235341 RVA: 0x007C1A0D File Offset: 0x007BFC0D
		// (set) Token: 0x0603974E RID: 235342 RVA: 0x007C1A15 File Offset: 0x007BFC15
		public EHookTriggerType SpecTriggerType { get; set; }

		// Token: 0x1700EE96 RID: 61078
		// (get) Token: 0x0603974F RID: 235343 RVA: 0x007C1A1E File Offset: 0x007BFC1E
		// (set) Token: 0x06039750 RID: 235344 RVA: 0x007C1A26 File Offset: 0x007BFC26
		public byte NullMask { get; set; }

		// Token: 0x06039751 RID: 235345 RVA: 0x007C1A2F File Offset: 0x007BFC2F
		public ITriggerHookPointSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AssistCharacterId = 0;
			this.HookEntityId = 0;
			this.SpecTriggerType = EHookTriggerType.Motor;
			this.NullMask = 0;
		}
	}
}
