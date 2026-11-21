using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A45 RID: 27205
	public class IClientFollowShooterPlaySkillT
	{
		// Token: 0x1700C7E4 RID: 51172
		// (get) Token: 0x0602EAA6 RID: 191142 RVA: 0x0065C814 File Offset: 0x0065AA14
		// (set) Token: 0x0602EAA7 RID: 191143 RVA: 0x0065C81C File Offset: 0x0065AA1C
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x1700C7E5 RID: 51173
		// (get) Token: 0x0602EAA8 RID: 191144 RVA: 0x0065C825 File Offset: 0x0065AA25
		// (set) Token: 0x0602EAA9 RID: 191145 RVA: 0x0065C82D File Offset: 0x0065AA2D
		public int SkillId { get; set; }

		// Token: 0x0602EAAA RID: 191146 RVA: 0x0065C836 File Offset: 0x0065AA36
		public IClientFollowShooterPlaySkillT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.PlayAnimation;
			this.SkillId = 0;
		}
	}
}
