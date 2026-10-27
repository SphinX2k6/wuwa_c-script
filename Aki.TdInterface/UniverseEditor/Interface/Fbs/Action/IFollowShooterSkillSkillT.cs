using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006853 RID: 26707
	public class IFollowShooterSkillSkillT
	{
		// Token: 0x1700C65D RID: 50781
		// (get) Token: 0x0602E90D RID: 190733 RVA: 0x0065A408 File Offset: 0x00658608
		// (set) Token: 0x0602E90E RID: 190734 RVA: 0x0065A410 File Offset: 0x00658610
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C65E RID: 50782
		// (get) Token: 0x0602E90F RID: 190735 RVA: 0x0065A419 File Offset: 0x00658619
		// (set) Token: 0x0602E910 RID: 190736 RVA: 0x0065A421 File Offset: 0x00658621
		public int SkillId { get; set; }

		// Token: 0x0602E911 RID: 190737 RVA: 0x0065A42A File Offset: 0x0065862A
		public IFollowShooterSkillSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.SkillId = 0;
		}
	}
}
