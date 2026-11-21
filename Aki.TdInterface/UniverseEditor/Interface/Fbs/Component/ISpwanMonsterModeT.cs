using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA0 RID: 24480
	public class ISpwanMonsterModeT
	{
		// Token: 0x1700B54F RID: 46415
		// (get) Token: 0x060292D8 RID: 168664 RVA: 0x0059F3FA File Offset: 0x0059D5FA
		// (set) Token: 0x060292D9 RID: 168665 RVA: 0x0059F402 File Offset: 0x0059D602
		public ESpawnMonsterConstraint Type { get; set; }

		// Token: 0x060292DA RID: 168666 RVA: 0x0059F40B File Offset: 0x0059D60B
		public ISpwanMonsterModeT()
		{
			this.Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
		}
	}
}
