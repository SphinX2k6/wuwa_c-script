using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065BC RID: 26044
	public class IDetectBattleTagTypeT
	{
		// Token: 0x1700C159 RID: 49497
		// (get) Token: 0x0602D2CF RID: 185039 RVA: 0x00631A56 File Offset: 0x0062FC56
		// (set) Token: 0x0602D2D0 RID: 185040 RVA: 0x00631A5E File Offset: 0x0062FC5E
		public EDetectBattleTagType Type { get; set; }

		// Token: 0x0602D2D1 RID: 185041 RVA: 0x00631A67 File Offset: 0x0062FC67
		public IDetectBattleTagTypeT()
		{
			this.Type = EDetectBattleTagType.MonsterOnTheGround;
		}
	}
}
