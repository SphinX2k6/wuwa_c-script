using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F61 RID: 24417
	public class ISpawnMonsterConstraintAnnularSectorT
	{
		// Token: 0x1700B4E0 RID: 46304
		// (get) Token: 0x060290C5 RID: 168133 RVA: 0x0059B798 File Offset: 0x00599998
		// (set) Token: 0x060290C6 RID: 168134 RVA: 0x0059B7A0 File Offset: 0x005999A0
		public ESpawnMonsterConstraint Type { get; set; }

		// Token: 0x1700B4E1 RID: 46305
		// (get) Token: 0x060290C7 RID: 168135 RVA: 0x0059B7A9 File Offset: 0x005999A9
		// (set) Token: 0x060290C8 RID: 168136 RVA: 0x0059B7B1 File Offset: 0x005999B1
		public float InnerRadius { get; set; }

		// Token: 0x1700B4E2 RID: 46306
		// (get) Token: 0x060290C9 RID: 168137 RVA: 0x0059B7BA File Offset: 0x005999BA
		// (set) Token: 0x060290CA RID: 168138 RVA: 0x0059B7C2 File Offset: 0x005999C2
		public float OuterRadius { get; set; }

		// Token: 0x1700B4E3 RID: 46307
		// (get) Token: 0x060290CB RID: 168139 RVA: 0x0059B7CB File Offset: 0x005999CB
		// (set) Token: 0x060290CC RID: 168140 RVA: 0x0059B7D3 File Offset: 0x005999D3
		public float Angle { get; set; }

		// Token: 0x060290CD RID: 168141 RVA: 0x0059B7DC File Offset: 0x005999DC
		public ISpawnMonsterConstraintAnnularSectorT()
		{
			this.Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
			this.InnerRadius = 0f;
			this.OuterRadius = 0f;
			this.Angle = 0f;
		}
	}
}
