using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE0 RID: 27360
	public class IMonsterNpcInteractT
	{
		// Token: 0x1700CAFC RID: 51964
		// (get) Token: 0x0602FF58 RID: 196440 RVA: 0x00685919 File Offset: 0x00683B19
		// (set) Token: 0x0602FF59 RID: 196441 RVA: 0x00685921 File Offset: 0x00683B21
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700CAFD RID: 51965
		// (get) Token: 0x0602FF5A RID: 196442 RVA: 0x0068592A File Offset: 0x00683B2A
		// (set) Token: 0x0602FF5B RID: 196443 RVA: 0x00685932 File Offset: 0x00683B32
		public int MonsterNpcEntityId { get; set; }

		// Token: 0x1700CAFE RID: 51966
		// (get) Token: 0x0602FF5C RID: 196444 RVA: 0x0068593B File Offset: 0x00683B3B
		// (set) Token: 0x0602FF5D RID: 196445 RVA: 0x00685943 File Offset: 0x00683B43
		public IMonsterNpcInteractTriggerHookT Config { get; set; }

		// Token: 0x0602FF5E RID: 196446 RVA: 0x0068594C File Offset: 0x00683B4C
		public IMonsterNpcInteractT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.MonsterNpcEntityId = 0;
			this.Config = null;
		}
	}
}
