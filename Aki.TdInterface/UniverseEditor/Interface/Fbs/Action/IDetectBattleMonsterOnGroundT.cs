using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C18 RID: 27672
	public class IDetectBattleMonsterOnGroundT
	{
		// Token: 0x1700CAD7 RID: 51927
		// (get) Token: 0x0602FA05 RID: 195077 RVA: 0x0067D47E File Offset: 0x0067B67E
		// (set) Token: 0x0602FA06 RID: 195078 RVA: 0x0067D486 File Offset: 0x0067B686
		public EDetectBattleTagType Type { get; set; }

		// Token: 0x0602FA07 RID: 195079 RVA: 0x0067D48F File Offset: 0x0067B68F
		public IDetectBattleMonsterOnGroundT()
		{
			this.Type = EDetectBattleTagType.MonsterOnTheGround;
		}
	}
}
