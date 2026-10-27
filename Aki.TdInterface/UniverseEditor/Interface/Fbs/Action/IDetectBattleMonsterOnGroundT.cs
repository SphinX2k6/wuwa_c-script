using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B0 RID: 26032
	public class IDetectBattleMonsterOnGroundT
	{
		// Token: 0x1700C148 RID: 49480
		// (get) Token: 0x0602D281 RID: 184961 RVA: 0x006312BA File Offset: 0x0062F4BA
		// (set) Token: 0x0602D282 RID: 184962 RVA: 0x006312C2 File Offset: 0x0062F4C2
		public EDetectBattleTagType Type { get; set; }

		// Token: 0x0602D283 RID: 184963 RVA: 0x006312CB File Offset: 0x0062F4CB
		public IDetectBattleMonsterOnGroundT()
		{
			this.Type = EDetectBattleTagType.MonsterOnTheGround;
		}
	}
}
