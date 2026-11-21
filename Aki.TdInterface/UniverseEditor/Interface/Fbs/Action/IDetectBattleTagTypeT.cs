using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C24 RID: 27684
	public class IDetectBattleTagTypeT
	{
		// Token: 0x1700CAE8 RID: 51944
		// (get) Token: 0x0602FA53 RID: 195155 RVA: 0x0067DC1A File Offset: 0x0067BE1A
		// (set) Token: 0x0602FA54 RID: 195156 RVA: 0x0067DC22 File Offset: 0x0067BE22
		public EDetectBattleTagType Type { get; set; }

		// Token: 0x0602FA55 RID: 195157 RVA: 0x0067DC2B File Offset: 0x0067BE2B
		public IDetectBattleTagTypeT()
		{
			this.Type = EDetectBattleTagType.MonsterOnTheGround;
		}
	}
}
