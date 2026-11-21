using System;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004866 RID: 18534
	public class IMatchPlayerRoleT
	{
		// Token: 0x17008113 RID: 33043
		// (get) Token: 0x0601B671 RID: 112241 RVA: 0x003E1342 File Offset: 0x003DF542
		// (set) Token: 0x0601B672 RID: 112242 RVA: 0x003E134A File Offset: 0x003DF54A
		public EMatchRoleType Type { get; set; }

		// Token: 0x17008114 RID: 33044
		// (get) Token: 0x0601B673 RID: 112243 RVA: 0x003E1353 File Offset: 0x003DF553
		// (set) Token: 0x0601B674 RID: 112244 RVA: 0x003E135B File Offset: 0x003DF55B
		public bool MatchPhantomSkill { get; set; }

		// Token: 0x17008115 RID: 33045
		// (get) Token: 0x0601B675 RID: 112245 RVA: 0x003E1364 File Offset: 0x003DF564
		// (set) Token: 0x0601B676 RID: 112246 RVA: 0x003E136C File Offset: 0x003DF56C
		public byte NullMask { get; set; }

		// Token: 0x0601B677 RID: 112247 RVA: 0x003E1375 File Offset: 0x003DF575
		public IMatchPlayerRoleT()
		{
			this.Type = EMatchRoleType.Player;
			this.MatchPhantomSkill = false;
			this.NullMask = 0;
		}
	}
}
