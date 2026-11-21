using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C7B RID: 31867
	public class ITriggerMotorSkillT
	{
		// Token: 0x1700EE9A RID: 61082
		// (get) Token: 0x06039763 RID: 235363 RVA: 0x007C1C5C File Offset: 0x007BFE5C
		// (set) Token: 0x06039764 RID: 235364 RVA: 0x007C1C64 File Offset: 0x007BFE64
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700EE9B RID: 61083
		// (get) Token: 0x06039765 RID: 235365 RVA: 0x007C1C6D File Offset: 0x007BFE6D
		// (set) Token: 0x06039766 RID: 235366 RVA: 0x007C1C75 File Offset: 0x007BFE75
		public int MotorSkillId { get; set; }

		// Token: 0x06039767 RID: 235367 RVA: 0x007C1C7E File Offset: 0x007BFE7E
		public ITriggerMotorSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.MotorSkillId = 0;
		}
	}
}
