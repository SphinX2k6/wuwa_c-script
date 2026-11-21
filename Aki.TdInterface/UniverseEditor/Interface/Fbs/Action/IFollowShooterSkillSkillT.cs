using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE8 RID: 28392
	public class IFollowShooterSkillSkillT
	{
		// Token: 0x1700D031 RID: 53297
		// (get) Token: 0x060311F3 RID: 201203 RVA: 0x006A8C74 File Offset: 0x006A6E74
		// (set) Token: 0x060311F4 RID: 201204 RVA: 0x006A8C7C File Offset: 0x006A6E7C
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700D032 RID: 53298
		// (get) Token: 0x060311F5 RID: 201205 RVA: 0x006A8C85 File Offset: 0x006A6E85
		// (set) Token: 0x060311F6 RID: 201206 RVA: 0x006A8C8D File Offset: 0x006A6E8D
		public int SkillId { get; set; }

		// Token: 0x060311F7 RID: 201207 RVA: 0x006A8C96 File Offset: 0x006A6E96
		public IFollowShooterSkillSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.SkillId = 0;
		}
	}
}
