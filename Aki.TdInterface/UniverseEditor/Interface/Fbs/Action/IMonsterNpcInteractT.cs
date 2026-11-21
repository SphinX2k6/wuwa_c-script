using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007217 RID: 29207
	public class IMonsterNpcInteractT
	{
		// Token: 0x1700D5CB RID: 54731
		// (get) Token: 0x06032D2C RID: 208172 RVA: 0x006DCFD1 File Offset: 0x006DB1D1
		// (set) Token: 0x06032D2D RID: 208173 RVA: 0x006DCFD9 File Offset: 0x006DB1D9
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700D5CC RID: 54732
		// (get) Token: 0x06032D2E RID: 208174 RVA: 0x006DCFE2 File Offset: 0x006DB1E2
		// (set) Token: 0x06032D2F RID: 208175 RVA: 0x006DCFEA File Offset: 0x006DB1EA
		public int MonsterNpcEntityId { get; set; }

		// Token: 0x1700D5CD RID: 54733
		// (get) Token: 0x06032D30 RID: 208176 RVA: 0x006DCFF3 File Offset: 0x006DB1F3
		// (set) Token: 0x06032D31 RID: 208177 RVA: 0x006DCFFB File Offset: 0x006DB1FB
		public IMonsterNpcInteractTriggerHookT Config { get; set; }

		// Token: 0x06032D32 RID: 208178 RVA: 0x006DD004 File Offset: 0x006DB204
		public IMonsterNpcInteractT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.MonsterNpcEntityId = 0;
			this.Config = null;
		}
	}
}
