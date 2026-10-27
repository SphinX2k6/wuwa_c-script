using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005993 RID: 22931
	public class ISpwanMonsterModeT
	{
		// Token: 0x1700AC1B RID: 44059
		// (get) Token: 0x06026D6E RID: 159086 RVA: 0x0055878E File Offset: 0x0055698E
		// (set) Token: 0x06026D6F RID: 159087 RVA: 0x00558796 File Offset: 0x00556996
		public ESpawnMonsterConstraint Type { get; set; }

		// Token: 0x06026D70 RID: 159088 RVA: 0x0055879F File Offset: 0x0055699F
		public ISpwanMonsterModeT()
		{
			this.Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
		}
	}
}
